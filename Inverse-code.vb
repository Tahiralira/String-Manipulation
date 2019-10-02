Module Module1

    Sub Main()

        Dim count As Integer
        Dim Cont1, alph1, Str1, Str2 As String


        Str1 = ""
        Str2 = ""
        Cont1 = ""
        alph1 = ""
        count = 0


        Console.Write("Input your String: ")
        Str1 = Console.ReadLine

        For count = Len(Str1) To 1 Step -1
            alph1 = Mid(Str1, count, 1)
            Str2 = Str2 & alph1
        Next

        Console.WriteLine(Str2)
        Console.WriteLine(" ")


        Console.ReadKey()

    End Sub

End Module
