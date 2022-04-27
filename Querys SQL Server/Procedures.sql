use BD_MAD_1;
/*--------------------------------------------validacion login ------------------------------------------------*/
go
create procedure SP_ValidaUser 
@u varchar(10),
@p varchar(10),
@Opc int 

as
begin
if(@Opc=1)
begin
Select Usuario,Contraseña from Usuarios where (Usuario=@u and Contraseña=@p)and(Tipo like 'Gerente');
end
else if(@Opc=2)
begin 
Select Usuario,Contraseña from Usuarios where (Usuario=@u and Contraseña=@p)and(Tipo like 'Empleado');
end

end
/*-----------------------------------------------------------------Agregar,Eliminar y Modificar Empleado---------------------------------------------------------------------------------------------------------*/
go
alter procedure ControlEmpleados
@Opc					int,
@Nombre				varchar(25)=null,
@AP						varchar(25)=null,
@AM					varchar(25)=null,
@FechaNac			date=null,
@CURP					char(18)=null,
@NSS					char(11)=null,
@RFC					char(13)=null,
@Email					varchar(50)=null,
@Telefono1			varchar(11)=null,
@Telefono2			varchar(11)=null,
@FContratacion     date=null,
@SalarioDiario		money=null,
@Banco					varchar(30)=null,
@NoCuenta			int=null,
@Usuario				varchar(10)=null,
@Contraseña			varchar(10)=null,
@Tipo					varchar(10)=null,
@Municipio			int = null,/*El municipio lo mandas directo del combobox*/
@CP						varchar(5)=null,
@Colonia				varchar(25)=null,
@Calle					varchar(25)=null,
@Nointerior			smallint = null,
@NoExt					smallint= null,
@IdUsuario			int = null,
@IdDireccion			int = null,
@IdEmpleado		int = null
as
begin

if(@Opc=1)/*Agregar Empleado*/
begin
 Insert into Usuarios (Usuario,Contraseña,Tipo) values(@Usuario,@Contraseña,@Tipo);
 SET  @IdUsuario=(SELECT @@IDENTITY);

 Insert into Direcciones(MunicipioFk,Cp,Colonia,Calle,NoInterior,NoExt) values (@Municipio,@CP,@Colonia,@Calle,@Nointerior,@NoExt);
 SET @IdDireccion=(SELECT @@IDENTITY);

 Insert into Empleados(Nombre,APaterno,AMaterno,FechaNacimiento,CURP,NSS,RFC,Email,Telefono1,Telefono2,Contratacion,Direccionfk,Usuariofk,SalarioDiario,Banco,NoCuenta)
 values (@Nombre,@AP,@AM,@FechaNac,@CURP,@NSS,@RFC,@Email,@Telefono1,@Telefono2,@FContratacion,@IdDireccion,@IdUsuario,@SalarioDiario,@Banco,@NoCuenta);
end

if(@Opc=2)/*Modificar Empleado*/
begin
UPDATE Usuarios SET Usuario=@Usuario,Contraseña=@Contraseña 
from Empleados e join Usuarios u
on e.Usuariofk=u.idUsuario
where e.NoEmpleado=@IdEmpleado;

UPDATE Empleados SET Nombre=@Nombre,APaterno=@AP,AMaterno=@AM,FechaNacimiento=@FechaNac,CURP=@CURP,NSS=@NSS,RFC=@RFC,Email=@Email,Telefono1=@Telefono1,Telefono2=@Telefono2,
Contratacion=@FContratacion,SalarioDiario=@SalarioDiario,Banco=@Banco,NoCuenta=@NoCuenta
from Empleados e join Usuarios u
on e.Usuariofk=u.idUsuario
where e.NoEmpleado=@IdEmpleado;

UPDATE Direcciones SET MunicipioFk=@Municipio,Cp=@CP,Colonia=@Colonia,Calle=@Calle,NoInterior=@Nointerior,NoExt=@NoExt
from Direcciones d
join Empleados e on e.Direccionfk=d.idDireccion
join Usuarios u on e.Usuariofk=u.idUsuario
where e.NoEmpleado=@IdEmpleado;
 
end
if(@Opc=3)/*Eliminar Empleado*/
begin
Delete from Usuarios where idUsuario=@IdUsuario;
Delete from Direcciones where idDireccion=@IdDireccion;
Delete from Empleados where NoEmpleado=@IdEmpleado;
Delete from Asiganciones where Empleadofk=@IdEmpleado;
end
if(@Opc=4)/*Muestra estos datos al Dgv de Empleados desde la vista vw_Empleados*/
begin
Select Número,Nombre,Usuario,Ingreso,Direccion,Telefono1,Telefono2,Salario from vw_Empleados;
end
if(@Opc=5)/*se hace select para pasar los datos al c#*/
begin
Select e.NoEmpleado,e.Nombre,e.APaterno,e.AMaterno,e.CURP,e.NSS,e.RFC,e.Email,m.NombreMunicipio,p.NombrePuesto,de.NombreDpto,d.Calle,d.Colonia,d.Cp,d.NoExt,d.NoInterior,e.FechaNacimiento,e.Contratacion,e.Telefono1,e.Telefono2,e.Banco,
e.NoCuenta,u.Usuario,u.Contraseña,e.SalarioDiario from Empleados e
inner join Direcciones d on d.idDireccion=e.Direccionfk
inner join Municipios m on m.idMunicipio=d.MunicipioFk
inner join Usuarios u on u.idUsuario=e.Usuariofk
inner join Asiganciones a on e.NoEmpleado=a.Empleadofk
inner join Puestos p on p.IdPuesto=a.Puestofk
inner join Departamentos de on de.idDpto=a.Departamentofk 
where NoEmpleado=@IdEmpleado;

end

end
/*---------------------------------------------------------------------------------------- Llenado de Combobox -----------------------------------------------------------------------------------------------------------------------------------*/
go
create procedure SP_LlenadoCombobox
@Opc int
as
begin

if(@Opc=1)/*Selecciona info de municipios para ponerlo en un CB*/
begin
 Select idMunicipio,NombreMunicipio from Municipios;
end 

end

/*-------------------------------------------------------------------------------------- Percepciones------------------------------------------------------------------------------------------------------------------------------------------------*/
go
alter procedure SP_ControlPercepciones
@Opc int,
@idPer int =null,
@NombrePer varchar(25) =null,
@FechaAplicada date =null,
@Bono money= null,
@BonoPorcentaje float =null
as
begin
if(@Opc =1)/*Agregar*/
begin
Insert into Percepciones (NombrePercepcion,FechaAplicada,Bono,BonoPorcentaje) values (@NombrePer,@FechaAplicada,@Bono,@BonoPorcentaje);
end
if(@Opc = 2)/*Eliminar*/
begin
Delete from Percepciones where IdPercepcion=@idPer;
end
if(@Opc = 3)/*Tabla(view)*/
begin
Select ID,Nombre,Mes,Año,Bono,Porcentaje from vw_Percepciones;
end
end

/*----------------------------------------------------------------------------------------------Deducciones------------------------------------------------------------------------------------------------------------------------------------------------*/
go 
alter procedure SP_ControlDeducciones
@Opc int,
@idDeduc int = null,
@NombreDeduc varchar(25) = null,
@FechaAplicada date = null,
@Descuento money=null,
@Porcentaje float = null
as
begin

if(@Opc =1)/*Agregar*/
begin
Insert into Deducciones(NombreDeduccion,FechaAplicada,Descuento,DescuentoPorcentaje) values (@NombreDeduc,@FechaAplicada,@Descuento,@Porcentaje);
end
if(@Opc = 2)/*Eliminar*/
begin
Delete from Deducciones where IdDeduccion=@idDeduc;
end
if(@Opc = 3)/*Tabla(view)*/
begin
Select ID,Nombre,Mes,Año,Descuento,Porcentaje from vw_Deducciones;
end

end


/*---------------------------------------------------------------------------Departamentos-------------------------------------------------------------------------------------*/

go
alter procedure SP_ControlDepto
@Opc int,
@idDepto int = null,
@NombreDepto varchar(25) = null,
@sueldoBase money = null

as
begin

if(@Opc =1)/*Agregar*/
begin
Insert into Departamentos(NombreDpto,SueldoBase) values (@NombreDepto,@sueldoBase);
end
if(@Opc = 2)/*Eliminar*/
begin
Delete from Departamentos where idDpto = @idDepto;
end
end


/*---------------------------------------------------------------------------------------Puesto------------------------------------------------------------------------------------*/
go
alter procedure SP_ControlPuesto
@Opc int,
@IdPuestos int = null,
@NombrePuesto varchar(25) = null,
@NivelSalarial float = null

as
begin

if(@Opc =1)/*Agregar*/
begin
Insert into Puestos(NombrePuesto,NivelSalarial) values (@NombrePuesto,@NivelSalarial);
end
if(@Opc = 2)/*Eliminar*/
begin
Delete from Puestos where IdPuesto = @IdPuestos;
end
end