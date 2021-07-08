<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addQuestion
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
        Me.markSchemeImageLabel = New System.Windows.Forms.Label()
        Me.examinerReportImageLabel = New System.Windows.Forms.Label()
        Me.submitButton = New System.Windows.Forms.Button()
        Me.markSchemeImageButton = New System.Windows.Forms.Button()
        Me.examinerReportImageButton = New System.Windows.Forms.Button()
        Me.msFilePathLabel = New System.Windows.Forms.Label()
        Me.erFilePathLabel = New System.Windows.Forms.Label()
        Me.topicLabel = New System.Windows.Forms.Label()
        Me.subtopicLabel = New System.Windows.Forms.Label()
        Me.questionImageLabel = New System.Windows.Forms.Label()
        Me.yearLabel = New System.Windows.Forms.Label()
        Me.marksLabel = New System.Windows.Forms.Label()
        Me.multipleChoiceLabel = New System.Windows.Forms.Label()
        Me.topicComboBox = New System.Windows.Forms.ComboBox()
        Me.subtopicComboBox = New System.Windows.Forms.ComboBox()
        Me.questionImageButton = New System.Windows.Forms.Button()
        Me.yearTextBox = New System.Windows.Forms.TextBox()
        Me.marksAvailableTextBox = New System.Windows.Forms.TextBox()
        Me.multipleChoiceCheckBox = New System.Windows.Forms.CheckBox()
        Me.multipleChoiceTextBox = New System.Windows.Forms.TextBox()
        Me.questionFilePathLabel = New System.Windows.Forms.Label()
        Me.questionGroupBox = New System.Windows.Forms.GroupBox()
        Me.msGroupBox = New System.Windows.Forms.GroupBox()
        Me.erGroupBox = New System.Windows.Forms.GroupBox()
        Me.backButton = New System.Windows.Forms.Button()
        Me.questionGroupBox.SuspendLayout()
        Me.msGroupBox.SuspendLayout()
        Me.erGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'markSchemeImageLabel
        '
        Me.markSchemeImageLabel.AutoSize = True
        Me.markSchemeImageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.markSchemeImageLabel.Location = New System.Drawing.Point(11, 89)
        Me.markSchemeImageLabel.Name = "markSchemeImageLabel"
        Me.markSchemeImageLabel.Size = New System.Drawing.Size(162, 20)
        Me.markSchemeImageLabel.TabIndex = 9
        Me.markSchemeImageLabel.Text = "Mark Scheme Image"
        '
        'examinerReportImageLabel
        '
        Me.examinerReportImageLabel.AutoSize = True
        Me.examinerReportImageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examinerReportImageLabel.Location = New System.Drawing.Point(8, 94)
        Me.examinerReportImageLabel.Name = "examinerReportImageLabel"
        Me.examinerReportImageLabel.Size = New System.Drawing.Size(184, 20)
        Me.examinerReportImageLabel.TabIndex = 10
        Me.examinerReportImageLabel.Text = "Examiner Report Image"
        '
        'submitButton
        '
        Me.submitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submitButton.Location = New System.Drawing.Point(19, 383)
        Me.submitButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.submitButton.Name = "submitButton"
        Me.submitButton.Size = New System.Drawing.Size(381, 55)
        Me.submitButton.TabIndex = 10
        Me.submitButton.Text = "Submit"
        Me.submitButton.UseVisualStyleBackColor = True
        '
        'markSchemeImageButton
        '
        Me.markSchemeImageButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.markSchemeImageButton.Location = New System.Drawing.Point(219, 86)
        Me.markSchemeImageButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.markSchemeImageButton.Name = "markSchemeImageButton"
        Me.markSchemeImageButton.Size = New System.Drawing.Size(93, 23)
        Me.markSchemeImageButton.TabIndex = 8
        Me.markSchemeImageButton.Text = "Browse..."
        Me.markSchemeImageButton.UseVisualStyleBackColor = True
        '
        'examinerReportImageButton
        '
        Me.examinerReportImageButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.examinerReportImageButton.Location = New System.Drawing.Point(216, 91)
        Me.examinerReportImageButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.examinerReportImageButton.Name = "examinerReportImageButton"
        Me.examinerReportImageButton.Size = New System.Drawing.Size(93, 23)
        Me.examinerReportImageButton.TabIndex = 9
        Me.examinerReportImageButton.Text = "Browse..."
        Me.examinerReportImageButton.UseVisualStyleBackColor = True
        '
        'msFilePathLabel
        '
        Me.msFilePathLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.msFilePathLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msFilePathLabel.Location = New System.Drawing.Point(13, 112)
        Me.msFilePathLabel.Name = "msFilePathLabel"
        Me.msFilePathLabel.Size = New System.Drawing.Size(299, 17)
        Me.msFilePathLabel.TabIndex = 23
        Me.msFilePathLabel.Text = "File Path"
        Me.msFilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.msFilePathLabel.Visible = False
        '
        'erFilePathLabel
        '
        Me.erFilePathLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.erFilePathLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erFilePathLabel.Location = New System.Drawing.Point(5, 117)
        Me.erFilePathLabel.Name = "erFilePathLabel"
        Me.erFilePathLabel.Size = New System.Drawing.Size(304, 18)
        Me.erFilePathLabel.TabIndex = 24
        Me.erFilePathLabel.Text = "File Path"
        Me.erFilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.erFilePathLabel.Visible = False
        '
        'topicLabel
        '
        Me.topicLabel.AutoSize = True
        Me.topicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topicLabel.Location = New System.Drawing.Point(15, 50)
        Me.topicLabel.Name = "topicLabel"
        Me.topicLabel.Size = New System.Drawing.Size(50, 20)
        Me.topicLabel.TabIndex = 3
        Me.topicLabel.Text = "Topic"
        '
        'subtopicLabel
        '
        Me.subtopicLabel.AutoSize = True
        Me.subtopicLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtopicLabel.Location = New System.Drawing.Point(15, 98)
        Me.subtopicLabel.Name = "subtopicLabel"
        Me.subtopicLabel.Size = New System.Drawing.Size(74, 20)
        Me.subtopicLabel.TabIndex = 4
        Me.subtopicLabel.Text = "Subtopic"
        '
        'questionImageLabel
        '
        Me.questionImageLabel.AutoSize = True
        Me.questionImageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionImageLabel.Location = New System.Drawing.Point(15, 146)
        Me.questionImageLabel.Name = "questionImageLabel"
        Me.questionImageLabel.Size = New System.Drawing.Size(126, 20)
        Me.questionImageLabel.TabIndex = 5
        Me.questionImageLabel.Text = "Question Image"
        '
        'yearLabel
        '
        Me.yearLabel.AutoSize = True
        Me.yearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearLabel.Location = New System.Drawing.Point(15, 194)
        Me.yearLabel.Name = "yearLabel"
        Me.yearLabel.Size = New System.Drawing.Size(100, 20)
        Me.yearLabel.TabIndex = 6
        Me.yearLabel.Text = "Year of Test"
        '
        'marksLabel
        '
        Me.marksLabel.AutoSize = True
        Me.marksLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marksLabel.Location = New System.Drawing.Point(15, 242)
        Me.marksLabel.Name = "marksLabel"
        Me.marksLabel.Size = New System.Drawing.Size(127, 20)
        Me.marksLabel.TabIndex = 7
        Me.marksLabel.Text = "Marks Available"
        '
        'multipleChoiceLabel
        '
        Me.multipleChoiceLabel.AutoSize = True
        Me.multipleChoiceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multipleChoiceLabel.Location = New System.Drawing.Point(15, 290)
        Me.multipleChoiceLabel.Name = "multipleChoiceLabel"
        Me.multipleChoiceLabel.Size = New System.Drawing.Size(133, 20)
        Me.multipleChoiceLabel.TabIndex = 8
        Me.multipleChoiceLabel.Text = "Multiple Choice?"
        '
        'topicComboBox
        '
        Me.topicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.topicComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topicComboBox.FormattingEnabled = True
        Me.topicComboBox.Location = New System.Drawing.Point(184, 46)
        Me.topicComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.topicComboBox.Name = "topicComboBox"
        Me.topicComboBox.Size = New System.Drawing.Size(215, 24)
        Me.topicComboBox.TabIndex = 1
        '
        'subtopicComboBox
        '
        Me.subtopicComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.subtopicComboBox.Enabled = False
        Me.subtopicComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtopicComboBox.FormattingEnabled = True
        Me.subtopicComboBox.Location = New System.Drawing.Point(184, 91)
        Me.subtopicComboBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.subtopicComboBox.Name = "subtopicComboBox"
        Me.subtopicComboBox.Size = New System.Drawing.Size(215, 24)
        Me.subtopicComboBox.TabIndex = 2
        '
        'questionImageButton
        '
        Me.questionImageButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionImageButton.Location = New System.Drawing.Point(253, 135)
        Me.questionImageButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.questionImageButton.Name = "questionImageButton"
        Me.questionImageButton.Size = New System.Drawing.Size(144, 30)
        Me.questionImageButton.TabIndex = 3
        Me.questionImageButton.Text = "Browse..."
        Me.questionImageButton.UseVisualStyleBackColor = True
        '
        'yearTextBox
        '
        Me.yearTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearTextBox.Location = New System.Drawing.Point(315, 191)
        Me.yearTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.yearTextBox.Name = "yearTextBox"
        Me.yearTextBox.Size = New System.Drawing.Size(84, 27)
        Me.yearTextBox.TabIndex = 4
        '
        'marksAvailableTextBox
        '
        Me.marksAvailableTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.marksAvailableTextBox.Location = New System.Drawing.Point(315, 238)
        Me.marksAvailableTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.marksAvailableTextBox.Name = "marksAvailableTextBox"
        Me.marksAvailableTextBox.Size = New System.Drawing.Size(84, 27)
        Me.marksAvailableTextBox.TabIndex = 5
        '
        'multipleChoiceCheckBox
        '
        Me.multipleChoiceCheckBox.AutoSize = True
        Me.multipleChoiceCheckBox.Location = New System.Drawing.Point(380, 288)
        Me.multipleChoiceCheckBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.multipleChoiceCheckBox.Name = "multipleChoiceCheckBox"
        Me.multipleChoiceCheckBox.Size = New System.Drawing.Size(18, 17)
        Me.multipleChoiceCheckBox.TabIndex = 6
        Me.multipleChoiceCheckBox.UseVisualStyleBackColor = True
        '
        'multipleChoiceTextBox
        '
        Me.multipleChoiceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multipleChoiceTextBox.Location = New System.Drawing.Point(315, 283)
        Me.multipleChoiceTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.multipleChoiceTextBox.Name = "multipleChoiceTextBox"
        Me.multipleChoiceTextBox.Size = New System.Drawing.Size(60, 27)
        Me.multipleChoiceTextBox.TabIndex = 7
        Me.multipleChoiceTextBox.Visible = False
        '
        'questionFilePathLabel
        '
        Me.questionFilePathLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.questionFilePathLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionFilePathLabel.Location = New System.Drawing.Point(184, 167)
        Me.questionFilePathLabel.Name = "questionFilePathLabel"
        Me.questionFilePathLabel.Size = New System.Drawing.Size(213, 20)
        Me.questionFilePathLabel.TabIndex = 22
        Me.questionFilePathLabel.Text = "File Path"
        Me.questionFilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.questionFilePathLabel.Visible = False
        '
        'questionGroupBox
        '
        Me.questionGroupBox.Controls.Add(Me.questionFilePathLabel)
        Me.questionGroupBox.Controls.Add(Me.multipleChoiceTextBox)
        Me.questionGroupBox.Controls.Add(Me.multipleChoiceCheckBox)
        Me.questionGroupBox.Controls.Add(Me.marksAvailableTextBox)
        Me.questionGroupBox.Controls.Add(Me.yearTextBox)
        Me.questionGroupBox.Controls.Add(Me.questionImageButton)
        Me.questionGroupBox.Controls.Add(Me.subtopicComboBox)
        Me.questionGroupBox.Controls.Add(Me.topicComboBox)
        Me.questionGroupBox.Controls.Add(Me.multipleChoiceLabel)
        Me.questionGroupBox.Controls.Add(Me.marksLabel)
        Me.questionGroupBox.Controls.Add(Me.yearLabel)
        Me.questionGroupBox.Controls.Add(Me.questionImageLabel)
        Me.questionGroupBox.Controls.Add(Me.subtopicLabel)
        Me.questionGroupBox.Controls.Add(Me.topicLabel)
        Me.questionGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.questionGroupBox.Location = New System.Drawing.Point(12, 11)
        Me.questionGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.questionGroupBox.Name = "questionGroupBox"
        Me.questionGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.questionGroupBox.Size = New System.Drawing.Size(413, 352)
        Me.questionGroupBox.TabIndex = 25
        Me.questionGroupBox.TabStop = False
        Me.questionGroupBox.Text = "Question Entry"
        '
        'msGroupBox
        '
        Me.msGroupBox.Controls.Add(Me.msFilePathLabel)
        Me.msGroupBox.Controls.Add(Me.markSchemeImageButton)
        Me.msGroupBox.Controls.Add(Me.markSchemeImageLabel)
        Me.msGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msGroupBox.Location = New System.Drawing.Point(443, 11)
        Me.msGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.msGroupBox.Name = "msGroupBox"
        Me.msGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.msGroupBox.Size = New System.Drawing.Size(324, 181)
        Me.msGroupBox.TabIndex = 26
        Me.msGroupBox.TabStop = False
        Me.msGroupBox.Text = "Mark Scheme Entry"
        '
        'erGroupBox
        '
        Me.erGroupBox.Controls.Add(Me.erFilePathLabel)
        Me.erGroupBox.Controls.Add(Me.examinerReportImageButton)
        Me.erGroupBox.Controls.Add(Me.examinerReportImageLabel)
        Me.erGroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erGroupBox.Location = New System.Drawing.Point(443, 209)
        Me.erGroupBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.erGroupBox.Name = "erGroupBox"
        Me.erGroupBox.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.erGroupBox.Size = New System.Drawing.Size(324, 154)
        Me.erGroupBox.TabIndex = 27
        Me.erGroupBox.TabStop = False
        Me.erGroupBox.Text = "Examiner Report Entry"
        '
        'backButton
        '
        Me.backButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backButton.Location = New System.Drawing.Point(652, 383)
        Me.backButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(115, 55)
        Me.backButton.TabIndex = 11
        Me.backButton.Text = "Back"
        Me.backButton.UseVisualStyleBackColor = True
        '
        'addQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.erGroupBox)
        Me.Controls.Add(Me.msGroupBox)
        Me.Controls.Add(Me.questionGroupBox)
        Me.Controls.Add(Me.submitButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "addQuestion"
        Me.Text = "Add Questions"
        Me.questionGroupBox.ResumeLayout(False)
        Me.questionGroupBox.PerformLayout()
        Me.msGroupBox.ResumeLayout(False)
        Me.msGroupBox.PerformLayout()
        Me.erGroupBox.ResumeLayout(False)
        Me.erGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents markSchemeImageLabel As Label
    Friend WithEvents examinerReportImageLabel As Label
    Friend WithEvents submitButton As Button
    Friend WithEvents markSchemeImageButton As Button
    Friend WithEvents examinerReportImageButton As Button
    Friend WithEvents msFilePathLabel As Label
    Friend WithEvents erFilePathLabel As Label
    Friend WithEvents topicLabel As Label
    Friend WithEvents subtopicLabel As Label
    Friend WithEvents questionImageLabel As Label
    Friend WithEvents yearLabel As Label
    Friend WithEvents marksLabel As Label
    Friend WithEvents multipleChoiceLabel As Label
    Friend WithEvents topicComboBox As ComboBox
    Friend WithEvents subtopicComboBox As ComboBox
    Friend WithEvents questionImageButton As Button
    Friend WithEvents yearTextBox As TextBox
    Friend WithEvents marksAvailableTextBox As TextBox
    Friend WithEvents multipleChoiceCheckBox As CheckBox
    Friend WithEvents multipleChoiceTextBox As TextBox
    Friend WithEvents questionFilePathLabel As Label
    Friend WithEvents questionGroupBox As GroupBox
    Friend WithEvents msGroupBox As GroupBox
    Friend WithEvents erGroupBox As GroupBox
    Friend WithEvents backButton As Button
End Class
