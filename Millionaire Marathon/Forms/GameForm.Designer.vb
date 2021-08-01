<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGame))
        Me.lblRound = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnOption1 = New System.Windows.Forms.Button()
        Me.btnOption2 = New System.Windows.Forms.Button()
        Me.btnOption3 = New System.Windows.Forms.Button()
        Me.btnOption4 = New System.Windows.Forms.Button()
        Me.lblCurrentPlayer = New System.Windows.Forms.Label()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.lblReponse = New System.Windows.Forms.Label()
        Me.btnPass = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRound
        '
        Me.lblRound.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRound.AutoSize = True
        Me.lblRound.BackColor = System.Drawing.Color.Transparent
        Me.lblRound.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRound.ForeColor = System.Drawing.Color.White
        Me.lblRound.Location = New System.Drawing.Point(62, 31)
        Me.lblRound.Name = "lblRound"
        Me.lblRound.Size = New System.Drawing.Size(108, 31)
        Me.lblRound.TabIndex = 0
        Me.lblRound.Text = "Round:"
        '
        'lblQuestion
        '
        Me.lblQuestion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQuestion.BackColor = System.Drawing.Color.Transparent
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblQuestion.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblQuestion.Location = New System.Drawing.Point(68, 130)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(644, 69)
        Me.lblQuestion.TabIndex = 1
        Me.lblQuestion.Text = "Question: "
        '
        'btnOption1
        '
        Me.btnOption1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOption1.BackColor = System.Drawing.Color.Transparent
        Me.btnOption1.FlatAppearance.BorderSize = 0
        Me.btnOption1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption1.ForeColor = System.Drawing.Color.Black
        Me.btnOption1.Location = New System.Drawing.Point(74, 200)
        Me.btnOption1.Name = "btnOption1"
        Me.btnOption1.Size = New System.Drawing.Size(280, 77)
        Me.btnOption1.TabIndex = 2
        Me.btnOption1.UseVisualStyleBackColor = False
        '
        'btnOption2
        '
        Me.btnOption2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOption2.BackColor = System.Drawing.Color.Transparent
        Me.btnOption2.FlatAppearance.BorderSize = 0
        Me.btnOption2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption2.ForeColor = System.Drawing.Color.Black
        Me.btnOption2.Location = New System.Drawing.Point(420, 200)
        Me.btnOption2.Name = "btnOption2"
        Me.btnOption2.Size = New System.Drawing.Size(280, 77)
        Me.btnOption2.TabIndex = 2
        Me.btnOption2.UseVisualStyleBackColor = False
        '
        'btnOption3
        '
        Me.btnOption3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOption3.BackColor = System.Drawing.Color.Transparent
        Me.btnOption3.FlatAppearance.BorderSize = 0
        Me.btnOption3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption3.ForeColor = System.Drawing.Color.Black
        Me.btnOption3.Location = New System.Drawing.Point(74, 322)
        Me.btnOption3.Name = "btnOption3"
        Me.btnOption3.Size = New System.Drawing.Size(280, 77)
        Me.btnOption3.TabIndex = 2
        Me.btnOption3.UseVisualStyleBackColor = False
        '
        'btnOption4
        '
        Me.btnOption4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOption4.BackColor = System.Drawing.Color.Transparent
        Me.btnOption4.FlatAppearance.BorderSize = 0
        Me.btnOption4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption4.ForeColor = System.Drawing.Color.Black
        Me.btnOption4.Location = New System.Drawing.Point(420, 322)
        Me.btnOption4.Name = "btnOption4"
        Me.btnOption4.Size = New System.Drawing.Size(280, 77)
        Me.btnOption4.TabIndex = 2
        Me.btnOption4.UseVisualStyleBackColor = False
        '
        'lblCurrentPlayer
        '
        Me.lblCurrentPlayer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurrentPlayer.AutoSize = True
        Me.lblCurrentPlayer.BackColor = System.Drawing.Color.Transparent
        Me.lblCurrentPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblCurrentPlayer.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblCurrentPlayer.Location = New System.Drawing.Point(517, 31)
        Me.lblCurrentPlayer.Name = "lblCurrentPlayer"
        Me.lblCurrentPlayer.Size = New System.Drawing.Size(164, 26)
        Me.lblCurrentPlayer.TabIndex = 1
        Me.lblCurrentPlayer.Text = "Current Player: "
        Me.lblCurrentPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMoney
        '
        Me.lblMoney.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMoney.AutoSize = True
        Me.lblMoney.BackColor = System.Drawing.Color.Transparent
        Me.lblMoney.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblMoney.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblMoney.Location = New System.Drawing.Point(571, 68)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(104, 26)
        Me.lblMoney.TabIndex = 1
        Me.lblMoney.Text = "Earnings:"
        Me.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblReponse
        '
        Me.lblReponse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblReponse.BackColor = System.Drawing.Color.Transparent
        Me.lblReponse.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReponse.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblReponse.Location = New System.Drawing.Point(229, 465)
        Me.lblReponse.Name = "lblReponse"
        Me.lblReponse.Size = New System.Drawing.Size(316, 26)
        Me.lblReponse.TabIndex = 4
        Me.lblReponse.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnPass
        '
        Me.btnPass.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPass.BackColor = System.Drawing.Color.Transparent
        Me.btnPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPass.ForeColor = System.Drawing.Color.Black
        Me.btnPass.Location = New System.Drawing.Point(244, 420)
        Me.btnPass.Name = "btnPass"
        Me.btnPass.Size = New System.Drawing.Size(286, 36)
        Me.btnPass.TabIndex = 5
        Me.btnPass.Text = "Pass"
        Me.btnPass.UseVisualStyleBackColor = False
        '
        'FrmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(775, 500)
        Me.Controls.Add(Me.btnPass)
        Me.Controls.Add(Me.lblReponse)
        Me.Controls.Add(Me.btnOption4)
        Me.Controls.Add(Me.btnOption3)
        Me.Controls.Add(Me.btnOption2)
        Me.Controls.Add(Me.btnOption1)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.lblCurrentPlayer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblRound)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmGame"
        Me.Text = "Game"
        Me.TransparencyKey = System.Drawing.SystemColors.MenuHighlight
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRound As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents btnOption1 As Button
    Friend WithEvents btnOption2 As Button
    Friend WithEvents btnOption3 As Button
    Friend WithEvents btnOption4 As Button
    Friend WithEvents lblCurrentPlayer As Label
    Friend WithEvents lblMoney As Label
    Friend WithEvents lblReponse As Label
    Friend WithEvents btnPass As Button
End Class
