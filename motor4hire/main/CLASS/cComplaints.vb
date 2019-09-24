Public Class cComplaints : Inherits cMembers

    Private complinants As String
    Private datecomplaint As Date
    Private description As String
    Private idcomplaints As Integer
    Private idmotor As Integer
    Public Property propidcomplaints() As Integer
        Get
            Return MyClass.idcomplaints
        End Get
        Set(ByVal value As Integer)
            MyClass.idcomplaints = value
        End Set
    End Property

    Public Property propcomplinants() As String
        Get
            Return MyClass.complinants
        End Get
        Set(ByVal value As String)
            MyClass.complinants = value
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

    Public Property propdatecomplaint() As Date
        Get
            Return MyClass.datecomplaint
        End Get
        Set(ByVal value As Date)
            MyClass.datecomplaint = value
        End Set
    End Property

    Public Property propidmotor() As Integer
        Get
            Return MyClass.idmotor
        End Get
        Set(ByVal value As Integer)
            MyClass.idmotor = value
        End Set
    End Property
    Public Sub INSERT_COMPLAINTS()
        Try
            Dim sql As String
            'idcompalaints, idmember, complinants, description, datecomplaint, idmotor
            sql = "insert into complaints values(null," & Convert.ToInt32(propmemberID.ToString).ToString & ", " & _
                  "'" & propcomplinants & "','" & propdescription & "','" & Format(propdatecomplaint, "yyyy-MM-dd").ToString & "', " & _
                  "" & propidmotor & ")"
            GLOBAL_VARIABLES.d.execute(sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()

        End Try
    End Sub

    Public Sub UPDATE_COMPLAINT()
        Try
            Dim sql As String
            sql = "UPDATE complaints set idmember = " & propmemberID & ",idmotor = " & propidmotor & ", " & _
            " complinants = '" & propcomplinants & "',description='" & propdescription & "'," & _
            " datecomplaint ='" & Format(propdatecomplaint, "yyyy-MM-dd").ToString & "' where idcomplaints = " & propidcomplaints
            GLOBAL_VARIABLES.d.execute(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Sub
    Sub loadcomplaints(ByVal ID As Integer)
        Dim sql As String
        sql = "select * from complaints where  idcomplaints = " & ID
        GLOBAL_VARIABLES.d.execute(sql)
        Try
            'idcompalaints, idmember, complinants, description, datecomplaint, idmotor
            If (GLOBAL_VARIABLES.d.reader.HasRows) Then
                While (GLOBAL_VARIABLES.d.reader.Read())
                    propidcomplaints = Convert.ToInt32(GLOBAL_VARIABLES.d.reader(0).ToString).ToString
                    propmemberID = GLOBAL_VARIABLES.d.reader(1).ToString
                    propcomplinants = GLOBAL_VARIABLES.d.reader(2).ToString
                    propdescription = GLOBAL_VARIABLES.d.reader(3).ToString
                    propdatecomplaint = GLOBAL_VARIABLES.d.reader(4).ToString
                    propidmotor = GLOBAL_VARIABLES.d.reader(5).ToString

                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try

    End Sub
End Class
