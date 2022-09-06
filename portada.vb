Public Class portada




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles EMPEZAR.Click

        instrucciones.Show()

        Me.Hide()
    End Sub

    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        Me.Close()
    End Sub


 

    Private Sub portada_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        My.Computer.Audio.Play(My.Resources.s5, AudioPlayMode.Background)

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