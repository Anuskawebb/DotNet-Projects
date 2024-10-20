<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lstCities = New System.Windows.Forms.ListBox()
        Me.btnCount = New System.Windows.Forms.Button()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstCities
        '
        Me.lstCities.FormattingEnabled = True
        Me.lstCities.ItemHeight = 16
        Me.lstCities.Location = New System.Drawing.Point(319, 144)
        Me.lstCities.Name = "lstCities"
        Me.lstCities.Size = New System.Drawing.Size(143, 244)
        Me.lstCities.TabIndex = 0
        '
        'btnCount
        '
        Me.btnCount.Location = New System.Drawing.Point(36, 144)
        Me.btnCount.Name = "btnCount"
        Me.btnCount.Size = New System.Drawing.Size(100, 41)
        Me.btnCount.TabIndex = 1
        Me.btnCount.Text = "Count Cities"
        Me.btnCount.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(168, 144)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(100, 41)
        Me.btnDisplay.TabIndex = 2
        Me.btnDisplay.Text = "Display Cities"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(36, 207)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(100, 41)
        Me.btnSort.TabIndex = 3
        Me.btnSort.Text = "Sort Cities"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(168, 207)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(100, 41)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove Selected"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(463, 46)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 41)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add Cities"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(300, 55)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(141, 22)
        Me.txtCity.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(217, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "City :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 449)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnCount)
        Me.Controls.Add(Me.lstCities)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstCities As System.Windows.Forms.ListBox
    Friend WithEvents btnCount As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents btnSort As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
