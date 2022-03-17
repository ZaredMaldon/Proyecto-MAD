
namespace Proyecto_MAD
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();

            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Salir_Btn = new FontAwesome.Sharp.IconButton();
            this.User_icon = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.User_TB = new System.Windows.Forms.TextBox();
            this.Password_TB = new System.Windows.Forms.TextBox();
            this.Titulo_LB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Salir_Btn
            // 
            this.Salir_Btn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Salir_Btn.FlatAppearance.BorderSize = 0;
            this.Salir_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Salir_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir_Btn.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.Salir_Btn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Salir_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Salir_Btn.IconSize = 28;
            this.Salir_Btn.Location = new System.Drawing.Point(469, 9);
            this.Salir_Btn.Margin = new System.Windows.Forms.Padding(0);
            this.Salir_Btn.Name = "Salir_Btn";
            this.Salir_Btn.Size = new System.Drawing.Size(25, 26);
            this.Salir_Btn.TabIndex = 0;
            this.Salir_Btn.UseVisualStyleBackColor = true;
            this.Salir_Btn.Click += new System.EventHandler(this.Salir_Btn_Click);
            // 
            // User_icon
            // 
            this.User_icon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.User_icon.FlatAppearance.BorderSize = 0;
            this.User_icon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.User_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.User_icon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.User_icon.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.User_icon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(141)))));
            this.User_icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.User_icon.IconSize = 25;
            this.User_icon.Location = new System.Drawing.Point(69, 73);
            this.User_icon.Margin = new System.Windows.Forms.Padding(0);
            this.User_icon.Name = "User_icon";
            this.User_icon.Size = new System.Drawing.Size(44, 43);
            this.User_icon.TabIndex = 1;
            this.User_icon.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(141)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(69, 127);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(44, 43);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // User_TB
            // 
            this.User_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_TB.Location = new System.Drawing.Point(116, 80);
            this.User_TB.Name = "User_TB";
            this.User_TB.Size = new System.Drawing.Size(290, 26);
            this.User_TB.TabIndex = 1;
            // 
            // Password_TB
            // 
            this.Password_TB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_TB.Location = new System.Drawing.Point(116, 134);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.PasswordChar = '*';
            this.Password_TB.Size = new System.Drawing.Size(290, 26);
            this.Password_TB.TabIndex = 2;
            // 
            // Titulo_LB
            // 
            this.Titulo_LB.AutoSize = true;
            this.Titulo_LB.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.Titulo_LB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Titulo_LB.Location = new System.Drawing.Point(11, 4);
            this.Titulo_LB.Name = "Titulo_LB";
            this.Titulo_LB.Size = new System.Drawing.Size(63, 28);
            this.Titulo_LB.TabIndex = 5;
            this.Titulo_LB.Text = "Login";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.Salir_Btn);
            this.panel1.Controls.Add(this.Titulo_LB);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 42);
            this.panel1.TabIndex = 6;
            // 
            // Login_btn
            // 
            this.Login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(141)))));
            this.Login_btn.Font = new System.Drawing.Font("Yu Gothic UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.Login_btn.Location = new System.Drawing.Point(400, 185);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(92, 34);
            this.Login_btn.TabIndex = 3;
            this.Login_btn.Text = "Inicio";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(504, 231);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.User_TB);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.User_icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1000, 1000);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private FontAwesome.Sharp.IconButton Salir_Btn;
        private System.Windows.Forms.TextBox Password_TB;
        private System.Windows.Forms.TextBox User_TB;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton User_icon;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Titulo_LB;
    }
}

