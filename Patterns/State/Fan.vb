
Public Class Fan
    Private ReadOnly controller As MotorController

    Public Sub New(controller As MotorController)
        Me.controller = controller
    End Sub
    Public Sub UpdateControler()
    End Sub
    Public Sub Click()
    End Sub

End Class



Public Interface MotorController
    Sub GoSlow()
    Sub GoFast()
    Sub StopFan()
End Interface