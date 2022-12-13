Option Strict On
Imports System

Module Program
    Sub Main(args As String())

        Console.WriteLine("#####################")
        Console.WriteLine("Welcome to Music Shop")
        Console.WriteLine("#####################")
        Console.WriteLine()
        Console.WriteLine("Please select what you want to do")

        Dim selection As Integer
        Do

            Console.WriteLine("1. List all albums")
            Console.WriteLine("2. List albums in genre")
            Console.WriteLine("3. List albums of an author")
            Console.WriteLine("4. Add autor")
            Console.WriteLine("5. Add genre")
            Console.WriteLine("6. Add album")
            Console.WriteLine("7. Exit")
            Try
                selection = CType(Console.ReadLine(), Integer)
            Catch ex As Exception
                selection = -1
            End Try
            Select Case selection
                Case 1
                    Console.WriteLine($"Selected instruction {selection}")
                Case 2
                    Console.WriteLine($"Selected instruction {selection}")
                Case 3
                    Console.WriteLine($"Selected instruction {selection}")
                Case 4
                    Console.WriteLine($"Selected instruction {selection}")
                Case 5
                    Console.WriteLine($"Selected instruction {selection}")
                Case 6
                    Console.WriteLine($"Selected instruction {selection}")
                Case 7
                    Console.WriteLine($"Selected instruction {selection}")
            End Select

        Loop While Not selection = 7
    End Sub
End Module
