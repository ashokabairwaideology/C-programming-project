Attribute VB_Name = "Module1"

Public Function charcheck(s As String) As Integer
Dim j As Byte
len1 = Len(Trim(s))

For i = 1 To len1

    For j = 96 To 123
       
        If Mid(s, i, 1) = Chr(j) Then
            
            charcheck = 0
            Exit Function
        End If
    Next
    
Next

charcheck = 1

End Function
