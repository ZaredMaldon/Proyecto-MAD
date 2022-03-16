
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Salir_Btn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
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
            this.Salir_Btn.IconColor = System.Drawing.Color.Black;
            this.Salir_Btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Salir_Btn.IconSize = 20;
            this.Salir_Btn.Location = new System.Drawing.Point(467, 12);
            this.Salir_Btn.Margin = new System.Windows.Forms.Padding(0);
            this.Salir_Btn.Name = "Salir_Btn";
            this.Salir_Btn.Size = new System.Drawing.Size(25, 26);
            this.Salir_Btn.TabIndex = 0;
            this.Salir_Btn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(504, 231);
            this.Controls.Add(this.Salir_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private FontAwesome.Sharp.IconButton Salir_Btn;
    }
}

