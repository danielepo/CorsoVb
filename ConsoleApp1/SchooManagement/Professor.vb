Option Strict On

Imports SchoolManagement.Management

Namespace SchoolManagement
    Public Class Professor
        Inherits Person

        Public Property Courses As List(Of String)

        Public Sub New()
            Console.WriteLine("default")
        End Sub
        Public Sub New(n As String)
            MyClass.New()
            Name = n
            Console.WriteLine("Costruito")
        End Sub

        Public Shared Function CreateWithoutAge(n As String) As Professor

            Dim p = New Professor
            p.Name = n
            Return p
        End Function

    End Class
End Namespace
