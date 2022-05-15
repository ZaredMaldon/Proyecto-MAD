insert Usuarios values ('sam', 'sam*12', 'Gerente')

DELETE FROM Usuarios

SELECT * FROM Departamentos
SELECT * FROM Empleados

Select dbo.fn_Edad('19750303') as edad

Select YEAR(Contratacion),MONTH(Contratacion) from Empleados

declare @e varchar(20)
Select @e=' '
if(@e like ' ')
begin
print 'Nulo'
end

Select Departamento,Puesto,dbo.fn_ContarEDep(1,pd.idDepartamento,pd.idPuesto,2021,1) as [Cantidad Empleados] from vw_PuesDep pd
	where Departamento='Electronica'
	order by Departamento,Puesto