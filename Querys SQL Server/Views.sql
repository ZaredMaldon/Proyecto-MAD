use BD_MAD_1
go
/***********************************************************View de Empleados para Gerentes********************************************************************************/
create view vw_Empleados with encryption
as 
Select e.NoEmpleado as N�mero,CONCAT(e.Nombre,' ',e.APaterno,' ',e.AMaterno) as Nombre,e.Contratacion as Ingreso,u.Usuario,CONCAT(d.Colonia,' ',d.Calle,' Int.',d.NoInterior,' Ext.',d.NoExt) as Direccion, e.Telefono1,e.Telefono2
 from Empleados e
Inner join Usuarios u on e.Usuariofk=u.idUsuario
Inner join Direcciones d on e.Direccionfk=d.idDireccion 
/*-------------------------------------------------------------- View de Percepciones ----------------------------------------------------------------------------------------*/
go
create view vw_Percepciones
as
SELECT IdPercepcion as ID,NombrePercepcion as Nombre,DATENAME(MONTH,FechaAplicada)as Mes,DATEPART(YEAR,FechaAplicada) as A�o ,CONCAT('$ ',Bono)AS Bono,BonoPorcentaje as Porcentaje from Percepciones;

/*-------------------------------------------------------------- View de Deducciones ----------------------------------------------------------------------------------------*/
go
create view vw_Deducciones
as
SELECT IdDeduccion as ID,NombreDeduccion as Nombre,DATENAME(MONTH,FechaAplicada)as Mes,DATEPART(YEAR,FechaAplicada) as A�o ,CONCAT('$ ',Descuento)AS Descuento,DescuentoPorcentaje as Porcentaje from Deducciones;

/*-------------------------------------------------------------- View de Departamentos ----------------------------------------------------------------------------------------*/
go
alter view vw_Departamentos
as
SELECT idDpto as ID,NombreDpto as Nombre,CONCAT('$ ',SueldoBase)AS SueldoBase from Departamentos;

/*-------------------------------------------------------------- View de Puestos ----------------------------------------------------------------------------------------*/
go
alter view vw_Puestos
as
SELECT p.IdPuesto as ID,p.NombrePuesto as Puesto,p.NivelSalarial AS [Nivel Salarial],d.NombreDpto AS Departamento, pd.SalarioDiario as [Salario Diario] FROM PuestoDepartamento pd
join Departamentos d on pd.Departamentofk=d.idDpto
join Puestos p on pd.Puestofk=p.IdPuesto;

/*-------------------------------------------------------------- View de Asignaciones ----------------------------------------------------------------------------------------*/
go
alter view vw_Asignaciones
as
Select CONCAT(e.Nombre,' ',e.APaterno,' ',e.AMaterno) as Nombre,p.NombrePuesto,d.NombreDpto,d.idDpto as idDpto,p.IdPuesto as idPuesto,e.NoCuenta as idEmp, from Asiganciones a
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
join Empleados e on e.NoEmpleado=a.Empleadofk
join Departamentos d on d.idDpto=pd.Departamentofk
join Puestos p on p.IdPuesto=pd.Puestofk
join Deducciones_Empleado de on de.Empleadofk=e.NoEmpleado
join Percepciones_Empleado pe on pe.Empleadofk=e.NoEmpleado
join Deducciones du on du.IdDeduccion=de.Deduccionfk
join Percepciones pu on pu.IdPercepcion=pe.Percepcionfk


