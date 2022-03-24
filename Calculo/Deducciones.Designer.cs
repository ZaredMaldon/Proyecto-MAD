
namespace Proyecto_MAD.Percepciones_y_deducciones
{
    partial class Deducciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deducciones));
            this.Panel_Background = new System.Windows.Forms.Panel();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.Cb_Mes = new System.Windows.Forms.ComboBox();
            this.Lbl_SalarioDiario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Porcentaje = new System.Windows.Forms.TextBox();
            this.TB_NivelSalarial = new System.Windows.Forms.TextBox();
            this.Lbl_Descuento = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.Btn_Deduccion = new FontAwesome.Sharp.IconButton();
            this.Panel_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Panel_Background.Controls.Add(this.Cb_Mes);
            this.Panel_Background.Controls.Add(this.Lbl_SalarioDiario);
            this.Panel_Background.Controls.Add(this.label1);
            this.Panel_Background.Controls.Add(this.TB_Porcentaje);
            this.Panel_Background.Controls.Add(this.TB_NivelSalarial);
            this.Panel_Background.Controls.Add(this.Lbl_Descuento);
            this.Panel_Background.Controls.Add(this.TB_Nombre);
            this.Panel_Background.Controls.Add(this.LBL_Nombre);
            this.Panel_Background.Controls.Add(this.Btn_Deduccion);
            this.Panel_Background.Controls.Add(this.LBL_Title);
            this.Panel_Background.Location = new System.Drawing.Point(12, 12);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(647, 302);
            this.Panel_Background.TabIndex = 25;
            this.Panel_Background.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_Background_Paint);
            // 
            // LBL_Title
            // 
            this.LBL_Title.AutoSize = true;
            this.LBL_Title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Title.ForeColor = System.Drawing.Color.White;
            this.LBL_Title.Location = new System.Drawing.Point(13, 16);
            this.LBL_Title.Name = "LBL_Title";
            this.LBL_Title.Size = new System.Drawing.Size(138, 23);
            this.LBL_Title.TabIndex = 20;
            this.LBL_Title.Text = "Deducciones";
            // 
            // Cb_Mes
            // 
            this.Cb_Mes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.Cb_Mes.FormattingEnabled = true;
            this.Cb_Mes.Items.AddRange(new object[] {
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
            this.Cb_Mes.Location = new System.Drawing.Point(36, 109);
            this.Cb_Mes.Name = "Cb_Mes";
            this.Cb_Mes.Size = new System.Drawing.Size(121, 23);
            this.Cb_Mes.TabIndex = 58;
            // 
            // Lbl_SalarioDiario
            // 
            this.Lbl_SalarioDiario.AutoSize = true;
            this.Lbl_SalarioDiario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SalarioDiario.ForeColor = System.Drawing.Color.White;
            this.Lbl_SalarioDiario.Location = new System.Drawing.Point(33, 90);
            this.Lbl_SalarioDiario.Name = "Lbl_SalarioDiario";
            this.Lbl_SalarioDiario.Size = new System.Drawing.Size(106, 16);
            this.Lbl_SalarioDiario.TabIndex = 57;
            this.Lbl_SalarioDiario.Text = "Mes Aplicado*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(494, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Porcentaje*";
            // 
            // TB_Porcentaje
            // 
            this.TB_Porcentaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Porcentaje.Location = new System.Drawing.Point(497, 120);
            this.TB_Porcentaje.Name = "TB_Porcentaje";
            this.TB_Porcentaje.Size = new System.Drawing.Size(109, 23);
            this.TB_Porcentaje.TabIndex = 55;
            // 
            // TB_NivelSalarial
            // 
            this.TB_NivelSalarial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_NivelSalarial.Location = new System.Drawing.Point(318, 120);
            this.TB_NivelSalarial.Name = "TB_NivelSalarial";
            this.TB_NivelSalarial.Size = new System.Drawing.Size(154, 23);
            this.TB_NivelSalarial.TabIndex = 54;
            // 
            // Lbl_Descuento
            // 
            this.Lbl_Descuento.AutoSize = true;
            this.Lbl_Descuento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Descuento.ForeColor = System.Drawing.Color.White;
            this.Lbl_Descuento.Location = new System.Drawing.Point(315, 101);
            this.Lbl_Descuento.Name = "Lbl_Descuento";
            this.Lbl_Descuento.Size = new System.Drawing.Size(85, 16);
            this.Lbl_Descuento.TabIndex = 53;
            this.Lbl_Descuento.Text = "Descuento*";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Nombre.Location = new System.Drawing.Point(36, 155);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(154, 23);
            this.TB_Nombre.TabIndex = 52;
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Nombre.ForeColor = System.Drawing.Color.White;
            this.LBL_Nombre.Location = new System.Drawing.Point(33, 136);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(68, 16);
            this.LBL_Nombre.TabIndex = 51;
            this.LBL_Nombre.Text = "Nombre*";
            // 
            // Btn_Deduccion
            // 
            this.Btn_Deduccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Btn_Deduccion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Btn_Deduccion.FlatAppearance.BorderSize = 2;
            this.Btn_Deduccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Btn_Deduccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Btn_Deduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Deduccion.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Deduccion.ForeColor = System.Drawing.Color.White;
            this.Btn_Deduccion.IconChar = FontAwesome.Sharp.IconChar.Icicles;
            this.Btn_Deduccion.IconColor = System.Drawing.Color.White;
            this.Btn_Deduccion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Deduccion.IconSize = 45;
            this.Btn_Deduccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Deduccion.Location = new System.Drawing.Point(509, 251);
            this.Btn_Deduccion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_Deduccion.Name = "Btn_Deduccion";
            this.Btn_Deduccion.Size = new System.Drawing.Size(138, 51);
            this.Btn_Deduccion.TabIndex = 50;
            this.Btn_Deduccion.Text = "Agregar Deducción";
            this.Btn_Deduccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Deduccion.UseVisualStyleBackColor = false;
            // 
            // Deducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 326);
            this.Controls.Add(this.Panel_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Deducciones";
            this.Text = "Deducciones";
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.ComboBox Cb_Mes;
        private System.Windows.Forms.Label Lbl_SalarioDiario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Porcentaje;
        private System.Windows.Forms.TextBox TB_NivelSalarial;
        private System.Windows.Forms.Label Lbl_Descuento;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.Label LBL_Nombre;
        private FontAwesome.Sharp.IconButton Btn_Deduccion;
    }
}