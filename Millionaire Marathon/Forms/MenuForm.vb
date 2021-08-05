﻿Public Class FrmMenu
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
                SwitchForm(FrmSetup) ' Switches form to "FrmSetup"
            Case "btnHelp"
                SwitchForm(FrmHelp) ' Switches form to "FrmHelp"
            Case "btnExit"
                LastFrm = FrmMain ' Exits the game
                ResetLastFrm(frm:=Me)
        End Select
    End Sub
End Class