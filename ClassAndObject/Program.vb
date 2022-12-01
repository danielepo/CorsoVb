Option Strict On

Imports Inheritance.SchoolManagement


Module Program
    Function Main() As Integer

        Dim professor1 As Professor = New Professor

        Console.WriteLine("inserire nome professore")
        professor1.Name = Console.ReadLine()

        Console.WriteLine("inserire eta proessore")
        professor1.Age = CByte(Console.ReadLine())

        Console.WriteLine($"Inserito professore {professor1.Name} ha { professor1.Age} anni")

        Return 0
    End Function

End Module

