Option Strict On

Public Interface IUnitOfMeasure(Of T)
    Function Calculate(value As T, toUom As IUnitOfMeasure(Of T)) As T
End Interface
Public Class Celcious
    Implements IUnitOfMeasure(Of Double)

    Public Function Calculate(value As Double, toUom As IUnitOfMeasure(Of Double)) As Double Implements IUnitOfMeasure(Of Double).Calculate
        If TypeOf (toUom) Is Farenheit Then
            Return (value * 9 / 5) + 32
        ElseIf TypeOf (toUom) Is Celcious Then
            Return value
        End If
        Throw New Exception
    End Function
End Class

Public Class Farenheit
    Implements IUnitOfMeasure(Of Double)

    Public Function Calculate(value As Double, toUom As IUnitOfMeasure(Of Double)) As Double Implements IUnitOfMeasure(Of Double).Calculate
        Throw New NotImplementedException()
    End Function
End Class
Public Class MeasuredValue(Of T)
    Public ReadOnly Value As T
    Public ReadOnly UOM As IUnitOfMeasure(Of T)

    Public Sub New(val As T, uom As IUnitOfMeasure(Of T))
        Value = val
        Me.UOM = uom
    End Sub

    Public Function Convert(toUom As IUnitOfMeasure(Of T)) As MeasuredValue(Of T)
        Dim newValue = UOM.Calculate(Value, toUom)
        Return New MeasuredValue(Of T)(newValue, toUom)
    End Function
End Class
