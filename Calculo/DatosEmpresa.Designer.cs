
namespace Proyecto_MAD.Calculo
{
    partial class DatosEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosEmpresa));
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.TB_RazonSocial = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_DatosEmp = new System.Windows.Forms.Label();
            this.LBL_RazonSocial = new System.Windows.Forms.Label();
            this.TB_Telefono = new System.Windows.Forms.TextBox();
            this.TB_Direccion = new System.Windows.Forms.TextBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_RegistroPatronal = new System.Windows.Forms.TextBox();
            this.LBL_Telefono = new System.Windows.Forms.Label();
            this.LBL_Email = new System.Windows.Forms.Label();
            this.LBL_RegistroPatronal = new System.Windows.Forms.Label();
            this.LBL_Direccion = new System.Windows.Forms.Label();
            this.LBL_RFC = new System.Windows.Forms.Label();
            this.TB_RFC = new System.Windows.Forms.TextBox();
            this.LBL_Fecha = new System.Windows.Forms.Label();
            this.TB_Fecha = new System.Windows.Forms.TextBox();
            this.Panel_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Panel_Background.Controls.Add(this.TB_Fecha);
            this.Panel_Background.Controls.Add(this.LBL_Fecha);
            this.Panel_Background.Controls.Add(this.TB_RFC);
            this.Panel_Background.Controls.Add(this.LBL_RFC);
            this.Panel_Background.Controls.Add(this.LBL_Direccion);
            this.Panel_Background.Controls.Add(this.LBL_RegistroPatronal);
            this.Panel_Background.Controls.Add(this.LBL_Email);
            this.Panel_Background.Controls.Add(this.LBL_Telefono);
            this.Panel_Background.Controls.Add(this.TB_RegistroPatronal);
            this.Panel_Background.Controls.Add(this.TB_Email);
            this.Panel_Background.Controls.Add(this.TB_Direccion);
            this.Panel_Background.Controls.Add(this.TB_Telefono);
            this.Panel_Background.Controls.Add(this.LBL_RazonSocial);
            this.Panel_Background.Controls.Add(this.LBL_DatosEmp);
            this.Panel_Background.Controls.Add(this.TB_RazonSocial);
            this.Panel_Background.Controls.Add(this.pictureBox1);
            this.Panel_Background.Controls.Add(this.LBL_Title);
            this.Panel_Background.Location = new System.Drawing.Point(12, 12);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(647, 302);
            this.Panel_Background.TabIndex = 26;
            // 
            // TB_RazonSocial
            // 
            this.TB_RazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.TB_RazonSocial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_RazonSocial.ForeColor = System.Drawing.Color.White;
            this.TB_RazonSocial.Location = new System.Drawing.Point(398, 49);
            this.TB_RazonSocial.Multiline = true;
            this.TB_RazonSocial.Name = "TB_RazonSocial";
            this.TB_RazonSocial.ReadOnly = true;
            this.TB_RazonSocial.Size = new System.Drawing.Size(199, 23);
            this.TB_RazonSocial.TabIndex = 25;
            this.TB_RazonSocial.TextChanged += new System.EventHandler(this.TB_Info_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.Color.White;
            this.LBL_Title.Location = new System.Drawing.Point(20, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(160, 23);
            this.LBL_Title.TabIndex = 23;
            this.LBL_Title.Text = "Datos Empresa";
            // 
            // LBL_DatosEmp
            // 
            this.LBL_DatosEmp.AutoSize = true;
            this.LBL_DatosEmp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DatosEmp.ForeColor = System.Drawing.Color.White;
            this.LBL_DatosEmp.Location = new System.Drawing.Point(419, 19);
            this.LBL_DatosEmp.Name = "LBL_DatosEmp";
            this.LBL_DatosEmp.Size = new System.Drawing.Size(151, 16);
            this.LBL_DatosEmp.TabIndex = 26;
            this.LBL_DatosEmp.Text = "DATOS DE EMPRESA";
            this.LBL_DatosEmp.Click += new System.EventHandler(this.LBL_ApMat_Click);
            // 
            // LBL_RazonSocial
            // 
            this.LBL_RazonSocial.AutoSize = true;
            this.LBL_RazonSocial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RazonSocial.ForeColor = System.Drawing.Color.White;
            this.LBL_RazonSocial.Location = new System.Drawing.Point(286, 52);
            this.LBL_RazonSocial.Name = "LBL_RazonSocial";
            this.LBL_RazonSocial.Size = new System.Drawing.Size(97, 16);
            this.LBL_RazonSocial.TabIndex = 27;
            this.LBL_RazonSocial.Text = "Razon Social:";
            // 
            // TB_Telefono
            // 
            this.TB_Telefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.TB_Telefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Telefono.ForeColor = System.Drawing.Color.White;
            this.TB_Telefono.Location = new System.Drawing.Point(398, 114);
            this.TB_Telefono.Multiline = true;
            this.TB_Telefono.Name = "TB_Telefono";
            this.TB_Telefono.ReadOnly = true;
            this.TB_Telefono.Size = new System.Drawing.Size(199, 23);
            this.TB_Telefono.TabIndex = 28;
            // 
            // TB_Direccion
            // 
            this.TB_Direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.TB_Direccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Direccion.ForeColor = System.Drawing.Color.White;
            this.TB_Direccion.Location = new System.Drawing.Point(398, 80);
            this.TB_Direccion.Multiline = true;
            this.TB_Direccion.Name = "TB_Direccion";
            this.TB_Direccion.ReadOnly = true;
            this.TB_Direccion.Size = new System.Drawing.Size(199, 23);
            this.TB_Direccion.TabIndex = 29;
            // 
            // TB_Email
            // 
            this.TB_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.TB_Email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Email.ForeColor = System.Drawing.Color.White;
            this.TB_Email.Location = new System.Drawing.Point(398, 147);
            this.TB_Email.Multiline = true;
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.ReadOnly = true;
            this.TB_Email.Size = new System.Drawing.Size(199, 23);
            this.TB_Email.TabIndex = 30;
            // 
            // TB_RegistroPatronal
            // 
            this.TB_RegistroPatronal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.TB_RegistroPatronal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_RegistroPatronal.ForeColor = System.Drawing.Color.White;
            this.TB_RegistroPatronal.Location = new System.Drawing.Point(421, 182);
            this.TB_RegistroPatronal.Multiline = true;
            this.TB_RegistroPatronal.Name = "TB_RegistroPatronal";
            this.TB_RegistroPatronal.ReadOnly = true;
            this.TB_RegistroPatronal.Size = new System.Drawing.Size(199, 23);
            this.TB_RegistroPatronal.TabIndex = 31;
            // 
            // LBL_Telefono
            // 
            this.LBL_Telefono.AutoSize = true;
            this.LBL_Telefono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Telefono.ForeColor = System.Drawing.Color.White;
            this.LBL_Telefono.Location = new System.Drawing.Point(286, 117);
            this.LBL_Telefono.Name = "LBL_Telefono";
            this.LBL_Telefono.Size = new System.Drawing.Size(69, 16);
            this.LBL_Telefono.TabIndex = 32;
            this.LBL_Telefono.Text = "Telefono:";
            // 
            // LBL_Email
            // 
            this.LBL_Email.AutoSize = true;
            this.LBL_Email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Email.ForeColor = System.Drawing.Color.White;
            this.LBL_Email.Location = new System.Drawing.Point(286, 150);
            this.LBL_Email.Name = "LBL_Email";
            this.LBL_Email.Size = new System.Drawing.Size(48, 16);
            this.LBL_Email.TabIndex = 34;
            this.LBL_Email.Text = "Email:";
            // 
            // LBL_RegistroPatronal
            // 
            this.LBL_RegistroPatronal.AutoSize = true;
            this.LBL_RegistroPatronal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RegistroPatronal.ForeColor = System.Drawing.Color.White;
            this.LBL_RegistroPatronal.Location = new System.Drawing.Point(286, 185);
            this.LBL_RegistroPatronal.Name = "LBL_RegistroPatronal";
            this.LBL_RegistroPatronal.Size = new System.Drawing.Size(129, 16);
            this.LBL_RegistroPatronal.TabIndex = 35;
            this.LBL_RegistroPatronal.Text = "Registro Patronal:";
            // 
            // LBL_Direccion
            // 
            this.LBL_Direccion.AutoSize = true;
            this.LBL_Direccion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Direccion.ForeColor = System.Drawing.Color.White;
            this.LBL_Direccion.Location = new System.Drawing.Point(286, 83);
            this.LBL_Direccion.Name = "LBL_Direccion";
            this.LBL_Direccion.Size = new System.Drawing.Size(75, 16);
            this.LBL_Direccion.TabIndex = 36;
            this.LBL_Direccion.Text = "Direccion:";
            // 
            // LBL_RFC
            // 
            this.LBL_RFC.AutoSize = true;
            this.LBL_RFC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RFC.ForeColor = System.Drawing.Color.White;
            this.LBL_RFC.Location = new System.Drawing.Point(286, 215);
            this.LBL_RFC.Name = "LBL_RFC";
            this.LBL_RFC.Size = new System.Drawing.Size(39, 16);
            this.LBL_RFC.TabIndex = 37;
            this.LBL_RFC.Text = "RFC:";
            // 
            // TB_RFC
            // 
            this.TB_RFC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.TB_RFC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_RFC.ForeColor = System.Drawing.Color.White;
            this.TB_RFC.Location = new System.Drawing.Point(398, 212);
            this.TB_RFC.Multiline = true;
            this.TB_RFC.Name = "TB_RFC";
            this.TB_RFC.ReadOnly = true;
            this.TB_RFC.Size = new System.Drawing.Size(199, 23);
            this.TB_RFC.TabIndex = 38;
            // 
            // LBL_Fecha
            // 
            this.LBL_Fecha.AutoSize = true;
            this.LBL_Fecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Fecha.ForeColor = System.Drawing.Color.White;
            this.LBL_Fecha.Location = new System.Drawing.Point(286, 244);
            this.LBL_Fecha.Name = "LBL_Fecha";
            this.LBL_Fecha.Size = new System.Drawing.Size(215, 16);
            this.LBL_Fecha.TabIndex = 39;
            this.LBL_Fecha.Text = "Fecha de Inicio de Operciones:";
            // 
            // TB_Fecha
            // 
            this.TB_Fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.TB_Fecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Fecha.ForeColor = System.Drawing.Color.White;
            this.TB_Fecha.Location = new System.Drawing.Point(289, 264);
            this.TB_Fecha.Multiline = true;
            this.TB_Fecha.Name = "TB_Fecha";
            this.TB_Fecha.ReadOnly = true;
            this.TB_Fecha.Size = new System.Drawing.Size(199, 23);
            this.TB_Fecha.TabIndex = 40;
            // 
            // DatosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 326);
            this.Controls.Add(this.Panel_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DatosEmpresa";
            this.Text = "DatosEmpresa";
            this.Load += new System.EventHandler(this.DatosEmpresa_Load);
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.TextBox TB_RazonSocial;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_DatosEmp;
        private System.Windows.Forms.Label LBL_Direccion;
        private System.Windows.Forms.Label LBL_RegistroPatronal;
        private System.Windows.Forms.Label LBL_Email;
        private System.Windows.Forms.Label LBL_Telefono;
        private System.Windows.Forms.TextBox TB_RegistroPatronal;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Direccion;
        private System.Windows.Forms.TextBox TB_Telefono;
        private System.Windows.Forms.Label LBL_RazonSocial;
        private System.Windows.Forms.Label LBL_RFC;
        private System.Windows.Forms.TextBox TB_Fecha;
        private System.Windows.Forms.Label LBL_Fecha;
        private System.Windows.Forms.TextBox TB_RFC;
    }
}