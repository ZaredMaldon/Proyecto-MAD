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
on PuestoDepartamento
after update
as
Declare @idD int
Declare @idP int
Declare @SueldoBase money
Declare @NivelSalarial float 

Select @idD=i.Departamentofk,@idP=i.Puestofk,@SueldoBase=d.SueldoBase,@NivelSalarial=p.NivelSalarial from u
join Departamentos d on d.idDpto=i.Departamentofk
join Puestos p on p.IdPuesto=i.Puestofk 

Declare @SalarioDiario money
Select @SalarioDiario=dbo.fn_SalarioDiario(@SueldoBase,@NivelSalarial);
Update PuestoDepartamento set SalarioDiario=@SalarioDiario where Departamentofk=@idD and Puestofk=@idP;