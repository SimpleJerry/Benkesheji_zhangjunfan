# -*- coding: utf-8 -*-
import scrapy
from selenium import webdriver
from scrapy import Request
from urllib import parse
from YanZhaoXinXi.items import YuanxiaoxinxiItem
import re


class YanZhaoSpider(scrapy.Spider):
    name = 'Yanzhao_yuanxiao'
    allowed_domains = ['yz.chsi.com.cn']
    start_urls = ['https://yz.chsi.com.cn/sch/']

    def parse(self, response):
        browser = webdriver.Chrome(r'chromedriver.exe')
        # 打开搜索页面
        browser.get("https://yz.chsi.com.cn/sch/")
        browser.maximize_window()

        while True:
            count = len(browser.find_elements_by_css_selector('table.ch-table tbody tr'))
            for index in range(1, count + 1):
                my_item = YuanxiaoxinxiItem()
                my_item["db_name"] = "院校信息_所有"
                my_item["url"] = browser.find_element_by_css_selector(
                    'table.ch-table tbody tr:nth-child({0}) td:nth-child({1}) a'.format(index, 1)).get_attribute("href")
                my_item["ID"] = re.findall(r'schId-(\d+)\.dhtml', my_item["url"])[0]
                my_item["YXMC"] = browser.find_element_by_css_selector(
                    'table.ch-table tbody tr:nth-child({0}) td:nth-child({1})'.format(index, 1)).text
                my_item["SZD"] = browser.find_element_by_css_selector(
                    'table.ch-table tbody tr:nth-child({0}) td:nth-child({1})'.format(index, 2)).text
                my_item["YXLS"] = browser.find_element_by_css_selector(
                    'table.ch-table tbody tr:nth-child({0}) td:nth-child({1})'.format(index, 3)).text
                my_item["YXTX"] = browser.find_element_by_css_selector(
                    'table.ch-table tbody tr:nth-child({0}) td:nth-child({1})'.format(index, 4)).text
                YJSY = browser.find_elements_by_css_selector(
                    'table.ch-table tbody tr:nth-child({0}) td:nth-child({1}) i'.format(index, 5))
                if (len(YJSY) == 0):
                    my_item["YJSY"] = 'False'
                else:
                    my_item["YJSY"] = 'True'
                ZHXYX = browser.find_elements_by_css_selector(
                    'table.ch-table tbody tr:nth-child({0}) td:nth-child({1}) i'.format(index, 6))
                if (len(ZHXYX) == 0):
                    my_item["ZHXYX"] = 'False'
                else:
                    my_item["ZHXYX"] = 'True'

                yield my_item

            # 只有一页的情况
            if (len(browser.find_elements_by_css_selector('ul.ch-page li.lip')) == 3):
                break

            # 有多页的情况，点击下一页，直到点不了（此时出现class=unable的li),写“或”是因为第一次会被识别，要让第一次的结果为真
            if (len(browser.find_elements_by_css_selector('ul.ch-page li.lip.unable')) == 0 or
                    len(browser.find_elements_by_css_selector('ul.ch-page li.lip.unable.lip-first')) == 1):
                browser.find_elements_by_css_selector('ul.ch-page li.lip')[-2].click()  # 点击下一页
            else:
                break

        browser.quit()  # 关闭页面
