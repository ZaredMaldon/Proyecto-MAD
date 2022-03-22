
namespace Proyecto_MAD.Empleados
{
    partial class InicioEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioEmpleados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Salir_Btn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Panel_Contenedor = new System.Windows.Forms.Panel();
            this.Inicio_Btn = new FontAwesome.Sharp.IconButton();
            this.Recibo_Btn = new FontAwesome.Sharp.IconButton();
            this.DatosPer_Btn = new FontAwesome.Sharp.IconButton();
            this.Panel_Conten = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.Salir_Btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 55);
            this.panel1.TabIndex = 0;
            // 
            // Salir_Btn
            // 
            this.Salir_Btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Salir_Btn.FlatAppearance.BorderSize = 0;
            this.Salir_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Salir_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.Salir_Btn.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.Salir_Btn.IconColor = System.Drawing.Color.White;
            this.Salir_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Salir_Btn.IconSize = 35;
            this.Salir_Btn.Location = new System.Drawing.Point(910, 4);
            this.Salir_Btn.Margin = new System.Windows.Forms.Padding(0);
            this.Salir_Btn.Name = "Salir_Btn";
            this.Salir_Btn.Size = new System.Drawing.Size(31, 48);
            this.Salir_Btn.TabIndex = 4;
            this.Salir_Btn.UseVisualStyleBackColor = true;
            this.Salir_Btn.Click += new System.EventHandler(this.Salir_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empleado";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(218, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(732, 621);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.Panel_Contenedor);
            this.panel2.Controls.Add(this.Inicio_Btn);
            this.panel2.Controls.Add(this.Recibo_Btn);
            this.panel2.Controls.Add(this.DatosPer_Btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 620);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Panel_Contenedor
            // 
            this.Panel_Contenedor.Location = new System.Drawing.Point(221, 0);
            this.Panel_Contenedor.Name = "Panel_Contenedor";
            this.Panel_Contenedor.Size = new System.Drawing.Size(732, 621);
            this.Panel_Contenedor.TabIndex = 2;
            this.Panel_Contenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Contenedor_Paint);
            // 
            // Inicio_Btn
            // 
            this.Inicio_Btn.FlatAppearance.BorderSize = 0;
            this.Inicio_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.Inicio_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Inicio_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inicio_Btn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicio_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.Inicio_Btn.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.Inicio_Btn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.Inicio_Btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Inicio_Btn.IconSize = 55;
            this.Inicio_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Inicio_Btn.Location = new System.Drawing.Point(0, 144);
            this.Inicio_Btn.Name = "Inicio_Btn";
            this.Inicio_Btn.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.Inicio_Btn.Size = new System.Drawing.Size(217, 83);
            this.Inicio_Btn.TabIndex = 1;
            this.Inicio_Btn.Text = "Inicio";
            this.Inicio_Btn.UseVisualStyleBackColor = true;
            this.Inicio_Btn.Click += new System.EventHandler(this.Inicio_Btn_Click);
            // 
            // Recibo_Btn
            // 
            this.Recibo_Btn.FlatAppearance.BorderSize = 0;
            this.Recibo_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.Recibo_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Recibo_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recibo_Btn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recibo_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.Recibo_Btn.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.Recibo_Btn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.Recibo_Btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Recibo_Btn.IconSize = 55;
            this.Recibo_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Recibo_Btn.Location = new System.Drawing.Point(0, 322);
            this.Recibo_Btn.Name = "Recibo_Btn";
            this.Recibo_Btn.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.Recibo_Btn.Size = new System.Drawing.Size(217, 83);
            this.Recibo_Btn.TabIndex = 3;
            this.Recibo_Btn.Text = "Consulta Recibo";
            this.Recibo_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Recibo_Btn.UseCompatibleTextRendering = true;
            this.Recibo_Btn.UseVisualStyleBackColor = true;
            this.Recibo_Btn.Click += new System.EventHandler(this.Recibo_Btn_Click);
            // 
            // DatosPer_Btn
            // 
            this.DatosPer_Btn.FlatAppearance.BorderSize = 0;
            this.DatosPer_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(43)))));
            this.DatosPer_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.DatosPer_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DatosPer_Btn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosPer_Btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.DatosPer_Btn.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.DatosPer_Btn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(64)))), ((int)(((byte)(102)))));
            this.DatosPer_Btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.DatosPer_Btn.IconSize = 55;
            this.DatosPer_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DatosPer_Btn.Location = new System.Drawing.Point(0, 233);
            this.DatosPer_Btn.Name = "DatosPer_Btn";
            this.DatosPer_Btn.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.DatosPer_Btn.Size = new System.Drawing.Size(217, 83);
            this.DatosPer_Btn.TabIndex = 2;
            this.DatosPer_Btn.Text = "Datos Personales";
            this.DatosPer_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DatosPer_Btn.UseVisualStyleBackColor = true;
            this.DatosPer_Btn.Click += new System.EventHandler(this.DatosPer_Btn_Click);
            // 
            // Panel_Conten
            // 
            this.Panel_Conten.BackColor = System.Drawing.Color.Black;
            this.Panel_Conten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Conten.Location = new System.Drawing.Point(220, 55);
            this.Panel_Conten.Name = "Panel_Conten";
            this.Panel_Conten.Size = new System.Drawing.Size(730, 620);
            this.Panel_Conten.TabIndex = 2;
            // 
            // InicioEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 675);
            this.Controls.Add(this.Panel_Conten);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InicioEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InicioEmpleados";
            this.Load += new System.EventHandler(this.InicioEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton Inicio_Btn;
        private FontAwesome.Sharp.IconButton Recibo_Btn;
        private FontAwesome.Sharp.IconButton DatosPer_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Salir_Btn;
        private System.Windows.Forms.Panel Panel_Contenedor;
        private System.Windows.Forms.Panel Panel_Conten;
    }
}