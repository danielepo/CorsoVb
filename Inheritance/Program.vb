Option Strict On


Imports System

Imports Inheritance.SchoolManagement

Module Program
    Sub Main(args As String())

        Dim professor As New Professor With {
            .Age = 60,
            .Name = "Luigi",
            .CanDoLessons = True,
            .Courses = New List(Of String)
        }

        Dim student As New Student With {
            .Age = 18,
            .Name = "Marco",
            .CoursesFollowed = New List(Of String)
        }

        Console.WriteLine("Inheritance")

        'Dim person As Person = New Person With {
        '    .Age = 18,
        '    .Name = "Marco"
        '}
        Dim person As Person = New Professor With {
            .Age = 45,
            .Name = "Daniele"
        }

        Dim professional As IHasProfession

        professional = student
        professional.GetProfession()
        PrintProf(professional)

        professional = professor
        professional.GetProfession()

        PrintProf(professional)

        If professor.Equals(person) Then
            Console.WriteLine("Sono la stessa persona")
        Else
            Console.WriteLine("Sono persone diverse")
        End If

        PrintInfo(person)
        PrintInfo(professor)
        PrintInfo(student)
    End Sub

    Private Sub PrintProf(professional As IHasProfession)
        professional.GetProfession()
    End Sub

    Private Sub IncreaseI(i As Integer)
        i = i + 1
        Console.WriteLine(i)
    End Sub
    Sub PrintInfo(pr As Person)
        Console.WriteLine(pr.ToString())
        Console.WriteLine(CType(pr, IHasProfession).GetProfession())
    End Sub

End Module
