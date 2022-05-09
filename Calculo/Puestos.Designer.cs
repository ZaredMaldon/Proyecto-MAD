
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
            this.Btn_EliminarPuesto = new FontAwesome.Sharp.IconButton();
            this.Btn_ModificarPuesto = new FontAwesome.Sharp.IconButton();
            this.Dgv_Puestos = new System.Windows.Forms.DataGridView();
            this.TB_NivelSalarial = new System.Windows.Forms.TextBox();
            this.Lbl_NivelSalarial = new System.Windows.Forms.Label();
            this.TB_Nombre = new System.Windows.Forms.TextBox();
            this.LBL_Nombre = new System.Windows.Forms.Label();
            this.Btn_AgregarPuesto = new FontAwesome.Sharp.IconButton();
            this.LBL_Title = new System.Windows.Forms.Label();
            this.Lbl_Dpto = new System.Windows.Forms.Label();
            this.CB_Dpto = new System.Windows.Forms.ComboBox();
            this.Lbl_Porcentaje = new System.Windows.Forms.Label();
            this.Panel_Background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Puestos)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Background
            // 
            this.Panel_Background.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Panel_Background.Controls.Add(this.Lbl_Porcentaje);
            this.Panel_Background.Controls.Add(this.Lbl_Dpto);
            this.Panel_Background.Controls.Add(this.CB_Dpto);
            this.Panel_Background.Controls.Add(this.Btn_EliminarPuesto);
            this.Panel_Background.Controls.Add(this.Btn_ModificarPuesto);
            this.Panel_Background.Controls.Add(this.Dgv_Puestos);
            this.Panel_Background.Controls.Add(this.TB_NivelSalarial);
            this.Panel_Background.Controls.Add(this.Lbl_NivelSalarial);
            this.Panel_Background.Controls.Add(this.TB_Nombre);
            this.Panel_Background.Controls.Add(this.LBL_Nombre);
            this.Panel_Background.Controls.Add(this.Btn_AgregarPuesto);
            this.Panel_Background.Controls.Add(this.LBL_Title);
            this.Panel_Background.Location = new System.Drawing.Point(12, 12);
            this.Panel_Background.Name = "Panel_Background";
            this.Panel_Background.Size = new System.Drawing.Size(647, 364);
            this.Panel_Background.TabIndex = 26;
            // 
            // Btn_EliminarPuesto
            // 
            this.Btn_EliminarPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Btn_EliminarPuesto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Btn_EliminarPuesto.FlatAppearance.BorderSize = 2;
            this.Btn_EliminarPuesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Btn_EliminarPuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Btn_EliminarPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EliminarPuesto.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EliminarPuesto.ForeColor = System.Drawing.Color.White;
            this.Btn_EliminarPuesto.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.Btn_EliminarPuesto.IconColor = System.Drawing.Color.White;
            this.Btn_EliminarPuesto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_EliminarPuesto.IconSize = 45;
            this.Btn_EliminarPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_EliminarPuesto.Location = new System.Drawing.Point(516, 313);
            this.Btn_EliminarPuesto.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_EliminarPuesto.Name = "Btn_EliminarPuesto";
            this.Btn_EliminarPuesto.Size = new System.Drawing.Size(116, 51);
            this.Btn_EliminarPuesto.TabIndex = 45;
            this.Btn_EliminarPuesto.Text = "Eliminar Puesto";
            this.Btn_EliminarPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EliminarPuesto.UseVisualStyleBackColor = false;
            this.Btn_EliminarPuesto.Click += new System.EventHandler(this.Btn_EliminarPuesto_Click);
            // 
            // Btn_ModificarPuesto
            // 
            this.Btn_ModificarPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Btn_ModificarPuesto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Btn_ModificarPuesto.FlatAppearance.BorderSize = 2;
            this.Btn_ModificarPuesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Btn_ModificarPuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Btn_ModificarPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ModificarPuesto.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ModificarPuesto.ForeColor = System.Drawing.Color.White;
            this.Btn_ModificarPuesto.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.Btn_ModificarPuesto.IconColor = System.Drawing.Color.White;
            this.Btn_ModificarPuesto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_ModificarPuesto.IconSize = 45;
            this.Btn_ModificarPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ModificarPuesto.Location = new System.Drawing.Point(269, 313);
            this.Btn_ModificarPuesto.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_ModificarPuesto.Name = "Btn_ModificarPuesto";
            this.Btn_ModificarPuesto.Size = new System.Drawing.Size(126, 51);
            this.Btn_ModificarPuesto.TabIndex = 44;
            this.Btn_ModificarPuesto.Text = "Modificar Puesto";
            this.Btn_ModificarPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ModificarPuesto.UseVisualStyleBackColor = false;
            this.Btn_ModificarPuesto.Click += new System.EventHandler(this.Btn_ModificarPuesto_Click);
            // 
            // Dgv_Puestos
            // 
            this.Dgv_Puestos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.Dgv_Puestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Puestos.Location = new System.Drawing.Point(17, 118);
            this.Dgv_Puestos.MultiSelect = false;
            this.Dgv_Puestos.Name = "Dgv_Puestos";
            this.Dgv_Puestos.ReadOnly = true;
            this.Dgv_Puestos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Dgv_Puestos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_Puestos.Size = new System.Drawing.Size(615, 172);
            this.Dgv_Puestos.TabIndex = 43;
            this.Dgv_Puestos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Puestos_CellContentClick);
            // 
            // TB_NivelSalarial
            // 
            this.TB_NivelSalarial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_NivelSalarial.Location = new System.Drawing.Point(281, 71);
            this.TB_NivelSalarial.Name = "TB_NivelSalarial";
            this.TB_NivelSalarial.Size = new System.Drawing.Size(103, 23);
            this.TB_NivelSalarial.TabIndex = 27;
            this.TB_NivelSalarial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NivelSalarial_KeyPress);
            this.TB_NivelSalarial.Leave += new System.EventHandler(this.TB_NivelSalarial_Leave);
            // 
            // Lbl_NivelSalarial
            // 
            this.Lbl_NivelSalarial.AutoSize = true;
            this.Lbl_NivelSalarial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NivelSalarial.ForeColor = System.Drawing.Color.White;
            this.Lbl_NivelSalarial.Location = new System.Drawing.Point(278, 52);
            this.Lbl_NivelSalarial.Name = "Lbl_NivelSalarial";
            this.Lbl_NivelSalarial.Size = new System.Drawing.Size(103, 16);
            this.Lbl_NivelSalarial.TabIndex = 26;
            this.Lbl_NivelSalarial.Text = "Nivel Salarial*";
            // 
            // TB_Nombre
            // 
            this.TB_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.TB_Nombre.Location = new System.Drawing.Point(17, 71);
            this.TB_Nombre.Name = "TB_Nombre";
            this.TB_Nombre.Size = new System.Drawing.Size(154, 23);
            this.TB_Nombre.TabIndex = 25;
            // 
            // LBL_Nombre
            // 
            this.LBL_Nombre.AutoSize = true;
            this.LBL_Nombre.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Nombre.ForeColor = System.Drawing.Color.White;
            this.LBL_Nombre.Location = new System.Drawing.Point(14, 52);
            this.LBL_Nombre.Name = "LBL_Nombre";
            this.LBL_Nombre.Size = new System.Drawing.Size(67, 16);
            this.LBL_Nombre.TabIndex = 24;
            this.LBL_Nombre.Text = "Nombre*";
            // 
            // Btn_AgregarPuesto
            // 
            this.Btn_AgregarPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Btn_AgregarPuesto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(74)))));
            this.Btn_AgregarPuesto.FlatAppearance.BorderSize = 2;
            this.Btn_AgregarPuesto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.Btn_AgregarPuesto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(101)))), ((int)(((byte)(139)))));
            this.Btn_AgregarPuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AgregarPuesto.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AgregarPuesto.ForeColor = System.Drawing.Color.White;
            this.Btn_AgregarPuesto.IconChar = FontAwesome.Sharp.IconChar.Vest;
            this.Btn_AgregarPuesto.IconColor = System.Drawing.Color.White;
            this.Btn_AgregarPuesto.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_AgregarPuesto.IconSize = 45;
            this.Btn_AgregarPuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AgregarPuesto.Location = new System.Drawing.Point(17, 313);
            this.Btn_AgregarPuesto.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Btn_AgregarPuesto.Name = "Btn_AgregarPuesto";
            this.Btn_AgregarPuesto.Size = new System.Drawing.Size(116, 51);
            this.Btn_AgregarPuesto.TabIndex = 23;
            this.Btn_AgregarPuesto.Text = "Agregar Puesto";
            this.Btn_AgregarPuesto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_AgregarPuesto.UseVisualStyleBackColor = false;
            this.Btn_AgregarPuesto.Click += new System.EventHandler(this.Btn_AgregarPuesto_Click);
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
            // Lbl_Dpto
            // 
            this.Lbl_Dpto.AutoSize = true;
            this.Lbl_Dpto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Dpto.ForeColor = System.Drawing.Color.White;
            this.Lbl_Dpto.Location = new System.Drawing.Point(479, 52);
            this.Lbl_Dpto.Name = "Lbl_Dpto";
            this.Lbl_Dpto.Size = new System.Drawing.Size(108, 16);
            this.Lbl_Dpto.TabIndex = 52;
            this.Lbl_Dpto.Text = "Departamento*";
            // 
            // CB_Dpto
            // 
            this.CB_Dpto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.CB_Dpto.FormattingEnabled = true;
            this.CB_Dpto.Location = new System.Drawing.Point(478, 71);
            this.CB_Dpto.Name = "CB_Dpto";
            this.CB_Dpto.Size = new System.Drawing.Size(154, 23);
            this.CB_Dpto.TabIndex = 51;
            // 
            // Lbl_Porcentaje
            // 
            this.Lbl_Porcentaje.AutoSize = true;
            this.Lbl_Porcentaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Porcentaje.ForeColor = System.Drawing.Color.White;
            this.Lbl_Porcentaje.Location = new System.Drawing.Point(302, 97);
            this.Lbl_Porcentaje.Name = "Lbl_Porcentaje";
            this.Lbl_Porcentaje.Size = new System.Drawing.Size(79, 16);
            this.Lbl_Porcentaje.TabIndex = 53;
            this.Lbl_Porcentaje.Text = "Porcentaje";
            // 
            // Puestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 388);
            this.Controls.Add(this.Panel_Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Puestos";
            this.Text = "Puestos";
            this.Load += new System.EventHandler(this.Puestos_Load);
            this.Panel_Background.ResumeLayout(false);
            this.Panel_Background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Puestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Background;
        private FontAwesome.Sharp.IconButton Btn_AgregarPuesto;
        private System.Windows.Forms.Label LBL_Title;
        private System.Windows.Forms.Label LBL_Nombre;
        private System.Windows.Forms.TextBox TB_NivelSalarial;
        private System.Windows.Forms.Label Lbl_NivelSalarial;
        private System.Windows.Forms.TextBox TB_Nombre;
        private System.Windows.Forms.DataGridView Dgv_Puestos;
        private FontAwesome.Sharp.IconButton Btn_EliminarPuesto;
        private FontAwesome.Sharp.IconButton Btn_ModificarPuesto;
        private System.Windows.Forms.Label Lbl_Dpto;
        private System.Windows.Forms.ComboBox CB_Dpto;
        private System.Windows.Forms.Label Lbl_Porcentaje;
    }
}