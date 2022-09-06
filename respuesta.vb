Public Class respuesta
    'Speed of the Ball
    Dim Xr As Integer
    Dim Yr As Integer

    'If True going left
    Dim DirectionX As Boolean
    'if true going up
    Dim DirectionY As Boolean

    'Times how long until the ball changes direction and speeds
    Dim ChangeDT As Integer

    Dim ChangeX As Byte
    Dim ChangeY As Byte
    Dim pic As PictureBox

    Dim Ball As PictureBox


    Private Sub respuesta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Computer.Audio.Play(My.Resources.grito, AudioPlayMode.Background)

        PictureBox21.Image = Image.FromFile(resp & ".jpg")

        Ball = PictureBox21

        'randomizing the initial rotation values
        Randomize()
        Xr = (Rnd() * 4) + 1
        Yr = (Rnd() * 4) + 1
        BallMove.Enabled = True
        DirectionC.Enabled = True

        Randomize()
        ChangeDT = (Rnd() * 5000) + 1
        Randomize()
        ChangeX = (Rnd() * 1) + 1
        ChangeY = (Rnd() * 1) + 1

        If ChangeX = 0 Then
            DirectionX = False

        ElseIf ChangeX >= 1 Then
            DirectionX = True
        End If

        If ChangeY = 0 Then
            DirectionY = False

        ElseIf ChangeY >= 1 Then
            DirectionY = True
        End If

    End Sub


  

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles NO.Click
        portada.Close()
        Me.Close()
    End Sub





    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles BallMove.Tick
        If DirectionX = True Then
            Ball.Left -= Xr
        End If
        If DirectionX = False Then
            Ball.Left += Xr
        End If

        If DirectionY = True Then
            Ball.Top -= Yr
        End If

        If DirectionY = False Then
            Ball.Top += Yr
        End If


        If Ball.Left <= 0 Then

            DirectionX = False
            Randomize()
            Xr = (Rnd() * 4) + 1
            Yr = (Rnd() * 4) + 1


        End If

        If Ball.Left >= Me.Width - 80 Then

            DirectionX = True
            Randomize()
            Xr = (Rnd() * 4) + 1
            Yr = (Rnd() * 4) + 1


        End If


        If Ball.Top <= 0 Then


            DirectionY = False
            Randomize()
            Xr = (Rnd() * 4) + 1
            Yr = (Rnd() * 4) + 1


        End If



        If Ball.Top >= Me.Height - 80 Then


            DirectionY = True
            Randomize()
            Xr = (Rnd() * 4) + 1
            Yr = (Rnd() * 4) + 1


        End If


    End Sub



    Private Sub DirectionC_Tick(sender As Object, e As EventArgs) Handles DirectionC.Tick
        Randomize()
        ChangeX = (Rnd() * 1) + 1
        ChangeY = (Rnd() * 1) + 1
    

        If ChangeX = 0 Then
            DirectionX = False

        ElseIf ChangeX >= 1 Then
            DirectionX = True
        End If

        If ChangeY = 0 Then
            DirectionY = False

        ElseIf ChangeY >= 1 Then
            DirectionY = True
        End If


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