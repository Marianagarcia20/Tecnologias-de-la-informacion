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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtDato = New System.Windows.Forms.TextBox()
        Me.PbxExcel = New System.Windows.Forms.PictureBox()
        Me.PbxWord = New System.Windows.Forms.PictureBox()
        CType(Me.PbxExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbxWord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 18)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Tu eliges que editar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("DK Lemon Yellow Sun", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "B I E N V E N I D O !"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 45)
        Me.Panel1.TabIndex = 9
        '
        'TxtDato
        '
        Me.TxtDato.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDato.Location = New System.Drawing.Point(20, 105)
        Me.TxtDato.Multiline = True
        Me.TxtDato.Name = "TxtDato"
        Me.TxtDato.Size = New System.Drawing.Size(210, 253)
        Me.TxtDato.TabIndex = 8
        '
        'PbxExcel
        '
        Me.PbxExcel.Image = CType(resources.GetObject("PbxExcel.Image"), System.Drawing.Image)
        Me.PbxExcel.Location = New System.Drawing.Point(258, 199)
        Me.PbxExcel.Name = "PbxExcel"
        Me.PbxExcel.Size = New System.Drawing.Size(84, 73)
        Me.PbxExcel.TabIndex = 7
        Me.PbxExcel.TabStop = False
        '
        'PbxWord
        '
        Me.PbxWord.Image = CType(resources.GetObject("PbxWord.Image"), System.Drawing.Image)
        Me.PbxWord.Location = New System.Drawing.Point(258, 105)
        Me.PbxWord.Name = "PbxWord"
        Me.PbxWord.Size = New System.Drawing.Size(84, 73)
        Me.PbxWord.TabIndex = 6
        Me.PbxWord.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(364, 373)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtDato)
        Me.Controls.Add(Me.PbxExcel)
        Me.Controls.Add(Me.PbxWord)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PbxExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbxWord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtDato As TextBox
    Friend WithEvents PbxExcel As PictureBox
    Friend WithEvents PbxWord As PictureBox
End Class
