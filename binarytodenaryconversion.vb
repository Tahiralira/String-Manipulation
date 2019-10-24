Module Module1

  

    Sub Main()
        Dim Binarynumber(7) As Char 'to make it an array '
        Const Bite As Integer = 128
        Dim Answer As Integer
        Dim Column As Integer
        Dim Bit As Integer
        Dim BitNumber As Integer
        Dim validbinarystring As Boolean
        Dim bitlen As Integer
        Dim count As Integer = 0
        Dim let1 As Integer = 0




        Column = Bite
        BitNumber = 0
        Answer = 0
        Do
            BitNumber = BitNumber + 1
            Console.Write("Bit number {0}: ", BitNumber)
            Bit = Console.ReadLine()
            Binarynumber(BitNumber - 1) = CChar(CStr(Bit))
            Answer = Answer + (Column * Bit)
            Column = (Column / 2)
            validbinarystring = True
            bitlen = Len(BitNumber)

            Do

                For count = 1 To Len(BitNumber)
                    let1 = Val(Mid(BitNumber, count, 1))
                    If let1 > 1 Or let1 < 0 Then
                        validbinarystring = False
                    Else : validbinarystring = True
                    End If
                Next

                If bitlen > 8 Or bitlen < 1 Then
                    validbinarystring = False
                End If


                If validbinarystring = False Then
                    Console.WriteLine("Not a valid binary number.....")
                End If
            Loop Until validbinarystring = True

        Loop Until Column < 1
        Console.WriteLine("Denary Value is: " & Answer)
        Console.WriteLine()



        Console.ReadKey()


    End Sub
    

End Module