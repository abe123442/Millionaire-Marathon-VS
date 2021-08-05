Public Class FrmHelp
    Private Sub FrmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetStyle(ControlStyles.SupportsTransparentBackColor, True) ' Allows transparent background
        BackColor = Color.FromArgb(0, Color.Black) ' Sets a transparent background
        lblTutorial.BackColor = Color.FromArgb(75, Color.Black)
        CustomiseButtons(btns:=GetControls(Of Button)(frm:=Me)) ' Gets a list of buttons and designs each button
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        SwitchForm(frm:=FrmMenu) ' displaying the form "FrmMenu"
    End Sub


End Class