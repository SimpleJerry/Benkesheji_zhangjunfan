# -*- coding: utf-8 -*-
import scrapy
from selenium import webdriver
from scrapy import Request
from urllib import parse
from YanZhaoXinXi.items import ChaxunxuanxiangItem
import re


class YanZhaoSpider(scrapy.Spider):
    name = 'Yanzhao_xuanxiang'
    allowed_domains = ['yz.chsi.com.cn']
    start_urls = ['https://yz.chsi.com.cn/sch/']

    def parse(self, response):
        browser = webdriver.Chrome(r'chromedriver.exe')
        # 打开搜索页面
        browser.get("https://yz.chsi.com.cn/zsml/zyfx_search.jsp")
        browser.maximize_window()

        # 1.提取"门类类别"下拉框
        MLLB_list = browser.find_elements_by_css_selector("select#mldm option")
        for MLLB in MLLB_list:
            # 2.选中"门类类别"
            browser.find_element_by_css_selector("select#mldm").click()
            MLLB.click()

            # 3.提取"学科类别"下拉框
            XKLB_list = browser.find_elements_by_css_selector("select#yjxkdm option")
            for XKLB in XKLB_list:
                # 4.选中"学科类别"
                browser.find_element_by_css_selector("select#yjxkdm").click()
                XKLB.click()

                # 5.提取"专业名称"下拉框
                ZYMC_list = browser.find_elements_by_css_selector("select#zymc option")
                for ZYMC in ZYMC_list:
                    my_item = ChaxunxuanxiangItem()
                    my_item["db_name"] = "门类学科专业选项"
                    my_item["MLLB"] = MLLB.text
                    my_item["XKLB"] = XKLB.text
                    my_item["ZYMC"] = ZYMC.text
                    yield my_item

        citys = browser.find_elements_by_css_selector("select#ssdm option")
        citys_text = []  # 这样操作是为了，在控制台中，直接获取城市列表，如果不分，会夹杂其他提示信息
        for city in citys:
            citys_text.append(city.text)
        for city in citys_text:
            print(city)
        browser.quit()  # 关闭页面
