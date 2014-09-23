Module Module1

    Sub Main()
        'code for input - output program
        'by A. Programmer on 23/09/2014

        Dim name As String

        Console.Write("Enter thy name, peasant: ")
        name = Console.ReadLine()
        If name = "John Snow" Then
            Console.Write("You know nothing " & name)
        ElseIf name = "Hover Hand" Or name = "Alasdair" Then
            Console.Write("You know you want to ;) ")
        Else
            Console.Write("Welcome to Isengard, " & name)
        End If
        Console.ReadLine()
    End Sub

End Module
