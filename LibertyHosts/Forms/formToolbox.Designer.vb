<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formToolbox
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formToolbox))
        Me.MinimizeButton = New System.Windows.Forms.PictureBox()
        Me.CloseButton = New System.Windows.Forms.PictureBox()
        Me.ViewHostsButton = New System.Windows.Forms.Button()
        Me.EditHosts = New System.Windows.Forms.Button()
        Me.CleanHosts = New System.Windows.Forms.Button()
        Me.About = New System.Windows.Forms.Button()
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MinimizeButton
        '
        Me.MinimizeButton.Image = Global.LibertyHosts.My.Resources.Resources.MinimizeW
        Me.MinimizeButton.Location = New System.Drawing.Point(264, 0)
        Me.MinimizeButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimizeButton.Name = "MinimizeButton"
        Me.MinimizeButton.Size = New System.Drawing.Size(50, 40)
        Me.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.MinimizeButton.TabIndex = 3
        Me.MinimizeButton.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.Image = Global.LibertyHosts.My.Resources.Resources.CloseW
        Me.CloseButton.Location = New System.Drawing.Point(339, 0)
        Me.CloseButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(50, 40)
        Me.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.CloseButton.TabIndex = 2
        Me.CloseButton.TabStop = False
        '
        'ViewHostsButton
        '
        Me.ViewHostsButton.BackColor = System.Drawing.Color.White
        Me.ViewHostsButton.Font = New System.Drawing.Font("DengXian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ViewHostsButton.ForeColor = System.Drawing.Color.Black
        Me.ViewHostsButton.Location = New System.Drawing.Point(69, 99)
        Me.ViewHostsButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ViewHostsButton.Name = "ViewHostsButton"
        Me.ViewHostsButton.Size = New System.Drawing.Size(273, 76)
        Me.ViewHostsButton.TabIndex = 4
        Me.ViewHostsButton.Text = "Explorer Hosts Folder"
        Me.ViewHostsButton.UseVisualStyleBackColor = False
        '
        'EditHosts
        '
        Me.EditHosts.BackColor = System.Drawing.Color.White
        Me.EditHosts.Font = New System.Drawing.Font("DengXian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.EditHosts.ForeColor = System.Drawing.Color.Black
        Me.EditHosts.Location = New System.Drawing.Point(69, 208)
        Me.EditHosts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EditHosts.Name = "EditHosts"
        Me.EditHosts.Size = New System.Drawing.Size(273, 76)
        Me.EditHosts.TabIndex = 5
        Me.EditHosts.Text = "Edit Hosts File"
        Me.EditHosts.UseVisualStyleBackColor = False
        '
        'CleanHosts
        '
        Me.CleanHosts.BackColor = System.Drawing.Color.White
        Me.CleanHosts.Font = New System.Drawing.Font("DengXian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.CleanHosts.ForeColor = System.Drawing.Color.Black
        Me.CleanHosts.Location = New System.Drawing.Point(69, 318)
        Me.CleanHosts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CleanHosts.Name = "CleanHosts"
        Me.CleanHosts.Size = New System.Drawing.Size(273, 76)
        Me.CleanHosts.TabIndex = 6
        Me.CleanHosts.Text = "Restore Hosts File"
        Me.CleanHosts.UseVisualStyleBackColor = False
        '
        'About
        '
        Me.About.BackColor = System.Drawing.Color.White
        Me.About.Font = New System.Drawing.Font("DengXian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.About.ForeColor = System.Drawing.Color.Black
        Me.About.Location = New System.Drawing.Point(66, 428)
        Me.About.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(273, 76)
        Me.About.TabIndex = 7
        Me.About.Text = "About"
        Me.About.UseVisualStyleBackColor = False
        '
        'formToolbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(412, 573)
        Me.Controls.Add(Me.About)
        Me.Controls.Add(Me.CleanHosts)
        Me.Controls.Add(Me.EditHosts)
        Me.Controls.Add(Me.ViewHostsButton)
        Me.Controls.Add(Me.MinimizeButton)
        Me.Controls.Add(Me.CloseButton)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "formToolbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmToolbox"
        CType(Me.MinimizeButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CloseButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MinimizeButton As PictureBox
    Friend WithEvents CloseButton As PictureBox
    Friend WithEvents ViewHostsButton As Button
    Friend WithEvents EditHosts As Button
    Friend WithEvents CleanHosts As Button
    Friend WithEvents About As Button
End Class
