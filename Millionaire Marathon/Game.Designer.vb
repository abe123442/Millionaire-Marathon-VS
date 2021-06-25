<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGame
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
        Me.lbl_round = New System.Windows.Forms.Label()
        Me.lbl_question = New System.Windows.Forms.Label()
        Me.BtnOption1 = New System.Windows.Forms.Button()
        Me.BtnOption2 = New System.Windows.Forms.Button()
        Me.BtnOption3 = New System.Windows.Forms.Button()
        Me.BtnOption4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_round
        '
        Me.lbl_round.AutoSize = True
        Me.lbl_round.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_round.Location = New System.Drawing.Point(346, 35)
        Me.lbl_round.Name = "lbl_round"
        Me.lbl_round.Size = New System.Drawing.Size(108, 31)
        Me.lbl_round.TabIndex = 0
        Me.lbl_round.Text = "Round:"
        '
        'lbl_question
        '
        Me.lbl_question.AutoSize = True
        Me.lbl_question.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.lbl_question.Location = New System.Drawing.Point(44, 110)
        Me.lbl_question.Name = "lbl_question"
        Me.lbl_question.Size = New System.Drawing.Size(111, 26)
        Me.lbl_question.TabIndex = 1
        Me.lbl_question.Text = "Question: "
        '
        'BtnOption1
        '
        Me.BtnOption1.Location = New System.Drawing.Point(169, 155)
        Me.BtnOption1.Name = "BtnOption1"
        Me.BtnOption1.Size = New System.Drawing.Size(181, 87)
        Me.BtnOption1.TabIndex = 2
        Me.BtnOption1.UseVisualStyleBackColor = True
        '
        'BtnOption2
        '
        Me.BtnOption2.Location = New System.Drawing.Point(451, 155)
        Me.BtnOption2.Name = "BtnOption2"
        Me.BtnOption2.Size = New System.Drawing.Size(181, 87)
        Me.BtnOption2.TabIndex = 2
        Me.BtnOption2.UseVisualStyleBackColor = True
        '
        'BtnOption3
        '
        Me.BtnOption3.Location = New System.Drawing.Point(169, 298)
        Me.BtnOption3.Name = "BtnOption3"
        Me.BtnOption3.Size = New System.Drawing.Size(181, 87)
        Me.BtnOption3.TabIndex = 2
        Me.BtnOption3.UseVisualStyleBackColor = True
        '
        'BtnOption4
        '
        Me.BtnOption4.Location = New System.Drawing.Point(451, 298)
        Me.BtnOption4.Name = "BtnOption4"
        Me.BtnOption4.Size = New System.Drawing.Size(181, 87)
        Me.BtnOption4.TabIndex = 2
        Me.BtnOption4.UseVisualStyleBackColor = True
        '
        'FrmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnOption4)
        Me.Controls.Add(Me.BtnOption3)
        Me.Controls.Add(Me.BtnOption2)
        Me.Controls.Add(Me.BtnOption1)
        Me.Controls.Add(Me.lbl_question)
        Me.Controls.Add(Me.lbl_round)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmGame"
        Me.Text = "Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_round As Label
    Friend WithEvents lbl_question As Label
    Friend WithEvents BtnOption1 As Button
    Friend WithEvents BtnOption2 As Button
    Friend WithEvents BtnOption3 As Button
    Friend WithEvents BtnOption4 As Button
End Class
