
' Option
Module Flow
    Friend Sub TestIfSelect()
        Dim dict As Dictionary(Of String, Date) = New Dictionary(Of String, Date) From {
            {"ieri", Date.Now.AddDays(-1)},
            {"oggi", Date.Now},
            {"domani", Date.Now.AddDays(1)}
        }

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


    Friend Sub TestControlFlow()
        Dim i As Integer

        Dim listSimple = New List(Of String) From {
            "Daniele",
            "Marco",
            "Filippo"
        }

        Dim arrayList As ArrayList = New ArrayList From {
            1,
            "dfs",
            3.4,
            "A"c
        }

        Console.WriteLine("for")
        For i = 0 To arrayList.Count
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

        For Each element In arrayList
            Console.WriteLine(element)
        Next
    End Sub
End Module
