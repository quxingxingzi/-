use master
go
-- =========================================================
-- 创建数据库 Library 
-- =========================================================
create database Library
go
use Library
go
--=================================================================================================================
--创建用户表
create table Users
(
	u_Name varchar(16) primary key not null,
	u_Pass varchar(16) not null,
	u_Type char(10),
	u_Stopuser char(2)
)
go

insert into Users values ('admin','1','系统管理员','否');
insert into Users values ('user','123','图书管理员','否');


--==========================================================================================================================================
--创建读者信息表

create table Reader  
(
    Number int    not null ,--编号
    CardID char(5)primary key,  --借书证号
    ReaderName varchar(10)   not null,	--读者姓名
    BorrowNumber int,     --已借阅图书数量 
    IDNumber char(18) ,--身份证号
    ReaderTypeID  char(10),--读者类型：1代表教师，2代表学生
    Mode varchar(10),--书证状态
    RegistrationTime varchar (16),--登记日期
    ValidTime varchar (16),--有效期至
    Sex char(2),	--性别 0--男 1---女
    Dept varchar(20)  ,	--工作单位
    Call varchar(15) --电话

)
go

insert into  Reader values('1','C0001','赵芸',2,'360724199210240797','教师','有效','2012-9-12','2015-9-11','女','培训部','13824230972');
insert into  Reader values('2','C0004','林薇薇',1,'360724199210240797','教师','有效','2012-9-11','2015-9-11','女','培训部','13870641658');
insert into  Reader values('3','C0006','周杰',2,'360724199210240797','职工','有效','2012-9-11','2015-9-11','男','人事处','15970060413');
insert into  Reader values('4','C0007','刘凡',1,'360724199210240797','教师','无效','2010-9-11','2012-9-11','男','财务部','13898971776');
insert into  Reader values('5','C0008','欧阳华',1,'360724199210240797','教师','无效','2010-4-11','2012-9-11','男','财务部','18798971973');
insert into  Reader values('6','C0009','李逍遥',1,'360724199210240797','教师','有效','2012-9-11','2015-9-11','男','学生工作处','13798961013');
insert into  Reader values('7','C000A','杨欣怡',1,'360724199210240797','学生','有效','2012-9-11','2015-9-11','女','学生工作处','13870067123');


--=================================================================================================================================
--创建图书信息表
create table Book                     
(
    Number int  not null ,--编号
    BookID varchar(10) primary key,	--图书编号
    Strichcode varchar(10) ,--条形码
    SlassificationID varchar(5)  ,--分类号
	BookName varchar(40) not null,	--图书名
    Type1 varchar(10) ,--类型
	Author varchar(20)  not null,	--作者
    Translator varchar(20),-- 译者
    ISBN varchar(17),--ISBN码
    Publisher varchar(30),	--出版社
    Revision  varchar(8),--版次
    Format varchar(2),--开本
    Word int,--字数
    Page int ,--页码
    Price int ,	--价格
  	EnterTime varchar (16) not null,--入馆时间
    Qty int	,--库存数
    Extant int ,--可借数
    Circulate bit --是否流通
)
go

insert into Book values('1','B0011','XS001','000AB','网页制作基础','专业类','刘裕','Freax','XORSE','清华出版社','第一版','16','235780','254','22','2009-01-08','20','19','0');
insert into Book values('2','B0002','XS001','000AB','C#程序设计','专业类','张清','Freac','XORSE','水电工程出版社','第二版','16','234345','341','45','2009-01-08','50','49','0');

insert into Book values('3','B0003','XS001','100AB','生活常识','其它类','李德奇','','XORSE','清华出版社','第一版','16','267688','349','18','2008-01-08','40','39','0');
insert into Book values('4','B0004','XS001','100AB','计算机英语','其它类','王城','Freac','XORSE','人民邮电出版社','第五版','16','235676','419','34','2010-01-08','40','39','1');

insert into Book values('5','B0005','XS001','000AB','ASP.NET简易教程','专业类','吴海波','Freac','XORSE','人民邮电出版社','第二版','16','765474','389','69','2010-01-08','50','49','0');
insert into Book values('6','B0006','XS001','100AB','60岁登上健康之门','其它类','洪韶光','','XORSE','清华出版社','第一版','16','156577','443','15','2010-01-08','40','39','1');

insert into Book values('7','B0007','XS001','000AB','JAVA程序设计','专业类','碧名','Freac','XORSE','机械工业出版社','第四版','16','768657','661','25','2010-01-08','20','19','0');
insert into Book values('8','B0008','XS001','000AB','电脑组装与维修','专业类','赵村霞','Freat','XORSE','机械工业出版社','第一版','16','257677','287','28','2010-01-08','20','19','0');

insert into Book values('9','B0009','XS001','000AB','读者','其它类','刘志明','Freat','XORSE','机械工业出版社','第三版','16','357651','1187','38','2010-01-08','20','19','0');
insert into Book values('10','B0010','XS002','100AB','电子电工技术','专业类','李德奇','Freat','XORSE','清华出版社','第二版','16','557677','716','28','2010-01-08','20','19','1');

--===============================================================================================================
--出版社信息
create table Publishing
(
PulNumber int,  --编号
PulName	Varchar(30) primary key not null,--出版社名称
PulAdress	Varchar (50),	--地址
PulExplain	Varchar (100)	--说明
)
go

insert into Publishing values('1','清华大学出版社','','');
insert into Publishing values('2','水电工程出版社','','');
insert into Publishing values('3','复旦大学出版社','','');
insert into Publishing values('4','北京大学出版社','','');
insert into Publishing values('5','山东大学出版社','','');
insert into Publishing values('6','东北财经大学出版社','','');
insert into Publishing values('7','北京语言大学出版社','','');
insert into Publishing values('8','高等教育出版社','','');
insert into Publishing values('9','北京师范出版社','','');
insert into Publishing values('10','人民教育出版社','','');
insert into Publishing values('11','人民文学出版社','','');
insert into Publishing values('12','中国人民大学出版社','','');
insert into Publishing values('13','中国轻工业出版社','','');
insert into Publishing values('14','中国大百科出版社','','');
insert into Publishing values('15','中国金融出版社','','');
insert into Publishing values('16','中国对外出版翻译公司','','');
insert into Publishing values('17','中国社会科学出版社','','');
insert into Publishing values('18','中国地图出版社','','');
insert into Publishing values('19','中国电力出版社','','');
insert into Publishing values('20','中国环境科学出版社','','');
insert into Publishing values('21','人民邮电出版社','','');
insert into Publishing values('22','上海交通大学出版社','','');
insert into Publishing values('23','人民卫生出版社','','');
insert into Publishing values('24','机械工业出版社','','');
insert into Publishing values('25','中国水利水电出版社','','');
insert into Publishing values('26','化学工业出版社','','');
insert into Publishing values('27','人民邮电机械工业出版社','','');
insert into Publishing values('28','电子工业出版社','','');
insert into Publishing values('29','世界知识出版社','','');

--===================================================================================================================

--图书借阅表
create table Borrow
(
	Number int,   --编号
	 CardID char(5)  not null, --借书证号
	 ReaderName varchar(10)  not null,  --读者姓名
     BookID varchar(10),   --图书编号
	 BookName varchar(20) not null,	--图书名
     Author varchar(20)  not null,	--作者
     Publisher varchar(30),	--出版社
     Price int ,	--价格
	 BorrowDate varchar (16) not null,   --借书日期
     BorrowNumber   varchar(2),          --借书数量
     UserName varchar(10), --操作员
     BroTieme varchar(3),  --借阅时长
     IsOverdue Char(2)	--是否超期
)
go

insert into Borrow values('1','C0001','赵芸','B0011','网页制作基础','刘裕','清华出版社','22','2012-9-12','1','user','90','否');
insert into Borrow values('2','C0007','刘凡','B0002','C#程序设计','张清','水电工程出版社','45','2012-10-28','1','user','90','否');

insert into Borrow values('3','C0001','赵芸','B0003','生活常识','李德奇','清华出版社','18','2012-9-22','1','user','90','否');
insert into Borrow values('4','C0004','林薇薇','B0002','C#程序设计','张清','水电工程出版社','45','2012-9-24','1','admin','90','否');

insert into Borrow values('5','C0006','周杰','B0003','生活常识','李德奇','清华出版社','18','2012-9-12','1','user','90','否');

insert into Borrow values('6','C0006','周杰','B0004','计算机英语','王城','人邮出版社','34','2012-10-11','1','admin','90','否');
insert into Borrow values('7','C0008','欧阳华','B0004','计算机英语','王城','人邮出版社','34','2012-11-01','1','user','90','否');

insert into Borrow values('8','C0009','李逍遥','B0003','生活常识','李德奇','清华出版社','18','2012-9-15','1','user','90','否');
insert into Borrow values('9','C000A','杨欣怡','B0002','C#程序设计','张清','水电工程出版社','45','2012-10-7','1','admin','90','否');


--=====================================================================================================================
--续借信息表
create table RenewNote
(
	Number int  not null ,--编号
	CardID	Char (5),  --借书证号
	ReaderName	varChar (10),--	读者姓名
	BookID	Char (10)	,--图书编号
	BookName	Varchar (20),--	图书名称
	Author	Varchar (20),--	图书作者
	Publisher	varchar (30),--	图书出版社
	Price	Int 	,--图书价格
	BorrowDate	varchar (16),--	续借时间
	UserName	Varchar (10)	--操作员
)
go

Insert into RenewNote values('1','C0009','李逍遥','B0003','生活常识','李德奇','清华出版社','18','2012-9-23','user');

--=======================================================================================================================
--创建预借表
create table ReserBroInfo
(
	r_Number     int  , --编号
	r_BookId  varchar(10) not null,   --图书编号
	r_BookName   varchar(40) not null,     --图书名称
	r_BookAuthor	varchar(20),         --图书作者
	r_ReaderId  char(5)  not null,      --读者编号
	r_ReaderName  varchar(10)  not null,       --读者姓名
	r_ReaderSex   char(2),       --读者性别
	r_BookNumber   varchar(2),        --预借数量
	r_BookPrice    int,         --图书价格
    r_Publisher    varchar (30),    --出版社
    r_HandleUsr   varchar(16),	--操作用户
	r_ReadyTime   varchar (16)		--预借时间
) 	
go

insert into ReserBroInfo values ('1','B0011','网页制作基础','刘裕','C0001','赵芸','女','1','22','清华出版社','admin','2012-12-28 9:00')
--=================================================================================================================================
--借阅逾期表
create table OverdueInfo
(
	 Number int  not null ,
	 CardID char(5)  not null, --借书证号
	 ReaderName varchar(10)  not null,  --读者姓名
     BookID varchar(10),   --图书编号
	 BookName varchar(20) not null,	--图书名
     Author varchar(20)  not null,	--作者
     Publisher varchar(30),	--出版社
     Price int ,	--价格
	 BorrowDate varchar (16) not null,   --借书日期
     BorrowNumber   varchar(2),          --借书数量
     UserName varchar(10), --操作员
     SpilthDay int --超期天数
)
go

insert into OverdueInfo values(1,'C0001','赵芸','B0011','网页制作基础','刘裕','清华出版社','22','2012-9-12','1','admin','0');
insert into OverdueInfo values(2,'C0007','刘凡','B0002','C#程序设计','张清','水电工程出版社','45','2012-10-28','1','admin','0');

--insert into OverdueInfo values(3,'C0001','赵芸','B0003','生活常识','李德奇','清华出版社','18','2012-9-22','1','admin','0');
--insert into OverdueInfo values(4,'C0004','林薇薇','B0002','C#程序设计','张清','水电工程出版社','45','2012-9-24','1','admin','0');

--insert into OverdueInfo values(5,'C0006','周杰','B0003','生活常识','李德奇','清华出版社','18','2012-9-12','1','admin','0');

-- insert into OverdueInfo values(6,'C0006','周杰','B0004','计算机英语','王城','人邮出版社','34','2012-10-11','1','admin','0');
--insert into OverdueInfo values(7,'C0008','欧阳华','B0004','计算机英语','王城','人邮出版社','34','2012-11-01','1','admin','0');

-- insert into OverdueInfo values(8,'C0009','李逍遥','B0003','生活常识','李德奇','清华出版社','18','2012-9-15','1','admin','0');
--insert into OverdueInfo values(9,'C000A','杨欣怡','B0002','C#程序设计','张清','水电工程出版社','45','2012-10-7','1','admin','0');


	
--==============================================================================================================================
--创建系统日志表
create table Journal
(
  Number int not null, --编号
  JournalName varchar(10) not null,--员工姓名
  Status  varchar(10),--身份
  EnterTime varchar(16)primary key not null--进入时间
)
go

insert into Journal values('1','admin','系统管理员','2013-1-13');


	
--======================================================================================================================
--创建日志表
create table Backupinfo 
(
	Number int not null, --编号  
	lodUser varchar(12) not null,   --登录用户
	BackupTime varchar(16) not null,    --登录时间
	Type varchar(10) , --操作类型
	BackupWay varchar(100) ,    --备份路径
)
go

insert into Backupinfo values ('1','admin','2012-12-3','数据库还原','C:\');


--==========================================================================================================================
--操作日志
create table HandleNote
(
	HandleNumber  int not null ,     --操作流水号
	HandleType varchar(8) not null,    --操作类别
	HandleUser   varchar(12) not null,       --操作用户
	BookName  varchar(20),     --图书名称
	BookStrichcode   varchar(10)   not null, --图书编号
	ReaderID    char(5)  	not null,--读者卡号
	ReaderName   varchar(10),	--读者姓名
	ReaderSex    char(2),	    --读者性别
	BookNumber    varchar(2),	      --借书数量
	BookPrice     int,        --图书价格
    HandleDate  varchar (16)--操作日期
)
go

insert into HandleNote values('1','归还图书','admin','JAVA程序设计','B0007','C000A','杨欣怡','女','1','25','2012-12-08 08:10')
insert into HandleNote values('2','借阅图书','admin','C#程序设计','B0002','C0006','周杰','男','1','25','2013-1-25 08:10')


--===================================================================================================================
 --罚款日志表
create table PenaltryInfo
(
	Number int  not null, --编号 
	CardID	Char(5) not null,  --读者编号
	ReaderName	Varchar(10) not null,	--读者姓名
	BookName	Varchar(40) not null,	--图书名称
	BookID	Varchar(10) not null,--图书编号
	Type	Varchar(20),	--罚款类型   （损坏、超期）
	PenaltyMoney	money ,	--罚款金额
	Paytime	varchar(16),	--交款时间 (元)
	HandleUser	Varchar (12)	--操作用户
)
go

insert into PenaltryInfo values('1','C0007','刘凡','电子电工技术','B0010','图书损坏',5,'2012-12-3','admin');
insert into PenaltryInfo values('2','C0008','欧阳华','C#程序设计','B0002','超期末还',4.5,'2012-12-3','admin');

--============================================================================================================
--系统设置表
create table SystemSet
(
	TeaBroNumber int,   --教师可借书数量
	StuBroNumber int,     --学生可借书数量
    PayMoney     varchar (3),  --罚款数目
	SetReserDay      int ,   --预借有效天数
    IsOpenOverdue  char(2)  --是否打开逾期表
)
go

insert into SystemSet values (10,4,'0.2','15','否');

--=============================================================================================================================
--创建备忘表
create table Remind
(
     Number int,--备忘编号
     Statue  char (8), --当前状态
     RemindTime varchar (20) ,--备忘时间
     Content varchar (100) ,--备忘内容
     IsRemind  char (2),--是否提示
     Type varchar (20),--提示方式
     IsToReader varchar (10), --是否涉及读者
     Addtime  varchar (20)  --备忘添加时间
)
go

insert into Remind values(1,'尚未提示','2012-12-30 00:00:000','今天要做好备忘窗体！','否','一次提醒','周杰','2012-12-29 00:00:000');

--==========================================================================================================================
--客户端后台信息发布表
create table Information
(
    Information text
)
go
create table Rules
(
    Number int primary key identity(1,1),--发布编号
    RulesTitle varchar(200),
    RulesContent text
)
go
create table Announcement
(
    Number int primary key identity(1,1),--发布编号
    AnnouncementTitle varchar(200),
    AnnouncementContent text
)
go


select Information from Information

select * from Rules

select RulesTitle,RulesContent from Rules


select * from Announcement