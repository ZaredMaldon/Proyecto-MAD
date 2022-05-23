
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
            this.Inicio_Btn = new FontAwesome.Sharp.IconButton();
            this.DGV_Recibos = new System.Windows.Forms.DataGridView();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.btn_Ver = new FontAwesome.Sharp.IconButton();
            this.Panel_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Recibos)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Panel_Background.Controls.Add(this.btn_Ver);
            this.Panel_Background.Controls.Add(this.Inicio_Btn);
            this.Panel_Background.Controls.Add(this.DGV_Recibos);
            this.Panel_Background.Controls.Add(this.LBL_Title);
            this.Panel_Background.Location = new System.Drawing.Point(31, 28);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(671, 567);
            this.Panel_Background.TabIndex = 22;
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
            this.Inicio_Btn.Location = new System.Drawing.Point(449, 516);
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
            this.DGV_Recibos.Location = new System.Drawing.Point(26, 62);
            this.DGV_Recibos.Name = "DGV_Recibos";
            this.DGV_Recibos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Recibos.Size = new System.Drawing.Size(623, 438);
            this.DGV_Recibos.TabIndex = 22;
            this.DGV_Recibos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Recibos_CellClick);
            this.DGV_Recibos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Recibos_CellContentClick);
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
            // btn_Ver
            // 
            this.btn_Ver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.btn_Ver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.btn_Ver.FlatAppearance.BorderSize = 2;
            this.btn_Ver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Ver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.btn_Ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ver.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ver.ForeColor = System.Drawing.Color.White;
            this.btn_Ver.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.btn_Ver.IconColor = System.Drawing.Color.White;
            this.btn_Ver.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_Ver.IconSize = 45;
            this.btn_Ver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ver.Location = new System.Drawing.Point(563, 516);
            this.btn_Ver.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btn_Ver.Name = "btn_Ver";
            this.btn_Ver.Size = new System.Drawing.Size(108, 51);
            this.btn_Ver.TabIndex = 27;
            this.btn_Ver.Text = "Ver";
            this.btn_Ver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Ver.UseVisualStyleBackColor = false;
            this.btn_Ver.Click += new System.EventHandler(this.btn_Ver_Click);
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
            this.Load += new System.EventHandler(this.ConsultaRecibo_Load);
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Recibos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.DataGridView DGV_Recibos;
        private FontAwesome.Sharp.IconButton Inicio_Btn;
        private FontAwesome.Sharp.IconButton btn_Ver;
    }
}