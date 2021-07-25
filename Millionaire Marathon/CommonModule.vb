Module CommonModule
    Public GameOver As Boolean = False
    Public Players As Hashtable
    Public Response As String

    Sub SwitchPanel(frm As Form)
        MainForm.PanelMain.Controls.Clear()
        frm.TopLevel = False
        MainForm.PanelMain.Controls.Add(frm)
        frm.Show()
        MainForm.PanelMain.BringToFront()
    End Sub


    Sub PopulateButtons(btns As List(Of Button), info As Array)
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

    Sub PopulateLabels(
                      lbls As List(Of Label),
                      vars As GameVariables)
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

    Function GetPartialList(arr As ArrayList, startIndex As Integer, lastIndex As Integer)
        Dim partialArray As New ArrayList
        For i = startIndex To lastIndex
            partialArray.Add(arr(i))
        Next
        Return partialArray
    End Function

    Function GetRounds(questions As ArrayList) As List(Of ArrayList)
        Return New List(Of ArrayList) From {
            GetPartialList(questions, 0, 19),
            GetPartialList(questions, 20, 39),
            GetPartialList(questions, 40, 59),
            GetPartialList(questions, 60, questions.Count - 1)
            }
    End Function

    Function RandomiseOptions(question As Array) As Array
        Dim options As New ArrayList()
        For j = 1 To 4
            options.Add(question(j))
        Next
        Call ShuffleArray(options)
        options.Add(question(5))
        For j = 1 To 4
            question(j) = options(j - 1)
        Next
        Return question
    End Function

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

End Module
