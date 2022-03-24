
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
            this.TB_Info = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.Panel_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Panel_Background.Controls.Add(this.TB_Info);
            this.Panel_Background.Controls.Add(this.pictureBox1);
            this.Panel_Background.Controls.Add(this.LBL_Title);
            this.Panel_Background.Location = new System.Drawing.Point(12, 12);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(647, 302);
            this.Panel_Background.TabIndex = 26;
            // 
            // TB_Info
            // 
            this.TB_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.TB_Info.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Info.ForeColor = System.Drawing.Color.White;
            this.TB_Info.Location = new System.Drawing.Point(325, 73);
            this.TB_Info.Multiline = true;
            this.TB_Info.Name = "TB_Info";
            this.TB_Info.ReadOnly = true;
            this.TB_Info.Size = new System.Drawing.Size(292, 173);
            this.TB_Info.TabIndex = 25;
            this.TB_Info.Text = resources.GetString("TB_Info.Text");
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
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.TextBox TB_Info;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LBL_Title;
    }
}