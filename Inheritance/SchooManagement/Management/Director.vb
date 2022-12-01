Option Strict On

Namespace SchoolManagement
    Friend Class Director
        Inherits Person
        Implements IHasProfession

        Public Function GetProfession() As String Implements IHasProfession.GetProfession
            Return "Director"
        End Function

        'Public Function GetProfession() As String
        '    Return "Director"
        'End Function
    End Class
End Namespace
