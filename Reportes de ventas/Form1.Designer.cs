namespace Reportes_de_ventas
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
            this.Label3 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.PbxExcel = new System.Windows.Forms.PictureBox();
            this.DtpFechaF = new System.Windows.Forms.DateTimePicker();
            this.DtpFechaI = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.PbxExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Hellobaby", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(89, 64);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(189, 27);
            this.Label3.TabIndex = 13;
            this.Label3.Text = "R e p o r t e   d e   v e n t a s";
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Black;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(373, 41);
            this.Panel1.TabIndex = 12;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 169);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(91, 18);
            this.Label2.TabIndex = 11;
            this.Label2.Text = "Fecha final:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(12, 130);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(99, 18);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "Fecha inicio:";
            // 
            // PbxExcel
            // 
            this.PbxExcel.Image = ((System.Drawing.Image)(resources.GetObject("PbxExcel.Image")));
            this.PbxExcel.Location = new System.Drawing.Point(281, 124);
            this.PbxExcel.Name = "PbxExcel";
            this.PbxExcel.Size = new System.Drawing.Size(68, 50);
            this.PbxExcel.TabIndex = 9;
            this.PbxExcel.TabStop = false;
            this.PbxExcel.Click += new System.EventHandler(this.PbxExcel_Click);
            // 
            // DtpFechaF
            // 
            this.DtpFechaF.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaF.Location = new System.Drawing.Point(127, 160);
            this.DtpFechaF.Name = "DtpFechaF";
            this.DtpFechaF.Size = new System.Drawing.Size(117, 27);
            this.DtpFechaF.TabIndex = 8;
            // 
            // DtpFechaI
            // 
            this.DtpFechaI.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaI.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaI.Location = new System.Drawing.Point(127, 121);
            this.DtpFechaI.Name = "DtpFechaI";
            this.DtpFechaI.Size = new System.Drawing.Size(117, 27);
            this.DtpFechaI.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(373, 226);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.PbxExcel);
            this.Controls.Add(this.DtpFechaF);
            this.Controls.Add(this.DtpFechaI);
            this.Name = "Form1";
            this.Text = "FormVentas";
            ((System.ComponentModel.ISupportInitialize)(this.PbxExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PbxExcel;
        internal System.Windows.Forms.DateTimePicker DtpFechaF;
        internal System.Windows.Forms.DateTimePicker DtpFechaI;
    }
}

