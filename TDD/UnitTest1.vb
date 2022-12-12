Imports NUnit.Framework

Namespace TDD

    Public Class FibonacciCalculateTest

        <SetUp>
        Public Sub Setup()
        End Sub

        <Test>
        Public Sub Position_zero_returns_zero()
            Dim fibo As New Fibonacci.Fibonacci

            Dim result = fibo.Calculate(0)

            Assert.That(result, [Is].EqualTo(0))
        End Sub
        <Test>
        Public Sub Position_One_returns_one()
            Dim fibo As New Fibonacci.Fibonacci

            Dim result = fibo.Calculate(1)

            Assert.That(result, [Is].EqualTo(1))
        End Sub
        <Test>
        Public Sub Position_two_returns_one()
            Dim fibo As New Fibonacci.Fibonacci

            Dim result = fibo.Calculate(2)

            Assert.That(result, [Is].EqualTo(1))
        End Sub
        <Test>
        Public Sub Position_four_returns_one()
            Dim fibo As New Fibonacci.Fibonacci

            Dim result = fibo.Calculate(4)

            Assert.That(result, [Is].EqualTo(3))
        End Sub
        <Test>
        Public Sub Position_three_returns_one()
            Dim fibo As New Fibonacci.Fibonacci

            Dim result = fibo.Calculate(3)

            Assert.That(result, [Is].EqualTo(2))
        End Sub

    End Class

End Namespace