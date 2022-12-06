Option Strict On
Imports System
Imports SOLID.DependencyInversion
Imports SOLID.IntefaceSegregation
Module Program
    Sub Main(args As String())
        Dim square As New Square(3)
        Dim rectangle As New Rectangle(3, 5)

        PrintRectangle(square)
        PrintRectangle(rectangle)

        IncreaseHeight(rectangle)
        IncreaseHeight(square)

        PrintAreaRectangle(rectangle)
        PrintAreaSquare(square)
        PrintAreaRectangle(square)


    End Sub

    Private Sub IncreaseHeight(rectangle As Rectangle)
        rectangle.Altezza += 1
    End Sub

    Private Sub PrintAreaRectangle(rectangle As Rectangle)
        Console.WriteLine($"Area: {rectangle.Base * rectangle.Altezza}")
    End Sub
    Private Sub PrintAreaSquare(square As Square)
        Console.WriteLine($"Area: {Math.Pow(square.Base, 2)}")
    End Sub

    Sub PrintRectangle(rec As Rectangle)
        Console.WriteLine($"Base {rec.Base}, Altezza {rec.Altezza}")
    End Sub
    Sub CheckSquare(rec As Rectangle)

        Console.WriteLine($"Base {rec.Base}, Altezza {rec.Altezza}")
    End Sub


End Module
