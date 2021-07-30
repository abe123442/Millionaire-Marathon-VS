<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStandings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblStandings = New System.Windows.Forms.Label()
        Me.LblRankFirst = New System.Windows.Forms.Label()
        Me.LblRankSecond = New System.Windows.Forms.Label()
        Me.LblRankFourth = New System.Windows.Forms.Label()
        Me.LblRankThird = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblStandings
        '
        Me.LblStandings.AutoSize = True
        Me.LblStandings.Font = New System.Drawing.Font("Montserrat", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStandings.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblStandings.Location = New System.Drawing.Point(252, 30)
        Me.LblStandings.Name = "LblStandings"
        Me.LblStandings.Size = New System.Drawing.Size(254, 40)
        Me.LblStandings.TabIndex = 0
        Me.LblStandings.Text = "Final Standings"
        Me.LblStandings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRankFirst
        '
        Me.LblRankFirst.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblRankFirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRankFirst.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblRankFirst.Location = New System.Drawing.Point(37, 188)
        Me.LblRankFirst.Name = "LblRankFirst"
        Me.LblRankFirst.Size = New System.Drawing.Size(700, 24)
        Me.LblRankFirst.TabIndex = 1
        Me.LblRankFirst.Text = "Label1"
        Me.LblRankFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRankSecond
        '
        Me.LblRankSecond.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblRankSecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRankSecond.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblRankSecond.Location = New System.Drawing.Point(37, 234)
        Me.LblRankSecond.Name = "LblRankSecond"
        Me.LblRankSecond.Size = New System.Drawing.Size(700, 24)
        Me.LblRankSecond.TabIndex = 2
        Me.LblRankSecond.Text = "Label2"
        Me.LblRankSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRankFourth
        '
        Me.LblRankFourth.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblRankFourth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRankFourth.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblRankFourth.Location = New System.Drawing.Point(37, 326)
        Me.LblRankFourth.Name = "LblRankFourth"
        Me.LblRankFourth.Size = New System.Drawing.Size(700, 24)
        Me.LblRankFourth.TabIndex = 4
        Me.LblRankFourth.Text = "Label4"
        Me.LblRankFourth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblRankThird
        '
        Me.LblRankThird.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblRankThird.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRankThird.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.LblRankThird.Location = New System.Drawing.Point(37, 280)
        Me.LblRankThird.Name = "LblRankThird"
        Me.LblRankThird.Size = New System.Drawing.Size(700, 24)
        Me.LblRankThird.TabIndex = 3
        Me.LblRankThird.Text = "Label3"
        Me.LblRankThird.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.Font = New System.Drawing.Font("Montserrat SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(286, 387)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(202, 51)
        Me.btnHome.TabIndex = 7
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = False
        '
        'lblWinner
        '
        Me.lblWinner.Font = New System.Drawing.Font("Montserrat", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWinner.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblWinner.Location = New System.Drawing.Point(37, 112)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(700, 29)
        Me.lblWinner.TabIndex = 8
        Me.lblWinner.Text = "Final Standings"
        Me.lblWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmStandings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 500)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.LblRankFourth)
        Me.Controls.Add(Me.LblRankThird)
        Me.Controls.Add(Me.LblRankSecond)
        Me.Controls.Add(Me.LblRankFirst)
        Me.Controls.Add(Me.LblStandings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmStandings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "StandingsForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblStandings As Label
    Friend WithEvents LblRankFirst As Label
    Friend WithEvents LblRankSecond As Label
    Friend WithEvents LblRankFourth As Label
    Friend WithEvents LblRankThird As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents lblWinner As Label
End Class
