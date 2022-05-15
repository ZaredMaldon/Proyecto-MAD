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