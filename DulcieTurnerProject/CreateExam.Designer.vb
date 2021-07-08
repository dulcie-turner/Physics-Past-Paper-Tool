<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateExam
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
        Me.createExamGroupBox = New System.Windows.Forms.GroupBox()
        Me.numMarksLabel = New System.Windows.Forms.Label()
        Me.numMarksSelector = New System.Windows.Forms.NumericUpDown()
        Me.timeEstimate = New System.Windows.Forms.Label()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.selectAllButton = New System.Windows.Forms.Button()
        Me.backButton = New System.Windows.Forms.Button()
        Me.countdownCheckBox = New System.Windows.Forms.CheckBox()
        Me.countdownLabel = New System.Windows.Forms.Label()
        Me.countdownUpDown = New System.Windows.Forms.NumericUpDown()
        CType(Me.numMarksSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.countdownUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'createExamGroupBox
        '
        Me.createExamGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createExamGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.createExamGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.createExamGroupBox.Name = "createExamGroupBox"
        Me.createExamGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.createExamGroupBox.Size = New System.Drawing.Size(528, 426)
        Me.createExamGroupBox.TabIndex = 27
        Me.createExamGroupBox.TabStop = False
        Me.createExamGroupBox.Text = "Create Paper"
        '
        'numMarksLabel
        '
        Me.numMarksLabel.AutoSize = True
        Me.numMarksLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numMarksLabel.Location = New System.Drawing.Point(573, 81)
        Me.numMarksLabel.Name = "numMarksLabel"
        Me.numMarksLabel.Size = New System.Drawing.Size(153, 20)
        Me.numMarksLabel.TabIndex = 28
        Me.numMarksLabel.Text = "Number of Marks"
        '
        'numMarksSelector
        '
        Me.numMarksSelector.Location = New System.Drawing.Point(572, 103)
        Me.numMarksSelector.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.numMarksSelector.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.numMarksSelector.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numMarksSelector.Name = "numMarksSelector"
        Me.numMarksSelector.Size = New System.Drawing.Size(149, 22)
        Me.numMarksSelector.TabIndex = 29
        Me.numMarksSelector.Value = New Decimal(New Integer() {80, 0, 0, 0})
        '
        'timeEstimate
        '
        Me.timeEstimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeEstimate.Location = New System.Drawing.Point(567, 142)
        Me.timeEstimate.Name = "timeEstimate"
        Me.timeEstimate.Size = New System.Drawing.Size(159, 73)
        Me.timeEstimate.TabIndex = 30
        Me.timeEstimate.Text = "This should take about "
        Me.timeEstimate.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'submitButton
        '
        Me.submitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitButton.Location = New System.Drawing.Point(564, 383)
        Me.submitButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(224, 54)
        Me.submitButton.TabIndex = 31
        Me.submitButton.Text = "Create Paper"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'selectAllButton
        '
        Me.selectAllButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectAllButton.Location = New System.Drawing.Point(643, 334)
        Me.selectAllButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.selectAllButton.Name = "selectAllButton"
        Me.selectAllButton.Size = New System.Drawing.Size(147, 43)
        Me.selectAllButton.TabIndex = 32
        Me.selectAllButton.Text = "Select All Topics"
        Me.selectAllButton.UseVisualStyleBackColor = True
        '
        'backButton
        '
        Me.backButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.Location = New System.Drawing.Point(641, 286)
        Me.backButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(147, 43)
        Me.backButton.TabIndex = 33
        Me.backButton.Text = "Back to Menu"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'countdownCheckBox
        '
        Me.countdownCheckBox.AutoSize = True
        Me.countdownCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countdownCheckBox.Location = New System.Drawing.Point(595, 184)
        Me.countdownCheckBox.Name = "countdownCheckBox"
        Me.countdownCheckBox.Size = New System.Drawing.Size(153, 21)
        Me.countdownCheckBox.TabIndex = 30
        Me.countdownCheckBox.Text = "Countdown Mode"
        Me.countdownCheckBox.UseVisualStyleBackColor = True
        '
        'countdownLabel
        '
        Me.countdownLabel.AutoSize = True
        Me.countdownLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countdownLabel.Location = New System.Drawing.Point(561, 215)
        Me.countdownLabel.Name = "countdownLabel"
        Me.countdownLabel.Size = New System.Drawing.Size(224, 17)
        Me.countdownLabel.TabIndex = 34
        Me.countdownLabel.Text = "Stop exam after                 minutes"
        Me.countdownLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.countdownLabel.Visible = False
        '
        'countdownUpDown
        '
        Me.countdownUpDown.Location = New System.Drawing.Point(669, 213)
        Me.countdownUpDown.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.countdownUpDown.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.countdownUpDown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.countdownUpDown.Name = "countdownUpDown"
        Me.countdownUpDown.Size = New System.Drawing.Size(57, 22)
        Me.countdownUpDown.TabIndex = 35
        Me.countdownUpDown.Value = New Decimal(New Integer() {120, 0, 0, 0})
        Me.countdownUpDown.Visible = False
        '
        'CreateExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.countdownUpDown)
        Me.Controls.Add(Me.countdownCheckBox)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.selectAllButton)
        Me.Controls.Add(Me.submitButton)
        Me.Controls.Add(Me.timeEstimate)
        Me.Controls.Add(Me.numMarksSelector)
        Me.Controls.Add(Me.numMarksLabel)
        Me.Controls.Add(Me.createExamGroupBox)
        Me.Controls.Add(Me.countdownLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "CreateExam"
        Me.Text = "Create Exam"
        CType(Me.numMarksSelector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.countdownUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents createExamGroupBox As GroupBox
    Friend WithEvents numMarksLabel As Label
    Friend WithEvents numMarksSelector As NumericUpDown
    Friend WithEvents timeEstimate As Label
    Friend WithEvents submitButton As Button
    Friend WithEvents selectAllButton As Button
    Friend WithEvents backButton As Button
    Friend WithEvents countdownCheckBox As CheckBox
    Friend WithEvents countdownLabel As Label
    Friend WithEvents countdownUpDown As NumericUpDown
End Class
