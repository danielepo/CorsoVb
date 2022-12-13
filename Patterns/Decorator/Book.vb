Public Interface IBuyable
    ReadOnly Property Description As String
End Interface
Public Class Book
    Implements IBuyable

    Private ReadOnly title As String

    Public Sub New(title As String)
        Me.title = title
    End Sub

    Public ReadOnly Property Description As String Implements IBuyable.Description
        Get
            Return Me.title
        End Get
    End Property
End Class

Public MustInherit Class BuyableDecorator
    Implements IBuyable

    Public MustOverride ReadOnly Property Description As String Implements IBuyable.Description
End Class

Public Class Wrapper
    Inherits BuyableDecorator

    Private ReadOnly buyable As IBuyable

    Public Sub New(buyable As IBuyable)
        Me.buyable = buyable
    End Sub



    Public Overrides ReadOnly Property Description As String
        Get
            Return $"Wrapped gift containing {buyable.GetType()}: {buyable.Description}"
        End Get
    End Property
End Class
