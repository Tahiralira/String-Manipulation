Module Module1

    Sub Main()
        Dim NewString, NextChar As String
        Dim Index As Integer 
        Dim AfterSpace As Boolean
    



        Space = " "
        AfterSpace = False
        NewString = ""


        Console.Write("Enter New String: ")
        Instring = Console.ReadLine

        For Index = 1 To Len(Instring)
            NextChar = (Mid(Instring, Index, 1))

            If AfterSpace = True Then
                If NextChar <> Space Then
                    NewString = NewString & NextChar
                    AfterSpace = False
                End If
            Else
                NewString = NewString & NextChar
                If NextChar = Space Then
                    AfterSpace = True
                End If
            End If
        Next
        Console.WriteLine(NewString)

        Console.ReadKey()
    End Sub

End Module
