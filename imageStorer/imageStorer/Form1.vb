Imports System.IO
Imports System.Runtime.InteropServices
Imports Microsoft.Office.Interop.Excel

Public Class ImageStorageForm
    Dim excelApp As Application
    Dim workBook As Workbook
    Dim workSheet As Worksheet
    Dim currentImageIndex As Integer = -1
    Dim imageList As New List(Of String)
    Dim excelFilePath As String = "C:\Users\anusk\OneDrive\Desktop\,NET projects\Image.xlsx" ' Ensure this path is valid

    Private Sub ImageStorageForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        InitializeExcel()
        LoadImagePathsFromExcel() ' Load existing image paths from Excel on startup
    End Sub

    Private Sub LoadImagePathsFromExcel()
        Try
            ' Open the existing Excel file to read saved image paths
            If File.Exists(excelFilePath) Then
                workBook = excelApp.Workbooks.Open(excelFilePath)
                workSheet = CType(workBook.Worksheets(1), Worksheet)

                ' Iterate over rows in the Excel file starting from the second row (to skip headers)
                Dim rowIndex As Integer = 2
                While workSheet.Cells(rowIndex, 1).Value IsNot Nothing
                    Dim imagePath As String = workSheet.Cells(rowIndex, 1).Value.ToString()
                    imageList.Add(imagePath) ' Add each image path to imageList
                    rowIndex += 1
                End While
            End If
        Catch ex As Exception
            ' Handle errors (e.g., Excel file not found or other issues)
        End Try
    End Sub



    Private Sub InitializeExcel()
        Try
            excelApp = New Application
            excelApp.Visible = True ' Set Excel to visible for debugging
            workBook = excelApp.Workbooks.Add()
            workSheet = CType(workBook.Worksheets(1), Worksheet)
            workSheet.Cells(1, 1) = "ImagePath" ' Header for the image paths
        Catch ex As Exception
            ' Handle any errors without showing message boxes
        End Try
    End Sub

    Private Sub btnAddImage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddImage.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Select an Image"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim imagePath As String = openFileDialog.FileName
                DisplayImage(imagePath)
            End If
        End Using
    End Sub

    Private Sub DisplayImage(ByVal imagePath As String)
        If File.Exists(imagePath) Then
            PictureBox1.Image = Image.FromFile(imagePath)
            currentImageIndex = imageList.IndexOf(imagePath)
            If currentImageIndex = -1 Then
                imageList.Add(imagePath) ' Add to the list if it's a new image
            End If
        End If
    End Sub

    Private Sub btnStoreImage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnStoreImage.Click
        If currentImageIndex >= 0 Then
            Dim imagePath As String = imageList(currentImageIndex)
            SaveImagePathToExcel(imagePath)
        End If
    End Sub

    Private Sub SaveImagePathToExcel(ByVal imagePath As String)
        Try
            ' Use row 2 for storing image paths and pictures
            Dim rowIndex As Integer = 2

            ' Find the next available column in the specified row
            Dim colIndex As Integer = workSheet.UsedRange.Columns.Count + 1

            ' Add the image path in the new column
            workSheet.Cells(rowIndex, colIndex).Value = "Image " & colIndex - 1 & ": " & imagePath

            ' Get the position of the target cell in the specified row and new column
            Dim targetCell As Range = workSheet.Cells(rowIndex + 1, colIndex) ' Adjust row for image placement
            Dim left As Double = targetCell.Left
            Dim top As Double = targetCell.Top
            Dim width As Double = targetCell.Width
            Dim height As Double = targetCell.Height

            ' Add the picture in the next column, resizing it to fit within the cell
            Dim picture = workSheet.Shapes.AddPicture(imagePath, _
                                                      Microsoft.Office.Core.MsoTriState.msoFalse, _
                                                      Microsoft.Office.Core.MsoTriState.msoCTrue, _
                                                      left, top, width, height)

            ' Adjust the picture to center it within the cell if it doesn't fully fit
            picture.LockAspectRatio = Microsoft.Office.Core.MsoTriState.msoTrue
            If picture.Width > width Or picture.Height > height Then
                ' Scale the picture to fit within cell dimensions
                picture.Width = width * 0.9
                picture.Height = height * 0.9
                ' Center the image within the cell
                picture.Left = left + (width - picture.Width) / 2
                picture.Top = top + (height - picture.Height) / 2
            End If

        Catch ex As Exception
            ' Optional: Handle exceptions if necessary
        End Try
    End Sub




    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        If currentImageIndex < imageList.Count - 1 Then
            currentImageIndex += 1
            DisplayImage(imageList(currentImageIndex))
        End If
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        If currentImageIndex > 0 Then
            currentImageIndex -= 1
            DisplayImage(imageList(currentImageIndex))
        End If
    End Sub

    Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
        If imageList.Count > 0 Then
            currentImageIndex = 0
            DisplayImage(imageList(currentImageIndex)) ' Display the first image in the list
        Else
            MessageBox.Show("No images found in the list.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
        If imageList.Count > 0 Then
            currentImageIndex = imageList.Count - 1
            DisplayImage(imageList(currentImageIndex))
        End If
    End Sub

    Private Sub btnDeleteImage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeleteImage.Click
        If currentImageIndex >= 0 AndAlso currentImageIndex < imageList.Count Then
            ' Remove the current image from the list
            imageList.RemoveAt(currentImageIndex)

            ' Adjust currentImageIndex
            If currentImageIndex >= imageList.Count Then
                currentImageIndex = imageList.Count - 1
            End If

            ' Display the next image or clear the PictureBox if the list is empty
            If currentImageIndex >= 0 Then
                DisplayImage(imageList(currentImageIndex))
            Else
                PictureBox1.Image = Nothing
            End If
        End If
    End Sub

    Private Sub btnPrintImage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrint.Click
        If PictureBox1.Image IsNot Nothing Then
            Dim printDialog As New PrintDialog()
            If printDialog.ShowDialog() = DialogResult.OK Then
                ' Implement printing logic here
            End If
        End If
    End Sub

    Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
        Try
            workBook.SaveAs(excelFilePath) ' Save the workbook at the specified path
        Catch ex As Exception
            ' Handle any errors without showing message boxes
        Finally
            ' Ensure Excel application is closed properly
            workBook.Close(False)
            excelApp.Quit()
            Marshal.ReleaseComObject(workSheet)
            Marshal.ReleaseComObject(workBook)
            Marshal.ReleaseComObject(excelApp)
        End Try
    End Sub
End Class
