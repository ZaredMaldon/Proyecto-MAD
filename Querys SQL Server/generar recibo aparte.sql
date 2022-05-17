	/*-------------------------------------------------------------View GenerarRecibo----------------------------------------------------------------------------------------------*/
go
alter view vw_GenerarRecibo
as 
Select n.IdNomina as [No.Nómina],e.NoEmpleado as[No.Empleado],CONCAT(e.Nombre,' ',e.APaterno,' ',e.AMaterno) as [Nombre Completo],n.FechaNomina as Fecha,Concat('$',n.Sueldo_neto) as SueldoN, Concat('$',n.Sueldo_bruto) as SueldoB,e.Banco as Banco ,e.NoCuenta as [No.Cuenta], pd.SalarioDiario, dbo.fn_Diastrabajados(n.FechaNomina, e.Contratacion) as DiasTrabajados, e.CURP, e.NSS, e.RFC, e.NoEmpleado, p.NombrePuesto as [Puesto], d.NombreDpto as [Departamento] from NOMINA n
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
@contra varchar(20) = null

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
SELECT [No.Nómina],[No.Empleado], [Nombre Completo], Fecha, SueldoN, SueldoB, Banco, [No.Cuenta], CURP, NSS, RFC, NoEmpleado, [Puesto], [Departamento] from vw_GenerarRecibo 
WHERE [No.Empleado] = @Empleadofk
end
if (@Opc = 3) /*Cargar*/
begin
SELECT IdNomina, Empleadofk,Sueldo_bruto, Sueldo_neto,	Bancofk, NoCuentafk, FechaNomina from NOMINA
WHERE Empleadofk = @Empleadofk;
end
end

Select * from Usuarios

insert Usuarios values ('sss', 's3*', 'Empleado')

/*--------------------------------------------------------------------View percepciones/deducciones------------------------------------------------------------------------------------------------*/
go 
create procedure SP_ImportePD
@idEmp int = null,
@TotalPercepciones money = null,
@TotalDeducciones money = null,
@Fijos money = null,
@FechaNomina date = null,
@SueldoBruto money = null


as 
begin
Select @TotalPercepciones=SUM(p.Bono) + dbo.fn_SumPeDe(1,@SueldoBruto,@FechaNomina,@idEmp) from Percepciones_Empleado pe--suma todas las percepciones del mes del empleado
			join Percepciones p on p.IdPercepcion=pe.Percepcionfk
			join Empleados e on e.NoEmpleado=pe.Empleadofk
			where e.NoEmpleado=@idEmp and (MONTH(pe.FechaAplicada)=MONTH(@FechaNomina) and YEAR(pe.FechaAplicada)=YEAR(@FechaNomina))

            Select @Fijos=Sum(DescuentoPorcentaje)*@SueldoBruto from Deducciones where NombreDeduccion='IMMS' or NombreDeduccion='ISR'

Select @TotalDeducciones=SUM(ded.Descuento)+@Fijos+dbo.fn_SumPeDe(2,@SueldoBruto,@FechaNomina,@idEmp)  from Deducciones_Empleado de--suma todas las deducciones del mes del empleado
			join Deducciones ded on ded.IdDeduccion=de.Deduccionfk
			join Empleados e on e.NoEmpleado=de.Empleadofk
			where e.NoEmpleado=@idEmp and (MONTH(de.FechaAplicada)=MONTH(@FechaNomina) and YEAR(de.FechaAplicada)=YEAR(@FechaNomina))

end

