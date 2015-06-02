--GEBRUIKTE SOFTWARE: Java(TM) Platform	1.7.0_75 - Oracle IDE	4.0.3.16.84

--1--Get the email, name plegeamount and project title from all the persons that called "Jan"
Select ac.EMAIL as "Email", ac.KICKNAME as "Account Name", bc.PLEDGEAMOUNT as "Pledge Amount", pr.TITLE as "Project Title"
FROM KICKSTARTER_ACCOUNT ac
INNER JOIN KICKSTARTER_BACKING bc
ON ac.ACCOUNT_ID = bc.ACCOUNT_ID
INNER JOIN KICKSTARTER_PROJECT pr
ON bc.PROJECT_ID = pr.PROJECT_ID
WHERE ac.KICKNAME='Jan';

--2--Get all rewards form the catagory "Games"
Select pr.TITLE as "Project Title", rw.KICKNAME as "Reward name"
FROM KICKSTARTER_PROJECT pr
INNER JOIN KICKSTARTER_REWARDS rw
ON pr.PROJECT_ID = rw.PROJECT_ID
INNER JOIN KICKSTARTER_CATEGORY ca
ON pr.CATEGORY_ID = ca.CATEGORY_ID
WHERE ca.KICKNAME = 'Games';

--3--Get a prev rewards from a Reward
SELECT rw.KICKNAME as "Reward Name", prw.KICKNAME as "Prev Reward"
FROM KICKSTARTER_REWARDS prw 
INNER JOIN KICKSTARTER_REWARDS rw 
ON prw.REWARD_ID = rw.PREVREWARD_ID ;

--4--Get the pledge amount per Account that are higher than the avg
SELECT ac.KICKNAME, bc.PLEDGEAMOUNT
FROM KICKSTARTER_ACCOUNT ac
INNER JOIN KICKSTARTER_BACKING bc
ON ac.ACCOUNT_ID = bc.ACCOUNT_ID
WHERE bc.PLEDGEAMOUNT > (
          SELECT AVG(bc.PLEDGEAMOUNT)
          FROM KICKSTARTER_BACKING bc);

--5--Get the value and the Name of the pledgeamount that is higher than the avg of the project they have pledge to.
Select pr.TITLE, bc1.PLEDGEAMOUNT, averagePledgeAmount
From KICKSTARTER_BACKING bc1,(SELECT avg(PLEDGEAMOUNT) as averagePledgeAmount
                              FROM KICKSTARTER_BACKING bc2), KICKSTARTER_PROJECT pr
WHERE bc1.PROJECT_ID = pr.PROJECT_ID
AND bc1.PLEDGEAMOUNT > averagePledgeAmount;

--6--Get all Pages, urls and content per Project
SELECT ct.HEAD, ct.TEXT, pa.URL, pr.TITLE
From KICKSTARTER_CONTENT ct
LEFT JOIN KICKSTARTER_PROJECT pr
ON pr.PROJECT_ID = ct.PROJECT_ID
RIGHT JOIN KICKSTARTER_PAGES pa
ON ct.PAGE_ID=pa.PAGE_ID;

--7--Get all admin info
SELECT *
From KICKSTARTER_ACCOUNT ac
FULL OUTER JOIN KICKSTARTER_ADMIN ad
ON ac.Account_ID = ad.ADMIN_ID
WHERE ac.RIGHTS='admin';

--8--Get all URLs per account
SELECT url.ADRES, ac.KICKNAME
FROM KICKSTARTER_URL url
INNER JOIN KICKSTARTER_ACCOUNT ac
ON url.ACCOUNT_ID = ac.ACCOUNT_ID;

  
