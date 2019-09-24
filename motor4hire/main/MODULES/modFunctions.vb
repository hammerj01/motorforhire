Imports MySql.Data
Imports MySql.Data.MySqlClient


Module modFunctions
    Dim reader As MySqlDataReader
    'Private conn As MySqlConnection = CreateConnection()
    Private comm As New MySqlCommand
    Dim d As New DB
    Public Sub PopulateListView(ByVal lsv As ListView, ByVal sql As String)
        Dim lstItem As ListViewItem
        GLOBAL_VARIABLES.d.execute(sql)
        lsv.Items.Clear()
        Try
            If (GLOBAL_VARIABLES.d.reader.HasRows) Then
                While GLOBAL_VARIABLES.d.reader.Read()
                    lstItem = lsv.Items.Add(GLOBAL_VARIABLES.d.reader.GetValue(0).ToString)
                    For x = 1 To GLOBAL_VARIABLES.d.reader.FieldCount - 1
                        lstItem.SubItems.Add(GLOBAL_VARIABLES.d.reader.GetValue(x).ToString())
                    Next x
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
            GLOBAL_VARIABLES.d.reader.Dispose()
        End Try

    End Sub

    Public Sub PopulateListViewRecords(ByVal lsv As ListView, ByVal sql As String)
        Dim lstItem As ListViewItem
        GLOBAL_VARIABLES.d.execute(sql)
        Dim arr(5) As String
        lsv.Items.Clear()
        Dim x As Integer
        Try
            If (GLOBAL_VARIABLES.d.reader.HasRows) Then
                While GLOBAL_VARIABLES.d.reader.Read()
                    ' lstItem = lsv.Items.Add(GLOBAL_VARIABLES.d.reader.GetValue(0).ToString)
                    For x = 0 To GLOBAL_VARIABLES.d.reader.FieldCount - 1
                        arr(x) = GLOBAL_VARIABLES.d.reader.GetValue(x).ToString().ToString
                    Next x
                    For x1 = 0 To x - 1
                        lstItem = lsv.Items.Add(arr(x1).ToString)
                        lstItem.SubItems.Add(arr(x1).ToString)
                    Next x1
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
            GLOBAL_VARIABLES.d.reader.Dispose()
        End Try

    End Sub

    Public Sub PopulateComboBox(ByRef cbo As ComboBox, ByRef sql As String, ByRef strTableName As String)
        cbo.Items.Clear()
        GLOBAL_VARIABLES.d.execute(sql)
        If (GLOBAL_VARIABLES.d.reader.HasRows) Then
            While (GLOBAL_VARIABLES.d.reader.Read())
                cbo.Items.Add(GLOBAL_VARIABLES.d.reader.GetValue(1).ToString())
            End While
        End If
        GLOBAL_VARIABLES.d.reader.Close()
    End Sub

    Public Sub ClearTextbox(ByVal root As Control)

        For Each ctrl As Control In root.Controls
            ClearTextbox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl
    End Sub

    Public Sub DisabledTextbox(ByRef root As Control)

        For Each ctrl As Control In root.Controls
            DisabledTextbox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = False
            End If
        Next ctrl
    End Sub

    Public Sub EnableTextbox(ByRef root As Control)

        For Each ctrl As Control In root.Controls
            EnableTextbox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Enabled = True
            End If
        Next ctrl
    End Sub

    Public Function IsEmpty(ByVal str As String) As Boolean
        If Len(Trim(str)) > 0 Then
            IsEmpty = False
        Else
            IsEmpty = True
        End If
    End Function
    Public Sub DisabledButton(ByRef root As Control)

        For Each ctrl As Control In root.Controls
            DisabledTextbox(ctrl)
            If TypeOf ctrl Is Button Then
                CType(ctrl, Button).Enabled = False
            End If
        Next ctrl
    End Sub

    Public Function generatepassword(ByVal val As Integer) As String
        Dim alpha_num_char As String = "abcdefghijklmnopqrstuvwxyz" & _
              "ABCDEFGHIJKLMNOPQRSTUVWXYZ" & "0123456789"
        Dim chars(val) As Char
        Dim generate_pass As String = ""

        Dim rd As New Random()
        Dim i, x As Integer

        For y As Integer = 0 To chars.Length
            chars(i) = alpha_num_char(rd.Next(0, alpha_num_char.Length))
            generate_pass = generate_pass + chars(i)
        Next y
        Return generate_pass
    End Function

    Sub DELETE_RECORD(ByVal tbl As String, ByVal f1 As Integer, ByVal id As String)
        Dim SQL As String

        Try
            SQL = "DELETE from " & tbl & " where " & id & "='" & f1 & "'"
            GLOBAL_VARIABLES.d.execute(SQL)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try

    End Sub

    Function chkLicenseORCR(ByVal values As String) As Boolean
        Dim sql As String

        Try
            sql = "SELECT count(*) as cnt FROM member m where licenseno = '" & values & "' or " & _
                  " idmember = (select idmember  from motor where or_num = '" & values & "' or cr_num = '" & values & "' " & _
                  "  or plateno = '" & values & "' or chasisNo = '" & values & "')"
            GLOBAL_VARIABLES.d.execute(sql)
            If (GLOBAL_VARIABLES.d.reader.HasRows()) Then
                GLOBAL_VARIABLES.d.reader.Read()
                If (Convert.ToInt32(GLOBAL_VARIABLES.d.reader(0).ToString).ToString > 0) Then
                    Return True

                Else
                    Return False
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try

    End Function

    Function UppercaseFirstLetter(ByVal val As String) As String
        ' Test for nothing or empty.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        ' Convert to character array.
        Dim array() As Char = val.ToCharArray

        ' Uppercase first character.
        array(0) = Char.ToUpper(array(0))

        ' Return new string.
        Return New String(array)
    End Function

End Module
