Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class DB

    Public _server As String
    Public _user As String
    Public _pw As String
    Public _db As String
    Public reader As MySqlDataReader
    Public conn As New MySqlConnection


    Public Function connect() As Boolean

        Dim server_string As String

        server_string = "server = '" & _server & "' " & _
                      ";username = '" & _user & "'" & _
                          ";password = '" & _pw & "'" & _
                          ";database ='" & _db & "'"
        conn.ConnectionString = server_string

        Try
            conn.Open()
            'MsgBox("database connected")
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

    End Function

    Public Function execute(ByVal sql As String) As MySqlDataReader
        Try
            Dim comm As New MySqlCommand
            comm.Connection = conn
            comm.CommandText = sql
            reader = comm.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return reader
    End Function

    Public Sub executeNonReader(ByVal sql As String)
        Try
            Dim comm As New MySqlCommand()
            comm.Connection = conn
            comm.CommandText = sql
            comm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function GetLastID() As Integer
        Dim sql As String
        Dim id As Integer

        Dim comm As New MySqlCommand
        Try
            sql = "SELECT last_insert_id()"
            comm.CommandText = sql

            comm.Connection = conn
            reader = d.execute(comm.CommandText)
            While (reader.Read())
                id = reader.GetInt32(0).ToString()
                Return id
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Function
End Class
