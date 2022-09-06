<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class portada
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(portada))
        Me.EMPEZAR = New System.Windows.Forms.Button()
        Me.SALIR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'EMPEZAR
        '
        Me.EMPEZAR.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EMPEZAR.Location = New System.Drawing.Point(303, 293)
        Me.EMPEZAR.Name = "EMPEZAR"
        Me.EMPEZAR.Size = New System.Drawing.Size(110, 50)
        Me.EMPEZAR.TabIndex = 0
        Me.EMPEZAR.Text = "INICIO"
        Me.EMPEZAR.UseVisualStyleBackColor = True
        '
        'SALIR
        '
        Me.SALIR.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALIR.Location = New System.Drawing.Point(555, 545)
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(110, 50)
        Me.SALIR.TabIndex = 1
        Me.SALIR.Text = "SALIR"
        Me.SALIR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(121, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(485, 55)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ADIVINA TU CARTA"
        '
        'portada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(678, 599)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SALIR)
        Me.Controls.Add(Me.EMPEZAR)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "portada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EMPEZAR As System.Windows.Forms.Button
    Friend WithEvents SALIR As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
End Class
