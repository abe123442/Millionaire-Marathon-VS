Public Class FrmMillion
    Private Sub btn_Click(sender As Button, e As EventArgs) Handles btnAccept.Click, btnDecline.Click
        Select Case sender.Text
            Case "Accept", "accept", "Yes", "yes"
                AcceptMillion = True
            Case "Decline", "decline", "No", "no"
                AcceptMillion = False
        End Select
        MillionEvent.Set()
    End Sub

    Private Sub FrmMillion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btnList As New List(Of Button) From {btnAccept, btnDecline}
        CustomiseButtons(btnList, Color.GhostWhite)
    End Sub
End Class