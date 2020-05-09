import os
from random import randint
from progressbar import *
import threading
import copy

thread_count = 4  # 设置线程数量
semaphore = threading.Semaphore(thread_count)  # 设置信号量，用于限定同时运行的线程数量
partition_size = 50000  # 子数组的长度


def testThread():  # 模拟一个IO密集型任务
    time_start = time.time()  # 开始时间
    time.sleep(1.5)
    time_end = time.time()  # 结束时间
    print('线程{0}耗时:{1}s'.format(threading.currentThread().name, '%.2f' % (time_end - time_start)))
    semaphore.release()  # 释放信号量


if __name__ == "__main__":
    os.system("cls")  # 运行前清屏

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

    # 2.1. 多线程排序(快速排序)
    print("正在进行多线程快速排序...")
    if (partition_size >= len(list_total)):  # 当小分区设置成比总数还大
        partition_size = len(list_total) // thread_count
        partition_count = thread_count
    else:
        partition_count = len(list_total) // partition_size

    time_start = time.time()  # 开始时间
    threads = []
    # 创建线程
    for i in range(partition_count):
        t = threading.Thread(target=testThread)  # 测试用
        threads.append(t)
    # 启动线程
    for t in threads:
        semaphore.acquire()  # 获得信号量
        t.start()
    # 等待所有子线程运行完毕
    for t in threads:
        t.join()
    time_end = time.time()  # 结束时间
    time_total_mul = time_end - time_start  # 多线程排序耗时
    print('多线程排序耗时:{0}s\n'.format('%.2f' % time_total_mul))

    # 2.2. 单线程排序(快速排序)
    print("正在进行单线程快速排序...")
    time_start = time.time()  # 开始时间
    for i in range(partition_count):
        testThread()  # 测试用
    time_end = time.time()  # 结束时间
    time_total_single = time_end - time_start  # 单线程排序耗时
    print('单线程排序耗时:{0}s\n'.format('%.2f' % time_total_single))

    # 2.3 对比多线程排序与多线程排序
    print("多线程总耗时：{0}".format('%.2f' % time_total_mul))
    print("单线程总耗时：{0}".format('%.2f' % time_total_single))
    print("性能提升:{0}%\n".format(round((time_total_single / time_total_mul - 1) * 100, 1)))

    print("--------------------已全部运行完毕--------------------")
