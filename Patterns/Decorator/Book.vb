Imports System.Runtime.InteropServices.WindowsRuntime

Public Interface IBuyable
    ReadOnly Property Description As String
End Interface
Public Class Book
    Implements IBuyable
    Public Property Title As String

    Public ReadOnly Property Description As String Implements IBuyable.Description
        Get
            Return Title
        End Get
    End Property
End Class

Public MustInherit Class BuyableDecorator
    Implements IBuyable
    Protected ReadOnly buyable As IBuyable
    Public Sub New(buyable As IBuyable)
        Me.buyable = buyable
    End Sub

    Public MustOverride ReadOnly Property Description As String Implements IBuyable.Description
End Class

Public Class Wrapper
    Inherits BuyableDecorator

    Public Sub New(buyable As IBuyable)
        MyBase.New(buyable)
    End Sub

    Public Overrides ReadOnly Property Description As String
        Get
            Return $"Gift of one {buyable.GetType()} with description {buyable.Description}"
        End Get
    End Property
End Class