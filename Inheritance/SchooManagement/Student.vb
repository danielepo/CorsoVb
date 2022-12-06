Option Strict On

Namespace SchoolManagement
    Public Class Student
        Inherits Person

        Implements IHasProfession

        Public Property CoursesFollowed As List(Of String)

        'Public Function GetProfession() As String
        '    
        'End Function
        'Public Function GetProfession() As String
        '    Return "Student"
        'End Function
        Public Overrides Function ToString() As String
            Return $"Student {Name} has {Age} CoursesFollowed {CoursesFollowed.Count}"
        End Function

        Private Function GetProfession() As String Implements IHasProfession.GetProfession
            Return "Student"
        End Function
    End Class
End Namespace