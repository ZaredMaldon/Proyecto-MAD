using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Proyecto_MAD.EnlaceDB
{
    public class EnlaceDB
    {
        static private string _aux { set; get; }
        static private SqlConnection _conexion;
        static private SqlDataAdapter _adaptador = new SqlDataAdapter();
        static private SqlCommand _comandosql = new SqlCommand();
        static private DataTable _tabla = new DataTable();
        static private DataSet _DS = new DataSet();

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
        public bool ControldeEmpleados(int Opc,int idEmpleado,int idUsuario,int idDireccion, string Nombre, string AP, string AM, DateTime Nacimiento, string CURP, string NSS, string RFC, string Email, int Telefono1, DateTime Contratacion, float SalarioDiario,
            string Banco, int NoCuenta, string Usuario, string Password, string Tipo, int Municipio, string Cp, string Colonia, string Calle, short Nointerior, short NoExt)
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
                var parametro10 = _comandosql.Parameters.Add("@Telefono1", SqlDbType.Int);
                parametro10.Value = Telefono1;
                var parametro12 = _comandosql.Parameters.Add("@FContratacion", SqlDbType.Date);
                parametro12.Value = Contratacion;
                var parametro13 = _comandosql.Parameters.Add("@SalarioDiario", SqlDbType.Money);
                parametro13.Value = SalarioDiario;
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
                var parametro25 = _comandosql.Parameters.Add("@IdEmpleado", SqlDbType.Int);
                parametro25.Value = idEmpleado;
                var parametro26 = _comandosql.Parameters.Add("@IdUsuario", SqlDbType.Int);
                parametro26.Value = idUsuario;
                var parametro27= _comandosql.Parameters.Add("@IdDireccion", SqlDbType.Int);
                parametro27.Value = idDireccion;




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

        public bool ControldeEmpleados(int Opc, int idEmpleado, int idUsuario, int idDireccion, string Nombre, string AP, string AM, DateTime Nacimiento, string CURP, string NSS, string RFC, string Email, int Telefono1, int Telefono2, DateTime Contratacion, float SalarioDiario,
            string Banco, int NoCuenta, string Usuario, string Password, string Tipo, int Municipio, string Cp, string Colonia, string Calle, short NoExt)
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
                var parametro10 = _comandosql.Parameters.Add("@Telefono1", SqlDbType.Int);
                parametro10.Value = Telefono1;
                var parametro11 = _comandosql.Parameters.Add("@Telefono2", SqlDbType.Int);
                parametro11.Value = Telefono2;
                var parametro12 = _comandosql.Parameters.Add("@FContratacion", SqlDbType.Date);
                parametro12.Value = Contratacion;
                var parametro13 = _comandosql.Parameters.Add("@SalarioDiario", SqlDbType.Money);
                parametro13.Value = SalarioDiario;
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
                var parametro25 = _comandosql.Parameters.Add("@IdEmpleado", SqlDbType.Int);
                parametro25.Value = idEmpleado;
                var parametro26 = _comandosql.Parameters.Add("@IdUsuario", SqlDbType.Int);
                parametro26.Value = idUsuario;
                var parametro27 = _comandosql.Parameters.Add("@IdDireccion", SqlDbType.Int);
                parametro27.Value = idDireccion;


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

        public bool ControldeEmpleados(int Opc, int idEmpleado, int idUsuario, int idDireccion, string Nombre, string AP, string AM, DateTime Nacimiento, string CURP, string NSS, string RFC, string Email, int Telefono1,DateTime Contratacion, float SalarioDiario,
            string Banco, int NoCuenta, string Usuario, string Password, string Tipo, int Municipio, string Cp, string Colonia, string Calle, short NoExt)
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
                var parametro10 = _comandosql.Parameters.Add("@Telefono1", SqlDbType.Int);
                parametro10.Value = Telefono1;  
                var parametro12 = _comandosql.Parameters.Add("@FContratacion", SqlDbType.Date);
                parametro12.Value = Contratacion;
                var parametro13 = _comandosql.Parameters.Add("@SalarioDiario", SqlDbType.Money);
                parametro13.Value = SalarioDiario;
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
                var parametro25 = _comandosql.Parameters.Add("@IdEmpleado", SqlDbType.Int);
                parametro25.Value = idEmpleado;
                var parametro26 = _comandosql.Parameters.Add("@IdUsuario", SqlDbType.Int);
                parametro26.Value = idUsuario;
                var parametro27 = _comandosql.Parameters.Add("@IdDireccion", SqlDbType.Int);
                parametro27.Value = idDireccion;


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

        public bool ControldeEmpleados(int Opc, string Nombre,string AP,string AM, DateTime Nacimiento,string CURP,string NSS,string RFC,string Email,int Telefono1,int Telefono2,DateTime Contratacion,float SalarioDiario,
            string Banco,int NoCuenta,string Usuario,string Password,string Tipo,int Municipio,string Cp,string Colonia,string Calle,short Nointerior,short NoExt)
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
                var parametro10 = _comandosql.Parameters.Add("@Telefono1", SqlDbType.Int);
                parametro10.Value = Telefono1;
                var parametro11 = _comandosql.Parameters.Add("@Telefono2", SqlDbType.Int);
                parametro11.Value = Telefono2;
                var parametro12 = _comandosql.Parameters.Add("@FContratacion", SqlDbType.Date);
                parametro12.Value = Contratacion;
                var parametro13 = _comandosql.Parameters.Add("@SalarioDiario", SqlDbType.Money);
                parametro13.Value = SalarioDiario;
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


        #endregion

    }
}
