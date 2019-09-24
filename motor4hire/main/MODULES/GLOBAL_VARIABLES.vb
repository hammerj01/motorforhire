Imports MySql.Data.MySqlClient
Module GLOBAL_VARIABLES

    'message box
    Public Const msgInsert As String = "Records has been successfully save."
    Public Const msgUpdate As String = "Records has been successfully updated."
    Public Const msgDelete As String = "Do you want to delete this record?"
    Public Const msgSystemInfo As String = "Motor for hire Information System in Municipality of Balilihan"
    Public Const msgError As String = "Database error occured, cannot open form."
    Public Const msgErr As String = "ERROR"

    'Active ID
    Public act_memberID As Integer
    Public act_officerID As Integer
    Public act_motorID As Integer
    Public act_complaintID As Integer
    Public active_sup_id As Integer
    Public active_item_type_id As Integer

    'Flag
    Public EDITMODE As Boolean
    Public d As New DB

End Module
