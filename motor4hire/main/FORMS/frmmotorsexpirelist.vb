Public Class frmmotorsexpirelist

    Private Sub frmmotorsexpirelist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtexpire As String
        Try
            'dtexpire = "select concat(m.fname, ' ', m.mname, ' ', m.lname) as name, m.licenseno,m.expirydate," & _
            '" concat(`mo`.`name`, ' ', `mo`.`description`) as motorname, `mo`.`dateofexpiration`, " & _
            '" DATEDIFF(mo.dateofexpiration, now()) as days from member m inner join motor mo on m.idmember = mo.idmember " & _
            '" where DATEDIFF(mo.dateofexpiration, now()) <= 7 "

            dtexpire = "select concat(m.fname, ' ', m.mname, ' ', m.lname) as name, m.licenseno,m.expirydate," & _
            " concat(`mo`.`name`, ' ', `mo`.`description`) as motorname, `mo`.`dateofexpiration`, " & _
            " DATEDIFF(mo.dateofexpiration, now()) as days  from member m inner join motor mo on m.idmember = mo.idmember " & _
            " where mo.dateofexpiration >= now() and mo.dateofexpiration <= now() + interval 7 day"
            Call modFunctions.PopulateListView(ListView1, dtexpire)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class