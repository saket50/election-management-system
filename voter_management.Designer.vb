<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class voter_management
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(voter_management))
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Button2 = New Button()
        Label4 = New Label()
        Button3 = New Button()
        Label3 = New Label()
        DateTimePicker1 = New DateTimePicker()
        TextBox2 = New TextBox()
        Label6 = New Label()
        Label8 = New Label()
        Button4 = New Button()
        TextBox5 = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        DataGridView1.Location = New Point(12, 85)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(486, 393)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.Frozen = True
        Column1.HeaderText = "Aadhar No."
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Width = 130
        ' 
        ' Column2
        ' 
        Column2.Frozen = True
        Column2.HeaderText = "Name"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 120
        ' 
        ' Column3
        ' 
        Column3.Frozen = True
        Column3.HeaderText = "Phone No."
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 120
        ' 
        ' Column4
        ' 
        Column4.Frozen = True
        Column4.HeaderText = "Voted"
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 60
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(625, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 21)
        Label1.TabIndex = 1
        Label1.Text = "MANAGE VOTERS"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(582, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 2
        Label2.Text = "Search Voter"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(668, 48)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(147, 23)
        TextBox1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(657, 85)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Search"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(514, 284)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(182, 23)
        TextBox4.TabIndex = 31
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.MidnightBlue
        Label5.Location = New Point(715, 122)
        Label5.Name = "Label5"
        Label5.Size = New Size(105, 21)
        Label5.TabIndex = 25
        Label5.Text = "Date Of Birth"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(514, 210)
        TextBox3.MaxLength = 10
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(182, 23)
        TextBox3.TabIndex = 24
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(740, 324)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 33)
        Button2.TabIndex = 30
        Button2.Text = "Clear"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.MidnightBlue
        Label4.Location = New Point(514, 260)
        Label4.Name = "Label4"
        Label4.Size = New Size(94, 21)
        Label4.TabIndex = 23
        Label4.Text = "Contact no."
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Highlight
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(584, 324)
        Button3.Name = "Button3"
        Button3.Size = New Size(89, 33)
        Button3.TabIndex = 29
        Button3.Text = "Update"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.MidnightBlue
        Label3.Location = New Point(514, 122)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 21)
        Label3.TabIndex = 22
        Label3.Text = "Aadhar no.:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Location = New Point(715, 146)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(182, 23)
        DateTimePicker1.TabIndex = 26
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(514, 146)
        TextBox2.MaxLength = 12
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(182, 23)
        TextBox2.TabIndex = 21
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.MidnightBlue
        Label6.Location = New Point(715, 186)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 21)
        Label6.TabIndex = 27
        Label6.Text = "State"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.MidnightBlue
        Label8.Location = New Point(514, 186)
        Label8.Name = "Label8"
        Label8.Size = New Size(57, 21)
        Label8.TabIndex = 19
        Label8.Text = "Name:"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Transparent
        Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), Image)
        Button4.BackgroundImageLayout = ImageLayout.Stretch
        Button4.Location = New Point(12, 9)
        Button4.Name = "Button4"
        Button4.Size = New Size(87, 39)
        Button4.TabIndex = 33
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(715, 210)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(182, 23)
        TextBox5.TabIndex = 34
        ' 
        ' voter_management
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(903, 525)
        Controls.Add(TextBox5)
        Controls.Add(Button4)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(Button3)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox2)
        Controls.Add(Label6)
        Controls.Add(Label8)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "voter_management"
        Text = "voter_management"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox5 As TextBox
End Class
