<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AuthorityForm
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
        Me.AdminButton = New System.Windows.Forms.Button()
        Me.GuestButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter Authority"
        '
        'AdminButton
        '
        Me.AdminButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminButton.Location = New System.Drawing.Point(141, 237)
        Me.AdminButton.Name = "AdminButton"
        Me.AdminButton.Size = New System.Drawing.Size(198, 102)
        Me.AdminButton.TabIndex = 1
        Me.AdminButton.Text = "Admin/Comelec"
        Me.AdminButton.UseVisualStyleBackColor = True
        '
        'GuestButton
        '
        Me.GuestButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GuestButton.Location = New System.Drawing.Point(417, 237)
        Me.GuestButton.Name = "GuestButton"
        Me.GuestButton.Size = New System.Drawing.Size(198, 102)
        Me.GuestButton.TabIndex = 2
        Me.GuestButton.Text = "Guest/Voter"
        Me.GuestButton.UseVisualStyleBackColor = True
        '
        'AuthorityForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 483)
        Me.Controls.Add(Me.GuestButton)
        Me.Controls.Add(Me.AdminButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AuthorityForm"
        Me.Text = "Authority"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AdminButton As Button
    Friend WithEvents GuestButton As Button
End Class
