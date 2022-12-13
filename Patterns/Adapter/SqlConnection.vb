
Public Class Repository
    Private ReadOnly sql As ISqlConnection

    Public Sub New(sql As ISqlConnection)
        Me.sql = sql
    End Sub

    Public Sub AddItem(name As String)
        sql.Add(name)
    End Sub
End Class
Public Interface ISqlConnection
    Sub Add(obj As Object)
    Sub Delete(obj As Object)
    Function [Get](i As Integer) As Object

End Interface
Public Interface INoSqlConnection
    Sub Add(obj As Object)
    Sub Delete(obj As Object)
    Function [Get](i As Integer) As Object
    Sub Open()
    Sub Close()
End Interface
Public Class NoSqlConnection
    Implements INoSqlConnection

    Public Sub Add(obj As Object) Implements INoSqlConnection.Add
        Console.WriteLine($"Add {obj}")
    End Sub

    Public Sub Delete(obj As Object) Implements INoSqlConnection.Delete
        Throw New NotImplementedException()
    End Sub

    Public Sub Open() Implements INoSqlConnection.Open
        Console.WriteLine($"Open Connection")
    End Sub

    Public Sub Close() Implements INoSqlConnection.Close
        Console.WriteLine($"Close Connection")
    End Sub

    Public Function [Get](i As Integer) As Object Implements INoSqlConnection.Get
        Throw New NotImplementedException()
    End Function
End Class
Public Class SqlConnection
    Implements ISqlConnection

    Public Sub Add(obj As Object) Implements ISqlConnection.Add
        Throw New NotImplementedException()
    End Sub

    Public Sub Delete(obj As Object) Implements ISqlConnection.Delete
        Throw New NotImplementedException()
    End Sub

    Public Function [Get](i As Integer) As Object Implements ISqlConnection.Get
        Throw New NotImplementedException()
    End Function
End Class

Public Class SqlConnectionAdaptor
    Implements ISqlConnection

    Private ReadOnly noSql As INoSqlConnection

    Public Sub New(noSql As INoSqlConnection)
        Me.noSql = noSql
    End Sub
    Public Sub Add(obj As Object) Implements ISqlConnection.Add
        noSql.Open()
        noSql.Add(obj)
        noSql.Close()
    End Sub

    Public Sub Delete(obj As Object) Implements ISqlConnection.Delete
        Throw New NotImplementedException()
    End Sub

    Public Function [Get](i As Integer) As Object Implements ISqlConnection.Get
        Throw New NotImplementedException()
    End Function
End Class