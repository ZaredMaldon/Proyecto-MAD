
namespace Proyecto_MAD.Recibo
{
    partial class GenerarRecibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerarRecibo));
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.Dgv_EmpDep = new System.Windows.Forms.DataGridView();
            this.CB_Modo = new System.Windows.Forms.ComboBox();
            this.Lbl_Modo = new System.Windows.Forms.Label();
            this.Cb_Percepciones = new System.Windows.Forms.ComboBox();
            this.Lbl_Percepciones = new System.Windows.Forms.Label();
            this.Cb_Deducciones = new System.Windows.Forms.ComboBox();
            this.Lbl_Deducciones = new System.Windows.Forms.Label();
            this.Btn_CSV = new FontAwesome.Sharp.IconButton();
            this.LB_Deducciones = new System.Windows.Forms.ListBox();
            this.LB_Percepciones = new System.Windows.Forms.ListBox();
            this.CB_Year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Filtrar = new FontAwesome.Sharp.IconButton();
            this.CB_Mes = new System.Windows.Forms.ComboBox();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Mes = new System.Windows.Forms.Label();
            this.Panel_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_EmpDep)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Panel_Background.Controls.Add(this.Dgv_EmpDep);
            this.Panel_Background.Controls.Add(this.CB_Modo);
            this.Panel_Background.Controls.Add(this.Lbl_Modo);
            this.Panel_Background.Controls.Add(this.Cb_Percepciones);
            this.Panel_Background.Controls.Add(this.Lbl_Percepciones);
            this.Panel_Background.Controls.Add(this.Cb_Deducciones);
            this.Panel_Background.Controls.Add(this.Lbl_Deducciones);
            this.Panel_Background.Controls.Add(this.Btn_CSV);
            this.Panel_Background.Controls.Add(this.LB_Deducciones);
            this.Panel_Background.Controls.Add(this.LB_Percepciones);
            this.Panel_Background.Controls.Add(this.CB_Year);
            this.Panel_Background.Controls.Add(this.label1);
            this.Panel_Background.Controls.Add(this.Btn_Filtrar);
            this.Panel_Background.Controls.Add(this.CB_Mes);
            this.Panel_Background.Controls.Add(this.LBL_Title);
            this.Panel_Background.Controls.Add(this.LBL_Mes);
            this.Panel_Background.Location = new System.Drawing.Point(32, 29);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(671, 567);
            this.Panel_Background.TabIndex = 24;
            // 
            // Dgv_EmpDep
            // 
            this.Dgv_EmpDep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Dgv_EmpDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_EmpDep.Location = new System.Drawing.Point(26, 357);
            this.Dgv_EmpDep.MultiSelect = false;
            this.Dgv_EmpDep.Name = "Dgv_EmpDep";
            this.Dgv_EmpDep.ReadOnly = true;
            this.Dgv_EmpDep.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_EmpDep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_EmpDep.Size = new System.Drawing.Size(623, 134);
            this.Dgv_EmpDep.TabIndex = 8;
            // 
            // CB_Modo
            // 
            this.CB_Modo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.CB_Modo.FormattingEnabled = true;
            this.CB_Modo.Items.AddRange(new object[] {
            "Departamento",
            "Empleado"});
            this.CB_Modo.Location = new System.Drawing.Point(220, 78);
            this.CB_Modo.Name = "CB_Modo";
            this.CB_Modo.Size = new System.Drawing.Size(209, 23);
            this.CB_Modo.TabIndex = 1;
            // 
            // Lbl_Modo
            // 
            this.Lbl_Modo.AutoSize = true;
            this.Lbl_Modo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Modo.ForeColor = System.Drawing.Color.White;
            this.Lbl_Modo.Location = new System.Drawing.Point(216, 54);
            this.Lbl_Modo.Name = "Lbl_Modo";
            this.Lbl_Modo.Size = new System.Drawing.Size(195, 21);
            this.Lbl_Modo.TabIndex = 38;
            this.Lbl_Modo.Text = "Generar nómina por:";
            // 
            // Cb_Percepciones
            // 
            this.Cb_Percepciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Cb_Percepciones.FormattingEnabled = true;
            this.Cb_Percepciones.Location = new System.Drawing.Point(90, 210);
            this.Cb_Percepciones.Name = "Cb_Percepciones";
            this.Cb_Percepciones.Size = new System.Drawing.Size(156, 23);
            this.Cb_Percepciones.TabIndex = 4;
            // 
            // Lbl_Percepciones
            // 
            this.Lbl_Percepciones.AutoSize = true;
            this.Lbl_Percepciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Percepciones.ForeColor = System.Drawing.Color.White;
            this.Lbl_Percepciones.Location = new System.Drawing.Point(102, 186);
            this.Lbl_Percepciones.Name = "Lbl_Percepciones";
            this.Lbl_Percepciones.Size = new System.Drawing.Size(133, 21);
            this.Lbl_Percepciones.TabIndex = 36;
            this.Lbl_Percepciones.Text = "Percepciones";
            // 
            // Cb_Deducciones
            // 
            this.Cb_Deducciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Cb_Deducciones.FormattingEnabled = true;
            this.Cb_Deducciones.Location = new System.Drawing.Point(402, 210);
            this.Cb_Deducciones.Name = "Cb_Deducciones";
            this.Cb_Deducciones.Size = new System.Drawing.Size(156, 23);
            this.Cb_Deducciones.TabIndex = 5;
            // 
            // Lbl_Deducciones
            // 
            this.Lbl_Deducciones.AutoSize = true;
            this.Lbl_Deducciones.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Deducciones.ForeColor = System.Drawing.Color.White;
            this.Lbl_Deducciones.Location = new System.Drawing.Point(411, 186);
            this.Lbl_Deducciones.Name = "Lbl_Deducciones";
            this.Lbl_Deducciones.Size = new System.Drawing.Size(126, 21);
            this.Lbl_Deducciones.TabIndex = 34;
            this.Lbl_Deducciones.Text = "Deducciones";
            // 
            // Btn_CSV
            // 
            this.Btn_CSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Btn_CSV.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Btn_CSV.FlatAppearance.BorderSize = 2;
            this.Btn_CSV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Btn_CSV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Btn_CSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CSV.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CSV.ForeColor = System.Drawing.Color.White;
            this.Btn_CSV.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            this.Btn_CSV.IconColor = System.Drawing.Color.White;
            this.Btn_CSV.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_CSV.IconSize = 45;
            this.Btn_CSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_CSV.Location = new System.Drawing.Point(423, 509);
            this.Btn_CSV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_CSV.Name = "Btn_CSV";
            this.Btn_CSV.Size = new System.Drawing.Size(104, 51);
            this.Btn_CSV.TabIndex = 9;
            this.Btn_CSV.Text = "CSV";
            this.Btn_CSV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_CSV.UseVisualStyleBackColor = false;
            this.Btn_CSV.Click += new System.EventHandler(this.Btn_CSV_Click);
            // 
            // LB_Deducciones
            // 
            this.LB_Deducciones.FormattingEnabled = true;
            this.LB_Deducciones.Location = new System.Drawing.Point(26, 256);
            this.LB_Deducciones.Name = "LB_Deducciones";
            this.LB_Deducciones.Size = new System.Drawing.Size(303, 95);
            this.LB_Deducciones.TabIndex = 6;
            // 
            // LB_Percepciones
            // 
            this.LB_Percepciones.FormattingEnabled = true;
            this.LB_Percepciones.Location = new System.Drawing.Point(346, 256);
            this.LB_Percepciones.Name = "LB_Percepciones";
            this.LB_Percepciones.Size = new System.Drawing.Size(303, 95);
            this.LB_Percepciones.TabIndex = 7;
            // 
            // CB_Year
            // 
            this.CB_Year.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.CB_Year.FormattingEnabled = true;
            this.CB_Year.Items.AddRange(new object[] {
            ""});
            this.CB_Year.Location = new System.Drawing.Point(221, 135);
            this.CB_Year.Name = "CB_Year";
            this.CB_Year.Size = new System.Drawing.Size(94, 23);
            this.CB_Year.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Año";
            // 
            // Btn_Filtrar
            // 
            this.Btn_Filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Btn_Filtrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Btn_Filtrar.FlatAppearance.BorderSize = 2;
            this.Btn_Filtrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Btn_Filtrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Btn_Filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Filtrar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Filtrar.ForeColor = System.Drawing.Color.White;
            this.Btn_Filtrar.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.Btn_Filtrar.IconColor = System.Drawing.Color.White;
            this.Btn_Filtrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Filtrar.IconSize = 45;
            this.Btn_Filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Filtrar.Location = new System.Drawing.Point(533, 509);
            this.Btn_Filtrar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_Filtrar.Name = "Btn_Filtrar";
            this.Btn_Filtrar.Size = new System.Drawing.Size(116, 51);
            this.Btn_Filtrar.TabIndex = 10;
            this.Btn_Filtrar.Text = "Calculo";
            this.Btn_Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Filtrar.UseVisualStyleBackColor = false;
            // 
            // CB_Mes
            // 
            this.CB_Mes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.CB_Mes.FormattingEnabled = true;
            this.CB_Mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.CB_Mes.Location = new System.Drawing.Point(336, 135);
            this.CB_Mes.Name = "CB_Mes";
            this.CB_Mes.Size = new System.Drawing.Size(94, 23);
            this.CB_Mes.TabIndex = 3;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.Color.White;
            this.LBL_Title.Location = new System.Drawing.Point(13, 17);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(84, 23);
            this.LBL_Title.TabIndex = 20;
            this.LBL_Title.Text = "Nómina";
            // 
            // LBL_Mes
            // 
            this.LBL_Mes.AutoSize = true;
            this.LBL_Mes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Mes.ForeColor = System.Drawing.Color.White;
            this.LBL_Mes.Location = new System.Drawing.Point(358, 111);
            this.LBL_Mes.Name = "LBL_Mes";
            this.LBL_Mes.Size = new System.Drawing.Size(46, 21);
            this.LBL_Mes.TabIndex = 8;
            this.LBL_Mes.Text = "Mes";
            // 
            // GenerarRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 625);
            this.Controls.Add(this.Panel_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GenerarRecibo";
            this.Text = "GenerarRecibo";
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_EmpDep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.ComboBox CB_Year;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Btn_Filtrar;
        private System.Windows.Forms.ComboBox CB_Mes;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Mes;
        private System.Windows.Forms.ComboBox Cb_Percepciones;
        private System.Windows.Forms.Label Lbl_Percepciones;
        private System.Windows.Forms.ComboBox Cb_Deducciones;
        private System.Windows.Forms.Label Lbl_Deducciones;
        private FontAwesome.Sharp.IconButton Btn_CSV;
        private System.Windows.Forms.ListBox LB_Deducciones;
        private System.Windows.Forms.ListBox LB_Percepciones;
        private System.Windows.Forms.ComboBox CB_Modo;
        private System.Windows.Forms.Label Lbl_Modo;
        private System.Windows.Forms.DataGridView Dgv_EmpDep;
    }
}