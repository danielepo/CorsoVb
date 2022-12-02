Option Strict On
Imports System
Imports SOLID.IntefaceSegregation

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim animali As List(Of IAnimal) = New List(Of IAnimal) From {
            New Uccello(),
            New Umano(),
            New Cane(),
            New AnimaleRobotico()
        }

        For Each animale In animali

            Console.WriteLine(animale.GetType().Name)

            If TypeOf (animale) Is IRompiballe Then
                CType(animale, IRompiballe).RompiLePalle()
            End If

            If TypeOf (animale) Is IMangiatore Then
                Mangia(CType(animale, IMangiatore))
            End If

            If TypeOf (animale) Is IVolatile Then
                CType(animale, IVolatile).Vola()
            End If
        Next

    End Sub
    Sub Mangia(mangiatore As IMangiatore)
        mangiatore.Mangia()
        mangiatore.Mangia("Carne")
    End Sub
End Module
