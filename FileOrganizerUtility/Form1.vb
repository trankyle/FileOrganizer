Imports System.IO
Public Class Form1
    Private Sub btnSelectFolder_Click(sender As Object, e As EventArgs) Handles btnSelectFolder.Click
        Dim folderDialog As New FolderBrowserDialog()

        If folderDialog.ShowDialog() = DialogResult.OK Then
            txtFolderPath.Text = folderDialog.SelectedPath
            LoadFiles(folderDialog.SelectedPath)
        End If
    End Sub


    Private Sub LoadFiles(folderPath As String)
        ' Clear existing items
        listViewFiles.Items.Clear()

        ' Add columns if not already added
        If listViewFiles.Columns.Count = 0 Then
            listViewFiles.Columns.Add("File Name", 250)
            listViewFiles.Columns.Add("File Type", 100)
            listViewFiles.Columns.Add("Size (KB)", 100)
        End If

        ' Get all files in the folder
        Dim files As String() = Directory.GetFiles(folderPath)

        ' Add each file to the ListView
        For Each file In files
            Dim fileInfo As New FileInfo(file)
            Dim item As New ListViewItem(fileInfo.Name)
            item.SubItems.Add(fileInfo.Extension)
            item.SubItems.Add((fileInfo.Length / 1024).ToString("F2"))
            listViewFiles.Items.Add(item)
        Next
    End Sub
    Private Sub btnOrganize_Click(sender As Object, e As EventArgs) Handles btnOrganize.Click
        Dim folderPath As String = txtFolderPath.Text

        If String.IsNullOrWhiteSpace(folderPath) OrElse Not Directory.Exists(folderPath) Then
            MessageBox.Show("Please select a valid folder.")
            Return
        End If

        ' Organize files by type
        Dim files As String() = Directory.GetFiles(folderPath)

        For Each cfile In files
            Dim fileInfo As New FileInfo(cfile)
            Dim fileType As String = fileInfo.Extension.TrimStart(".").ToUpper()
            Dim destinationFolder As String = Path.Combine(folderPath, fileType)

            ' Create subfolder if it doesn't exist
            If Not Directory.Exists(destinationFolder) Then
                Directory.CreateDirectory(destinationFolder)
            End If

            ' Move file to the subfolder
            Dim destinationFile As String = Path.Combine(destinationFolder, fileInfo.Name)
            File.Move(cfile, destinationFile)
        Next

        ' Refresh the ListView
        LoadFiles(folderPath)
        MessageBox.Show("Files organized successfully!")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
