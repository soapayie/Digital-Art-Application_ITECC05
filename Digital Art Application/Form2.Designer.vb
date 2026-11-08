<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.artist_button = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.buyer_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.artist_button)
        Me.Panel2.Location = New System.Drawing.Point(44, 240)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(452, 258)
        Me.Panel2.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(91, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(240, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Showcase your artwork"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Digital_Art_Application.My.Resources.Resources.Copy_of_LARO_NG_LUPA_FAQ__10_
        Me.PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), System.Drawing.Image)
        Me.PictureBox1.Image = Global.Digital_Art_Application.My.Resources.Resources.purple
        Me.PictureBox1.Location = New System.Drawing.Point(135, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(152, 130)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'artist_button
        '
        Me.artist_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.artist_button.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.artist_button.ForeColor = System.Drawing.Color.FloralWhite
        Me.artist_button.Location = New System.Drawing.Point(79, 192)
        Me.artist_button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.artist_button.Name = "artist_button"
        Me.artist_button.Size = New System.Drawing.Size(267, 46)
        Me.artist_button.TabIndex = 0
        Me.artist_button.Text = "I'M AN ARTIST"
        Me.artist_button.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FloralWhite
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.buyer_button)
        Me.Panel3.Location = New System.Drawing.Point(543, 240)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(452, 258)
        Me.Panel3.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(83, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(303, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Buy some Artist's Commission"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Digital_Art_Application.My.Resources.Resources.Copy_of_LARO_NG_LUPA_FAQ__10_
        Me.PictureBox2.ErrorImage = CType(resources.GetObject("PictureBox2.ErrorImage"), System.Drawing.Image)
        Me.PictureBox2.Image = Global.Digital_Art_Application.My.Resources.Resources.purple
        Me.PictureBox2.Location = New System.Drawing.Point(153, 18)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(152, 130)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'buyer_button
        '
        Me.buyer_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.buyer_button.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buyer_button.ForeColor = System.Drawing.Color.FloralWhite
        Me.buyer_button.Location = New System.Drawing.Point(97, 194)
        Me.buyer_button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.buyer_button.Name = "buyer_button"
        Me.buyer_button.Size = New System.Drawing.Size(267, 46)
        Me.buyer_button.TabIndex = 1
        Me.buyer_button.Text = "I'M A BUYER"
        Me.buyer_button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(244, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(544, 43)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "LET YOUR CREATIVE SHINE!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(299, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(436, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Discover talented artists or share your creativity with the world." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(299, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(436, 32)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "WHAT BRINGS YOU TO TITLE?"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FloralWhite
        Me.Button1.Location = New System.Drawing.Point(859, 518)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 39)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "LOG OUT"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.BackgroundImage = Global.Digital_Art_Application.My.Resources.Resources.HOME__3_
        Me.ClientSize = New System.Drawing.Size(1037, 568)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub title_label_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents artist_button As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents buyer_button As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Friend WithEvents Label3 As Label

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Friend WithEvents Label4 As Label

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
