<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.username_txtbox = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.username_label = New System.Windows.Forms.Label()
        Me.password_txtbox = New System.Windows.Forms.TextBox()
        Me.password_label = New System.Windows.Forms.Label()
        Me.login_button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'username_txtbox
        '
        Me.username_txtbox.BackColor = System.Drawing.Color.FloralWhite
        Me.username_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_txtbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.username_txtbox.Location = New System.Drawing.Point(562, 222)
        Me.username_txtbox.Name = "username_txtbox"
        Me.username_txtbox.Size = New System.Drawing.Size(290, 45)
        Me.username_txtbox.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'username_label
        '
        Me.username_label.AutoSize = True
        Me.username_label.BackColor = System.Drawing.Color.Transparent
        Me.username_label.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.username_label.Location = New System.Drawing.Point(341, 218)
        Me.username_label.Name = "username_label"
        Me.username_label.Size = New System.Drawing.Size(204, 43)
        Me.username_label.TabIndex = 2
        Me.username_label.Text = "Username"
        '
        'password_txtbox
        '
        Me.password_txtbox.BackColor = System.Drawing.Color.FloralWhite
        Me.password_txtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_txtbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.password_txtbox.Location = New System.Drawing.Point(562, 302)
        Me.password_txtbox.Name = "password_txtbox"
        Me.password_txtbox.Size = New System.Drawing.Size(290, 45)
        Me.password_txtbox.TabIndex = 3
        '
        'password_label
        '
        Me.password_label.AutoSize = True
        Me.password_label.BackColor = System.Drawing.Color.Transparent
        Me.password_label.Font = New System.Drawing.Font("Arial Rounded MT Bold", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.password_label.Location = New System.Drawing.Point(341, 302)
        Me.password_label.Name = "password_label"
        Me.password_label.Size = New System.Drawing.Size(197, 43)
        Me.password_label.TabIndex = 4
        Me.password_label.Text = "Password"
        '
        'login_button
        '
        Me.login_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(148, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(155, Byte), Integer))
        Me.login_button.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_button.ForeColor = System.Drawing.Color.FloralWhite
        Me.login_button.Location = New System.Drawing.Point(562, 369)
        Me.login_button.Name = "login_button"
        Me.login_button.Size = New System.Drawing.Size(187, 54)
        Me.login_button.TabIndex = 5
        Me.login_button.Text = "Log In"
        Me.login_button.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Digital_Art_Application.My.Resources.Resources.COMMISSION_SITE
        Me.ClientSize = New System.Drawing.Size(999, 587)
        Me.Controls.Add(Me.login_button)
        Me.Controls.Add(Me.password_label)
        Me.Controls.Add(Me.password_txtbox)
        Me.Controls.Add(Me.username_label)
        Me.Controls.Add(Me.username_txtbox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents username_txtbox As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents username_label As Label
    Friend WithEvents password_txtbox As TextBox
    Friend WithEvents password_label As Label
    Friend WithEvents login_button As Button
End Class
