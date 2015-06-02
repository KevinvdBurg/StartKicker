--GEBRUIKTE SOFTWARE: Java(TM) Platform	1.7.0_75 - Oracle IDE	4.0.3.16.84

DROP TABLE Kickstarter_Account CASCADE constraints;
DROP TABLE Kickstarter_URL CASCADE constraints;
DROP TABLE Kickstarter_User CASCADE constraints;
DROP TABLE Kickstarter_Admin CASCADE constraints;
DROP TABLE Kickstarter_Project CASCADE constraints;
DROP TABLE Kickstarter_Content CASCADE constraints;
DROP TABLE Kickstarter_Pages CASCADE constraints;
DROP TABLE Kickstarter_Category CASCADE constraints;
DROP TABLE Kickstarter_SubCategory CASCADE constraints;
DROP TABLE Kickstarter_Rewards CASCADE constraints;
DROP TABLE Kickstarter_Backing CASCADE constraints;

Create table Kickstarter_Account(
Account_ID          Number(4) PRIMARY KEY,
Email               VARCHAR2(100) NOT NULL,
Phone               NUMBER(10),
KickPassword        VARCHAR2(50) NOT NULL,
KickName            VARCHAR2(100) NOT NULL,
Picture             VARCHAR2(500),
Biography           VARCHAR2(500),
KickLocation        VARCHAR2(100),
TimeZone            VARCHAR2(500),
Vanity_URL          VARCHAR2(100),
Rights              VARCHAR2(5) NOT NULL
);

Create table Kickstarter_URL(
URL_ID              Number(4) PRIMARY KEY,
Adres               VARCHAR2(100) NOT NULL,
Account_ID          Number(4) NOT NULL
); 

Create table Kickstarter_User(
User_ID             Number(4) NOT NULL,
KickUser            VARCHAR2(50)
);

Create table Kickstarter_Admin(
Admin_ID            Number(4) NOT NULL,
KickAdmin           VARCHAR2(50),
WorkEmail           VARCHAR2(100),
Salary              Number(5),
Department          VARCHAR2(50) NOT NULL
);

Create table Kickstarter_Project(
Project_ID          Number(4) PRIMARY KEY,
Account_ID          Number(4),
Title               VARCHAR2(50) NOT NULL,
ShortBlurb          VARCHAR2(150),
Category_ID         Number(4) NOT NULL,
Subcategory_ID      Number(4),
Project_location    VARCHAR2(150) NOT NULL,
Funding_duration    Number(4) NOT NULL,
Funding_goal        Number(9) NOT NULL,
ProjectVideo        VARCHAR2(100),
ProjectDescription  VARCHAR2(500),
RisksAndChallenges  VARCHAR2(1000)
);

Create table Kickstarter_Content(
Content_ID          Number(4) PRIMARY KEY,
Page_ID             Number(4),
Project_ID          Number(4),
Head                VARCHAR2(50),
Text                VARCHAR2(2000)
);

Create table Kickstarter_Pages(
Page_ID             Number(4) PRIMARY KEY,
URL                 VARCHAR2(100)
);

Create table Kickstarter_Category(
Category_ID         Number(4) PRIMARY KEY,
KickName            VARCHAR2(50)  NOT NULL UNIQUE
);

Create table Kickstarter_SubCategory(
Subcategory_ID      Number(4) PRIMARY KEY,
Category_ID         Number(4) NOT NULL,
KickName            VARCHAR2(50) NOT NULL UNIQUE
);

Create table Kickstarter_Rewards(
Reward_ID           Number(4) PRIMARY KEY,
Project_ID          Number(4) NOT NULL,
KickName            VARCHAR2(50) NOT NULL,
PrevReward_ID       Number(4),
Price               Number(9)NOT NULL,
Description         VARCHAR2(150),
EstimatedDelivery   VARCHAR2(50),
ShippingDetails     VARCHAR2(50),
BackerCount         Number(9) DEFAULT 0,
LimitQuantity       Number(4)
);

Create table Kickstarter_Backing(
Backing_ID          Number(4) PRIMARY KEY,
Account_ID          Number(4),
Project_ID          Number(4),
PledgeAmount        Number(9) NOT NULL,
Betaald             Number(1)
);

Alter Table Kickstarter_URL
Add CONSTRAINT  FK_Url1 FOREIGN KEY (Account_ID) REFERENCES Kickstarter_Account(Account_ID);

Alter Table Kickstarter_User
Add CONSTRAINT  FK_User1 FOREIGN KEY (User_ID) REFERENCES Kickstarter_Account(Account_ID);
  
Alter Table Kickstarter_Admin
Add CONSTRAINT  FK_Admin1 FOREIGN KEY (Admin_ID) REFERENCES Kickstarter_Account(Account_ID);

Alter Table Kickstarter_Project
Add CONSTRAINT  FK_Project1 FOREIGN KEY (Account_ID) REFERENCES Kickstarter_Account(Account_ID);
  
Alter Table Kickstarter_Project
Add CONSTRAINT  FK_Project2 FOREIGN KEY (Category_ID) REFERENCES Kickstarter_Category (Category_ID); 
  
Alter Table Kickstarter_Project
Add CONSTRAINT  FK_Project3 FOREIGN KEY (Subcategory_ID) REFERENCES Kickstarter_SubCategory (Subcategory_ID);
  
Alter Table Kickstarter_SubCategory
Add CONSTRAINT  FK_SubCategory1 FOREIGN KEY (Category_ID) REFERENCES Kickstarter_Category (Category_ID);
  
Alter Table Kickstarter_Rewards
Add CONSTRAINT  FK_Rewards1 FOREIGN KEY (Project_ID) REFERENCES Kickstarter_Project (Project_ID);
  
Alter Table Kickstarter_Rewards
Add CONSTRAINT  FK_Rewards2 FOREIGN KEY (PrevReward_ID) REFERENCES Kickstarter_Rewards (Reward_ID);
  
Alter Table Kickstarter_Backing
Add CONSTRAINT  FK_Backing1 FOREIGN KEY (Project_ID) REFERENCES Kickstarter_Project (Project_ID);
  
Alter Table Kickstarter_Backing
Add CONSTRAINT  FK_Backing2 FOREIGN KEY (Account_ID) REFERENCES Kickstarter_Account (Account_ID);

Alter Table Kickstarter_Backing
Add CONSTRAINT CH_BACKING check (PLEDGEAMOUNT > 10);

Alter Table Kickstarter_Content
Add CONSTRAINT  FK_Content1 FOREIGN KEY (Project_ID) REFERENCES Kickstarter_Project (Project_ID);

Alter Table Kickstarter_Content
Add CONSTRAINT  FK_Content2 FOREIGN KEY (Page_ID) REFERENCES Kickstarter_Pages (Page_ID);

