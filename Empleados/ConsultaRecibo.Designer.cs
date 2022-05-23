
namespace Proyecto_MAD.Empleados
{
    partial class ConsultaRecibo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaRecibo));
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.CB_Año = new System.Windows.Forms.ComboBox();
            this.lbl_Año = new System.Windows.Forms.Label();
            this.LBL_Informacion = new System.Windows.Forms.Label();
            this.Inicio_Btn = new FontAwesome.Sharp.IconButton();
            this.DGV_Recibos = new System.Windows.Forms.DataGridView();
            this.CB_Mes = new System.Windows.Forms.ComboBox();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Mes = new System.Windows.Forms.Label();
            this.Panel_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Recibos)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Panel_Background.Controls.Add(this.CB_Año);
            this.Panel_Background.Controls.Add(this.lbl_Año);
            this.Panel_Background.Controls.Add(this.LBL_Informacion);
            this.Panel_Background.Controls.Add(this.Inicio_Btn);
            this.Panel_Background.Controls.Add(this.DGV_Recibos);
            this.Panel_Background.Controls.Add(this.CB_Mes);
            this.Panel_Background.Controls.Add(this.LBL_Title);
            this.Panel_Background.Controls.Add(this.LBL_Mes);
            this.Panel_Background.Location = new System.Drawing.Point(31, 28);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(671, 567);
            this.Panel_Background.TabIndex = 22;
            // 
            // CB_Año
            // 
            this.CB_Año.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.CB_Año.FormattingEnabled = true;
            this.CB_Año.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020"});
            this.CB_Año.Location = new System.Drawing.Point(338, 83);
            this.CB_Año.Name = "CB_Año";
            this.CB_Año.Size = new System.Drawing.Size(156, 23);
            this.CB_Año.TabIndex = 26;
            // 
            // lbl_Año
            // 
            this.lbl_Año.AutoSize = true;
            this.lbl_Año.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Año.ForeColor = System.Drawing.Color.White;
            this.lbl_Año.Location = new System.Drawing.Point(398, 59);
            this.lbl_Año.Name = "lbl_Año";
            this.lbl_Año.Size = new System.Drawing.Size(45, 21);
            this.lbl_Año.TabIndex = 25;
            this.lbl_Año.Text = "Año";
            this.lbl_Año.Click += new System.EventHandler(this.lbl_Año_Click);
            // 
            // LBL_Informacion
            // 
            this.LBL_Informacion.AutoSize = true;
            this.LBL_Informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Informacion.ForeColor = System.Drawing.Color.Red;
            this.LBL_Informacion.Location = new System.Drawing.Point(23, 157);
            this.LBL_Informacion.Name = "LBL_Informacion";
            this.LBL_Informacion.Size = new System.Drawing.Size(177, 16);
            this.LBL_Informacion.TabIndex = 24;
            this.LBL_Informacion.Text = "*No hay recibos disponibles";
            this.LBL_Informacion.Visible = false;
            // 
            // Inicio_Btn
            // 
            this.Inicio_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Inicio_Btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Inicio_Btn.FlatAppearance.BorderSize = 2;
            this.Inicio_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Inicio_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Inicio_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inicio_Btn.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inicio_Btn.ForeColor = System.Drawing.Color.White;
            this.Inicio_Btn.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.Inicio_Btn.IconColor = System.Drawing.Color.White;
            this.Inicio_Btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Inicio_Btn.IconSize = 45;
            this.Inicio_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Inicio_Btn.Location = new System.Drawing.Point(541, 509);
            this.Inicio_Btn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Inicio_Btn.Name = "Inicio_Btn";
            this.Inicio_Btn.Size = new System.Drawing.Size(108, 51);
            this.Inicio_Btn.TabIndex = 23;
            this.Inicio_Btn.Text = "PDF";
            this.Inicio_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Inicio_Btn.UseVisualStyleBackColor = false;
            this.Inicio_Btn.Click += new System.EventHandler(this.Inicio_Btn_Click);
            // 
            // DGV_Recibos
            // 
            this.DGV_Recibos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.DGV_Recibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Recibos.Location = new System.Drawing.Point(26, 176);
            this.DGV_Recibos.Name = "DGV_Recibos";
            this.DGV_Recibos.Size = new System.Drawing.Size(623, 324);
            this.DGV_Recibos.TabIndex = 22;
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
            this.CB_Mes.Location = new System.Drawing.Point(165, 83);
            this.CB_Mes.Name = "CB_Mes";
            this.CB_Mes.Size = new System.Drawing.Size(156, 23);
            this.CB_Mes.TabIndex = 21;
            this.CB_Mes.SelectedIndexChanged += new System.EventHandler(this.CB_Mes_SelectedIndexChanged);
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.Color.White;
            this.LBL_Title.Location = new System.Drawing.Point(13, 16);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(187, 23);
            this.LBL_Title.TabIndex = 20;
            this.LBL_Title.Text = "Recibo de Nómina";
            // 
            // LBL_Mes
            // 
            this.LBL_Mes.AutoSize = true;
            this.LBL_Mes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Mes.ForeColor = System.Drawing.Color.White;
            this.LBL_Mes.Location = new System.Drawing.Point(222, 59);
            this.LBL_Mes.Name = "LBL_Mes";
            this.LBL_Mes.Size = new System.Drawing.Size(46, 21);
            this.LBL_Mes.TabIndex = 8;
            this.LBL_Mes.Text = "Mes";
            this.LBL_Mes.Click += new System.EventHandler(this.LBL_Mes_Click);
            // 
            // ConsultaRecibo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 621);
            this.Controls.Add(this.Panel_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaRecibo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Recibos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Mes;
        private System.Windows.Forms.DataGridView DGV_Recibos;
        private System.Windows.Forms.ComboBox CB_Mes;
        private System.Windows.Forms.Label LBL_Informacion;
        private FontAwesome.Sharp.IconButton Inicio_Btn;
        private System.Windows.Forms.ComboBox CB_Año;
        private System.Windows.Forms.Label lbl_Año;
    }
}