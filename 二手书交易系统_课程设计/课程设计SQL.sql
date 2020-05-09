--CREATE DATABASE 二手书交易系统;
USE 二手书交易系统;

----此段注释语句用于删除定义的所有表
DROP TABLE 现存订单表;
DROP TABLE 购物车表;
DROP TABLE 货品表;
DROP TABLE 管理员表;
DROP TABLE 用户表;
DROP TABLE 书目表;
DROP TABLE 历史订单表;
DROP VIEW 黑名单视图;
DROP VIEW 购物车视图;
DROP VIEW 货品视图;
DROP VIEW 现存订单视图;
DROP VIEW 历史订单视图;

CREATE TABLE 书目表
(
ISBN VARCHAR(13) PRIMARY KEY,
书名 VARCHAR(100) NOT NULL,
作者 VARCHAR(30) NOT NULL,
出版社 VARCHAR(30),
出版时间 DATE,
定价 FLOAT NOT NULL,
允许交易 BIT NOT NULL,
CHECK(LEN(ISBN)=10 OR LEN(ISBN)=13)
--2007年1月1日前，ISBN由10位字组成;2007年1月1日起，新版ISBN由13位数字组成
)

CREATE TABLE 用户表
(
UID INT PRIMARY KEY,
帐号 VARCHAR(16) NOT NULL,
密码 VARCHAR(16) NOT NULL,
昵称 VARCHAR(20) NOT NULL,
年级 VARCHAR(10),
专业 VARCHAR(10),
邮箱 VARCHAR(25) NOT NULL,
手机 VARCHAR(11) NOT NULL,
余额 INT NOT NULL DEFAULT 0,
收货地址 VARCHAR(50),
状态 VARCHAR(10) NOT NULL,
CHECK (年级 IN('大一','大二','大三','大四')),
CHECK(LEN(手机)=11),
CHECK (余额>=0),
CHECK (状态 IN ('正常','黑名单')),
)

CREATE TABLE 管理员表
(
AID INT PRIMARY KEY,
帐号 VARCHAR(16) NOT NULL,
密码 VARCHAR(16) NOT NULL,
姓名 VARCHAR(10) NOT NULL,
邮箱 VARCHAR(25) NOT NULL,
手机 VARCHAR(11) NOT NULL,
)

CREATE TABLE 货品表
(
货物编号 INT PRIMARY KEY,
ISBN VARCHAR(13) NOT NULL,
卖家UID INT NOT NULL,
价格 FLOAT NOT NULL,
数量 INT NOT NULL,
已订数量 INT NOT NULL,
CHECK(已订数量<=数量),
FOREIGN KEY (ISBN) REFERENCES 书目表(ISBN),
FOREIGN KEY (卖家UID) REFERENCES 用户表(UID)
)

CREATE TABLE 现存订单表
(
订单号 INT PRIMARY KEY,
交易时间 DATETIME NOT NULL,
货物编号 INT NOT NULL,
卖家UID INT NOT NULL,
买家UID INT NOT NULL,
价格 FLOAT NOT NULL,
数量 INT NOT NULL,
收货地址 VARCHAR(50) NOT NULL,
订单状态 VARCHAR(10),
快递单号 VARCHAR(20),
CHECK (卖家UID != 买家UID),
CHECK (数量 > 0),
CHECK (订单状态 IN('未付款','已付款','已发货')),
CHECK ((快递单号 IS NOT NULL AND 订单状态 = '已发货') OR (快递单号 IS NULL AND 订单状态 != '已发货')),
FOREIGN KEY (货物编号) REFERENCES 货品表(货物编号),
FOREIGN KEY (卖家UID) REFERENCES 用户表(UID),
FOREIGN KEY (买家UID) REFERENCES 用户表(UID)
)

CREATE TABLE 历史订单表
(
订单号 INT PRIMARY KEY,
交易时间 DATETIME NOT NULL,
货物编号 INT NOT NULL,
卖家UID INT NOT NULL,
买家UID INT NOT NULL,
价格 FLOAT NOT NULL,
数量 INT NOT NULL,
收货地址 VARCHAR(50),
订单状态 VARCHAR(10),
快递单号 VARCHAR(20),
CHECK (卖家UID != 买家UID),
CHECK (数量 > 0),
CHECK (订单状态 IN('完成','买方取消','卖方取消','禁止销售')),
CHECK ((快递单号 IS NOT NULL AND 订单状态 = '完成') OR (快递单号 IS NULL AND 订单状态 != '完成')),
)

CREATE TABLE 购物车表
(
货物编号 INT,
UID INT,
数量 INT NOT NULL,
有效 BIT NOT NULL DEFAULT 1,
PRIMARY KEY(货物编号,UID),
)

CREATE UNIQUE INDEX 书目表_ISBN ON 书目表(ISBN);
CREATE INDEX 用户表_UID ON 用户表(UID);
CREATE INDEX 管理员表_AID ON 管理员表(AID);
CREATE INDEX 货品表_货物编号 ON 货品表(货物编号);
CREATE INDEX 现存订单表_订单号 ON 现存订单表(订单号);
CREATE INDEX 历史订单表_订单号 ON 历史订单表(订单号);
CREATE INDEX 购物车表_货物编号 ON 购物车表(货物编号);

GO
CREATE VIEW 黑名单视图
AS
SELECT *
FROM 用户表
WHERE 状态='黑名单';
GO

GO
CREATE VIEW 购物车视图
AS
SELECT 购物车表.货物编号,货品表.ISBN,书名,作者,出版社,出版时间,昵称 卖家昵称,卖家UID,CAST (定价 AS DECIMAL(18,2)) 原价,CAST (价格 AS DECIMAL(18,2)) 价格,购物车表.数量,货品表.数量-已订数量 库存,购物车表.有效,购物车表.UID
FROM 购物车表,货品表,书目表,用户表
WHERE 购物车表.货物编号 = 货品表.货物编号 AND 货品表.ISBN = 书目表.ISBN AND 卖家UID = 用户表.UID
GO

GO
CREATE VIEW 货品视图
AS
SELECT 货物编号,书名,作者,货品表.ISBN,出版社,出版时间,昵称 卖家昵称,UID 卖家ID,CAST (定价 AS DECIMAL(18,2)) 原价,CAST (价格 AS DECIMAL(18,2)) 价格,数量-已订数量 库存,允许交易
FROM 货品表,书目表,用户表
WHERE 货品表.ISBN = 书目表.ISBN AND 货品表.卖家UID = 用户表.UID;
GO

GO
CREATE VIEW 现存订单视图
AS
SELECT 订单号,货物编号,卖家UID,Y.昵称 卖家昵称,买家UID,X.昵称 买家昵称,收货地址,现存订单表.价格,数量,交易时间,快递单号,订单状态
FROM 现存订单表,(SELECT UID,昵称 FROM 用户表) X,(SELECT UID,昵称 FROM 用户表) Y
WHERE 现存订单表.买家UID = X.UID AND 现存订单表.卖家UID = Y.UID
GO

GO
CREATE VIEW 历史订单视图
AS
SELECT 订单号,货物编号,卖家UID,Y.昵称 卖家昵称,买家UID,X.昵称 买家昵称,收货地址,历史订单表.价格,数量,交易时间,快递单号,订单状态
FROM 历史订单表,(SELECT UID,昵称 FROM 用户表) X,(SELECT UID,昵称 FROM 用户表) Y
WHERE 历史订单表.买家UID = X.UID AND 历史订单表.卖家UID = Y.UID
GO

--2018.11.6改动：
--创建多个基本表，包括：订单表、用户表、管理员表、货品表、书目表

--2018.11.7改动：
--设置了货品表、订单表的参照关系
--为多个属性设置了NOT NULL约束
--创建视图：余额视图
--增加了管理员表和用户表的测试数据
--将价格属性全部更正为FLOAT类型
--将所有的ID属性全部更改为INT类型

--2018.11.11改动：
--将书目表的"价格"属性更名为"定价"
--将书单表的书名、作者、出版社属性的VARCHAR全部延长为VARCHAR(30)

--2018.12.3改动：
--为用户表添加属性"状态",并限定为("正常","黑名单")
--将用户表的"姓名"属性的VARCHAR延长为VARCHAR(20)
--将书目表的"书名"属性的VARCHAR延长为VARCHAR(100)
--创建视图：黑名单视图

--2018.12.3改动：
--将用户表的"年级"属性限定为('大一','大二','大三','大四')
--为货品表添加属性"数量"

--2018.12.5改动：
--将用户表的"姓名"属性更名为"昵称"

--2018.12.6改动：
--新增基本表"购物车表"
--为订单表增加属性"状态"，并限制(状态 IN('未付款','已付款','已发货')),
--创建基本表：历史订单表,限制"状态" IN('完成','取消')

--2018.12.7改动：
--将货品表的"是否为书单"属性删除
--创建货品视图,购物车视图
--将货品表的"货物编号"属性从VARCHAR(10)改变为INT

--2018.12.10改动：
--为书目表增加属性"允许交易",类型为BIT,用于控制是否允许上架
--修改"货品视图"，查询属性"允许交易"
--将历史订单表的"状态"属性的限制由 IN('完成','取消') 改为 IN('完成','买方取消','卖方取消','禁止销售')
--注：其中的"禁止销售"状态为禁售书籍之后取消了正在交易的未发货的订单形成的状态
--将购物车表的参照关系：FOREIGN KEY (货物编号) REFERENCES 货品表(货物编号)删除
--注：以防卖方下架货品之后，产生冲突
--为购物车表增设属性"有效"，类型为BIT，在"禁止销售"或者"下架货品"操作之后会切换其值，以示其失效
--相应地修改购物车视图，使之显示属性"有效"
--将用户表的"默认收货地址"更名为"收货地址"

--2018.12.11改动：
--为购物车表增加属性"ISBN"，为了解决货品表中相应项被删去，后找不到对应的图书信息的问题
--终于意识到，购物车表应该独立地存储很多数据，并时不时刷新数据！！！
--为购物车表增加属性"卖家UID","价格"
--为购物车表添加约束：FOREIGN KEY (ISBN) REFERENCES 书目表(ISBN)
--以上关于购物车表的思考全部错误，复原！！！
--删除购物车表的约束：FOREIGN KEY (UID) REFERENCES 用户表(UID)

--2018.12.12改动：
--为订单表添加属性"快递单号"
--为订单表设置约束：((快递单号 IS NOT NULL AND 订单状态 = '已发货') OR (快递单号 IS NULL AND 订单状态 != '已发货'))
--为订单表设置约束：CHECK (数量 > 0)
--为历史订单表添加属性"快递单号"
--为历史订单表设置约束：((快递单号 IS NOT NULL AND 订单状态 = '完成') OR (快递单号 IS NULL AND 订单状态 != '完成'))
--为历史订单表设置约束：CHECK (数量 > 0)

--将"订单表"更名为"现存订单表"
--将"订单视图"更名为"现存订单视图"
--创建"历史订单视图"
