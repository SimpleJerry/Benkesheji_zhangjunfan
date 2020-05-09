from random import randint

ISBN_list = [9787040205497, 9787040212778, 9787563233915, 9787563233984, 9787563233977, 9787040494792, 9787040495034,
             9787040494815]
for i in range(1,101):  # 100条数据
    ISBN = ISBN_list[randint(0, len(ISBN_list) - 1)]  # 从中随机抽取
    UID = randint(1, 260)
    price = randint(15, 25)
    count = randint(1, 3)
    sql_string = "INSERT INTO 货品表(货物编号,ISBN,卖家UID,价格,数量,已订数量) VALUES({0},{1},{2},{3},{4},0);".format(i, ISBN, UID,
                                                                                              price, count)
    print(sql_string)
    # INSERT INTO 货品表(货物编号,ISBN,卖家UID,价格,数量,是否为书单) VALUES(1,9787040205497,103,25,1,0);
