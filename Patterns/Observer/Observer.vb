Public Interface IObserver
    Sub Add(observable As ISubscriber)
    Sub NotifyAll()
End Interface
Public Interface ISubscriber
    Sub Update()
End Interface
Public Class Observer

End Class
