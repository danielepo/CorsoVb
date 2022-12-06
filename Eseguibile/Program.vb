Option Strict On

Imports System
Imports SI

Class Classe
    Public Num As Integer
End Class

Module Program
    Sub Main(args As String())
        Dim lista As New List(Of String) From {
            "Hello",
            "World"
        }

        Dim listaInt As New List(Of Integer) From {
            1,
            2
        }

        Dim setInt As New HashSet(Of Classe)

        Dim dic As New Dictionary(Of Short, UInteger)


        Dim temperature As New MeasuredValue(Of Double)(0, New Celcious)

        Dim tF = temperature.Convert(New Farenheit)

    End Sub
End Module
