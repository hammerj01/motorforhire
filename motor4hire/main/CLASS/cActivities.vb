Public Class cActivities

    Private activityname As String
    Private idactivity As Integer
    Private description As String
    Private startdate As Date
    Private enddate As Date
    Private organizedby As String
    Public Property propactivityname() As String
        Get
            Return MyClass.activityname
        End Get
        Set(ByVal value As String)
            MyClass.activityname = value
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

    Public Property propstartdate() As Date
        Get
            Return MyClass.startdate
        End Get
        Set(ByVal value As Date)
            MyClass.startdate = value
        End Set
    End Property

    Public Property propenddate() As Date
        Get
            Return MyClass.enddate
        End Get
        Set(ByVal value As Date)
            MyClass.enddate = value
        End Set
    End Property

    Public Property proporganizedby() As String
        Get
            Return MyClass.organizedby
        End Get
        Set(ByVal value As String)
            MyClass.organizedby = value
        End Set
    End Property

    Public Property propidactivity() As Integer
        Get
            Return MyClass.idactivity
        End Get
        Set(ByVal value As Integer)
            MyClass.idactivity = value
        End Set
    End Property
    Public Sub INSERT_ACTIVITY()
        Dim sql As String
        'idactivities, actname, description, startdate, enddate, organized_by
        Try
            sql = "insert into activities values(null, '" & propactivityname & "', " & _
                  "'" & propdescription & "','" & Format(propstartdate, "yyyy-MM-dd").ToString & "'," & _
                  "'" & Format(propenddate, "yyyy-MM-dd").ToString & "', '" & proporganizedby & "')"
            GLOBAL_VARIABLES.d.execute(sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try

    End Sub

    Sub UPDATE_ACTIVITY()
        Dim sql As String

        Try
            sql = "UPDATE activities set actname ='" & propactivityname & "', " & _
                  " description = '" & propdescription & "',startdate = '" & Format(propstartdate, "yyyy-MM-dd").ToString & "'," & _
                  " enddate = '" & Format(propenddate, "yyyy-MM-dd").ToString & "',organized_by ='" & proporganizedby & "' where idactivities =" & propidactivity
            GLOBAL_VARIABLES.d.execute(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Sub

    Sub DELETE_ACTIVITY()
        Dim sql As String
        Try
            sql = "DELETE from activities where idactivities = " & propidactivity
            GLOBAL_VARIABLES.d.execute(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Sub

    Public Sub loadFields(ByVal aid As Integer)
        Dim sql As String

        Try
            sql = "select * from activities where idactivities = " & aid
            GLOBAL_VARIABLES.d.execute(sql)
            If (GLOBAL_VARIABLES.d.reader.HasRows()) Then
                While GLOBAL_VARIABLES.d.reader.Read
                    propidactivity = Convert.ToInt32(GLOBAL_VARIABLES.d.reader(0).ToString).ToString
                    propactivityname = GLOBAL_VARIABLES.d.reader(1).ToString
                    propdescription = GLOBAL_VARIABLES.d.reader(2).ToString
                    propstartdate = GLOBAL_VARIABLES.d.reader(3).ToString
                    propstartdate = GLOBAL_VARIABLES.d.reader(4).ToString
                    proporganizedby = GLOBAL_VARIABLES.d.reader(5).ToString
                End While
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Sub
End Class
