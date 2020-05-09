# -*- coding: utf-8 -*-
import scrapy
from selenium import webdriver
from scrapy import Request
from urllib import parse
from YanZhaoXinXi.items import YanzhaoxinxiItem


class YanZhaoSpider(scrapy.Spider):
    name = 'Yanzhao'
    allowed_domains = ['yz.chsi.com.cn']
    start_urls = ['http://yz.chsi.com.cn/zsml/queryAction.do']

    def parse(self, response):
        browser = webdriver.Chrome(r'chromedriver.exe')
        # 打开搜索页面
        browser.get("https://yz.chsi.com.cn/zsml/queryAction.do")
        browser.maximize_window()

        # 选择城市
        # browser.find_element_by_css_selector('#ssdm').click()
        # browser.find_element_by_css_selector('#ssdm > option:nth-child(10)').click()  # 上海

        # 选择学术学位
        browser.find_element_by_css_selector('#mldm').click()
        # browser.find_element_by_css_selector('#mldm > optgroup:nth-child(2) > option').click()  # 专业学位
        browser.find_element_by_css_selector('#mldm > optgroup:nth-child(3) > option:nth-child(12)').click()  # 管理科学

        # 选择学科类别
        browser.find_element_by_css_selector('#yjxkdm').click()
        # browser.find_element_by_css_selector('#yjxkdm > option:nth-child(21)').click()  # 0852工程
        # browser.find_element_by_css_selector('#yjxkdm > option:nth-child(5)').click()  # 0254国际商务
        browser.find_element_by_css_selector('#yjxkdm > option:nth-child(2)').click()  # 1201管理科学与工程
        # browser.find_element_by_css_selector('#yjxkdm > option:nth-child(3)').click()  # 1202工商管理

        # 选择学科类别
        # browser.find_element_by_css_selector('#zymc').click()
        # browser.find_element_by_css_selector('#zymc > option:nth-child(24)').click()  # (085211)(专业学位)计算机技术
        # browser.find_element_by_css_selector('#zymc > option:nth-child(32)').click()  # (085212)(专业学位)软件工程
        # browser.find_element_by_css_selector('#zymc > option:nth-child(2)').click()  # (025400)(专业学位)国际商务

        # 选择学习方式
        browser.find_element_by_css_selector('select.ch-select').click()
        browser.find_element_by_css_selector('#form2 > select:nth-child(9) > option:nth-child(2)').click()  # 全日制

        # 点击查询
        browser.find_element_by_css_selector('input.blue-btn').click()

        # 点击211
        browser.find_elements_by_css_selector('label.ch-check-label')[1].click()
        # 点击确认
        browser.find_element_by_css_selector('input.blue-btn-s').click()

        while True:
            nodes = browser.find_elements_by_css_selector('table.ch-table a')
            for node in nodes:
                url = node.get_attribute('href')
                yield Request(url=parse.urljoin(browser.current_url, url), callback=self.parse_deep)

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

    # 处理页面，从所有专业跳转到考试范围页面
    def parse_deep(self, response):
        # 考试范围url
        urls = response.css('td.ch-table-center:nth-child(8) a[target=_blank]::attr(href)').extract()
        for url in urls:
            yield Request(url=parse.urljoin(response.url, url), callback=self.parse_detail)

    def parse_detail(self, response):
        my_item = YanzhaoxinxiItem()
        my_item["db_name"] = "120100管理科学与工程_全国_211"

        my_item["url"] = response.url
        details = response.css('td.zsml-summary::text').extract()
        # 分别为：招生单位、考试方式、院系所、专业代码、学习方式、研究方向、指导老师、拟招人数
        my_item["zsdw"] = details[0]
        my_item["ksfs"] = details[1]
        my_item["yxs"] = details[2]
        my_item["zydm"] = details[3]
        my_item["xxfs"] = details[4]
        my_item["yjfx"] = details[5]
        my_item["zdls"] = details[6]
        try:
            my_item["nzrs"] = details[7].replace("专业：", "")
        except:
            # zdls为空所导致的异常
            my_item["zdls"] = ""
            my_item["nzrs"] = details[6].replace("专业：", "")

        exams = response.css("tbody.zsml-res-items td::text").extract()
        exams = [item.replace('\r\n', '').replace(' ', '') for item in exams]
        my_item["zhengzhi"] = exams[0]
        my_item["waiyu"] = exams[2]
        my_item["yewuke_1"] = exams[3]
        my_item["yewuke_2"] = exams[4]

        yield my_item
