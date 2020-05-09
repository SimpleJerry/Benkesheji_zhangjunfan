from scrapy.cmdline import execute  # 调用该函数以执行scrapy脚本
import sys  # 为了加载到指定的目录
import os  # 为了获取当前目录

sys.path.append(os.path.dirname(os.path.abspath(__file__)))

# execute(["scrapy", "crawl", "Yanzhao"])
execute(["scrapy", "crawl", "Yanzhao_all"])
# execute(["scrapy", "crawl", "Yanzhao_yuanxiao"])
# execute(["scrapy", "crawl", "Yanzhao_xuanxiang"])
