Public Class FrmMillion

    Private Sub btn_Click(sender As Button, e As EventArgs) Handles btnAccept.Click, btnDecline.Click
        Select Case sender.Text
            Case "Accept", "accept", "Yes", "yes"
                AcceptMillion = True
            Case "Decline", "decline", "No", "no"
                AcceptMillion = False
        End Select
        MillionEvent.Set()

        Dim btnList As New List(Of Button) From {btnAccept, btnDecline}
        CustomiseButtons(btns:=btnList)
    End Sub
End Class