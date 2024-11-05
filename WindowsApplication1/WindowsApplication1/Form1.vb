Public Class ScientificCalculator
    Dim result As Double
    Dim operation As String
    Dim isOperationPerformed As Boolean = False
    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        If txtDisplay.Text = "0" Or isOperationPerformed Then
            txtDisplay.Clear()
        End If
        isOperationPerformed = False
        Dim button As Button = CType(sender, Button)
        txtDisplay.Text += button.Text
    End Sub

    Private Sub btnOperator_Click(sender As Object, e As EventArgs) Handles btnAdd.Click, btnSubtract.Click, btnMultiply.Click, btnDivide.Click
        Dim button As Button = CType(sender, Button)
        operation = button.Text
        result = Double.Parse(txtDisplay.Text)
        isOperationPerformed = True
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Select Case operation
            Case "+"
                txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString()
            Case "-"
                txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString()
            Case "*"
                txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString()
            Case "/"
                txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString()
        End Select
        operation = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDisplay.Text = "0"
        result = 0
        operation = ""
    End Sub
    Private Sub btnSin_Click(sender As Object, e As EventArgs) Handles btnSin.Click
        txtDisplay.Text = Math.Sin(Double.Parse(txtDisplay.Text)).ToString()
    End Sub

    Private Sub btnCos_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        txtDisplay.Text = Math.Cos(Double.Parse(txtDisplay.Text)).ToString()
    End Sub

    Private Sub btnTan_Click(sender As Object, e As EventArgs) Handles btnTan.Click
        txtDisplay.Text = Math.Tan(Double.Parse(txtDisplay.Text)).ToString()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        txtDisplay.Text = Math.Log(Double.Parse(txtDisplay.Text)).ToString()
    End Sub

    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        txtDisplay.Text = Math.Sqrt(Double.Parse(txtDisplay.Text)).ToString()
    End Sub