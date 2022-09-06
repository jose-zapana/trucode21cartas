Public Class Class1 'identidad
    'atributos,campos o propiedades
    Private nombrecompleto As String
    Private direccion As String
    Private nacionalidad As String
    Private estadocivil As String
    Private estatura As Integer

    'metodos constructores
    Sub New(ByVal nombrecompleto As String, ByVal direccion As String, ByVal nacionalidad As String, ByVal estadocivil As String, ByVal estatura As Integer)
        Me.nombrecompleto = nombrecompleto
        Me.direccion = direccion
        Me.nacionalidad = nacionalidad
        Me.estadocivil = estadocivil
        Me.estatura = estatura
    End Sub

    'metodos
    Function GetNombrecompleto() As String
        Return Me.nombrecompleto
    End Function
    Function SetNombreCompleto(ByVal nombreCompleto As String) As String
        Me.nombrecompleto = nombreCompleto
        Return Nothing
    End Function

    Function Getdireccion() As String
        Return Me.direccion
    End Function

    Function Setdireccion(ByVal nombreCompleto As String) As String

        Me.direccion = direccion
        Return Nothing
    End Function


  


End Class
