Namespace DependencyInversion
    Public Enum TypeOperation
        Add
        Mul
        Div
    End Enum
    Public Interface ICalculatable
        Function Calculate(a As Integer, b As Integer) As Integer
    End Interface
    Public Class Calculator
        Private ReadOnly _calculatable As ICalculatable

        Public Sub New(calculatable As ICalculatable)
            Me._calculatable = calculatable
        End Sub
        Public Function Calculate(a As Integer, b As Integer) As Integer
            Return _calculatable.Calculate(a, b)
        End Function

    End Class

    Public Class Addition
        Implements ICalculatable

        Public Function Calculate(a As Integer, b As Integer) As Integer Implements ICalculatable.Calculate
            Return a + b
        End Function
    End Class

    Public Class Multiplication
        Implements ICalculatable

        Public Function Calculate(a As Integer, b As Integer) As Integer Implements ICalculatable.Calculate
            Return a * b
        End Function
    End Class
    Public Class Division
        Implements ICalculatable

        Public Function Calculate(a As Integer, b As Integer) As Integer Implements ICalculatable.Calculate
            Return a / b
        End Function
    End Class
    Public Class Substract
        Implements ICalculatable

        Public Function Calculate(a As Integer, b As Integer) As Integer Implements ICalculatable.Calculate
            Return a - b
        End Function
    End Class
End Namespace
