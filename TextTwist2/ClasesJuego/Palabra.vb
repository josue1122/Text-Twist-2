Public Class pal
    Implements IEquatable(Of pal)
    Public Property Texto As String
    Public Property Significado As String
    Public Sub New(texto As String)
        Me.Texto = texto
    End Sub
    Public Sub New(texto As String, significado As String)
        Me.New(texto)
        Me.Significado = significado
    End Sub
    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, pal))
    End Function
    Public Overloads Function Equals(other As pal) As Boolean Implements IEquatable(Of pal).Equals
        Return other IsNot Nothing AndAlso
               Texto.Equals(other.Texto, StringComparison.InvariantCultureIgnoreCase)
    End Function
    Public Shared Operator =(left As pal, right As pal) As Boolean
        Return EqualityComparer(Of pal).Default.Equals(left, right)
    End Operator
    Public Shared Operator <>(left As pal, right As pal) As Boolean
        Return Not left = right
    End Operator
End Class