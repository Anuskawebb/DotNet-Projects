<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageStorageForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnDeleteImage = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnAddImage = New System.Windows.Forms.Button()
        Me.btnStoreImage = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(1033, 636)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(126, 37)
        Me.btnLast.TabIndex = 15
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(273, 469)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(107, 47)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnDeleteImage
        '
        Me.btnDeleteImage.Location = New System.Drawing.Point(273, 327)
        Me.btnDeleteImage.Name = "btnDeleteImage"
        Me.btnDeleteImage.Size = New System.Drawing.Size(107, 46)
        Me.btnDeleteImage.TabIndex = 13
        Me.btnDeleteImage.Text = "Delete"
        Me.btnDeleteImage.UseVisualStyleBackColor = True
        '
        'btnUpload
        '
        Me.btnUpload.Location = New System.Drawing.Point(273, 400)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(107, 49)
        Me.btnUpload.TabIndex = 12
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(547, 636)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(138, 37)
        Me.btnFirst.TabIndex = 11
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(273, 257)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(107, 40)
        Me.btnPrevious.TabIndex = 10
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(273, 196)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(107, 43)
        Me.btnNext.TabIndex = 9
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.PictureBox1.Location = New System.Drawing.Point(493, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(704, 563)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(63, 422)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 15
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnAddImage
        '
        Me.btnAddImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAddImage.Location = New System.Drawing.Point(380, 69)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(92, 50)
        Me.btnAddImage.TabIndex = 16
        Me.btnAddImage.Text = "Add"
        Me.btnAddImage.UseVisualStyleBackColor = True
        '
        'btnStoreImage
        '
        Me.btnStoreImage.Location = New System.Drawing.Point(380, 574)
        Me.btnStoreImage.Name = "btnStoreImage"
        Me.btnStoreImage.Size = New System.Drawing.Size(92, 39)
        Me.btnStoreImage.TabIndex = 17
        Me.btnStoreImage.Text = "Store"
        Me.btnStoreImage.UseVisualStyleBackColor = True
        '
        'ImageStorageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1304, 742)
        Me.Controls.Add(Me.btnStoreImage)
        Me.Controls.Add(Me.btnAddImage)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDeleteImage)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ImageStorageForm"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnDeleteImage As System.Windows.Forms.Button
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents btnAddImage As System.Windows.Forms.Button
    Friend WithEvents btnStoreImage As System.Windows.Forms.Button

End Class
