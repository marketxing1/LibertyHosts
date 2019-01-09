<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMain))
        Me.GetHostsButton = New System.Windows.Forms.Button()
        Me.CheckHostsButton = New System.Windows.Forms.Button()
        Me.ToolBoxButton = New System.Windows.Forms.Button()
        Me.Label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MinimizeButton = New System.Windows.Forms.PictureBox()
        Me.CloseButton = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GetHostsButton
        '
        Me.GetHostsButton.BackColor = System.Drawing.Color.White
        Me.GetHostsButton.Font = New System.Drawing.Font("DengXian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GetHostsButton.ForeColor = System.Drawing.Color.Black
        Me.GetHostsButton.Location = New System.Drawing.Point(20, 381)
        Me.GetHostsButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GetHostsButton.Name = "GetHostsButton"
        Me.GetHostsButton.Size = New System.Drawing.Size(273, 76)
        Me.GetHostsButton.TabIndex = 3
        Me.GetHostsButton.Text = "Update Hosts"
        Me.GetHostsButton.UseVisualStyleBackColor = False
        '
        'CheckHostsButton
        '
        Me.CheckHostsButton.BackColor = System.Drawing.Color.White
        Me.CheckHostsButton.Font = New System.Drawing.Font("DengXian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CheckHostsButton.ForeColor = System.Drawing.Color.Black
        Me.CheckHostsButton.Location = New System.Drawing.Point(314, 381)
        Me.CheckHostsButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckHostsButton.Name = "CheckHostsButton"
        Me.CheckHostsButton.Size = New System.Drawing.Size(273, 76)
        Me.CheckHostsButton.TabIndex = 4
        Me.CheckHostsButton.Text = "Check Connectivity"
        Me.CheckHostsButton.UseVisualStyleBackColor = False
        '
        'ToolBoxButton
        '
        Me.ToolBoxButton.BackColor = System.Drawing.Color.White
        Me.ToolBoxButton.Font = New System.Drawing.Font("DengXian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ToolBoxButton.ForeColor = System.Drawing.Color.Black
        Me.ToolBoxButton.Location = New System.Drawing.Point(608, 381)
        Me.ToolBoxButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ToolBoxButton.Name = "ToolBoxButton"
        Me.ToolBoxButton.Size = New System.Drawing.Size(273, 76)
        Me.ToolBoxButton.TabIndex = 5
        Me.ToolBoxButton.Text = "Advanced Options"
        Me.ToolBoxButton.UseVisualStyleBackColor = False
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Enabled = False
        Me.Label.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Gray
        Me.Label.Location = New System.Drawing.Point(348, 284)
        Me.Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(201, 31)
        Me.Label.TabIndex = 6
        Me.Label.Text = "Fight For Liberty" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LibertyHosts.My.Resources.Resources.GoogleLogo
        Me.PictureBox1.Location = New System.Drawing.Point(244, 104)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Image = Global.LibertyHosts.My.Resources.Resources.MinimizeW
        Me.MinimizeButton.Location = New System.Drawing.Point(752, 0)
        Me.MinimizeButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(50, 40)
        Me.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.MinimizeButton.TabIndex = 1
        Me.MinimizeButton.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.Image = Global.LibertyHosts.My.Resources.Resources.CloseW
        Me.CloseButton.Location = New System.Drawing.Point(826, 0)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(50, 40)
        Me.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CloseButton.TabIndex = 0
        Me.CloseButton.TabStop = False
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(897, 492)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.ToolBoxButton)
        Me.Controls.Add(Me.CheckHostsButton)
        Me.Controls.Add(Me.GetHostsButton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "formMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liberty Hosts"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CloseButton As PictureBox
    Friend WithEvents MinimizeButton As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GetHostsButton As Button
    Friend WithEvents CheckHostsButton As Button
    Friend WithEvents ToolBoxButton As Button
    Friend WithEvents Label As Label
End Class
