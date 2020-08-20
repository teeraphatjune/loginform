Imports MySql.Data.MySqlClient
Public Class Register

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles add_firstname.Leave

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles add_firstname.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Public Function usernameExist(ByVal username As String) As Boolean
        Dim con As New MY_CONNECTION()

        Dim command As New MySqlCommand("SELECT * FROM `sys_users` WHERE `username` = @usn", con.getConnection())
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
        Dim adapter As New MySqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count > 0 Then

            Return True
        Else

            Return False

        End If

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim rad_gender As String = ""
        Dim fname As String = add_firstname.Text
        Dim sname As String = add_surname.Text
        Dim email As String = add_email.Text
        Dim username As String = add_username.Text
        Dim password As String = EncodeBase64(add_password.Text.Trim())
        Dim enable As String = "1"


        If String.IsNullOrEmpty(fname) Or String.IsNullOrEmpty(sname) Or
            String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(username) Or
            String.IsNullOrEmpty(password) Then

            MsgBox("Empty Fields")

        ElseIf usernameExist(username) Then

            MsgBox("Username Already Use")
        Else

            If btn_male.Checked = True Then
                rad_gender = "male"
            ElseIf btn_female.Checked = True Then
                rad_gender = "female"
            End If
            Dim conn As New MY_CONNECTION()
            Dim command As New MySqlCommand("INSERT INTO sys_users(`username`, `password`, `firstname`, `lastname`, `email`, enable, gender) 
            VALUES (@usn, @pass, @fname, @sname, @mail,@enable,@gender )", conn.getConnection)

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname
            command.Parameters.Add("@sname", MySqlDbType.VarChar).Value = sname
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = email
            command.Parameters.Add("@enable", MySqlDbType.VarChar).Value = enable
            command.Parameters.Add("@gender", MySqlDbType.VarChar).Value = rad_gender


            conn.openConnection()

            If command.ExecuteNonQuery() = 1 Then
                MsgBox("User Inserted")
                conn.closeConnection()
            Else
                MsgBox("User Not Inserted")
                conn.closeConnection()
            End If


        End If




    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each Control As Control In Me.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = String.Empty
            End If
        Next



    End Sub

    Private Sub add_username_TextChanged(sender As Object, e As EventArgs) Handles add_username.TextChanged

    End Sub

    Private Sub add_password_TextChanged(sender As Object, e As EventArgs) Handles add_password.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Public Function EncodeBase64(input As String) As String
        Return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(input))
    End Function

    Public Function DecodeBase64(input As String) As String
        Return System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input))
    End Function

    Private Sub btn_male_CheckedChanged(sender As Object, e As EventArgs) Handles btn_male.CheckedChanged

    End Sub

    Private Sub btn_female_CheckedChanged(sender As Object, e As EventArgs) Handles btn_female.CheckedChanged

    End Sub
End Class