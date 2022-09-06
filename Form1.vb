
Public Class Form1
    Dim pic As PictureBox
    Dim vector(21)
    Dim f As Integer

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load




        'iniciamos el contador en 2



        a = 0

        For i = 0 To 20
            pic = Me.Controls("picturebox" & i + 1)
            pic.Image = Image.FromFile("carta.jpg")
        Next i

        'la ruta de la imagen para cargar

        'corremos el codigo pero antes..
    End Sub

    Sub Auto()
        'Se declaran las variables
        Dim Numero As Integer
        Dim aleatorio As New Random
        Dim Control As Boolean
        Dim NumMax As Integer
        Dim Mostrar, i, f, c, x As Integer
        Dim Contador As Integer
        Dim v(21) As String

        NumMax = 52
        Mostrar = 21
        If Mostrar > NumMax Then Mostrar = NumMax
        'Código que se ejecuta mientras el número de muestras sea inferior al deseado 
        Do While (Contador < Mostrar)
            'Código que se ejecuta mientras el número obtenido ya haya salido con anterioridad 
            Do While Not (Control)
                'Se genera el número aleatorio
                Numero = aleatorio.Next(1, NumMax + 1)
                If Tb_Resultado.Text.Contains(Numero.ToString()) Then
                    Control = False
                Else
                    Control = True
                    If Tb_Resultado.Text = "" Then
                        Tb_Resultado.Text = Numero.ToString
                        v(Contador) = Numero.ToString

                    Else
                        Tb_Resultado.Text = Tb_Resultado.Text + " ; " + Numero.ToString
                        v(Contador) = v(Contador) + Numero.ToString
                    End If

                End If
            Loop
            Control = False
            Contador = Contador + 1
        Loop

       
        i = 0
        For f = 0 To 6
            For c = 0 To 2
                m(f, c) = v(i)
                i = i + 1
            Next
        Next
        x = 1
        For f = 0 To 6
            For c = 0 To 2

                pic = Me.Controls("picturebox" & x)
                pic.Image = Image.FromFile(m(f, c) & ".jpg")
                pic.Visible = True
                x = x + 1
            Next
        Next


    End Sub



    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click



        If a = 0 Then

            Dim f, c, i, j, x As Integer
            'llenar matriz
            i = 1
            x = 1
            For f = 0 To 6
                For c = 0 To 2

                    If c = 0 Then
                        ax(f, c) = m(f, 2)
                    Else
                        If c = 1 Then
                            ax(f, c) = m(f, 0)
                        Else
                            If c = 2 Then
                                ax(f, c) = m(f, 1)
                            End If
                        End If
                    End If


                Next
            Next
            'llenar vector
            For c = 0 To 2
                For f = 0 To 6
                    aux(i) = ax(f, c)
                    i = i + 1
                Next
            Next
            j = 1
            'llenar matriz
            For f = 0 To 6
                For c = 0 To 2
                    '
                    ax(f, c) = aux(j)
                    j = j + 1
                Next
            Next


            For f = 0 To 6
                For c = 0 To 2
                    m(f, c) = ax(f, c)
                    'Me.ListView1.Items.Add("m[" & f & "," & c & "]=" & m(f, c))



                Next
            Next





            For f = 0 To 6
                For c = 0 To 2
                    pic = Me.Controls("picturebox" & x)
                    pic.Image = Image.FromFile("carta.jpg")
                    ' pic.Image = Image.FromFile(ax(f, c) & ".jpg")
                    pic.Visible = True
                    x = x + 1
                Next
            Next
            Timer1.Interval = 40
            Timer1.Enabled = True

        Else
            If a = 1 Then


                Dim f, c, i, j, x As Integer
                'llenar matriz
                i = 1
                x = 1

                




                For f = 0 To 6
                    For c = 0 To 2

                        If c = 0 Then
                            ax(f, c) = m(f, 2)
                        Else
                            If c = 1 Then
                                ax(f, c) = m(f, 0)
                            Else
                                If c = 2 Then
                                    ax(f, c) = m(f, 1)
                                End If
                            End If
                        End If


                    Next
                Next
                'llenar vector
                For c = 0 To 2
                    For f = 0 To 6
                        aux(i) = ax(f, c)
                        i = i + 1
                    Next
                Next
                j = 1
                'llenar matriz
                For f = 0 To 6
                    For c = 0 To 2
                        '
                        ax(f, c) = aux(j)
                        j = j + 1
                    Next
                Next


                For f = 0 To 6
                    For c = 0 To 2
                        m(f, c) = ax(f, c)
                        'Me.ListView1.Items.Add("m[" & f & "," & c & "]=" & m(f, c))



                    Next
                Next

                For f = 0 To 6
                    For c = 0 To 2
                        pic = Me.Controls("picturebox" & x)
                        pic.Image = Image.FromFile("carta.jpg")
                        ' pic.Image = Image.FromFile(ax(f, c) & ".jpg")
                        pic.Visible = True
                        x = x + 1
                    Next
                Next

                Timer1.Interval = 40
                Timer1.Enabled = True

            ElseIf a = 2 Then

                Button1.Enabled = False
                Button3.Enabled = False
                Button6.Enabled = False


                resp = ax(3, 0)

                'respuesta.Show()
                loading.Show()
                Me.Hide()

                For i = 0 To 20
                    pic = Me.Controls("picturebox" & i + 1)
                    pic.Image = Image.FromFile("carta.jpg")

                Next i

                a = a + 1
                'limitamos el contador a 2
                If a = 3 Then
                    a = 0
                    ' Y se repite la misma historia jjj
                End If
            End If

        End If

        a = a + 1
        'limitamos el contador a 2
        If a = 3 Then
            a = 0
            ' Y se repite la misma historia jjj
        End If



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If a = 0 Then
            Dim f, c, i, j, x As Integer
            'llenar matriz
            i = 1
            x = 1
            For f = 0 To 6
                For c = 0 To 2

                    If c = 0 Then
                        ax(f, c) = m(f, 2)
                    Else
                        If c = 1 Then
                            ax(f, c) = m(f, 1)
                        Else
                            If c = 2 Then
                                ax(f, c) = m(f, 0)
                            End If
                        End If
                    End If


                Next
            Next
            'llenar vector
            For c = 0 To 2
                For f = 0 To 6
                    aux(i) = ax(f, c)
                    i = i + 1
                Next
            Next
            j = 1
            'llenar matriz
            For f = 0 To 6
                For c = 0 To 2
                    '
                    ax(f, c) = aux(j)
                    j = j + 1
                Next
            Next


            For f = 0 To 6
                For c = 0 To 2
                    m(f, c) = ax(f, c)
                    'Me.ListView1.Items.Add("m[" & f & "," & c & "]=" & m(f, c))



                Next
            Next

            For f = 0 To 6
                For c = 0 To 2
                    pic = Me.Controls("picturebox" & x)
                    pic.Image = Image.FromFile("carta.jpg")
                    ' pic.Image = Image.FromFile(ax(f, c) & ".jpg")

                    pic.Visible = True
                    ' pic.Image = Image.FromFile(x & ".jpg")
                    x = x + 1
                Next
            Next
            Timer1.Interval = 40
            Timer1.Enabled = True
        Else
            If a = 1 Then


                Dim f, c, i, j, x As Integer
                'llenar matriz
                i = 1
                x = 1
                For f = 0 To 6
                    For c = 0 To 2

                        If c = 0 Then
                            ax(f, c) = m(f, 2)
                        Else
                            If c = 1 Then
                                ax(f, c) = m(f, 1)
                            Else
                                If c = 2 Then
                                    ax(f, c) = m(f, 0)
                                End If
                            End If
                        End If


                    Next
                Next
                'llenar vector
                For c = 0 To 2
                    For f = 0 To 6
                        aux(i) = ax(f, c)
                        i = i + 1
                    Next
                Next
                j = 1
                'llenar matriz
                For f = 0 To 6
                    For c = 0 To 2
                        '
                        ax(f, c) = aux(j)
                        j = j + 1
                    Next
                Next


                For f = 0 To 6
                    For c = 0 To 2
                        m(f, c) = ax(f, c)
                        'Me.ListView1.Items.Add("m[" & f & "," & c & "]=" & m(f, c))



                    Next
                Next

                For f = 0 To 6
                    For c = 0 To 2
                        pic = Me.Controls("picturebox" & x)
                        pic.Image = Image.FromFile("carta.jpg")
                        'pic.Image = Image.FromFile(ax(f, c) & ".jpg")
                        pic.Visible = True
                        'pic.Image = Image.FromFile(x & ".jpg")
                        x = x + 1
                    Next
                Next


                Timer1.Interval = 40
                Timer1.Enabled = True



            ElseIf a = 2 Then

                Button1.Enabled = False
                Button3.Enabled = False
                Button6.Enabled = False


                resp = ax(3, 1)

                'respuesta.Show()
                loading.Show()
                Me.Hide()
                For i = 0 To 20
                    pic = Me.Controls("picturebox" & i + 1)
                    pic.Image = Image.FromFile("carta.jpg")

                Next i

                a = a + 1
                'limitamos el contador a 2
                If a = 3 Then
                    a = 0
                    ' Y se repite la misma historia jjj
                End If
            End If

        End If

        a = a + 1
        'limitamos el contador a 2
        If a = 3 Then
            a = 0
            ' Y se repite la misma historia jjj
        End If


    End Sub

    Private Sub Bt_Lanzar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Auto()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button1.Enabled = True
        Button3.Enabled = True
        Button6.Enabled = True
        Button2.Enabled = False
        Me.Button2.Hide()
        Randomize()

        Auto()


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click


        If a = 0 Then

            Dim f, c, i, j, x As Integer
            'llenar matriz
            i = 1
            x = 1
            For f = 0 To 6
                For c = 0 To 2

                    If c = 0 Then
                        ax(f, c) = m(f, 1)
                    Else
                        If c = 1 Then
                            ax(f, c) = m(f, 2)
                        Else
                            If c = 2 Then
                                ax(f, c) = m(f, 0)
                            End If
                        End If
                    End If


                Next
            Next
            'llenar vector
            For c = 0 To 2
                For f = 0 To 6
                    aux(i) = ax(f, c)
                    i = i + 1
                Next
            Next
            j = 1
            'llenar matriz
            For f = 0 To 6
                For c = 0 To 2
                    '
                    ax(f, c) = aux(j)
                    j = j + 1
                Next
            Next


            For f = 0 To 6
                For c = 0 To 2
                    m(f, c) = ax(f, c)
                    'Me.ListView1.Items.Add("m[" & f & "," & c & "]=" & m(f, c))



                Next
            Next

            For f = 0 To 6
                For c = 0 To 2
                    pic = Me.Controls("picturebox" & x)
                    pic.Image = Image.FromFile("carta.jpg")
                    'pic.Image = Image.FromFile(ax(f, c) & ".jpg")
                    pic.Visible = True
                    ' pic.Image = Image.FromFile(x & ".jpg")
                    x = x + 1
                Next
            Next

            Timer1.Interval = 40
            Timer1.Enabled = True



        Else
            If a = 1 Then


                Dim f, c, i, j, x As Integer
                'llenar matriz
                i = 1
                x = 1
                For f = 0 To 6
                    For c = 0 To 2

                        If c = 0 Then
                            ax(f, c) = m(f, 1)
                        Else
                            If c = 1 Then
                                ax(f, c) = m(f, 2)
                            Else
                                If c = 2 Then
                                    ax(f, c) = m(f, 0)
                                End If
                            End If
                        End If


                    Next
                Next
                'llenar vector
                For c = 0 To 2
                    For f = 0 To 6
                        aux(i) = ax(f, c)
                        i = i + 1
                    Next
                Next
                j = 1
                'llenar matriz
                For f = 0 To 6
                    For c = 0 To 2
                        '
                        ax(f, c) = aux(j)
                        j = j + 1
                    Next
                Next


                For f = 0 To 6
                    For c = 0 To 2
                        m(f, c) = ax(f, c)
                        'Me.ListView1.Items.Add("m[" & f & "," & c & "]=" & m(f, c))



                    Next
                Next

                For f = 0 To 6
                    For c = 0 To 2
                        pic = Me.Controls("picturebox" & x)
                        pic.Image = Image.FromFile("carta.jpg")
                        'pic.Image = Image.FromFile(ax(f, c) & ".jpg")
                        pic.Visible = True
                        ' pic.Image = Image.FromFile(x & ".jpg")
                        x = x + 1
                    Next
                Next

                Timer1.Interval = 40
                Timer1.Enabled = True


            ElseIf a = 2 Then

                Button1.Enabled = False
                Button3.Enabled = False
                Button6.Enabled = False


                resp = ax(3, 2)

                'respuesta.Show()
                loading.Show()

                Me.Hide()

                For i = 0 To 20
                    pic = Me.Controls("picturebox" & i + 1)
                    pic.Image = Image.FromFile("carta.jpg")

                Next i

                a = a + 1
                'limitamos el contador a 2
                If a = 3 Then
                    a = 0
                    ' Y se repite la misma historia jjj
                End If
            End If

        End If

        a = a + 1
        'limitamos el contador a 2
        If a = 3 Then
            a = 0
            ' Y se repite la misma historia jjj
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        For i = 1 To 7
            pic = Me.Controls("picturebox" & i)
            pic.Image = Image.FromFile(i & ".jpg")

        Next i
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static contador As Integer
        Dim f, c, x As Integer


        x = 1
        contador = contador + 1
        If contador < 100 Then


            For f = 0 To 6
                For c = 0 To 2
                    pic = Me.Controls("picturebox" & x)
                    pic.Image = Image.FromFile(ax(f, c) & ".jpg")
                    pic.Visible = True
                    ' pic.Image = Image.FromFile(x & ".jpg")
                    x = x + 1
                Next
            Next

            '  For i = 0 To 20
            'pic = Me.Controls("picturebox" & i + 1)
            'pic.Image = Image.FromFile("carta.jpg")

            'Next i

        Else
            Timer1.Enabled = False
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


