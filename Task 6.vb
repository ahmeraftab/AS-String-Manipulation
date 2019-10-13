Module Module1

    Sub Main()
        Dim str1, str2 As String
        Dim chr1, chr2 As Char
        Dim i, x, asc1, asc2, asc3, asc4 As Integer

        str1 = ""
        str2 = ""
        chr1 = ""
        chr2 = ""
        i = 0
        x = 0
        asc1 = 0
        asc2 = 0
        asc3 = 0
        asc4 = 0

        Console.WriteLine("Enter string: ")
        str1 = Console.ReadLine

        Console.WriteLine("Enter another string: ")
        str2 = Console.ReadLine

        For i = 1 To Len(str1)
            chr1 = Mid((UCase(str1)), i, 1)
            asc1 = Asc(chr1)
            asc2 = asc2 + asc1
        Next
        For x = 1 To Len(str2)
            chr2 = Mid(UCase((str2)), x, 1)
            asc3 = Asc(chr2)
            asc4 = asc4 + asc3
        Next

        If asc2 = asc4 Then
            Console.WriteLine("This is an anagram.")
        Else
            Console.WriteLine("This is not an anagram.")
        End If
        Console.ReadKey()
    End Sub

End Module
