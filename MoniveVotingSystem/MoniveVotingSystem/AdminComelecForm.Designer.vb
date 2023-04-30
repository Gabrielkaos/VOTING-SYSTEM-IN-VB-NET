<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminComelecForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PresidentBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.VicePresidentBox = New System.Windows.Forms.TextBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TreasurerBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SecretaryBox = New System.Windows.Forms.TextBox()
        Me.PartyNameBox = New System.Windows.Forms.TextBox()
        Me.GoBackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Party Name"
        '
        'PresidentBox
        '
        Me.PresidentBox.Location = New System.Drawing.Point(178, 151)
        Me.PresidentBox.Name = "PresidentBox"
        Me.PresidentBox.Size = New System.Drawing.Size(239, 22)
        Me.PresidentBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(98, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "President:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(66, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Vice President:"
        '
        'VicePresidentBox
        '
        Me.VicePresidentBox.Location = New System.Drawing.Point(178, 176)
        Me.VicePresidentBox.Name = "VicePresidentBox"
        Me.VicePresidentBox.Size = New System.Drawing.Size(239, 22)
        Me.VicePresidentBox.TabIndex = 6
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(337, 572)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(139, 53)
        Me.ClearButton.TabIndex = 11
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveButton.Location = New System.Drawing.Point(101, 572)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(139, 53)
        Me.SaveButton.TabIndex = 12
        Me.SaveButton.Text = "Save/Add New"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(96, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 18)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Treasurer:"
        '
        'TreasurerBox
        '
        Me.TreasurerBox.Location = New System.Drawing.Point(178, 247)
        Me.TreasurerBox.Name = "TreasurerBox"
        Me.TreasurerBox.Size = New System.Drawing.Size(239, 22)
        Me.TreasurerBox.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(98, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 18)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Secretary:"
        '
        'SecretaryBox
        '
        Me.SecretaryBox.Location = New System.Drawing.Point(178, 219)
        Me.SecretaryBox.Name = "SecretaryBox"
        Me.SecretaryBox.Size = New System.Drawing.Size(239, 22)
        Me.SecretaryBox.TabIndex = 13
        '
        'PartyNameBox
        '
        Me.PartyNameBox.Location = New System.Drawing.Point(178, 93)
        Me.PartyNameBox.Name = "PartyNameBox"
        Me.PartyNameBox.Size = New System.Drawing.Size(239, 22)
        Me.PartyNameBox.TabIndex = 23
        '
        'GoBackButton
        '
        Me.GoBackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoBackButton.Location = New System.Drawing.Point(230, 684)
        Me.GoBackButton.Name = "GoBackButton"
        Me.GoBackButton.Size = New System.Drawing.Size(119, 44)
        Me.GoBackButton.TabIndex = 24
        Me.GoBackButton.Text = "Go Back"
        Me.GoBackButton.UseVisualStyleBackColor = True
        '
        'AdminComelecForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 807)
        Me.Controls.Add(Me.GoBackButton)
        Me.Controls.Add(Me.PartyNameBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TreasurerBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.SecretaryBox)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.VicePresidentBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PresidentBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AdminComelecForm"
        Me.Text = "Admin/Comelec"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PresidentBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents VicePresidentBox As TextBox
    Friend WithEvents ClearButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents TreasurerBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents SecretaryBox As TextBox
    Friend WithEvents PartyNameBox As TextBox
    Friend WithEvents GoBackButton As Button
End Class
