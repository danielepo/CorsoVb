Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports SOLID.DependencyInversion
Namespace TestProject1
    <TestClass>
    Public Class SumTests
        <TestMethod>
        Sub TestOnePlusOne()
            Dim sum As New Addition

            Dim result = sum.Calculate(1, 1)

            Assert.AreEqual(2, result)
        End Sub
        <TestMethod>
        Sub TestOnePlusZero()
            Dim sum As New Addition

            Dim result = sum.Calculate(1, 1)

            Assert.AreEqual(2, result)
        End Sub
    End Class

End Namespace

