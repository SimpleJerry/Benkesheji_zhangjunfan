import os
from random import randint
from progressbar import *
import multiprocessing
import copy

process_count = 4  # 设置进程数量
partition_size = 10000  # 子数组的长度


def testProcess():  # 模拟一个IO密集型任务
    time_start = time.time()  # 开始时间
    time.sleep(1.5)
    time_end = time.time()  # 结束时间
    print('进程{0}耗时:{1}s'.format(multiprocessing.current_process().name, '%.2f' % (time_end - time_start)))


if __name__ == "__main__":
    os.system("cls")  # 运行前清屏
    sys.setrecursionlimit(3000)  # 设置最大递归深度为3000

    # 1.从txt文件读取待排序数组，用list_total存放
    print("正在读入文件...")
    time_start = time.time()  # 开始时间
    with open("input.txt", "r") as file:
        list_total = file.readlines()[0].split(" ")[:-1]  # 去掉末尾的空格符号
        progress = ProgressBar()
        for i in progress(range(len(list_total))):
            list_total[i] = int(list_total[i])
    time_end = time.time()  # 结束时间
    print('读入文件耗时:{0}s\n'.format('%.2f' % (time_end - time_start)))

    # 2.1. 多进程排序(快速排序)
    print("正在进行多进程快速排序...")
    if (partition_size >= len(list_total)):  # 当小分区设置成比总数还大
        partition_size = len(list_total) // process_count
        partition_count = process_count
    else:
        partition_count = len(list_total) // partition_size

    time_start = time.time()  # 开始时间
    pool = multiprocessing.Pool(process_count)  # 创建进程池
    # 运行进程
    for i in range(partition_count):
        pool.apply_async(testProcess)
    pool.close()
    pool.join()  # 等待子进程全部运行完毕
    time_end = time.time()  # 结束时间
    time_total_mul = time_end - time_start  # 多进程排序耗时
    print('多进程排序耗时:{0}s\n'.format('%.2f' % time_total_mul))

    # 2.2. 单进程排序(快速排序)
    print("正在进行单进程快速排序...")
    time_start = time.time()  # 开始时间
    for i in range(partition_count):
        testProcess()
    time_end = time.time()  # 结束时间
    time_total_single = time_end - time_start  # 单进程排序耗时
    print('单进程排序耗时:{0}s\n'.format('%.2f' % time_total_single))

    # 2.3 对比多进程排序与多进程排序
    print("多进程总耗时：{0}".format('%.2f' % time_total_mul))
    print("单进程总耗时：{0}".format('%.2f' % time_total_single))
    print("性能提升:{0}%\n".format(round((time_total_single / time_total_mul - 1) * 100, 1)))

    print("--------------------已全部运行完毕--------------------")
