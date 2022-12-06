


Class Rectangle
    Public Property Base As Integer
    Public Property Altezza As Integer
    Public Sub New(_base As Integer, _altezza As Integer)
        Base = _base
        Altezza = _altezza
    End Sub
End Class

Class Square
    Inherits Rectangle
    Public Sub New(_lato As Integer)
        MyBase.New(_lato, _lato)

    End Sub
End Class