<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class V_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(V_login))
        Label1 = New Label()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        TextBox1 = New TextBox()
        LinkLabel1 = New LinkLabel()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        Panel1 = New Panel()
        CheckBox1 = New CheckBox()
        Button4 = New Button()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.MidnightBlue
        Label1.Location = New Point(69, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(170, 32)
        Label1.TabIndex = 0
        Label1.Text = "VOTER LOGIN"
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.InactiveCaption
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(169, 313)
        Button2.Name = "Button2"
        Button2.Size = New Size(101, 37)
        Button2.TabIndex = 8
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(105, 42)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.MenuHighlight
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.Location = New Point(50, 313)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 37)
        Button1.TabIndex = 7
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(50, 175)
        TextBox1.MaxLength = 12
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Enter 12 digit Aadhar No."
        TextBox1.Size = New Size(220, 23)
        TextBox1.TabIndex = 2
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Location = New Point(50, 353)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(99, 15)
        LinkLabel1.TabIndex = 6
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Forget Password?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(50, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(134, 21)
        Label2.TabIndex = 3
        Label2.Text = "Enter Aadhar No."
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.MidnightBlue
        Label3.Location = New Point(50, 219)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 21)
        Label3.TabIndex = 5
        Label3.Text = "Password"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(50, 243)
        TextBox2.Name = "TextBox2"
        TextBox2.PlaceholderText = "Enter Password"
        TextBox2.Size = New Size(220, 23)
        TextBox2.TabIndex = 4
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(CheckBox1)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(TextBox2)
        Panel1.Location = New Point(509, 39)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(319, 431)
        Panel1.TabIndex = 11
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.BackColor = Color.Transparent
        CheckBox1.Font = New Font("Mongolian Baiti", 8.25F)
        CheckBox1.Location = New Point(174, 272)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(96, 15)
        CheckBox1.TabIndex = 11
        CheckBox1.Text = "Show Password"
        CheckBox1.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.MenuHighlight
        Button4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button4.Location = New Point(102, 377)
        Button4.Name = "Button4"
        Button4.Size = New Size(114, 37)
        Button4.TabIndex = 10
        Button4.Text = "Create Account"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Location = New Point(12, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(87, 39)
        Button3.TabIndex = 12
        Button3.UseVisualStyleBackColor = False
        ' 
        ' V_login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(903, 525)
        Controls.Add(Panel1)
        Controls.Add(Button3)
        Name = "V_login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
