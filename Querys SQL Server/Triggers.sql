/*---------------------------------------------------------------------Triggers------------------------------------------------------------------*/
/*---------------------------------------------------------------------Agregar a tabla Puesto departamento el salario diario------------------------------------------------------------------*/
go
create trigger TR_SalarioDiario_insert
on PuestoDepartamento
after insert
as
Declare @idD int
Declare @idP int
Declare @SueldoBase money
Declare @NivelSalarial float 

Select @idD=i.Departamentofk,@idP=i.Puestofk,@SueldoBase=d.SueldoBase,@NivelSalarial=p.NivelSalarial from inserted i
join Departamentos d on d.idDpto=i.Departamentofk
join Puestos p on p.IdPuesto=i.Puestofk 

Declare @SalarioDiario money
Select @SalarioDiario=dbo.fn_SalarioDiario(@SueldoBase,@NivelSalarial);
Update PuestoDepartamento set SalarioDiario=@SalarioDiario where Departamentofk=@idD and Puestofk=@idP;


go
create trigger TR_SalarioDiario_update
on Puestos
after update
as
Declare @idD int
Declare @idP int
Declare @SueldoBase money
Declare @NivelSalarial float 

Select @idD=pd.Departamentofk,@idP=i.IdPuesto,@SueldoBase=d.SueldoBase,@NivelSalarial=i.NivelSalarial from inserted i
join PuestoDepartamento pd on pd.Puestofk = i.IdPuesto
join Departamentos d on d.idDpto = pd.Departamentofk

Declare @SalarioDiario money
Select @SalarioDiario=dbo.fn_SalarioDiario(@SueldoBase,@NivelSalarial);
Update PuestoDepartamento set SalarioDiario=@SalarioDiario where Departamentofk=@idD and Puestofk=@idP;


go
create trigger TR_SalarioDiario_update2
on Departamentos
after update
as
Declare @idD int
Declare @idP int
Declare @SueldoBase money
Declare @NivelSalarial float 

Select @idD=i.idDpto,@idP=pd.Puestofk,@SueldoBase=i.SueldoBase,@NivelSalarial=p.NivelSalarial from inserted i
join PuestoDepartamento pd on pd.Departamentofk = i.idDpto
join Puestos p on p.IdPuesto = pd.Puestofk

Declare @SalarioDiario money
Select @SalarioDiario=dbo.fn_SalarioDiario(@SueldoBase,@NivelSalarial);
Update PuestoDepartamento set SalarioDiario=@SalarioDiario where Departamentofk=@idD and Puestofk=@idP;