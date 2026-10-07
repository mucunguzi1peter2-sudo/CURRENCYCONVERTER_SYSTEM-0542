<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lblLoginForm = New Label()
        lblUsername = New Label()
        lblPassward = New Label()
        btnLogin = New Button()
        btnClear = New Button()
        txtUser = New TextBox()
        txtPass = New TextBox()
        SuspendLayout()
        ' 
        ' lblLoginForm
        ' 
        lblLoginForm.AutoSize = True
        lblLoginForm.Font = New Font("Adobe Fan Heiti Std B", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLoginForm.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        lblLoginForm.Location = New Point(206, 19)
        lblLoginForm.Name = "lblLoginForm"
        lblLoginForm.Size = New Size(409, 40)
        lblLoginForm.TabIndex = 0
        lblLoginForm.Text = "WELCOME TO LOGIN FORM"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(184, 95)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(145, 40)
        lblUsername.TabIndex = 1
        lblUsername.Text = "Username"
        ' 
        ' lblPassward
        ' 
        lblPassward.AutoSize = True
        lblPassward.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPassward.Location = New Point(184, 162)
        lblPassward.Name = "lblPassward"
        lblPassward.Size = New Size(136, 40)
        lblPassward.TabIndex = 2
        lblPassward.Text = "Password"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.White
        btnLogin.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.Blue
        btnLogin.Location = New Point(475, 255)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(172, 46)
        btnLogin.TabIndex = 3
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.White
        btnClear.Font = New Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.Blue
        btnClear.Location = New Point(252, 255)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(151, 46)
        btnClear.TabIndex = 4
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' txtUser
        ' 
        txtUser.BackColor = SystemColors.InactiveCaption
        txtUser.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUser.ForeColor = SystemColors.ControlText
        txtUser.Location = New Point(367, 100)
        txtUser.Name = "txtUser"
        txtUser.PlaceholderText = "Username"
        txtUser.Size = New Size(280, 35)
        txtUser.TabIndex = 5
        ' 
        ' txtPass
        ' 
        txtPass.BackColor = SystemColors.InactiveCaption
        txtPass.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPass.ForeColor = SystemColors.InactiveCaptionText
        txtPass.Location = New Point(367, 167)
        txtPass.Name = "txtPass"
        txtPass.PlaceholderText = "Password"
        txtPass.Size = New Size(280, 35)
        txtPass.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkTurquoise
        ClientSize = New Size(800, 450)
        Controls.Add(txtPass)
        Controls.Add(txtUser)
        Controls.Add(btnClear)
        Controls.Add(btnLogin)
        Controls.Add(lblPassward)
        Controls.Add(lblUsername)
        Controls.Add(lblLoginForm)
        Name = "Form1"
        Text = "SIMPLE LOGIN FORM"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLoginForm As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassward As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox

End Class
