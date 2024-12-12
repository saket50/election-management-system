<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voters_settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(voters_settings))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label4 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(40, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 15)
        Label1.TabIndex = 0
        Label1.Text = "Old Password:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(40, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 1
        Label2.Text = "New Password:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(40, 207)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 15)
        Label3.TabIndex = 2
        Label3.Text = "Re-enter New Password:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(40, 95)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Enter Old Password"
        TextBox1.Size = New Size(236, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(40, 158)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Enter New Password"
        TextBox2.Size = New Size(236, 23)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(40, 225)
        TextBox3.Name = "TextBox3"
        TextBox3.PlaceholderText = "Confirm New Password"
        TextBox3.Size = New Size(236, 23)
        TextBox3.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.Location = New Point(39, 270)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 31)
        Button1.TabIndex = 6
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(198, 270)
        Button2.Name = "Button2"
        Button2.Size = New Size(83, 31)
        Button2.TabIndex = 7
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label3)
        Panel1.Location = New Point(27, 139)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(325, 340)
        Panel1.TabIndex = 8
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Navy
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(-2, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(907, 54)
        Panel2.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Navy
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(670, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 25)
        Label4.TabIndex = 1
        Label4.Text = "Label4"
        ' 
        ' voters_settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(903, 525)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "voters_settings"
        Text = "voters_settings"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label4 As Label
End Class
