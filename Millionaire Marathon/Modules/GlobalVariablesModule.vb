Module GlobalVariablesModule
    ' Game related public variables
    Public ReadOnly QuestionsFilePath As String = "assets\Questions.csv"
    Public Players As Hashtable ' The hashtable that contains 4 instances of "PlayerClass"
    Public Response As String
    Public LastFrm As New Form ' Variable used to assign to other forms to clear.
    Public AcceptMillion As Boolean = False
    'Public OptionEvent As New Threading.ManualResetEvent(False) ' An event that gets triggered on clicking a button in "FrmGame"
    Public MillionEvent As New Threading.ManualResetEvent(False) ' An event that gets triggered on clicking a button in "FrmMillion"
    Public NewMusicEvent As New Threading.ManualResetEvent(True) ' An event that gets triggered when the panel switches to one of 3 specific forms.

    Public Sub ResetLastFrm(frm As Form)
        ' A function that resets the previous form and sets "LastFrm" to "Me"
        LastFrm.Close()
        LastFrm = frm
    End Sub
End Module
