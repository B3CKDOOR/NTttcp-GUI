<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.BTNrun = New System.Windows.Forms.Button()
        Me.BTNexit = New System.Windows.Forms.Button()
        Me.BTNstop = New System.Windows.Forms.Button()
        Me.LBLmode = New System.Windows.Forms.Label()
        Me.LBLip = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LBLpacksize = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.CHKsend = New System.Windows.Forms.CheckBox()
        Me.CHKreceive = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CMBip = New System.Windows.Forms.ComboBox()
        Me.TXBip = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BTNrun
        '
        Me.BTNrun.Location = New System.Drawing.Point(408, 335)
        Me.BTNrun.Name = "BTNrun"
        Me.BTNrun.Size = New System.Drawing.Size(75, 23)
        Me.BTNrun.TabIndex = 0
        Me.BTNrun.Text = "Run"
        Me.BTNrun.UseVisualStyleBackColor = True
        '
        'BTNexit
        '
        Me.BTNexit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNexit.Location = New System.Drawing.Point(12, 335)
        Me.BTNexit.Name = "BTNexit"
        Me.BTNexit.Size = New System.Drawing.Size(75, 23)
        Me.BTNexit.TabIndex = 1
        Me.BTNexit.Text = "Exit"
        Me.BTNexit.UseVisualStyleBackColor = True
        '
        'BTNstop
        '
        Me.BTNstop.Enabled = False
        Me.BTNstop.Location = New System.Drawing.Point(408, 306)
        Me.BTNstop.Name = "BTNstop"
        Me.BTNstop.Size = New System.Drawing.Size(75, 23)
        Me.BTNstop.TabIndex = 2
        Me.BTNstop.Text = "Stop"
        Me.BTNstop.UseVisualStyleBackColor = True
        '
        'LBLmode
        '
        Me.LBLmode.AutoSize = True
        Me.LBLmode.Location = New System.Drawing.Point(12, 28)
        Me.LBLmode.Name = "LBLmode"
        Me.LBLmode.Size = New System.Drawing.Size(34, 13)
        Me.LBLmode.TabIndex = 4
        Me.LBLmode.Text = "Mode"
        '
        'LBLip
        '
        Me.LBLip.AutoSize = True
        Me.LBLip.Location = New System.Drawing.Point(12, 53)
        Me.LBLip.Name = "LBLip"
        Me.LBLip.Size = New System.Drawing.Size(58, 13)
        Me.LBLip.TabIndex = 6
        Me.LBLip.Text = "IP Address"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(114, 76)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(114, 20)
        Me.TextBox2.TabIndex = 5
        '
        'LBLpacksize
        '
        Me.LBLpacksize.AutoSize = True
        Me.LBLpacksize.Location = New System.Drawing.Point(12, 79)
        Me.LBLpacksize.Name = "LBLpacksize"
        Me.LBLpacksize.Size = New System.Drawing.Size(71, 13)
        Me.LBLpacksize.TabIndex = 8
        Me.LBLpacksize.Text = "Package size"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(114, 102)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(114, 20)
        Me.TextBox3.TabIndex = 7
        '
        'CHKsend
        '
        Me.CHKsend.AutoSize = True
        Me.CHKsend.Location = New System.Drawing.Point(114, 27)
        Me.CHKsend.Name = "CHKsend"
        Me.CHKsend.Size = New System.Drawing.Size(51, 17)
        Me.CHKsend.TabIndex = 9
        Me.CHKsend.Text = "Send"
        Me.CHKsend.UseVisualStyleBackColor = True
        '
        'CHKreceive
        '
        Me.CHKreceive.AutoSize = True
        Me.CHKreceive.Location = New System.Drawing.Point(162, 27)
        Me.CHKreceive.Name = "CHKreceive"
        Me.CHKreceive.Size = New System.Drawing.Size(66, 17)
        Me.CHKreceive.TabIndex = 10
        Me.CHKreceive.Text = "Receive"
        Me.CHKreceive.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Label4"
        '
        'CMBip
        '
        Me.CMBip.FormattingEnabled = True
        Me.CMBip.Location = New System.Drawing.Point(233, 50)
        Me.CMBip.Name = "CMBip"
        Me.CMBip.Size = New System.Drawing.Size(114, 21)
        Me.CMBip.TabIndex = 12
        Me.CMBip.Text = "Select item..."
        Me.CMBip.Visible = False
        '
        'TXBip
        '
        Me.TXBip.Location = New System.Drawing.Point(114, 50)
        Me.TXBip.Name = "TXBip"
        Me.TXBip.Size = New System.Drawing.Size(114, 20)
        Me.TXBip.TabIndex = 13
        '
        'Main
        '
        Me.AcceptButton = Me.BTNrun
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 370)
        Me.Controls.Add(Me.TXBip)
        Me.Controls.Add(Me.CMBip)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CHKreceive)
        Me.Controls.Add(Me.CHKsend)
        Me.Controls.Add(Me.LBLpacksize)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.LBLip)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.LBLmode)
        Me.Controls.Add(Me.BTNstop)
        Me.Controls.Add(Me.BTNexit)
        Me.Controls.Add(Me.BTNrun)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNrun As Button
    Friend WithEvents BTNexit As Button
    Friend WithEvents BTNstop As Button
    Friend WithEvents LBLmode As Label
    Friend WithEvents LBLip As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents LBLpacksize As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents CHKsend As CheckBox
    Friend WithEvents CHKreceive As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CMBip As ComboBox
    Friend WithEvents TXBip As TextBox
End Class
