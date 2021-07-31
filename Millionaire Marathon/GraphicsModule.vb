Module GraphicsModule
    Sub SwitchPanel(frm As Form)
        ' A subroutine that allows the functionality of displaying multiple forms on the same panel
        ' The previous contents of the form is cleared, then the panel adds the new "frm" form and displays it
        MainForm.PanelMain.Controls.Clear()
        frm.TopLevel = False
        MainForm.PanelMain.Controls.Add(frm)
        frm.Show()
        MainForm.PanelMain.BringToFront()
    End Sub

    Sub CustomiseButtons(btns As List(Of Button))
        ' A subroutine that iterates over a list of buttons and changes the appearance of each button.
        For Each btn As Button In btns
            ' Button properties
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.AntiqueWhite
            btn.Cursor = Cursors.Hand
            btn.Font = New Font("Century Gothic", 10)
            btn.TextAlign = ContentAlignment.MiddleCenter

            ' Drawing the new graphics of the button
            Dim Raduis As New Drawing2D.GraphicsPath
            Raduis.StartFigure()
            Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
            Raduis.AddLine(10, 0, btn.Width - 20, 0)
            Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
            Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
            Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
            Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
            Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
            Raduis.CloseFigure()
            btn.Region = New Region(Raduis)
        Next
    End Sub

    Sub PopulateButtons(btns As List(Of Button), info As Array)
        ' A subroutine that iterates over a list of buttons, checking the name of each button
        ' and setting its text to an appropriate value in the "info" array
        For Each btn As Button In btns
            Select Case btn.Name
                Case "btnOption1"
                    btn.Text = info(1)
                Case "btnOption2"
                    btn.Text = info(2)
                Case "btnOption3"
                    btn.Text = info(3)
                Case "btnOption4"
                    btn.Text = info(4)
            End Select
        Next
    End Sub

    Sub PopulateLabels(lbls As List(Of Label), vars As GameVariablesClass)
        ' A subroutine that iterates over a list of labels, checking the name of each label
        ' and settings its text to values from variables in the "Gamevariables" class.
        For Each lbl As Label In lbls
            Select Case lbl.Name
                Case "lblRound"
                    lbl.Text = $"Round: {vars.CurrentRound}"
                Case "lblCurrentPlayer"
                    lbl.Text = $"Current Player: {Players(vars.CurrentPlayerInfo.CurrentPlayerID).Name}"
                Case "lblMoney"
                    lbl.Text = $"Money: ${(Players(vars.CurrentPlayerInfo.CurrentPlayerID).Money)}"
                Case "lblQuestion"
                    lbl.Text = $"Question {vars.CurrentQuestionInfo.CurrentQuestionNo + 1}: {vars.CurrentQuestionInfo.CurrentQuestion}"
            End Select
        Next
    End Sub

    Function GetControls(Of controltype)(frm As Form) As List(Of controltype)
        ' A function that returns a list of only the controls of type "controltype".
        Return frm.Controls.OfType(Of controltype).ToList()
    End Function

    Function GetControlByName(ctrls As IEnumerable(Of Control), name As String) As Control
        ' A function that finds a control by name and returns it
        For Each ctrl As Control In ctrls
            If ctrl.Name = name Then
                Return ctrl
            End If
        Next
        Return Nothing
    End Function
End Module
