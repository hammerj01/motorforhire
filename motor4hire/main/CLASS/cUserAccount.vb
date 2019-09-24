Imports MySql.Data.MySqlClient

Imports System.IO
Imports System.Text
Imports System.Data
Imports System.Configuration
Imports System.Security.Cryptography
Public Class cUserAccount
    Private iduseraccount As Integer
    Private username As String
    Private password As String
    Private usertype As String

    Public Property propiduseraccount()
        Get
            Return MyClass.iduseraccount
        End Get
        Set(ByVal value)
            MyClass.iduseraccount = value
        End Set
    End Property
    Public Property propusername()
        Get
            Return MyClass.username
        End Get
        Set(ByVal value)
            MyClass.username = value
        End Set
    End Property
    Public Property proppassword()
        Get
            Return MyClass.password
        End Get
        Set(ByVal value)
            MyClass.password = value
        End Set
    End Property
    Public Property propusertype()
        Get
            Return MyClass.usertype
        End Get
        Set(ByVal value)
            MyClass.usertype = value
        End Set
    End Property

    Sub INSERT_USER()
        Dim SQL As String
        Try
            SQL = "insert into useraccount values(null,'" & propusername & "', '" & Encrypt(proppassword) & "', '" & propusertype & "')"
            GLOBAL_VARIABLES.d.execute(SQL)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()

        End Try
    End Sub

    Sub UPDATE_USER()
        Dim SQL As String
        Try
            SQL = "UPDATE useraccount set username = '" & propusername & "', password = '" & Encrypt(proppassword) & "', usertype = '" & propusertype & "'" & _
                   " where  iduseraccount = " & propiduseraccount
            GLOBAL_VARIABLES.d.execute(SQL)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Sub

    Sub Loaduser(ByVal id As Integer)
        'iduseraccount, username, password, usertype
        Dim sql As String
        Try
            sql = "select * from useraccount where iduseraccount = " & id
            GLOBAL_VARIABLES.d.execute(sql)
            If (GLOBAL_VARIABLES.d.reader.HasRows()) Then
                While GLOBAL_VARIABLES.d.reader.Read
                    propiduseraccount = Convert.ToInt32(GLOBAL_VARIABLES.d.reader(0).ToString).ToString
                    propusername = GLOBAL_VARIABLES.d.reader(1).ToString
                    proppassword = GLOBAL_VARIABLES.d.reader(2).ToString
                    propusertype = GLOBAL_VARIABLES.d.reader(3).ToString
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Sub

    Function chkuser(ByVal username As String, ByVal password As String) As Boolean
        Dim sql As String
        Try
            sql = "select count(*) as cnt from useraccount where username= '" & username & "' and password = '" & Encrypt(password) & "'"
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


    Private Function Encrypt(ByVal clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    Private Function Decrypt(ByVal cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, _
             &H65, &H64, &H76, &H65, &H64, &H65, _
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function

End Class