<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class send
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(send))
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.subtxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Attach = New System.Windows.Forms.Button()
        Me.bodytxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sendbtn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(131, 30)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(165, 24)
        Me.email.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "To:"
        '
        'subtxt
        '
        Me.subtxt.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtxt.Location = New System.Drawing.Point(131, 78)
        Me.subtxt.Name = "subtxt"
        Me.subtxt.Size = New System.Drawing.Size(165, 24)
        Me.subtxt.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Subject:"
        '
        'Attach
        '
        Me.Attach.BackColor = System.Drawing.Color.SteelBlue
        Me.Attach.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Attach.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Attach.Location = New System.Drawing.Point(12, 133)
        Me.Attach.Name = "Attach"
        Me.Attach.Size = New System.Drawing.Size(98, 35)
        Me.Attach.TabIndex = 25
        Me.Attach.Text = "Attach Pay Slip"
        Me.Attach.UseVisualStyleBackColor = False
        '
        'bodytxt
        '
        Me.bodytxt.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bodytxt.Location = New System.Drawing.Point(67, 205)
        Me.bodytxt.Multiline = True
        Me.bodytxt.Name = "bodytxt"
        Me.bodytxt.Size = New System.Drawing.Size(259, 97)
        Me.bodytxt.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Body:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(116, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "|"
        '
        'sendbtn
        '
        Me.sendbtn.BackColor = System.Drawing.Color.SteelBlue
        Me.sendbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.sendbtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.sendbtn.Location = New System.Drawing.Point(248, 323)
        Me.sendbtn.Name = "sendbtn"
        Me.sendbtn.Size = New System.Drawing.Size(98, 35)
        Me.sendbtn.TabIndex = 29
        Me.sendbtn.Text = "Send"
        Me.sendbtn.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'send
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PowderBlue
        Me.ClientSize = New System.Drawing.Size(358, 370)
        Me.Controls.Add(Me.sendbtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.bodytxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Attach)
        Me.Controls.Add(Me.subtxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "send"
        Me.Text = "Send Pay Slip"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents subtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Attach As System.Windows.Forms.Button
    Friend WithEvents bodytxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents sendbtn As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
