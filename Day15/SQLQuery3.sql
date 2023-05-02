create table CLIENT_MASTER (
CLIENT_NO VARCHAR(6) PRIMARY KEY NOT NULL,
NAME VARCHAR(20) NOT NULL,
ADDRESS1 VARCHAR(30),
ADDRESS2 VARCHAR(30),
CITY VARCHAR(15),
PINCODE Numeric(8),
STATE VARCHAR(15),
BALDUE Numeric(10,2)
);



insert into		CLIENT_MASTER (CLIENT_NO,NAME,ADDRESS1,ADDRESS2,CITY,STATE,BALDUE) 
values ('C0001','Arun','kolayad','kannavam','kannur','kerala',15000
);


insert into		CLIENT_MASTER (CLIENT_NO,NAME,ADDRESS1,ADDRESS2,CITY,STATE,BALDUE) 
values ('C0008','ArYAN','kolHDFVGFd','kannHGFDavam','kanJHGTur','kerala',15000
);



insert into		CLIENT_MASTER (CLIENT_NO,NAME,ADDRESS1,ADDRESS2,CITY,STATE,BALDUE) 
values ('C0002','Kavya','kuttupuzha','Eritty','Eduki','kerala',17000),
('C0003','Alia','kanpur','mumbai','maharashtra','kerala',25000),
 ('C0004','kiran','kolayad','kannavam','kannur','kerala',17000),
  ('C0005','maneesh','erumbpalam','kuttandu','allappy','kerala',18000);

  insert into		CLIENT_MASTER (CLIENT_NO,NAME,ADDRESS1,ADDRESS2,CITY,STATE,BALDUE) 
values ('C0006','Ivan bayross','thirupur','coyambathur','srk street','thamizhnadu',15000);


select *from CLIENT_MASTER;


 create table PRODUCT_MASTER (
PRODUCT_NO VARCHAR(6) PRIMARY KEY NOT NULL,
DESCRIPTION VARCHAR(20) NOT NULL,
PROFITPERC NUMERIC(4,2) NOT NULL,
UNITMEASURE VARCHAR(30) NOT NULL,
QTYONHAND NUMERIC(8) NOT NULL,
REORDERLVL Numeric(8) NOT NULL,
SELLPRICE NUMERIC(8,2) NOT NULL CHECK(SELLPRICE!=0),
COSTPRICE Numeric(8,2) NOT NULL CHECK(COSTPRICE !=0),
);

INSERT INTO PRODUCT_MASTER (PRODUCT_NO,DESCRIPTION,PROFITPERC,UNITMEASURE,QTYONHAND,REORDERLVL,SELLPRICE,COSTPRICE) VALUES
('P0001','T-SHIRTS',5,'PIECE',60,50,560,440),
('P0002','SHIRTS',15,'PIECE',110,200,780,640),
('P0003','froke',5,'PIECE',80,260,980,740),
('P0004','Midi',15,'PIECE',110,200,780,640),
('P0005','Pants',10,'PIECE',70,230,980,440);

select * from PRODUCT_MASTER;

CREATE TABLE SALESMAN_MASTER (
SALESMANNO VARCHAR(6) PRIMARY KEY NOT NULL,
SALESMANNAME VARCHAR(20) NOT NULL,
ADDRESS1 VARCHAR(30) NOT NULL,
ADDRESS2 VARCHAR(30) NOT NULL,
CITY VARCHAR(20),
PINCODE NUMERIC(8),
STATE VARCHAR(20),
SALAMT NUMERIC(8,2) NOT NULL CHECK(SALAMT !=0),
TGTTOGET NUMERIC(6,2),
YTDSALES NUMERIC(6,2),
REMARKS VARCHAR(60)
);

INSERT INTO Salesman_Master  (SALESMANNO, SALESMANNAME,ADDRESS1,ADDRESS2,CITY,PINCODE,STATE,SALAMT,TGTTOGET,YTDSALES,REMARKS) 
VALUES ('S00001', 'Aman', 'A/14', 'Worli', 'Mumbai', 400002, 'Maharashtra', 3000, 100, 50, 'Good'),
('S00002', 'KIRAN', 'B/15', 'kIOrli', 'Mumbai', 400005, 'Maharashtra', 3500, 110, 70, ' VERY Good'),
('S00003', 'LAKSHAYA', 'AC/16', 'CUSAT', 'ERNAKULAM', 400008, 'KERALA', 4000, 190, 90, 'Good'),
('S00004', 'SOORYA', 'AK/19', 'KOLATHUR', 'KAZHAKUTTAM', 400010, 'MADHYAPRADHESH', 3800, 200, 150, ' AVAERAGE'),
('S00005', 'ASWIN', 'AT/34', 'KOLYAD', 'KULATHOOR', 400020, 'Maharashtra', 3800, 150, 80, 'Good');

SELECT * FROM SALESMAN_MASTER;

CREATE TABLE SALES_ORDER(
ORDERNO VARCHAR(6) PRIMARY KEY NOT NULL,
CLIENTNO VARCHAR(6) FOREIGN KEY REFERENCES CLIENT_MASTER(CLIENT_NO),
ORDERDATE DATE,
DELYADDR VARCHAR(25),
SALESMANNO VARCHAR(6) FOREIGN KEY REFERENCES SALESMAN_MASTER(SALESMANNO),
DELYTYPE CHAR(1) CHECK(DELYTYPE ='P' OR DELYTYPE='F'),
BILLEDYN CHAR(1) CHECK(BILLEDYN='Y' OR BILLEDYN='N'),
DELYDATE date,
ORDERSTATUS VARCHAR(10) Check (ORDERSTATUS='In Process' or
 ORDERSTATUS='Fulfilled' or ORDERSTATUS= 'Backorder'
or  ORDERSTATUS='Cancelled'));

INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus,DELYADDR)
VALUES('O19001', '21-june-02', 'C0001', 'F', 'N', 'S00001', '20-july-02', 'In Process','mumbai');
INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus,DELYADDR)
VALUES('O19002', '21-july-02', 'C0002', 'P', 'Y', 'S00001', '20-AUGUST-02', 'In Process','kannur');
INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus,DELYADDR)
VALUES
('O19003', '21-AUGUST-02', 'C0003', 'F', 'N', 'S00003', '20-MARCH-02', 'BACKORDER','maharashtra');
INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus,DELYADDR)
VALUES
('O19004','21-SEPTEMBER-03','C0004','P','Y','S00004','20-AUGUST-02','CANCELLED','alapuzha');
INSERT INTO Sales_Order (OrderNo, OrderDate, ClientNo, DelyType, BilledYn, SalesmanNo, DelyDate, OrderStatus,DELYADDR)
VALUES('O19005', '21-OCTOBER-05', 'C0005', 'F', 'N', 'S00005', '20-july-05', 'FULFILLED','maharashtra');
SELECT * FROM Sales_Order;


CREATE TABLE SALES_ORDER_DETAILS(
ORDERNO VARCHAR(6) FOREIGN KEY  REFERENCES SALES_ORDER(ORDERNO),
PRODUCTNO VARCHAR(6) FOREIGN KEY REFERENCES PRODUCT_MASTER(PRODUCT_NO),
QTYORDERED NUMERIC(8),
QTYDISP NUMERIC(8),
PRODUCTRATE NUMERIC(10,2),
 PRIMARY KEY ( ORDERNO ,PRODUCTNO)
 );

 INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES('O19001', 'P0001', 4, 4, 525);
  INSERT INTO Sales_Order_Details (OrderNo, ProductNo, QtyOrdered, QtyDisp, ProductRate) VALUES
 ('O19002', 'P0004', 8, 3, 925),
 ('O19003', 'P0003', 14, 10, 550),
 ('O19004', 'P0002', 10, 8, 710),
 ('O19005', 'P0005', 40, 24, 250);
 
 

 SELECT * FROM SALES_ORDER_DETAILS;

 
 SELECT NAME FROM CLIENT_MASTER;

 /*Display all the clients who are located in Mumbai. CHANGED TO KANNUR*/

 SELECT * FROM CLIENT_MASTER WHERE CITY='Kannur';

 /* Display all the products whose selling price is > 500 and < 800.*/

 SELECT * FROM PRODUCT_MASTER WHERE SELLPRICE BETWEEN 500 AND 800;

 /* Display Name, City and State of Clients not in the state of
thamizhnadu*/

SELECT NAME,CITY,STATE FROM CLIENT_MASTER WHERE STATE !='thamizhnadu';

/* Display all the information of client_no C0001 and C0002.*/

SELECT * FROM CLIENT_MASTER WHERE CLIENT_NO IN('C0001' ,'C0002');

/* Change the selling price of '1.44 drive' to Rs. 1150.50.*/
UPDATE PRODUCT_MASTER SET SELLPRICE =1150.50 WHERE SELLPRICE=560;

/* Delete the record of client_no C0008.*/
DELETE FROM CLIENT_MASTER WHERE CLIENT_NO='C0008';

/* Display the clients who stay in a city whose second letter is 'a'*/

SELECT * FROM CLIENT_MASTER WHERE CITY LIKE '_a%';

/* Count the number of products having price greater than or equal to
800.*/

SELECT COUNT(PRODUCT_NO) FROM PRODUCT_MASTER WHERE SELLPRICE >= 800;

 /* Display qtyordered, qtydisp and balancedqty (not in table). - NOT GET*/



 /* Make Client_no as primary key in client_master. - already done */

/* Add a new column phone_no in the client_master table.)*/
ALTER TABLE CLIENT_MASTER Add PHONE_NO VARCHAR(10);

/* Add the not null constraint in the product_master table with the
column description, profit percent, sell price and cost price. - ALREADY DONE*/

/* Change size of name column to 60 in client_master table.*/
ALTER TABLE CLIENT_MASTER 
ALTER COLUMN NAME VARCHAR(60);

/*  Change size of name column to 60 in client_master table.*/
ALTER TABLE CLIENT_MASTER 
DROP COLUMN PINCODE;

SELECT * FROM CLIENT_MASTER;

/* Find out the products, which have been sold to 'Arun' */ 
SELECT CLIENT_MASTER.NAME,SALES_ORDER.ORDERNO FROM CLIENT_MASTER  
JOIN SALES_ORDER ON SALES_ORDER.CLIENTNO= CLIENT_MASTER.CLIENT_NO 
WHERE NAME='Arun';

/* Another method */

select PRODUCT_MASTER.PRODUCT_NO,PRODUCT_MASTER.DESCRIPTION,PRODUCT_MASTER.PROFITPERC from PRODUCT_MASTER inner join SALES_ORDER_DETAILS 
on PRODUCT_MASTER.PRODUCT_NO = SALES_ORDER_DETAILS.PRODUCTNO
join SALES_ORDER on SALES_ORDER.ORDERNO = SALES_ORDER_DETAILS.ORDERNO

where CLIENTNO='C0001'


/*  Finding out the products and their quantities that will have to be delivered in the FROM A SPECIFIED month. */
SELECT * FROM  SALES_ORDER_DETAILS
JOIN SALES_ORDER ON SALES_ORDER.ORDERNO=SALES_ORDER_DETAILS.ORDERNO 
WHERE DELYDATE='2002-07-20';

/*Listing the ProductNo and description of constantly sold (i.e. rapidly moving) products. */






