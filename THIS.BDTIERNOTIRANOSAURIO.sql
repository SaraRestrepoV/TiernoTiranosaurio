CREATE DATABASE TIERNOTIRANOSAURIO

USE TIERNOTIRANOSAURIO
GO

CREATE TABLE USUARIO (
ID BIGINT PRIMARY KEY,
NOMBRE VARCHAR(30),
USUARIO VARCHAR(30),
CONTRASE�A VARCHAR(60),
TIPO CHAR(1) NOT NULL);
GO

ALTER TABLE USUARIO ADD CHECK (TIPO LIKE'1' OR TIPO LIKE'2');
GO

CREATE TABLE CLIENTE (
ID BIGINT PRIMARY KEY,
NOMBRE VARCHAR(30),
APELLIDO VARCHAR(60));
GO

CREATE TABLE TEL_CLIENTE (
ID_CLIENTE BIGINT,
TELEFONO BIGINT,
PRIMARY KEY (ID_CLIENTE, TELEFONO),
CONSTRAINT FK_ID_CLIENTE foreign key(ID_CLIENTE) references CLIENTE(ID));
GO

CREATE TABLE DIREC_CLIENTE(
ID_CLIENTE BIGINT,
DIRECCION VARCHAR(30),
PRIMARY KEY(ID_CLIENTE, DIRECCION),
CONSTRAINT FK_ID_CLIENTE_DIRECCION foreign key(ID_CLIENTE) references CLIENTE(ID));
GO

CREATE TABLE ESPECIE (
CODIGO BIGINT PRIMARY KEY NOT NULL,
NOMBRE VARCHAR(30) NOT NULL,
);
GO

CREATE TABLE MASCOTAS(
CODIGO BIGINT PRIMARY KEY ,
IMAGEN varchar(100),
NOMBRE VARCHAR(30) NOT NULL,
PRECIO BIGINT NOT NULL,
CANTIDAD INT NOT NULL,
ESPECIE BIGINT FOREIGN KEY REFERENCES ESPECIE (CODIGO));
GO

CREATE TABLE SEXO (
CODIGO BIGINT FOREIGN KEY REFERENCES MASCOTAS(CODIGO),
SEXO CHAR(1),
PRIMARY KEY(CODIGO, SEXO)
);
GO
ALTER TABLE SEXO ADD CHECK(SEXO LIKE'M' OR SEXO LIKE'H' OR SEXO LIKE'O');
GO

CREATE TABLE FACTURA (
ID BIGINT IDENTITY(1,1) PRIMARY KEY NOT NULL,
ID_CLIENTE BIGINT NOT NULL,
TOTAL BIGINT NOT NULL,
IVA BIGINT,
CANTIDAD INT NOT NULL,
CONSTRAINT FK_ID_CLIENTE_FACTURA foreign key(ID_CLIENTE) references CLIENTE(ID));
GO

CREATE TABLE DETALLE_FACTURA(
ID_FACTURA BIGINT,
ID_MASCOTA BIGINT,
CANTIDAD INT NOT NULL,
TOTAL BIGINT,
PRIMARY KEY(ID_FACTURA, ID_MASCOTA),
CONSTRAINT FK_ID_MASCOTA_DETALLE foreign key(ID_MASCOTA) references MASCOTAS(CODIGO),
CONSTRAINT FK_ID_FACTURA_DETALLE foreign key(ID_FACTURA) references FACTURA(ID)
);
GO

INSERT INTO USUARIO VALUES
(65464, 'Gabi', 'Admin', 1234, 1),
(65842, 'Laura', 'Cajero', 6542, 2);
GO

INSERT INTO ESPECIE VALUES
(1000, 'PERRO'),(2000, 'GATO'),(3000, 'CONEJO'),(4000, 'PEZ'),(5000, 'PAJARO'),(7000, 'HURON'),
(8000, 'HAMSTER'),(9000, 'MINIPIGS');
GO

INSERT INTO MASCOTAS (CODIGO, NOMBRE, PRECIO, CANTIDAD, ESPECIE) VALUES 
--PERROS
(1234, 'chihuahua',1000000, 13,1000),(3456, 'bulldog',3400000, 6,1000),
(5556, 'caniche',1700000, 1,1000),(7654, 'yorkshire',1000000, 2,1000),
--GATOS
(7788, 'Abisinio',300000, 2,2000),(3006,'Americano de pelo duro',240000, 6,2000),
(4456,'Siames',150000, 10,2000),(4567,'Azul ruso',560000, 4,2000),
--CONEJOS
(34378,'Belier',310000, 3,3000),(15180, 'No recuerdo', 240000, 8,3000),
(27290, 'Rex',300000, 5,3000),(65859, 'Gigante de Flandes',180000, 2,3000),
--PECES
(10101, 'ajolote',310000, 7,4000),(14176,'caballito de mar',310000, 3,4000),
(30308,'carpa',310000, 20,4000),(90987,'goldfish',310000, 30,4000),
--PAJARO
(67684,'cacatua',1240000, 2,5000),(75342,'canario',570000, 3,5000),
(32566,'pinzon',1380000, 7,5000),(23457,'perico',890000, 8,5000),
--HAMSTER
(787654,'ruso',840000, 4,8000),(212356,'Roborowski',490000, 4,8000),
(345679,'sirio',670000, 8,8000),(909876,'chino',890000, 3,8000),
--HUR�N
(765476,'sable',1670000, 8,7000),(533264,'chocolate',2890000, 4,7000),
(435365,'champan',970600, 9,7000),(986423,'albino',1890000, 5,7000),
--MINNIPIGS
(564754,'Vietnamita',2676000,4,9000),(235536,'Kunekune',2340000, 1,9000);
GO
