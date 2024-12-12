<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class V_create
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(V_create))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
        Label7 = New Label()
        TextBox4 = New TextBox()
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
        Label1.Location = New Point(157, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(189, 32)
        Label1.TabIndex = 1
        Label1.Text = "Create Account"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.unnamed2
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(425, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(87, 72)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.MidnightBlue
        Label2.Location = New Point(31, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 21)
        Label2.TabIndex = 5
        Label2.Text = "Name:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(31, 97)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(182, 23)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(31, 161)
        TextBox2.MaxLength = 12
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(182, 23)
        TextBox2.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.MidnightBlue
        Label3.Location = New Point(31, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 21)
        Label3.TabIndex = 8
        Label3.Text = "Aadhar no.:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.MidnightBlue
        Label4.Location = New Point(31, 211)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 21)
        Label4.TabIndex = 9
        Label4.Text = "Contact no."
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(31, 235)
        TextBox3.MaxLength = 10
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(182, 23)
        TextBox3.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.MidnightBlue
        Label5.Location = New Point(280, 73)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 21)
        Label5.TabIndex = 11
        Label5.Text = "Date Of Birth"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(280, 97)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(182, 23)
        DateTimePicker1.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.MidnightBlue
        Label6.Location = New Point(280, 137)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 21)
        Label6.TabIndex = 13
        Label6.Text = "State"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Andhra Pradesh", "Arunachal Pradesh", "Assam", "Bihar", "Chhattisgarh", "Goa", "Gujarat", "Haryana", "Himachal Pradesh", "Jharkhand", "Karnataka", "Kerala", "Madhya Pradesh", "Maharashtra", "Manipur", "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana", "Tripura", "Uttar Pradesh", "Uttarakhand", "West Bengal", "", "Andaman and Nicobar Islands", "Chandigarh", "Dadra and Nagar Haveli and Daman and Diu", "Lakshadweep", "Delhi (National Capital Territory of Delhi)", "Puducherry (Pondicherry)", "Ladakh", "Lakshadweep"})
        ComboBox1.Location = New Point(280, 161)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 23)
        ComboBox1.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(124, 303)
        Button1.Name = "Button1"
        Button1.Size = New Size(89, 33)
        Button1.TabIndex = 15
        Button1.Text = "Create"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(280, 303)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 33)
        Button2.TabIndex = 16
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(TextBox4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(DateTimePicker1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(ComboBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(425, 96)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(483, 387)
        Panel1.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.MidnightBlue
        Label7.Location = New Point(280, 211)
        Label7.Name = "Label7"
        Label7.Size = New Size(114, 21)
        Label7.TabIndex = 18
        Label7.Text = "Enter Pasword"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(280, 235)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(182, 23)
        TextBox4.TabIndex = 17
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Location = New Point(12, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(87, 39)
        Button3.TabIndex = 19
        Button3.UseVisualStyleBackColor = False
        ' 
        ' V_create
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(920, 527)
        Controls.Add(Button3)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Name = "V_create"
        Text = "v"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox4 As TextBox
End Class
