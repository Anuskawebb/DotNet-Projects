Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Fill the ComboBox with sample items
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Apple")
        ComboBox1.Items.Add("Banana")
        ComboBox1.Items.Add("Cherry")
        ComboBox1.Items.Add("Date")
        ComboBox1.Items.Add("Grape")
        ComboBox1.Items.Add("Mango")
        ComboBox1.Items.Add("Orange")
        ComboBox1.Items.Add("Peach")
        ComboBox1.Items.Add("Pear")
        ComboBox1.Items.Add("Pineapple")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Add selected item from ComboBox to ListBox
        If ComboBox1.SelectedItem IsNot Nothing Then
            ListBox1.Items.Add(ComboBox1.SelectedItem)
        Else
            MessageBox.Show("Please select an item from the ComboBox.")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Sort the items in ListBox
        Dim items As New List(Of String)

        For Each item In ListBox1.Items
            items.Add(item.ToString())
        Next

        items.Sort()
        ListBox1.Items.Clear()

        For Each item In items
            ListBox1.Items.Add(item)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Clear the ComboBox and ListBox
        ComboBox1.Items.Clear()
        ListBox1.Items.Clear()
    End Sub
End Class
