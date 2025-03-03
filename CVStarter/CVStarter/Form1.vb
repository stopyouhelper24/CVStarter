Imports System.Runtime
Imports System.IO
Imports System.IO.Compression.ZipFile

Public Class Form1
    Public CVVersionInUse As String = "2.7.0"
    Public Menu__ As String = "0"
    Public SWTask_V As String = "2.6.0"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\CVNeed\Sebs SW CV.exe") Then
        Else
            If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\CV\Sebs SW CV.exe") Then
            Else
                Panel1.Visible = True
                Panel1.Dock = DockStyle.Fill
            End If
        End If
    End Sub
    Public Sub NeedFilesofCVStarter()
        Try
            My.Computer.FileSystem.CopyDirectory(My.Application.Info.DirectoryPath & "\CVNeed\runtimes", My.Application.Info.DirectoryPath & "\CV\runtimes")
        Catch ex As Exception

        End Try
        Try
            My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\CVNeed\AxInterop.WMPLib.dll", My.Application.Info.DirectoryPath & "\CV\AxInterop.WMPLib.dll")
        Catch ex As Exception

        End Try
        Try
            My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\CVNeed\FontAwesome.Sharp.dll", My.Application.Info.DirectoryPath & "\CV\FontAwesome.Sharp.dll")
        Catch ex As Exception

        End Try
        Try
            My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\CVNeed\Interop.SHDocVw.dll", My.Application.Info.DirectoryPath & "\CV\Interop.SHDocVw.dll")
        Catch ex As Exception

        End Try
        Try
            My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\CVNeed\Interop.WMPLib.dll", My.Application.Info.DirectoryPath & "\CV\Interop.WMPLib.dll")
        Catch ex As Exception

        End Try
        Try
            My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\CVNeed\Microsoft.Web.WebView2.Core.dll", My.Application.Info.DirectoryPath & "\CV\Microsoft.Web.WebView2.Core.dll")
        Catch ex As Exception

        End Try
        Try
            My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\CVNeed\Microsoft.Web.WebView2.WinForms.dll", My.Application.Info.DirectoryPath & "\CV\Microsoft.Web.WebView2.WinForms.dll")
        Catch ex As Exception

        End Try
        Try
            My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\CVNeed\Microsoft.Web.WebView2.Wpf.dll", My.Application.Info.DirectoryPath & "\CV\Microsoft.Web.WebView2.Wpf.dll")
        Catch ex As Exception

        End Try
        Try
            My.Computer.FileSystem.CopyFile(My.Application.Info.DirectoryPath & "\CVNeed\Sebs SW CV.exe", My.Application.Info.DirectoryPath & "\CV\Sebs SW CV.exe")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NeedFilesofCVStarter()

        If CheckBox5.Checked = True Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath & "\CV\Apps")

            'Blocker Settings
            Dim writer As String = ""

            If CheckBox1.Checked = True Then
                writer = writer + "1
"

            End If
            If CheckBox2.Checked = True Then
                writer = writer + "2
"
            End If
            If CheckBox3.Checked = True Then
                writer = writer + "3
"
            End If
            If CheckBox4.Checked = True Then
                writer = writer + "4
"
            End If
            If writer = "" Then
                writer = "0"
            End If
            Dim HomeDirandapps As String = My.Application.Info.DirectoryPath & "\CV\Apps\"
            If My.Computer.FileSystem.FileExists(HomeDirandapps & "Blocker.swfiles") Then
                My.Computer.FileSystem.DeleteFile(HomeDirandapps & "Blocker.swfiles")
                My.Computer.FileSystem.WriteAllText(HomeDirandapps & "Blocker.swfiles", writer, False)
            Else
                Try
                    My.Computer.FileSystem.WriteAllText(HomeDirandapps & "Blocker.swfiles", writer, False)
                Catch ex As Exception
                    Blue_Error.ErrorBox("??? | " & ex.Message)
                End Try

            End If
            'Blocker Settings

            If CheckBox6.Checked = True Then
                If SWTask_V = "2.6.0" Then
                    Try
                        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\CV\Apps\swtaskp.swfiles", "2.6.0", False)
                    Catch ex As Exception
                        Blue_Error.ErrorBox("??? | " & ex.Message)
                    End Try
                ElseIf SWTask_V = "2.6.1" Then
                    Try
                        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\CV\Apps\swtaskp.swfiles", "2.6.1", False)
                    Catch ex As Exception
                        Blue_Error.ErrorBox("??? | " & ex.Message)
                    End Try
                ElseIf SWTask_V = "3.0.0" Then
                    Try
                        My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\CV\Apps\swtaskp.swfiles", "3.0.0", False)
                    Catch ex As Exception
                        Blue_Error.ErrorBox("??? | " & ex.Message)
                    End Try
                End If


            End If
            If CheckBox7.Checked = True Then
                If CVVersionInUse = "2.7.0.0" Then
                    My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\CV\Apps\textedit.swfiles", "2.7.0", False)
                ElseIf CVVersionInUse = "2.8.0.0" Then
                    My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\CV\Apps\quickedit.swfiles", "2.8.0", False)
                ElseIf CVVersionInUse = "2.9.0.0" Then
                    My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\CV\Apps\quickedit.swfiles", "2.9.0", False)
                ElseIf CVVersionInUse = "3.0.0.0" Then
                    My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\CV\Apps\quickedit.swfiles", "3.0.0", False)
                End If

            End If
            If CheckBox9.Checked = True Then
                If CVVersionInUse = "2.7.0.0" Then
                    My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\CV\Apps\picview.swfiles", "2.7.0", False)
                ElseIf CVVersionInUse = "2.8.0.0" Then
                    My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\CV\Apps\picview.swfiles", "2.8.0", False)
                ElseIf CVVersionInUse = "2.9.0.0" Then
                    My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\CV\Apps\picview.swfiles", "2.9.0", False)
                ElseIf CVVersionInUse = "3.0.0.0" Then
                    My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\CV\Apps\picview.swfiles", "3.0.0", False)
                End If

            End If
            If CheckBox8.Checked = True Then
                My.Computer.FileSystem.WriteAllText(My.Application.Info.DirectoryPath & "\CV\Apps\swstore.swfiles", "2.7.0", False)
            End If
            If CheckBox9.Checked = True Then
                Dim M_ As String = "Not Working"
            End If
        End If
        'Start Menu/Window Settings
        If Menu__ = "0" Then
            Dim writer As String = "0"
            Dim HomeDirandapps As String = My.Application.Info.DirectoryPath & "\CV\"
            My.Computer.FileSystem.WriteAllText(HomeDirandapps & "Menu.swfiles", writer, False)
        ElseIf Menu__ = "1" Then
            Dim writer As String = "1"
            Dim HomeDirandapps As String = My.Application.Info.DirectoryPath & "\CV\"
            My.Computer.FileSystem.WriteAllText(HomeDirandapps & "Menu.swfiles", writer, False)
        ElseIf Menu__ = "2" Then
            Dim writer As String = "2"
            Dim HomeDirandapps As String = My.Application.Info.DirectoryPath & "\CV\"
            My.Computer.FileSystem.WriteAllText(HomeDirandapps & "Menu.swfiles", writer, False)
        ElseIf Menu__ = "3" Then
            Dim writer As String = "3"
            Dim HomeDirandapps As String = My.Application.Info.DirectoryPath & "\CV\"
            My.Computer.FileSystem.WriteAllText(HomeDirandapps & "Menu.swfiles", writer, False)
        End If
        ' Starts Sebs SW CV
        Dim jj As New Process
        jj.StartInfo.UseShellExecute = True
        jj.Start("notepad.exe")

        'Process.Start(My.Application.Info.DirectoryPath & "\CV\Sebs SW CV.exe")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Menu__ = "0" Then
            Button2.Enabled = False
            Button3.Enabled = True
            If CVVersionInUse = "3.0.0.0" Then
                Button8.Enabled = True
                Button9.Enabled = True
            End If
        ElseIf Menu__ = "1" Then
            Button3.Enabled = False
            Button2.Enabled = True
            If CVVersionInUse = "3.0.0.0" Then
                Button8.Enabled = True
                Button9.Enabled = True
            End If
        ElseIf Menu__ = "2" Then
            Button3.Enabled = True
            Button2.Enabled = True
            Button8.Enabled = True
            Button9.Enabled = False
        ElseIf Menu__ = "3" Then
            Button3.Enabled = True
            Button2.Enabled = True
            Button8.Enabled = False
            Button9.Enabled = True
        End If
        If SWTask_V = "2.6.0" Then
            Button5.Enabled = False
            Button6.Enabled = True
        ElseIf SWTask_V = "2.6.1" Then
            Button6.Enabled = False
            Button5.Enabled = True
        End If

    End Sub
    Private Sub Close_CV()
        For Each p As Process In Process.GetProcessesByName("Sebs SW CV.exe")
            If p.HasExited = True Then
                Try
                    My.Computer.FileSystem.DeleteDirectory(My.Application.Info.DirectoryPath & "\CV\Apps", FileIO.DeleteDirectoryOption.DeleteAllContents)
                Catch ex As Exception
                    Blue_Error.ErrorBox("??? | " & ex.Message)
                End Try
            End If
        Next
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) ' Handles Button1.Click
        'Close_CV()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If CheckBox11.Checked = True Then
        Else
            Try
                'My.Computer.FileSystem.DeleteDirectory(My.Application.Info.DirectoryPath & "\CV\Apps", FileIO.DeleteDirectoryOption.DeleteAllContents)
                My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\CV\Apps\swtaskp.swfiles")
                If CheckBox7.Text = "Text Editor" Then
                    My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\CV\Apps\textedit.swfiles")
                Else
                    My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\CV\Apps\quickedit.swfiles")
                End If
                My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\CV\Apps\swstore.swfiles")
                My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\CV\Apps\picview.swfiles")
                My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\CV\Apps\Blocker.swfiles")
                My.Computer.FileSystem.DeleteFile(My.Application.Info.DirectoryPath & "\CV\Menu.swfiles")
            Catch ex As Exception

            End Try
        End If



    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If sender.Checked = True Then
            GroupBox1.Enabled = True
            GroupBox3.Enabled = True
            GroupBox4.Enabled = True
        Else
            GroupBox1.Enabled = False
            GroupBox3.Enabled = False
            GroupBox4.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Menu__ = "0"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Menu__ = "1"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Menu__ = "0"
        CheckBox1.Checked = True
    End Sub

    Private Sub CheckBox8_CheckStateChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckStateChanged
        'CheckBox9.Checked = True
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If sender.Checked = True Then
            If CVVersionInUse = "3.0.0.0" Then
                GroupBox4.Enabled = False
            Else
                GroupBox4.Enabled = True
            End If
        Else
            GroupBox4.Enabled = False

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SWTask_V = "2.6.0"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        SWTask_V = "2.6.1"
    End Sub

    Private Sub InstallButton_Click(sender As Object, e As EventArgs) Handles InstallButton.Click
        'Form2.Show()

        'Form2.WebView21.Source = New Uri("https://sebs-sw-b.netlify.app/Sebs%20SW%20CV%202.7.zip")
        'Process.Start()
        'Timer1.Start()
        'Process.Start("https://sebs-sw-b.netlify.app/cv-v")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Timer1.Stop()
        'Dim s_ As String = Form2.WebView21.CoreWebView2.Profile.DefaultDownloadFolderPath
        'Try
        'Process.Start(s_ & "\Sebs SW CV 2.7.zip")
        'Catch ex As Exception
        'Blue_Error.ErrorBox(ex.Message)
        'End Try
        'Form2.Close()
        'MsgBox(s_)
        '
        If CheckBox12.Checked = True Then
            CheckBox13.Checked = False
            CheckBox14.Checked = False
            CheckBox15.Checked = False
        ElseIf CheckBox13.Checked = True Then
            CheckBox12.Checked = False
            CheckBox14.Checked = False
            CheckBox15.Checked = False
        ElseIf CheckBox14.Checked = True Then
            CheckBox12.Checked = False
            CheckBox13.Checked = False
            CheckBox15.Checked = False
        ElseIf CheckBox15.Checked = True Then
            CheckBox12.Checked = False
            CheckBox13.Checked = False
            CheckBox14.Checked = False
        End If
    End Sub

    Private Sub Panel2_DragEnter(sender As Object, e As DragEventArgs) Handles Panel2.DragEnter
        'e.Effect = DragDropEffects.All
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
        'MsgBox("2")
    End Sub

    Private MyFile As FileInfo

    Private Sub Panel2_DragDrop(sender As Object, e As DragEventArgs) Handles Panel2.DragDrop
        'Try
        'My.Computer.FileSystem.CopyFile(e.Data.GetData(DataFormats.FileDrop), "i")
        'Catch ex As Exception
        'Label1.Text = e.Data.GetData(DataFormats.Text)
        'MsgBox(Label1.Text)
        'End Try

        ' GET [SINGLE] FILE PATH FROM DROPPED FILE
        Dim file As String = e.Data.GetData(DataFormats.FileDrop)(0)

        ' GET PATH & FILEINFO
        Dim path As String = file
        MyFile = New FileInfo(path)

        ' ABORT IF NOT A VALID FILE
        If String.IsNullOrWhiteSpace(MyFile.Extension) Then Exit Sub

        If MyFile.FullName.Contains("Sebs SW CV") = False Then
            If MyFile.FullName.Contains("Sebs.SW.CV") = False Then Exit Sub
        Else
        End If

        If My.Computer.FileSystem.FileExists(My.Application.Info.DirectoryPath & "\CV.zip") Then
        Else
            My.Computer.FileSystem.CopyFile(MyFile.FullName, My.Application.Info.DirectoryPath & "\CV.zip")
        End If

        If My.Computer.FileSystem.DirectoryExists("CVNeed") Then
        Else
            My.Computer.FileSystem.CreateDirectory("CVNeed")
            IO.Compression.ZipFile.ExtractToDirectory(My.Application.Info.DirectoryPath & "\CV.zip", My.Application.Info.DirectoryPath & "\CVNeed\")
        End If

        Panel1.Visible = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            CVVersionInUse = "2.7.0"
            CheckBox7.Text = "Text Editor"
            SWTask_V = "2.6.0"
            CheckBox13.Checked = False
            CheckBox14.Checked = False
            CheckBox15.Checked = False
            GroupBox4.Enabled = True
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            CVVersionInUse = "2.8.0"
            CheckBox7.Text = "Quick Edit"
            SWTask_V = "2.6.0"
            CheckBox12.Checked = False
            CheckBox14.Checked = False
            CheckBox15.Checked = False
            GroupBox4.Enabled = True
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            CVVersionInUse = "2.9.0"
            CheckBox7.Text = "Quick Edit"
            SWTask_V = "2.6.0"
            CheckBox12.Checked = False
            CheckBox13.Checked = False
            CheckBox15.Checked = False
            GroupBox4.Enabled = True
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = True Then
            CVVersionInUse = "3.0.0.0"
            SWTask_V = "3.0.0"
            CheckBox7.Text = "Quick Edit"
            CheckBox12.Checked = False
            CheckBox13.Checked = False
            CheckBox14.Checked = False
            GroupBox4.Enabled = False
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Menu__ = "2"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Menu__ = "3"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim Apps As String = Nothing
            Dim quickedit_textedit As String = Nothing
            Dim SWTask As String = Nothing
            Dim Picture_Viewer As String = Nothing
            Dim SW_Store As String = Nothing
            Dim Menu__ As String = Nothing
            Dim CVVersion As String = Nothing


            Dim Reader As String = ""
            Reader = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
            If Reader.Contains("Apps = True") = True Then
                Apps = "True"
                If Reader.Contains("Quickedit/texteditor = True") = True Then
                    quickedit_textedit = "True"
                Else
                    quickedit_textedit = "False"
                End If
                If Reader.Contains("SWTask = True") = True Then
                    If Reader.Contains("SWTask = True,2.6.1") = True Then
                        SWTask = "True,2.6.1"
                    Else
                        If Reader.Contains("SWTask = True,2.6.0") = True Then
                            SWTask = "True,2.6.0"
                        Else
                            SWTask = "3.0.0"
                        End If
                    End If
                Else
                    SWTask = "False"
                End If
                If Reader.Contains("Picture_Viewer = True") = True Then
                    Picture_Viewer = "True"
                Else
                    Picture_Viewer = "False"
                End If
                If Reader.Contains("SW_Store = True") = True Then
                    SW_Store = "True"
                Else
                    SW_Store = "False"
                End If
            Else
                Apps = "False"
            End If
            If Reader.Contains("Menu = 0") = True Then
                Menu__ = "0"
            Else
                If Reader.Contains("Menu = 1") = True Then
                    Menu__ = "1"
                Else
                    If Reader.Contains("Menu = 2") = True Then
                        Menu__ = "2"
                    Else
                        If Reader.Contains("Menu = 3") = True Then
                            Menu__ = "3"
                        Else
                            Menu__ = "0"
                        End If
                    End If
                End If
            End If
            If Reader.Contains("2.7.0.0") = True Then
                CVVersion = "2.7.0.0"
            Else
                If Reader.Contains("2.8.0.0") = True Then
                    CVVersion = "2.8.0.0"
                Else
                    If Reader.Contains("2.9.0.0") = True Then
                        CVVersion = "2.9.0.0"
                    Else
                        If Reader.Contains("3.0.0.0") = True Then
                            CVVersion = "3.0.0.0"
                        Else
                        End If
                    End If

                End If
            End If
            If CVVersion.Contains("2.7.0.0") = True Then
                CVVersion = "3.0.0.0"
            Else
                If CVVersion.Contains("2.8.0.0") = True Then
                    CVVersion = "3.0.0.0"
                Else
                    If CVVersion.Contains("2.9.0.0") = True Then
                        CVVersion = "3.0.0.0"
                    Else
                        If CVVersion.Contains("3.0.0.0") = True Then
                            CVVersion = "3.0.0.0"
                        Else
                        End If
                    End If
                End If
            End If
            If Apps = "True" Then
                CheckBox5.Checked = True
                If quickedit_textedit = "True" Then
                    CheckBox7.Checked = True
                Else
                    CheckBox7.Checked = False
                End If
                If SWTask = "True,2.6.0" Then
                    CheckBox6.Checked = True
                    SWTask_V = "2.6.0"
                Else
                    If SWTask = "True,2.6.1" Then
                        CheckBox6.Checked = True
                        SWTask_V = "2.6.1"
                    Else
                        If SWTask = "True,3.0.0" Then
                            CheckBox6.Checked = True
                            SWTask_V = "3.0.0"
                        Else
                            CheckBox6.Checked = False
                        End If
                    End If
                End If
                If Picture_Viewer = "True" Then
                    CheckBox9.Checked = True
                Else
                    CheckBox9.Checked = False
                End If
            Else
                    CheckBox5.Checked = False
            End If

        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged

    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Public C3_2Mode As Boolean = False
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If C3_2Mode = False Then
            Button11.Text = "Go out of 3.2 Mode"
            Panel3.Visible = True
            C3_2Mode = True
        ElseIf C3_2Mode = True Then
            Button11.Text = "Change to 3.2 Mode"
            Panel3.Visible = False
            C3_2Mode = False
        End If
    End Sub
End Class
