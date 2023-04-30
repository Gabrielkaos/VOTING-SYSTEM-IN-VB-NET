<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuestForm
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
        Me.LastNameBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FirstNameBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SectionBox = New System.Windows.Forms.TextBox()
        Me.ReadRulesButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ContinueButton = New System.Windows.Forms.Button()
        Me.GoBackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(316, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome To The Election"
        '
        'LastNameBox
        '
        Me.LastNameBox.Location = New System.Drawing.Point(346, 150)
        Me.LastNameBox.Name = "LastNameBox"
        Me.LastNameBox.Size = New System.Drawing.Size(182, 22)
        Me.LastNameBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(255, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(254, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "First Name:"
        '
        'FirstNameBox
        '
        Me.FirstNameBox.Location = New System.Drawing.Point(346, 195)
        Me.FirstNameBox.Name = "FirstNameBox"
        Me.FirstNameBox.Size = New System.Drawing.Size(182, 22)
        Me.FirstNameBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(200, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Grade and Section:"
        '
        'SectionBox
        '
        Me.SectionBox.Location = New System.Drawing.Point(346, 239)
        Me.SectionBox.Name = "SectionBox"
        Me.SectionBox.Size = New System.Drawing.Size(182, 22)
        Me.SectionBox.TabIndex = 7
        '
        'ReadRulesButton
        '
        Me.ReadRulesButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReadRulesButton.Location = New System.Drawing.Point(346, 390)
        Me.ReadRulesButton.Name = "ReadRulesButton"
        Me.ReadRulesButton.Size = New System.Drawing.Size(117, 54)
        Me.ReadRulesButton.TabIndex = 9
        Me.ReadRulesButton.Text = "Read The Rules"
        Me.ReadRulesButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(167, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(494, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Make sure you follow the rules in voting before continuing"
        '
        'ContinueButton
        '
        Me.ContinueButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinueButton.Location = New System.Drawing.Point(500, 623)
        Me.ContinueButton.Name = "ContinueButton"
        Me.ContinueButton.Size = New System.Drawing.Size(107, 51)
        Me.ContinueButton.TabIndex = 11
        Me.ContinueButton.Text = "Continue"
        Me.ContinueButton.UseVisualStyleBackColor = True
        '
        'GoBackButton
        '
        Me.GoBackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GoBackButton.Location = New System.Drawing.Point(196, 623)
        Me.GoBackButton.Name = "GoBackButton"
        Me.GoBackButton.Size = New System.Drawing.Size(107, 51)
        Me.GoBackButton.TabIndex = 12
        Me.GoBackButton.Text = "Go Back"
        Me.GoBackButton.UseVisualStyleBackColor = True
        '
        'GuestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 738)
        Me.Controls.Add(Me.GoBackButton)
        Me.Controls.Add(Me.ContinueButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ReadRulesButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SectionBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FirstNameBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LastNameBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GuestForm"
        Me.Text = "Guest Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LastNameBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FirstNameBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SectionBox As TextBox
    Friend WithEvents ReadRulesButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ContinueButton As Button
    Friend WithEvents GoBackButton As Button
End Class
