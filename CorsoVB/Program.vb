Option Strict On

Imports CorsoVB.SchoolManagement
'Imports CorsoVB.SchoolManagement

Module Utility
    Public Sub NewMethod(ByRef arrayList As ArrayList, ByRef listSimple As List(Of String), ByRef dict As Dictionary(Of String, Date))
        arrayList = New ArrayList

        arrayList.Add(1)
        arrayList.Add("sdlfk")
        arrayList.Add(1.3)
        Console.WriteLine(arrayList(2))


        listSimple = New List(Of String)
        'listSimple.Add(1)
        listSimple.Add("Daniele")
        listSimple.Add("Marco")
        listSimple.Add("Filippo")

        Dim setSimple As HashSet(Of String) = New HashSet(Of String)
        'listSimple.Add(1)
        setSimple.Add("Daniele")
        setSimple.Add("Marco")
        setSimple.Add("Filippo")
        'listSimple.Add(1.3)
        dict = New Dictionary(Of String, Date)

        dict.Add("ieri", DateTime.Now.AddDays(-1))
        dict.Add("oggi", DateTime.Now)
        dict.Add("domani", DateTime.Now.AddDays(1))

        Console.WriteLine(dict("oggi"))
    End Sub
End Module

Module Program
    Function Main() As Integer

        Dim 

        Console.WriteLine("inserire nome professore")
        professor1.Name = Console.ReadLine()

        Console.WriteLine("inserire eta proessore")
        professor1.Age = CByte(Console.ReadLine())

        Console.WriteLine($"Inserito professore {professor1.Name} ha { professor1.Age} anni")

        Return 0
    End Function
    ' array di stringe
    Sub Main_1(args As String())
        ' stringa


        Console.WriteLine("Arrays")
        Dim array(2) As Integer
        array(0) = 1
        array(1) = 2
        array(2) = 3

        Console.WriteLine("Arrays " + array(0).ToString())
        Console.WriteLine($"Arrays {array(1)}")
        Console.WriteLine("Arrays " & array(2))

        Dim oggi As Date = DateTime.Now
        Dim ennesima As String = "1"
        Dim giornata = oggi.ToString("yyyy-MM-dd")

        Console.WriteLine("Oggi e' " + giornata + " e oggi c'e' la " + ennesima + " giornatna di corso")

        Console.WriteLine($"Oggi e' {oggi:yyyy-MM-dd} e oggi c'e' la {ennesima} giornatna di corso")

        Console.WriteLine(String.Format("Oggi e' {0:yyyy-MM-dd} e {2} oggi c'e' la {1} giornatna di ", oggi, ennesima, 1))

        Dim arrayObj(5) As Object
        arrayObj(0) = 1
        arrayObj(1) = "dfs"
        arrayObj(2) = 3.4
        arrayObj(3) = "C"c

        Dim str2 As String = CStr(arrayObj(1))
        Dim arrayList As ArrayList = Nothing
        Dim listSimple As List(Of String) = Nothing
        Dim dict As Dictionary(Of String, Date) = Nothing

        Utility.NewMethod(arrayList, listSimple, dict)

        ' scope
        Dim i As Integer

        Console.WriteLine("for")
        For i = 0 To 0
            Console.WriteLine(arrayList(i))
        Next

        For i = 2 To 0 Step -1
            Console.WriteLine(listSimple(i))
        Next

        i = 0
        While i = 0
            Console.WriteLine(listSimple(i))
            i += 1
        End While

        Console.WriteLine("do..loop")
        i = 0
        Do
            Console.WriteLine(listSimple(i))
            i += 1
        Loop While i < 0

        Console.WriteLine("For each")

        Dim keys = dict.Keys
        For i = 2 To 0 Step -1
            Dim key = keys(i)
            Console.WriteLine(dict(key))
        Next

        Console.WriteLine("If")

        For Each element In dict
            If element.Key = "oggi" Then
                Console.WriteLine("oggi")
            ElseIf element.Key = "ieri" Then
                Console.WriteLine($"ieri {element.Value:dd}")
            Else
                Console.WriteLine(element.Value)
            End If

            Select Case element.Key
                Case "oggi"
                    Console.WriteLine("oggi")
                Case "ieri"
                    Console.WriteLine($"ieri {element.Value:dd}")
                Case Else
                    Console.WriteLine(element.Value)
            End Select

        Next

    End Sub

End Module

