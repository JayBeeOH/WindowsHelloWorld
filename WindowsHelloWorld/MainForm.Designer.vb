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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.EnglishButton = New System.Windows.Forms.Button()
        Me.GermanButton = New System.Windows.Forms.Button()
        Me.FrenchButton = New System.Windows.Forms.Button()
        Me.SpainishButton = New System.Windows.Forms.Button()
        Me.PirateButton = New System.Windows.Forms.Button()
        Me.PigLatinButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ResultLabel
        '
        Me.ResultLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResultLabel.BackColor = System.Drawing.Color.White
        Me.ResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ResultLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultLabel.Location = New System.Drawing.Point(12, 9)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(273, 52)
        Me.ResultLabel.TabIndex = 0
        Me.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EnglishButton
        '
        Me.EnglishButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EnglishButton.Location = New System.Drawing.Point(12, 84)
        Me.EnglishButton.Name = "EnglishButton"
        Me.EnglishButton.Size = New System.Drawing.Size(87, 28)
        Me.EnglishButton.TabIndex = 1
        Me.EnglishButton.Text = "&English"
        Me.EnglishButton.UseVisualStyleBackColor = True
        '
        'GermanButton
        '
        Me.GermanButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GermanButton.Location = New System.Drawing.Point(105, 84)
        Me.GermanButton.Name = "GermanButton"
        Me.GermanButton.Size = New System.Drawing.Size(87, 28)
        Me.GermanButton.TabIndex = 2
        Me.GermanButton.Text = "&German"
        Me.GermanButton.UseVisualStyleBackColor = True
        '
        'FrenchButton
        '
        Me.FrenchButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FrenchButton.Location = New System.Drawing.Point(198, 84)
        Me.FrenchButton.Name = "FrenchButton"
        Me.FrenchButton.Size = New System.Drawing.Size(87, 28)
        Me.FrenchButton.TabIndex = 3
        Me.FrenchButton.Text = "&French"
        Me.FrenchButton.UseVisualStyleBackColor = True
        '
        'SpainishButton
        '
        Me.SpainishButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SpainishButton.Location = New System.Drawing.Point(12, 117)
        Me.SpainishButton.Name = "SpainishButton"
        Me.SpainishButton.Size = New System.Drawing.Size(87, 28)
        Me.SpainishButton.TabIndex = 4
        Me.SpainishButton.Text = "&Spanish"
        Me.SpainishButton.UseVisualStyleBackColor = True
        '
        'PirateButton
        '
        Me.PirateButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PirateButton.Location = New System.Drawing.Point(198, 117)
        Me.PirateButton.Name = "PirateButton"
        Me.PirateButton.Size = New System.Drawing.Size(87, 28)
        Me.PirateButton.TabIndex = 5
        Me.PirateButton.Text = "Pi&rate"
        Me.PirateButton.UseVisualStyleBackColor = True
        '
        'PigLatinButton
        '
        Me.PigLatinButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PigLatinButton.Location = New System.Drawing.Point(105, 117)
        Me.PigLatinButton.Name = "PigLatinButton"
        Me.PigLatinButton.Size = New System.Drawing.Size(87, 28)
        Me.PigLatinButton.TabIndex = 6
        Me.PigLatinButton.Text = "&Pig Latin"
        Me.PigLatinButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 158)
        Me.Controls.Add(Me.PigLatinButton)
        Me.Controls.Add(Me.PirateButton)
        Me.Controls.Add(Me.SpainishButton)
        Me.Controls.Add(Me.FrenchButton)
        Me.Controls.Add(Me.GermanButton)
        Me.Controls.Add(Me.EnglishButton)
        Me.Controls.Add(Me.ResultLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(314, 197)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(314, 197)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hello World"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ResultLabel As Label
    Friend WithEvents EnglishButton As Button
    Friend WithEvents GermanButton As Button
    Friend WithEvents FrenchButton As Button
    Friend WithEvents SpainishButton As Button
    Friend WithEvents PirateButton As Button
    Friend WithEvents PigLatinButton As Button
End Class
