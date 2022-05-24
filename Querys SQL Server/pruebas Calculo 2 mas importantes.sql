select * from Percepciones_Empleado
select*from Percepciones

alter table Percepciones_Empleado
drop constraint [PK_PEmp]

alter table deducciones_Empleado
drop Constraint [PK_DEmp]

 alter table Percepciones_Empleado
  add idPE int Identity(1,1);
 alter table Percepciones_Empleado
  add primary key ( idPE);

  alter table DEducciones_EMpleado
  add idDe int identity(1,1);
  alter table Deducciones_Empleado
  add primary key(idDE)

  select*from Empleados

  Select*from Percepciones_Empleado
    where FechaAplicada='20220101'
  Select*from Percepciones
  Select*from Deducciones_Empleado
  where FechaAplicada='20220101' 
  select*from Deducciones

  select*from Empleados

  delete from Percepciones_Empleado where FechaAplicada='20220101'
  delete from Deducciones_Empleado where FechaAplicada='20220101'
  
  truncate table nomina
  delete from Deducciones_Empleado where Deduccionfk=10 or Deduccionfk=11--para eliminar todas las percepciones y deducciones fijas porque alteran el producto final
  

  select dbo.fn_SueldoMensualBruto(1,dbo.fn_DiasdelMes('20211101'))

  declare @Bruto money
  set @Bruto=(Select dbo.fn_SueldoMensualBruto(SalarioDiario,dbo.fn_DiasdelMes('20211101'))  from  vw_Asignaciones where idEmp=100046)

  		Select SUM(ded.Descuento)+dbo.fn_SumPeDe(2,15345,'20211101',100046)  from Deducciones_Empleado de--suma todas las deducciones del mes del empleado
			join Deducciones ded on ded.IdDeduccion=de.Deduccionfk
			join Empleados e on e.NoEmpleado=de.Empleadofk
			where e.NoEmpleado=100046 and (MONTH(FechaAplicada)=MONTH('20211202') and YEAR(FechaAplicada)=YEAR('20211202'))


			select*from Usuarios



			select dbo.fn_Diastrabajados('20211101','20211123')