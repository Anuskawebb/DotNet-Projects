Public Class Form1

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
       Dim feet1 As Integer = Val(txtFeet1.Text)
        Dim inches1 As Integer = Val(txtInches1.Text)
        Dim feet2 As Integer = Val(txtFeet2.Text)
        Dim inches2 As Integer = Val(txtInches2.Text)

        Dim totalInches As Integer = inches1 + inches2
        Dim totalFeet As Integer = feet1 + feet2 + (totalInches \ 12)
        totalInches = totalInches Mod 12

        txtResultFeet.Text = totalFeet.ToString()
        txtResultInches.Text = totalInches.ToString()
    End Sub
End Class
