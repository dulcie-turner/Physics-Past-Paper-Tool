<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class viewCharts
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.accuracyButton = New System.Windows.Forms.Button()
        Me.errorButton = New System.Windows.Forms.Button()
        Me.timePMarkButton = New System.Windows.Forms.Button()
        Me.menuButton = New System.Windows.Forms.Button()
        Me.overviewButton = New System.Windows.Forms.Button()
        Me.topicButton = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.topicSelectBox = New System.Windows.Forms.ComboBox()
        Me.mcButton = New System.Windows.Forms.Button()
        Me.timingInfoPanel = New System.Windows.Forms.Panel()
        Me.timing1 = New System.Windows.Forms.Label()
        Me.timing2 = New System.Windows.Forms.Label()
        Me.timing3 = New System.Windows.Forms.Label()
        Me.timing4 = New System.Windows.Forms.Label()
        CType(Me.chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.timingInfoPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chart1.Legends.Add(Legend1)
        Me.chart1.Location = New System.Drawing.Point(0, -1)
        Me.chart1.Margin = New System.Windows.Forms.Padding(4)
        Me.chart1.Name = "chart1"
        Me.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "chartSeries"
        Me.chart1.Series.Add(Series1)
        Me.chart1.Size = New System.Drawing.Size(784, 494)
        Me.chart1.TabIndex = 0
        Me.chart1.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Title1.Name = "Title1"
        Title1.Text = "Chart Title"
        Me.chart1.Titles.Add(Title1)
        '
        'accuracyButton
        '
        Me.accuracyButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.accuracyButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.accuracyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accuracyButton.Location = New System.Drawing.Point(791, 14)
        Me.accuracyButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.accuracyButton.Name = "accuracyButton"
        Me.accuracyButton.Size = New System.Drawing.Size(208, 62)
        Me.accuracyButton.TabIndex = 2
        Me.accuracyButton.Text = "Accuracy"
        Me.accuracyButton.UseVisualStyleBackColor = False
        '
        'errorButton
        '
        Me.errorButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.errorButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.errorButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errorButton.Location = New System.Drawing.Point(791, 215)
        Me.errorButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.errorButton.Name = "errorButton"
        Me.errorButton.Size = New System.Drawing.Size(208, 62)
        Me.errorButton.TabIndex = 3
        Me.errorButton.Text = "Error Breakdown"
        Me.errorButton.UseVisualStyleBackColor = False
        '
        'timePMarkButton
        '
        Me.timePMarkButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timePMarkButton.BackColor = System.Drawing.SystemColors.ControlLight
        Me.timePMarkButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timePMarkButton.Location = New System.Drawing.Point(791, 114)
        Me.timePMarkButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.timePMarkButton.Name = "timePMarkButton"
        Me.timePMarkButton.Size = New System.Drawing.Size(208, 62)
        Me.timePMarkButton.TabIndex = 4
        Me.timePMarkButton.Text = "Time Per Mark"
        Me.timePMarkButton.UseVisualStyleBackColor = False
        '
        'menuButton
        '
        Me.menuButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuButton.Location = New System.Drawing.Point(791, 466)
        Me.menuButton.Margin = New System.Windows.Forms.Padding(4)
        Me.menuButton.Name = "menuButton"
        Me.menuButton.Size = New System.Drawing.Size(260, 73)
        Me.menuButton.TabIndex = 27
        Me.menuButton.Text = "Back to Menu"
        Me.menuButton.UseVisualStyleBackColor = True
        '
        'overviewButton
        '
        Me.overviewButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.overviewButton.Location = New System.Drawing.Point(4, 4)
        Me.overviewButton.Margin = New System.Windows.Forms.Padding(4)
        Me.overviewButton.Name = "overviewButton"
        Me.overviewButton.Size = New System.Drawing.Size(160, 39)
        Me.overviewButton.TabIndex = 28
        Me.overviewButton.Text = "Overview"
        Me.overviewButton.UseVisualStyleBackColor = True
        '
        'topicButton
        '
        Me.topicButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.topicButton.Location = New System.Drawing.Point(172, 4)
        Me.topicButton.Margin = New System.Windows.Forms.Padding(4)
        Me.topicButton.Name = "topicButton"
        Me.topicButton.Size = New System.Drawing.Size(172, 39)
        Me.topicButton.TabIndex = 29
        Me.topicButton.Text = "Topics"
        Me.topicButton.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.overviewButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.topicButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.topicSelectBox)
        Me.FlowLayoutPanel1.Controls.Add(Me.mcButton)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(16, 484)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(767, 55)
        Me.FlowLayoutPanel1.TabIndex = 32
        '
        'topicSelectBox
        '
        Me.topicSelectBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.topicSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.topicSelectBox.FormattingEnabled = True
        Me.topicSelectBox.Location = New System.Drawing.Point(352, 4)
        Me.topicSelectBox.Margin = New System.Windows.Forms.Padding(4)
        Me.topicSelectBox.Name = "topicSelectBox"
        Me.topicSelectBox.Size = New System.Drawing.Size(225, 24)
        Me.topicSelectBox.TabIndex = 32
        '
        'mcButton
        '
        Me.mcButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mcButton.Location = New System.Drawing.Point(585, 4)
        Me.mcButton.Margin = New System.Windows.Forms.Padding(4)
        Me.mcButton.Name = "mcButton"
        Me.mcButton.Size = New System.Drawing.Size(160, 39)
        Me.mcButton.TabIndex = 30
        Me.mcButton.Text = "Multiple Choice"
        Me.mcButton.UseVisualStyleBackColor = True
        '
        'timingInfoPanel
        '
        Me.timingInfoPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.timingInfoPanel.Controls.Add(Me.timing1)
        Me.timingInfoPanel.Controls.Add(Me.timing2)
        Me.timingInfoPanel.Controls.Add(Me.timing3)
        Me.timingInfoPanel.Controls.Add(Me.timing4)
        Me.timingInfoPanel.Location = New System.Drawing.Point(791, 330)
        Me.timingInfoPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.timingInfoPanel.Name = "timingInfoPanel"
        Me.timingInfoPanel.Size = New System.Drawing.Size(275, 95)
        Me.timingInfoPanel.TabIndex = 37
        '
        'timing1
        '
        Me.timing1.AutoSize = True
        Me.timing1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timing1.Location = New System.Drawing.Point(1, 0)
        Me.timing1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.timing1.Name = "timing1"
        Me.timing1.Size = New System.Drawing.Size(196, 17)
        Me.timing1.TabIndex = 41
        Me.timing1.Text = "Multiple Choice Questions"
        '
        'timing2
        '
        Me.timing2.AutoSize = True
        Me.timing2.Location = New System.Drawing.Point(1, 16)
        Me.timing2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.timing2.Name = "timing2"
        Me.timing2.Size = New System.Drawing.Size(268, 17)
        Me.timing2.TabIndex = 42
        Me.timing2.Text = "Should take about 110 seconds per mark"
        '
        'timing3
        '
        Me.timing3.AutoSize = True
        Me.timing3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timing3.Location = New System.Drawing.Point(1, 43)
        Me.timing3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.timing3.Name = "timing3"
        Me.timing3.Size = New System.Drawing.Size(230, 17)
        Me.timing3.TabIndex = 43
        Me.timing3.Text = "Non Multiple Choice Questions"
        '
        'timing4
        '
        Me.timing4.AutoSize = True
        Me.timing4.Location = New System.Drawing.Point(1, 59)
        Me.timing4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.timing4.Name = "timing4"
        Me.timing4.Size = New System.Drawing.Size(260, 17)
        Me.timing4.TabIndex = 44
        Me.timing4.Text = "Should take about 70 seconds per mark"
        '
        'viewCharts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1064, 542)
        Me.Controls.Add(Me.timingInfoPanel)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.menuButton)
        Me.Controls.Add(Me.timePMarkButton)
        Me.Controls.Add(Me.errorButton)
        Me.Controls.Add(Me.accuracyButton)
        Me.Controls.Add(Me.chart1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1082, 589)
        Me.MinimumSize = New System.Drawing.Size(1082, 589)
        Me.Name = "viewCharts"
        Me.Text = "View Progress Charts"
        CType(Me.chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.timingInfoPanel.ResumeLayout(False)
        Me.timingInfoPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chart1 As DataVisualization.Charting.Chart
    Friend WithEvents accuracyButton As Button
    Friend WithEvents errorButton As Button
    Friend WithEvents timePMarkButton As Button
    Friend WithEvents menuButton As Button
    Friend WithEvents overviewButton As Button
    Friend WithEvents topicButton As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents topicSelectBox As ComboBox
    Friend WithEvents mcButton As Button
    Friend WithEvents timingInfoPanel As Panel
    Friend WithEvents timing1 As Label
    Friend WithEvents timing2 As Label
    Friend WithEvents timing3 As Label
    Friend WithEvents timing4 As Label
End Class
