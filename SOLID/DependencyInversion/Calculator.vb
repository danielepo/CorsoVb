Namespace DependencyInversion
    Public Class Calculator
        Private ReadOnly _calculatable As ICalculatable

        Public Sub New(calculatable As ICalculatable)
            Me._calculatable = calculatable
        End Sub
        Public Function Calculate(a As Integer, b As Integer) As Integer
            Return _calculatable.Calculate(a, b)
        End Function

    End Class
End Namespace
