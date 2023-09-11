<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DtpFechaI = New System.Windows.Forms.DateTimePicker()
        Me.DtpFechaF = New System.Windows.Forms.DateTimePicker()
        Me.PbxExcel = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PbxExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtpFechaI
        '
        Me.DtpFechaI.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaI.Location = New System.Drawing.Point(127, 120)
        Me.DtpFechaI.Name = "DtpFechaI"
        Me.DtpFechaI.Size = New System.Drawing.Size(117, 27)
        Me.DtpFechaI.TabIndex = 0
        '
        'DtpFechaF
        '
        Me.DtpFechaF.Font = New System.Drawing.Font("Lucida Sans Unicode", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaF.Location = New System.Drawing.Point(127, 159)
        Me.DtpFechaF.Name = "DtpFechaF"
        Me.DtpFechaF.Size = New System.Drawing.Size(117, 27)
        Me.DtpFechaF.TabIndex = 1
        '
        'PbxExcel
        '
        Me.PbxExcel.Image = CType(resources.GetObject("PbxExcel.Image"), System.Drawing.Image)
        Me.PbxExcel.Location = New System.Drawing.Point(281, 123)
        Me.PbxExcel.Name = "PbxExcel"
        Me.PbxExcel.Size = New System.Drawing.Size(68, 50)
        Me.PbxExcel.TabIndex = 2
        Me.PbxExcel.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha inicio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha final:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 41)
        Me.Panel1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Hellobaby", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(89, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 27)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "R e p o r t e   d e   v e n t a s"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(361, 217)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PbxExcel)
        Me.Controls.Add(Me.DtpFechaF)
        Me.Controls.Add(Me.DtpFechaI)
        Me.Name = "Form1"
        Me.Text = "FormVentas"
        CType(Me.PbxExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtpFechaI As DateTimePicker
    Friend WithEvents DtpFechaF As DateTimePicker
    Friend WithEvents PbxExcel As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
End Class
