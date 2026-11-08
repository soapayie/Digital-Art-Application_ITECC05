Public Class Form2

    Private Sub artist_button_Click(sender As Object, e As EventArgs) Handles artist_button.Click

        Dim categoryPage As New Form3()
        categoryPage.Show()
        Me.Hide()

    End Sub

    Private Sub buyer_button_Click(sender As Object, e As EventArgs) Handles buyer_button.Click

        Dim categoryPage As New Form3()
        categoryPage.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim categoryPage As New Form1()
        categoryPage.Show()
        Me.Hide()

    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to close the app", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If
    End Sub

End Class