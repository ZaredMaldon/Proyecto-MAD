select dbo.fn_SalarioDiario(120, 7) as salariodiario;

select dbo.fn_DiasdelMes('20200225') as Dias;

select dbo.fn_SueldoMensualBruto(120,30) as sueldoBruto;

select dbo.fn_Diastrabajados(GETDATE(),'20220515');