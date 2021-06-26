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
        Me.lblRound = New System.Windows.Forms.Label()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btnOption1 = New System.Windows.Forms.Button()
        Me.btnOption2 = New System.Windows.Forms.Button()
        Me.btnOption3 = New System.Windows.Forms.Button()
        Me.btnOption4 = New System.Windows.Forms.Button()
        Me.lblFeedback = New System.Windows.Forms.Label()
        Me.lblCurrentPlayer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblRound
        '
        Me.lblRound.AutoSize = True
        Me.lblRound.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRound.Location = New System.Drawing.Point(43, 20)
        Me.lblRound.Name = "lblRound"
        Me.lblRound.Size = New System.Drawing.Size(108, 31)
        Me.lblRound.TabIndex = 0
        Me.lblRound.Text = "Round:"
        '
        'lblQuestion
        '
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblQuestion.Location = New System.Drawing.Point(19, 116)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(762, 67)
        Me.lblQuestion.TabIndex = 1
        Me.lblQuestion.Text = "Question: "
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnOption1
        '
        Me.btnOption1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption1.Location = New System.Drawing.Point(142, 186)
        Me.btnOption1.Name = "btnOption1"
        Me.btnOption1.Size = New System.Drawing.Size(225, 75)
        Me.btnOption1.TabIndex = 2
        Me.btnOption1.UseVisualStyleBackColor = True
        '
        'btnOption2
        '
        Me.btnOption2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption2.Location = New System.Drawing.Point(433, 186)
        Me.btnOption2.Name = "btnOption2"
        Me.btnOption2.Size = New System.Drawing.Size(225, 75)
        Me.btnOption2.TabIndex = 2
        Me.btnOption2.UseVisualStyleBackColor = True
        '
        'btnOption3
        '
        Me.btnOption3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption3.Location = New System.Drawing.Point(142, 308)
        Me.btnOption3.Name = "btnOption3"
        Me.btnOption3.Size = New System.Drawing.Size(225, 75)
        Me.btnOption3.TabIndex = 2
        Me.btnOption3.UseVisualStyleBackColor = True
        '
        'btnOption4
        '
        Me.btnOption4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOption4.Location = New System.Drawing.Point(433, 308)
        Me.btnOption4.Name = "btnOption4"
        Me.btnOption4.Size = New System.Drawing.Size(225, 75)
        Me.btnOption4.TabIndex = 2
        Me.btnOption4.UseVisualStyleBackColor = True
        '
        'lblFeedback
        '
        Me.lblFeedback.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedback.Location = New System.Drawing.Point(51, 404)
        Me.lblFeedback.Name = "lblFeedback"
        Me.lblFeedback.Size = New System.Drawing.Size(698, 24)
        Me.lblFeedback.TabIndex = 3
        Me.lblFeedback.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCurrentPlayer
        '
        Me.lblCurrentPlayer.AutoSize = True
        Me.lblCurrentPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lblCurrentPlayer.Location = New System.Drawing.Point(510, 25)
        Me.lblCurrentPlayer.Name = "lblCurrentPlayer"
        Me.lblCurrentPlayer.Size = New System.Drawing.Size(164, 26)
        Me.lblCurrentPlayer.TabIndex = 1
        Me.lblCurrentPlayer.Text = "Current Player: "
        '
        'FrmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblFeedback)
        Me.Controls.Add(Me.btnOption4)
        Me.Controls.Add(Me.btnOption3)
        Me.Controls.Add(Me.btnOption2)
        Me.Controls.Add(Me.btnOption1)
        Me.Controls.Add(Me.lblCurrentPlayer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Controls.Add(Me.lblRound)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmGame"
        Me.Text = "Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRound As Label
    Friend WithEvents lblQuestion As Label
    Friend WithEvents btnOption1 As Button
    Friend WithEvents btnOption2 As Button
    Friend WithEvents btnOption3 As Button
    Friend WithEvents btnOption4 As Button
    Friend WithEvents lblFeedback As Label
    Friend WithEvents lblCurrentPlayer As Label
End Class
