<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblTitle = New Label()
        btnSelectFolder = New Button()
        txtFolderPath = New TextBox()
        listViewFiles = New ListView()
        btnOrganize = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(132, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(209, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Organize Files by Type"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnSelectFolder
        ' 
        btnSelectFolder.Location = New Point(12, 52)
        btnSelectFolder.Name = "btnSelectFolder"
        btnSelectFolder.Size = New Size(75, 23)
        btnSelectFolder.TabIndex = 1
        btnSelectFolder.Text = "Select Folder"
        btnSelectFolder.UseVisualStyleBackColor = True
        ' 
        ' txtFolderPath
        ' 
        txtFolderPath.Location = New Point(93, 52)
        txtFolderPath.Name = "txtFolderPath"
        txtFolderPath.ReadOnly = True
        txtFolderPath.Size = New Size(369, 23)
        txtFolderPath.TabIndex = 2
        ' 
        ' listViewFiles
        ' 
        listViewFiles.Location = New Point(12, 81)
        listViewFiles.Name = "listViewFiles"
        listViewFiles.Size = New Size(450, 200)
        listViewFiles.TabIndex = 3
        listViewFiles.UseCompatibleStateImageBehavior = False
        listViewFiles.View = View.Details
        ' 
        ' btnOrganize
        ' 
        btnOrganize.Location = New Point(198, 287)
        btnOrganize.Name = "btnOrganize"
        btnOrganize.Size = New Size(75, 23)
        btnOrganize.TabIndex = 4
        btnOrganize.Text = "Organize Files"
        btnOrganize.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(477, 361)
        Controls.Add(btnOrganize)
        Controls.Add(listViewFiles)
        Controls.Add(txtFolderPath)
        Controls.Add(btnSelectFolder)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "File Organizer Utility"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSelectFolder As Button
    Friend WithEvents txtFolderPath As TextBox
    Friend WithEvents listViewFiles As ListView
    Friend WithEvents btnOrganize As Button

End Class
