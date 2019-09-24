
Public Class cPayments : Inherits cMembers

    Private idpayment As String
    Private datepaid As Date
    Private amount As Double
    Public Property propIdpayment() As String
        Get
            Return MyClass.idpayment
        End Get
        Set(ByVal value As String)
            MyClass.idpayment = value
        End Set
    End Property

    Public Property propDatepaid() As Date
        Get
            Return MyClass.datepaid
        End Get
        Set(ByVal value As Date)
            MyClass.datepaid = value
        End Set
    End Property

    Public Property propAmount() As Double
        Get
            Return MyClass.amount
        End Get
        Set(ByVal value As Double)
            MyClass.amount = value
        End Set
    End Property
    Public Sub INSERT_PAYMENTS()
        Try
            Dim sql As String
            'idpayments, idmember, amount, datepaid, fname, lname, mname
            sql = "insert into payments values(null," & Convert.ToInt32(propmemberID.ToString).ToString & ", " & _
                  "" & Convert.ToDouble(propAmount.ToString).ToString & ", '" & Format(Now, "yyyy-MM-dd").ToString & "'," & _
                  "'" & propfname & "', '" & proplname & "', '" & propmname & "')"

            GLOBAL_VARIABLES.d.execute(sql)
            GLOBAL_VARIABLES.d.reader.Close()
            'Dim sql1 As String = "update member set status = 'active' where idmember= " & Convert.ToInt32(propmemberID.ToString).ToString
            'GLOBAL_VARIABLES.d.execute(sql1)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()

        End Try
    End Sub

    Sub update_rate()
        Try
            Dim sql As String
            sql = "update paymentrate set rate = " & propAmount & " where idpayment =  " & propIdpayment
            GLOBAL_VARIABLES.d.execute(sql)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()

        End Try
    End Sub

    Sub loadRate()
        Try
            Dim sql As String = "select * from paymentrate where idpayment =1 limit 1 "
            GLOBAL_VARIABLES.d.execute(sql)
            If (GLOBAL_VARIABLES.d.reader.HasRows()) Then
                While GLOBAL_VARIABLES.d.reader.Read
                    propIdpayment = Convert.ToInt32(GLOBAL_VARIABLES.d.reader(0).ToString).ToString
                    propAmount = GLOBAL_VARIABLES.d.reader(1).ToString
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GLOBAL_VARIABLES.d.reader.Close()
        End Try
    End Sub

End Class
