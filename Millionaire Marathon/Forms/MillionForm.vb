Public Class FrmMillion
    Private Sub FrmMillion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim btnList As New List(Of Button) From {btnAccept, btnDecline}
        CustomiseButtons(btns:=btnList)
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        AcceptMillion = True
        MillionEvent.Set()
    End Sub

    Private Sub btnDecline_Click(sender As Object, e As EventArgs) Handles btnDecline.Click
        AcceptMillion = False
        MillionEvent.Set()
    End Sub
End Class