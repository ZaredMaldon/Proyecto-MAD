
namespace Proyecto_MAD.Calculo
{
    partial class Puestos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puestos));
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.Btn_Puesto = new FontAwesome.Sharp.IconButton();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.Lbl_NivelSalarial = new System.Windows.Forms.Label();
            this.TB_NivelSalarial = new System.Windows.Forms.TextBox();
            this.TB_Porcentaje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_SalarioDiario = new System.Windows.Forms.Label();
            this.Panel_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Panel_Background.Controls.Add(this.textBox1);
            this.Panel_Background.Controls.Add(this.Lbl_SalarioDiario);
            this.Panel_Background.Controls.Add(this.label1);
            this.Panel_Background.Controls.Add(this.TB_Porcentaje);
            this.Panel_Background.Controls.Add(this.TB_NivelSalarial);
            this.Panel_Background.Controls.Add(this.Lbl_NivelSalarial);
            this.Panel_Background.Controls.Add(this.TB_Nombre);
            this.Panel_Background.Controls.Add(this.LBL_Nombre);
            this.Panel_Background.Controls.Add(this.Btn_Puesto);
            this.Panel_Background.Controls.Add(this.LBL_Title);
            this.Panel_Background.Location = new System.Drawing.Point(12, 12);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(647, 302);
            this.Panel_Background.TabIndex = 26;
            // 
            // Btn_Puesto
            // 
            this.Btn_Puesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Btn_Puesto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Btn_Puesto.FlatAppearance.BorderSize = 2;
            this.Btn_Puesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Btn_Puesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Btn_Puesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Puesto.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Puesto.ForeColor = System.Drawing.Color.White;
            this.Btn_Puesto.IconChar = FontAwesome.Sharp.IconChar.Vest;
            this.Btn_Puesto.IconColor = System.Drawing.Color.White;
            this.Btn_Puesto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Puesto.IconSize = 45;
            this.Btn_Puesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Puesto.Location = new System.Drawing.Point(528, 251);
            this.Btn_Puesto.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_Puesto.Name = "Btn_Puesto";
            this.Btn_Puesto.Size = new System.Drawing.Size(116, 51);
            this.Btn_Puesto.TabIndex = 23;
            this.Btn_Puesto.Text = "Agregar Puesto";
            this.Btn_Puesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Puesto.UseVisualStyleBackColor = false;
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.Color.White;
            this.LBL_Title.Location = new System.Drawing.Point(13, 16);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(88, 23);
            this.LBL_Title.TabIndex = 20;
            this.LBL_Title.Text = "Puestos";
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Nombre.ForeColor = System.Drawing.Color.White;
            this.LBL_Nombre.Location = new System.Drawing.Point(47, 74);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(68, 16);
            this.LBL_Nombre.TabIndex = 24;
            this.LBL_Nombre.Text = "Nombre*";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Nombre.Location = new System.Drawing.Point(50, 93);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(154, 23);
            this.TB_Nombre.TabIndex = 25;
            // 
            // Lbl_NivelSalarial
            // 
            this.Lbl_NivelSalarial.AutoSize = true;
            this.Lbl_NivelSalarial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NivelSalarial.ForeColor = System.Drawing.Color.White;
            this.Lbl_NivelSalarial.Location = new System.Drawing.Point(47, 153);
            this.Lbl_NivelSalarial.Name = "Lbl_NivelSalarial";
            this.Lbl_NivelSalarial.Size = new System.Drawing.Size(104, 16);
            this.Lbl_NivelSalarial.TabIndex = 26;
            this.Lbl_NivelSalarial.Text = "Nivel Salarial*";
            // 
            // TB_NivelSalarial
            // 
            this.TB_NivelSalarial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_NivelSalarial.Location = new System.Drawing.Point(50, 172);
            this.TB_NivelSalarial.Name = "TB_NivelSalarial";
            this.TB_NivelSalarial.Size = new System.Drawing.Size(154, 23);
            this.TB_NivelSalarial.TabIndex = 27;
            // 
            // TB_Porcentaje
            // 
            this.TB_Porcentaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Porcentaje.Location = new System.Drawing.Point(298, 172);
            this.TB_Porcentaje.Name = "TB_Porcentaje";
            this.TB_Porcentaje.Size = new System.Drawing.Size(109, 23);
            this.TB_Porcentaje.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(295, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Porcentaje*";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.textBox1.Location = new System.Drawing.Point(450, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 23);
            this.textBox1.TabIndex = 31;
            // 
            // Lbl_SalarioDiario
            // 
            this.Lbl_SalarioDiario.AutoSize = true;
            this.Lbl_SalarioDiario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SalarioDiario.ForeColor = System.Drawing.Color.White;
            this.Lbl_SalarioDiario.Location = new System.Drawing.Point(447, 74);
            this.Lbl_SalarioDiario.Name = "Lbl_SalarioDiario";
            this.Lbl_SalarioDiario.Size = new System.Drawing.Size(105, 16);
            this.Lbl_SalarioDiario.TabIndex = 30;
            this.Lbl_SalarioDiario.Text = "Salario Diario*";
            // 
            // Puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 326);
            this.Controls.Add(this.Panel_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Puestos";
            this.Text = "Puestos";
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private FontAwesome.Sharp.IconButton Btn_Puesto;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Lbl_SalarioDiario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Porcentaje;
        private System.Windows.Forms.TextBox TB_NivelSalarial;
        private System.Windows.Forms.Label Lbl_NivelSalarial;
        private System.Windows.Forms.TextBox TB_Nombre;
    }
}