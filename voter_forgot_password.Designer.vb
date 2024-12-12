<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voter_forgot_password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(voter_forgot_password))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        DateTimePicker1 = New DateTimePicker()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        TextBox3 = New TextBox()
        Label4 = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(28, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 15)
        Label1.TabIndex = 0
        Label1.Text = "Date of Birth"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(28, 155)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 15)
        Label2.TabIndex = 1
        Label2.Text = "New Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(28, 214)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 15)
        Label3.TabIndex = 2
        Label3.Text = "Re- enter New Password"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(28, 59)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 3
        DateTimePicker1.Value = New Date(2024, 4, 3, 15, 4, 51, 0)
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(28, 115)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(200, 23)
        TextBox1.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(28, 232)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(200, 23)
        TextBox2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.MenuHighlight
        Button1.Location = New Point(34, 261)
        Button1.Name = "Button1"
        Button1.Size = New Size(82, 31)
        Button1.TabIndex = 6
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(133, 261)
        Button2.Name = "Button2"
        Button2.Size = New Size(82, 31)
        Button2.TabIndex = 7
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(28, 173)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(200, 23)
        TextBox3.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(28, 97)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 15)
        Label4.TabIndex = 9
        Label4.Text = "Aadhar No."
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(362, 65)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(253, 336)
        Panel1.TabIndex = 10
        ' 
        ' voter_forgot_password
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(657, 463)
        Controls.Add(Panel1)
        Name = "voter_forgot_password"
        Text = "voter_forgot_password"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
End Class
