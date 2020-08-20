<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.add_firstname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.add_surname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.add_username = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.add_email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.add_password = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_male = New System.Windows.Forms.RadioButton()
        Me.btn_female = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(331, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add User"
        '
        'add_firstname
        '
        Me.add_firstname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.add_firstname.Location = New System.Drawing.Point(137, 149)
        Me.add_firstname.Name = "add_firstname"
        Me.add_firstname.Size = New System.Drawing.Size(194, 20)
        Me.add_firstname.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Firstname:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Surname:"
        '
        'add_surname
        '
        Me.add_surname.Location = New System.Drawing.Point(419, 149)
        Me.add_surname.Name = "add_surname"
        Me.add_surname.Size = New System.Drawing.Size(194, 20)
        Me.add_surname.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(134, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Username:"
        '
        'add_username
        '
        Me.add_username.ForeColor = System.Drawing.SystemColors.WindowText
        Me.add_username.Location = New System.Drawing.Point(137, 82)
        Me.add_username.Name = "add_username"
        Me.add_username.Size = New System.Drawing.Size(194, 20)
        Me.add_username.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(134, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Email:"
        '
        'add_email
        '
        Me.add_email.ForeColor = System.Drawing.SystemColors.WindowText
        Me.add_email.Location = New System.Drawing.Point(137, 248)
        Me.add_email.Name = "add_email"
        Me.add_email.Size = New System.Drawing.Size(476, 20)
        Me.add_email.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(416, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Password:"
        '
        'add_password
        '
        Me.add_password.ForeColor = System.Drawing.SystemColors.WindowText
        Me.add_password.Location = New System.Drawing.Point(419, 82)
        Me.add_password.Name = "add_password"
        Me.add_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.add_password.Size = New System.Drawing.Size(194, 20)
        Me.add_password.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Lime
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(184, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 50)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Add User"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(419, 304)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 50)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Clear Texts"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Brown
        Me.Button3.Location = New System.Drawing.Point(736, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(36, 34)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "X"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(134, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Gender:"
        '
        'btn_male
        '
        Me.btn_male.AutoSize = True
        Me.btn_male.Checked = True
        Me.btn_male.Location = New System.Drawing.Point(207, 191)
        Me.btn_male.Name = "btn_male"
        Me.btn_male.Size = New System.Drawing.Size(48, 17)
        Me.btn_male.TabIndex = 13
        Me.btn_male.TabStop = True
        Me.btn_male.Text = "Male"
        Me.btn_male.UseVisualStyleBackColor = True
        '
        'btn_female
        '
        Me.btn_female.AutoSize = True
        Me.btn_female.Location = New System.Drawing.Point(272, 191)
        Me.btn_female.Name = "btn_female"
        Me.btn_female.Size = New System.Drawing.Size(59, 17)
        Me.btn_female.TabIndex = 14
        Me.btn_female.Text = "Female"
        Me.btn_female.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_female)
        Me.Controls.Add(Me.btn_male)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.add_password)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.add_email)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.add_username)
        Me.Controls.Add(Me.add_surname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.add_firstname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Register"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents add_firstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents add_surname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents add_username As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents add_email As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents add_password As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents btn_male As RadioButton
    Friend WithEvents btn_female As RadioButton
End Class
