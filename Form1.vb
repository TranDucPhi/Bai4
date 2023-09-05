Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim soducan As New Integer
        Dim soduchi As New Integer
        Dim nam As Integer
        nam = Integer.Parse(txtdl.Text)
        Dim can As String
        can = " "
        soducan = (nam - 3) Mod 10
        Select Case soducan
            Case 0
                can = "Quý"
            Case 1
                can = "Giáp"
            Case 2
                can = "Ất"
            Case 3
                can = "Bính"
            Case 4
                can = "Đinh"
            Case 5
                can = "Giáp"
            Case 6
                can = "Ất"
            Case 7
                can = "Canh"
            Case 8
                can = "Tân"
            Case 9
                can = "Nhâm"
        End Select
        Dim chi As String
        chi = " "
        soduchi = (nam - 3) Mod 12
        Select Case soduchi
            Case 0
                chi = "Hợi"
            Case 1
                chi = "Tý"
            Case 2
                chi = "Sửu"
            Case 3
                chi = "Dần"
            Case 4
                chi = "Mão"
            Case 5
                chi = "Thìn"
            Case 6
                chi = "Tỵ"
            Case 7
                chi = "Ngọ"
            Case 8
                chi = "Mùi"
            Case 9
                chi = "Thân"
            Case 10
                chi = "Dậu"
            Case 11
                chi = "Tuất"
        End Select
        txtal.Text = can & " " & chi
    End Sub
End Class
