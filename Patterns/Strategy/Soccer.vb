Public Interface Strategy
    Sub Play()
End Interface
Public Class Team

    Public Sub New(st As Strategy)
        Strategy = st
    End Sub

    Public Strategy As Strategy
    Friend Sub TryStrategy()
        Strategy.Play()
    End Sub


End Class
Public Class Attacco
    Implements Strategy

    Public Sub Play() Implements Strategy.Play
        Console.WriteLine("Vai in attacco e cerca di far goal")
    End Sub
End Class
Public Class Diffesa
    Implements Strategy

    Public Sub Play() Implements Strategy.Play
        Console.WriteLine("Vai in diffesa e cerca di evitare goal")
    End Sub
End Class
Public Class Soccer
    Public Property Team1 As Team
    Public Property Team2 As Team

    Public Sub PlayGame()
        Team1 = New Team(New Attacco)
        Team2 = New Team(New Diffesa)
        While True
            Team1.TryStrategy()
            Team2.TryStrategy()
            '...

            Team1.Strategy = New Diffesa
            Team1.TryStrategy()
        End While
    End Sub
End Class
