<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class respuesta
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(respuesta))
        Me.PictureBox21 = New System.Windows.Forms.PictureBox()
        Me.NO = New System.Windows.Forms.Button()
        Me.BallMove = New System.Windows.Forms.Timer(Me.components)
        Me.DirectionC = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox21
        '
        Me.PictureBox21.Image = CType(resources.GetObject("PictureBox21.Image"), System.Drawing.Image)
        Me.PictureBox21.Location = New System.Drawing.Point(544, 378)
        Me.PictureBox21.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox21.Name = "PictureBox21"
        Me.PictureBox21.Size = New System.Drawing.Size(132, 167)
        Me.PictureBox21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox21.TabIndex = 52
        Me.PictureBox21.TabStop = False
        '
        'NO
        '
        Me.NO.Font = New System.Drawing.Font("Impact", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NO.Location = New System.Drawing.Point(585, 570)
        Me.NO.Name = "NO"
        Me.NO.Size = New System.Drawing.Size(81, 38)
        Me.NO.TabIndex = 56
        Me.NO.Text = "SALIR"
        Me.NO.UseVisualStyleBackColor = True
        '
        'BallMove
        '
        Me.BallMove.Enabled = True
        Me.BallMove.Interval = 1
        '
        'DirectionC
        '
        Me.DirectionC.Interval = 3000
        '
        'respuesta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(678, 620)
        Me.ControlBox = False
        Me.Controls.Add(Me.NO)
        Me.Controls.Add(Me.PictureBox21)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "respuesta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox21 As System.Windows.Forms.PictureBox
    Friend WithEvents NO As System.Windows.Forms.Button
    Friend WithEvents BallMove As System.Windows.Forms.Timer
    Friend WithEvents DirectionC As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
