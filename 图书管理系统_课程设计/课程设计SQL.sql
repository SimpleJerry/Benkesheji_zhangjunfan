--CREATE DATABASE Library;
USE Library;

----�˶�ע���������ɾ����������б�
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
S_condition VARCHAR(10) CHECK (S_condition IN ('�ڹ�','���','��ʧ'))
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
R_condition VARCHAR(20) CHECK (R_condition IN ('ѧ��','�о���','��ʦ','������'))
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
SELECT Reader.R_id �������,R_account �����ʺ�,R_name ��������,R_phone �绰,R_email ����,B_name ����,Book_info.B_ISBN ISBN,B_price �۸�,H_BorrowDate ��������,H_ReturnDate Ӧ������
FROM Reader,Storage,History,Book_info
WHERE Reader.R_id = History.R_id AND Storage.S_no = History.S_no AND Book_info.B_ISBN = Storage.B_ISBN;
GO

GO
CREATE VIEW Borrow_View
AS
SELECT Reader.R_id �������,R_account �����ʺ�,R_name ��������,R_phone �绰,R_email ����,B_name ����,Book_info.B_ISBN ISBN,B_price �۸�,B_BorrowDate ��������,B_ReturnDate Ӧ������
FROM Reader,Storage,Book_info,Borrow_List
WHERE Reader.R_id = Borrow_List.R_id AND Storage.S_no = Borrow_List.S_no AND Book_info.B_ISBN = Storage.B_ISBN;
GO

GO
CREATE VIEW Storage_View
AS
SELECT S_no �����,Storage.B_ISBN ISBN,B_name ����,B_author ����,S_address �ݲص�ַ,S_condition �ڹ�״̬ 
FROM Storage,Book_info
WHERE Storage.B_ISBN = Book_info.B_ISBN;

GO
CREATE VIEW Reader_View
AS
SELECT R_id ���߱��,R_account �ʺ�,R_name ����,R_phone �ֻ�,R_email ����,R_condition ����
FROM Reader;

GO
CREATE VIEW BlackList
AS
SELECT R_id ���߱��,R_account �ʺ�,R_name ����,R_phone �ֻ�,R_email ����
FROM Reader
WHERE R_condition='������';

--2018.5.26�Ķ���
--		1.S_no��R_id��ԭ����VARCHAR���͸�Ϊ��INT����
--		2.��������ʷ��ѯ��ͼ��History_View���ڽ��鼮��ѯ��ͼ��Borrow_View
--		3.�ṩ�˷ֱ�ΪAdmin��Reader���ṩ��һ����������

--2018.6.1�Ķ���
--		1.��R_condition INT CHECK (R_condition IN (0,1))��ΪR_condition VARCHAR(20) CHECK (R_condition IN ('ѧ��','�о���','У��'))
--		2.��B_remain INT NOT NULL��ΪB_remain INT DEFAULT(0) NOT NULL,�������Ĭ��ֵ0
--		3.��S_condition INT CHECK (S_condition IN ('0','1'))��ΪS_condition VARCHAR(10) CHECK (S_condition IN ('�ڹ�','���','��ʧ'))
--		4.ΪBook_info�ṩ����ʵ�Ĳ�������

--2018.6.5�Ķ���
--		1.����Storage_View��ͼ
--		2.����Reader_View��ͼ
--		3.ΪReader�ṩ�˲�������
--		4.���γ����SQL�ļ��еĲ���������ɵ�����SQL�ļ�

--2018.6.5�Ķ���
--		1.ΪStorage�ṩ�˲�������
--		2.ΪBook_info����������
--		3.��R_condition��������Ϊ('ѧ��','�о���','У��','������')
--		4.����BlackList��ͼ�����⼴������

--2018.6.6�Ķ���
--		1.�����е�DATETIME����ת��ΪDATE����
--		2.��Borrow_list�е�R_id����Լ��NOT NULL
--		3.��History��H_ReturnDate��Լ��NOT NULLɾ��,���Ҳ�����ȫ����ΪPRIMARY KEY
--		(���ǵ�����ͬһ������ͬһ���ͬһ���鲢���ڵ���黹���ַ蹷���������)��������ݲ���Ĵ���

--2018.6.18�Ķ���
--      1.��Reader�еġ�У������Ϊ�ˡ���ʦ��


--���¾���������
--USE library;
--CREATE TABLE books(
--ISBN VARCHAR(50),
--���� VARCHAR(50),
--��ͼ���� VARCHAR(50),
--��Ҫ���� VARCHAR(50),
--���� VARCHAR(50),
--����� VARCHAR(50),
--������ VARCHAR(50),
--�������� VARCHAR(50),
--ժҪ LONGTEXT,
--���� VARCHAR(50),
--������̬ VARCHAR(50),
--���������� VARCHAR(50),
--����� VARCHAR(50),
--�۸� VARCHAR(50),
--PRIMARY KEY(ISBN,����));