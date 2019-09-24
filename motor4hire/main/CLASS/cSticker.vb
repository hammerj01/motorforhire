Imports MySql.Data.MySqlClient

Public Class cSticker : Inherits cMembers

    Private idsticker As String
    Private stickerno As String
    Private datestart As Date
    Private mystatus As String

    Public Property propIdsticker() As String
        Get
            Return MyClass.idsticker
        End Get
        Set(ByVal value As String)
            MyClass.idsticker = value
        End Set
    End Property

    Public Property propStickerno() As String
        Get
            Return MyClass.stickerno
        End Get
        Set(ByVal value As String)
            MyClass.stickerno = value
        End Set
    End Property
    Public Property propDatestart() As Date
        Get
            Return MyClass.datestart
        End Get
        Set(ByVal value As Date)
            MyClass.datestart = value
        End Set
    End Property
    Public Property propmystatus() As String
        Get
            Return MyClass.mystatus
        End Get
        Set(ByVal value As String)
            MyClass.mystatus = value
        End Set
    End Property


    Sub INSERT_STICKER()
        Dim sql As String
        Try
            'idsticker, idmember, stickerNo, datestart, mystatus
            sql = "INSERT INTO sticker values(null,'" & propmemberID & "','" & propStickerno & "', '" & Format(propDatestart, "yyyy-MM-dd").ToString & "', '" & propmystatus & "')"
            GLOBAL_VARIABLES.d.execute(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Sub

    Sub UPDATE_STICKER()
        Dim sql As String

        Try
            sql = "UPDATE sticker set idmember= '" & propmemberID & "', stickerno = '" & propStickerno & "', datestart ='" & Format(propDatestart, "yyyy-MM-dd").ToString & "'," & _
                   " mystatus = '" & propstatus & "' WHERE idsticker = '" & propIdsticker & "'"
            GLOBAL_VARIABLES.d.execute(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()

        End Try

    End Sub

End Class
