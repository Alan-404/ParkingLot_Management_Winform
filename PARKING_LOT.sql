﻿
CREATE DATABASE PARKING_LOT
GO

USE PARKING_LOT

SELECT *
FROM admin

select *
from MANAGE

delete MANAGE where ID_USER= '5'

drop table admin
drop table WORKING
drop table SPECIALIZE
drop table WORK
drop table emp

select *
from admin 
where id =1
-- CREATE TABLE FIELD
CREATE TABLE ADMIN
(
	ID  varchar(20) PRIMARY KEY,
	NAME NVARCHAR(50),
	USERNAME NVARCHAR(50),
	PASS NVARCHAR(50),
	ACCESS VARCHAR(50),
	IMG IMAGE
)

select *
from admin
drop table work
CREATE TABLE WORK 
(
	ID VARCHAR(20) PRIMARY KEY,
	NAME_WORK NVARCHAR(50)
)

CREATE TABLE EMP
(
	ID VARCHAR(50) PRIMARY KEY,
	FNAME NVARCHAR(50),
	LNAME NVARCHAR(50),
	CMND VARCHAR(20),
	BDATE DATE,
	PHONE VARCHAR(20),
	ADDR TEXT,
	GENDER NVARCHAR(6),
	IMG IMAGE
)

CREATE TABLE MANAGE
(
	ID_USER VARCHAR(50) REFERENCES EMP(ID),
	ID_WORK VARCHAR(20) REFERENCES WORK(ID),
	PRIMARY KEY (ID_USER, ID_WORK)
)

CREATE TABLE SPECIALIZE 
(
	ID VARCHAR(20) PRIMARY KEY,
	NAME_SPEC NVARCHAR(100),
	ID_WORK VARCHAR(20) REFERENCES WORK(ID)
)

select *
from WORKing

select *
from emp

CREATE TABLE WORKING 
(
	ID_EMP VARCHAR(50) REFERENCES EMP(ID),
	ID_SPEC VARCHAR(20) REFERENCES SPECIALIZE (ID),
	PRIMARY KEY(ID_EMP, ID_SPEC)
)

select *
from bike

select emp.id, fname, lname, CMND, BDATE, ADDR, GENDER, IMG
from emp, working, SPECIALIZE, work 
where emp.ID = WORKING.ID_EMP and WORKING.ID_SPEC = SPECIALIZE.Id and work.ID = SPECIALIZE.ID_WORK and WORK.ID = '1'


CREATE TABLE SERVICE_FIX
(
	TYPE_TRANSPORT NVARCHAR(10) PRIMARY KEY,
	TYPE_SERVICE NVARCHAR(100),
	PRICE INT CHECK (PRICE >= 0)
)

CREATE TABLE PARKING_AREA
(
	ID_AREA VARCHAR(10) PRIMARY KEY,
	NAME_AREA VARCHAR(50),
	CAPACITY INT
)

CREATE TABLE BIKE
(
	ID VARCHAR(20) PRIMARY KEY,
	PICTURE_USER IMAGE,
	PICTURE_TRANSPORT IMAGE,
	TYPE_OF_CUSTOMER VARCHAR(50),
	TIME_START DATETIME
)

select *
from bike
drop table motor
CREATE TABLE MOTOR
(
	ID VARCHAR(20) PRIMARY KEY,
	PICTURE_USER IMAGE,
	LICENSE_PLATES_PIC IMAGE,
	LICENSE_PLATES VARCHAR(20),
	TYPE_OF_CUSTOMER VARCHAR(50),
	TIME_START DATETIME
)

CREATE TABLE PARKED_MOTOR
(
	ID VARCHAR(20),
	PICTURE_USER IMAGE,
	LICENSE_PLATES_PIC IMAGE,
	LICENSE_PLATES VARCHAR(20),
	TYPE_OF_CUSTOMER VARCHAR(50),
	TIME_START DATETIME,
	RENTAL_TERM DATETIME,
	END_TIME DATETIME,
	PRICE INT
	PRIMARY KEY (ID, TIME_START)
)

CREATE TABLE DETECT_MOTOR
(
	ID INT,
	PLATE VARCHAR(50),
	PRIMARY KEY(ID, PLATE)
)
drop table car
CREATE TABLE CAR 
(
	ID VARCHAR(20) PRIMARY KEY,
	PICTURE_BRAND IMAGE,
	LICENSE_PLATES_PIC IMAGE,
	LICENSE_PLATES VARCHAR(20),
	TYPE_OF_CUSTOMER VARCHAR(50),
	TIME_START DATETIME
)

DROP TABLE PARKED_BIKE
CREATE TABLE PARKED_BIKE
(
	ID VARCHAR(20),
	PICTURE_USER IMAGE,
	PICTURE_TRANSPORT IMAGE,
	TYPE_OF_CUSTOMER VARCHAR(50),
	TIME_START DATETIME,
	RENTAL_TERM DATETIME,
	END_TIME DATETIME,
	PRICE INT
	PRIMARY KEY (ID, TIME_START)
)

CREATE TABLE PARKED_MOTOR
(
	ID VARCHAR(20),
	LICENSE_PLATES_PIC IMAGE,
	PICTURE_USER IMAGE,
	TYPE_OF_CUSTOMER VARCHAR(50),
	TIME_START DATETIME,
	RENTAL_TERM DATETIME,
	END_TIME DATETIME,
	PRICE INT,
	PRIMARY KEY (ID, TIME_START)
)
DROP TABLE PARKED_CAR
CREATE TABLE PARKED_CAR
(
	ID VARCHAR(20),
	PICTURE_BRAND IMAGE,
	LICENSE_PLATES_PIC IMAGE,
	LICENSE_PLATES VARCHAR(20),
	TYPE_OF_CUSTOMER VARCHAR(50),
	TIME_START DATETIME,
	RENTAL_TERM DATETIME,
	END_TIME DATETIME,
	PRICE INT,
	PRIMARY KEY (ID, TIME_START)
)


CREATE TABLE PRICE_PARK
(
	ID INT PRIMARY KEY,
	PRICE_HOUR INT,
	PRICE_DAY INT,
	PRICE_MONTH INT,
	PRICE_YEAR INT
)
drop table PRICE_PARK_A_HOUR


select *
from MANAGE

SELECT *
FROM EMP

delete admin
where id = 3

select *
from admin

select *
from emp
drop table PARKED_BIKE
drop table bike
CREATE TABLE PARKED_BIKE
(
	ID VARCHAR(20),
	PICTURE_USER IMAGE,
	PICTURE_TRANSPORT IMAGE,
	TYPE_OF_CUSTOMER VARCHAR(50),
	TIME_START DATETIME,
	RENTAL_TERM DATETIME,
	END_TIME DATETIME,
	PRICE INT
	PRIMARY KEY (ID, TIME_START)
)
drop table DETECT_CAR
CREATE TABLE DETECT_CAR 
(
	ID INT,
	PLATE VARCHAR(50),
	PRIMARY KEY(ID, PLATE)
)

SELECT *
FROM motor

select *
from PARKED_motor
USE PARKING_LOT
print GETDATE()

select *
from car
SELECT *
FROM PARKED_BIKE

SELECT BIKE.ID, PARKED_BIKE.PICTURE_USER, PARKED_BIKE.PICTURE_TRANSPORT, PARKED_BIKE.TYPE_OF_CUSTOMER, PARKED_BIKE.TIME_START, RENTAL_TERM
FROM BIKE, PARKED_BIKE
WHERE BIKE.ID = PARKED_BIKE.ID AND PARKED_BIKE.PRICE = 0
select *
from admin

SELECT MOTOR.ID, MOTOR.PICTURE_USER, MOTOR.LICENSE_PLATES_PIC, MOTOR.LICENSE_PLATES, MOTOR.TYPE_OF_CUSTOMER, MOTOR.TIME_START, PARKED_MOTOR.RENTAL_TERM
FROM MOTOR, PARKED_MOTOR
WHERE MOTOR.ID = PARKED_MOTOR.ID AND PARKED_MOTOR.PRICE = 0

SELECT CAR.ID, CAR.PICTURE_BRAND, CAR.LICENSE_PLATES_PIC, CAR.LICENSE_PLATES, CAR.TYPE_OF_CUSTOMER, CAR.TIME_START, PARKED_CAR.RENTAL_TERM
FROM CAR, PARKED_CAR
WHERE CAR.ID = PARKED_CAR.ID AND PARKED_CAR.PRICE = 0

CREATE TABLE CONTRACT 
(
	ID VARCHAR(50) PRIMARY KEY,
	
)
drop table customer
CREATE TABLE CUSTOMER 
(
	ID VARCHAR(50) PRIMARY KEY,
	FNAME NVARCHAR(50),
	LNAME NVARCHAR(50),
	BDATE DATETIME,
	PHONE VARCHAR(20),
	GENDER VARCHAR(10),
	COUNTRY NVARCHAR(50),
	ADDR TEXT,
	GMAIL NVARCHAR(50),
	IMG IMAGE
)

select *
from emp

select *
from SPECIALIZE

select EMP.ID, FNAME, LNAME, CMND, BDATE, PHONE, ADDR, GENDER, IMG
from emp, WORKING, SPECIALIZE, WORK
WHERE EMP.ID = WORKING.ID_EMP AND SPECIALIZE.ID_WORK = WORK.ID AND WORKING.ID_SPEC = SPECIALIZE.ID AND WORK.ID = 2

CREATE TABLE RENT
(
	ID_CUS VARCHAR(50) REFERENCES CUSTOMER(ID),
	ID_TRANS VARCHAR(50),
	PRIMARY KEY(ID_CUS, ID_TRANS)
)

CREATE TABLE CONTRACT 
(
	ID VARCHAR(20) PRIMARY KEY,
	ID_CUS VARCHAR(50) REFERENCES CUSTOMER(ID),
	ID_TRANS VARCHAR(50),
	TYPE_CUSTOMER VARCHAR(100),
	TIME_RENT DATETIME,
	RENTAL DATETIME,
	END_TIME DATETIME,
	PRICE INT,
	PAY INT,
	RES INT
)
select *
from PRICE_PARK

CREATE TABLE TRANS_RENT
(
	ID VARCHAR(50) PRIMARY KEY,
	PIC_TRANS IMAGE
)

delete TRANS_RENT
where id = 'R1'

select *
from CUSTOMER
SELECT PARKED_BIKE.ID
FROM BIKE, PARKED_BIKE
WHERE BIKE.ID = PARKED_BIKE.ID AND PARKED_BIKE.PRICE = 0
select *
from PARKED_CAR

select *
from CONTRACT



SELECT * FROM CUSTOMER WHERE ID = 
--EMP.ID, FNAME, LNAME, CMND, BDATE, PHONE, ADDR, GENDER, IMG, SPECIALIZE.NAME_SPEC
select SPECIALIZE.NAME_SPEC 
from emp, WORKING, SPECIALIZE, WORK
WHERE EMP.ID = WORKING.ID_EMP AND SPECIALIZE.ID_WORK = WORK.ID AND WORKING.ID_SPEC = SPECIALIZE.ID AND EMP.ID = 1
select *
from CUSTOMER

CREATE TABLE PRICE_SERVICE
(
	ID VARCHAR(20) REFERENCES SPECIALIZE(ID),
	PRICE INT
)
SELECT ID FROM SPECIALIZE ORDER BY CONVERT (INT, ID)
select *
from SPECIALIZE
ORDER BY ID_WORK
select *
from PARKED_CAR

select *
from emp

delete CONTRACT
CREATE TABLE SERVICE_PARK
(
	ID VARCHAR(20) PRIMARY KEY,
	PIC_USER IMAGE,
	PIC_TRANS IMAGE,
	NAME_SERVICE NVARCHAR(100),
	PRICE INT
)

select *
from SERVICE_PARK

select SPECIALIZE.id, PIC_USER, PIC_TRANS,SPECIALIZE.NAME_SPEC, PRICE
from SPECIALIZE, SERVICE_PARK
WHERE SPECIALIZE.NAME_SPEC = SERVICE_PARK.NAME_SERVICE AND SPECIALIZE.ID_WORK = 2

SELECT *
FROM SERVICE_PARK 

UPDATE SERVICE_PARK
SET NAME_SERVICE = 'Sửa đèn xe'
WHERE ID = 1 OR ID = 2

SELECT *
FROM SPECIALIZE WHERE ID_WORK = 3

SELECT NAME_SPEC, PRICE
FROM SPECIALIZE, PRICE_SERVICE
WHERE SPECIALIZE.ID = PRICE_SERVICE.ID AND SPECIALIZE.ID = '12'

SELECT *
FROM PRICE_SERVICE

SELECT MOTOR.ID, MOTOR.PICTURE_USER, MOTOR.LICENSE_PLATES_PIC, MOTOR.LICENSE_PLATES, MOTOR.TYPE_OF_CUSTOMER, MOTOR.TIME_START, PARKED_MOTOR.RENTAL_TERM 
FROM MOTOR, PARKED_MOTOR 
WHERE MOTOR.ID = PARKED_MOTOR.ID AND PARKED_MOTOR.PRICE = 0 AND MOTOR.ID = 'm2'


SELECT CAR.ID, CAR.PICTURE_BRAND, CAR.LICENSE_PLATES_PIC, CAR.LICENSE_PLATES, CAR.TYPE_OF_CUSTOMER, CAR.TIME_START, PARKED_CAR.RENTAL_TERM 
FROM CAR, PARKED_CAR 
WHERE CAR.ID = PARKED_CAR.ID AND PARKED_CAR.PRICE = 0 and car.id = 'c2'

select *
from car
where id ='c1'

delete car
where id = 'c1'

select *
from PARKED_CAR
select *
from admin

select *
from MANAGE

SELECT * FROM MANAGE WHERE ID_USER = 1
select EMP.ID, FNAME, LNAME, CMND, BDATE, PHONE, ADDR, GENDER, IMG 
from emp, WORKING, SPECIALIZE, WORK 
WHERE EMP.ID = WORKING.ID_EMP AND SPECIALIZE.ID_WORK = WORK.ID AND WORKING.ID_SPEC = SPECIALIZE.ID AND WORK.ID = '1'

SELECT ID FROM EMP ORDER BY CONVERT(INT,ID)

select *
from car
ORDER BY CONVERT(INT,ID)

delete car 
where id = 'c11'


select *
from CUSTOMER
select *
delete CONTRACT


select *
from emp

delete CONTRACT

select *
from  PARKED_CAR



