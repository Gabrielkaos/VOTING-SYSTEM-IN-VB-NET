<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VotingForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PresidentComboBox = New System.Windows.Forms.ComboBox()
        Me.PartiesDatabaseDataSet = New MoniveVotingSystem.PartiesDatabaseDataSet()
        Me.PartiesDatabaseDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TreasurerComboBox = New System.Windows.Forms.ComboBox()
        Me.SecretaryComboBox = New System.Windows.Forms.ComboBox()
        Me.VicePresidentComboBox = New System.Windows.Forms.ComboBox()
        CType(Me.PartiesDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartiesDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(102, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "President:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Vice President:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Treasurer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(101, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Secretary:"
        '
        'PresidentComboBox
        '
        Me.PresidentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PartiesDatabaseDataSet, "Table1.President", True))
        Me.PresidentComboBox.FormattingEnabled = True
        Me.PresidentComboBox.Location = New System.Drawing.Point(204, 63)
        Me.PresidentComboBox.Name = "PresidentComboBox"
        Me.PresidentComboBox.Size = New System.Drawing.Size(288, 24)
        Me.PresidentComboBox.TabIndex = 4
        '
        'PartiesDatabaseDataSet
        '
        Me.PartiesDatabaseDataSet.DataSetName = "PartiesDatabaseDataSet"
        Me.PartiesDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PartiesDatabaseDataSetBindingSource
        '
        Me.PartiesDatabaseDataSetBindingSource.DataSource = Me.PartiesDatabaseDataSet
        Me.PartiesDatabaseDataSetBindingSource.Position = 0
        '
        'TreasurerComboBox
        '
        Me.TreasurerComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PartiesDatabaseDataSet, "Table1.President", True))
        Me.TreasurerComboBox.FormattingEnabled = True
        Me.TreasurerComboBox.Location = New System.Drawing.Point(204, 255)
        Me.TreasurerComboBox.Name = "TreasurerComboBox"
        Me.TreasurerComboBox.Size = New System.Drawing.Size(288, 24)
        Me.TreasurerComboBox.TabIndex = 5
        '
        'SecretaryComboBox
        '
        Me.SecretaryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PartiesDatabaseDataSet, "Table1.President", True))
        Me.SecretaryComboBox.FormattingEnabled = True
        Me.SecretaryComboBox.Location = New System.Drawing.Point(204, 187)
        Me.SecretaryComboBox.Name = "SecretaryComboBox"
        Me.SecretaryComboBox.Size = New System.Drawing.Size(288, 24)
        Me.SecretaryComboBox.TabIndex = 6
        '
        'VicePresidentComboBox
        '
        Me.VicePresidentComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PartiesDatabaseDataSet, "Table1.President", True))
        Me.VicePresidentComboBox.FormattingEnabled = True
        Me.VicePresidentComboBox.Location = New System.Drawing.Point(204, 125)
        Me.VicePresidentComboBox.Name = "VicePresidentComboBox"
        Me.VicePresidentComboBox.Size = New System.Drawing.Size(288, 24)
        Me.VicePresidentComboBox.TabIndex = 7
        '
        'VotingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.VicePresidentComboBox)
        Me.Controls.Add(Me.SecretaryComboBox)
        Me.Controls.Add(Me.TreasurerComboBox)
        Me.Controls.Add(Me.PresidentComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VotingForm"
        Me.Text = "Vote"
        CType(Me.PartiesDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartiesDatabaseDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PresidentComboBox As ComboBox
    Friend WithEvents PartiesDatabaseDataSet As PartiesDatabaseDataSet
    Friend WithEvents PartiesDatabaseDataSetBindingSource As BindingSource
    Friend WithEvents TreasurerComboBox As ComboBox
    Friend WithEvents SecretaryComboBox As ComboBox
    Friend WithEvents VicePresidentComboBox As ComboBox
End Class
