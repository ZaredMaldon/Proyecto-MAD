/*-------------------------------------------------------------View GenerarRecibo----------------------------------------------------------------------------------------------*/
go
alter view vw_GenerarRecibo
as 
Select n.IdNomina as [No.Nómina],e.NoEmpleado as[No.Empleado],CONCAT(e.Nombre,' ',e.APaterno,' ',e.AMaterno) as [Nombre Completo],n.FechaNomina as Fecha,
Concat('$',n.Sueldo_neto) as SueldoN, Concat('$',n.Sueldo_bruto) as SueldoB,n.Bancofk as Banco ,n.NoCuentafk as [No.Cuenta], n.SalarioDirario as [Salario Diario], dbo.fn_Diastrabajados(n.FechaNomina, e.Contratacion) as DiasTrabajados, 
e.CURP, e.NSS, e.RFC, n.Puesto as [Puesto], n.Departamento as [Departamento], e.Contratacion from NOMINA n
join Empleados e on e.NoEmpleado = n.Empleadofk
join Usuarios u on e.Usuariofk = u.idUsuario
join Asiganciones a on a.Empleadofk = n.Empleadofk 
join PuestoDepartamento pd on pd.IdPD = a.PuestoDptofk
join Puestos p on p.IdPuesto = pd.Puestofk
join Departamentos d on d.idDpto = pd.Departamentofk


/*----------------------------------------------------------------------------------Generacion de Recibo----------------------------------------------------------------------------------*/
go
alter procedure SP_GenerarRecibo
@Opc int,
@Empleadofk int = null,
@usuario varchar(20) = null,
@contra varchar(20) = null,
@FechaNomina  date = null

as
begin
if (@Opc = 1)
begin
Select NoEmpleado from Empleados e
Join usuarios u on u.idUsuario = e.usuariofk
Where u.usuario=@usuario and u.Contraseña = @contra
end
if(@Opc = 2) /*mostrar*/
begin
SELECT [No.Nómina],[No.Empleado], [Nombre Completo], Fecha, SueldoN, SueldoB, Banco, [No.Cuenta], [Salario Diario], DiasTrabajados, CURP, NSS, RFC, [Puesto],[Departamento], Contratacion from vw_GenerarRecibo 
WHERE [No.Empleado] = @Empleadofk and (MONTH(Fecha)=MONTH(@FechaNomina) and YEAR(Fecha)=YEAR(@FechaNomina))
end
if (@Opc = 3) /*Cargar*/
begin
SELECT IdNomina, Empleadofk,Sueldo_bruto, Sueldo_neto,	Bancofk, NoCuentafk, FechaNomina from NOMINA
WHERE Empleadofk = @Empleadofk;
end
if(@Opc=4)/*Periodo DIA FINAL DEL MES*/
begin
Select CONCAT(FechaNomina,' / ', EOMONTH(FechaNomina)) as Periodo from NOMINA
where Empleadofk=@Empleadofk and (MONTH(FechaNomina)=MONTH(@FechaNomina) and YEAR(FechaNomina)=YEAR(@FechaNomina))
end

end


/*--------------------------------------------------------------------View percepciones/deducciones------------------------------------------------------------------------------------------------*/
go 
ALTER procedure SP_ImportePD
@Opc int,
@idEmp int = null,
@TotalPercepciones money = null,
@TotalDeducciones money = null,
@FechaNomina date = null,
@SueldoBruto money = null


as 
begin
if(@Opc=1)
begin

Select  SUM(p.Bono) + dbo.fn_SumPeDe(1,@SueldoBruto,@FechaNomina,@idEmp) as TotalPercepciones from Percepciones_Empleado pe--suma todas las percepciones del mes del empleado
			join Percepciones p on p.IdPercepcion=pe.Percepcionfk
			join Empleados e on e.NoEmpleado=pe.Empleadofk
			where e.NoEmpleado=@idEmp and (MONTH(pe.FechaAplicada)=MONTH(@FechaNomina) and YEAR(pe.FechaAplicada)=YEAR(@FechaNomina))

end
If(@Opc=2)
begin
Select SUM(ded.Descuento)+dbo.fn_SumPeDe(2,@SueldoBruto,@FechaNomina,@idEmp)as TotalDeducciones  from Deducciones_Empleado de--suma todas las deducciones del mes del empleado
			join Deducciones ded on ded.IdDeduccion=de.Deduccionfk
			join Empleados e on e.NoEmpleado=de.Empleadofk
			where e.NoEmpleado=@idEmp and (MONTH(de.FechaAplicada)=MONTH(@FechaNomina) and YEAR(de.FechaAplicada)=YEAR(@FechaNomina))
end
           
end

/*------------------------------------------------------------Mostrar percepciones y deducciones----------------------------------------------------------*/

go 
create procedure SP_MostrarDedPer
@Opc int,
@idEmp int = null,
@FechaNomina date = null

as
begin
If(@Opc = 1) /*Mostrar percepciones*/
begin
SELECT p.IdPercepcion,p.NombrePercepcion,Concat('$',p.Bono) as Bono,Concat('%',(p.BonoPorcentaje*100)) as Porcentaje from Percepciones_Empleado pE 
join Percepciones p on p.IdPercepcion = pE.Percepcionfk
where pE.Empleadofk = @idEmp and (MONTH(pE.FechaAplicada)=MONTH(@FechaNomina) and YEAR(pE.FechaAplicada)=YEAR(@FechaNomina))
end
if(@Opc = 2) /*Mostrar Deducciones*/
begin
SELECT d.IdDeduccion,d.NombreDeduccion,Concat('$',d.Descuento) as Descuento,Concat('%',(d.DescuentoPorcentaje*100))as Porcentaje from Deducciones_Empleado dE 
join Deducciones d on d.IdDeduccion = dE.Deduccionfk
where dE.Empleadofk = @idEmp and (MONTH(dE.FechaAplicada)=MONTH(@FechaNomina) and YEAR(dE.FechaAplicada)=YEAR(@FechaNomina))
end
end