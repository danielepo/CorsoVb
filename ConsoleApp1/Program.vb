Imports System
Imports ConsoleApp1.SchoolManagement
'Imports System.Collections.Generic
'Imports System.Linq

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        'Dim professor1 As Professor = New Professor
        Dim cont As New Contenitore("dato")
        cont.Lista.Add("My")
        cont.Lista.Add("daniele")

        Dim lista = cont.Lista.
            Select(Function(x) New Professor(x)).
            Where(Function(x) x.Name.Length > 2)

        For Each elm In lista
            Console.WriteLine(elm.Name)
        Next
    End Sub


End Module

Public Class Contenitore
    Public ReadOnly Dato As String

    Private ReadOnly _Lista As List(Of String) = New List(Of String) From {
            "hello",
            "world"
            }

    Public ReadOnly Property Lista As List(Of String)
        Get
            Return _Lista
        End Get
    End Property

    Public Sub New(dato As String)
        Me.Dato = dato
    End Sub

End Class
