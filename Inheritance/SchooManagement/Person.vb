Option Strict On
Imports System.Drawing

Namespace SchoolManagement

    Public MustInherit Class Person
        Private _age As Byte
        Protected _eyes As Color

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

        Public Overrides Function ToString() As String
            Return $"Person {Name} has {Age}"
        End Function


        Public Overrides Function Equals(obj As Object) As Boolean

            If TypeOf obj IsNot Person Then
                Return False
            End If

            Dim that = CType(obj, Person)
            Return Me.Age = that.Age And Me.Name = that.Name
        End Function

    End Class
End Namespace
