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
@Telefono1			int=null,
@Telefono2			int = null,
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
UPDATE Usuarios SET Usuario=@Usuario,Contraseña=@Contraseña where idUsuario=@IdUsuario;

UPDATE Empleados SET Nombre=@Nombre,APaterno=@AP,AMaterno=@AM,FechaNacimiento=@FechaNac,CURP=@CURP,NSS=@NSS,RFC=@RFC,Email=@Email,Telefono1=@Telefono1,Telefono2=@Telefono2,
Contratacion=@FContratacion,SalarioDiario=@SalarioDiario,Banco=@Banco,NoCuenta=@NoCuenta
from Empleados e join Usuarios u
on e.Usuariofk=u.idUsuario
where e.Usuariofk=@IdUsuario;

UPDATE Direcciones SET MunicipioFk=@Municipio,Cp=@CP,Colonia=@Colonia,Calle=@Calle,NoInterior=@Nointerior,NoExt=@NoExt
from Direcciones d
join Empleados e on e.Direccionfk=d.idDireccion
join Usuarios u on e.Usuariofk=u.idUsuario
where e.Usuariofk=@IdUsuario;
 
end
if(@Opc=3)/*Eliminar Empleado*/
begin
Delete from Empleados where NoEmpleado=@IdEmpleado;
Delete from Usuarios where idUsuario=@IdUsuario;
Delete from Direcciones where idDireccion=@IdDireccion;
end
if(@Opc=4)
begin
Select Número,Nombre,Usuario,Ingreso,Direccion,Telefono1,Telefono2,Salario from vw_Empleados;
end
end

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