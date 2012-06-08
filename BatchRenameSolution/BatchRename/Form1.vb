Imports System.Windows.Forms
Imports System.IO

Public Class BatchRename

    Private Sub btnPath_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnPath.Click
        Dim myFolderBrowser As New FolderBrowserDialog
        myFolderBrowser.Description = "Select Folder"
        myFolderBrowser.RootFolder = Environment.SpecialFolder.MyComputer

        Dim dlgResult As DialogResult = myFolderBrowser.ShowDialog()
        If dlgResult = DialogResult.OK Then
            Me.txtPath.Text = myFolderBrowser.SelectedPath()
        End If
    End Sub


    Private Sub btnRun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRun.Click
        Dim wr As StreamWriter = File.CreateText("batch.bat")
        wr.WriteLine("FOR /R """ & Me.txtPath.Text & """ %%F IN (" & Me.txtOldName.Text & ") DO REN ""%%F"" " & Me.txtNewName.Text)
        wr.Close()
        Try
            Dim p As New Process
            p.StartInfo.FileName = "batch.bat"
            p.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            p.Start()
            p.WaitForExit()
            p.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            File.Delete("batch.bat")
        End Try
    End Sub
End Class
