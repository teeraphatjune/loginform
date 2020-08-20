Imports MySql.Data.MySqlClient

Public Class Login

    Dim connection As New MySqlConnection("datasource=localhost; port=3306; username=root; password=12345678; database=test")

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_LOGIN.Click
        Dim en_password = EncodeBase64(box_password.Text.Trim())
        Dim command As New MySqlCommand("SELECT * FROM `sys_users` WHERE username = @username AND password = @password", connection)

        command.Parameters.Add("@username", MySqlDbType.VarChar).Value = box_username.Text.Trim()
        command.Parameters.Add("@password", MySqlDbType.VarChar).Value = en_password

        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)



        If table.Rows.Count = 0 Then
            MessageBox.Show("Invalid Username Or Password")

        Else

            MessageBox.Show("Logged In")
            Dim home As New Register()
            home.Show()
            Me.Hide()

        End If


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTN_Cancel.Click
        Me.Close()

    End Sub

    Private Sub box_username_Enter(sender As Object, e As EventArgs) Handles box_username.Enter
        Dim username As String = box_username.Text

        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            box_username.Text = ""
            box_username.ForeColor = Color.Black

        End If
    End Sub

    Private Sub box_username_Leave(sender As Object, e As EventArgs) Handles box_username.Leave
        Dim username As String = box_username.Text

        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            box_username.Text = "Username"
            box_username.ForeColor = Color.Gray

        End If
    End Sub

    Private Sub box_password_Enter(sender As Object, e As EventArgs) Handles box_password.Enter
        Dim password As String = box_password.Text

        If password.Trim().ToLower() = "password" Or password.Trim() = "" Then
            box_password.Text = ""
            box_password.ForeColor = Color.Black
            box_password.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub box_password_Leave(sender As Object, e As EventArgs) Handles box_password.Leave
        Dim password As String = box_password.Text

        If password.Trim().ToLower() = "password" Or password.Trim() = "" Then
            box_password.Text = "password"
            box_password.ForeColor = Color.Gray
            box_password.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim encodetest = EncodeBase64(box_password.Text.Trim())
        Dim decodetest = DecodeBase64(encodetest.Trim())
        MsgBox(encodetest)
        MsgBox(decodetest)
    End Sub


    Public Function EncodeBase64(input As String) As String
        Return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input))
    End Function

    Public Function DecodeBase64(input As String) As String
        Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input))
    End Function

End Class
