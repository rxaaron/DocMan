<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmParse
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.fbdOldFiles = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnFileBrowse = New System.Windows.Forms.Button()
        Me.btnParseNames = New System.Windows.Forms.Button()
        Me.txtErrors = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'fbdOldFiles
        '
        Me.fbdOldFiles.ShowNewFolderButton = False
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(12, 12)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(458, 20)
        Me.txtFilePath.TabIndex = 1
        '
        'btnFileBrowse
        '
        Me.btnFileBrowse.Location = New System.Drawing.Point(476, 12)
        Me.btnFileBrowse.Name = "btnFileBrowse"
        Me.btnFileBrowse.Size = New System.Drawing.Size(132, 23)
        Me.btnFileBrowse.TabIndex = 2
        Me.btnFileBrowse.Text = "Select Folder"
        Me.btnFileBrowse.UseVisualStyleBackColor = True
        '
        'btnParseNames
        '
        Me.btnParseNames.Location = New System.Drawing.Point(1192, 9)
        Me.btnParseNames.Name = "btnParseNames"
        Me.btnParseNames.Size = New System.Drawing.Size(75, 23)
        Me.btnParseNames.TabIndex = 3
        Me.btnParseNames.Text = "Parse Names"
        Me.btnParseNames.UseVisualStyleBackColor = True
        '
        'txtErrors
        '
        Me.txtErrors.Location = New System.Drawing.Point(13, 39)
        Me.txtErrors.Name = "txtErrors"
        Me.txtErrors.Size = New System.Drawing.Size(595, 683)
        Me.txtErrors.TabIndex = 4
        Me.txtErrors.Text = ""
        '
        'frmParse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 731)
        Me.Controls.Add(Me.txtErrors)
        Me.Controls.Add(Me.btnParseNames)
        Me.Controls.Add(Me.btnFileBrowse)
        Me.Controls.Add(Me.txtFilePath)
        Me.Name = "frmParse"
        Me.ShowIcon = False
        Me.Text = "Old File Sorter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents fbdOldFiles As FolderBrowserDialog
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btnFileBrowse As Button
    Friend WithEvents btnParseNames As Button
    Friend WithEvents txtErrors As RichTextBox
End Class
