<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.ClickMeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ResultLabel
        '
        Me.ResultLabel.BackColor = System.Drawing.Color.White
        Me.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ResultLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultLabel.Location = New System.Drawing.Point(30, 21)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(310, 52)
        Me.ResultLabel.TabIndex = 0
        Me.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClickMeButton
        '
        Me.ClickMeButton.Location = New System.Drawing.Point(253, 99)
        Me.ClickMeButton.Name = "ClickMeButton"
        Me.ClickMeButton.Size = New System.Drawing.Size(87, 27)
        Me.ClickMeButton.TabIndex = 1
        Me.ClickMeButton.Text = "&Click Me"
        Me.ClickMeButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 140)
        Me.Controls.Add(Me.ClickMeButton)
        Me.Controls.Add(Me.ResultLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainForm"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ResultLabel As Label
    Friend WithEvents ClickMeButton As Button
End Class
