
namespace Proyecto_MAD.Reportes
{
    partial class ReporteNómina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteNómina));
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.CB_Year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Filtrar = new FontAwesome.Sharp.IconButton();
            this.DGV_ReporteNomina = new System.Windows.Forms.DataGridView();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.Btn_Reinicio = new FontAwesome.Sharp.IconButton();
            this.Panel_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ReporteNomina)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Panel_Background.Controls.Add(this.Btn_Reinicio);
            this.Panel_Background.Controls.Add(this.CB_Year);
            this.Panel_Background.Controls.Add(this.label1);
            this.Panel_Background.Controls.Add(this.Btn_Filtrar);
            this.Panel_Background.Controls.Add(this.DGV_ReporteNomina);
            this.Panel_Background.Controls.Add(this.LBL_Title);
            this.Panel_Background.Location = new System.Drawing.Point(31, 27);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(671, 567);
            this.Panel_Background.TabIndex = 24;
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
            this.CB_Year.Location = new System.Drawing.Point(260, 90);
            this.CB_Year.Name = "CB_Year";
            this.CB_Year.Size = new System.Drawing.Size(156, 23);
            this.CB_Year.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(317, 66);
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
            this.Btn_Filtrar.Location = new System.Drawing.Point(541, 509);
            this.Btn_Filtrar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_Filtrar.Name = "Btn_Filtrar";
            this.Btn_Filtrar.Size = new System.Drawing.Size(108, 51);
            this.Btn_Filtrar.TabIndex = 23;
            this.Btn_Filtrar.Text = "Filtrar";
            this.Btn_Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Filtrar.UseVisualStyleBackColor = false;
            this.Btn_Filtrar.Click += new System.EventHandler(this.Btn_Filtrar_Click);
            // 
            // DGV_ReporteNomina
            // 
            this.DGV_ReporteNomina.AllowUserToAddRows = false;
            this.DGV_ReporteNomina.AllowUserToDeleteRows = false;
            this.DGV_ReporteNomina.AllowUserToResizeColumns = false;
            this.DGV_ReporteNomina.AllowUserToResizeRows = false;
            this.DGV_ReporteNomina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ReporteNomina.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.DGV_ReporteNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ReporteNomina.Location = new System.Drawing.Point(26, 176);
            this.DGV_ReporteNomina.Name = "DGV_ReporteNomina";
            this.DGV_ReporteNomina.Size = new System.Drawing.Size(623, 324);
            this.DGV_ReporteNomina.TabIndex = 22;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.Color.White;
            this.LBL_Title.Location = new System.Drawing.Point(13, 16);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(168, 23);
            this.LBL_Title.TabIndex = 20;
            this.LBL_Title.Text = "Reporte Nómina";
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
            this.Btn_Reinicio.Location = new System.Drawing.Point(422, 90);
            this.Btn_Reinicio.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_Reinicio.Name = "Btn_Reinicio";
            this.Btn_Reinicio.Size = new System.Drawing.Size(28, 23);
            this.Btn_Reinicio.TabIndex = 32;
            this.Btn_Reinicio.UseVisualStyleBackColor = false;
            this.Btn_Reinicio.Click += new System.EventHandler(this.Btn_Reinicio_Click);
            // 
            // ReporteNómina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 621);
            this.Controls.Add(this.Panel_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReporteNómina";
            this.Text = "ReporteNómina";
            this.Load += new System.EventHandler(this.ReporteNómina_Load);
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ReporteNomina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.ComboBox CB_Year;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Btn_Filtrar;
        private System.Windows.Forms.DataGridView DGV_ReporteNomina;
        private System.Windows.Forms.Label LBL_Title;
        private FontAwesome.Sharp.IconButton Btn_Reinicio;
    }
}