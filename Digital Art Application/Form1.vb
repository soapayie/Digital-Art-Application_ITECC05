
Imports System.Windows
Imports MySql.Data.MySqlClient

Public Class Form1

    ' MySQL Connection
    Private connectionString As String =
        "Server=localhost;Port=3306;Database=digital_art_comms;Uid=root;Pwd=;"

    ' Hide Password Characters
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        password_txtbox.UseSystemPasswordChar = True

    End Sub

    Private Sub login_button_Click(sender As Object, e As EventArgs) Handles login_button.Click

        ' Validate empty fields
        If username_txtbox.Text.Trim() = "" OrElse password_txtbox.Text = "" Then

            MessageBox.Show("Please enter your username and password.",
                            "Missing Information",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            Return

        End If

        Try

            ' Connect to MySQL Database
            Using MysqlConn As New MySqlConnection(connectionString)

                MysqlConn.Open()

                ' SQL Login Query
                Dim Query As String =
                    "SELECT COUNT(*) FROM users " &
                    "WHERE user_name = @username " &
                    "AND password = @password"

                Using COMMAND As New MySqlCommand(Query, MysqlConn)

                    ' Add Parameters
                    COMMAND.Parameters.AddWithValue(
                        "@username",
                        username_txtbox.Text.Trim()
                    )

                    COMMAND.Parameters.AddWithValue(
                        "@password",
                        password_txtbox.Text
                    )

                    ' Execute Query
                    Dim count As Integer =
                        Convert.ToInt32(COMMAND.ExecuteScalar())

                    ' Check Login Credentials
                    If count = 1 Then

                        MessageBox.Show("Login Successful!",
                                        "Welcome",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)

                        ' Open Form2
                        Form2.Show()

                        ' Hide Login Form
                        Me.Hide()

                    Else

                        MessageBox.Show("Invalid Username or Password.",
                                        "Login Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)

                        password_txtbox.Clear()
                        password_txtbox.Focus()

                    End If

                End Using

            End Using

        Catch ex As Exception

            MessageBox.Show("Database Connection Error: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End Try

    End Sub

End Class
