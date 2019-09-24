Imports MySql.Data.MySqlClient

Public Class cMembers
    Private cmd As New MySqlCommand
    Private idmember As String
    Private fname As String
    Private lname As String
    Private mname As String
    Private address As String
    Private barangay As String
    Private gender As String
    Private age As Integer
    Private birthday As Date
    Private licenseNo As String
    Private expiryDate As Date
    Private req1 As String
    Private req2 As String
    Private datereg As Date
    Private status, img As String
    Private genSteicker As String

#Region "properties"

    Public Property propfname() As String
        Get
            Return MyClass.fname
        End Get
        Set(ByVal value As String)
            MyClass.fname = value
        End Set
    End Property
    Public Property propexpirydate() As Date
        Get
            Return MyClass.expiryDate
        End Get
        Set(ByVal value As Date)
            MyClass.expiryDate = value
        End Set
    End Property
    Public Property proplname() As String
        Get
            Return MyClass.lname
        End Get
        Set(ByVal value As String)
            MyClass.lname = value
        End Set
    End Property

    Public Property propmname() As String
        Get
            Return MyClass.mname
        End Get
        Set(ByVal value As String)
            MyClass.mname = value
        End Set
    End Property

    Public Property propbarangay() As String
        Get
            Return MyClass.barangay
        End Get
        Set(ByVal value As String)
            MyClass.barangay = value
        End Set
    End Property

    Public Property propgender() As String
        Get
            Return MyClass.gender
        End Get
        Set(ByVal value As String)
            MyClass.gender = value
        End Set
    End Property

    Public Property propage() As Integer
        Get
            Return MyClass.age
        End Get
        Set(ByVal value As Integer)
            MyClass.age = value
        End Set
    End Property

    Public Property propbirthday() As Date
        Get
            Return MyClass.birthday
        End Get
        Set(ByVal value As Date)
            MyClass.birthday = value
        End Set
    End Property

    Public Property propmemberID() As Integer
        Get
            Return MyClass.idmember
        End Get
        Set(ByVal value As Integer)
            MyClass.idmember = value
        End Set
    End Property

    Public Property propaddress() As String
        Get
            Return MyClass.address
        End Get
        Set(ByVal value As String)
            MyClass.address = value
        End Set
    End Property
    Public Property proplicenseno() As String
        Get
            Return MyClass.licenseNo
        End Get
        Set(ByVal value As String)
            MyClass.licenseNo = value
        End Set
    End Property

    Public Property propreq1() As String
        Get
            Return MyClass.req1
        End Get
        Set(ByVal value As String)
            MyClass.req1 = value
        End Set
    End Property

    Public Property propreq2() As String
        Get
            Return MyClass.req2
        End Get
        Set(ByVal value As String)
            MyClass.req2 = value
        End Set
    End Property

    Public Property propdatereg() As Date
        Get
            Return MyClass.datereg
        End Get
        Set(ByVal value As Date)
            MyClass.datereg = value
        End Set
    End Property

    Public Property propstatus() As String
        Get
            Return MyClass.status
        End Get
        Set(ByVal value As String)
            MyClass.status = value
        End Set
    End Property

    Public Property propgenSticker() As String
        Get
            Return MyClass.genSteicker
        End Get
        Set(ByVal value As String)
            MyClass.genSteicker = value
        End Set
    End Property
    Public Property propImg() As String
        Get
            Return MyClass.img
        End Get
        Set(ByVal value As String)
            MyClass.img = value
        End Set
    End Property

#End Region

  
    Public Sub Insert_members()
        Dim SQL As String
        ' idmember, fname, lname, mname, address, barangay, age, gender, licenseno, expirydate,
        'bday, requirements1, requirements2, datereg
        Try
            SQL = "INSERT INTO member VALUES(null, '" & propfname & "'," & _
                          "'" & proplname & "'," & _
                          "'" & propmname & "'," & _
                          "'" & propaddress & "'," & _
                          "'" & propbarangay & "'," & _
                          "'" & propage & "'," & _
                          "'" & propgender & "'," & _
                          "'" & proplicenseno & "'," & _
                          "'" & Format(propexpirydate, "yyyy-MM-dd").ToString & "'," & _
                          "'" & Format(propbirthday, "yyyy-MM-dd").ToString & "', " & _
                          "'" & propreq1 & "', '" & propreq2 & "', " & _
                          "'" & Format(propdatereg, "yyyy-MM-dd").ToString & "','" & propstatus & "','" & propImg  & "')"
            GLOBAL_VARIABLES.d.execute(SQL)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()

        End Try
    End Sub

    Public Sub Update_members()
        Dim sql As String

        Try
            ' idmember, fname, lname, mname, address, barangay, age, gender, licenseno, expirydate,
            'bday, requirements1, requirements2, datereg
            sql = "update member set fname = '" & propfname & "',lname = '" & proplname & "', mname = '" & propmname & "', " & _
                  " address = '" & propaddress & "', barangay = '" & propbarangay & "', age = '" & propage & "', img ='" & propImg & "', " & _
                  "gender = '" & propgender & "', licenseno = '" & proplicenseno & "', expirydate = '" & Format(propexpirydate, "yyyy-MM-dd").ToString & "'," & _
                  "bday = '" & Format(propbirthday, "yyyy-MM-dd").ToString & "', requirements1 = '" & propreq1 & "', requirements2 = '" & propreq2 & "'" & _
                  " WHERE idmember = " & propmemberID
            GLOBAL_VARIABLES.d.execute(sql)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try

    End Sub

    Sub INSER_STICKER()
        Dim sql As String

        Try
            sql = "insert into sticker values(null, '" & propmemberID & "','" & Format(Now, "yyyy-MM-dd").ToString & "','Active')"
            GLOBAL_VARIABLES.d.execute(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Sub

    Function chkSticker(ByVal idmember As Integer, ByVal sticker As String) As Boolean
        Dim sql As String
        Dim res As Boolean

        Try
            'idsticker, idmember, stickerNo, datestart, mystatus
            sql = "SELECT * FROM `motor4hire`.`sticker` where idmember = " & idmember & " and stickerNo = '" & sticker & "'"
            GLOBAL_VARIABLES.d.execute(sql)
            If (GLOBAL_VARIABLES.d.reader.HasRows) Then
                GLOBAL_VARIABLES.d.reader.Read()
                res = True
            Else
                res = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Function

    Sub lsvMemberByID(ByVal ID As Integer)
        Dim sql As String
        sql = "select idmember, fname, lname, mname, address, barangay, age, gender, licenseno, expirydate, " & _
              "bday, requirements1, requirements2, datereg,`status`, img from member where idmember = " & ID
        GLOBAL_VARIABLES.d.execute(sql)
        Try
            'idmember, fname, lname, mname, address, barangay, age, gender, licenseno, expirydate, bday, requirements1, requirements2, datereg,status
            If (GLOBAL_VARIABLES.d.reader.HasRows) Then
                While (GLOBAL_VARIABLES.d.reader.Read())
                    propmemberID = Convert.ToInt32(GLOBAL_VARIABLES.d.reader(0).ToString).ToString
                    propfname = GLOBAL_VARIABLES.d.reader(1).ToString
                    proplname = GLOBAL_VARIABLES.d.reader(2).ToString
                    propmname = GLOBAL_VARIABLES.d.reader(3).ToString
                    propaddress = GLOBAL_VARIABLES.d.reader(4).ToString
                    propbarangay = GLOBAL_VARIABLES.d.reader(5).ToString
                    propage = GLOBAL_VARIABLES.d.reader(6).ToString
                    propgender = GLOBAL_VARIABLES.d.reader(7).ToString
                    proplicenseno = GLOBAL_VARIABLES.d.reader(8).ToString
                    propexpirydate = Convert.ToDateTime(GLOBAL_VARIABLES.d.reader(9).ToString).ToString
                    propbirthday = Convert.ToDateTime(GLOBAL_VARIABLES.d.reader(10).ToString).ToString
                    propreq1 = GLOBAL_VARIABLES.d.reader(11).ToString
                    propreq2 = GLOBAL_VARIABLES.d.reader(12).ToString
                    propdatereg = Convert.ToDateTime(GLOBAL_VARIABLES.d.reader(13).ToString).ToString
                    propstatus = GLOBAL_VARIABLES.d.reader(14).ToString
                    propImg = GLOBAL_VARIABLES.d.reader(15).ToString

                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try

    End Sub

    Public Function CheckStatus(ByVal ID As Integer) As Boolean
        Dim sql As String

        Try
            sql = "select count(*) as status from member where idmember = " & ID & " and status = 'active'"
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
            MessageBox.Show(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try

    End Function

    Sub expiredMembers()
        Try
            Dim sql1 As String

            Dim sql As String = "select m.idmember,concat(m.fname, ' ',m.mname,' ', m.lname) as name, m.expirydate" & _
                                " from member m where m.expirydate < now() and m.status='active'"
            GLOBAL_VARIABLES.d.execute(sql)
            If (GLOBAL_VARIABLES.d.reader.HasRows()) Then
                Dim x As Integer = GLOBAL_VARIABLES.d.reader.FieldCount - 1
                Dim arr(x) As Integer
                Dim Y As Integer = 0
                While (GLOBAL_VARIABLES.d.reader.Read())
                    propmemberID = Convert.ToInt32(GLOBAL_VARIABLES.d.reader(0).ToString).ToString()

                    arr(Y) = Convert.ToInt16(propmemberID.ToString).ToString
                    Y = Y + 1
                End While

                For xx = 0 To arr.Length
                    GLOBAL_VARIABLES.d.reader.Close()
                    sql1 = "update member set status = 'expired' where idmember = " & xx
                    GLOBAL_VARIABLES.d.execute(sql1)
                    'GLOBAL_VARIABLES.d.reader.Close()
                Next xx

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Sub

    Function IsmemberExist(ByVal fname As String, ByVal lname As String) As Boolean
        Try
            Dim sql As String = "Select count(*) as cnt from member where fname = '" & fname & "' and lname = '" & lname & "'"
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

End Class
