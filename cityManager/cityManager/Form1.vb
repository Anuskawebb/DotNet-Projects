Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtCity.Text <> "" Then
            lstCities.Items.Add(txtCity.Text)
            txtCity.Clear()
        End If
    End Sub

    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        MessageBox.Show("Number of cities: " & lstCities.Items.Count.ToString())
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim cities As String = String.Join(Environment.NewLine, lstCities.Items.Cast(Of String)())
        MessageBox.Show(cities)
    End Sub

    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnSort.Click
        Dim sortedCities = lstCities.Items.Cast(Of String)().OrderBy(Function(c) c).ToList()
        lstCities.Items.Clear()
        For Each city In sortedCities
            lstCities.Items.Add(city)
        Next
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If lstCities.SelectedIndex <> -1 Then
            lstCities.Items.RemoveAt(lstCities.SelectedIndex)
        End If
    End Sub
End Class

