import os
from random import randint
from progressbar import *


def main(min, max, count):
    time_start = time.time()  # 开始时间
    with open("input.txt", "w") as file:
        progress = ProgressBar()  # 进度条
        for i in progress(range(count)):
            rand_num = randint(min, max)  # 所指定范围内的随机整数
            file.writelines(str(rand_num) + " ")  # 写入文件
    time_end = time.time()  # 结束时间
    print('创建随机数文件耗时:{0}s\n'.format('%.2f' % (time_end - time_start)))


if __name__ == "__main__":
    main(-100, 100, 1234567)
