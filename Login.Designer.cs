
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
            this.Login_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CB_Tipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.Salir_Btn.Location = new System.Drawing.Point(267, 9);
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
            this.User_icon.Location = new System.Drawing.Point(24, 228);
            this.User_icon.Margin = new System.Windows.Forms.Padding(0);
            this.User_icon.Name = "User_icon";
            this.User_icon.Size = new System.Drawing.Size(28, 36);
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
            this.iconButton1.Location = new System.Drawing.Point(24, 280);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(28, 35);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // User_TB
            // 
            this.User_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.User_TB.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(141)))));
            this.User_TB.Location = new System.Drawing.Point(55, 228);
            this.User_TB.Multiline = true;
            this.User_TB.Name = "User_TB";
            this.User_TB.Size = new System.Drawing.Size(221, 24);
            this.User_TB.TabIndex = 1;
            // 
            // Password_TB
            // 
            this.Password_TB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password_TB.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold);
            this.Password_TB.Location = new System.Drawing.Point(55, 286);
            this.Password_TB.Multiline = true;
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.PasswordChar = '*';
            this.Password_TB.Size = new System.Drawing.Size(221, 20);
            this.Password_TB.TabIndex = 2;
            this.Password_TB.TextChanged += new System.EventHandler(this.Password_TB_TextChanged);
            // 
            // Titulo_LB
            // 
            this.Titulo_LB.AutoSize = true;
            this.Titulo_LB.Font = new System.Drawing.Font("Elephant", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_LB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(141)))));
            this.Titulo_LB.Location = new System.Drawing.Point(102, 117);
            this.Titulo_LB.Name = "Titulo_LB";
            this.Titulo_LB.Size = new System.Drawing.Size(120, 42);
            this.Titulo_LB.TabIndex = 5;
            this.Titulo_LB.Text = "Login";
            // 
            // Login_btn
            // 
            this.Login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(141)))));
            this.Login_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(141)))));
            this.Login_btn.FlatAppearance.BorderSize = 0;
            this.Login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_btn.Font = new System.Drawing.Font("Bookshelf Symbol 7", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.ForeColor = System.Drawing.Color.White;
            this.Login_btn.Location = new System.Drawing.Point(24, 369);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(252, 33);
            this.Login_btn.TabIndex = 3;
            this.Login_btn.Text = "Entrar";
            this.Login_btn.UseVisualStyleBackColor = false;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(141)))));
            this.panel1.Location = new System.Drawing.Point(46, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 1);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(99)))), ((int)(((byte)(141)))));
            this.panel2.Location = new System.Drawing.Point(46, 310);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 1);
            this.panel2.TabIndex = 9;
            // 
            // CB_Tipo
            // 
            this.CB_Tipo.FormattingEnabled = true;
            this.CB_Tipo.Items.AddRange(new object[] {
            "Gerente",
            "Empleado"});
            this.CB_Tipo.Location = new System.Drawing.Point(24, 179);
            this.CB_Tipo.Name = "CB_Tipo";
            this.CB_Tipo.Size = new System.Drawing.Size(252, 21);
            this.CB_Tipo.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(308, 486);
            this.Controls.Add(this.CB_Tipo);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Salir_Btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Titulo_LB);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Password_TB);
            this.Controls.Add(this.User_TB);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.User_icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1000, 1000);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label Titulo_LB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox CB_Tipo;
    }
}

