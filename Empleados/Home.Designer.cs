
namespace Proyecto_MAD.Empleados
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.LBL_Informacion = new System.Windows.Forms.Label();
            this.DGV_Recibos = new System.Windows.Forms.DataGridView();
            this.CB_Mes = new System.Windows.Forms.ComboBox();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Mes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Recibos)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Panel_Background.Controls.Add(this.label1);
            this.Panel_Background.Controls.Add(this.LBL_Informacion);
            this.Panel_Background.Controls.Add(this.DGV_Recibos);
            this.Panel_Background.Controls.Add(this.CB_Mes);
            this.Panel_Background.Controls.Add(this.LBL_Title);
            this.Panel_Background.Controls.Add(this.LBL_Mes);
            this.Panel_Background.Location = new System.Drawing.Point(31, 27);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(671, 567);
            this.Panel_Background.TabIndex = 23;
            // 
            // LBL_Informacion
            // 
            this.LBL_Informacion.AutoSize = true;
            this.LBL_Informacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Informacion.ForeColor = System.Drawing.Color.Red;
            this.LBL_Informacion.Location = new System.Drawing.Point(23, 157);
            this.LBL_Informacion.Name = "LBL_Informacion";
            this.LBL_Informacion.Size = new System.Drawing.Size(184, 16);
            this.LBL_Informacion.TabIndex = 24;
            this.LBL_Informacion.Text = "*No hay ingresos disponibles";
            this.LBL_Informacion.Visible = false;
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
            this.CB_Mes.Location = new System.Drawing.Point(267, 103);
            this.CB_Mes.Name = "CB_Mes";
            this.CB_Mes.Size = new System.Drawing.Size(156, 23);
            this.CB_Mes.TabIndex = 21;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.Color.White;
            this.LBL_Title.Location = new System.Drawing.Point(24, 40);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(221, 23);
            this.LBL_Title.TabIndex = 20;
            this.LBL_Title.Text = "Resumen de ingresos";
            this.LBL_Title.Click += new System.EventHandler(this.LBL_Title_Click);
            // 
            // LBL_Mes
            // 
            this.LBL_Mes.AutoSize = true;
            this.LBL_Mes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Mes.ForeColor = System.Drawing.Color.White;
            this.LBL_Mes.Location = new System.Drawing.Point(324, 79);
            this.LBL_Mes.Name = "LBL_Mes";
            this.LBL_Mes.Size = new System.Drawing.Size(46, 21);
            this.LBL_Mes.TabIndex = 8;
            this.LBL_Mes.Text = "Mes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 32);
            this.label1.TabIndex = 25;
            this.label1.Text = "INICIO";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 621);
            this.Controls.Add(this.Panel_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Recibos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.Label LBL_Informacion;
        private System.Windows.Forms.DataGridView DGV_Recibos;
        private System.Windows.Forms.ComboBox CB_Mes;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Mes;
        private System.Windows.Forms.Label label1;
    }
}