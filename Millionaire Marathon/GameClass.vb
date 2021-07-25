﻿Class GameClass
    Property Buttons As List(Of Button)
    Property Labels As List(Of Label)
    Property MRE As Threading.ManualResetEvent
    Property Players As Hashtable
    Property Rounds As List(Of ArrayList)

    ' Class Constructor
    Sub New(
           mre As Threading.ManualResetEvent,
           players As Hashtable,
           rounds As List(Of ArrayList),
           buttons As List(Of Button),
           labels As List(Of Label))
        Me.MRE = mre
        Me.Players = players
        Me.Rounds = rounds
        Me.Buttons = buttons
        Me.Labels = labels
    End Sub

    Async Sub MainGame(lblReponse As Label, btnPass As Button)
        Dim vars As New GameVariables
        vars.CurrentPlayerInfo = New GameVariables.CurrentPlayerInfoClass
        Dim PlayerID As String


        For Each Round In Rounds
            vars.CurrentRound = Rounds.IndexOf(Round) + 1

            For Question = 0 To Round.Count - 1
                vars.CurrentQuestionInfo = New GameVariables.CurrentQuestionInfoClass With {
                    .CurrentQuestionNo = Question,
                    .CurrentQuestion = Round(Question)(0),
                    .OptionsAnswersArray = RandomiseOptions(Round(.CurrentQuestionNo)),
                    .CorrectAnswer = .OptionsAnswersArray(5)
                    }

                PlayerID = vars.CurrentPlayerInfo.CurrentPlayerID

                PopulateButtons(btns:=Me.Buttons, info:=vars.CurrentQuestionInfo.OptionsAnswersArray)
                PopulateLabels(lbls:=Me.Labels, vars:=vars)

                If (Players(PlayerID).Passes = 0) Then
                    lblReponse.Text = ""
                    btnPass.Text = $"{Players(PlayerID).Name} has no more passes!"
                    btnPass.Enabled = False
                Else
                    btnPass.Text = "Pass"
                    btnPass.Enabled = True
                End If

                Await Task.Run(
                    Sub()
                        MRE.WaitOne()
                    End Sub)

                Select Case Response
                    Case vars.CurrentQuestionInfo.CorrectAnswer
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
                End Select

                vars.CurrentPlayerInfo.ChangeCurrentPlayer()
                MRE.Reset()

            Next
        Next
    End Sub


End Class