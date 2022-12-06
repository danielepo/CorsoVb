Imports Inheritance.SchoolManagement
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Namespace TestProject1

    <TestClass>
    Public Class UnitTest1
        <TestMethod("Test add age equals 1")>
        Sub TestSub()
            ' Arrange
            Dim stdu = New Student

            ' Act
            stdu.Age = 0

            ' Assert
            Assert.AreEqual(CByte(1), stdu.Age, "Age Should be 1")
        End Sub

        <TestMethod>
        Sub TestSub1()
            ' Arrange
            Dim stdu = New Student

            ' Act
            stdu.Age = 0

            ' Assert
            Assert.AreEqual(CByte(0), stdu.Age)
        End Sub

        <TestMethod>
        Sub TestSub2()
            ' Arrange
            Dim stdu = New Student

            ' Act
            stdu.Age = 99

            ' Assert
            Assert.AreEqual(CByte(99), stdu.Age)
        End Sub

        <TestMethod>
        Sub TestSubException()
            ' Arrange
            Dim stdu = New Student

            ' Act
            Assert.ThrowsException(Of Exception)(Sub() stdu.Age = Byte.MaxValue)

        End Sub
    End Class


End Namespace

