Module GlobalVariablesModule
    ' Game related public variables
    Public OptionEvent As New Threading.ManualResetEvent(False) ' An event that gets triggered on clicking a button in "FrmGame"
    Public ReadOnly FilePath As String = "assets\Questions.csv"
    Public MillionEvent As New Threading.ManualResetEvent(False) ' An event that gets triggered on clicking a button in "FrmMillion"
    Public AcceptMillion As Boolean = False
    Public MillionPlayerName As String
    Public Players As Hashtable ' The hashtable that contains 4 instances of "PlayerClass"
    Public Response As String
    Public LastFrm As New Form ' Variable used to assign to other forms to clear.

    Public Sub ResetLastFrm(frm As Form)
        ' A function that resets the previous form and sets "LastFrm" to "Me"
        LastFrm.Close()
        LastFrm = frm
    End Sub
End Module
