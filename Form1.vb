Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tabIndexToRedirect As Integer = 3
        If tabIndexToRedirect >= 0 AndAlso tabIndexToRedirect < TabControl1.TabCount Then
            TabControl1.SelectedIndex = tabIndexToRedirect
        Else
            MessageBox.Show("Invalid tab index specified.")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("YOUR LOGIN WAS SUCCESFULL THANK YOU " & TextBox1.Text)
        Dim tabIndexToRedirect2 As Integer = 1
        If tabIndexToRedirect2 >= 0 AndAlso tabIndexToRedirect2 < TabControl1.TabCount Then
            TabControl1.SelectedIndex = tabIndexToRedirect2
        Else
            MessageBox.Show("Invalid tab index specified.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("PLEASE LOGIN")
        Dim tabIndexToRedirect3 As Integer = 2
        If tabIndexToRedirect3 >= 0 AndAlso tabIndexToRedirect3 < TabControl1.TabCount Then
            TabControl1.SelectedIndex = tabIndexToRedirect3
        Else
            MessageBox.Show("Invalid tab index specified.")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Add("VIVO X100: 599$")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Add("SAMSUNG S23: 799$")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListBox1.Items.Add("S24 ULTRA: 1399$")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ListBox1.Items.Add("IPHONE 15 PRO MAX: 1499$")
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ListBox1.Items.Add("ONEPLUS 12: 499$")
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        MsgBox("YOUR ORDER WAS PLACED! ")
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Close()
    End Sub
End Class
