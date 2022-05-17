
namespace Proyecto_MAD.Percepciones_y_deducciones
{
    partial class Percepciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Percepciones));
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.btn_CargarExcel = new FontAwesome.Sharp.IconButton();
            this.Btn_EliminarPercepcion = new FontAwesome.Sharp.IconButton();
            this.Dgv_Percepciones = new System.Windows.Forms.DataGridView();
            this.Lbl_Porcentaje = new System.Windows.Forms.Label();
            this.TB_Porcentaje = new System.Windows.Forms.TextBox();
            this.TB_Bono = new System.Windows.Forms.TextBox();
            this.Lbl_Bono = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.Btn_AgregarPercepcion = new FontAwesome.Sharp.IconButton();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.CHB_Porcentaje = new System.Windows.Forms.CheckBox();
            this.lbl_signo = new System.Windows.Forms.Label();
            this.Panel_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Percepciones)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Panel_Background.Controls.Add(this.lbl_signo);
            this.Panel_Background.Controls.Add(this.CHB_Porcentaje);
            this.Panel_Background.Controls.Add(this.btn_CargarExcel);
            this.Panel_Background.Controls.Add(this.Btn_EliminarPercepcion);
            this.Panel_Background.Controls.Add(this.Dgv_Percepciones);
            this.Panel_Background.Controls.Add(this.Lbl_Porcentaje);
            this.Panel_Background.Controls.Add(this.TB_Porcentaje);
            this.Panel_Background.Controls.Add(this.TB_Bono);
            this.Panel_Background.Controls.Add(this.Lbl_Bono);
            this.Panel_Background.Controls.Add(this.TB_Nombre);
            this.Panel_Background.Controls.Add(this.LBL_Nombre);
            this.Panel_Background.Controls.Add(this.Btn_AgregarPercepcion);
            this.Panel_Background.Controls.Add(this.LBL_Title);
            this.Panel_Background.Location = new System.Drawing.Point(12, 12);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(647, 364);
            this.Panel_Background.TabIndex = 26;
            // 
            // btn_CargarExcel
            // 
            this.btn_CargarExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.btn_CargarExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.btn_CargarExcel.FlatAppearance.BorderSize = 2;
            this.btn_CargarExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_CargarExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.btn_CargarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CargarExcel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CargarExcel.ForeColor = System.Drawing.Color.White;
            this.btn_CargarExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btn_CargarExcel.IconColor = System.Drawing.Color.White;
            this.btn_CargarExcel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_CargarExcel.IconSize = 45;
            this.btn_CargarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CargarExcel.Location = new System.Drawing.Point(0, 313);
            this.btn_CargarExcel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btn_CargarExcel.Name = "btn_CargarExcel";
            this.btn_CargarExcel.Size = new System.Drawing.Size(158, 51);
            this.btn_CargarExcel.TabIndex = 62;
            this.btn_CargarExcel.Text = "Cargar Excel";
            this.btn_CargarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CargarExcel.UseVisualStyleBackColor = false;
            this.btn_CargarExcel.Click += new System.EventHandler(this.btn_CargarExcel_Click);
            // 
            // Btn_EliminarPercepcion
            // 
            this.Btn_EliminarPercepcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Btn_EliminarPercepcion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Btn_EliminarPercepcion.FlatAppearance.BorderSize = 2;
            this.Btn_EliminarPercepcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Btn_EliminarPercepcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Btn_EliminarPercepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EliminarPercepcion.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EliminarPercepcion.ForeColor = System.Drawing.Color.White;
            this.Btn_EliminarPercepcion.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.Btn_EliminarPercepcion.IconColor = System.Drawing.Color.White;
            this.Btn_EliminarPercepcion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_EliminarPercepcion.IconSize = 45;
            this.Btn_EliminarPercepcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_EliminarPercepcion.Location = new System.Drawing.Point(509, 316);
            this.Btn_EliminarPercepcion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_EliminarPercepcion.Name = "Btn_EliminarPercepcion";
            this.Btn_EliminarPercepcion.Size = new System.Drawing.Size(138, 51);
            this.Btn_EliminarPercepcion.TabIndex = 61;
            this.Btn_EliminarPercepcion.Text = "Eliminar Percepción";
            this.Btn_EliminarPercepcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EliminarPercepcion.UseVisualStyleBackColor = false;
            this.Btn_EliminarPercepcion.Click += new System.EventHandler(this.Btn_EliminarPercepcion_Click);
            // 
            // Dgv_Percepciones
            // 
            this.Dgv_Percepciones.AllowUserToResizeColumns = false;
            this.Dgv_Percepciones.AllowUserToResizeRows = false;
            this.Dgv_Percepciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_Percepciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Dgv_Percepciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Percepciones.Location = new System.Drawing.Point(17, 145);
            this.Dgv_Percepciones.MultiSelect = false;
            this.Dgv_Percepciones.Name = "Dgv_Percepciones";
            this.Dgv_Percepciones.ReadOnly = true;
            this.Dgv_Percepciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_Percepciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Percepciones.Size = new System.Drawing.Size(615, 150);
            this.Dgv_Percepciones.TabIndex = 42;
            this.Dgv_Percepciones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Percepciones_CellClick);
            // 
            // Lbl_Porcentaje
            // 
            this.Lbl_Porcentaje.AutoSize = true;
            this.Lbl_Porcentaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Porcentaje.ForeColor = System.Drawing.Color.White;
            this.Lbl_Porcentaje.Location = new System.Drawing.Point(526, 75);
            this.Lbl_Porcentaje.Name = "Lbl_Porcentaje";
            this.Lbl_Porcentaje.Size = new System.Drawing.Size(85, 16);
            this.Lbl_Porcentaje.TabIndex = 38;
            this.Lbl_Porcentaje.Text = "Porcentaje*";
            // 
            // TB_Porcentaje
            // 
            this.TB_Porcentaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Porcentaje.Location = new System.Drawing.Point(496, 91);
            this.TB_Porcentaje.MaxLength = 5;
            this.TB_Porcentaje.Name = "TB_Porcentaje";
            this.TB_Porcentaje.Size = new System.Drawing.Size(136, 23);
            this.TB_Porcentaje.TabIndex = 37;
            // 
            // TB_Bono
            // 
            this.TB_Bono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Bono.Location = new System.Drawing.Point(269, 91);
            this.TB_Bono.MaxLength = 8;
            this.TB_Bono.Name = "TB_Bono";
            this.TB_Bono.Size = new System.Drawing.Size(136, 23);
            this.TB_Bono.TabIndex = 36;
            // 
            // Lbl_Bono
            // 
            this.Lbl_Bono.AutoSize = true;
            this.Lbl_Bono.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bono.ForeColor = System.Drawing.Color.White;
            this.Lbl_Bono.Location = new System.Drawing.Point(315, 75);
            this.Lbl_Bono.Name = "Lbl_Bono";
            this.Lbl_Bono.Size = new System.Drawing.Size(47, 16);
            this.Lbl_Bono.TabIndex = 35;
            this.Lbl_Bono.Text = "Bono*";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Nombre.Location = new System.Drawing.Point(17, 91);
            this.TB_Nombre.MaxLength = 25;
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(141, 23);
            this.TB_Nombre.TabIndex = 34;
            this.TB_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Nombre_KeyPress);
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Nombre.ForeColor = System.Drawing.Color.White;
            this.LBL_Nombre.Location = new System.Drawing.Point(48, 72);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(67, 16);
            this.LBL_Nombre.TabIndex = 33;
            this.LBL_Nombre.Text = "Nombre*";
            // 
            // Btn_AgregarPercepcion
            // 
            this.Btn_AgregarPercepcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Btn_AgregarPercepcion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Btn_AgregarPercepcion.FlatAppearance.BorderSize = 2;
            this.Btn_AgregarPercepcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Btn_AgregarPercepcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Btn_AgregarPercepcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AgregarPercepcion.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AgregarPercepcion.ForeColor = System.Drawing.Color.White;
            this.Btn_AgregarPercepcion.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.Btn_AgregarPercepcion.IconColor = System.Drawing.Color.White;
            this.Btn_AgregarPercepcion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_AgregarPercepcion.IconSize = 45;
            this.Btn_AgregarPercepcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AgregarPercepcion.Location = new System.Drawing.Point(269, 313);
            this.Btn_AgregarPercepcion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_AgregarPercepcion.Name = "Btn_AgregarPercepcion";
            this.Btn_AgregarPercepcion.Size = new System.Drawing.Size(136, 51);
            this.Btn_AgregarPercepcion.TabIndex = 23;
            this.Btn_AgregarPercepcion.Text = "Agregar Percepción";
            this.Btn_AgregarPercepcion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_AgregarPercepcion.UseVisualStyleBackColor = false;
            this.Btn_AgregarPercepcion.Click += new System.EventHandler(this.Btn_AgregarPercepcion_Click);
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.Color.White;
            this.LBL_Title.Location = new System.Drawing.Point(3, 0);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(145, 23);
            this.LBL_Title.TabIndex = 20;
            this.LBL_Title.Text = "Percepciones";
            // 
            // CHB_Porcentaje
            // 
            this.CHB_Porcentaje.AutoSize = true;
            this.CHB_Porcentaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.CHB_Porcentaje.ForeColor = System.Drawing.Color.White;
            this.CHB_Porcentaje.Location = new System.Drawing.Point(17, 35);
            this.CHB_Porcentaje.Name = "CHB_Porcentaje";
            this.CHB_Porcentaje.Size = new System.Drawing.Size(98, 20);
            this.CHB_Porcentaje.TabIndex = 65;
            this.CHB_Porcentaje.Text = "Porcentaje";
            this.CHB_Porcentaje.UseVisualStyleBackColor = true;
            this.CHB_Porcentaje.CheckedChanged += new System.EventHandler(this.CHB_Porcentaje_CheckedChanged);
            // 
            // lbl_signo
            // 
            this.lbl_signo.AutoSize = true;
            this.lbl_signo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signo.ForeColor = System.Drawing.Color.White;
            this.lbl_signo.Location = new System.Drawing.Point(244, 98);
            this.lbl_signo.Name = "lbl_signo";
            this.lbl_signo.Size = new System.Drawing.Size(19, 16);
            this.lbl_signo.TabIndex = 67;
            this.lbl_signo.Text = "%";
            // 
            // Percepciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 388);
            this.Controls.Add(this.Panel_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Percepciones";
            this.Text = "Percepciones";
            this.Load += new System.EventHandler(this.Percepciones_Load);
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Percepciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private FontAwesome.Sharp.IconButton Btn_AgregarPercepcion;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label Lbl_Porcentaje;
        private System.Windows.Forms.TextBox TB_Porcentaje;
        private System.Windows.Forms.TextBox TB_Bono;
        private System.Windows.Forms.Label Lbl_Bono;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.DataGridView Dgv_Percepciones;
        private FontAwesome.Sharp.IconButton Btn_EliminarPercepcion;
        private FontAwesome.Sharp.IconButton btn_CargarExcel;
        private System.Windows.Forms.CheckBox CHB_Porcentaje;
        private System.Windows.Forms.Label lbl_signo;
    }
}