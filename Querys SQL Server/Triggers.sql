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

/*---------------------------------------------------------------------Modificar a tabla Puesto departamento el salario diario------------------------------------------------------------------*/
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

/*---------------------------------------------------------------------Modificar a tabla Puesto departamento el salario diario 2------------------------------------------------------------------*/
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

/*---------------------------------------------------------------------Eliminar usuario------------------------------------------------------------------*/
go
create trigger TR_EliminarUsuario
on Empleados
after delete
as
Declare @Usuariofk int

Select @Usuariofk=d.Usuariofk from deleted d
Delete from Usuarios where idUsuario=@Usuariofk; 

/*---------------------------------------------------------------------Eliminar direccion------------------------------------------------------------------*/
go
create trigger TR_EliminarDireccion
on Empleados
after delete
as
Declare @Direccionfk int

Select @Direccionfk=d.Direccionfk from deleted d
Delete from Direcciones where idDireccion=@Direccionfk; 