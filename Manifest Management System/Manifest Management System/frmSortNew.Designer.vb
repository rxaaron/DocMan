<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSortNew
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
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.listFiles = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pdfViewer = New System.Windows.Forms.WebBrowser()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(231, 13)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'listFiles
        '
        Me.listFiles.Activation = System.Windows.Forms.ItemActivation.TwoClick
        Me.listFiles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.listFiles.FullRowSelect = True
        Me.listFiles.HideSelection = False
        Me.listFiles.Location = New System.Drawing.Point(12, 12)
        Me.listFiles.MultiSelect = False
        Me.listFiles.Name = "listFiles"
        Me.listFiles.Size = New System.Drawing.Size(213, 764)
        Me.listFiles.TabIndex = 2
        Me.listFiles.UseCompatibleStateImageBehavior = False
        Me.listFiles.View = System.Windows.Forms.View.List
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 100
        '
        'pdfViewer
        '
        Me.pdfViewer.Location = New System.Drawing.Point(331, 72)
        Me.pdfViewer.MinimumSize = New System.Drawing.Size(20, 20)
        Me.pdfViewer.Name = "pdfViewer"
        Me.pdfViewer.Size = New System.Drawing.Size(968, 685)
        Me.pdfViewer.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(541, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(737, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(737, 38)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 5
        '
        'frmSortNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 788)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pdfViewer)
        Me.Controls.Add(Me.listFiles)
        Me.Controls.Add(Me.btnRefresh)
        Me.Name = "frmSortNew"
        Me.ShowIcon = False
        Me.Text = "Manifest Sorter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRefresh As Button
    Friend WithEvents listFiles As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents pdfViewer As WebBrowser
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
