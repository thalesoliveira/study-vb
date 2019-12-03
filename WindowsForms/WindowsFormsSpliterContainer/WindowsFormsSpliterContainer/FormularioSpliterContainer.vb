Imports System.IO

Public Class FormularioSpliterContainer
    Private Sub FormularioSpliterContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each drive As DriveInfo In DriveInfo.GetDrives
            ListBox1.Items.Add(drive)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        ListBox2.Items.Clear()
        Try
            Dim drive As DriveInfo = ListBox1.SelectedItem

            For Each dirInfo As DirectoryInfo In drive.RootDirectory.GetDirectories
                ListBox2.Items.Add(dirInfo)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        ListBox3.Items.Clear()

        Try
            Dim dirInfo As DirectoryInfo = ListBox2.SelectedItem

            For Each fileInfo As FileInfo In dirInfo.GetFiles
                ListBox3.Items.Add(fileInfo)
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
