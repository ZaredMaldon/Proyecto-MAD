/*--------------------------------------------------------------funciones------------------------------------------------------------------------------------*/
/*--------------------------------------------------------------Cálculo de salario diario------------------------------------------------------------------------------------*/
go
CREATE FUNCTION fn_SalarioDiario(@SueldoBase money,@NSalarial float) RETURNS MONEY
AS
BEGIN
DECLARE @SalarioDiario MONEY

Select @SalarioDiario=(@SueldoBase*@NSalarial)
RETURN @SalarioDiario

END
/*---------------------------------------------------------------Sueldo mensual bruto--------------------------------------------------------------------------------------*/
go
CREATE FUNCTION fn_SueldoMensualBruto(@SalarioDiario money,@DiasMes INT) RETURNS MONEY
AS
BEGIN
DECLARE @SueldoBruto MONEY

Select @SueldoBruto=(@SalarioDiario*@DiasMes) 
RETURN @SueldoBruto
END

/*------------------------------------------------------------Obtener dias en un mes --------------------------------------------------------------------------------------*/
go
CREATE FUNCTION fn_DiasdelMes(@Fecha Date) RETURNS INT
AS
BEGIN
DECLARE @NoDias		INT
DECLARE @bis				INT
DECLARE @Mes				INT
DECLARE @Aux				INT	

Select @bis=(DATEPART(YEAR,@Fecha)%4),@Mes=Datepart(MONTH,@Fecha)
Select @Aux=(@Mes%2) 
if(@bis=0)/*Año bis*/
begin
	if(@Aux = 0)/*Para tomar los meses que tienen 30 dias*/
	begin
		if(@Mes=2)/*Febrero*/
		begin
		Select @NoDias=29
		end
		else if(@Mes<>2)/*Abril, junio, septiembre y noviembre*/
		begin 
		Select @NoDias=30
		end
	end
	else if(@Aux<>0)/*Para tomar todos los de mas meses con 31 dias(Enero, marzo, mayo, julio, agosto, octubre y diciembre)*/
	begin
	Select @NoDias=31
	end
end
else if(@bis<>0)/*Año no bis*/
begin
	if(@Aux = 0)/*Para tomar los meses que tienen 30 dias*/
	begin
		if(@Mes=2)/*Febrero*/
		begin
		Select @NoDias=28
		end
		else if(@Mes<>2)/*Abril, junio, septiembre y noviembre*/
		begin 
		Select @NoDias=30
		end
	end
	else if(@Aux<>0)/*Para tomar todos los de mas meses con 31 dias(Enero, marzo, mayo, julio, agosto, octubre y diciembre)*/
	begin
	Select @NoDias=31
	end
end

RETURN @NoDias
END
/*------------------------------------------------------------------------------------ Dias trabajados -----------------------------------------------------------------------------------------*/
go
CREATE FUNCTION fn_Diastrabajados(@Fecha Date,@Ingreso Date) RETURNS INT/*Se obtienen los dias trabajados solo si la persona se inscribe el mes de la nomina*/
AS
BEGIN
Declare @Diastrabajados	int
Declare @Diferencia			int
Declare @Aux					int	
Declare @Diasdelmes			int

Select @Diferencia= DATEDIFF(MONTH,@Ingreso,@Fecha)
--Select DATEDIFF(Day,'20220501',Getdate())
if(@Diferencia=0)/*Si esta en el mismo mes de su ingreso*/
begin
	Select @Aux=DATEPART(DAY,@Ingreso),@Diasdelmes=dbo.fn_DiasdelMes(@Fecha)
	Select @Diastrabajados=@Diasdelmes-@Aux;
end
else
begin
	Select @Diastrabajados=dbo.fn_DiasdelMes(@Fecha)--esto puede ser modificado para que detecte las faltas de cada mes de una persona y restarlas 
end

return @Diastrabajados
END
/*------------------------------------------------------------------------------------ Calcular edad -----------------------------------------------------------------------------------------*/
go
CREATE FUNCTION fn_Edad(@FechaNacimiento date) Returns int
as
BEGIN
Declare @Edad int;
Select @Edad=floor(
(cast(convert(varchar(8),getdate(),112) as int)-
cast(convert(varchar(8),@FechaNacimiento,112) as int) ) / 10000)  

return @Edad
END

/*------------------------------------------------------------------------------------Contar empleados en departamentos con filtro de a;os y meses parte 1 -----------------------------------------------------------------------------------------*/
--Parte1
go
create function fn_ContarEDep(@Opc int,@idDpto int,@idPuesto int,@Año int,@Mes int) returns int
as
BEGIN
Declare @Cuenta int
if(@Opc=1)--Si tiene tanto meses y años
begin
Select @Cuenta=Count(a.Empleadofk) from Asiganciones a
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
join Empleados e on e.NoEmpleado=a.Empleadofk
where (pd.Departamentofk=@idDpto and pd.Puestofk=@idPuesto) and (MONTH(e.Contratacion)=@Mes and YEAR(e.Contratacion)=@Año)
end
if (@Opc=2)--Si tiene solo meses
begin
Select @Cuenta=Count(a.Empleadofk) from Asiganciones a
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
join Empleados e on e.NoEmpleado=a.Empleadofk
where (pd.Departamentofk=@idDpto and pd.Puestofk=@idPuesto) and (MONTH(e.Contratacion)=@Mes )
end
if(@Opc=3)--Si tiene solo años
begin
Select @Cuenta=Count(a.Empleadofk) from Asiganciones a
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
join Empleados e on e.NoEmpleado=a.Empleadofk
where (pd.Departamentofk=@idDpto and pd.Puestofk=@idPuesto) and (YEAR(e.Contratacion)=@Año)
end
if(@Opc=4)--si no tiene mes o anio
begin
Select @Cuenta=Count(a.Empleadofk) from Asiganciones a
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
join Empleados e on e.NoEmpleado=a.Empleadofk
where (pd.Departamentofk=@idDpto and pd.Puestofk=@idPuesto)
end

return @Cuenta
END

/*------------------------------------------------------------------------------------Contar empleados en departamentos sin filtro-----------------------------------------------------------------------------------------*/
go
create function fn_ContarEDep2(@idDpto int,@idPuesto int ) returns int--Todos 
as
BEGIN
Declare @Cuenta int

Select @Cuenta=Count(a.Empleadofk) from Asiganciones a
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
where pd.Departamentofk=@idDpto and pd.Puestofk=@idPuesto

return @Cuenta
END

/*------------------------------------------------------------------------------------Contar empleados en departamentos Parte 2-----------------------------------------------------------------------------------------*/
go
Create function fn_ContarEmpleados(@idDpto int ) returns int--Todos 
as
BEGIN
Declare @Cuenta int

Select @Cuenta=Count(a.Empleadofk) from Asiganciones a
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
where pd.Departamentofk=@idDpto

return @Cuenta
END

go
create function fn_ContarEmpleados2(@Opc int,@idDpto int,@Año int,@Mes int) returns int
as
BEGIN
Declare @Cuenta int
if(@Opc=1)--Si tiene tanto meses y años
begin
Select @Cuenta=Count(a.Empleadofk) from Asiganciones a
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
join Empleados e on e.NoEmpleado=a.Empleadofk
where (pd.Departamentofk=@idDpto) and (MONTH(e.Contratacion)=@Mes and YEAR(e.Contratacion)=@Año)
end
if (@Opc=2)--Si tiene solo meses
begin
Select @Cuenta=Count(a.Empleadofk) from Asiganciones a
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
join Empleados e on e.NoEmpleado=a.Empleadofk
where (pd.Departamentofk=@idDpto) and (MONTH(e.Contratacion)=@Mes )
end
if(@Opc=3)--Si tiene solo años
begin
Select @Cuenta=Count(a.Empleadofk) from Asiganciones a
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
join Empleados e on e.NoEmpleado=a.Empleadofk
where (pd.Departamentofk=@idDpto) and (YEAR(e.Contratacion)=@Año)
end
if(@Opc=4)--si no tiene ni mes ni anio
begin
Select @Cuenta=Count(a.Empleadofk) from Asiganciones a
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
join Empleados e on e.NoEmpleado=a.Empleadofk
where pd.Departamentofk=@idDpto 
end

return @Cuenta
END

/*-------------------------------------------------------Sumatoria de sueldo bruto y neto-----------------------------------------------------------*/
go
create function fn_SumatoriaSBSN(@Opc int,@idDpto int) returns money
as
BEGIN
Declare @SueldoNetoT money
Declare @SueldoBrutoT money
Declare @retorno money

if(@Opc=1)--Sueldo Bruto
begin
Select @SueldoBrutoT =Sum(n.Sueldo_bruto) from NOMINA n
join Asiganciones a on a.Empleadofk=n.Empleadofk
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
where pd.Departamentofk=@idDpto

set @retorno=@SueldoBrutoT
end

if(@Opc=2)--Sueldo Neto
begin
Select @SueldoNetoT=Sum(n.Sueldo_neto) from NOMINA n
join Asiganciones a on a.Empleadofk=n.Empleadofk
join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
where pd.Departamentofk=@idDpto

set @retorno= @SueldoNetoT
end
return @retorno
END

/*-------------------------------------------------------Sumatoria Percepciones y deducciones-----------------------------------------------------------*/
go

create function fn_SumPeDe(@Opc int,@SueldoBruto money,@FechaNomina date,@idEmp int) returns money
as
begin
declare @Suma money
declare @PorcentajeSueldo money


if(@Opc=1)--Percepcioness
begin
	

	Select @Suma= SUM(BonoPorcentaje) from Percepciones_Empleado pe
	join Percepciones p on p.IdPercepcion=pe.Percepcionfk
	join Empleados e on e.NoEmpleado=pe.Empleadofk
	where (MONTH(pe.FechaAplicada) = MONTH(@FechaNomina) and YEAR(pe.FechaAplicada) = YEAR(@FechaNomina)) and pe.Empleadofk=@idEmp

	set @PorcentajeSueldo = @Suma*@SueldoBruto;

end
if(@Opc=2)--Deducciones
begin
	

	Select @Suma = SUM(DescuentoPorcentaje) from Deducciones_Empleado de--suma todas las deducciones del mes del empleado
	join Deducciones ded on ded.IdDeduccion=de.Deduccionfk
	join Empleados e on e.NoEmpleado=de.Empleadofk
	where e.NoEmpleado=@idEmp and (MONTH(de.FechaAplicada)=MONTH(@FechaNomina) and YEAR(de.FechaAplicada)=YEAR(@FechaNomina))

	set @PorcentajeSueldo=(@Suma*@SueldoBruto)


end

return @PorcentajeSueldo
end