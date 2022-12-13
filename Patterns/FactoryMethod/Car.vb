
Public Interface ICarFactory
    Function MakeCar() As Car
End Interface

Public Class CarFactory
    Implements ICarFactory

    Public Function MakeCar() As Car Implements ICarFactory.MakeCar
        Return New Car
    End Function
End Class

Public Class Car

End Class
