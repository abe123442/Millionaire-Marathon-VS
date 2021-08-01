Public Class FrmMain
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelMain.BackColor = Color.FromArgb(0, Color.Black) ' Enabling the panel to have a transparent background
        Call SwitchPanel(frm:=FrmMenu) ' displaying the form "FrmMenu"
    End Sub
End Class
