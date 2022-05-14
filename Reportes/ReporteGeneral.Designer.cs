
namespace Proyecto_MAD.Reportes
{
    partial class ReporteGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteGeneral));
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.Btn_Reinicio = new FontAwesome.Sharp.IconButton();
            this.CB_Year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Filtrar = new FontAwesome.Sharp.IconButton();
            this.DGV_ReporteGeneralNoimina = new System.Windows.Forms.DataGridView();
            this.CB_Mes = new System.Windows.Forms.ComboBox();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Mes = new System.Windows.Forms.Label();
            this.Panel_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ReporteGeneralNoimina)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Panel_Background.Controls.Add(this.Btn_Reinicio);
            this.Panel_Background.Controls.Add(this.CB_Year);
            this.Panel_Background.Controls.Add(this.label1);
            this.Panel_Background.Controls.Add(this.Btn_Filtrar);
            this.Panel_Background.Controls.Add(this.DGV_ReporteGeneralNoimina);
            this.Panel_Background.Controls.Add(this.CB_Mes);
            this.Panel_Background.Controls.Add(this.LBL_Title);
            this.Panel_Background.Controls.Add(this.LBL_Mes);
            this.Panel_Background.Location = new System.Drawing.Point(31, 27);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(671, 567);
            this.Panel_Background.TabIndex = 23;
            // 
            // Btn_Reinicio
            // 
            this.Btn_Reinicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Btn_Reinicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Btn_Reinicio.FlatAppearance.BorderSize = 2;
            this.Btn_Reinicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Btn_Reinicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Btn_Reinicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reinicio.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reinicio.ForeColor = System.Drawing.Color.White;
            this.Btn_Reinicio.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.Btn_Reinicio.IconColor = System.Drawing.Color.White;
            this.Btn_Reinicio.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Reinicio.IconSize = 19;
            this.Btn_Reinicio.Location = new System.Drawing.Point(545, 85);
            this.Btn_Reinicio.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_Reinicio.Name = "Btn_Reinicio";
            this.Btn_Reinicio.Size = new System.Drawing.Size(28, 23);
            this.Btn_Reinicio.TabIndex = 27;
            this.Btn_Reinicio.UseVisualStyleBackColor = false;
            this.Btn_Reinicio.Click += new System.EventHandler(this.Btn_Reinicio_Click);
            // 
            // CB_Year
            // 
            this.CB_Year.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.CB_Year.FormattingEnabled = true;
            this.CB_Year.Items.AddRange(new object[] {
            "Todos",
            "2022",
            "2021",
            "2020"});
            this.CB_Year.Location = new System.Drawing.Point(149, 85);
            this.CB_Year.Name = "CB_Year";
            this.CB_Year.Size = new System.Drawing.Size(156, 23);
            this.CB_Year.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 61);
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
            this.Btn_Filtrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.Btn_Filtrar.IconColor = System.Drawing.Color.White;
            this.Btn_Filtrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Filtrar.IconSize = 45;
            this.Btn_Filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Filtrar.Location = new System.Drawing.Point(210, 498);
            this.Btn_Filtrar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_Filtrar.Name = "Btn_Filtrar";
            this.Btn_Filtrar.Size = new System.Drawing.Size(266, 51);
            this.Btn_Filtrar.TabIndex = 23;
            this.Btn_Filtrar.Text = "Filtrar";
            this.Btn_Filtrar.UseVisualStyleBackColor = false;
            this.Btn_Filtrar.Click += new System.EventHandler(this.Btn_Filtrar_Click);
            // 
            // DGV_ReporteGeneralNoimina
            // 
            this.DGV_ReporteGeneralNoimina.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.DGV_ReporteGeneralNoimina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ReporteGeneralNoimina.Location = new System.Drawing.Point(31, 168);
            this.DGV_ReporteGeneralNoimina.Name = "DGV_ReporteGeneralNoimina";
            this.DGV_ReporteGeneralNoimina.Size = new System.Drawing.Size(607, 324);
            this.DGV_ReporteGeneralNoimina.TabIndex = 22;
            // 
            // CB_Mes
            // 
            this.CB_Mes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.CB_Mes.FormattingEnabled = true;
            this.CB_Mes.Items.AddRange(new object[] {
            "Todos",
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
            this.CB_Mes.Location = new System.Drawing.Point(373, 85);
            this.CB_Mes.Name = "CB_Mes";
            this.CB_Mes.Size = new System.Drawing.Size(156, 23);
            this.CB_Mes.TabIndex = 21;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.Color.White;
            this.LBL_Title.Location = new System.Drawing.Point(14, 16);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(281, 23);
            this.LBL_Title.TabIndex = 20;
            this.LBL_Title.Text = "Reporte General de Nómina";
            // 
            // LBL_Mes
            // 
            this.LBL_Mes.AutoSize = true;
            this.LBL_Mes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Mes.ForeColor = System.Drawing.Color.White;
            this.LBL_Mes.Location = new System.Drawing.Point(430, 61);
            this.LBL_Mes.Name = "LBL_Mes";
            this.LBL_Mes.Size = new System.Drawing.Size(46, 21);
            this.LBL_Mes.TabIndex = 8;
            this.LBL_Mes.Text = "Mes";
            // 
            // ReporteGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 621);
            this.Controls.Add(this.Panel_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteGeneral";
            this.Text = "ReporteGeneral";
            this.Load += new System.EventHandler(this.ReporteGeneral_Load);
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ReporteGeneralNoimina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private FontAwesome.Sharp.IconButton Btn_Filtrar;
        private System.Windows.Forms.DataGridView DGV_ReporteGeneralNoimina;
        private System.Windows.Forms.ComboBox CB_Mes;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Mes;
        private System.Windows.Forms.ComboBox CB_Year;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Btn_Reinicio;
    }
}