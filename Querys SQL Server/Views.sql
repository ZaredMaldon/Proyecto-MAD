use BD_MAD_1
go
/***********************************************************View de Empleados para Gerentes********************************************************************************/
alter view vw_Empleados with encryption
as 
Select e.NoEmpleado as Número,CONCAT(e.Nombre,' ',e.APaterno,' ',e.AMaterno) as Nombre,e.Contratacion as Ingreso,u.Usuario,m.NombreMunicipio as Municipio,CONCAT(d.Colonia,' ',d.Calle,' Int.',d.NoInterior,' Ext.',d.NoExt) as Direccion, e.Telefono1,e.Telefono2
 from Empleados e
Inner join Usuarios u on e.Usuariofk=u.idUsuario
Inner join Direcciones d on e.Direccionfk=d.idDireccion 
Inner join Municipios m on m.idMunicipio=d.MunicipioFk
/*-------------------------------------------------------------- View de Percepciones ----------------------------------------------------------------------------------------*/
go
ALTER view vw_Percepciones
as
SELECT IdPercepcion as ID,NombrePercepcion as Nombre ,CONCAT('$ ',Bono)AS Bono,BonoPorcentaje as Porcentaje from Percepciones;
/*DATENAME(MONTH,FechaAplicada)as Mes,DATEPART(YEAR,FechaAplicada) as Año*/
/*-------------------------------------------------------------- View de Deducciones ----------------------------------------------------------------------------------------*/
go
ALTER view vw_Deducciones
as
SELECT IdDeduccion as ID,NombreDeduccion as Nombre ,CONCAT('$ ',Descuento)AS Descuento,DescuentoPorcentaje as Porcentaje from Deducciones;

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
Select CONCAT(e.Nombre,' ',e.APaterno,' ',e.AMaterno) as Nombre,p.NombrePuesto,d.NombreDpto,d.idDpto as idDpto,p.IdPuesto as idPuesto,e.NoEmpleado as idEmp , pd.SalarioDiario,e.Contratacion from Asiganciones a
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
join Empleados e on e.NoEmpleado=a.Empleadofk
join Departamentos d on d.idDpto=pd.Departamentofk
join Puestos p on p.IdPuesto=pd.Puestofk


/*----------------------------------------------------------- View de PuestoDepartamento -----------------------------------------------------------------------------------*/
go
create view vw_PuesDep
as
SELECT pd.IdPD as IdPD,d.idDpto as idDepartamento,d.NombreDpto as Departamento,p.IdPuesto as idPuesto, p.NombrePuesto as Puesto from  PuestoDepartamento pd
join Departamentos d on pd.Departamentofk=d.idDpto
join Puestos p on pd.Puestofk=p.IdPuesto;

/*------------------------------------------------------------View de Nomina---------------------------------------------------------------------------------------------------*/
go
create view vw_Nomina
as
Select n.IdNomina as [No.Nómina],e.NoEmpleado as[No.Empleado],CONCAT(e.Nombre,' ',e.APaterno,' ',e.AMaterno) as [Nombre Completo],n.FechaNomina as Fecha,Concat('$',n.Sueldo_neto) as SueldoN, Concat('$',n.Sueldo_bruto) as SueldoB,e.Banco as Banco ,e.NoCuenta as [No.Cuenta] from NOMINA n
join Empleados e on e.NoEmpleado=n.Empleadofk

/*-------------------------------------------------------------View Reporte General de Nómina------------------------------------------------------------------------------*/
go
create view vw_ReporteGeneralNomina
as
Select d.NombreDpto as Departamento,p.NombrePuesto as Puesto,CONCAT(e.Nombre,' ',e.APaterno,' ',e.AMaterno) as Nombre,e.Contratacion as [Fecha de Ingreso],dbo.fn_Edad(e.FechaNacimiento) as Edad,pd.SalarioDiario as [Salario Diario] from Empleados e
join Asiganciones a on a.Empleadofk=e.NoEmpleado
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
join Puestos p on p.IdPuesto=pd.Puestofk
join Departamentos d on d.idDpto=pd.Departamentofk

/*-------------------------------------------------------------View Reporte Headcounter parte 2------------------------------------------------------------------------------*/
go
alter view vw_ReporteHeadcounterp2
as
Select d.NombreDpto as Departamento,dbo.fn_ContarEmpleados(d.idDpto) as [Cantidad de Empleados] from Departamentos d
/*-------------------------------------------------------------View ReporteNomina----------------------------------------------------------------------------------------------*/
go
alter view vw_ReporteNomina
as
Select d.NombreDpto as Departamento,DATEPART(YEAR,n.FechaNomina) as Año,DATEPART(MONTH,n.FechaNomina) as Mes,DBO.fn_SumatoriaSBSN(1,d.idDpto) as [Sueldo Bruto Dpto.],DBO.fn_SumatoriaSBSN(2,d.idDpto) as [Sueldo Neto Dpto.] from NOMINA n
join Asiganciones a on a.Empleadofk=n.Empleadofk
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
join Departamentos d on d.idDpto=pd.Departamentofk


