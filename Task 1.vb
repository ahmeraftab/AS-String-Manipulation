Module Module1

    Sub Main()
        Dim A1, A2, FN, LN As String
        Dim x As Integer

        A1 = ""
        A2 = ""
        FN = ""
        LN = ""
        x = 0

        Console.WriteLine("Enter a name: ")
        A1 = Console.ReadLine

        Console.WriteLine("Enter another name: ")
        A2 = Console.ReadLine

        x = InStr(A1, " ")
        FN = Left(A1, x - 1)

        x = InStr(A2, " ")
        LN = Right(A2, Len(A2) - x)

        Console.WriteLine(FN & " " & LN)
        Console.ReadKey()

    End Sub

End Module
