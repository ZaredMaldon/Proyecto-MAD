use BD_MAD_1;
/*--------------------------------------------validacion login ------------------------------------------------*/
go
Create procedure SP_ValidaUser 
@u varchar(10),
@p varchar(10) 
as
begin
Select Usuario,Contrase�a from Usuarios where Usuario=@u and Contrase�a=@p;
end