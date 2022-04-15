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