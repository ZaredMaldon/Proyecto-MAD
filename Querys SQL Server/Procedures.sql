use BD_MAD_1;
/*--------------------------------------------validacion login ------------------------------------------------*/
go
alter procedure SP_ValidaUser 
@u varchar(10),
@p varchar(10),
@Opc int 

as
begin
if(@Opc=1)
begin
Select Usuario,Contraseña from Usuarios where (Usuario=@u and Contraseña=@p)and(Tipo = 'Gerente') 
end
else if(@Opc=2)
begin 
Select Usuario,Contraseña from Usuarios where (Usuario=@u and Contraseña=@p)and(Tipo = 'Empleado')
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
			raiserror('Error al insertar Empleado',16,1);
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
inner join PuestoDepartamento  pd on pd.IdPD=a.PuestoDptofk
inner join Puestos p on p.IdPuesto=pd.Puestofk
inner join Departamentos de on de.idDpto=pd.Departamentofk
where NoEmpleado=@IdEmpleado;
end
if(@Opc = 6) /*cambiar solo contra y us*/
begin
begin try
UPDATE Usuarios SET Usuario=@Usuario,Contraseña=@Contraseña 
			from Empleados e join Usuarios u
			on e.Usuariofk=u.idUsuario
			where e.NoEmpleado=@IdEmpleado;
end try
begin catch
raiserror('No se logro modificar el Usuario',16,1)
end catch
end
if(@Opc=7)/*Modificar Empleado*/
begin
	Begin try
		Begin Tran

			UPDATE Empleados SET Nombre=@Nombre,APaterno=@AP,AMaterno=@AM,FechaNacimiento=@FechaNac,CURP=@CURP,NSS=@NSS,RFC=@RFC,Email=@Email,Telefono1=@Telefono1,Telefono2=@Telefono2,
			Banco=@Banco,NoCuenta=@NoCuenta
			where NoEmpleado=@IdEmpleado
			
			declare @iddir int
			Select @iddir=Direccionfk from Empleados
			where NoEmpleado=@IdEmpleado

			UPDATE Direcciones SET Cp=@CP,Colonia=@Colonia,Calle=@Calle,NoInterior=@Nointerior,NoExt=@NoExt
			where idDireccion=@iddir

			
		commit tran
  End try
	Begin catch
			Rollback tran
			raiserror('No se logro hacer la modificacion',16,1)
			
	end catch
	
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
	Select IdDeduccion,NombreDeduccion from Deducciones
	where NombreDeduccion!='IMMS' and NombreDeduccion!='ISR';
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
Delete from Percepciones_Empleado where Percepcionfk=@idPer
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
Delete from Deducciones_Empleado where Deduccionfk=@idDeduc
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
Declare @CuentaEmpleados int
Select @CuentaEmpleados = COUNT(idEmp) from vw_Asignaciones
where idDpto=@idDepto
if(@CuentaEmpleados=0)/*Para ver si hay empleados y si no hay hacer el delete*/
begin
Delete from PuestoDepartamento where Departamentofk=@idDepto
Delete from Departamentos where idDpto = @idDepto;
end else
begin
raiserror('No se puede borrar Departamento con Empleados en el',16,1);
end

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
	Declare @CuentaEmpleados int
	Select @CuentaEmpleados = COUNT(idEmp) from vw_Asignaciones
	where idDpto=@idDepto
	if(@CuentaEmpleados=0)
	begin
	delete from PuestoDepartamento where Puestofk = @IdPuestos;
	Delete from Puestos where IdPuesto = @IdPuestos; /*primero se debe eliminar regristro de la tabla puestodepartamento*/
	end else
	begin
	raiserror('No se puede borrar Puesto con Empleados en el',16,1);
	end
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
alter procedure SP_Calculo
@FechaNomina date = null
--nuevo
as
BEGIN
declare @nomina int
set @nomina=(select top(1)IdNomina from NOMINA where MONTH(FechaNomina)=MONTH(@FechaNomina) and YEAR(FechaNomina)=YEAR(@FechaNomina))
if(@nomina is null)
begin
declare @error int,@mensaje varchar(150)
Declare @SueldoMensualBruto money,@SueldoBruto money
Declare @TotalPercepciones money,@TotalDeducciones money
Declare @SueldoNeto money
Declare @banco varchar(30),@noCuenta int

/*while para recorrer los empleados que ya tengan asignado un puesto y un departamento*/
		declare @tabla table(idEmpleado int,Ingreso date)
		insert into @tabla(idEmpleado,Ingreso) select idEmp,Contratacion from vw_Asignaciones 
		declare @count int=(select count(idEmpleado) from @tabla)

		declare @IMMS int,@ISR int
		set @IMMS=(select IdDeduccion from Deducciones where NombreDeduccion='IMMS')
		set @ISR=(select IdDeduccion from Deducciones where NombreDeduccion='ISR')
		
		while @count>0
		begin
			
			declare @idEmp int=(select top(1) idEmpleado from @tabla order by idEmpleado)
			declare @FechaIngreso date=(Select top(1) Ingreso from @tabla order by idEmpleado)
			declare @Diferencia int, @nombre varchar(50)

			Select @nombre=Nombre from vw_Asignaciones where idEmp=@idEmp

			Select @Diferencia= DATEDIFF(MONTH,@FechaIngreso,@FechaNomina);
			if(@Diferencia>=0)
			begin

			--Agregamos las deducciones basicas al empleado
		
			insert into Deducciones_Empleado (Empleadofk,Deduccionfk,FechaAplicada) values (@idEmp,@IMMS,@FechaNomina)
			insert into Deducciones_Empleado (Empleadofk,Deduccionfk,FechaAplicada) values (@idEmp,@ISR,@FechaNomina)

			--Select @SueldoMensualBruto=dbo.fn_SueldoMensualBruto(SalarioDiario,dbo.fn_DiasdelMes(@FechaNomina)) from  vw_Asignaciones  where idEmp=@idEmp--Sueldo mensual bruto con todos los dias
			Select @SueldoBruto=dbo.fn_SueldoMensualBruto(SalarioDiario,dbo.fn_Diastrabajados(@FechaNomina,@FechaIngreso)) from vw_Asignaciones where idEmp=@idEmp--Sueldo bruto tomando en cuenta el dia de ingreso del empleado


			Select @TotalPercepciones=SUM(p.Bono) + dbo.fn_SumPeDe(1,@SueldoBruto,@FechaNomina,@idEmp) from Percepciones_Empleado pe--suma todas las percepciones del mes del empleado
			join Percepciones p on p.IdPercepcion=pe.Percepcionfk
			join Empleados e on e.NoEmpleado=pe.Empleadofk
			where e.NoEmpleado=@idEmp and (MONTH(FechaAplicada)=MONTH(@FechaNomina) and YEAR(FechaAplicada)=YEAR(@FechaNomina))

			--declare @Fijos money/*imms e isr*/
	
			--Select @Fijos=Sum(DescuentoPorcentaje)*@SueldoBruto from Deducciones where NombreDeduccion='IMMS' or NombreDeduccion='ISR'

			Select @TotalDeducciones=SUM(ded.Descuento)+dbo.fn_SumPeDe(2,@SueldoBruto,@FechaNomina,@idEmp)  from Deducciones_Empleado de--suma todas las deducciones del mes del empleado
			join Deducciones ded on ded.IdDeduccion=de.Deduccionfk
			join Empleados e on e.NoEmpleado=de.Empleadofk
			where e.NoEmpleado=@idEmp and (MONTH(FechaAplicada)=MONTH(@FechaNomina) and YEAR(FechaAplicada)=YEAR(@FechaNomina))


			if(@TotalPercepciones is not null)
			begin
			Select @SueldoNeto=@SueldoBruto+@TotalPercepciones
			end
			else
			begin
			Select @SueldoNeto=@SueldoBruto;
			end
			Select @SueldoNeto=@SueldoNeto-@TotalDeducciones

			Select @banco=Banco,@noCuenta=NoCuenta from Empleados where NoEmpleado=@idEmp

			Declare @SDN money,@PuN varchar(25),@DeN varchar(25)
			Select @SDN=pd.SalarioDiario,@PuN=p.NombrePuesto,@DeN=d.NombreDpto from Empleados e
				join Asiganciones a on  a.Empleadofk=e.NoEmpleado
				join PuestoDepartamento pd on pd.IdPD=a.PuestoDptofk
				join Puestos p on p.IdPuesto=pd.Puestofk
				join Departamentos d on d.idDpto=pd.Departamentofk
				where e.NoEmpleado=@idEmp

			if(@TotalPercepciones is null and @TotalDeducciones is null)
			begin
				insert into NOMINA (Empleadofk,Sueldo_bruto,Sueldo_neto,Bancofk,NoCuentafk,FechaNomina,SalarioDirario,Puesto,Departamento)values(@idEmp,@SueldoBruto,@SueldoBruto,@banco,@noCuenta,@FechaNomina,@SDN,@PuN,@DeN)
			end
			else if(@TotalDeducciones is not null or @TotalPercepciones is not null)
			begin
				insert into NOMINA (Empleadofk,Sueldo_bruto,Sueldo_neto,Bancofk,NoCuentafk,FechaNomina,SalarioDirario,Puesto,Departamento)values(@idEmp,@SueldoBruto,@SueldoNeto,@banco,@noCuenta,@FechaNomina,@SDN,@PuN,@DeN)
			end

			end else
			begin
			Set @error=1
			end

			delete @tabla where idEmpleado=@idEmp
			set @count = (select count(idEmpleado) from @tabla)
		end
		if(@error=1)
		begin
		Set @mensaje='No todos los empleados tienen la nomina de este mes porque aun no han sido contratados'
		Raiserror(@mensaje,16,1);
		end

end
else
begin
Raiserror('Esta nomina ya ha sido calculada',16,1);
end
END
/*-------------------------------------------------------------------------------------Mostrar nomina------------------------------------------------------------------------------------------*/
go
ALTER procedure Sp_MostrarNomina
@Opc int,
@idEmp int = null

as
BEGIN
if(@Opc=1)
begin
	Select [No.Nómina],[No.Empleado],[Nombre Completo],Fecha,SueldoB as [Sueldo Bruto],SueldoN as [Sueldo Neto],Banco,[No.Cuenta] from vw_Nomina
end
if(@Opc=2)
begin
	Select [No.Nómina],[No.Empleado],[Nombre Completo],Fecha,SueldoB as [Sueldo Bruto],SueldoN as [Sueldo Neto],Banco,[No.Cuenta] from vw_Nomina
	where [No.Empleado]=@idEmp
end
END
/*---------------------------------------------------------------------------------------- Reportes ---------------------------------------------------------------------------------------------------*/
/*----------------------------------------------------------------------------- Reporte General de Nomina ----------------------------------------------------------------------------------------*/
go
create procedure Sp_ReporteGeneralNomina
@Opc int,
@Mes int = null,
@Año int = null
as
BEGIN
if(@Opc=1)/*Sin filtro (Año=0,Mes=0)*/
begin
Select Departamento,Puesto,Nombre,[Fecha de Ingreso],Edad,Concat('$',[Salario Diario]) as [Salario Diario] from vw_ReporteGeneralNomina
order by Departamento,Puesto,Nombre;
end
if(@Opc=2)/*Si solo se envia el mes (Año=0)*/
begin
Select Departamento,Puesto,Nombre,[Fecha de Ingreso],Edad,Concat('$',[Salario Diario]) as [Salario Diario] from vw_ReporteGeneralNomina
where MONTH([Fecha de Ingreso])=@Mes
order by Departamento,Puesto,Nombre;
end
if(@Opc=3)/*Si solo se envia el año(Mes=0)*/
begin
Select Departamento,Puesto,Nombre,[Fecha de Ingreso],Edad,Concat('$',[Salario Diario]) as [Salario Diario] from vw_ReporteGeneralNomina
where YEAR([Fecha de Ingreso])=@Año
order by Departamento,Puesto,Nombre;
end
if(@Opc=4)/*Si se envian los dos*/
begin
Select Departamento,Puesto,Nombre,[Fecha de Ingreso],Edad,Concat('$',[Salario Diario]) as [Salario Diario] from vw_ReporteGeneralNomina
where YEAR([Fecha de Ingreso])=@Año and MONTH([Fecha de Ingreso])=@Mes
order by Departamento,Puesto,Nombre;
end
END

/*-----------------------------------------------------------------------------------Reporte Headcounter---------------------------------------------------------------------------------*/
go
create procedure SP_ReporteHeadcounter
@Opc int,
@Month int=null,
@Year int = null,
@Departamento varchar(20)=null
as
BEGIN
--Parte1
if(@Opc=1)/*Todos*/
begin
	Select Departamento,Puesto,dbo.fn_ContarEDep2(pd.idDepartamento,pd.idPuesto) as [Cantidad Empleados] from vw_PuesDep pd
	order by Departamento,Puesto
end
--Parte2
if(@Opc=5)/*Todos*/
begin
Select Departamento,[Cantidad de Empleados] from vw_ReporteHeadcounterp2
order by Departamento
end

/*if(@Departamento is not null)*/
end

------------------------------------------------------------Parte 1---------------------------------------------------------------------------------------------------

if(@Opc=2)/* Si tiene meses y años y depa*/
begin
	Select Departamento,Puesto,dbo.fn_ContarEDep(1,pd.idDepartamento,pd.idPuesto,@Year,@Month) as [Cantidad Empleados] from vw_PuesDep pd
	where Departamento=@Departamento
	order by Departamento,Puesto
end
if(@Opc=3)/*Solo mes y depa*/
begin
	Select Departamento,Puesto,dbo.fn_ContarEDep(2,pd.idDepartamento,pd.idPuesto,0,@Month) as [Cantidad Empleados] from vw_PuesDep pd
	where Departamento=@Departamento
	order by Departamento,Puesto
end
if(@Opc=4)/*Solo año y depa*/
begin
	Select Departamento,Puesto,dbo.fn_ContarEDep(3,pd.idDepartamento,pd.idPuesto,@Year,0) as [Cantidad Empleados] from vw_PuesDep pd
	where Departamento=@Departamento
	order by Departamento,Puesto
end
------------------------------------------------------------Parte 2---------------------------------------------------------------------------------------------------

if(@Opc=6)/*Si tiene tanto meses y años y depa*/
begin
Select NombreDpto as Departamento,dbo.fn_ContarEmpleados2(1,idDpto,@Year,@Month) as [Cantidad de Empleados] from Departamentos 
where NombreDpto=@Departamento
order by Departamento
end
if(@Opc=7)/*Solo mes y depa*/
begin
Select NombreDpto as Departamento,dbo.fn_ContarEmpleados2(2,idDpto,@Year,@Month) as [Cantidad de Empleados] from Departamentos 
where NombreDpto=@Departamento
order by Departamento
end
if(@Opc=8)/*Solo año y depa*/
begin
Select NombreDpto as Departamento,dbo.fn_ContarEmpleados2(3,idDpto,@Year,@Month) as [Cantidad de Empleados] from Departamentos 
where NombreDpto=@Departamento
order by Departamento
end
-----------------------------------------------------------Solo departamento---------------------------------------------------------------------------------------
if(@Opc=15)--Mostrar solo con Departamento parte 1
begin

Select Departamento,Puesto,dbo.fn_ContarEDep(4,pd.idDepartamento,pd.idPuesto,0,0) as [Cantidad Empleados] from vw_PuesDep pd
	where Departamento=@Departamento
	order by Departamento,Puesto

end

if(@Opc=16)--Mostrar solo con Departamento parte 2
begin

Select NombreDpto as Departamento,dbo.fn_ContarEmpleados2(4,idDpto,0,0) as [Cantidad de Empleados] from Departamentos 
where NombreDpto=@Departamento
order by Departamento
end

end else/*Si es null Departamento*/
begin

------------------------------------------------------------Parte 1---------------------------------------------------------------------------------------------------
if(@Opc=9)/* Si tiene meses y años*/
begin
	Select Departamento,Puesto,dbo.fn_ContarEDep(1,pd.idDepartamento,pd.idPuesto,@Year,@Month) as [Cantidad Empleados] from vw_PuesDep pd
	order by Departamento,Puesto
end
if(@Opc=10)/*Solo mes*/
begin
	Select Departamento,Puesto,dbo.fn_ContarEDep(2,pd.idDepartamento,pd.idPuesto,0,@Month) as [Cantidad Empleados] from vw_PuesDep pd
	order by Departamento,Puesto
end
if(@Opc=11)/*Solo año*/
begin
	Select Departamento,Puesto,dbo.fn_ContarEDep(3,pd.idDepartamento,pd.idPuesto,@Year,0) as [Cantidad Empleados] from vw_PuesDep pd
	order by Departamento,Puesto
end
------------------------------------------------------------Parte 2---------------------------------------------------------------------------------------------------
if(@Opc=12)/*Si tiene tanto meses y años*/
begin
Select NombreDpto as Departamento,dbo.fn_ContarEmpleados2(1,idDpto,@Year,@Month) as [Cantidad de Empleados] from Departamentos 
order by Departamento
end
if(@Opc=13)/*Solo mes*/
begin
Select NombreDpto as Departamento,dbo.fn_ContarEmpleados2(2,idDpto,@Year,@Month) as [Cantidad de Empleados] from Departamentos 
order by Departamento
end
if(@Opc=14)/*Solo año*/
begin
Select NombreDpto as Departamento,dbo.fn_ContarEmpleados2(3,idDpto,@Year,@Month) as [Cantidad de Empleados] from Departamentos 
order by Departamento
end

end
END

/*----------------------------------------------------------------------------------Reporte de Nómina----------------------------------------------------------------------------------*/
go
alter procedure SP_ReporteNomina
@Año int = null
as
begin
Declare @SueldoNetoTotal money
Declare @SueldoBrutoTotal money
if(@Año = 0)
begin
set @SueldoBrutoTotal =(Select Sum([Sueldo Bruto Dpto.]) from vw_ReporteNomina) 
set @SueldoNetoTotal=(Select Sum([Sueldo Neto Dpto.]) from vw_ReporteNomina)
select Departamento,Año,Mes, FORMAT([Sueldo Bruto Dpto.] ,'C','En-Us')as [Sueldo Bruto Dpto.], FORMAT([Sueldo Neto Dpto.],'C','En-Us') as [Sueldo Neto Dpto.], FORMAT(@SueldoBrutoTotal,'C','En-Us') as [SueldoBrutoTotal] , FORMAT(@SueldoNetoTotal,'C','En-Us') as [SueldoNetoTotal] from vw_ReporteNomina
order by Departamento,Año,Mes
end else
begin
set @SueldoBrutoTotal  =(Select Sum([Sueldo Bruto Dpto.]) from vw_ReporteNomina) 
set @SueldoNetoTotal =(Select Sum([Sueldo Neto Dpto.]) from vw_ReporteNomina)
select Departamento,Año,Mes, FORMAT([Sueldo Bruto Dpto.] ,'C','En-Us')as [Sueldo Bruto Dpto.], FORMAT([Sueldo Neto Dpto.],'C','En-Us') as [Sueldo Neto Dpto.], FORMAT(@SueldoBrutoTotal,'C','En-Us') as [SueldoBrutoTotal] , FORMAT(@SueldoNetoTotal,'C','En-Us') as [SueldoNetoTotal] from vw_ReporteNomina
where Año<=@Año
order by Departamento,Año,Mes
end
end

