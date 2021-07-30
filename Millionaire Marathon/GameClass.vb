Class GameClass
    Property Buttons As List(Of Button)
    Property Labels As List(Of Label)
    Property ButtonClick As Threading.ManualResetEvent
    Property MillionEvent As Threading.ManualResetEvent
    Property Players As Hashtable
    Property Rounds As List(Of ArrayList)

    ' Class Constructor
    Sub New(
           buttonclick As Threading.ManualResetEvent,
           millionevent As Threading.ManualResetEvent,
           players As Hashtable,
           rounds As List(Of ArrayList),
           buttons As List(Of Button),
           labels As List(Of Label))
        Me.ButtonClick = buttonclick
        Me.MillionEvent = millionevent
        Me.Players = players
        Me.Rounds = rounds
        Me.Buttons = buttons
        Me.Labels = labels
    End Sub

    Async Sub MainGame(nextForm As Form)
        Dim lblReponse As Label = GetControlByName(ctrls:=Me.Labels, name:="lblReponse")
        Dim btnPass As Button = GetControlByName(ctrls:=Me.Buttons, name:="btnPass")
        Dim Vars As New GameVariables With {
            .CurrentPlayerInfo = New GameVariables.CurrentPlayerInfoClass
        }
        Dim PlayerID As String


        For Each Round In Rounds
            Vars.CurrentRound = Rounds.IndexOf(Round) + 1

            For Question = 0 To Round.Count - 1
                Vars.CurrentQuestionInfo = New GameVariables.CurrentQuestionInfoClass With {
                    .CurrentQuestionNo = Question,
                    .CurrentQuestion = Round(Question)(0),
                    .OptionsAnswersArray = RandomiseOptions(Round(.CurrentQuestionNo)),
                    .CorrectAnswer = .OptionsAnswersArray(5)
                    }

                PlayerID = Vars.CurrentPlayerInfo.CurrentPlayerID

                PopulateButtons(btns:=Me.Buttons, info:=Vars.CurrentQuestionInfo.OptionsAnswersArray)
                PopulateLabels(lbls:=Me.Labels, vars:=Vars)
                If Players(PlayerID).Money = 2 ^ 19 Then
                    SwitchPanel(frm:=FrmMillion)
                    FrmMillion.lblChallenge.Text = $"{Players(PlayerID).Name}, do you want to risk losing all your earnings to have a chance at winning $1048576 ?"
                    Await Task.Run(
                        Sub()
                            MillionEvent.WaitOne()
                        End Sub)

                    If AcceptMillion = False Then
                        Vars.CurrentPlayerInfo.ChangeCurrentPlayer()
                    End If
                    MillionEvent.Reset()
                    SwitchPanel(frm:=FrmGame)
                End If


                If (Players(PlayerID).Passes = 0) Then
                    lblReponse.Text = ""
                    btnPass.Text = $"{Players(PlayerID).Name} has no more passes!"
                    btnPass.Enabled = False
                Else
                    If AcceptMillion Then
                        btnPass.Text = $"{Players(PlayerID).Name} cannot pass!"
                        btnPass.Enabled = False
                    Else
                        btnPass.Text = "Pass"
                        btnPass.Enabled = True
                    End If
                End If

                Await Task.Run(
                Sub()
                    ButtonClick.WaitOne()
                End Sub)

                Select Case Response
                    Case Vars.CurrentQuestionInfo.CorrectAnswer
                        Players(PlayerID).Money = 2 ^ (Players(PlayerID).Qansd)
                        Players(PlayerID).Qansd += 1
                        Labels.Contains(lblReponse)
                        lblReponse.Text = $"{Players(PlayerID).Name} is correct!"
                    Case "pass", "Pass", "PASS"
                        Players(PlayerID).Passes -= 1
                        lblReponse.Text = $"{Players(PlayerID).Name} passes with {Players(PlayerID).Passes}/5 passes left."
                        Question -= 1
                    Case Else

                        lblReponse.Text = $"{Players(PlayerID).Name} is wrong!"
                        If AcceptMillion Then
                            Players(PlayerID).Money = 0
                            AcceptMillion = False
                            SwitchPanel(nextForm)
                        End If
                End Select

                Vars.CurrentPlayerInfo.ChangeCurrentPlayer()
                ButtonClick.Reset()
            Next
        Next
        SwitchPanel(nextForm)
    End Sub

    Public Function CheckMillionDollar(name As String)
        Return $"{name} will you risk all your previous savings at a chance to win $1048576 ?"
    End Function

End Class
