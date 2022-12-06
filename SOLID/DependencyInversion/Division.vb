Namespace DependencyInversion


    Public Class Division
        Implements ICalculatable

        Public Function Calculate(a As Integer, b As Integer) As Integer Implements ICalculatable.Calculate
            Return a / b
        End Function
    End Class
End Namespace
