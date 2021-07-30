Public Class FrmMenu
    Private Sub FrmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True) ' Allowing transparent background
        BackColor = Color.FromArgb(0, Color.Black) ' Setting a transparent background
        CustomiseButtons(btns:=GetControls(Of Button)(frm:=Me)) ' Gets a list of buttons and designs each button
    End Sub

    Private Sub Btn_Click(sender As Button, e As EventArgs) Handles btnPlay.Click, btnHelp.Click, btnExit.Click
        ' Subroutine that gets called when either of the 3 buttons in the form get clicked
        ResetLastFrm(frm:=Me) ' Resets the previous form
        Select Case sender.Name
            Case "btnPlay"
                FrmStandings = Nothing ' This allows for the previous forms to be reset, allowing game replayability
                SwitchPanel(FrmSetup) ' Switches form to "FrmSetup"
            Case "btnHelp"
                SwitchPanel(FrmHelp) ' Switches form to "FrmHelp"
            Case "btnExit"
                ParentForm.Close() ' Closes "FrmMain" which is the main game window
        End Select
    End Sub
End Class