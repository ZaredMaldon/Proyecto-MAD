alter table Empleado
--Add Constraint  FK_Puestp
ADD CONSTRAINT DF_Telefono2 DEFAULT 'No tiene' references ();

alter table PuestoDepartamento
Drop column SalarioDiario 
Select * from PuestoDepartamento

Alter table PuestoDepartamento
Add SalarioDiario money

Select*from Departamentos
select*from Puestos
select*from PuestoDepartamento
select*from Asiganciones
select*from Empleados
select * from Direcciones
select*from Usuarios
Select*from Municipios

Delete from Empleados where NoEmpleado=100009;
Delete from Direcciones
/*Begin try
		Begin Tran
		commit tran
  End try
	Begin catch
			Rollback tran
	end catch*/

	update Asiganciones set PuestoDptofk=1 where IdAsignacion=2
	insert Puestos values ('admin', .8);
	insert Departamentos values ('escolar', 200);
	Insert into PuestoDepartamento(Departamentofk,Puestofk) values (2,2);

	update Puestos set NivelSalarial = .5
	update Departamentos set SueldoBase = 500
	update Departamentos set NombreDpto = 'sam'
	update Puestos set NombrePuesto = 'zared2',  NivelSalarial = .3
	update Puestos set NivelSalarial =.7 where IdPuesto = 2

	insert Usuarios values ('sam', 'sam*12', 'Gerente')
	select * from Usuarios
	delete from Usuarios where idUsuario<>1 and idUsuario<>15
	delete from PuestoDepartamento where Departamentofk = @IdDepto and Puestofk = @IdPuestos;
Delete from Puestos where IdPuesto = 2;

insert Usuarios values ('sam','sam*12','Gerente');
SELECT IdPD,Puestofk,Departamentofk from PuestoDepartamento where Puestofk=6 and Departamentofk=3;

select* from empresa
DBCC CHECKIDENT('Empresa',RESEED,0);  /*RESETEAR EL IDENTITY*/