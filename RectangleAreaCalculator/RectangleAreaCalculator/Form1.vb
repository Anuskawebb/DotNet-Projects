Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim length As Double = Val(txtLength.Text)
        Dim width As Double = Val(txtWidth.Text)
        Dim area As Double = length * width

        MessageBox.Show("The area of the rectangle is: " & area.ToString())
    End Sub
End Class

