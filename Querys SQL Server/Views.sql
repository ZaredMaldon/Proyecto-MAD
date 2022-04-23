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
create view vw_Percepciones
as
SELECT IdPercepcion as ID,NombrePercepcion as Nombre,DATENAME(MONTH,FechaAplicada)as Mes,DATEPART(YEAR,FechaAplicada) as Año ,Bono,BonoPorcentaje as Porcentaje from Percepciones;
