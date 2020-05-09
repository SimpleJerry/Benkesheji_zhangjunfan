import os, re
from random import randint

dict = {}
with open("货品表数据.txt", "r",encoding="utf-8") as file:
    for line in file.readlines():
        list = re.findall(".*?VALUES\((.*?)\);", line)[0].split(",")
        id = int(list[0])
        seller = int(list[2])
        dict[id] = seller

for i in range(1, 100):
    day = randint(1, 13)
    huowu = randint(1, 100)
    seller = dict[i]
    buyer = randint(1, 260)
    price = randint(15, 20)
    count = randint(1, 3)
    conditions = ["完成", "买方取消", "卖方取消", "禁止销售"]
    condition = conditions[randint(0, 3)]
    kuaidi = randint(100000000000, 999999999999)
    if (seller != buyer):
        if (condition == "完成"):  # 有快递单号
            sql = "INSERT INTO 历史订单表(订单号,交易时间,货物编号,卖家UID,买家UID,价格,数量,收货地址,订单状态,快递单号) VALUES({0},'2018-12-{1}',{2},{3},{4},{5},{6},'上海海事大学','{7}','{8}');".format(
                i, day, huowu, seller, buyer, price, count, condition, kuaidi)
        else:
            sql = "INSERT INTO 历史订单表(订单号,交易时间,货物编号,卖家UID,买家UID,价格,数量,收货地址,订单状态,快递单号) VALUES({0},'2018-12-{1}',{2},{3},{4},{5},{6},'上海海事大学','{7}',NULL);".format(
                i, day, huowu, seller, buyer, price, count, condition)
        print(sql)
    else:
        print(str(i) + "号订单空缺")
