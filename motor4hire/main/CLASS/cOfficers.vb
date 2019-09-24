
Public Class cOfficers

    Private idofficer As Integer
    Private president, active As String
    Private vice As String
    Private tresurer As String
    Private secretary As String
    Private auditor As String
    Private dateelected As Date
    Private endterm As Date
    Private pres_image, vice_image, sec_image, tres_image, aud_image As String

    Public Property propidofficers() As Integer
        Get
            Return MyClass.idofficer
        End Get
        Set(ByVal value As Integer)
            MyClass.idofficer = value
        End Set
    End Property

    Public Property propactive() As String
        Get
            Return MyClass.active
        End Get
        Set(ByVal value As String)
            MyClass.active = value
        End Set
    End Property

    Public Property propPres_image() As String
        Get
            Return MyClass.pres_image
        End Get
        Set(ByVal value As String)
            MyClass.pres_image = value
        End Set
    End Property

    Public Property proppresident() As String
        Get
            Return MyClass.president
        End Get
        Set(ByVal value As String)
            MyClass.president = value
        End Set
    End Property

    Public Property propvice() As String
        Get
            Return MyClass.vice
        End Get
        Set(ByVal value As String)
            MyClass.vice = value
        End Set
    End Property

    Public Property propVice_image() As String
        Get
            Return MyClass.vice_image
        End Get
        Set(ByVal value As String)
            MyClass.vice_image = value
        End Set
    End Property

    Public Property propsecretary() As String
        Get
            Return MyClass.secretary
        End Get
        Set(ByVal value As String)
            MyClass.secretary = value
        End Set
    End Property

    Public Property propSec_image() As String
        Get
            Return MyClass.sec_image
        End Get
        Set(ByVal value As String)
            MyClass.sec_image = value
        End Set
    End Property
    Public Property proptresurer() As String
        Get
            Return MyClass.tresurer
        End Get
        Set(ByVal value As String)
            MyClass.tresurer = value
        End Set
    End Property

    Public Property propTres_image() As String
        Get
            Return MyClass.tres_image
        End Get
        Set(ByVal value As String)
            MyClass.tres_image = value
        End Set
    End Property

    Public Property propauditor() As String
        Get
            Return MyClass.auditor
        End Get
        Set(ByVal value As String)
            MyClass.auditor = value
        End Set
    End Property

    Public Property propAud_image() As String
        Get
            Return MyClass.aud_image
        End Get
        Set(ByVal value As String)
            MyClass.aud_image = value
        End Set
    End Property
    Public Property propddateelected() As Date
        Get
            Return MyClass.dateelected
        End Get
        Set(ByVal value As Date)
            MyClass.dateelected = value
        End Set
    End Property
    Public Property propendterm() As Date
        Get
            Return MyClass.endterm
        End Get
        Set(ByVal value As Date)
            MyClass.endterm = value
        End Set
    End Property


    Public Sub INSERT_OFFICERS()
        Dim sql As String

        Try
            'idofficers, president, vice, secretary, tresurer, auditor, dateelected
            sql = "INSERT INTO officers values(null," & _
                  "'" & proppresident & "', " & _
                  "'" & propvice & "', " & _
                  "'" & propsecretary & "', " & _
                  "'" & proptresurer & "'," & _
                  "'" & propauditor & "', '" & Format(propddateelected, "yyyy-MM-dd").ToString & "', " & _
                  "'" & Format(propendterm, "yyyy-MM-dd").ToString & "','" & propPres_image & "', " & _
                  "'" & propVice_image & "','" & propSec_image & "', '" & propTres_image & "','" & propAud_image & "','" & propactive & "')"
            GLOBAL_VARIABLES.d.execute(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Sub

    Public Sub UPDATE_OFFICERS()
        Dim sql As String

        Try
            sql = "UPDATE officers SET president = '" & proppresident & "'," & _
                  " vice = '" & propvice & "', secretary = '" & propsecretary & "'," & _
                  " tresurer = '" & proptresurer & "', auditor = '" & propauditor & "', " & _
                  " dateelected = '" & Format(propddateelected, "yyyy-MM-dd").ToString & "', " & _
                  " endterm =  '" & Format(propendterm, "yyyy-MM-dd").ToString & "', pres_image = '" & propPres_image & "', " & _
                  " vice_image ='" & propVice_image & "', tres_image = '" & propTres_image & "', " & _
                  " sec_image = '" & propSec_image & "', aud_image = '" & propAud_image & "', status = '" & propactive & "' where idofficers = " & propidofficers
            GLOBAL_VARIABLES.d.execute(sql)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try

    End Sub

    Sub LoadOfficer(ByVal idOfficers As Integer)
        Dim sql As String
        Try
            'idofficers, president, vice, secretary, tresurer, auditor, dateelected, endterm, pres_image, vice_image, sec_image, tres_image, aud_image
            sql = "select * from officers where idofficers = " & idOfficers
            GLOBAL_VARIABLES.d.execute(sql)
            If (GLOBAL_VARIABLES.d.reader.HasRows) Then
                While (GLOBAL_VARIABLES.d.reader.Read())
                    propidofficers = Convert.ToInt32(GLOBAL_VARIABLES.d.reader(0).ToString).ToString
                    proppresident = GLOBAL_VARIABLES.d.reader(1).ToString
                    propvice = GLOBAL_VARIABLES.d.reader(2).ToString
                    propsecretary = GLOBAL_VARIABLES.d.reader(3).ToString
                    proptresurer = GLOBAL_VARIABLES.d.reader(4).ToString
                    propauditor = GLOBAL_VARIABLES.d.reader(5).ToString
                    propddateelected = Convert.ToDateTime(GLOBAL_VARIABLES.d.reader(6).ToString).ToString
                    propendterm = Convert.ToDateTime(GLOBAL_VARIABLES.d.reader(7).ToString).ToString
                    propPres_image = GLOBAL_VARIABLES.d.reader(8).ToString
                    propVice_image = GLOBAL_VARIABLES.d.reader(9).ToString
                    propSec_image = GLOBAL_VARIABLES.d.reader(10).ToString
                    propTres_image = GLOBAL_VARIABLES.d.reader(11).ToString
                    propAud_image = GLOBAL_VARIABLES.d.reader(12).ToString
                    propactive = GLOBAL_VARIABLES.d.reader(13).ToString
                End While
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try

    End Sub

    Function officerstatus(ByVal electdate As Date, ByVal endterm As Date, ByVal stat As String) As Boolean
        Try
            Dim sql As String
            sql = "SELECT * FROM officers where year(endterm) = '" & Format(endterm, "yyyy").ToString & "' and status = '" & stat & "' and status = 'Active'"
            GLOBAL_VARIABLES.d.execute(sql)
            If (GLOBAL_VARIABLES.d.reader.HasRows()) Then
                GLOBAL_VARIABLES.d.reader.Read()
                'values = Convert.ToInt32(GLOBAL_VARIABLES.d.reader(0).ToString).ToString
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

End Class
