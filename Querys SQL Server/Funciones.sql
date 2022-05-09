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