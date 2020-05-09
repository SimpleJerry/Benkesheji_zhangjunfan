# -*- coding: utf-8 -*-
import scrapy
from selenium import webdriver
from scrapy import Request
from urllib import parse
from YanZhaoXinXi.items import YanzhaoxinxiItem
import re
import time


class YanZhaoSpider(scrapy.Spider):
    name = 'Yanzhao_all'
    allowed_domains = ['yz.chsi.com.cn']
    start_urls = ['https://yz.chsi.com.cn/zsml/queryAction.do']
    # start_urls = ['http://www.baidu.com']

    def parse(self, response):
        browser = webdriver.Chrome(executable_path=r'C:\个人文件\Code\Python Project\YanZhaoXinXi\YanZhaoXinXi\spiders\chromedriver.exe')
        # 打开搜索页面
        browser.get("https://yz.chsi.com.cn/zsml/queryAction.do")
        browser.maximize_window()

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

    # 处理某个学校的招生页面
    def parse_deep(self, response):
        browser = webdriver.Chrome(r'chromedriver.exe')
        browser.get(response.url)  # 打开网页
        browser.maximize_window()
        url_zydm_list = []  # 用于存储元组：(url,zydm_bh)

        while True:
            # 考试范围url
            urls_node = browser.find_elements_by_css_selector('td.ch-table-center:nth-child(8) a')
            zydm_list = browser.find_elements_by_css_selector("table.ch-table tbody tr td:nth-child(3)")
            for index in range(len(urls_node)):
                url = urls_node[index].get_attribute("href")
                zydm_bh = re.findall(r"(\d+)", zydm_list[index].text)[0]  # 编号
                url_zydm_list.append((url, zydm_bh))  # 存入元组->(url,zydm_bh)

            # 只有一页的情况
            if (len(browser.find_elements_by_css_selector('ul.ch-page li.lip')) == 3):
                break

            if (len(browser.find_elements_by_css_selector('ul.ch-page li.lip.lip-input-box')) != 1):
                browser.find_elements_by_css_selector('ul.ch-page li.lip')[-1].click()  # 点击下一页
                # 如果到了末尾，跳出循环
                if (browser.find_element_by_css_selector('ul.ch-page li.lip.unable.lip-last') ==
                        browser.find_elements_by_css_selector('ul.ch-page li.lip')[-1]):
                    break
            # 有多页的情况，点击下一页，直到点不了（此时出现class=unable的li),写“或”是因为第一次会被识别，要让第一次的结果为真
            elif (len(browser.find_elements_by_css_selector('ul.ch-page li.lip.unable')) == 0 or
                  len(browser.find_elements_by_css_selector('ul.ch-page li.lip.unable.lip-first')) == 1):
                browser.find_elements_by_css_selector('ul.ch-page li.lip')[-2].click()  # 点击下一页
            else:
                break

        # 关闭浏览器
        browser.quit()

        # 放在最后yield是因为，如果放在中间，会生成很多浏览器窗口，直至内存承受不了
        # 要让他一口气获取完所有url，并先关闭当前浏览器
        for item in url_zydm_list:
            url, zydm_bh = item[0], item[1]
            yield Request(url=parse.urljoin(response.url, url), meta={"zydm_bh": zydm_bh}, callback=self.parse_detail)

    # 某个学校的某个专业的考试范围页面
    def parse_detail(self, response):
        my_item = YanzhaoxinxiItem()
        my_item["db_name"] = "研招信息_所有"

        my_item["url"] = response.url
        my_item["ID"] = re.split("id=", response.url)[1]
        details = response.css('td.zsml-summary::text').extract()
        # 分别为：招生单位、考试方式、院系所、专业代码、学习方式、研究方向、指导老师、拟招人数
        my_item["zsdw"] = details[0]
        my_item["ksfs"] = details[1]
        my_item["yxs"] = details[2]
        my_item["zydm_bh"] = response.meta["zydm_bh"]
        my_item["zydm_mc"] = details[3]
        my_item["xxfs"] = details[4]
        my_item["yjfx"] = details[5]
        my_item["zdls"] = details[6]
        try:
            my_item["nzrs"] = details[7]
        except:
            # zdls为空所导致的异常
            my_item["zdls"] = ""
            my_item["nzrs"] = details[6]

        try:
            my_item["bz"] = response.css('span.zsml-bz::text')[1].extract()
        except:
            # 无备注时，赋值为空串
            my_item["bz"] = ""

        exams = response.css("tbody.zsml-res-items td::text").extract()
        exams = [item.replace('\r\n', '').replace(' ', '') for item in exams]
        my_item["zhengzhi"] = exams[0]
        my_item["waiyu"] = exams[2]
        my_item["yewuke_1"] = exams[3]
        my_item["yewuke_2"] = exams[4]

        yield my_item
