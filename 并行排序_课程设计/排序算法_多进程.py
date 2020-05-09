import os
from random import randint
from progressbar import *
import multiprocessing
import copy

process_count = 4  # 设置进程数量
partition_size = 50000  # 子数组的长度
partition_list = []  # 用于记录分组情况


# 插入排序算法，对arr[l...r]范围内的元素进行排序
def insertionSort(arr, l, r):
    for i in range(l, r + 1):
        v = arr[i]
        j = 0
        for j in reversed(range(l, i + 1)):
            if (v >= arr[j - 1]):
                break
            arr[j] = arr[j - 1]
        arr[j] = v


# 对arr[l...r]部分进行partition操作
# 返回p，使得arr[l...p-1]<arr[p]arr[p+1...r]>arr[p]
def __partition(arr, l, r):
    # 随机选择标定元素，以解决遇到近乎有序的数组时，性能下降的问题
    rand_num = randint(l, r)
    arr[l], arr[rand_num] = arr[rand_num], arr[l]
    v = arr[l]  # 选则第一个元素为标定元素

    # arr[l+1...j]<varr[j+1...i] >v
    j = l
    for i in range(l + 1, r + 1):  # 遍历arr[l+1]~arr[r]
        if (arr[i] < v):
            j += 1
            arr[i], arr[j] = arr[j], arr[i]  # 调整顺序

    arr[l], arr[j] = arr[j], arr[l]  # 最终调整顺序，将arr[l]放到它应在的位置上
    return j


def __quickSort(arr, l, r):  # arr:数字列表,l:左边界,r:右边界
    # 当数组小到一定程度时，用插入排序算法效率更高
    if (r - l <= 15):
        insertionSort(arr, l, r)
        return

    # p为分界点，划分为小于arr[p]和大于arr[p]两段
    p = __partition(arr, l, r)

    __quickSort(arr, l, p - 1)
    __quickSort(arr, p + 1, r)


# 快速排序算法,，对arr[l...r]范围内的元素进行排序
def quickSort(arr, l, r):
    time_start = time.time()  # 开始时间
    __quickSort(arr, l, r)
    time_end = time.time()  # 结束时间
    partition_list.append(arr[l:r + 1])  # 将分段保存到partition_list
    print('进程{0}耗时:{1}s'.format(multiprocessing.current_process().name, '%.2f' % (time_end - time_start)))


def __merge(arr, l, mid, r):
    aux = []
    for i in range(l, r + 1):
        aux.append(arr[i])

    i, j = l, mid + 1
    for k in range(l, r + 1):
        if (i > mid):
            arr[k] = aux[j - l]
            j += 1
        elif (j > r):
            arr[k] = aux[i - l]
            i += 1
        elif (aux[i - l] < aux[j - l]):
            arr[k] = aux[i - l]
            i += 1
        else:
            arr[k] = aux[j - l]
            j += 1


def __mergeSort(arr, l, r):
    if (r - l <= 15):
        insertionSort(arr, l, r)
        return

    mid = (r - l) // 2 + l
    __mergeSort(arr, l, mid)
    __mergeSort(arr, mid + 1, r)

    # arr[l...mid]与arr[mid+1...r]是两段有序数组
    # 即：arr[mid] <= arr[mid + 1]时arr[l...r]有序，不必要继续执行
    if (arr[mid] > arr[mid + 1]):
        __merge(arr, l, mid, r)


# 可设定mid的mergeSort函数
def __mergeSort_mid(arr, l, mid, r):
    if (r - l <= 15):
        insertionSort(arr, l, r)
        return

    __mergeSort(arr, l, mid)
    __mergeSort(arr, mid + 1, r)

    # arr[l...mid]与arr[mid+1...r]是两段有序数组
    # 即：arr[mid] <= arr[mid + 1]时arr[l...r]有序，不必要继续执行
    if (arr[mid] > arr[mid + 1]):
        __merge(arr, l, mid, r)


# 归并排序
def mergeSort(arr, n):
    __mergeSort(arr, 0, n - 1)


# 检验排序的正确性(从小到大)
def checkArray(arr):
    print("验证排序正确性...")
    progress = ProgressBar()  # 进度条
    for i in progress(range(len(arr) - 1)):
        if (arr[i] > arr[i + 1]):
            print("排序错误！{0}号为{1},{2}号为{3}".format(i, arr[i], i + 1, arr[i + 1]))

    print("已验证：排序正确!")


def merge_task(list1, list2):
    print(semaphore)
    semaphore.acquire()
    semaphore.acquire()
    item1 = partition_list.pop(0)
    item2 = partition_list.pop(0)
    list = list1 + list2
    __mergeSort_mid(list, 0, len(list1), len(list1) + len(list2) - 1)
    partition_list.append(list)
    semaphore.release()


if __name__ == "__main__":
    os.system("cls")  # 运行前清屏
    sys.setrecursionlimit(3000)  # 设置最大递归深度为3000

    print("使用进程数:{0}\n".format(process_count))
    # 1.从txt文件读取待排序数组，用list_total存放
    print("正在读入文件...")
    time_start = time.time()  # 开始时间
    with open("input.txt", "r") as file:
        list_total = file.readlines()[0].split(" ")[:-1]  # 去掉末尾的空格符号
        progress = ProgressBar()
        for i in progress(range(len(list_total))):
            list_total[i] = int(list_total[i])
    time_end = time.time()  # 结束时间
    print("读入数据{0}条".format(len(list_total)))
    print('读入文件耗时:{0}s\n'.format('%.2f' % (time_end - time_start)))

    list_total_copy = copy.deepcopy(list_total)  # 拷贝一份,用于做对比

    # 2.1. 多进程排序(快速排序)
    print("正在进行多进程快速排序...")
    if (partition_size >= len(list_total)):  # 当小分区设置成比总数还大
        partition_size = len(list_total) // process_count
        partition_count = process_count
    else:
        partition_count = len(list_total) // partition_size

    time_start = time.time()  # 开始时间
    pool = multiprocessing.Pool(process_count)  # 创建进程池
    # 创建进程
    for i in range(partition_count):
        if (i != partition_count):
            pool.apply_async(quickSort, args=(list_total, i * partition_size, (i + 1) * partition_size - 1))
        else:
            pool.apply_async(quickSort, args=(list_total, i * partition_size, len(list_total) - 1))

    pool.close()
    pool.join()  # 等待子进程全部运行完毕
    time_end = time.time()  # 结束时间
    time_total_mul = time_end - time_start  # 多进程排序耗时
    print('多进程排序耗时:{0}s\n'.format('%.2f' % time_total_mul))

    # 2.2. 单线程排序(快速排序)
    print("正在进行单线程快速排序...")
    time_start = time.time()  # 开始时间
    for i in range(partition_count):
        if (i != partition_count):
            quickSort(list_total_copy, i * partition_size, (i + 1) * partition_size - 1)
        else:
            quickSort(list_total_copy, i * partition_size, len(list_total) - 1)
    time_end = time.time()  # 结束时间
    time_total_single = time_end - time_start  # 单线程排序耗时
    print('单线程排序耗时:{0}s\n'.format('%.2f' % time_total_single))

    # 2.3 对比多进程排序与多进程排序
    print("多进程总耗时：{0}".format('%.2f' % time_total_mul))
    print("单线程总耗时：{0}".format('%.2f' % time_total_single))
    print("性能提升:{0}%\n".format(round((time_total_single / time_total_mul - 1) * 100, 1)))

    # 3.0.最终执行归并排序(失败的)
    print("正在进行单线程归并排序...")
    time_start = time.time()  # 开始时间
    mergeSort(list_total, len(list_total))
    time_end = time.time()  # 结束时间
    print('单线程归并排序耗时:{0}s\n'.format('%.2f' % (time_end - time_start)))

    # 3.最终执行归并排序
    print("正在进行多进程归并排序...")
    time_start = time.time()  # 开始时间
    pool = multiprocessing.Pool(process_count)  # 创建进程池
    progress = ProgressBar()  # 进度条
    semaphore = multiprocessing.Semaphore(len(partition_list))  # 信号量
    for i in progress(range(len(partition_list) - 1)):  # 10段需要9次合并
        pool.apply_async(merge_task)
    pool.close()
    pool.join()
    time_end = time.time()  # 结束时间
    print('多进程归并排序耗时:{0}s\n'.format('%.2f' % (time_end - time_start)))

    # 4.检查程序正确性
    checkArray(partition_list[0])
    print()

    # 5.保存排序结果
    print("正在保存排序结果...")
    time_start = time.time()  # 开始时间
    with open("output.txt", "w") as file:
        progress = ProgressBar()  # 进度条
        for i in progress(list_total):
            file.writelines(str(i) + " ")  # 写入文件
    time_end = time.time()  # 结束时间
    print('保存排序结果耗时:{0}s\n'.format('%.2f' % (time_end - time_start)))

    print("--------------------已全部运行完毕--------------------")
