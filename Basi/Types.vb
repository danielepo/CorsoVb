
' Option
Module Types
    Sub TestTypes()
        Global.System.Console.WriteLine("Hello World!")



        Dim data As Date = CDate("01-05-2022")

        Dim by As SByte = -128
        Dim uby As Byte = 255

        Dim shrt As Short = 500
        Dim ushrt As UShort

        Dim int As Integer
        Dim int2 As Int32 = 2

        Dim ln As Long = 1

        Dim dec = 1D

        Dim fl As Single

        Dim dbl As Double


        int = shrt

        ' danger
        by = CSByte(shrt)

        Dim hello As String = ""

        Dim str = hello

        Dim obj As Object
    End Sub
End Module
