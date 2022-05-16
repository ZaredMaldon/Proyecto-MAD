/*-------------------------------------------------------------View GenerarRecibo----------------------------------------------------------------------------------------------*/
go
create view vw_GenerarRecibo
as 
Select n.IdNomina as [No.Nómina],e.NoEmpleado as[No.Empleado],CONCAT(e.Nombre,' ',e.APaterno,' ',e.AMaterno) as [Nombre Completo],n.FechaNomina as Fecha,Concat('$',n.Sueldo_neto) as SueldoN, Concat('$',n.Sueldo_bruto) as SueldoB,e.Banco as Banco ,e.NoCuenta as [No.Cuenta], pd.SalarioDiario, dbo.fn_Diastrabajados(n.FechaNomina, e.Contratacion) as DiasTrabajados from NOMINA n
join Empleados e on e.NoEmpleado = n.Empleadofk
join Usuarios u on e.Usuariofk = u.Usuario
join Asiganciones a on a.Empleadofk = n.Empleadofk 
join PuestoDepartamento pd on pd.IdPD = a.PuestoDptofk
join Puestos p on p.IdPuesto = pd.Puestofk
join Departamentos d on d.idDpto = pd.Puestofk


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
SELECT [No.Nómina],[No.Empleado], [Nombre Completo], Fecha, SueldoN, SueldoB, Banco, [No.Cuenta] from vw_GenerarRecibo 
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