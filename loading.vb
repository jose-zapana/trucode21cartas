Public Class loading
    Public contador As Integer


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If contador < 100 Then
            ProgressBar1.Value = contador
            contador = contador + 1
        Else
            Timer1.Enabled = False
            Me.Hide()
            respuesta.Show()
        End If
    End Sub

    Private Sub loading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Value = 0.0
        ProgressBar1.Maximum = 100
        Timer1.Interval = 40
        Timer1.Enabled = True

    End Sub



    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            If MsgBox("Esta realmente seguro que desea salir?", MsgBoxStyle.YesNo, "Salir?") = MsgBoxResult.Yes Then
                Application.Exit()
            Else
                e.Cancel = True
            End If
        End If

    End Sub
End Class