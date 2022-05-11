
namespace Proyecto_MAD.Empleados
{
    partial class CambiarContra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContra));
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.Btn_Cambiar = new FontAwesome.Sharp.IconButton();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Mes = new System.Windows.Forms.Label();
            this.TB_Usuario = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Password2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Panel_Background.Controls.Add(this.TB_Password2);
            this.Panel_Background.Controls.Add(this.label2);
            this.Panel_Background.Controls.Add(this.TB_Password);
            this.Panel_Background.Controls.Add(this.label1);
            this.Panel_Background.Controls.Add(this.TB_Usuario);
            this.Panel_Background.Controls.Add(this.Btn_Cambiar);
            this.Panel_Background.Controls.Add(this.LBL_Title);
            this.Panel_Background.Controls.Add(this.LBL_Mes);
            this.Panel_Background.Location = new System.Drawing.Point(31, 28);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(671, 567);
            this.Panel_Background.TabIndex = 22;
            // 
            // Btn_Cambiar
            // 
            this.Btn_Cambiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Btn_Cambiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Btn_Cambiar.FlatAppearance.BorderSize = 2;
            this.Btn_Cambiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Btn_Cambiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Btn_Cambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cambiar.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cambiar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cambiar.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.Btn_Cambiar.IconColor = System.Drawing.Color.White;
            this.Btn_Cambiar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Cambiar.IconSize = 45;
            this.Btn_Cambiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Cambiar.Location = new System.Drawing.Point(527, 505);
            this.Btn_Cambiar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_Cambiar.Name = "Btn_Cambiar";
            this.Btn_Cambiar.Size = new System.Drawing.Size(130, 51);
            this.Btn_Cambiar.TabIndex = 23;
            this.Btn_Cambiar.Text = "Cambiar";
            this.Btn_Cambiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Cambiar.UseVisualStyleBackColor = false;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.Color.White;
            this.LBL_Title.Location = new System.Drawing.Point(13, 16);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(234, 23);
            this.LBL_Title.TabIndex = 20;
            this.LBL_Title.Text = "Cambio de Contraseña";
            // 
            // LBL_Mes
            // 
            this.LBL_Mes.AutoSize = true;
            this.LBL_Mes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Mes.ForeColor = System.Drawing.Color.White;
            this.LBL_Mes.Location = new System.Drawing.Point(216, 128);
            this.LBL_Mes.Name = "LBL_Mes";
            this.LBL_Mes.Size = new System.Drawing.Size(80, 21);
            this.LBL_Mes.TabIndex = 8;
            this.LBL_Mes.Text = "Usuario";
            this.LBL_Mes.Click += new System.EventHandler(this.LBL_Mes_Click);
            // 
            // TB_Usuario
            // 
            this.TB_Usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Usuario.Location = new System.Drawing.Point(220, 167);
            this.TB_Usuario.Name = "TB_Usuario";
            this.TB_Usuario.Size = new System.Drawing.Size(218, 23);
            this.TB_Usuario.TabIndex = 24;
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Password.Location = new System.Drawing.Point(220, 257);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(218, 23);
            this.TB_Password.TabIndex = 26;
            this.TB_Password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Contraseña";
            // 
            // TB_Password2
            // 
            this.TB_Password2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Password2.Location = new System.Drawing.Point(220, 345);
            this.TB_Password2.Name = "TB_Password2";
            this.TB_Password2.PasswordChar = '*';
            this.TB_Password2.Size = new System.Drawing.Size(218, 23);
            this.TB_Password2.TabIndex = 28;
            this.TB_Password2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(216, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Confirma Contraseña";
            // 
            // CambiarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 621);
            this.Controls.Add(this.Panel_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CambiarContra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Mes;
        private FontAwesome.Sharp.IconButton Btn_Cambiar;
        private System.Windows.Forms.TextBox TB_Password2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Usuario;
    }
}