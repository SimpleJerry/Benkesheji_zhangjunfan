# -*- coding: utf-8 -*-

# Define here the models for your scraped items

# See documentation in:
# https://doc.scrapy.org/en/latest/topics/items.html

import scrapy


class YanzhaoxinxiItem(scrapy.Item):
    # define the fields for your item here like:
    # name = scrapy.Field()
    ID = scrapy.Field()  # ID:截取url后面一串字串
    db_name = scrapy.Field()  # 表名
    zsdw = scrapy.Field()  # 招生单位
    ksfs = scrapy.Field()  # 考试方式
    yxs = scrapy.Field()  # 院系所
    zydm_bh = scrapy.Field()  # 专业代码_编号
    zydm_mc = scrapy.Field()  # 专业代码_名称
    xxfs = scrapy.Field()  # 学习方式
    yjfx = scrapy.Field()  # 研究方向
    zdls = scrapy.Field()  # 指导老师
    nzrs = scrapy.Field()  # 拟招人数
    bz = scrapy.Field()  # 备注
    zhengzhi = scrapy.Field()  # 政治
    waiyu = scrapy.Field()  # 外语
    yewuke_1 = scrapy.Field()  # 业务课一
    yewuke_2 = scrapy.Field()  # 业务课二
    url = scrapy.Field()

    def get_insert_sql(self):
        sql = "INSERT INTO {0}(ID,招生单位,考试方式,院系所,专业代码,专业名称,学习方式,研究方向,指导老师,拟招人数,备注,政治,外语,业务课一,业务课二,url) " \
              "VALUES('{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}')".format(
            self["db_name"], self["ID"], self["zsdw"], self["ksfs"], self["yxs"], self["zydm_bh"], self["zydm_mc"],
            self["xxfs"], self["yjfx"], self["zdls"], self["nzrs"], self["bz"], self["zhengzhi"], self["waiyu"],
            self["yewuke_1"], self["yewuke_2"], self["url"])
        return sql


class YuanxiaoxinxiItem(scrapy.Item):
    db_name = scrapy.Field()  # 表名
    ID = scrapy.Field()  # ID:截取url后面一串数字
    YXMC = scrapy.Field()  # 院校名称
    SZD = scrapy.Field()  # 所在地
    YXLS = scrapy.Field()  # 院校隶属
    YXTX = scrapy.Field()  # 院校特性
    YJSY = scrapy.Field()  # 研究生院
    ZHXYX = scrapy.Field()  # 自主划线院校
    url = scrapy.Field()

    def get_insert_sql(self):
        sql = "INSERT INTO {0}(ID,院校名称,所在地,院校隶属,院校特性,研究生院,自划线院校,url) VALUES('{1}','{2}','{3}','{4}','{5}',{6},{7},'{8}');".format(
            self["db_name"], self["ID"], self["YXMC"], self["SZD"], self["YXLS"], self["YXTX"], self["YJSY"],
            self["ZHXYX"], self["url"])
        return sql


class ChaxunxuanxiangItem(scrapy.Item):
    db_name = scrapy.Field()  # 表名
    MLLB = scrapy.Field()  # 门类类别
    XKLB = scrapy.Field()  # 学科类别
    ZYMC = scrapy.Field()  # 专业名称

    def get_insert_sql(self):
        sql = "INSERT INTO {0}(门类类别,学科类别,专业名称) VALUES('{1}','{2}','{3}');".format(self["db_name"], self["MLLB"],
                                                                                  self["XKLB"], self["ZYMC"])
        return sql
