Module Module1
    Sub Main()
 
        Dim dec As Double = 0
        Dim length As Integer = Len(Bin)
        Dim denum As Integer = 0
        Dim x As Integer = 0
        Dim Bin as String
        
        For x = 1 To length
            denum = Val(Mid(Bin, length, 1))
            length = length - 1
            If denum <> "0" Then
                dec += (2 ^ (x - 1))
            End If
        Next
       
    Return dec
   
    
      End Function
      
    End Sub 
   
End Module    
