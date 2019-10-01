Module Module1

    Sub Main()
        Dim Str1, NewChar As String
        Dim Counter, Alphcount, Numcount As Integer

        Str1 = ""
        NewChar = ""
        Counter = 0
        Alphcount = 0
        Numcount = 0

        Console.Write("Input String: ")
        Str1 = Console.ReadLine

        For Counter = 1 To Len(Str1)
            NewChar = Mid(Str1, Counter, 1)
            If LCase(NewChar) < "a" Or LCase(NewChar) > "z" Then
                Numcount = Numcount + 1

            End If
        Next

        Console.WriteLine(Alphcount)
        Console.WriteLine(Numcount)
        Console.ReadKey()



    End Sub

End Module
