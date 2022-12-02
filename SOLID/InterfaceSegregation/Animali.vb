Option Strict On


Namespace IntefaceSegregation
    Public Interface IMangiatore
        Sub Mangia()
        Sub Mangia(cibo As String)
    End Interface
    Public Interface IRompiballe
        Sub RompiLePalle()
    End Interface
    Public Interface IVolatile
        Sub Vola()
    End Interface
    Public Interface IAnimal

    End Interface
    Public Class AnimaleRobotico
        Implements IAnimal, IRompiballe

        Public Sub RompiLePalle() Implements IRompiballe.RompiLePalle
            Console.WriteLine("Volume non si puo abbassare")
        End Sub

    End Class
    Public Class Cane
        Implements IAnimal, IRompiballe, IMangiatore

        Public Sub RompiLePalle() Implements IRompiballe.RompiLePalle
            Console.WriteLine("Abbaia di notte")
        End Sub

        Public Sub Mangia() Implements IMangiatore.Mangia
            Console.WriteLine("Mangia")
        End Sub
        Public Sub Mangia(cibo As String) Implements IMangiatore.Mangia
            Console.WriteLine("Mangia")
        End Sub

    End Class
    Public Class Uccello
        Implements IAnimal, IRompiballe, IMangiatore, IVolatile

        Public Sub RompiLePalle() Implements IRompiballe.RompiLePalle
            Console.WriteLine("Sporca la macchina")
        End Sub
        Public Sub Mangia() Implements IMangiatore.Mangia
            Console.WriteLine("Mangia")
        End Sub
        Public Sub Mangia(cibo As String) Implements IMangiatore.Mangia
            Console.WriteLine("Mangia")
        End Sub


        Private Sub IAnimal_Vola() Implements IVolatile.Vola
            Console.WriteLine("Vola")
        End Sub
    End Class
    Public Class Umano
        Implements IAnimal, IRompiballe, IMangiatore

        Public Sub RompiLePalle() Implements IRompiballe.RompiLePalle
            Console.WriteLine("Chiama per vendere nuova linea telefonica")
        End Sub
        Public Sub Mangia() Implements IMangiatore.Mangia
            Console.WriteLine("Mangia")
        End Sub
        Public Sub Mangia(cibo As String) Implements IMangiatore.Mangia
            Console.WriteLine("Mangia")
        End Sub

    End Class


End Namespace