Option Strict On

Namespace SchoolManagement
    Public Class Person
        Private _age As Byte
        Public Property Age As Byte
            Get
                Return _age
            End Get
            Set
                If Value > 100 Then
                    Throw New Exception("Age must be below 100")
                End If
                _age = Value
            End Set
        End Property

        Private _Name As String
        Public Property Name As String
            Get
                Return _Name
            End Get
            Set
                If String.IsNullOrWhiteSpace(Value) Then
                    Throw New Exception("name must be")
                End If
                _Name = Value
            End Set
        End Property
    End Class
End Namespace
