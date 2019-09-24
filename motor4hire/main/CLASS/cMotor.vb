Imports MySql.Data.MySqlClient

Public Class cMotor
    'Inherits cMembers

    Dim member As New cMembers
    Private cmd As New MySqlCommand
    Private idmember As Integer
    Private motorname As String
    Private or_no As String
    Private cr_no As String
    Private date_register As Date
    Private dateofexpiration As Date
    Private plateNo As String
    Private idmotor As Integer
    Private description, chasis As String
    Private status As String

    Public Property propmemberID() As Integer
        Get
            Return MyClass.idmember
        End Get
        Set(ByVal value As Integer)
            MyClass.idmember = value
        End Set
    End Property
    Public Property propcrno() As String
        Get
            Return MyClass.cr_no
        End Get
        Set(ByVal value As String)
            MyClass.cr_no = value
        End Set
    End Property

    Public Property propchasis() As String
        Get
            Return MyClass.chasis
        End Get
        Set(ByVal value As String)
            MyClass.chasis = value
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

    Public Property propdescription() As String
        Get
            Return MyClass.description
        End Get
        Set(ByVal value As String)
            MyClass.description = value
        End Set
    End Property

    Public Property propormo() As String
        Get
            Return MyClass.or_no
        End Get
        Set(ByVal value As String)
            MyClass.or_no = value
        End Set
    End Property

    Public Property propname() As String
        Get
            Return MyClass.motorname
        End Get
        Set(ByVal value As String)
            MyClass.motorname = value
        End Set
    End Property

    Public Property propplateno() As String
        Get
            Return MyClass.plateNo
        End Get
        Set(ByVal value As String)
            MyClass.plateNo = value
        End Set
    End Property

    Public Property propdateregister() As Date
        Get
            Return MyClass.date_register
        End Get
        Set(ByVal value As Date)
            MyClass.date_register = value
        End Set
    End Property

    Public Property propdateofexpiration() As Date
        Get
            Return MyClass.dateofexpiration
        End Get
        Set(ByVal value As Date)
            MyClass.dateofexpiration = value
        End Set
    End Property

    Public Property propidmoter() As String
        Get
            Return MyClass.idmotor
        End Get
        Set(ByVal value As String)
            MyClass.idmotor = value
        End Set
    End Property

    Public Sub Insert_motor()
        Dim sql As String
        'idmotor, name, date_register, idmember, or_num, cr_num, description, dateofexpiration, plateNo
        'modConnection.connection.Open()
        Try

            sql = "INSERT INTO motor VALUES(null,'" & propname & "'," & _
            "'" & Format(Now(), "yyyy-MM-dd").ToString & "'," & _
            " " & propmemberID & ", '" & propormo & "','" & propcrno & "','" & propdescription & "'," & _
            "'" & Format(propdateofexpiration, "yyyy-MM-dd").ToString & "', '" & propplateno & "','" & propstatus & "','" & propchasis & "')"
                   GLOBAL_VARIABLES.d.execute(SQL)
         Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try

    End Sub

    Public Sub update_motor()
        Dim sql As String

        Try
            'idmotor, name, date_register, idmember, or_num, cr_num, description, dateofexpiration, plateNo, status
            sql = "update motor set name = '" & propname & "', idmember='" & propmemberID & "',or_num = '" & propormo & "'," & _
                  "cr_num ='" & propcrno & "', description ='" & propdescription & "',dateofexpiration = '" & Format(propdateofexpiration, "yyyy-MM-dd").ToString & "'," & _
                  "plateNo ='" & propplateno & "', chasisNo = '" & propchasis & "'  WHERE idmotor = " & propidmoter
            GLOBAL_VARIABLES.d.execute(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try

    End Sub
    Public Sub Listof_motor(ByVal idmotor As Integer)
        Dim sql As String
        Try
            sql = "select * from motor where (`status` = 'active' or status = 'Expired') and idmotor = " & idmotor
            GLOBAL_VARIABLES.d.execute(sql)
            'idmotor, name, date_register, idmember, or_num, cr_num, description, dateofexpiration, plateNo, status
            If (GLOBAL_VARIABLES.d.reader.HasRows()) Then
                While (GLOBAL_VARIABLES.d.reader.Read())
                    propidmoter = Convert.ToInt32(GLOBAL_VARIABLES.d.reader(0).ToString).ToString
                    propname = GLOBAL_VARIABLES.d.reader(1).ToString
                    propdateregister = Convert.ToDateTime(GLOBAL_VARIABLES.d.reader(2).ToString).ToString
                    propmemberID = GLOBAL_VARIABLES.d.reader(3).ToString
                    propormo = GLOBAL_VARIABLES.d.reader(4).ToString
                    propcrno = GLOBAL_VARIABLES.d.reader(5).ToString
                    propdescription = GLOBAL_VARIABLES.d.reader(6).ToString
                    propdateofexpiration = GLOBAL_VARIABLES.d.reader(7).ToString
                    propplateno = GLOBAL_VARIABLES.d.reader(8).ToString
                    propstatus = GLOBAL_VARIABLES.d.reader(9).ToString
                    propchasis = GLOBAL_VARIABLES.d.reader(10).ToString
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Sub

    Public Sub Listof_motorbyplate(ByVal idmotor As Integer)
        Dim sql As String
        Try
            sql = "select * from motor where (`status` = 'active' or status = 'Expired') and idmotor = " & idmotor
            GLOBAL_VARIABLES.d.execute(sql)
            'idmotor, name, date_register, idmember, or_num, cr_num, description, dateofexpiration, plateNo, status
            If (GLOBAL_VARIABLES.d.reader.HasRows()) Then
                While (GLOBAL_VARIABLES.d.reader.Read())
                    propidmoter = Convert.ToInt32(GLOBAL_VARIABLES.d.reader(0).ToString).ToString
                    propname = GLOBAL_VARIABLES.d.reader(1).ToString
                    propdateregister = Convert.ToDateTime(GLOBAL_VARIABLES.d.reader(2).ToString).ToString
                    propmemberID = GLOBAL_VARIABLES.d.reader(3).ToString
                    propormo = GLOBAL_VARIABLES.d.reader(4).ToString
                    propcrno = GLOBAL_VARIABLES.d.reader(5).ToString
                    propdescription = GLOBAL_VARIABLES.d.reader(6).ToString
                    propdateofexpiration = GLOBAL_VARIABLES.d.reader(7).ToString
                    propplateno = GLOBAL_VARIABLES.d.reader(8).ToString
                    propstatus = GLOBAL_VARIABLES.d.reader(9).ToString
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Sub

    Function Motorisexist(ByVal motorname As String) As Boolean
        Dim sql As String
        Try
            sql = "select count(*) as `count` from motor where `name` = '" & motorname & "'"
            'GLOBAL_VARIABLES.d.execute(sql)
            If (GLOBAL_VARIABLES.d.reader.HasRows()) Then
                GLOBAL_VARIABLES.d.reader.Read()
                'If (Convert.ToInt32(GLOBAL_VARIABLES.d.reader(0).ToString).ToString > 0) Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Function

    Function ifExpires1week() As Integer
        Try
            Dim sql As String
            Dim values As Integer
            sql = "select count(*) as `count` from member m inner join motor mo on m.idmember = mo.idmember " & _
            " where mo.dateofexpiration >= now() and mo.dateofexpiration <= now() + interval 7 day"
            If (GLOBAL_VARIABLES.d.reader.HasRows()) Then
                GLOBAL_VARIABLES.d.reader.Read()
                values = Convert.ToInt32(GLOBAL_VARIABLES.d.reader(0).ToString).ToString
                Return values
            Else
                Return values
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Function

End Class
