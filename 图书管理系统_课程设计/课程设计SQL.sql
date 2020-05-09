--CREATE DATABASE Library;
USE Library;

----此段注释语句用于删除定义的所有表
--DROP TABLE [Admin];
--DROP TABLE Borrow_List;
--DROP TABLE History;
--DROP TABLE Reader;
--DROP TABLE Storage;
--DROP TABLE Book_info;
--DROP VIEW BlackList;
--DROP VIEW Borrow_View;
--DROP VIEW History_View;
--DROP VIEW Reader_View;
--DROP VIEW Storage_View;


CREATE TABLE Book_info
(
B_ISBN VARCHAR(50) PRIMARY KEY,
B_name VARCHAR(50) NOT NULL,
B_author VARCHAR(50) NOT NULL,
B_pubcom VARCHAR(50) NOT NULL,
B_pubtime VARCHAR(10) NOT NULL,
B_price VARCHAR(10) NOT NULL,
B_remain INT DEFAULT(0) NOT NULL
)

CREATE TABLE Storage
(
S_no INT PRIMARY KEY,
B_ISBN VARCHAR(50) REFERENCES Book_info(B_ISBN),
S_address VARCHAR(50),
S_condition VARCHAR(10) CHECK (S_condition IN ('在馆','借出','挂失'))
)

CREATE TABLE [Admin]
(
A_account VARCHAR(20) PRIMARY KEY,
A_password VARCHAR(20) NOT NULL,
A_name VARCHAR(20) NOT NULL,
A_phone VARCHAR(20) UNIQUE NOT NULL
)

CREATE TABLE Reader
(
R_id INT PRIMARY KEY,
R_account VARCHAR(20) UNIQUE NOT NULL,
R_password VARCHAR(20) NOT NULL,
R_name VARCHAR(20) NOT NULL,
R_phone VARCHAR(20) UNIQUE NOT NULL,
R_email VARCHAR(20) UNIQUE NOT NULL,
R_condition VARCHAR(20) CHECK (R_condition IN ('学生','研究生','教师','黑名单'))
)

CREATE TABLE Borrow_List
(
S_no INT PRIMARY KEY,
R_id INT NOT NULL,
B_borrowdate DATE NOT NULL,
B_returndate DATE NOT NULL,
FOREIGN KEY (S_no) REFERENCES Storage(S_no),
FOREIGN KEY (R_id) REFERENCES Reader(R_id)
)

CREATE TABLE History
(
S_no INT,
R_id INT,
H_BorrowDate DATE NOT NULL,
H_ReturnDate DATE,
PRIMARY KEY (S_no,R_id,H_BorrowDate),
FOREIGN KEY (S_no) REFERENCES Storage(S_no),
FOREIGN KEY (R_id) REFERENCES Reader(R_id)
)


GO
CREATE VIEW History_View
AS
SELECT Reader.R_id 读者序号,R_account 读者帐号,R_name 读者姓名,R_phone 电话,R_email 邮箱,B_name 书名,Book_info.B_ISBN ISBN,B_price 价格,H_BorrowDate 借书日期,H_ReturnDate 应还日期
FROM Reader,Storage,History,Book_info
WHERE Reader.R_id = History.R_id AND Storage.S_no = History.S_no AND Book_info.B_ISBN = Storage.B_ISBN;
GO

GO
CREATE VIEW Borrow_View
AS
SELECT Reader.R_id 读者序号,R_account 读者帐号,R_name 读者姓名,R_phone 电话,R_email 邮箱,B_name 书名,Book_info.B_ISBN ISBN,B_price 价格,B_BorrowDate 借书日期,B_ReturnDate 应还日期
FROM Reader,Storage,Book_info,Borrow_List
WHERE Reader.R_id = Borrow_List.R_id AND Storage.S_no = Borrow_List.S_no AND Book_info.B_ISBN = Storage.B_ISBN;
GO

GO
CREATE VIEW Storage_View
AS
SELECT S_no 库存编号,Storage.B_ISBN ISBN,B_name 书名,B_author 作者,S_address 馆藏地址,S_condition 在馆状态 
FROM Storage,Book_info
WHERE Storage.B_ISBN = Book_info.B_ISBN;

GO
CREATE VIEW Reader_View
AS
SELECT R_id 读者编号,R_account 帐号,R_name 姓名,R_phone 手机,R_email 邮箱,R_condition 类型
FROM Reader;

GO
CREATE VIEW BlackList
AS
SELECT R_id 读者编号,R_account 帐号,R_name 姓名,R_phone 手机,R_email 邮箱
FROM Reader
WHERE R_condition='黑名单';

--2018.5.26改动：
--		1.S_no和R_id从原来的VARCHAR类型改为了INT类型
--		2.增加了历史查询视图—History_View和在借书籍查询视图—Borrow_View
--		3.提供了分别为Admin和Reader表提供了一个测试数据

--2018.6.1改动：
--		1.将R_condition INT CHECK (R_condition IN (0,1))改为R_condition VARCHAR(20) CHECK (R_condition IN ('学生','研究生','校长'))
--		2.将B_remain INT NOT NULL改为B_remain INT DEFAULT(0) NOT NULL,即添加了默认值0
--		3.将S_condition INT CHECK (S_condition IN ('0','1'))改为S_condition VARCHAR(10) CHECK (S_condition IN ('在馆','借出','挂失'))
--		4.为Book_info提供了真实的测试数据

--2018.6.5改动：
--		1.新增Storage_View视图
--		2.新增Reader_View视图
--		3.为Reader提供了测试数据
--		4.将课程设计SQL文件中的插入语句分离成单独的SQL文件

--2018.6.5改动：
--		1.为Storage提供了测试数据
--		2.为Book_info清理了数据
--		3.将R_condition的域扩充为('学生','研究生','校长','黑名单')
--		4.新增BlackList视图——意即黑名单

--2018.6.6改动：
--		1.将所有的DATETIME类型转换为DATE类型
--		2.将Borrow_list中的R_id增添约束NOT NULL
--		3.将History中H_ReturnDate的约束NOT NULL删除,并且不再用全码作为PRIMARY KEY
--		(但是当出现同一个人在同一天借同一本书并都在当天归还这种疯狗操作情况下)会产生数据插入的错误

--2018.6.18改动：
--      1.将Reader中的“校长”改为了“教师”


--以下均不用运行
--USE library;
--CREATE TABLE books(
--ISBN VARCHAR(50),
--书名 VARCHAR(50),
--中图分类 VARCHAR(50),
--主要著者 VARCHAR(50),
--主题 VARCHAR(50),
--出版地 VARCHAR(50),
--出版社 VARCHAR(50),
--出版日期 VARCHAR(50),
--摘要 LONGTEXT,
--语种 VARCHAR(50),
--载体形态 VARCHAR(50),
--题名责任者 VARCHAR(50),
--索书号 VARCHAR(50),
--价格 VARCHAR(50),
--PRIMARY KEY(ISBN,书名));