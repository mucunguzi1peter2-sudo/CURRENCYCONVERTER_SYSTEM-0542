Public Class Form1
    Private Sub lblPassward_Click(sender As Object, e As EventArgs) Handles lblPassward.Click

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Username As String
        Dim Password As String
        Username = txtUser.Text
        Password = txtPass.Text
        If Username = "" Or Password = "" Then

            MessageBox.Show("Please enter username and password.",
                            "Login",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

        ElseIf Username = "admin" And password = "1234" Then

            MessageBox.Show("Login successful!",
                            "Login",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        Else

            MessageBox.Show("Invalid username or password.",
                            "Login Failed",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUser.Clear()
        txtPass.Clear()
        txtUser.Focus()
    End Sub
End Class
