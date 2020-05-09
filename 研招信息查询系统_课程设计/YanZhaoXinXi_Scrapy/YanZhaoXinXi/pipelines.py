# -*- coding: utf-8 -*-

# Define your item pipelines here
#
# Don't forget to add your pipeline to the ITEM_PIPELINES setting
# See: https://doc.scrapy.org/en/latest/topics/item-pipeline.html
import MySQLdb.cursors
from twisted.enterprise import adbapi


class YanzhaoxinxiPipeline(object):
    def process_item(self, item, spider):
        return item


class MysqlPipeline(object):
    # 采用同步的机制写入mysql
    def __init__(self):
        self.conn = MySQLdb.connect(host='localhost', user='root', passwd='root', db='YanZhaoXinXi', charset="utf8",
                                    use_unicode=True)
        self.cursor = self.conn.cursor()

    def process_item(self, item, spider):
        insert_sql = item.get_insert_sql()
        try:
            self.cursor.execute(insert_sql)
            self.conn.commit()
        except:
            pass


class MysqlTwistedPipline(object):
    def __init__(self, dbpool):
        self.dbpool = dbpool

    @classmethod
    def from_settings(cls, settings):
        dbparms = dict(
            host='localhost',
            user='root',
            passwd='root',
            db='YanZhaoXinXi',
            charset="utf8",
            use_unicode=True,
            cursorclass=MySQLdb.cursors.DictCursor,
        )
        dbpool = adbapi.ConnectionPool("MySQLdb", **dbparms)  # 连接池

        return cls(dbpool)

    def process_item(self, item, spider):
        # 使用twisted将mysql插入变成异步执行
        query = self.dbpool.runInteraction(self.do_insert, item)  # 这个函数会将第一个参数变成异步的
        query.addErrback(self.handle_error, item, spider)  # 处理异常，实际不用传这么多参数，请根据实际情况

    def do_insert(self, cursor, item):
        # 执行具体的插入
        # 根据不同的item 构建不同的sql语句并插入到mysql中
        insert_sql = item.get_insert_sql()  # 这么写是因为在item中定义了生成插入语句的函数，可自行定义
        cursor.execute(insert_sql)
        # 这里和同步不同，不需要做commit()操作，会自动执行

    def handle_error(self, failure, item, spider):
        # 处理异步插入的异常
        print(failure)
