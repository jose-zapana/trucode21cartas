<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.ProcesarABtn = New System.Windows.Forms.Button()
        Me.ProcesarBBtn = New System.Windows.Forms.Button()
        Me.ProcesarCBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ProcesarABtn
        '
        Me.ProcesarABtn.Location = New System.Drawing.Point(32, 37)
        Me.ProcesarABtn.Name = "ProcesarABtn"
        Me.ProcesarABtn.Size = New System.Drawing.Size(75, 63)
        Me.ProcesarABtn.TabIndex = 0
        Me.ProcesarABtn.Text = "Button1"
        Me.ProcesarABtn.UseVisualStyleBackColor = True
        '
        'ProcesarBBtn
        '
        Me.ProcesarBBtn.Location = New System.Drawing.Point(113, 37)
        Me.ProcesarBBtn.Name = "ProcesarBBtn"
        Me.ProcesarBBtn.Size = New System.Drawing.Size(75, 63)
        Me.ProcesarBBtn.TabIndex = 1
        Me.ProcesarBBtn.Text = "Button2"
        Me.ProcesarBBtn.UseVisualStyleBackColor = True
        '
        'ProcesarCBtn
        '
        Me.ProcesarCBtn.Location = New System.Drawing.Point(194, 37)
        Me.ProcesarCBtn.Name = "ProcesarCBtn"
        Me.ProcesarCBtn.Size = New System.Drawing.Size(75, 63)
        Me.ProcesarCBtn.TabIndex = 2
        Me.ProcesarCBtn.Text = "Button3"
        Me.ProcesarCBtn.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(84, 119)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(124, 111)
        Me.TextBox1.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 262)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ProcesarCBtn)
        Me.Controls.Add(Me.ProcesarBBtn)
        Me.Controls.Add(Me.ProcesarABtn)
        Me.Name = "Form2"
        Me.Text = "Ordenando Array"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProcesarABtn As System.Windows.Forms.Button
    Friend WithEvents ProcesarBBtn As System.Windows.Forms.Button
    Friend WithEvents ProcesarCBtn As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
End Class
