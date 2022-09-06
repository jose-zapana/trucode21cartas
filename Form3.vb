Public Class Form3
    Dim TABLERO(3, 4) As Integer
    Dim VectorFiguras(9, 1) As Integer
    Dim posFinalBusqueda As Integer = 9
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       


    End Sub
    Private Sub inicializarjuego()

        posFinalBusqueda = 9
        For li As Integer = 0 To 9
            VectorFiguras(li, 0) = li
            VectorFiguras(li, 1) = 0

        Next
        InicializarTablero()
        AsiganarControles()

    End Sub

    Private Sub InicializarTablero()
        Dim oRandom As New Random
        For li As Integer = 0 To 3
            For lj As Integer = 0 To 4
                TABLERO(li, lj) = AsignarElementoTablero(oRandom.Next(0, posFinalBusqueda))
            Next
        Next
    End Sub


    Private Function AsignarElementoTablero(ByVal nro As Integer) As Integer
        Dim Oran As New Random
        Dim retval As Integer = 0
        retval = VectorFiguras(nro, 0)
        VectorFiguras(nro, 1) = VectorFiguras(nro, 1) + 1
        If VectorFiguras(nro, 1) = 2 Then
            Dim el0 As Integer = 0, el1 As Integer = 0
            el0 = VectorFiguras(posFinalBusqueda, 0)
            el1 = VectorFiguras(posFinalBusqueda, 1)
            VectorFiguras(posFinalBusqueda, 0) = VectorFiguras(nro, 0)
            VectorFiguras(posFinalBusqueda, 1) = VectorFiguras(nro, 1)

            VectorFiguras(nro, 0) = el0
            VectorFiguras(nro, 1) = el1
            posFinalBusqueda -= 1
        End If
        Return retval
    End Function
    Private Sub AsiganarControles()
        Dim contador As Integer = 1

        For li As Integer = 0 To 3
            For lj As Integer = 0 To 4
                For Each ctrl As Control In Me.GroupBox1.Controls
                    If ctrl.GetType() Is PictureBox1.GetType() Then
                        If ctrl.Name = "PictureBox" & contador.ToString Then
                            ctrl.Tag = TABLERO(li, lj)

                        End If
                    End If
                Next
            Next
        Next
    End Sub


End Class