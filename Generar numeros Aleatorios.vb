Public Class Generar_numeros_Aleatorios

    Dim LimInfRand As Integer = 1           'Desde donde Comeienza a generar numeros aleatorios
    Dim LimSupRand As Integer = 52        'Hasta donde Genera números aleatorios
    Dim CantNumAleat As Integer = 52        'Cantidad de números a generar (Debe estar dentro del rango definido (LimSup - LimInf[quote][/quote]) )
    Dim matriz(LimSupRand) As Boolean
    Dim ContNumGenerados As Integer

    Private Sub RamdomNoRepetido()
        Dim NumAleat As New System.Random()
        While (CantNumAleat <> ContNumGenerados)
            If ContNumGenerados = CantNumAleat Then Exit Sub
            Dim numero As Integer
            Randomize()
            Do
                numero = NumAleat.Next(LimInfRand, LimSupRand)
                If matriz(numero) = False Then
                    matriz(numero) = True
                    'ListBox1.Items.Add(numero)
                    ContNumGenerados = ContNumGenerados + 1
                    Exit Do
                End If
            Loop
        End While
    End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    ' RamdomNoRepetido()
    ' End Sub
End Class

