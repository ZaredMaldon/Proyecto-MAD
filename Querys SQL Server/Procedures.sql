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
Select Usuario,Contrase�a from Usuarios where (Usuario=@u and Contrase�a=@p)and(Tipo like 'Gerente');
end
else if(@Opc=2)
begin 
Select Usuario,Contrase�a from Usuarios where (Usuario=@u and Contrase�a=@p)and(Tipo like 'Empleado');
end

end