<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Login
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm

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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.OK = New MetroFramework.Controls.MetroButton()
        Me.Cancel = New MetroFramework.Controls.MetroButton()
        Me.Se = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtSenha = New MetroFramework.Controls.MetroTextBox()
        Me.txtUsuario = New MetroFramework.Controls.MetroTextBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.Black
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(168, 198)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'OK
        '
        Me.OK.Cursor = System.Windows.Forms.Cursors.Default
        Me.OK.Location = New System.Drawing.Point(175, 158)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(104, 26)
        Me.OK.TabIndex = 3
        Me.OK.Text = "&OK"
        Me.OK.UseSelectable = True
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(285, 158)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(109, 26)
        Me.Cancel.TabIndex = 4
        Me.Cancel.Text = "Cancelar"
        Me.Cancel.UseSelectable = True
        '
        'Se
        '
        Me.Se.AutoSize = True
        Me.Se.Location = New System.Drawing.Point(175, 91)
        Me.Se.Name = "Se"
        Me.Se.Size = New System.Drawing.Size(47, 20)
        Me.Se.TabIndex = 8
        Me.Se.Text = "&Senha"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(175, 21)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(56, 20)
        Me.MetroLabel1.TabIndex = 9
        Me.MetroLabel1.Text = "&Usuário"
        '
        'txtSenha
        '
        '
        '
        '
        Me.txtSenha.CustomButton.Image = Nothing
        Me.txtSenha.CustomButton.Location = New System.Drawing.Point(197, 1)
        Me.txtSenha.CustomButton.Name = ""
        Me.txtSenha.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSenha.CustomButton.TabIndex = 1
        Me.txtSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSenha.CustomButton.UseSelectable = True
        Me.txtSenha.CustomButton.Visible = False
        Me.txtSenha.Lines = New String(-1) {}
        Me.txtSenha.Location = New System.Drawing.Point(174, 114)
        Me.txtSenha.MaxLength = 32767
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSenha.SelectedText = ""
        Me.txtSenha.SelectionLength = 0
        Me.txtSenha.SelectionStart = 0
        Me.txtSenha.ShortcutsEnabled = True
        Me.txtSenha.Size = New System.Drawing.Size(219, 23)
        Me.txtSenha.TabIndex = 2
        Me.txtSenha.UseSelectable = True
        Me.txtSenha.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSenha.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtUsuario
        '
        '
        '
        '
        Me.txtUsuario.CustomButton.Image = Nothing
        Me.txtUsuario.CustomButton.Location = New System.Drawing.Point(196, 1)
        Me.txtUsuario.CustomButton.Name = ""
        Me.txtUsuario.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsuario.CustomButton.TabIndex = 1
        Me.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsuario.CustomButton.UseSelectable = True
        Me.txtUsuario.CustomButton.Visible = False
        Me.txtUsuario.Lines = New String(-1) {}
        Me.txtUsuario.Location = New System.Drawing.Point(175, 52)
        Me.txtUsuario.MaxLength = 32767
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.SelectionLength = 0
        Me.txtUsuario.SelectionStart = 0
        Me.txtUsuario.ShortcutsEnabled = True
        Me.txtUsuario.Size = New System.Drawing.Size(218, 23)
        Me.txtUsuario.TabIndex = 1
        Me.txtUsuario.UseSelectable = True
        Me.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsuario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'Login
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(411, 202)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.Se)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OK As MetroFramework.Controls.MetroButton
    Friend WithEvents Cancel As MetroFramework.Controls.MetroButton
    Friend WithEvents Se As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSenha As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtUsuario As MetroFramework.Controls.MetroTextBox
End Class
