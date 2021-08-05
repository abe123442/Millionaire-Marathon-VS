<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMillion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMillion))
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnDecline = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblChallenge = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(171, 272)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(200, 69)
        Me.btnAccept.TabIndex = 0
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnDecline
        '
        Me.btnDecline.Location = New System.Drawing.Point(404, 272)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Size = New System.Drawing.Size(200, 69)
        Me.btnDecline.TabIndex = 1
        Me.btnDecline.Text = "Decline"
        Me.btnDecline.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(251, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 31)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "The final question..."
        '
        'lblChallenge
        '
        Me.lblChallenge.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChallenge.BackColor = System.Drawing.Color.Transparent
        Me.lblChallenge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChallenge.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblChallenge.Location = New System.Drawing.Point(2, 136)
        Me.lblChallenge.Name = "lblChallenge"
        Me.lblChallenge.Size = New System.Drawing.Size(770, 24)
        Me.lblChallenge.TabIndex = 3
        Me.lblChallenge.Text = "The final question..."
        Me.lblChallenge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmMillion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(775, 500)
        Me.Controls.Add(Me.lblChallenge)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDecline)
        Me.Controls.Add(Me.btnAccept)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMillion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MillionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAccept As Button
    Friend WithEvents btnDecline As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblChallenge As Label
End Class
