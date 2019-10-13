Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim i As Integer
        Dim chr As Char

        str1 = ""
        str2 = ""
        i = 0
        chr = ""

        Console.WriteLine("Enter a String: ")
        str1 = Console.ReadLine

        For i = Len(str1) To 1 Step -1
            chr = Mid(str1, i, 1)
            str2 = str2 & chr
        Next
        Console.WriteLine(LCase(str2))
        Console.ReadKey()

    End Sub

End Module
