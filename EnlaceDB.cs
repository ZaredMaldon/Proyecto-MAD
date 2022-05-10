using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Proyecto_MAD.DAO;

namespace Proyecto_MAD.EnlaceDB
{
    public class EnlaceDB
    {
        /*<add name="BD_MAD_1" connectionString="data source=PCZAZA\SQLEXPRESS;Initial Catalog=BD_MAD_1;persist security info=True;Integrated Security=SSPI" providerName="System.Data.SqlClient" />
          <add name="BD_MAD_1" connectionString="Server=JAIME-ASUS\SQLEXPRESS;Database=BD_MAD_1;User Id=sa;Password=jddsaa2128"/>*/

        static private string _aux { set; get; }
        static private SqlConnection _conexion;
        static private SqlDataAdapter _adaptador = new SqlDataAdapter();
        static private SqlCommand _comandosql = new SqlCommand();
        static private DataTable _tabla = new DataTable();
        static private DataSet _DS = new DataSet();
        //static public bool login_tipo;

        public DataTable obtenertabla
        {
            get
            {
                return _tabla;
            }
        }        

        #region Conexión
        private static void conectar()
        {
            //string cnn = ConfigurationManager.AppSettings["desarrollo1"];
            string cnn = ConfigurationManager.ConnectionStrings["BD_MAD_1"].ToString();
            _conexion = new SqlConnection(cnn);
            _conexion.Open();           
        }
        
        private static void desconectar()
        {
            _conexion.Close();
        }

        #endregion

        //----------------------------------------------Login------------------------------------------------------------------------------------//
        #region Login
        public bool Autentificar(string us, string ps,int Opc)
        {
            bool isValid = false;
            try
            {
                
                conectar();
                string qry = "SP_ValidaUser";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 9000;

                var parametro1 = _comandosql.Parameters.Add("@u", SqlDbType.Char, 10);
                parametro1.Value = us;
                var parametro2 = _comandosql.Parameters.Add("@p", SqlDbType.Char, 10);
                parametro2.Value = ps;
                var parametro3 = _comandosql.Parameters.Add("@Opc",SqlDbType.Int);
                parametro3.Value = Opc;
                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(_tabla);

                if (_tabla.Rows.Count > 0)
                {
                    _tabla.Rows.Clear();
                    isValid = true;
                }
                else isValid = false;

            }
            catch (SqlException e)
            {
                _tabla.Rows.Clear();
                isValid = false;
            }
            finally
            {
                desconectar();
            }

            return isValid;
        }
        #endregion

        //----------------------------------------------Empleado------------------------------------------------------------------------------------//

        #region Control Empleado
        //Abstraccion Control Empleados
        //sin telefono 2
        public bool ControldeEmpleados(int Opc,string Nombre, string AP, string AM, DateTime Nacimiento, string CURP, string NSS, string RFC, string Email, string Telefono1, DateTime Contratacion,
            string Banco, int NoCuenta, string Usuario, string Password, string Tipo, int Municipio, string Cp, string Colonia, string Calle, short Nointerior, short NoExt, int idEmp)
        {
            var msg = "";
            var add = true;

            /*Al momento de hacer un insert, agregar a la tabla el el dia y la hora en el que se realizo la accion*/


            try
            {
                conectar();
                string qry = "ControlEmpleados";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;
                var parametro2 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                parametro2.Value = Nombre;
                var parametro3 = _comandosql.Parameters.Add("@AP", SqlDbType.VarChar, 25);
                parametro3.Value = AP;
                var parametro4 = _comandosql.Parameters.Add("@AM", SqlDbType.VarChar, 25);
                parametro4.Value = AM;
                var parametro5 = _comandosql.Parameters.Add("@FechaNac", SqlDbType.Date);
                parametro5.Value = Nacimiento;
                var parametro6 = _comandosql.Parameters.Add("@CURP", SqlDbType.Char, 18);
                parametro6.Value = CURP;
                var parametro7 = _comandosql.Parameters.Add("@NSS", SqlDbType.Char, 11);
                parametro7.Value = NSS;
                var parametro8 = _comandosql.Parameters.Add("@RFC", SqlDbType.Char, 13);
                parametro8.Value = RFC;
                var parametro9 = _comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 50);
                parametro9.Value = Email;
                var parametro10 = _comandosql.Parameters.Add("@Telefono1", SqlDbType.VarChar, 11);
                parametro10.Value = Telefono1;
                var parametro12 = _comandosql.Parameters.Add("@FContratacion", SqlDbType.Date);
                parametro12.Value = Contratacion;   
                var parametro14 = _comandosql.Parameters.Add("@Banco", SqlDbType.VarChar, 30);
                parametro14.Value = Banco;
                var parametro15 = _comandosql.Parameters.Add("@NoCuenta", SqlDbType.Int);
                parametro15.Value = NoCuenta;
                var parametro16 = _comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 10);
                parametro16.Value = Usuario;
                var parametro17 = _comandosql.Parameters.Add("@Contraseña", SqlDbType.VarChar, 10);
                parametro17.Value = Password;
                var parametro18 = _comandosql.Parameters.Add("@Tipo", SqlDbType.VarChar, 10);
                parametro18.Value = Tipo;
                var parametro19 = _comandosql.Parameters.Add("@Municipio", SqlDbType.Int);
                parametro19.Value = Municipio;
                var parametro20 = _comandosql.Parameters.Add("@CP", SqlDbType.VarChar, 5);
                parametro20.Value = Cp;
                var parametro21 = _comandosql.Parameters.Add("@Colonia", SqlDbType.VarChar, 25);
                parametro21.Value = Colonia;
                var parametro22 = _comandosql.Parameters.Add("@Calle", SqlDbType.VarChar, 25);
                parametro22.Value = Calle;
                var parametro23 = _comandosql.Parameters.Add("@Nointerior", SqlDbType.SmallInt);
                parametro23.Value = Nointerior;
                var parametro24 = _comandosql.Parameters.Add("@NoExt", SqlDbType.SmallInt);
                parametro24.Value = NoExt;
                if (idEmp != 0)
                {
                    var parametro25 = _comandosql.Parameters.Add("@IdEmpleado", SqlDbType.Int);
                    parametro25.Value = idEmp;
                }





                _adaptador.InsertCommand = _comandosql;
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return add;
        }
        //Sin numero interior
        public bool ControldeEmpleados(int Opc,string Nombre, string AP, string AM, DateTime Nacimiento, string CURP, string NSS, string RFC, string Email, string Telefono1,string Telefono2, DateTime Contratacion,
            string Banco, int NoCuenta, string Usuario, string Password, string Tipo, int Municipio, string Cp, string Colonia, string Calle, short NoExt, int idEmp)
        {
            var msg = "";
            var add = true;

            /*Al momento de hacer un insert, agregar a la tabla el el dia y la hora en el que se realizo la accion*/


            try
            {
                conectar();
                string qry = "ControlEmpleados";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;
                var parametro2 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                parametro2.Value = Nombre;
                var parametro3 = _comandosql.Parameters.Add("@AP", SqlDbType.VarChar, 25);
                parametro3.Value = AP;
                var parametro4 = _comandosql.Parameters.Add("@AM", SqlDbType.VarChar, 25);
                parametro4.Value = AM;
                var parametro5 = _comandosql.Parameters.Add("@FechaNac", SqlDbType.Date);
                parametro5.Value = Nacimiento;
                var parametro6 = _comandosql.Parameters.Add("@CURP", SqlDbType.Char, 18);
                parametro6.Value = CURP;
                var parametro7 = _comandosql.Parameters.Add("@NSS", SqlDbType.Char, 11);
                parametro7.Value = NSS;
                var parametro8 = _comandosql.Parameters.Add("@RFC", SqlDbType.Char, 13);
                parametro8.Value = RFC;
                var parametro9 = _comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 50);
                parametro9.Value = Email;
                var parametro10 = _comandosql.Parameters.Add("@Telefono1", SqlDbType.VarChar, 11);
                parametro10.Value = Telefono1;
                var parametro11 = _comandosql.Parameters.Add("@Telefono2", SqlDbType.VarChar, 11);
                parametro11.Value = Telefono2;
                var parametro12 = _comandosql.Parameters.Add("@FContratacion", SqlDbType.Date);
                parametro12.Value = Contratacion;
                var parametro14 = _comandosql.Parameters.Add("@Banco", SqlDbType.VarChar, 30);
                parametro14.Value = Banco;
                var parametro15 = _comandosql.Parameters.Add("@NoCuenta", SqlDbType.Int);
                parametro15.Value = NoCuenta;
                var parametro16 = _comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 10);
                parametro16.Value = Usuario;
                var parametro17 = _comandosql.Parameters.Add("@Contraseña", SqlDbType.VarChar, 10);
                parametro17.Value = Password;
                var parametro18 = _comandosql.Parameters.Add("@Tipo", SqlDbType.VarChar, 10);
                parametro18.Value = Tipo;
                var parametro19 = _comandosql.Parameters.Add("@Municipio", SqlDbType.Int);
                parametro19.Value = Municipio;
                var parametro20 = _comandosql.Parameters.Add("@CP", SqlDbType.VarChar, 5);
                parametro20.Value = Cp;
                var parametro21 = _comandosql.Parameters.Add("@Colonia", SqlDbType.VarChar, 25);
                parametro21.Value = Colonia;
                var parametro22 = _comandosql.Parameters.Add("@Calle", SqlDbType.VarChar, 25);
                parametro22.Value = Calle;
                var parametro24 = _comandosql.Parameters.Add("@NoExt", SqlDbType.SmallInt);
                parametro24.Value = NoExt;
                if (idEmp != 0)
                {
                    var parametro25 = _comandosql.Parameters.Add("@IdEmpleado", SqlDbType.Int);
                    parametro25.Value = idEmp;
                }


                _adaptador.InsertCommand = _comandosql;
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return add;
        }

        //Sin num interior y sin telefono 2 
        public bool ControldeEmpleados(int Opc,string Nombre, string AP, string AM, DateTime Nacimiento, string CURP, string NSS, string RFC, string Email, string Telefono1,DateTime Contratacion,
            string Banco, int NoCuenta, string Usuario, string Password, string Tipo, int Municipio, string Cp, string Colonia, string Calle, short NoExt,int idEmp)
        {
            var msg = "";
            var add = true;

            /*Al momento de hacer un insert, agregar a la tabla el el dia y la hora en el que se realizo la accion*/


            try
            {
                conectar();
                string qry = "ControlEmpleados";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;
                var parametro2 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                parametro2.Value = Nombre;
                var parametro3 = _comandosql.Parameters.Add("@AP", SqlDbType.VarChar, 25);
                parametro3.Value = AP;
                var parametro4 = _comandosql.Parameters.Add("@AM", SqlDbType.VarChar, 25);
                parametro4.Value = AM;
                var parametro5 = _comandosql.Parameters.Add("@FechaNac", SqlDbType.Date);
                parametro5.Value = Nacimiento;
                var parametro6 = _comandosql.Parameters.Add("@CURP", SqlDbType.Char, 18);
                parametro6.Value = CURP;
                var parametro7 = _comandosql.Parameters.Add("@NSS", SqlDbType.Char, 11);
                parametro7.Value = NSS;
                var parametro8 = _comandosql.Parameters.Add("@RFC", SqlDbType.Char, 13);
                parametro8.Value = RFC;
                var parametro9 = _comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 50);
                parametro9.Value = Email;
                var parametro10 = _comandosql.Parameters.Add("@Telefono1", SqlDbType.VarChar,11);
                parametro10.Value = Telefono1;  
                var parametro12 = _comandosql.Parameters.Add("@FContratacion", SqlDbType.Date);
                parametro12.Value = Contratacion;
                var parametro14 = _comandosql.Parameters.Add("@Banco", SqlDbType.VarChar, 30);
                parametro14.Value = Banco;
                var parametro15 = _comandosql.Parameters.Add("@NoCuenta", SqlDbType.Int);
                parametro15.Value = NoCuenta;
                var parametro16 = _comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 10);
                parametro16.Value = Usuario;
                var parametro17 = _comandosql.Parameters.Add("@Contraseña", SqlDbType.VarChar, 10);
                parametro17.Value = Password;
                var parametro18 = _comandosql.Parameters.Add("@Tipo", SqlDbType.VarChar, 10);
                parametro18.Value = Tipo;
                var parametro19 = _comandosql.Parameters.Add("@Municipio", SqlDbType.Int);
                parametro19.Value = Municipio;
                var parametro20 = _comandosql.Parameters.Add("@CP", SqlDbType.VarChar, 5);
                parametro20.Value = Cp;
                var parametro21 = _comandosql.Parameters.Add("@Colonia", SqlDbType.VarChar, 25);
                parametro21.Value = Colonia;
                var parametro22 = _comandosql.Parameters.Add("@Calle", SqlDbType.VarChar, 25);
                parametro22.Value = Calle;
                var parametro24 = _comandosql.Parameters.Add("@NoExt", SqlDbType.SmallInt);
                parametro24.Value = NoExt;
                if (idEmp != 0)
                {
                    var parametro25 = _comandosql.Parameters.Add("@IdEmpleado", SqlDbType.Int);
                    parametro25.Value = idEmp;
                }


                _adaptador.InsertCommand = _comandosql;
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return add;
        }
        //Con todos los datos
        public bool ControldeEmpleados(int Opc, string Nombre,string AP,string AM, DateTime Nacimiento,string CURP,string NSS,string RFC,string Email,string Telefono1,string Telefono2,DateTime Contratacion,
            string Banco,int NoCuenta,string Usuario,string Password,string Tipo,int Municipio,string Cp,string Colonia,string Calle,short Nointerior,short NoExt,int idEmp)
        {
            var msg = "";
            var add = true;

            /*Al momento de hacer un insert, agregar a la tabla el el dia y la hora en el que se realizo la accion*/


            try
            {
                conectar();
                string qry = "ControlEmpleados";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;
                var parametro2 = _comandosql.Parameters.Add("@Nombre", SqlDbType.VarChar, 25);
                parametro2.Value = Nombre;
                var parametro3 = _comandosql.Parameters.Add("@AP", SqlDbType.VarChar, 25);
                parametro3.Value = AP;
                var parametro4 = _comandosql.Parameters.Add("@AM", SqlDbType.VarChar, 25);
                parametro4.Value = AM;
                var parametro5 = _comandosql.Parameters.Add("@FechaNac", SqlDbType.Date);
                parametro5.Value = Nacimiento;
                var parametro6 = _comandosql.Parameters.Add("@CURP", SqlDbType.Char, 18);
                parametro6.Value = CURP;
                var parametro7 = _comandosql.Parameters.Add("@NSS", SqlDbType.Char,11);
                parametro7.Value = NSS;
                var parametro8 = _comandosql.Parameters.Add("@RFC", SqlDbType.Char, 13);
                parametro8.Value = RFC;
                var parametro9 = _comandosql.Parameters.Add("@Email", SqlDbType.VarChar, 50);
                parametro9.Value = Email;
                var parametro10 = _comandosql.Parameters.Add("@Telefono1", SqlDbType.VarChar, 11);
                parametro10.Value = Telefono1;
                var parametro11 = _comandosql.Parameters.Add("@Telefono2", SqlDbType.VarChar, 11);
                parametro11.Value = Telefono2;
                var parametro12 = _comandosql.Parameters.Add("@FContratacion", SqlDbType.Date);
                parametro12.Value = Contratacion;
                var parametro14 = _comandosql.Parameters.Add("@Banco", SqlDbType.VarChar, 30);
                parametro14.Value = Banco;
                var parametro15 = _comandosql.Parameters.Add("@NoCuenta", SqlDbType.Int);
                parametro15.Value = NoCuenta;
                var parametro16 = _comandosql.Parameters.Add("@Usuario", SqlDbType.VarChar, 10);
                parametro16.Value = Usuario;
                var parametro17 = _comandosql.Parameters.Add("@Contraseña", SqlDbType.VarChar, 10);
                parametro17.Value = Password;
                var parametro18 = _comandosql.Parameters.Add("@Tipo", SqlDbType.VarChar, 10);
                parametro18.Value = Tipo;
                var parametro19 = _comandosql.Parameters.Add("@Municipio", SqlDbType.Int);
                parametro19.Value = Municipio;
                var parametro20 = _comandosql.Parameters.Add("@CP", SqlDbType.VarChar, 5);
                parametro20.Value = Cp;
                var parametro21 = _comandosql.Parameters.Add("@Colonia", SqlDbType.VarChar,25);
                parametro21.Value = Colonia;
                var parametro22 = _comandosql.Parameters.Add("@Calle", SqlDbType.VarChar,25);
                parametro22.Value = Calle;
                var parametro23 = _comandosql.Parameters.Add("@Nointerior", SqlDbType.SmallInt);
                parametro23.Value = Nointerior;
                var parametro24 = _comandosql.Parameters.Add("@NoExt", SqlDbType.SmallInt);
                parametro24.Value = NoExt;
                if (idEmp != 0)
                {
                    var parametro25 = _comandosql.Parameters.Add("@IdEmpleado", SqlDbType.Int);
                    parametro25.Value = idEmp;
                }
               


                _adaptador.InsertCommand = _comandosql;
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return add;
        }

        public DataTable DataTable_MostrarEmpleado(int Opc)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            DataSet dataSet = new DataSet();

            try
            {
                conectar();

                string qry = "ControlEmpleados";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;



                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                _adaptador.Fill(dataSet, "Codigo1");
            }
            catch (Exception e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }

        #endregion

        #region Control Percepciones
        //Agregar
        public bool ControldePercepciones(int Opc,int idPer,string Nombre, DateTime fechaAplicada, float Bono, float BonoPorcentaje)
        {
            var msg = "";
            var add = true;

            try
            {
                conectar();
                string qry = "SP_ControlPercepciones";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;
                var parametro2 = _comandosql.Parameters.Add("@NombrePer", SqlDbType.VarChar, 25);
                parametro2.Value = Nombre;
                var parametro3 = _comandosql.Parameters.Add("@FechaAplicada ", SqlDbType.Date);
                parametro3.Value = fechaAplicada;
                var parametro4 = _comandosql.Parameters.Add("@Bono", SqlDbType.Money);
                parametro4.Value = Bono;
                var parametro5 = _comandosql.Parameters.Add("@BonoPorcentaje", SqlDbType.Float);
                parametro5.Value = BonoPorcentaje;
                var parametro6 = _comandosql.Parameters.Add("@idPer", SqlDbType.Int);
                parametro6.Value = idPer;

                _adaptador.InsertCommand = _comandosql;
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return add;
        }
        //Eliminar
        public bool ControldePercepciones(int Opc, int idPer)
        {
            var msg = "";
            var add = true;

            try
            {
                conectar();
                string qry = "SP_ControlPercepciones";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;
                var parametro6 = _comandosql.Parameters.Add("@idPer", SqlDbType.Int);
                parametro6.Value = idPer;

                _adaptador.InsertCommand = _comandosql;
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return add;
        }
        //Carga Datos al grid
        public DataTable DataTable_MostrarPercep(int Opc)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            DataSet dataSet = new DataSet();

            try
            {
                conectar();

                string qry = "SP_ControlPercepciones";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;



                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                _adaptador.Fill(dataSet, "Codigo1");
            }
            catch (Exception e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }

        #endregion

        #region ControlDeducciones
        public bool ControlDeducciones(int Opc,int idDeduc,string Nombre,DateTime fechaAplicada,float Descuento,float Porcentaje)
        {
            var msg = "";
            var add = true;

            try
            {
                conectar();
                string qry = "SP_ControlDeducciones";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;
                var parametro2 = _comandosql.Parameters.Add("@NombreDeduc", SqlDbType.VarChar, 25);
                parametro2.Value = Nombre;
                var parametro3 = _comandosql.Parameters.Add("@FechaAplicada", SqlDbType.Date);
                parametro3.Value = fechaAplicada;
                var parametro4 = _comandosql.Parameters.Add("@Descuento", SqlDbType.Money);
                parametro4.Value = Descuento;
                var parametro5 = _comandosql.Parameters.Add("@Porcentaje", SqlDbType.Float);
                parametro5.Value = Porcentaje;
                var parametro6 = _comandosql.Parameters.Add("@idDeduc", SqlDbType.Int);
                parametro6.Value = idDeduc;

                _adaptador.InsertCommand = _comandosql;
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return add;
        }
        public bool ControlDeducciones(int Opc, int idDeduc)
        {
            var msg = "";
            var add = true;

            try
            {
                conectar();
                string qry = "SP_ControlDeducciones";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;
                var parametro6 = _comandosql.Parameters.Add("@idDeduc", SqlDbType.Int);
                parametro6.Value = idDeduc;

                _adaptador.InsertCommand = _comandosql;
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return add;
        }
        //Carga Datos al grid
        public DataTable DataTable_MostrarDeduccion(int Opc)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            DataSet dataSet = new DataSet();

            try
            {
                conectar();

                string qry = "SP_ControlDeducciones";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;



                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                _adaptador.Fill(dataSet, "Codigo1");
            }
            catch (Exception e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }

        #endregion

        #region Llenado de ComboBox
        public void Cargar_DatosMuni_CB(int Opc,ComboBox a)
        {
            conectar();
            string qry = "SP_LlenadoCombobox";
        
            _comandosql = new SqlCommand(qry, _conexion);
            _comandosql.CommandType = CommandType.StoredProcedure;
            _comandosql.CommandTimeout = 1200;

            var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
            parametro1.Value = Opc;

            
            SqlDataAdapter da = new SqlDataAdapter(_comandosql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            desconectar();

            DataRow fila = dt.NewRow();
            fila["NombreMunicipio"] = "Selecciona un Municipio";
            dt.Rows.InsertAt(fila, 0);
            a.ValueMember = "idMunicipio";
            a.DisplayMember = "NombreMunicipio";
            a.DataSource = dt;


        }

        public void Cargar_DatosDPTO_CB(int Opc, ComboBox a)
        {
            conectar();
            string qry = "SP_LlenadoCombobox";

            _comandosql = new SqlCommand(qry, _conexion);
            _comandosql.CommandType = CommandType.StoredProcedure;
            _comandosql.CommandTimeout = 1200;

            var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
            parametro1.Value = Opc;


            SqlDataAdapter da = new SqlDataAdapter(_comandosql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            desconectar();

            DataRow fila = dt.NewRow();
            fila["NombreDpto"] = "Selecciona un Departamento";
            dt.Rows.InsertAt(fila, 0);
            a.ValueMember = "idDpto";
            a.DisplayMember = "NombreDpto";
            a.DataSource = dt;

        }

        public void Cargar_DatosPUESTOS_CB(int Opc,string Departamento, ComboBox a)
        {
            conectar();
            string qry = "SP_LlenadoCombobox";

            _comandosql = new SqlCommand(qry, _conexion);
            _comandosql.CommandType = CommandType.StoredProcedure;
            _comandosql.CommandTimeout = 1200;

            var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
            parametro1.Value = Opc;
            var parametro2 = _comandosql.Parameters.Add("@Dpto", SqlDbType.VarChar,20);
            parametro2.Value = Departamento;

            SqlDataAdapter da = new SqlDataAdapter(_comandosql);
            DataTable dt = new DataTable();
            da.Fill(dt);
            desconectar();

            DataRow fila = dt.NewRow();
            fila["Puesto"] = "Selecciona un Puesto";
            dt.Rows.InsertAt(fila, 0);
            a.ValueMember = "ID";
            a.DisplayMember = "Puesto";
            a.DataSource = dt;

        }
        #endregion

        #region Toma de datos 
        //Empleado
        public void Toma_Datos_Empleado(int Opc, int idEmp)
        {
            var msg = "";
           

            try
            {
                conectar();
                string qry = "ControlEmpleados";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;
                var parametro2 = _comandosql.Parameters.Add("@IdEmpleado", SqlDbType.Int);
                parametro2.Value = idEmp;


                _adaptador.InsertCommand = _comandosql;

                SqlDataReader dr = _comandosql.ExecuteReader();

                while (dr.Read())//si no pasa este es porque no hay nada en el query
                {
                    DAO_Empleado.id = dr.GetInt32(0);
                    DAO_Empleado.Nombre = dr.GetString(1);
                    DAO_Empleado.ApPaterno = dr.GetString(2);
                    DAO_Empleado.ApMaterno = dr.GetString(3);
                    DAO_Empleado.CURP = dr.GetString(4);
                    DAO_Empleado.NSS = dr.GetString(5);
                    DAO_Empleado.RFC = dr.GetString(6);
                    DAO_Empleado.email=dr.GetString(7);
                    DAO_Empleado.municipio = dr.GetString(8);
                    DAO_Empleado.puesto = dr.GetString(9);
                    DAO_Empleado.departamento=dr.GetString(10);
                    DAO_Empleado.Calle = dr.GetString(11);
                    DAO_Empleado.Colonia = dr.GetString(12);
                    DAO_Empleado.Cp = dr.GetString(13);
                    DAO_Empleado.numExt = dr.GetInt16(14);
                    if (dr.IsDBNull(15)!=true)
                    {
                        DAO_Empleado.numInt = dr.GetInt16(15);
                    }
                   
                    DAO_Empleado.Fecha_nacimiento =dr.GetDateTime(16);
                    DAO_Empleado.Fecha_Contratacion =dr.GetDateTime(17);
                    DAO_Empleado.Telefono1 = dr.GetString(18);

                    if (dr.IsDBNull(19) != true)
                    {
                        DAO_Empleado.Telefono2 = dr.GetString(19);
                    }
                    
                    DAO_Empleado.Banco = dr.GetString(20);
                    DAO_Empleado.NoCuenta=dr.GetInt32(21);
                    DAO_Empleado.Usuario = dr.GetString(22);
                    DAO_Empleado.Contraseña = dr.GetString(23);
                    DAO_Empleado.SalarioDiario = (decimal)dr.GetSqlMoney(24);
                }


            }
            catch (SqlException e)
            {

                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
        }

        #endregion

        //----------------------------------------------------------Departamento----------------------------------------------------------------//

        #region ControlDeptos

        public bool ControlDepto(int Op, int idDepto, string Nombre, int sueldoBase)
        {
            var msg = "";
            var add = true;

            try
            {
                conectar();
                string qry = "SP_ControlDepto";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Op;
                var parametro2 = _comandosql.Parameters.Add("@NombreDepto", SqlDbType.VarChar, 25);
                parametro2.Value = Nombre;
                var parametro3 = _comandosql.Parameters.Add("@sueldoBase", SqlDbType.Int);
                parametro3.Value = sueldoBase;

                _adaptador.InsertCommand = _comandosql;
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }
        public bool ControlDeptos(int Opc, int idDepto)
        {
            var msg = "";
            var add = true;

            try
            {
                conectar();
                string qry = "SP_ControlDepto";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;
                var parametro6 = _comandosql.Parameters.Add("@idDepto", SqlDbType.Int);
                parametro6.Value = idDepto;

                _adaptador.InsertCommand = _comandosql;
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return add;
        }

        //Carga Datos al grid
        public DataTable DataTable_MostrarDeptos(int Opc)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            DataSet dataSet = new DataSet();

            try
            {
                conectar();

                string qry = "SP_ControlDepto";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;

                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                _adaptador.Fill(dataSet, "Codigo1");
            }
            catch (Exception e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }

        #endregion

        public void Toma_Datos_Departamentos(int Opc, int idDepto)
        {
            var msg = "";


            try
            {
                conectar();
                string qry = "SP_ControlDepto";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;
                var parametro2 = _comandosql.Parameters.Add("@idDepto", SqlDbType.Int);
                parametro2.Value = idDepto;


                _adaptador.InsertCommand = _comandosql;

                SqlDataReader dr = _comandosql.ExecuteReader();

                while (dr.Read())//si no pasa este es porque no hay nada en el query
                {
                    DAO_Departamentos.id = dr.GetInt32(0);
                    DAO_Departamentos.Nombre = dr.GetString(1);

                    DAO_Departamentos.Sueldo_Base = dr.GetSqlString(2).ToString();

                }
            }
            catch (SqlException e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
        }

        //----------------------------------------------------Puesto---------------------------------------------------------------------//

        #region ControlPuestos

        public bool ControlPuestos(int Op, int IdPuesto, string NombrePuesto, float NivelSalarial, string Departamento, int idDepto) //INSERTAR
        {
            var msg = "";
            var add = true;

            try
            {
                conectar();
                string qry = "SP_ControlPuestos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Op;
                var parametro5 = _comandosql.Parameters.Add("@IdPuestos", SqlDbType.Int);
                parametro5.Value = IdPuesto;
                var parametro2 = _comandosql.Parameters.Add("@NombrePuesto", SqlDbType.VarChar, 25);
                parametro2.Value = NombrePuesto;
                var parametro3 = _comandosql.Parameters.Add("@NivelSalarial", SqlDbType.Float);
                parametro3.Value = NivelSalarial;
                var parametro4 = _comandosql.Parameters.Add("@Departamento", SqlDbType.VarChar,20);
                parametro4.Value = Departamento;
                var parametro6 = _comandosql.Parameters.Add("@IdDepto", SqlDbType.Int);
                parametro5.Value = idDepto;

                _adaptador.InsertCommand = _comandosql;
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }

            return add;
        }
        public bool ControlPuesto(int Opc, int idPuestos) //ELIMINAR
        {
            var msg = "";
            var add = true;

            try
            {
                conectar();
                string qry = "SP_ControlPuestos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;
                var parametro6 = _comandosql.Parameters.Add("@idPuestos", SqlDbType.Int);
                parametro6.Value = idPuestos;

                _adaptador.InsertCommand = _comandosql;
                _comandosql.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                add = false;
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return add;
        }

        //Carga Datos al grid
        public DataTable DataTable_MostrarPuestos(int Opc)
        {
            var msg = "";
            DataTable tabla = new DataTable();
            DataSet dataSet = new DataSet();

            try
            {
                conectar();

                string qry = "SP_ControlPuestos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;



                _adaptador.SelectCommand = _comandosql;
                _adaptador.Fill(tabla);
                _adaptador.Fill(dataSet, "Codigo1");
            }
            catch (Exception e)
            {
                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
            return tabla;
        }

        #endregion

        public void Toma_Datos_Puestos(int Opc, int idPuesto)
        {
            var msg = "";


            try
            {
                conectar();
                string qry = "SP_ControlPuestos";
                _comandosql = new SqlCommand(qry, _conexion);
                _comandosql.CommandType = CommandType.StoredProcedure;
                _comandosql.CommandTimeout = 1200;

                var parametro1 = _comandosql.Parameters.Add("@Opc", SqlDbType.Int);
                parametro1.Value = Opc;
                var parametro2 = _comandosql.Parameters.Add("@IdPuestos", SqlDbType.Int);
                parametro2.Value = idPuesto;


                _adaptador.InsertCommand = _comandosql;

                SqlDataReader dr = _comandosql.ExecuteReader();

                while (dr.Read())//si no pasa este es porque no hay nada en el query
                {
                    DAO_Puestos.id = dr.GetInt32(0);
                    DAO_Puestos.Puesto = dr.GetString(1);
                    DAO_Puestos.Nivel_Salarial = (float)dr.GetDouble(2);
                    DAO_Puestos.Departamento = dr.GetString(3);
                    DAO_Puestos.Salario_Diario = (decimal)dr.GetSqlMoney(4);
                    
                }


            }
            catch (SqlException e)
            {

                msg = "Excepción de base de datos: \n";
                msg += e.Message;
                MessageBox.Show(msg, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                desconectar();
            }
        }

    }
}
