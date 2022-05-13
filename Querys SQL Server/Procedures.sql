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
Alter procedure ControlEmpleados
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
@IdEmpleado		int = null,
@Dpto					varchar(20)=null,
@Puesto				varchar(20)=null,
@IdPD					int=null
as
begin

if(@Opc=1)/*Agregar Empleado*/
begin
		Begin try
			Begin Tran
				Insert into Usuarios (Usuario,Contraseña,Tipo) values(@Usuario,@Contraseña,@Tipo);
				SET  @IdUsuario=(SELECT @@IDENTITY);

				Insert into Direcciones(MunicipioFk,Cp,Colonia,Calle,NoInterior,NoExt) values (@Municipio,@CP,@Colonia,@Calle,@Nointerior,@NoExt);
				SET @IdDireccion=(SELECT @@IDENTITY);

				Insert into Empleados(Nombre,APaterno,AMaterno,FechaNacimiento,CURP,NSS,RFC,Email,Telefono1,Telefono2,Contratacion,Direccionfk,Usuariofk,Banco,NoCuenta)
				values (@Nombre,@AP,@AM,@FechaNac,@CURP,@NSS,@RFC,@Email,@Telefono1,@Telefono2,@FContratacion,@IdDireccion,@IdUsuario,@Banco,@NoCuenta);
				SET @IdEmpleado=(Select @@IDENTITY);


				SELECT @IdPD=IdPD from vw_PuesDep where Puesto=@Puesto and Departamento=@Dpto;

				Insert into Asiganciones(Empleadofk,PuestoDptofk) values (@IdEmpleado,@IdPD);

			commit tran
	End try
	Begin catch
			Rollback tran
	end catch

end

if(@Opc=2)/*Modificar Empleado*/
begin
	Begin try
		Begin Tran
			UPDATE Usuarios SET Usuario=@Usuario,Contraseña=@Contraseña 
			from Empleados e join Usuarios u
			on e.Usuariofk=u.idUsuario
			where e.NoEmpleado=@IdEmpleado;

			UPDATE Empleados SET Nombre=@Nombre,APaterno=@AP,AMaterno=@AM,FechaNacimiento=@FechaNac,CURP=@CURP,NSS=@NSS,RFC=@RFC,Email=@Email,Telefono1=@Telefono1,Telefono2=@Telefono2,
			Contratacion=@FContratacion,Banco=@Banco,NoCuenta=@NoCuenta
			from Empleados e join Usuarios u
			on e.Usuariofk=u.idUsuario
			where e.NoEmpleado=@IdEmpleado;

			UPDATE Direcciones SET MunicipioFk=@Municipio,Cp=@CP,Colonia=@Colonia,Calle=@Calle,NoInterior=@Nointerior,NoExt=@NoExt
			from Direcciones d
			join Empleados e on e.Direccionfk=d.idDireccion
			join Usuarios u on e.Usuariofk=u.idUsuario
			where e.NoEmpleado=@IdEmpleado;
			
			SELECT @IdPD=IdPD from vw_PuesDep where Puesto=@Puesto and Departamento=@Dpto;
			UPDATE Asiganciones set PuestoDptofk=@IdPD where Empleadofk=@IdEmpleado
		commit tran
  End try
	Begin catch
			Rollback tran
	end catch
	
end
if(@Opc=3)/*Eliminar Empleado*/
begin
	Begin try
			Begin Tran
					Delete from Asiganciones where Empleadofk=@IdEmpleado;
					Delete from NOMINA where Empleadofk=@IdEmpleado;
					Delete from Percepciones_Empleado where Empleadofk=@IdEmpleado;
					Delete from Deducciones_Empleado where Empleadofk=@IdEmpleado;
					Delete from Empleados where NoEmpleado=@IdEmpleado;
			Commit tran
	End try
	Begin catch
			Rollback tran
	end catch

end
if(@Opc=4)/*Muestra estos datos al Dgv de Empleados desde la vista vw_Empleados*/
begin
Select Número,Nombre,Usuario,Ingreso,Municipio,Direccion,Telefono1,Telefono2 from vw_Empleados;
end
if(@Opc=5)/*se hace select para pasar los datos al c#*/
begin
Select e.NoEmpleado,e.Nombre,e.APaterno,e.AMaterno,e.CURP,e.NSS,e.RFC,e.Email,m.NombreMunicipio,p.NombrePuesto,de.NombreDpto,d.Calle,d.Colonia,d.Cp,d.NoExt,d.NoInterior,e.FechaNacimiento,e.Contratacion,e.Telefono1,e.Telefono2,e.Banco,
e.NoCuenta,u.Usuario,u.Contraseña,pd.SalarioDiario from Empleados e
inner join Direcciones d on d.idDireccion=e.Direccionfk
inner join Municipios m on m.idMunicipio=d.MunicipioFk
inner join Usuarios u on u.idUsuario=e.Usuariofk
inner join Asiganciones a on e.NoEmpleado=a.Empleadofk
inner join PuestoDepartamento  pd on pd.Departamentofk=a.PuestoDptofk
inner join Puestos p on p.IdPuesto=pd.Puestofk
inner join Departamentos de on de.idDpto=pd.Departamentofk
where NoEmpleado=@IdEmpleado;
end
if(@Opc = 6) /*cambiar solo contra y us*/
begin
UPDATE Usuarios SET Usuario=@Usuario,Contraseña=@Contraseña 
			from Empleados e join Usuarios u
			on e.Usuariofk=u.idUsuario
			where e.NoEmpleado=@IdEmpleado;
end

end
/*---------------------------------------------------------------------------------------- Llenado de Combobox -----------------------------------------------------------------------------------------------------------------------------------*/
go
alter procedure SP_LlenadoCombobox
@Opc int,
@Dpto varchar(20) = null
as
BEGIN

if(@Opc=1)/*Selecciona info de municipios para ponerlo en un CB*/
begin
	Select idMunicipio,NombreMunicipio from Municipios;
end 
if(@Opc=2)/*Llenado de CB departamento*/
begin
	Select idDpto,NombreDpto from Departamentos;
end
if(@Opc=3)/*Llenado de CB Puestos por DPTO*/
begin
	Select ID,Puesto from vw_Puestos where Departamento=@Dpto;
end
if(@Opc=4)/*Llenado de CB Perc por percepciones*/
begin
	Select IdPercepcion,NombrePercepcion from Percepciones;
end
if(@Opc=5)/*Llenado de CB Deduc por Deducciones*/
begin
	Select IdDeduccion,NombreDeduccion from Deducciones;
end
END

/*-------------------------------------------------------------------------------------- Percepciones------------------------------------------------------------------------------------------------------------------------------------------------*/
go
ALTER procedure SP_ControlPercepciones
@Opc int,
@idPer int =null,
@NombrePer varchar(25) =null,
@Bono money= null,
@BonoPorcentaje float =null
as
begin
if(@Opc =1)/*Agregar*/
begin
Insert into Percepciones (NombrePercepcion,Bono,BonoPorcentaje) values (@NombrePer,@Bono,@BonoPorcentaje);
end
if(@Opc = 2)/*Eliminar*/
begin
Delete from Percepciones where IdPercepcion=@idPer;
end
if(@Opc = 3)/*Tabla(view)*/
begin
Select ID,Nombre,Bono,Porcentaje from vw_Percepciones;
end
end

/*----------------------------------------------------------------------------------------------Deducciones------------------------------------------------------------------------------------------------------------------------------------------------*/
go 
alter procedure SP_ControlDeducciones
@Opc int,
@idDeduc int = null,
@NombreDeduc varchar(25) = null,
@Descuento money=null,
@Porcentaje float = null
as
begin

if(@Opc =1)/*Agregar*/
begin
Insert into Deducciones(NombreDeduccion,Descuento,DescuentoPorcentaje) values (@NombreDeduc,@Descuento,@Porcentaje);
end
if(@Opc = 2)/*Eliminar*/
begin
Delete from Deducciones where IdDeduccion=@idDeduc;
end
if(@Opc = 3)/*Tabla(view)*/
begin
Select ID,Nombre,Descuento,Porcentaje from vw_Deducciones;
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
if(@Opc = 3)/*Editar*/
begin 
UPDATE Departamentos SET NombreDpto=@NombreDepto,SueldoBase=@sueldoBase where idDpto=@idDepto;
end
if(@Opc = 4) /*mostrar*/
begin
Select ID ,Nombre,SueldoBase from vw_Departamentos;
end
if (@Opc = 5) /*Cargar*/
begin
SELECT idDpto,NombreDpto, SueldoBase from Departamentos
WHERE idDpto = @idDepto;
end
end


/*---------------------------------------------------------------------------------------Puesto------------------------------------------------------------------------------------*/
go
alter procedure SP_ControlPuestos
@Opc int,
@IdPuestos int = null,
@NombrePuesto varchar(25) = null,
@NivelSalarial float = null,
@Departamento varchar(20) =null,
@IdDepto     int = null

as
begin
Declare @idP		int
Declare @idD	int

if(@Opc =1)/*Agregar*/
begin
	Begin try
		Begin Tran
			Insert into Puestos(NombrePuesto,NivelSalarial) values (@NombrePuesto,@NivelSalarial);
			SET @idP=(SELECT @@IDENTITY);
			Select @idD=idDpto from Departamentos where NombreDpto=@Departamento
			Insert into PuestoDepartamento(Departamentofk,Puestofk) values (@idD,@idP)
		commit tran
	End try
	Begin catch
			Rollback tran
	end catch

end
if(@Opc = 2)/*Eliminar*/
begin
delete from PuestoDepartamento where Puestofk = @IdPuestos;
Delete from Puestos where IdPuesto = @IdPuestos; /*primero se debe eliminar regristro de la tabla puestodepartamento*/
end
if(@Opc = 3)/*Editar*/
begin 
UPDATE Puestos SET NombrePuesto=@NombrePuesto,NivelSalarial=@NivelSalarial where IdPuesto=@IdPuestos
end
if(@Opc = 4) /*mostrar*/
begin
Select ID,Puesto,[Nivel Salarial],Departamento from vw_Puestos;
end
if(@Opc = 5) /* LLENAR DATOS*/
begin
SELECT ID,Puesto,[Nivel Salarial],Departamento, [Salario Diario] from vw_Puestos
WHERE ID = @IdPuestos;
end
end
/*---------------------------------------------------------------------------------------PEDE_Empleado------------------------------------------------------------------------------------*/
go
alter procedure SP_ControlPEDE_Empleado
@Opc					 int,
@Empleadofk		 int	 = null,
@Percepcion			 varchar(25)	 = null,
@Deduccion			 varchar(25)	 = null,
@Departamentofk  int	 = null,
@Deduccionfk		int		=null,
@Percepcionfk		int		=null,
@Fecha					date	=null

as
BEGIN
	Declare @Contador int
	Declare @Cantidad int

	if(@Opc=1)--Agregar Deduccion a Empleado individual
	begin
		Select @Deduccionfk=IdDeduccion from Deducciones where NombreDeduccion=@Deduccion;
		Insert into Deducciones_Empleado(Empleadofk,Deduccionfk,FechaAplicada) values(@Empleadofk,@Deduccionfk,@Fecha);
	end
	if(@Opc=2)--Agregar Percepcion a Empleado individual
	begin
		Select @Percepcionfk=IdPercepcion from Percepciones where NombrePercepcion=@Percepcion;
		Insert into Percepciones_Empleado(Empleadofk,Percepcionfk,FechaAplicada) values(@Empleadofk,@Percepcionfk,@Fecha);
	end
	if(@Opc=3)--Agregar Deducion a empleados de departamento
	begin
		declare @tabla table(idEmpleado int)
		insert into @tabla(idEmpleado) select idEmp from vw_Asignaciones where idDpto=@Departamentofk
		declare @count int=(select count(idEmpleado) from @tabla)

		while @count>0
		begin
			declare @idEmp int=(select top(1) idEmpleado from @tabla order by idEmpleado)

			Select @Deduccionfk=IdDeduccion from Deducciones where NombreDeduccion=@Deduccion;
			Insert into Deducciones_Empleado(Empleadofk,Deduccionfk,FechaAplicada) values(@idEmp,@Deduccionfk,@Fecha);

			delete @tabla where idEmpleado=@idEmp
			set @count = (select count(idEmpleado) from @tabla)
		end

	end
	if(@Opc=4)--Agregar Percepcion a empleados por departamento
	begin

		declare @tabla2 table(idEmpleado int)
		insert into @tabla2(idEmpleado) select idEmp from vw_Asignaciones where idDpto=@Departamentofk
		declare @count2 int=(select count(idEmpleado) from @tabla2)

		while @count2>0
		begin
			declare @idEmp2 int=(select top(1) idEmpleado from @tabla2 order by idEmpleado)

			Select @Percepcionfk=IdPercepcion from Percepciones where NombrePercepcion=@Percepcion;
		Insert into Percepciones_Empleado(Empleadofk,Percepcionfk,FechaAplicada) values(@idEmp2,@Percepcionfk,@Fecha);

			delete @tabla2 where idEmpleado=@idEmp2
			set @count2 = (select count(idEmpleado) from @tabla2)
		end
		
	end
END

/*----------------------------------------------------------------------------------Empresa------------------------------------------------------------------------------------*/

go
alter procedure SP_Empresa
@Opc int,
@idEmpresa int = null,
@RazonSocial varchar(30) = null,
@Direccionfk varchar (50) = null,
@Telefono int = null,
@Email varchar(30) = null,
@RegistroPatronal  varchar(30) = null,
@RFC varchar(20) = null,
@FechaInicioOp date = null

as
begin

/*f(@Opc = 2) Mostrar datos de empresa*/
if(@Opc = 1) /*Mostrar datos de empresa*/
begin
SELECT idEmpresa,RazonSocial,CONCAT(m.NombreMunicipio,' ',d.Colonia,' ',d.Calle,' #',d.NoExt) as Direccion, Telefono, Email, RegistroPatronal,RFC, FechaInicioOp from Empresa
inner join Direcciones d on d.idDireccion=Empresa.Direccionfk
inner join Municipios m on m.idMunicipio=d.MunicipioFk
/*SELECT @idEmpresa as ID,@RazonSocial as RazonSocial , @Direccionfk as Direccionfk,  from Departamentos;*/
end
if (@Opc = 2) /*Cargar*/
begin
SELECT RazonSocial, Direccionfk, Telefono, Email, RegistroPatronal,RFC, FechaInicioOp from Empresa
WHERE idEmpresa = @idEmpresa;
end

end

/*-------------------------------------------------------------------------------------Calculo------------------------------------------------------------------------------------------*/
go
create procedure SP_Calculo
@FechaNomina date = null,
@FechaIngreso date = null

as
BEGIN
Declare @SueldoMensualBruto money,@SueldoBruto money
/*Les falta un where para elegir el empleado*/
Select @SueldoMensualBruto=dbo.fn_SueldoMensualBruto(SalarioDiario,dbo.fn_DiasdelMes(@FechaNomina)) from PuestoDepartamento --Sueldo mensual bruto con todos los dias
Select @SueldoBruto=dbo.fn_SueldoMensualBruto(SalarioDiario,dbo.fn_Diastrabajados(@FechaNomina,@FechaIngreso)) from PuestoDepartamento--Sueldo bruto tomando en cuenta el dia de ingreso del empleado
Select SUM(per.Bono),SUM(ded.Descuento) from PuestoDepartamento pd--checar porque sale muchas cosas repetidas 3 veces, pero esto es para sumar solo la columna de Percepciones y deducciones utilizando un where
join Puestos pu on pu.IdPuesto=pd.Puestofk
join Departamentos Dp on Dp.idDpto=pd.Departamentofk
join Asiganciones a on a.PuestoDptofk=pd.IdPD
join Empleados e on  e.NoEmpleado= a.Empleadofk
join Percepciones_Empleado Pee on pee.Empleadofk=e.NoEmpleado
join Deducciones_Empleado Dee on dee.Empleadofk=e.NoEmpleado
join Percepciones per on per.IdPercepcion=Pee.Percepcionfk
join Deducciones ded on ded.IdDeduccion=dee.Deduccionfk

select*from Percepciones

END