Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = (GeneratePassword(True, True, False, False, 16))
    End Sub
    Public Function GeneratePassword(ByVal Uppers As Boolean, ByVal Lowers As Boolean, ByVal Numbers As Boolean, ByVal Specials As Boolean, ByVal passwordLength As Integer) As String
        Dim H As String = ""
        Dim Black As String = ""

        If Uppers Then
            H = (H & "ūĪūīŪūĒĪīūēē◥꧁ŪĒūūūūĒŪĒĒདŪ★彡◥꧁དĪēēēĒŪĒūūūĪĪŪĒū℟꧂Åℤ¥ēĒĒēūŪŪēĒŪ༒₭ÏḼḼ℥īēĪī℟ŪĒ")
        End If

        VBMath.Randomize()
        Dim num2 As Integer = (passwordLength - 1)
        Dim i As Integer = 0
        Do While (i <= num2)
            Black = (Black & Strings.Mid(H, CInt(Math.Round(CDbl(((Strings.Len(H) * VBMath.Rnd) + 1.0!)))), 1))
            i += 1
        Loop
        Return Black
    End Function
End Class