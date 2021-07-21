Public Class FrmGame
    Dim MRE As New Threading.ManualResetEvent(False)

    ReadOnly FilePath As String = "assets\Questions.csv"
    ReadOnly Rounds = GetRounds(GetQuestions(FilePath))

    Dim CurrentRound As Integer = 1
    Dim CurrentQuestionNo As Integer = 0
    Dim CurrentQuestionInfo As Array

    ReadOnly PlayerNames As Hashtable = FrmSetup.playerNames
    Dim Players As New Hashtable From {
        {PlayerNames("Player 1"), New PlayerClass},
        {PlayerNames("Player 2"), New PlayerClass},
        {PlayerNames("Player 3"), New PlayerClass},
        {PlayerNames("Player 4"), New PlayerClass}
    }

    Dim Response As String
    Dim currentPlayerInt As Integer = 1
    Dim currentPlayerStr As String = PlayerNames("Player" + Str(currentPlayerInt))

    Private Sub FrmGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        BackColor = Color.FromArgb(0, Color.Black)
        Call MainGame()
        ' call the end of game stuff later here
    End Sub

    Sub BtnOptions_Click(sender As Button, e As EventArgs) _
        Handles btnOption1.Click, btnOption2.Click, btnOption3.Click, btnOption4.Click, btnPass.Click
        Response = sender.Text
        MRE.Set()
    End Sub

    ' main game subroutine
    Async Sub MainGame()
        For round = 0 To 3
            CurrentRound = round + 1
            For question = 0 To Rounds(round).Count - 1

                CurrentQuestionNo = question
                CurrentQuestionInfo = Rounds(round)(CurrentQuestionNo)
                Call RandomiseOptions(CurrentQuestionInfo)
                Dim correctAnswer As String = CurrentQuestionInfo(5)

                PopulateButtons(CurrentQuestionInfo)
                PopulateLabels(CurrentQuestionInfo(0))

                If (Players(currentPlayerStr).Passes = 0) Then
                    btnPass.Text = currentPlayerStr & " has no more passes!"
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
                    Case correctAnswer
                        Players(currentPlayerStr).Money = 2 ^ (Players(currentPlayerStr).Qansd)
                        Players(currentPlayerStr).Qansd += 1
                        lblReponse.Text = currentPlayerStr & " is correct!"
                    Case "pass", "Pass"
                        Players(currentPlayerStr).Passes -= 1
                        lblReponse.Text = currentPlayerStr & " passes with" &
                                String.Format(" {0}/5 passes left.", Players(currentPlayerStr).Passes)
                        question -= 1
                    Case Else
                        lblReponse.Text = currentPlayerStr & " is wrong!"
                End Select

                Call ChangePlayer()
                MRE.Reset()

            Next question
        Next round
    End Sub

    ' subroutines that update the visuals of the game

    Sub PopulateButtons(info As Array)
        btnOption1.Text = info(1)
        btnOption2.Text = info(2)
        btnOption3.Text = info(3)
        btnOption4.Text = info(4)
    End Sub

    Sub PopulateLabels(question As String)
        lblRound.Text = "Round: " & CurrentRound
        lblCurrentPlayer.Text = "Current Player: " & currentPlayerStr
        lblMoney.Text = "Money: $" & Players(currentPlayerStr).Money
        lblQuestion.Text = String.Format("Question {0}: {1}", (CurrentQuestionNo + 1), question)
    End Sub

    Sub ChangePlayer()
        If currentPlayerInt = 4 Then
            currentPlayerInt = 1
        Else
            currentPlayerInt += 1
        End If
        currentPlayerStr = PlayerNames("Player" + Str(currentPlayerInt))
    End Sub


    ' functions and subroutines that gets or modifies game data 

    Function GetRounds(questions As ArrayList) As List(Of ArrayList)
        Return New List(Of ArrayList) From {
            GetPartialList(questions, 0, 19),
            GetPartialList(questions, 20, 39),
            GetPartialList(questions, 40, 59),
            GetPartialList(questions, 60, questions.Count - 1)
            }
    End Function

    Function GetPartialList(arr As ArrayList, startIndex As Integer, lastIndex As Integer)
        Dim partialArray As New ArrayList
        For i = startIndex To lastIndex
            partialArray.Add(arr(i))
        Next
        Return partialArray
    End Function

    Sub RandomiseOptions(question As Array)
        Dim options As New ArrayList()
        For j = 1 To 4
            options.Add(question(j))
        Next
        Call ShuffleArray(options)
        options.Add(question(5))
        For j = 1 To 4
            question(j) = options(j - 1)
        Next
    End Sub

    Function GetQuestions(path As String) As ArrayList
        Dim questions As New ArrayList()
        Using MyReader As New FileIO.TextFieldParser(path)
            MyReader.TextFieldType = FileIO.FieldType.Delimited
            MyReader.SetDelimiters(",")
            While Not MyReader.EndOfData
                questions.Add(MyReader.ReadFields())
            End While
        End Using
        Call ShuffleArray(questions)
        Return questions
    End Function

    Sub ShuffleArray(arr As ArrayList)
        Dim lastIndex As Integer = arr.Count - 1
        Dim randIndex As Integer
        Dim randGen As Random = New Random

        While lastIndex > 0
            randIndex = randGen.Next(0, arr.Count)
            Dim temp = arr(lastIndex)
            arr(lastIndex) = arr(randIndex)
            arr(randIndex) = temp
            lastIndex -= 1
        End While
    End Sub
End Class
