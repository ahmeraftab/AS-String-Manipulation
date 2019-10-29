Module Module1

    Sub Main()
        Dim str1 As String = ""
        Dim x, str2 As Integer
        Dim validBinaryString As Boolean = True

        x = 0
        str2 = 0

        Console.WriteLine("Enter Binary Number: ")
        str1 = Console.ReadLine

        If Len(str1) > 0 And Len(str1) < 9 Then
            validBinaryString = True
        Else
            validBinaryString = False
        End If

        If validBinaryString = True Then
            For x = 1 To Len(str1)
                str2 = Mid(str1, x, 1)
                If str2 < 0 Or str2 > 1 Then
                    validBinaryString = False
                    Exit For
                End If
            Next

        End If
        If validBinaryString = False Then
            Console.WriteLine("Not a valid binary number...")
            Console.ReadKey()
        ElseIf validBinaryString = True Then
            Console.WriteLine("It is a binary number")
            Console.ReadKey()
        End If
    End Sub

End Module
