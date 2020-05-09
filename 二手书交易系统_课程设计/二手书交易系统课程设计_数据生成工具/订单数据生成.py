from random import randint

for i in range(1,11):
    time = "2018-12-{0}".format(randint(1, 10))
    number = randint(1,100)
    buyer = randint(1, 100)
    seller = randint(1, 100)
    price = randint(15, 25)
    count = randint(1, 2)

    rand_num = randint(0, 2)
    conditions = ['未付款', '已付款', '已发货']
    condition = conditions[rand_num]

    sql_string = " " \
                 "VALUES({0},'{1}',{2},{3},{4},{5},{6},'{7}');".format(i, time, number, seller, 103, price, count,
                                                                         condition)
    print(sql_string)
