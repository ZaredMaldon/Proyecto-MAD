
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
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_Nominas = new System.Windows.Forms.DataGridView();
            this.Btn_CSV = new FontAwesome.Sharp.IconButton();
            this.CB_Year = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Calculo = new FontAwesome.Sharp.IconButton();
            this.CB_Mes = new System.Windows.Forms.ComboBox();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Mes = new System.Windows.Forms.Label();
            this.Panel_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Nominas)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Panel_Background.Controls.Add(this.label2);
            this.Panel_Background.Controls.Add(this.Dgv_Nominas);
            this.Panel_Background.Controls.Add(this.Btn_CSV);
            this.Panel_Background.Controls.Add(this.CB_Year);
            this.Panel_Background.Controls.Add(this.label1);
            this.Panel_Background.Controls.Add(this.Btn_Calculo);
            this.Panel_Background.Controls.Add(this.CB_Mes);
            this.Panel_Background.Controls.Add(this.LBL_Title);
            this.Panel_Background.Controls.Add(this.LBL_Mes);
            this.Panel_Background.Location = new System.Drawing.Point(32, 29);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(671, 567);
            this.Panel_Background.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Lista de Nóminas Generadas";
            // 
            // Dgv_Nominas
            // 
            this.Dgv_Nominas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Dgv_Nominas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Nominas.Location = new System.Drawing.Point(26, 231);
            this.Dgv_Nominas.MultiSelect = false;
            this.Dgv_Nominas.Name = "Dgv_Nominas";
            this.Dgv_Nominas.ReadOnly = true;
            this.Dgv_Nominas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_Nominas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Nominas.Size = new System.Drawing.Size(623, 260);
            this.Dgv_Nominas.TabIndex = 8;
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
            this.Btn_CSV.Location = new System.Drawing.Point(218, 497);
            this.Btn_CSV.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_CSV.Name = "Btn_CSV";
            this.Btn_CSV.Size = new System.Drawing.Size(260, 51);
            this.Btn_CSV.TabIndex = 9;
            this.Btn_CSV.Text = "CSV";
            this.Btn_CSV.UseVisualStyleBackColor = false;
            this.Btn_CSV.Click += new System.EventHandler(this.Btn_CSV_Click);
            // 
            // CB_Year
            // 
            this.CB_Year.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.CB_Year.FormattingEnabled = true;
            this.CB_Year.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020"});
            this.CB_Year.Location = new System.Drawing.Point(218, 76);
            this.CB_Year.Name = "CB_Year";
            this.CB_Year.Size = new System.Drawing.Size(118, 23);
            this.CB_Year.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Año";
            // 
            // Btn_Calculo
            // 
            this.Btn_Calculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Btn_Calculo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Btn_Calculo.FlatAppearance.BorderSize = 2;
            this.Btn_Calculo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Btn_Calculo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Btn_Calculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Calculo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Calculo.ForeColor = System.Drawing.Color.White;
            this.Btn_Calculo.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.Btn_Calculo.IconColor = System.Drawing.Color.White;
            this.Btn_Calculo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Calculo.IconSize = 45;
            this.Btn_Calculo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Calculo.Location = new System.Drawing.Point(218, 124);
            this.Btn_Calculo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_Calculo.Name = "Btn_Calculo";
            this.Btn_Calculo.Size = new System.Drawing.Size(260, 51);
            this.Btn_Calculo.TabIndex = 10;
            this.Btn_Calculo.Text = "Cálculo";
            this.Btn_Calculo.UseVisualStyleBackColor = false;
            this.Btn_Calculo.Click += new System.EventHandler(this.Btn_Calculo_Click);
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
            this.CB_Mes.Location = new System.Drawing.Point(360, 76);
            this.CB_Mes.Name = "CB_Mes";
            this.CB_Mes.Size = new System.Drawing.Size(118, 23);
            this.CB_Mes.TabIndex = 3;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.Color.White;
            this.LBL_Title.Location = new System.Drawing.Point(13, 17);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(192, 23);
            this.LBL_Title.TabIndex = 20;
            this.LBL_Title.Text = "Cálculo de Nómina";
            // 
            // LBL_Mes
            // 
            this.LBL_Mes.AutoSize = true;
            this.LBL_Mes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Mes.ForeColor = System.Drawing.Color.White;
            this.LBL_Mes.Location = new System.Drawing.Point(396, 52);
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
            this.Load += new System.EventHandler(this.GenerarRecibo_Load);
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Nominas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.ComboBox CB_Year;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Btn_Calculo;
        private System.Windows.Forms.ComboBox CB_Mes;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Mes;
        private FontAwesome.Sharp.IconButton Btn_CSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Dgv_Nominas;
    }
}