Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, b As Integer
        Dim z, x As String
        a = NumericUpDown1.Text
        b = NumericUpDown2.Text

        z = a + 110
       
        If b < z Then
            x = "ไม่ผ่าน"
        ElseIf b >= z Then
            x = "ผ่าน"
        End If
        TextBox3.Text = x

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        NumericUpDown1.Text = ""
        NumericUpDown2.Text = ""
        TextBox3.Text = ""

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

End Class
