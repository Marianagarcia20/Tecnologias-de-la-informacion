namespace EditorDocumentosDeOffice
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtDato = new System.Windows.Forms.TextBox();
            this.PbxExcel = new System.Windows.Forms.PictureBox();
            this.PbxWord = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbxExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxWord)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tu eliges que editar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DK Lemon Yellow Sun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "B I E N V E N I D O !";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 46);
            this.panel1.TabIndex = 9;
            // 
            // TxtDato
            // 
            this.TxtDato.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDato.Location = new System.Drawing.Point(17, 116);
            this.TxtDato.Multiline = true;
            this.TxtDato.Name = "TxtDato";
            this.TxtDato.Size = new System.Drawing.Size(230, 248);
            this.TxtDato.TabIndex = 8;
            // 
            // PbxExcel
            // 
            this.PbxExcel.Image = ((System.Drawing.Image)(resources.GetObject("PbxExcel.Image")));
            this.PbxExcel.Location = new System.Drawing.Point(285, 195);
            this.PbxExcel.Name = "PbxExcel";
            this.PbxExcel.Size = new System.Drawing.Size(74, 65);
            this.PbxExcel.TabIndex = 7;
            this.PbxExcel.TabStop = false;
            this.PbxExcel.Click += new System.EventHandler(this.PbxExcel_Click);
            // 
            // PbxWord
            // 
            this.PbxWord.Image = ((System.Drawing.Image)(resources.GetObject("PbxWord.Image")));
            this.PbxWord.Location = new System.Drawing.Point(285, 112);
            this.PbxWord.Name = "PbxWord";
            this.PbxWord.Size = new System.Drawing.Size(74, 65);
            this.PbxWord.TabIndex = 6;
            this.PbxWord.TabStop = false;
            this.PbxWord.Click += new System.EventHandler(this.PbxWord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(385, 379);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtDato);
            this.Controls.Add(this.PbxExcel);
            this.Controls.Add(this.PbxWord);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PbxExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxWord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxtDato;
        private System.Windows.Forms.PictureBox PbxExcel;
        private System.Windows.Forms.PictureBox PbxWord;
    }
}

