Public Class CreditCardProcessor

    Private Shared _instance As CreditCardProcessor

    Private Sub New()

    End Sub
    ' inizializzato
    Public Shared ReadOnly Property Instance As CreditCardProcessor
        Get
            If _instance Is Nothing Then
                _instance = New CreditCardProcessor
            End If
            Return _instance
        End Get
    End Property

    Friend Sub Pay(accountNumber As Integer, v As Double)
        Console.WriteLine($"Remove {v} from {accountNumber}")
    End Sub
End Class
Public Class DebitCardProcessor
    ' inizializzato
    '
    Friend Shared Sub Pay(accountNumber As Integer, v As Double)
        Console.WriteLine($"Remove {v} from {accountNumber}")
    End Sub
End Class

Public Class Item
    Public Property Cost As Double
    Public Property Description As String
End Class
Public Class Cart
    Private cart As List(Of Item) = New List(Of Item)
    Private accountNumber As Integer
    Private ReadOnly paymentMethod As String

    Public Sub New(account As Integer, paymentMethod As String)
        accountNumber = account
        Me.paymentMethod = paymentMethod
    End Sub

    Public Sub add(item As Item)
        cart.Add(item)
    End Sub

    Public Sub Pay()
        Dim processor = CreditCardProcessor.Instance

        processor.Pay(accountNumber, cart.Select(Function(x) x.Cost).Sum())
    End Sub
End Class

