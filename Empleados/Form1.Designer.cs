namespace Proyecto_MAD.Empleados
{
    partial class VistaPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaPDF));
            this.Inicio_Btn = new FontAwesome.Sharp.IconButton();
            this.pdfViewer1 = new Apitron.PDF.Controls.PDFViewer();
            this.SuspendLayout();
            // 
            // Inicio_Btn
            // 
            this.Inicio_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(83)))), ((int)(((byte)(121)))));
            this.Inicio_Btn.Dock = System.Windows.Forms.DockStyle.Right;
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
            this.Inicio_Btn.Location = new System.Drawing.Point(685, 0);
            this.Inicio_Btn.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Inicio_Btn.Name = "Inicio_Btn";
            this.Inicio_Btn.Size = new System.Drawing.Size(115, 450);
            this.Inicio_Btn.TabIndex = 24;
            this.Inicio_Btn.Text = "PDF";
            this.Inicio_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Inicio_Btn.UseVisualStyleBackColor = false;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.BackColor = System.Drawing.Color.White;
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pdfViewer1.Document = null;
            this.pdfViewer1.EnableSearch = true;
            this.pdfViewer1.Location = new System.Drawing.Point(0, 0);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.SearchHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pdfViewer1.Size = new System.Drawing.Size(686, 450);
            this.pdfViewer1.TabIndex = 25;
            // 
            // VistaPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.Inicio_Btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VistaPDF";
            this.Text = "Pdf";
            this.Load += new System.EventHandler(this.VistaPDF_Load);
            this.Leave += new System.EventHandler(this.VistaPDF_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton Inicio_Btn;
        private Apitron.PDF.Controls.PDFViewer pdfViewer1;
    }
}