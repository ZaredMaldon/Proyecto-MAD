use BD_MAD_1;
/*--------------------------------------------validacion login ------------------------------------------------*/
go
Create procedure SP_ValidaUser 
@u varchar(10),
@p varchar(10) 
as
begin
Select Usuario,Contraseña from Usuarios where Usuario=@u and Contraseña=@p;
end