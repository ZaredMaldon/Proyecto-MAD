use BD_MAD_1
go
/***********************************************************View de Empleados para Gerentes********************************************************************************/
create view vw_Empleados with encryption
as 
Select e.NoEmpleado as Número,CONCAT(e.Nombre,' ',e.APaterno,' ',e.AMaterno) as Nombre,e.Contratacion as Ingreso,u.Usuario,CONCAT(d.Colonia,' ',d.Calle,' Int.',d.NoInterior,' Ext.',d.NoExt) as Direccion,CONCAT('$',e.SalarioDiario) as Salario, e.Telefono1,e.Telefono2
 from Empleados e
Inner join Usuarios u on e.Usuariofk=u.idUsuario
Inner join Direcciones d on e.Direccionfk=d.idDireccion 
/*-------------------------------------------------------------- View de Percepciones ----------------------------------------------------------------------------------------*/
go
alter view vw_Percepciones
as
SELECT IdPercepcion as ID,NombrePercepcion as Nombre,DATENAME(MONTH,FechaAplicada)as Mes,DATEPART(YEAR,FechaAplicada) as Año ,CONCAT('$ ',Bono)AS Bono,BonoPorcentaje as Porcentaje from Percepciones;

/*-------------------------------------------------------------- View de Deducciones ----------------------------------------------------------------------------------------*/
go
create view vw_Deducciones
as
SELECT IdDeduccion as ID,NombreDeduccion as Nombre,DATENAME(MONTH,FechaAplicada)as Mes,DATEPART(YEAR,FechaAplicada) as Año ,CONCAT('$ ',Descuento)AS Descuento,DescuentoPorcentaje as Porcentaje from Deducciones;