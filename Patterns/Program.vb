Imports System

Module Program
    Private factory As ICarFactory = New CarFactory

    Sub Main(args As String())
        'Dim book As New Book
        'book.Title = "Harry potter"
        ''        book.IsWrapped = True

        'Dim wrappedBook As New Wrapper(book)

        'Print(book)
        'Print(wrappedBook)


        'Dim repo As New Repository(New SqlConnectionAdaptor(New NoSqlConnection()))

        'repo.AddItem("Hello World!")

        'Dim cart As New Cart(1, "creditcard")
        'cart.add(New Item With {
        '    .Cost = 1,
        '    .Description = "gomma"
        '         })

        'cart.Pay()
        'cart.Pay()

        'Dim car = factory.MakeCar()

        Dim soccer As New Soccer
        soccer.PlayGame()
    End Sub
    Private Sub Print(b As IBuyable)
        Console.WriteLine(b.Description)
    End Sub
End Module
