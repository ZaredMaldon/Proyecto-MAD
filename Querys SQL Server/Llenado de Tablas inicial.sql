Insert into Municipios values
(001,'Abasolo'),
(002,'Agualeguas'),
(003,'Los Aldamas'),
(004,'Allende'),
(005,'Anahuac'),
(006,'Apodaca'),
(007,'Aramberri'),	
(008,'Bustamante'),
(009,'Cadereyta Jim?nez'),
(010,'El Carmen'),	
(011,'Cerralvo'),
(012,'Ci?nega de Flores'),	
(013,'China'),
(014,'Doctor Arroyo'),	
(015,'Doctor Coss'),
(016,'Doctor Gonz?lez'),	
(017,'Galeana'),
(018,'Garc?a'),	
(019,'San Pedro Garza Garc?a'),
(020,'General Bravo'),	
(021,'General Escobedo'),
(022,'General Ter?n'),
(023,'General Trevi?o'),	
(024,'General Zaragoza'),
(025,'General Zuazua'),	
(026,'Guadalupe'),
(027,'Los Herreras'),	
(028,'Higueras'),	
(029,'Hualahuises'),
(030,'Iturbide'),	
(031,'Ju?rez'),
(032,'Lampazos de Naranjo'),	
(033,'Linares'),
(034,'Mar?n'),	
(035,'Melchor Ocampo'),	
(036,'Mier y Noriega'),
(037,'Mina'),	
(038,'Montemorelos'),
(039,'Monterrey'),	
(040,'Par?s'),
(041,'Pesquer?a'),	
(042,'Los Ramones'),	
(043,'Rayones'),
(044,'Sabinas Hidalgo'),	
(045,'Salinas Victoria'),
(046,'San Nicol?s de los Garza'),	
(047,'Hidalgo'),
(048,'Santa Catarina'),	
(049,'Santiago'),
(050,'Vallecillo'),
(051,'Villaldama');
Select * from Municipios

/*-------------------------------------------------------------------------------------Llenado de Empresa-------------------------------------------------------------------------------------------------------------*/
go

select * from Direcciones
insert into Direcciones (MunicipioFk,Cp,Colonia,Calle,NoExt)values(39,'66054','Centro','Guerrero',250)
Declare @idDirecciones int=(Select @@IDENTITY)
insert into Empresa(RazonSocial,Direccionfk,Telefono,Email,RegistroPatronal,RFC,FechaInicioOp) values ('Zama Industrie S.A',1,85461234,'Zama@zama.com','124456987456120','ZAI2004082K1','20200408');
SELECT*FROM Empresa
select * from Direcciones
