Imports System
Imports System.IO
Imports System.ComponentModel
Imports System.Text
Imports MySql.Data.MySqlClient


Public Class frmbackuprestore

    Private Sub frmbackuprestore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call modFunctions.DisabledButton(Me)
        TextBox1.Enabled = False
    End Sub

    Private Sub rdoBackup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdoBackup.CheckedChanged
        Button1.Enabled = True

    End Sub

    Private Sub rdorestore_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdorestore.CheckedChanged
        Button2.Enabled = True
        Button1.Enabled = False
        TextBox1.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim file As String
        file = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"

        Process.Start("C:\xampp\mysql\bin\MySQLdump.exe", " -u root -p  motor4hire -r ""D:\MY PROJECTS\motor4hire\backupdb\ " & file & """")

        'Process.Start("C:\xampp\mysql\bin\mysqldum.exe", "-u root -p  --database=motor4hire > -r ""D:\MY PROJECTS\motor4hire\backupdb\motor4hire (1).sql""")

        MsgBox("Backup Created Successfully!", MsgBoxStyle.Information, "Backup")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        'Dim myProcess As New Process()
        'myProcess.StartInfo.FileName = "cmd.exe"
        'myProcess.StartInfo.UseShellExecute = False
        'myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"
        'myProcess.StartInfo.RedirectStandardInput = True
        'myProcess.StartInfo.RedirectStandardOutput = True
        'myProcess.Start()
        'Dim myStreamWriter As StreamWriter = myProcess.StandardInput
        'Dim mystreamreader As StreamReader = myProcess.StandardOutput
        'myStreamWriter.WriteLine("mysql -u root -p motor4hire <  D:\MY PROJECTS\motor4hire\backupdb\2017-09-12 22-47-59-old.sql")
        'myStreamWriter.Close()
        'myProcess.WaitForExit()
        'myProcess.Close()

        'Dim file As String
        ''opd.Filter = "SQL Dump File (*.sql)|*.sql|All files (*.*)|*.*"
        ''If opd.ShowDialog = DialogResult.OK Then
        'file = "D:\MY PROJECTS\motor4hire\backupdb\2017-09-14 09-00-34.sql"
        'Dim myProcess As New Process()
        'myProcess.StartInfo.FileName = "cmd.exe"
        'myProcess.StartInfo.UseShellExecute = False
        'myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin\"
        'myProcess.StartInfo.RedirectStandardInput = True
        'myProcess.StartInfo.RedirectStandardOutput = True
        'myProcess.Start()
        'Dim myStreamWriter As StreamWriter = myProcess.StandardInput
        'Dim mystreamreader As StreamReader = myProcess.StandardOutput
        'myStreamWriter.WriteLine("mysql -u root --password -h localhost ""motor4hire"" < """ + file + """ ")
        'myStreamWriter.Close()
        'myProcess.WaitForExit()
        'myProcess.Close()

        Process.Start("C:\xampp\mysql\bin\mysqldump.exe", " --host=localhost --user=root --p motor4hire < ""D:\MY PROJECTS\motor4hire\backupdb\motor4hire.sql"" ")

        'Process.Start("C:\xampp\mysql\bin\MySQLdump.exe,-u root -p  motor4hire < -r ""D:\MY PROJECTS\motor4hire\backupdb\2017-09-12 22-47-59-old.sql""")

        '       Dim ConString As String = "SERVER = 'localhost'; USERID = 'root'; PASSWORD = ''; DATABASE = 'D:\MY PROJECTS\motor4hire\backupdb\2017-09-14 09-00-34.sql'"
        'Dim RestoreFile As String

        'Dim fileOpener As OpenFileDialog = New OpenFileDialog()
        'fileOpener.Filter = "SQL files | *.sql"
        'If fileOpener.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '    RestoreFile = fileOpener.FileName
        '    Using sConnection As New MySqlConnection(ConString)
        '        Using sqlCommand As New MySqlCommand()
        '            Using sqlBackup As New MySqlBackup(sqlCommand)
        '                sqlCommand.Connection = sConnection
        '                sConnection.Open()
        '                sqlBackup.ImportFromFile(RestoreFile)
        '                MessageBox.Show("MySQL database has been restored.", "MySQL Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '                sConnection.Close()
        '            End Using
        '        End Using
        '    End Using
        'Else
        '    MessageBox.Show("No restore file was chosen.", "MySQL Restore", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If

        'Dim constring As String = "server=localhost;user=root;pwd=;database=motor4hire;"
        'Dim file As String = "D:\MY PROJECTS\motor4hire\backupdb\2017-09-14 09-00-34.sql"
        ''Dim conn As String = ""
        'Dim conn As New MySqlConnection(constring)

        'Dim cmd As New MySqlCommand()

        'Using mb As New MySqlBackup()
        '    cmd.Connection = conn
        '    conn.Open()
        '    mb.ImportFromFile(file)
        '    conn.Close()

        'End Using



    End Sub
End Class