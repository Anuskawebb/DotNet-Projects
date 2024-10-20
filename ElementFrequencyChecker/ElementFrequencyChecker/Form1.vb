
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim elements As List(Of Integer) = GetElements()
        Dim searchElement As Integer
        If Integer.TryParse(TextBox2.Text, searchElement) Then
            If elements.Contains(searchElement) Then
                Label1.Text = $"{searchElement} is present in the list."
            Else
                Label1.Text = $"{searchElement} is not present in the list."
            End If
        Else
            Label1.Text = "Please enter a valid number in TextBox2."
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim elements As List(Of Integer) = GetElements()
        Dim searchElement As Integer
        If Integer.TryParse(TextBox2.Text, searchElement) Then
            Dim frequency As Integer = elements.Count(Function(x) x = searchElement)
            Label1.Text = $"Frequency of {searchElement}: {frequency}."
        Else
            Label1.Text = "Please enter a valid number in TextBox2."
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim elements As List(Of Integer) = GetElements()
        If elements.Count > 0 Then
            Dim maxElement As Integer = elements.Max()
            Label1.Text = $"Maximum element: {maxElement}."
        Else
            Label1.Text = "The list is empty."
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim elements As List(Of Integer) = GetElements()
        If elements.Count > 0 Then
            Dim sum As Integer = elements.Sum()
            Label1.Text = $"Sum of elements: {sum}."
        Else
            Label1.Text = "The list is empty."
        End If
    End Sub

    Private Function GetElements() As List(Of Integer)
        Dim elements As New List(Of Integer)()
        Dim input As String = TextBox1.Text
        If Not String.IsNullOrWhiteSpace(input) Then
            Dim elementStrings As String() = input.Split(","c)
            For Each str As String In elementStrings
                Dim number As Integer
                If Integer.TryParse(str.Trim(), number) Then
                    elements.Add(number)
                End If
            Next
        End If
        Return elements
    End Function
End Class
