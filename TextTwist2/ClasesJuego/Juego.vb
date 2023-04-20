Public Class Juego
    Public Shared Property Puntos As Integer
    Public Property Ronda As Integer

    Public Shared Function ComprobarPalabra(palabra1 As Palabra, palabra2 As Palabra) As Boolean
        If palabra1 Is Nothing AndAlso palabra2 Is Nothing Then
            Return True
        ElseIf palabra1 Is Nothing OrElse palabra2 Is Nothing Then
            Return False
        Else
            If palabra1.Texto.Equals(palabra2.Texto, StringComparison.OrdinalIgnoreCase) Then
                Puntos += 1500
            End If
            Return palabra1.Texto.Equals(palabra2.Texto, StringComparison.OrdinalIgnoreCase)
        End If
    End Function
End Class
