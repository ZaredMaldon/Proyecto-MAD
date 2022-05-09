
namespace Proyecto_MAD.Gerente
{
    partial class GestionEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionEmpleado));
            this.Dgv_GestionEmpleados = new System.Windows.Forms.DataGridView();
            this.Panel_Registro = new System.Windows.Forms.Panel();
            this.Lbl_Cp = new System.Windows.Forms.Label();
            this.TB_Cp = new System.Windows.Forms.TextBox();
            this.lbl_ingreso = new System.Windows.Forms.Label();
            this.DTP_Contratacion = new System.Windows.Forms.DateTimePicker();
            this.LBL_NoCuenta = new System.Windows.Forms.Label();
            this.TB_NoCuenta = new System.Windows.Forms.TextBox();
            this.LBL_Banco = new System.Windows.Forms.Label();
            this.TB_Banco = new System.Windows.Forms.TextBox();
            this.Lbl_Puesto = new System.Windows.Forms.Label();
            this.CB_Puesto = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_Usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Password2 = new System.Windows.Forms.TextBox();
            this.Lbl_Password = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.Lbl_Dpto = new System.Windows.Forms.Label();
            this.CB_Dpto = new System.Windows.Forms.ComboBox();
            this.LBL_Municipio = new System.Windows.Forms.Label();
            this.CB_Municipio = new System.Windows.Forms.ComboBox();
            this.LBL_NoInt = new System.Windows.Forms.Label();
            this.TB_NoInt = new System.Windows.Forms.TextBox();
            this.LBL_NoExt = new System.Windows.Forms.Label();
            this.TB_NoExt = new System.Windows.Forms.TextBox();
            this.LBL_Calle = new System.Windows.Forms.Label();
            this.TB_Calle = new System.Windows.Forms.TextBox();
            this.LBL_Colonia = new System.Windows.Forms.Label();
            this.TB_Colonia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Telefono2 = new System.Windows.Forms.TextBox();
            this.TB_RFC = new System.Windows.Forms.TextBox();
            this.TB_ApMat = new System.Windows.Forms.TextBox();
            this.TB_NSS = new System.Windows.Forms.TextBox();
            this.LBL_CURP = new System.Windows.Forms.Label();
            this.LBL_Telefono = new System.Windows.Forms.Label();
            this.DTP_FechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.TB_Telefono = new System.Windows.Forms.TextBox();
            this.lblb_Email = new System.Windows.Forms.Label();
            this.TB_CURP = new System.Windows.Forms.TextBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.Lbl_Fecha = new System.Windows.Forms.Label();
            this.LBL_NSS = new System.Windows.Forms.Label();
            this.TB_ApPat = new System.Windows.Forms.TextBox();
            this.LBL_RFC = new System.Windows.Forms.Label();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.LBL_ApPat = new System.Windows.Forms.Label();
            this.LBL_ApMat = new System.Windows.Forms.Label();
            this.Btn_Registrar = new FontAwesome.Sharp.IconButton();
            this.Btn_Modificar = new FontAwesome.Sharp.IconButton();
            this.Btn_Eliminar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_GestionEmpleados)).BeginInit();
            this.Panel_Registro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_GestionEmpleados
            // 
            this.Dgv_GestionEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Dgv_GestionEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_GestionEmpleados.Location = new System.Drawing.Point(34, 454);
            this.Dgv_GestionEmpleados.MultiSelect = false;
            this.Dgv_GestionEmpleados.Name = "Dgv_GestionEmpleados";
            this.Dgv_GestionEmpleados.ReadOnly = true;
            this.Dgv_GestionEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_GestionEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_GestionEmpleados.Size = new System.Drawing.Size(519, 146);
            this.Dgv_GestionEmpleados.TabIndex = 0;
            this.Dgv_GestionEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_GestionEmpleados_CellClick);
            // 
            // Panel_Registro
            // 
            this.Panel_Registro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Panel_Registro.Controls.Add(this.Lbl_Cp);
            this.Panel_Registro.Controls.Add(this.TB_Cp);
            this.Panel_Registro.Controls.Add(this.lbl_ingreso);
            this.Panel_Registro.Controls.Add(this.DTP_Contratacion);
            this.Panel_Registro.Controls.Add(this.LBL_NoCuenta);
            this.Panel_Registro.Controls.Add(this.TB_NoCuenta);
            this.Panel_Registro.Controls.Add(this.LBL_Banco);
            this.Panel_Registro.Controls.Add(this.TB_Banco);
            this.Panel_Registro.Controls.Add(this.Lbl_Puesto);
            this.Panel_Registro.Controls.Add(this.CB_Puesto);
            this.Panel_Registro.Controls.Add(this.panel1);
            this.Panel_Registro.Controls.Add(this.Lbl_Dpto);
            this.Panel_Registro.Controls.Add(this.CB_Dpto);
            this.Panel_Registro.Controls.Add(this.LBL_Municipio);
            this.Panel_Registro.Controls.Add(this.CB_Municipio);
            this.Panel_Registro.Controls.Add(this.LBL_NoInt);
            this.Panel_Registro.Controls.Add(this.TB_NoInt);
            this.Panel_Registro.Controls.Add(this.LBL_NoExt);
            this.Panel_Registro.Controls.Add(this.TB_NoExt);
            this.Panel_Registro.Controls.Add(this.LBL_Calle);
            this.Panel_Registro.Controls.Add(this.TB_Calle);
            this.Panel_Registro.Controls.Add(this.LBL_Colonia);
            this.Panel_Registro.Controls.Add(this.TB_Colonia);
            this.Panel_Registro.Controls.Add(this.label11);
            this.Panel_Registro.Controls.Add(this.label10);
            this.Panel_Registro.Controls.Add(this.label8);
            this.Panel_Registro.Controls.Add(this.TB_Telefono2);
            this.Panel_Registro.Controls.Add(this.TB_RFC);
            this.Panel_Registro.Controls.Add(this.TB_ApMat);
            this.Panel_Registro.Controls.Add(this.TB_NSS);
            this.Panel_Registro.Controls.Add(this.LBL_CURP);
            this.Panel_Registro.Controls.Add(this.LBL_Telefono);
            this.Panel_Registro.Controls.Add(this.DTP_FechaNacimiento);
            this.Panel_Registro.Controls.Add(this.TB_Telefono);
            this.Panel_Registro.Controls.Add(this.lblb_Email);
            this.Panel_Registro.Controls.Add(this.TB_CURP);
            this.Panel_Registro.Controls.Add(this.TB_Email);
            this.Panel_Registro.Controls.Add(this.Lbl_Fecha);
            this.Panel_Registro.Controls.Add(this.LBL_NSS);
            this.Panel_Registro.Controls.Add(this.TB_ApPat);
            this.Panel_Registro.Controls.Add(this.LBL_RFC);
            this.Panel_Registro.Controls.Add(this.LBL_Nombre);
            this.Panel_Registro.Controls.Add(this.TB_Nombre);
            this.Panel_Registro.Controls.Add(this.LBL_ApPat);
            this.Panel_Registro.Controls.Add(this.LBL_ApMat);
            this.Panel_Registro.Location = new System.Drawing.Point(34, 23);
            this.Panel_Registro.Name = "Panel_Registro";
            this.Panel_Registro.Size = new System.Drawing.Size(665, 425);
            this.Panel_Registro.TabIndex = 5;
            // 
            // Lbl_Cp
            // 
            this.Lbl_Cp.AutoSize = true;
            this.Lbl_Cp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cp.ForeColor = System.Drawing.Color.White;
            this.Lbl_Cp.Location = new System.Drawing.Point(378, 284);
            this.Lbl_Cp.Name = "Lbl_Cp";
            this.Lbl_Cp.Size = new System.Drawing.Size(32, 16);
            this.Lbl_Cp.TabIndex = 58;
            this.Lbl_Cp.Text = "Cp*";
            // 
            // TB_Cp
            // 
            this.TB_Cp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Cp.Location = new System.Drawing.Point(484, 277);
            this.TB_Cp.MaxLength = 5;
            this.TB_Cp.Name = "TB_Cp";
            this.TB_Cp.Size = new System.Drawing.Size(150, 23);
            this.TB_Cp.TabIndex = 59;
            this.TB_Cp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Cp_KeyPress);
            // 
            // lbl_ingreso
            // 
            this.lbl_ingreso.AutoSize = true;
            this.lbl_ingreso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingreso.ForeColor = System.Drawing.Color.White;
            this.lbl_ingreso.Location = new System.Drawing.Point(17, 281);
            this.lbl_ingreso.Name = "lbl_ingreso";
            this.lbl_ingreso.Size = new System.Drawing.Size(64, 16);
            this.lbl_ingreso.TabIndex = 57;
            this.lbl_ingreso.Text = "Ingreso*";
            // 
            // DTP_Contratacion
            // 
            this.DTP_Contratacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.DTP_Contratacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Contratacion.Location = new System.Drawing.Point(129, 281);
            this.DTP_Contratacion.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.DTP_Contratacion.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DTP_Contratacion.Name = "DTP_Contratacion";
            this.DTP_Contratacion.Size = new System.Drawing.Size(150, 23);
            this.DTP_Contratacion.TabIndex = 56;
            this.DTP_Contratacion.Value = new System.DateTime(2022, 4, 16, 0, 0, 0, 0);
            // 
            // LBL_NoCuenta
            // 
            this.LBL_NoCuenta.AutoSize = true;
            this.LBL_NoCuenta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NoCuenta.ForeColor = System.Drawing.Color.White;
            this.LBL_NoCuenta.Location = new System.Drawing.Point(379, 368);
            this.LBL_NoCuenta.Name = "LBL_NoCuenta";
            this.LBL_NoCuenta.Size = new System.Drawing.Size(83, 16);
            this.LBL_NoCuenta.TabIndex = 53;
            this.LBL_NoCuenta.Text = "No.Cuenta*";
            // 
            // TB_NoCuenta
            // 
            this.TB_NoCuenta.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_NoCuenta.Location = new System.Drawing.Point(484, 361);
            this.TB_NoCuenta.MaxLength = 6;
            this.TB_NoCuenta.Name = "TB_NoCuenta";
            this.TB_NoCuenta.Size = new System.Drawing.Size(150, 23);
            this.TB_NoCuenta.TabIndex = 55;
            this.TB_NoCuenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NoCuenta_KeyPress);
            // 
            // LBL_Banco
            // 
            this.LBL_Banco.AutoSize = true;
            this.LBL_Banco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Banco.ForeColor = System.Drawing.Color.White;
            this.LBL_Banco.Location = new System.Drawing.Point(379, 326);
            this.LBL_Banco.Name = "LBL_Banco";
            this.LBL_Banco.Size = new System.Drawing.Size(55, 16);
            this.LBL_Banco.TabIndex = 52;
            this.LBL_Banco.Text = "Banco*";
            // 
            // TB_Banco
            // 
            this.TB_Banco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Banco.Location = new System.Drawing.Point(484, 323);
            this.TB_Banco.MaxLength = 30;
            this.TB_Banco.Name = "TB_Banco";
            this.TB_Banco.Size = new System.Drawing.Size(150, 23);
            this.TB_Banco.TabIndex = 54;
            this.TB_Banco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Banco_KeyPress);
            // 
            // Lbl_Puesto
            // 
            this.Lbl_Puesto.AutoSize = true;
            this.Lbl_Puesto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Puesto.ForeColor = System.Drawing.Color.White;
            this.Lbl_Puesto.Location = new System.Drawing.Point(17, 250);
            this.Lbl_Puesto.Name = "Lbl_Puesto";
            this.Lbl_Puesto.Size = new System.Drawing.Size(59, 16);
            this.Lbl_Puesto.TabIndex = 51;
            this.Lbl_Puesto.Text = "Puesto*";
            // 
            // CB_Puesto
            // 
            this.CB_Puesto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.CB_Puesto.FormattingEnabled = true;
            this.CB_Puesto.Location = new System.Drawing.Point(129, 243);
            this.CB_Puesto.Name = "CB_Puesto";
            this.CB_Puesto.Size = new System.Drawing.Size(150, 23);
            this.CB_Puesto.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.TB_Usuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Tb_Password2);
            this.panel1.Controls.Add(this.Lbl_Password);
            this.panel1.Controls.Add(this.Lbl_Usuario);
            this.panel1.Controls.Add(this.TB_Password);
            this.panel1.Location = new System.Drawing.Point(0, 310);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 115);
            this.panel1.TabIndex = 47;
            // 
            // TB_Usuario
            // 
            this.TB_Usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Usuario.Location = new System.Drawing.Point(121, 13);
            this.TB_Usuario.MaxLength = 10;
            this.TB_Usuario.Name = "TB_Usuario";
            this.TB_Usuario.Size = new System.Drawing.Size(150, 23);
            this.TB_Usuario.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Contraseña*";
            // 
            // Tb_Password2
            // 
            this.Tb_Password2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Tb_Password2.Location = new System.Drawing.Point(121, 71);
            this.Tb_Password2.MaxLength = 10;
            this.Tb_Password2.Name = "Tb_Password2";
            this.Tb_Password2.Size = new System.Drawing.Size(150, 23);
            this.Tb_Password2.TabIndex = 46;
            // 
            // Lbl_Password
            // 
            this.Lbl_Password.AutoSize = true;
            this.Lbl_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Password.ForeColor = System.Drawing.Color.White;
            this.Lbl_Password.Location = new System.Drawing.Point(4, 49);
            this.Lbl_Password.Name = "Lbl_Password";
            this.Lbl_Password.Size = new System.Drawing.Size(90, 16);
            this.Lbl_Password.TabIndex = 41;
            this.Lbl_Password.Text = "Contraseña*";
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Usuario.ForeColor = System.Drawing.Color.White;
            this.Lbl_Usuario.Location = new System.Drawing.Point(4, 20);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(66, 16);
            this.Lbl_Usuario.TabIndex = 44;
            this.Lbl_Usuario.Text = "Usuario*";
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Password.Location = new System.Drawing.Point(121, 42);
            this.TB_Password.MaxLength = 10;
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(150, 23);
            this.TB_Password.TabIndex = 43;
            // 
            // Lbl_Dpto
            // 
            this.Lbl_Dpto.AutoSize = true;
            this.Lbl_Dpto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dpto.ForeColor = System.Drawing.Color.White;
            this.Lbl_Dpto.Location = new System.Drawing.Point(14, 214);
            this.Lbl_Dpto.Name = "Lbl_Dpto";
            this.Lbl_Dpto.Size = new System.Drawing.Size(108, 16);
            this.Lbl_Dpto.TabIndex = 50;
            this.Lbl_Dpto.Text = "Departamento*";
            // 
            // CB_Dpto
            // 
            this.CB_Dpto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.CB_Dpto.FormattingEnabled = true;
            this.CB_Dpto.Location = new System.Drawing.Point(129, 207);
            this.CB_Dpto.Name = "CB_Dpto";
            this.CB_Dpto.Size = new System.Drawing.Size(150, 23);
            this.CB_Dpto.TabIndex = 48;
            this.CB_Dpto.DropDownClosed += new System.EventHandler(this.CB_Dpto_DropDownClosed);
            // 
            // LBL_Municipio
            // 
            this.LBL_Municipio.AutoSize = true;
            this.LBL_Municipio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Municipio.ForeColor = System.Drawing.Color.White;
            this.LBL_Municipio.Location = new System.Drawing.Point(379, 178);
            this.LBL_Municipio.Name = "LBL_Municipio";
            this.LBL_Municipio.Size = new System.Drawing.Size(78, 16);
            this.LBL_Municipio.TabIndex = 33;
            this.LBL_Municipio.Text = "Municipio*";
            // 
            // CB_Municipio
            // 
            this.CB_Municipio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.CB_Municipio.FormattingEnabled = true;
            this.CB_Municipio.Location = new System.Drawing.Point(484, 178);
            this.CB_Municipio.Name = "CB_Municipio";
            this.CB_Municipio.Size = new System.Drawing.Size(150, 23);
            this.CB_Municipio.TabIndex = 29;
            // 
            // LBL_NoInt
            // 
            this.LBL_NoInt.AutoSize = true;
            this.LBL_NoInt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NoInt.ForeColor = System.Drawing.Color.White;
            this.LBL_NoInt.Location = new System.Drawing.Point(489, 138);
            this.LBL_NoInt.Name = "LBL_NoInt";
            this.LBL_NoInt.Size = new System.Drawing.Size(79, 16);
            this.LBL_NoInt.TabIndex = 27;
            this.LBL_NoInt.Text = "No.Interior";
            // 
            // TB_NoInt
            // 
            this.TB_NoInt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_NoInt.Location = new System.Drawing.Point(575, 134);
            this.TB_NoInt.MaxLength = 4;
            this.TB_NoInt.Name = "TB_NoInt";
            this.TB_NoInt.Size = new System.Drawing.Size(59, 23);
            this.TB_NoInt.TabIndex = 35;
            this.TB_NoInt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NoInt_KeyPress);
            // 
            // LBL_NoExt
            // 
            this.LBL_NoExt.AutoSize = true;
            this.LBL_NoExt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NoExt.ForeColor = System.Drawing.Color.White;
            this.LBL_NoExt.Location = new System.Drawing.Point(295, 141);
            this.LBL_NoExt.Name = "LBL_NoExt";
            this.LBL_NoExt.Size = new System.Drawing.Size(89, 16);
            this.LBL_NoExt.TabIndex = 26;
            this.LBL_NoExt.Text = "No.Exterior*";
            // 
            // TB_NoExt
            // 
            this.TB_NoExt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_NoExt.Location = new System.Drawing.Point(391, 134);
            this.TB_NoExt.MaxLength = 4;
            this.TB_NoExt.Name = "TB_NoExt";
            this.TB_NoExt.Size = new System.Drawing.Size(59, 23);
            this.TB_NoExt.TabIndex = 32;
            this.TB_NoExt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NoExt_KeyPress);
            // 
            // LBL_Calle
            // 
            this.LBL_Calle.AutoSize = true;
            this.LBL_Calle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Calle.ForeColor = System.Drawing.Color.White;
            this.LBL_Calle.Location = new System.Drawing.Point(378, 254);
            this.LBL_Calle.Name = "LBL_Calle";
            this.LBL_Calle.Size = new System.Drawing.Size(47, 16);
            this.LBL_Calle.TabIndex = 25;
            this.LBL_Calle.Text = "Calle*";
            // 
            // TB_Calle
            // 
            this.TB_Calle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Calle.Location = new System.Drawing.Point(484, 247);
            this.TB_Calle.MaxLength = 25;
            this.TB_Calle.Name = "TB_Calle";
            this.TB_Calle.Size = new System.Drawing.Size(150, 23);
            this.TB_Calle.TabIndex = 34;
            // 
            // LBL_Colonia
            // 
            this.LBL_Colonia.AutoSize = true;
            this.LBL_Colonia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Colonia.ForeColor = System.Drawing.Color.White;
            this.LBL_Colonia.Location = new System.Drawing.Point(378, 219);
            this.LBL_Colonia.Name = "LBL_Colonia";
            this.LBL_Colonia.Size = new System.Drawing.Size(63, 16);
            this.LBL_Colonia.TabIndex = 24;
            this.LBL_Colonia.Text = "Colonia*";
            // 
            // TB_Colonia
            // 
            this.TB_Colonia.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Colonia.Location = new System.Drawing.Point(484, 212);
            this.TB_Colonia.MaxLength = 25;
            this.TB_Colonia.Name = "TB_Colonia";
            this.TB_Colonia.Size = new System.Drawing.Size(150, 23);
            this.TB_Colonia.TabIndex = 31;
            this.TB_Colonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Colonia_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(107, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(107, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "1*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Registro Empleado";
            // 
            // TB_Telefono2
            // 
            this.TB_Telefono2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Telefono2.Location = new System.Drawing.Point(129, 174);
            this.TB_Telefono2.MaxLength = 10;
            this.TB_Telefono2.Name = "TB_Telefono2";
            this.TB_Telefono2.Size = new System.Drawing.Size(150, 23);
            this.TB_Telefono2.TabIndex = 14;
            this.TB_Telefono2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Telefono2_KeyPress);
            // 
            // TB_RFC
            // 
            this.TB_RFC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_RFC.Location = new System.Drawing.Point(361, 79);
            this.TB_RFC.MaxLength = 13;
            this.TB_RFC.Name = "TB_RFC";
            this.TB_RFC.Size = new System.Drawing.Size(154, 23);
            this.TB_RFC.TabIndex = 10;
            // 
            // TB_ApMat
            // 
            this.TB_ApMat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_ApMat.Location = new System.Drawing.Point(361, 34);
            this.TB_ApMat.MaxLength = 25;
            this.TB_ApMat.Name = "TB_ApMat";
            this.TB_ApMat.Size = new System.Drawing.Size(154, 23);
            this.TB_ApMat.TabIndex = 7;
            this.TB_ApMat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_ApMat_KeyPress);
            // 
            // TB_NSS
            // 
            this.TB_NSS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_NSS.Location = new System.Drawing.Point(190, 79);
            this.TB_NSS.MaxLength = 11;
            this.TB_NSS.Name = "TB_NSS";
            this.TB_NSS.Size = new System.Drawing.Size(154, 23);
            this.TB_NSS.TabIndex = 9;
            this.TB_NSS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NSS_KeyPress);
            // 
            // LBL_CURP
            // 
            this.LBL_CURP.AutoSize = true;
            this.LBL_CURP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CURP.ForeColor = System.Drawing.Color.White;
            this.LBL_CURP.Location = new System.Drawing.Point(17, 105);
            this.LBL_CURP.Name = "LBL_CURP";
            this.LBL_CURP.Size = new System.Drawing.Size(53, 16);
            this.LBL_CURP.TabIndex = 2;
            this.LBL_CURP.Text = "CURP*";
            // 
            // LBL_Telefono
            // 
            this.LBL_Telefono.AutoSize = true;
            this.LBL_Telefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Telefono.ForeColor = System.Drawing.Color.White;
            this.LBL_Telefono.Location = new System.Drawing.Point(23, 137);
            this.LBL_Telefono.Name = "LBL_Telefono";
            this.LBL_Telefono.Size = new System.Drawing.Size(73, 16);
            this.LBL_Telefono.TabIndex = 6;
            this.LBL_Telefono.Text = "Telefonos";
            // 
            // DTP_FechaNacimiento
            // 
            this.DTP_FechaNacimiento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.DTP_FechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_FechaNacimiento.Location = new System.Drawing.Point(533, 34);
            this.DTP_FechaNacimiento.MaxDate = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.DTP_FechaNacimiento.MinDate = new System.DateTime(1850, 12, 31, 0, 0, 0, 0);
            this.DTP_FechaNacimiento.Name = "DTP_FechaNacimiento";
            this.DTP_FechaNacimiento.Size = new System.Drawing.Size(101, 23);
            this.DTP_FechaNacimiento.TabIndex = 12;
            this.DTP_FechaNacimiento.Value = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            // 
            // TB_Telefono
            // 
            this.TB_Telefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Telefono.Location = new System.Drawing.Point(129, 134);
            this.TB_Telefono.MaxLength = 10;
            this.TB_Telefono.Name = "TB_Telefono";
            this.TB_Telefono.Size = new System.Drawing.Size(150, 23);
            this.TB_Telefono.TabIndex = 13;
            this.TB_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Telefono_KeyPress);
            // 
            // lblb_Email
            // 
            this.lblb_Email.AutoSize = true;
            this.lblb_Email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblb_Email.ForeColor = System.Drawing.Color.White;
            this.lblb_Email.Location = new System.Drawing.Point(533, 105);
            this.lblb_Email.Name = "lblb_Email";
            this.lblb_Email.Size = new System.Drawing.Size(50, 16);
            this.lblb_Email.TabIndex = 4;
            this.lblb_Email.Text = "Email*";
            // 
            // TB_CURP
            // 
            this.TB_CURP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_CURP.Location = new System.Drawing.Point(20, 79);
            this.TB_CURP.MaxLength = 18;
            this.TB_CURP.Name = "TB_CURP";
            this.TB_CURP.Size = new System.Drawing.Size(154, 23);
            this.TB_CURP.TabIndex = 8;
            // 
            // TB_Email
            // 
            this.TB_Email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Email.Location = new System.Drawing.Point(533, 79);
            this.TB_Email.MaxLength = 50;
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(101, 23);
            this.TB_Email.TabIndex = 11;
            // 
            // Lbl_Fecha
            // 
            this.Lbl_Fecha.AutoSize = true;
            this.Lbl_Fecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Fecha.ForeColor = System.Drawing.Color.White;
            this.Lbl_Fecha.Location = new System.Drawing.Point(530, 60);
            this.Lbl_Fecha.Name = "Lbl_Fecha";
            this.Lbl_Fecha.Size = new System.Drawing.Size(89, 16);
            this.Lbl_Fecha.TabIndex = 2;
            this.Lbl_Fecha.Text = "Nacimiento*";
            // 
            // LBL_NSS
            // 
            this.LBL_NSS.AutoSize = true;
            this.LBL_NSS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_NSS.ForeColor = System.Drawing.Color.White;
            this.LBL_NSS.Location = new System.Drawing.Point(187, 105);
            this.LBL_NSS.Name = "LBL_NSS";
            this.LBL_NSS.Size = new System.Drawing.Size(42, 16);
            this.LBL_NSS.TabIndex = 2;
            this.LBL_NSS.Text = "NSS*";
            // 
            // TB_ApPat
            // 
            this.TB_ApPat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_ApPat.Location = new System.Drawing.Point(190, 34);
            this.TB_ApPat.MaxLength = 25;
            this.TB_ApPat.Name = "TB_ApPat";
            this.TB_ApPat.Size = new System.Drawing.Size(154, 23);
            this.TB_ApPat.TabIndex = 6;
            this.TB_ApPat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_ApPat_KeyPress);
            // 
            // LBL_RFC
            // 
            this.LBL_RFC.AutoSize = true;
            this.LBL_RFC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RFC.ForeColor = System.Drawing.Color.White;
            this.LBL_RFC.Location = new System.Drawing.Point(358, 105);
            this.LBL_RFC.Name = "LBL_RFC";
            this.LBL_RFC.Size = new System.Drawing.Size(41, 16);
            this.LBL_RFC.TabIndex = 2;
            this.LBL_RFC.Text = "RFC*";
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Nombre.ForeColor = System.Drawing.Color.White;
            this.LBL_Nombre.Location = new System.Drawing.Point(17, 60);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(85, 16);
            this.LBL_Nombre.TabIndex = 2;
            this.LBL_Nombre.Text = "Nombre(s)*";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Nombre.Location = new System.Drawing.Point(20, 34);
            this.TB_Nombre.MaxLength = 25;
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(154, 23);
            this.TB_Nombre.TabIndex = 5;
            this.TB_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Nombre_KeyPress);
            // 
            // LBL_ApPat
            // 
            this.LBL_ApPat.AutoSize = true;
            this.LBL_ApPat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ApPat.ForeColor = System.Drawing.Color.White;
            this.LBL_ApPat.Location = new System.Drawing.Point(187, 60);
            this.LBL_ApPat.Name = "LBL_ApPat";
            this.LBL_ApPat.Size = new System.Drawing.Size(125, 16);
            this.LBL_ApPat.TabIndex = 2;
            this.LBL_ApPat.Text = "Apellido Paterno*";
            // 
            // LBL_ApMat
            // 
            this.LBL_ApMat.AutoSize = true;
            this.LBL_ApMat.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_ApMat.ForeColor = System.Drawing.Color.White;
            this.LBL_ApMat.Location = new System.Drawing.Point(358, 60);
            this.LBL_ApMat.Name = "LBL_ApMat";
            this.LBL_ApMat.Size = new System.Drawing.Size(122, 16);
            this.LBL_ApMat.TabIndex = 2;
            this.LBL_ApMat.Text = "Apellido Materno";
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Btn_Registrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Btn_Registrar.FlatAppearance.BorderSize = 2;
            this.Btn_Registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Btn_Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Registrar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Registrar.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
            this.Btn_Registrar.IconColor = System.Drawing.Color.White;
            this.Btn_Registrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Registrar.IconSize = 45;
            this.Btn_Registrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Registrar.Location = new System.Drawing.Point(556, 454);
            this.Btn_Registrar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(140, 40);
            this.Btn_Registrar.TabIndex = 52;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Btn_Modificar.FlatAppearance.BorderSize = 2;
            this.Btn_Modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Btn_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.Btn_Modificar.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.Btn_Modificar.IconColor = System.Drawing.Color.White;
            this.Btn_Modificar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Modificar.IconSize = 45;
            this.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Modificar.Location = new System.Drawing.Point(556, 507);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(140, 40);
            this.Btn_Modificar.TabIndex = 53;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Btn_Eliminar.FlatAppearance.BorderSize = 2;
            this.Btn_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Btn_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.Btn_Eliminar.IconColor = System.Drawing.Color.White;
            this.Btn_Eliminar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Eliminar.IconSize = 45;
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar.Location = new System.Drawing.Point(556, 560);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.Btn_Eliminar.Size = new System.Drawing.Size(140, 40);
            this.Btn_Eliminar.TabIndex = 54;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // GestionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 625);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Panel_Registro);
            this.Controls.Add(this.Dgv_GestionEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionEmpleado";
            this.Text = "GestionEmpleado";
            this.Load += new System.EventHandler(this.GestionEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_GestionEmpleados)).EndInit();
            this.Panel_Registro.ResumeLayout(false);
            this.Panel_Registro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_GestionEmpleados;
        private System.Windows.Forms.Panel Panel_Registro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Telefono2;
        private System.Windows.Forms.TextBox TB_RFC;
        private System.Windows.Forms.TextBox TB_ApMat;
        private System.Windows.Forms.TextBox TB_NSS;
        private System.Windows.Forms.Label LBL_CURP;
        private System.Windows.Forms.Label LBL_Telefono;
        private System.Windows.Forms.DateTimePicker DTP_FechaNacimiento;
        private System.Windows.Forms.TextBox TB_Telefono;
        private System.Windows.Forms.Label lblb_Email;
        private System.Windows.Forms.TextBox TB_CURP;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label Lbl_Fecha;
        private System.Windows.Forms.Label LBL_NSS;
        private System.Windows.Forms.TextBox TB_ApPat;
        private System.Windows.Forms.Label LBL_RFC;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Label LBL_ApPat;
        private System.Windows.Forms.Label LBL_ApMat;
        private System.Windows.Forms.Label LBL_Municipio;
        private System.Windows.Forms.ComboBox CB_Municipio;
        private System.Windows.Forms.Label LBL_NoInt;
        private System.Windows.Forms.TextBox TB_NoInt;
        private System.Windows.Forms.Label LBL_NoExt;
        private System.Windows.Forms.TextBox TB_NoExt;
        private System.Windows.Forms.Label LBL_Calle;
        private System.Windows.Forms.TextBox TB_Calle;
        private System.Windows.Forms.Label LBL_Colonia;
        private System.Windows.Forms.TextBox TB_Colonia;
        private System.Windows.Forms.Label Lbl_Puesto;
        private System.Windows.Forms.ComboBox CB_Puesto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_Usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Password2;
        private System.Windows.Forms.Label Lbl_Password;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label Lbl_Dpto;
        private System.Windows.Forms.ComboBox CB_Dpto;
        private FontAwesome.Sharp.IconButton Btn_Registrar;
        private FontAwesome.Sharp.IconButton Btn_Modificar;
        private FontAwesome.Sharp.IconButton Btn_Eliminar;
        private System.Windows.Forms.Label LBL_NoCuenta;
        private System.Windows.Forms.TextBox TB_NoCuenta;
        private System.Windows.Forms.Label LBL_Banco;
        private System.Windows.Forms.TextBox TB_Banco;
        private System.Windows.Forms.Label lbl_ingreso;
        private System.Windows.Forms.DateTimePicker DTP_Contratacion;
        private System.Windows.Forms.Label Lbl_Cp;
        private System.Windows.Forms.TextBox TB_Cp;
    }
}