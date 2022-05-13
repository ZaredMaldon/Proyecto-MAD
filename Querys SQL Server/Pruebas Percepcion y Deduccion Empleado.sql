Select*from Percepciones_Empleado;
Select*from Deducciones_Empleado;
Select*from Percepciones;
select*from Deducciones;

truncate table percepciones;
truncate table deducciones;
delete from percepciones;
delete from Deducciones;


DBCC CHECKIDENT('Deducciones',RESEED,0);

truncate table Percepciones_Empleado
truncate table Deducciones_Empleado
alter table Percepciones
Drop column FechaAplicada
alter table Deducciones
Drop column FechaAplicada

alter table Percepciones_Empleado
ADD FechaAplicada date
alter table Deducciones_Empleado
ADD FechaAplicada date

alter table Percepciones_Empleado
ADD Constraint PK_PEmp primary key(FechaAplicada,Empleadofk,Deduccionfk)


declare @tabla table(idEmpleado int)
		insert into @tabla(idEmpleado) select idEmp from vw_Asignaciones 
		declare @count int=(select count(idEmpleado) from @tabla)
select top(1) idEmpleado from @tabla order by idEmpleado