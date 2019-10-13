Module Module1

    Sub Main()
        Dim mystr, newstr As String
        Dim x, y As Integer

        mystr = ""
        newstr = ""
        x = 0
        y = 0

        Console.WriteLine("Enter a 3 word phrase: ")
        mystr = Console.ReadLine

        x = InStr(mystr, " ")
        y = InStr(x + 1, mystr, " ")
        newstr = Mid(mystr, x + 1, y - x - 1)

        Console.WriteLine("The Middle Word is: " & newstr)
        Console.ReadKey()
    End Sub

End Module
