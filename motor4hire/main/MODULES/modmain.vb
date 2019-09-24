Module modmain
    Public Sub Main()
        GLOBAL_VARIABLES.d._server = "localhost"
        GLOBAL_VARIABLES.d._user = "root"
        GLOBAL_VARIABLES.d._pw = ""
        GLOBAL_VARIABLES.d._db = "motor4hire"


        If (GLOBAL_VARIABLES.d.connect()) Then
            Application.Run(New Login())
        End If

    End Sub
End Module
