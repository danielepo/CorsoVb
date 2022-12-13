Option Strict On

Imports System.Drawing
Imports CorsoVB.SchoolManagement.Management

Namespace SchoolManagement
    ' if S if a subtype of T then objects of type T can be replaced with objects of type S
    Public Class Professor
        Inherits Person
        Implements IHasProfession

        Private Sub New()
            _eyes = Color.Gray
        End Sub

        Public Property Courses As List(Of String)


        Public Shared Function CreateWithoutAge(n As String) As Professor

            Dim p = New Professor
            p.Name = n
            Return p
        End Function

        'Public Function GetProfession() As String
        '    Return "Professor"
        'End Function
        Public Property CanDoLessons As Boolean
        Public Overrides Function ToString() As String
            Return $"Professor {Name} has {Age} CanDoLessons {CanDoLessons}"
        End Function
        Public Overrides Function Equals(obj As Object) As Boolean

            If TypeOf obj IsNot Professor Then
                Return False
            End If

            Dim that = CType(obj, Professor)
            Return Me.Age = that.Age And Me.Name = that.Name

        End Function

        Private Function GetProfession() As String Implements IHasProfession.GetProfession
            Return "Professor"
        End Function
    End Class

End Namespace
