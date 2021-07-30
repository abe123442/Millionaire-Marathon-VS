Module GlobalVariablesModule
    ' Game related public variables
    Public OptionEvent As New Threading.ManualResetEvent(False) ' An event that gets triggered
    Public ReadOnly FilePath As String = "assets\Questions.csv"
    Public MillionEvent As New Threading.ManualResetEvent(False)
    Public AcceptMillion As Boolean = False
    Public MillionPlayerName As String
    Public Players As Hashtable
    Public Response As String
    Public LastFrm As New Form

    Public Sub ResetLastFrm(frm As Form)
        ' A function that resets the previous form and sets "LastFrm" to "Me"
        LastFrm.Close()
        LastFrm = frm
    End Sub
End Module
