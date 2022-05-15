select*from Percepciones_Empleado
select*from Percepciones
delete from Percepciones_Empleado where Empleadofk=100020
select*from Deducciones_Empleado
select*from Deducciones


select*from PuestoDepartamento
select * from Empleados

execute  SP_Calculo @FechaNomina='20220101'

update Empleados set Contratacion='20220125' where NoEmpleado=100022

select*from NOMINA

delete from NOMINA 

Declare @Diferencia int
Declare @FechaIngreso date ='20220125',@FechaNomina date = '20200201'
select DATEDIFF(MONTH,@FechaIngreso,@FechaNomina);
if(@Diferencia<=-1)
begin
print @Diferencia
end