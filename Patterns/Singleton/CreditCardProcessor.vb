Public Class CreditCardProcessor

End Class

Public Class Item
    Public Property Cost As Double
    Public Property Description As String
End Class
Public Class Cart
    Private cart As List(Of Item) = New List(Of Item)
    Private accountNumber As Integer
    Public Sub New(account As Integer)
        accountNumber = account
    End Sub

    Public Sub add(item As Item)
        cart.Add(item)
    End Sub

    Public Sub Pay()

    End Sub
End Class

