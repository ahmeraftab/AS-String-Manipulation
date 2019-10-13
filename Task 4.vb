Module Module1

    Sub Main()
        Dim str1, str2, char1, char2 As String
        Dim index As Integer

        str1 = ""
        str2 = ""
        char1 = ""
        char2 = ""
        index = 0

        Console.WriteLine("Enter a string: ")
        str1 = Console.ReadLine

        Console.WriteLine("Enter character to remove: ")
        char1 = Console.ReadLine

        For index = 1 To Len(str1)
            char2 = Mid(str1, index, 1)
            If char2 <> char1 Then
                str2 = str2 & char2
            End If
        Next

        Console.WriteLine(str2)
        Console.ReadKey()

    End Sub

End Module
