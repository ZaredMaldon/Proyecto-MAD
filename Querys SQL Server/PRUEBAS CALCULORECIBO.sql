	Select SUM(BonoPorcentaje) from Percepciones_Empleado pe
	join Percepciones p on p.IdPercepcion=pe.Percepcionfk
	join Empleados e on e.NoEmpleado=pe.Empleadofk
	where (MONTH(pe.FechaAplicada) = MONTH('20220101') and YEAR(pe.FechaAplicada) = YEAR('20220101')) and pe.Empleadofk=100019

		Select SUM(Bono) from Percepciones_Empleado pe
	join Percepciones p on p.IdPercepcion=pe.Percepcionfk
	join Empleados e on e.NoEmpleado=pe.Empleadofk
	where (MONTH(pe.FechaAplicada) = MONTH('20220101') and YEAR(pe.FechaAplicada) = YEAR('20220101')) and pe.Empleadofk=100019

	Select * from Percepciones_Empleado pe
	join Percepciones p on p.IdPercepcion=pe.Percepcionfk
	join Empleados e on e.NoEmpleado=pe.Empleadofk
	where (MONTH(pe.FechaAplicada) = MONTH('20220101') and YEAR(pe.FechaAplicada) = YEAR('20220101')) and pe.Empleadofk=100019


	Select SUM(DescuentoPorcentaje) from Deducciones_Empleado de--suma todas las deducciones del mes del empleado
	join Deducciones ded on ded.IdDeduccion=de.Deduccionfk
	join Empleados e on e.NoEmpleado=de.Empleadofk
where (MONTH(de.FechaAplicada) = MONTH('20220101') and YEAR(de.FechaAplicada) = YEAR('20220101')) and de.Empleadofk=100019

	Select *from Deducciones_Empleado de--suma todas las deducciones del mes del empleado
	join Deducciones ded on ded.IdDeduccion=de.Deduccionfk
	join Empleados e on e.NoEmpleado=de.Empleadofk
where (MONTH(de.FechaAplicada) = MONTH('20220101') and YEAR(de.FechaAplicada) = YEAR('20220101')) and de.Empleadofk=100019

select Sum(Descuento)from Deducciones_Empleado de
	join Deducciones ded on ded.IdDeduccion=de.Deduccionfk
	join Empleados e on e.NoEmpleado=de.Empleadofk
where (MONTH(de.FechaAplicada) = MONTH('20220101') and YEAR(de.FechaAplicada) = YEAR('20220101')) and de.Empleadofk=100019