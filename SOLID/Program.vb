Option Strict On
Imports System
Imports SOLID.DependencyInversion
Imports SOLID.IntefaceSegregation
Module Program
    Sub Main(args As String())
        ' InterefaceSegregation.InterfaceSegregationExample()

        Console.WriteLine(New Calculator(New Addition).Calculate(2, 5))
        Console.WriteLine(New Calculator(New Multiplication).Calculate(2, 5))
        Console.WriteLine(New Calculator(New Division).Calculate(5, 2))
        Console.WriteLine(New Calculator(New Substract).Calculate(5, 2))
    End Sub




End Module
