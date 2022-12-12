Public Class Fibonacci
    Public Function Calculate(v As UInteger) As UInteger
        If v = 1 Then
            Return 1
        End If
        If v = 0 Then
            Return 0
        End If
        Return Calculate(v - 1) + Calculate(v - 2)
    End Function
End Class