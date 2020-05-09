--CREATE DATABASE �����齻��ϵͳ;
USE �����齻��ϵͳ;

----�˶�ע���������ɾ����������б�
DROP TABLE �ִ涩����;
DROP TABLE ���ﳵ��;
DROP TABLE ��Ʒ��;
DROP TABLE ����Ա��;
DROP TABLE �û���;
DROP TABLE ��Ŀ��;
DROP TABLE ��ʷ������;
DROP VIEW ��������ͼ;
DROP VIEW ���ﳵ��ͼ;
DROP VIEW ��Ʒ��ͼ;
DROP VIEW �ִ涩����ͼ;
DROP VIEW ��ʷ������ͼ;

CREATE TABLE ��Ŀ��
(
ISBN VARCHAR(13) PRIMARY KEY,
���� VARCHAR(100) NOT NULL,
���� VARCHAR(30) NOT NULL,
������ VARCHAR(30),
����ʱ�� DATE,
���� FLOAT NOT NULL,
������ BIT NOT NULL,
CHECK(LEN(ISBN)=10 OR LEN(ISBN)=13)
--2007��1��1��ǰ��ISBN��10λ�����;2007��1��1�����°�ISBN��13λ�������
)

CREATE TABLE �û���
(
UID INT PRIMARY KEY,
�ʺ� VARCHAR(16) NOT NULL,
���� VARCHAR(16) NOT NULL,
�ǳ� VARCHAR(20) NOT NULL,
�꼶 VARCHAR(10),
רҵ VARCHAR(10),
���� VARCHAR(25) NOT NULL,
�ֻ� VARCHAR(11) NOT NULL,
��� INT NOT NULL DEFAULT 0,
�ջ���ַ VARCHAR(50),
״̬ VARCHAR(10) NOT NULL,
CHECK (�꼶 IN('��һ','���','����','����')),
CHECK(LEN(�ֻ�)=11),
CHECK (���>=0),
CHECK (״̬ IN ('����','������')),
)

CREATE TABLE ����Ա��
(
AID INT PRIMARY KEY,
�ʺ� VARCHAR(16) NOT NULL,
���� VARCHAR(16) NOT NULL,
���� VARCHAR(10) NOT NULL,
���� VARCHAR(25) NOT NULL,
�ֻ� VARCHAR(11) NOT NULL,
)

CREATE TABLE ��Ʒ��
(
������ INT PRIMARY KEY,
ISBN VARCHAR(13) NOT NULL,
����UID INT NOT NULL,
�۸� FLOAT NOT NULL,
���� INT NOT NULL,
�Ѷ����� INT NOT NULL,
CHECK(�Ѷ�����<=����),
FOREIGN KEY (ISBN) REFERENCES ��Ŀ��(ISBN),
FOREIGN KEY (����UID) REFERENCES �û���(UID)
)

CREATE TABLE �ִ涩����
(
������ INT PRIMARY KEY,
����ʱ�� DATETIME NOT NULL,
������ INT NOT NULL,
����UID INT NOT NULL,
���UID INT NOT NULL,
�۸� FLOAT NOT NULL,
���� INT NOT NULL,
�ջ���ַ VARCHAR(50) NOT NULL,
����״̬ VARCHAR(10),
��ݵ��� VARCHAR(20),
CHECK (����UID != ���UID),
CHECK (���� > 0),
CHECK (����״̬ IN('δ����','�Ѹ���','�ѷ���')),
CHECK ((��ݵ��� IS NOT NULL AND ����״̬ = '�ѷ���') OR (��ݵ��� IS NULL AND ����״̬ != '�ѷ���')),
FOREIGN KEY (������) REFERENCES ��Ʒ��(������),
FOREIGN KEY (����UID) REFERENCES �û���(UID),
FOREIGN KEY (���UID) REFERENCES �û���(UID)
)

CREATE TABLE ��ʷ������
(
������ INT PRIMARY KEY,
����ʱ�� DATETIME NOT NULL,
������ INT NOT NULL,
����UID INT NOT NULL,
���UID INT NOT NULL,
�۸� FLOAT NOT NULL,
���� INT NOT NULL,
�ջ���ַ VARCHAR(50),
����״̬ VARCHAR(10),
��ݵ��� VARCHAR(20),
CHECK (����UID != ���UID),
CHECK (���� > 0),
CHECK (����״̬ IN('���','��ȡ��','����ȡ��','��ֹ����')),
CHECK ((��ݵ��� IS NOT NULL AND ����״̬ = '���') OR (��ݵ��� IS NULL AND ����״̬ != '���')),
)

CREATE TABLE ���ﳵ��
(
������ INT,
UID INT,
���� INT NOT NULL,
��Ч BIT NOT NULL DEFAULT 1,
PRIMARY KEY(������,UID),
)

CREATE UNIQUE INDEX ��Ŀ��_ISBN ON ��Ŀ��(ISBN);
CREATE INDEX �û���_UID ON �û���(UID);
CREATE INDEX ����Ա��_AID ON ����Ա��(AID);
CREATE INDEX ��Ʒ��_������ ON ��Ʒ��(������);
CREATE INDEX �ִ涩����_������ ON �ִ涩����(������);
CREATE INDEX ��ʷ������_������ ON ��ʷ������(������);
CREATE INDEX ���ﳵ��_������ ON ���ﳵ��(������);

GO
CREATE VIEW ��������ͼ
AS
SELECT *
FROM �û���
WHERE ״̬='������';
GO

GO
CREATE VIEW ���ﳵ��ͼ
AS
SELECT ���ﳵ��.������,��Ʒ��.ISBN,����,����,������,����ʱ��,�ǳ� �����ǳ�,����UID,CAST (���� AS DECIMAL(18,2)) ԭ��,CAST (�۸� AS DECIMAL(18,2)) �۸�,���ﳵ��.����,��Ʒ��.����-�Ѷ����� ���,���ﳵ��.��Ч,���ﳵ��.UID
FROM ���ﳵ��,��Ʒ��,��Ŀ��,�û���
WHERE ���ﳵ��.������ = ��Ʒ��.������ AND ��Ʒ��.ISBN = ��Ŀ��.ISBN AND ����UID = �û���.UID
GO

GO
CREATE VIEW ��Ʒ��ͼ
AS
SELECT ������,����,����,��Ʒ��.ISBN,������,����ʱ��,�ǳ� �����ǳ�,UID ����ID,CAST (���� AS DECIMAL(18,2)) ԭ��,CAST (�۸� AS DECIMAL(18,2)) �۸�,����-�Ѷ����� ���,������
FROM ��Ʒ��,��Ŀ��,�û���
WHERE ��Ʒ��.ISBN = ��Ŀ��.ISBN AND ��Ʒ��.����UID = �û���.UID;
GO

GO
CREATE VIEW �ִ涩����ͼ
AS
SELECT ������,������,����UID,Y.�ǳ� �����ǳ�,���UID,X.�ǳ� ����ǳ�,�ջ���ַ,�ִ涩����.�۸�,����,����ʱ��,��ݵ���,����״̬
FROM �ִ涩����,(SELECT UID,�ǳ� FROM �û���) X,(SELECT UID,�ǳ� FROM �û���) Y
WHERE �ִ涩����.���UID = X.UID AND �ִ涩����.����UID = Y.UID
GO

GO
CREATE VIEW ��ʷ������ͼ
AS
SELECT ������,������,����UID,Y.�ǳ� �����ǳ�,���UID,X.�ǳ� ����ǳ�,�ջ���ַ,��ʷ������.�۸�,����,����ʱ��,��ݵ���,����״̬
FROM ��ʷ������,(SELECT UID,�ǳ� FROM �û���) X,(SELECT UID,�ǳ� FROM �û���) Y
WHERE ��ʷ������.���UID = X.UID AND ��ʷ������.����UID = Y.UID
GO

--2018.11.6�Ķ���
--��������������������������û�������Ա����Ʒ����Ŀ��

--2018.11.7�Ķ���
--�����˻�Ʒ��������Ĳ��չ�ϵ
--Ϊ�������������NOT NULLԼ��
--������ͼ�������ͼ
--�����˹���Ա����û���Ĳ�������
--���۸�����ȫ������ΪFLOAT����
--�����е�ID����ȫ������ΪINT����

--2018.11.11�Ķ���
--����Ŀ���"�۸�"���Ը���Ϊ"����"
--���鵥������������ߡ����������Ե�VARCHARȫ���ӳ�ΪVARCHAR(30)

--2018.12.3�Ķ���
--Ϊ�û����������"״̬",���޶�Ϊ("����","������")
--���û����"����"���Ե�VARCHAR�ӳ�ΪVARCHAR(20)
--����Ŀ���"����"���Ե�VARCHAR�ӳ�ΪVARCHAR(100)
--������ͼ����������ͼ

--2018.12.3�Ķ���
--���û����"�꼶"�����޶�Ϊ('��һ','���','����','����')
--Ϊ��Ʒ���������"����"

--2018.12.5�Ķ���
--���û����"����"���Ը���Ϊ"�ǳ�"

--2018.12.6�Ķ���
--����������"���ﳵ��"
--Ϊ��������������"״̬"��������(״̬ IN('δ����','�Ѹ���','�ѷ���')),
--������������ʷ������,����"״̬" IN('���','ȡ��')

--2018.12.7�Ķ���
--����Ʒ���"�Ƿ�Ϊ�鵥"����ɾ��
--������Ʒ��ͼ,���ﳵ��ͼ
--����Ʒ���"������"���Դ�VARCHAR(10)�ı�ΪINT

--2018.12.10�Ķ���
--Ϊ��Ŀ����������"������",����ΪBIT,���ڿ����Ƿ������ϼ�
--�޸�"��Ʒ��ͼ"����ѯ����"������"
--����ʷ�������"״̬"���Ե������� IN('���','ȡ��') ��Ϊ IN('���','��ȡ��','����ȡ��','��ֹ����')
--ע�����е�"��ֹ����"״̬Ϊ�����鼮֮��ȡ�������ڽ��׵�δ�����Ķ����γɵ�״̬
--�����ﳵ��Ĳ��չ�ϵ��FOREIGN KEY (������) REFERENCES ��Ʒ��(������)ɾ��
--ע���Է������¼ܻ�Ʒ֮�󣬲�����ͻ
--Ϊ���ﳵ����������"��Ч"������ΪBIT����"��ֹ����"����"�¼ܻ�Ʒ"����֮����л���ֵ����ʾ��ʧЧ
--��Ӧ���޸Ĺ��ﳵ��ͼ��ʹ֮��ʾ����"��Ч"
--���û����"Ĭ���ջ���ַ"����Ϊ"�ջ���ַ"

--2018.12.11�Ķ���
--Ϊ���ﳵ����������"ISBN"��Ϊ�˽����Ʒ������Ӧ�ɾȥ�����Ҳ�����Ӧ��ͼ����Ϣ������
--������ʶ�������ﳵ��Ӧ�ö����ش洢�ܶ����ݣ���ʱ��ʱˢ�����ݣ�����
--Ϊ���ﳵ����������"����UID","�۸�"
--Ϊ���ﳵ�����Լ����FOREIGN KEY (ISBN) REFERENCES ��Ŀ��(ISBN)
--���Ϲ��ڹ��ﳵ���˼��ȫ�����󣬸�ԭ������
--ɾ�����ﳵ���Լ����FOREIGN KEY (UID) REFERENCES �û���(UID)

--2018.12.12�Ķ���
--Ϊ�������������"��ݵ���"
--Ϊ����������Լ����((��ݵ��� IS NOT NULL AND ����״̬ = '�ѷ���') OR (��ݵ��� IS NULL AND ����״̬ != '�ѷ���'))
--Ϊ����������Լ����CHECK (���� > 0)
--Ϊ��ʷ�������������"��ݵ���"
--Ϊ��ʷ����������Լ����((��ݵ��� IS NOT NULL AND ����״̬ = '���') OR (��ݵ��� IS NULL AND ����״̬ != '���'))
--Ϊ��ʷ����������Լ����CHECK (���� > 0)

--��"������"����Ϊ"�ִ涩����"
--��"������ͼ"����Ϊ"�ִ涩����ͼ"
--����"��ʷ������ͼ"
