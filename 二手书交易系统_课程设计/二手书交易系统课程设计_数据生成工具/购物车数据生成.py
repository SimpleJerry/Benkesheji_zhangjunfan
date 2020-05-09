import os, re
from random import randint

dict = {}
with open("货品表数据.txt", "r", encoding="utf-8") as file:
    for line in file.readlines():
        list = re.findall(".*?VALUES\((.*?)\);", line)[0].split(",")
        id = list[0]  # 货物编号
        for i in range(3):  # 每个货物编号产生多条数据
            UID = randint(1, 260)  # UID
            kucun = int(list[4]) - int(list[5])  # 库存
            if (kucun != 0):  # 库存0就不加购物车
                count = randint(1, kucun)
                sql_string = "INSERT INTO 购物车表(货物编号,UID,数量,有效) VALUES({0},{1},{2},1);".format(id, UID, count)
                print(sql_string)
