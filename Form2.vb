Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub MostarArry(ByRef sMiLista() As String)
        Dim iContador As Integer

        Me.TextBox1.Clear()
        For iContador = 0 To sMiLista.Length - 1
            Me.TextBox1.Text += sMiLista(iContador) + vbNewLine

        Next
    End Sub

    Private Sub ProcesarABtn_Click(sender As Object, e As EventArgs) Handles ProcesarABtn.Click
        Dim sLetra1() As String = {"z", "a", "g", "m", "w", "i", "c", "b"}
        Array.Sort(sLetra1)

        MostarArry(sLetra1)

    End Sub

    Private Sub ProcesarBBtn_Click(sender As Object, e As EventArgs) Handles ProcesarBBtn.Click
        Dim sLetras() As String = {"z", "a", "g", "m", "w", "i", "c", "b"}
        Array.Sort(sLetras, 4, 3)

        MostarArry(sLetras)
    End Sub

    Private Sub ProcesarCBtn_Click(sender As Object, e As EventArgs) Handles ProcesarCBtn.Click
        Dim sLetras() As String = {"z", "a", "g", "m", "w", "i", "c", "b"}
        Array.Reverse(sLetras)

        MostarArry(sLetras)
    End Sub
End Class