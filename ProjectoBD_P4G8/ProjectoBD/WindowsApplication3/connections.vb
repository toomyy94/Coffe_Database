﻿Imports Microsoft.VisualBasic

Public Class connections
    Public Static Function ligacao()
        Return New SqlConnection("data source=tcp:193.136.175.33\\SQLSERVER2012,8293;initial catalog=p4g8; User ID=p4g8; Password=tomasgabriel")
    End Function
End Class
