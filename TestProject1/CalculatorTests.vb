Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SOLID.DependencyInversion
Namespace TestProject1
    <TestClass>
    Public Class CalculatorTests
        Private Class CalculatableSpy
            Implements ICalculatable
            Public Aspy As Integer
            Public Bspy As Integer
            Public Function Calculate(a As Integer, b As Integer) As Integer Implements ICalculatable.Calculate
                Aspy = a
                Bspy = b
            End Function
        End Class

        <TestMethod>
        Sub TestCalculation()
            ' Arrange
            Dim spy As New CalculatableSpy
            Dim calculator As New Calculator(spy)

            ' Act
            Dim sum = calculator.Calculate(2, 3)

            ' Assert
            Assert.AreEqual(2, spy.Aspy)
            Assert.AreEqual(3, spy.Bspy)
        End Sub
    End Class

End Namespace

