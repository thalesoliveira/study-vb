<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora))
        Me.txtSoma1 = New System.Windows.Forms.TextBox()
        Me.lblSoma = New System.Windows.Forms.Label()
        Me.txtSoma2 = New System.Windows.Forms.TextBox()
        Me.btnIgualSoma = New System.Windows.Forms.Button()
        Me.txtResultadoSoma = New System.Windows.Forms.TextBox()
        Me.lblaviso = New System.Windows.Forms.Label()
        Me.grpsoma = New System.Windows.Forms.GroupBox()
        Me.grpsubtracao = New System.Windows.Forms.GroupBox()
        Me.txtSub1 = New System.Windows.Forms.TextBox()
        Me.txtSub2 = New System.Windows.Forms.TextBox()
        Me.txtResultadoSubtracao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIgualSubtracao = New System.Windows.Forms.Button()
        Me.grpmultiplicacao = New System.Windows.Forms.GroupBox()
        Me.txtMult1 = New System.Windows.Forms.TextBox()
        Me.txtMult2 = New System.Windows.Forms.TextBox()
        Me.txtResultadoMultiplicacao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnIgualMultiplicacao = New System.Windows.Forms.Button()
        Me.grpdivisao = New System.Windows.Forms.GroupBox()
        Me.txtDiv1 = New System.Windows.Forms.TextBox()
        Me.txtDiv2 = New System.Windows.Forms.TextBox()
        Me.txtResultadoDivisao = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnIgualDivisao = New System.Windows.Forms.Button()
        Me.grpsoma.SuspendLayout()
        Me.grpsubtracao.SuspendLayout()
        Me.grpmultiplicacao.SuspendLayout()
        Me.grpdivisao.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSoma1
        '
        Me.txtSoma1.Location = New System.Drawing.Point(19, 42)
        Me.txtSoma1.Name = "txtSoma1"
        Me.txtSoma1.Size = New System.Drawing.Size(96, 22)
        Me.txtSoma1.TabIndex = 0
        '
        'lblSoma
        '
        Me.lblSoma.AutoSize = True
        Me.lblSoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoma.Location = New System.Drawing.Point(121, 41)
        Me.lblSoma.Name = "lblSoma"
        Me.lblSoma.Size = New System.Drawing.Size(32, 32)
        Me.lblSoma.TabIndex = 2
        Me.lblSoma.Text = "+"
        '
        'txtSoma2
        '
        Me.txtSoma2.Location = New System.Drawing.Point(167, 42)
        Me.txtSoma2.Name = "txtSoma2"
        Me.txtSoma2.Size = New System.Drawing.Size(100, 22)
        Me.txtSoma2.TabIndex = 3
        '
        'btnIgualSoma
        '
        Me.btnIgualSoma.Location = New System.Drawing.Point(295, 41)
        Me.btnIgualSoma.Name = "btnIgualSoma"
        Me.btnIgualSoma.Size = New System.Drawing.Size(75, 23)
        Me.btnIgualSoma.TabIndex = 4
        Me.btnIgualSoma.Text = "="
        Me.btnIgualSoma.UseVisualStyleBackColor = True
        '
        'txtResultadoSoma
        '
        Me.txtResultadoSoma.Enabled = False
        Me.txtResultadoSoma.Location = New System.Drawing.Point(394, 41)
        Me.txtResultadoSoma.Name = "txtResultadoSoma"
        Me.txtResultadoSoma.Size = New System.Drawing.Size(100, 22)
        Me.txtResultadoSoma.TabIndex = 5
        '
        'lblaviso
        '
        Me.lblaviso.AutoSize = True
        Me.lblaviso.Location = New System.Drawing.Point(15, 484)
        Me.lblaviso.Name = "lblaviso"
        Me.lblaviso.Size = New System.Drawing.Size(51, 17)
        Me.lblaviso.TabIndex = 7
        Me.lblaviso.Text = "Label1"
        '
        'grpsoma
        '
        Me.grpsoma.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpsoma.Controls.Add(Me.txtSoma1)
        Me.grpsoma.Controls.Add(Me.txtSoma2)
        Me.grpsoma.Controls.Add(Me.txtResultadoSoma)
        Me.grpsoma.Controls.Add(Me.lblSoma)
        Me.grpsoma.Controls.Add(Me.btnIgualSoma)
        Me.grpsoma.Location = New System.Drawing.Point(18, 27)
        Me.grpsoma.Name = "grpsoma"
        Me.grpsoma.Size = New System.Drawing.Size(513, 97)
        Me.grpsoma.TabIndex = 8
        Me.grpsoma.TabStop = False
        Me.grpsoma.Text = "SOMA"
        '
        'grpsubtracao
        '
        Me.grpsubtracao.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpsubtracao.Controls.Add(Me.txtSub1)
        Me.grpsubtracao.Controls.Add(Me.txtSub2)
        Me.grpsubtracao.Controls.Add(Me.txtResultadoSubtracao)
        Me.grpsubtracao.Controls.Add(Me.Label1)
        Me.grpsubtracao.Controls.Add(Me.btnIgualSubtracao)
        Me.grpsubtracao.Location = New System.Drawing.Point(18, 142)
        Me.grpsubtracao.Name = "grpsubtracao"
        Me.grpsubtracao.Size = New System.Drawing.Size(513, 97)
        Me.grpsubtracao.TabIndex = 8
        Me.grpsubtracao.TabStop = False
        Me.grpsubtracao.Text = "SUBTRAÇÃO"
        '
        'txtSub1
        '
        Me.txtSub1.Location = New System.Drawing.Point(19, 42)
        Me.txtSub1.Name = "txtSub1"
        Me.txtSub1.Size = New System.Drawing.Size(96, 22)
        Me.txtSub1.TabIndex = 0
        '
        'txtSub2
        '
        Me.txtSub2.Location = New System.Drawing.Point(167, 42)
        Me.txtSub2.Name = "txtSub2"
        Me.txtSub2.Size = New System.Drawing.Size(100, 22)
        Me.txtSub2.TabIndex = 3
        '
        'txtResultadoSubtracao
        '
        Me.txtResultadoSubtracao.Enabled = False
        Me.txtResultadoSubtracao.Location = New System.Drawing.Point(394, 41)
        Me.txtResultadoSubtracao.Name = "txtResultadoSubtracao"
        Me.txtResultadoSubtracao.Size = New System.Drawing.Size(100, 22)
        Me.txtResultadoSubtracao.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "-"
        '
        'btnIgualSubtracao
        '
        Me.btnIgualSubtracao.Location = New System.Drawing.Point(295, 41)
        Me.btnIgualSubtracao.Name = "btnIgualSubtracao"
        Me.btnIgualSubtracao.Size = New System.Drawing.Size(75, 23)
        Me.btnIgualSubtracao.TabIndex = 4
        Me.btnIgualSubtracao.Text = "="
        Me.btnIgualSubtracao.UseVisualStyleBackColor = True
        '
        'grpmultiplicacao
        '
        Me.grpmultiplicacao.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpmultiplicacao.Controls.Add(Me.txtMult1)
        Me.grpmultiplicacao.Controls.Add(Me.txtMult2)
        Me.grpmultiplicacao.Controls.Add(Me.txtResultadoMultiplicacao)
        Me.grpmultiplicacao.Controls.Add(Me.Label2)
        Me.grpmultiplicacao.Controls.Add(Me.btnIgualMultiplicacao)
        Me.grpmultiplicacao.Location = New System.Drawing.Point(18, 255)
        Me.grpmultiplicacao.Name = "grpmultiplicacao"
        Me.grpmultiplicacao.Size = New System.Drawing.Size(513, 97)
        Me.grpmultiplicacao.TabIndex = 8
        Me.grpmultiplicacao.TabStop = False
        Me.grpmultiplicacao.Text = "MULTIPLICAÇÃO"
        '
        'txtMult1
        '
        Me.txtMult1.Location = New System.Drawing.Point(19, 42)
        Me.txtMult1.Name = "txtMult1"
        Me.txtMult1.Size = New System.Drawing.Size(96, 22)
        Me.txtMult1.TabIndex = 0
        '
        'txtMult2
        '
        Me.txtMult2.Location = New System.Drawing.Point(167, 42)
        Me.txtMult2.Name = "txtMult2"
        Me.txtMult2.Size = New System.Drawing.Size(100, 22)
        Me.txtMult2.TabIndex = 3
        '
        'txtResultadoMultiplicacao
        '
        Me.txtResultadoMultiplicacao.Enabled = False
        Me.txtResultadoMultiplicacao.Location = New System.Drawing.Point(394, 41)
        Me.txtResultadoMultiplicacao.Name = "txtResultadoMultiplicacao"
        Me.txtResultadoMultiplicacao.Size = New System.Drawing.Size(100, 22)
        Me.txtResultadoMultiplicacao.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(128, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "*"
        '
        'btnIgualMultiplicacao
        '
        Me.btnIgualMultiplicacao.Location = New System.Drawing.Point(295, 41)
        Me.btnIgualMultiplicacao.Name = "btnIgualMultiplicacao"
        Me.btnIgualMultiplicacao.Size = New System.Drawing.Size(75, 23)
        Me.btnIgualMultiplicacao.TabIndex = 4
        Me.btnIgualMultiplicacao.Text = "="
        Me.btnIgualMultiplicacao.UseVisualStyleBackColor = True
        '
        'grpdivisao
        '
        Me.grpdivisao.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpdivisao.Controls.Add(Me.txtDiv1)
        Me.grpdivisao.Controls.Add(Me.txtDiv2)
        Me.grpdivisao.Controls.Add(Me.txtResultadoDivisao)
        Me.grpdivisao.Controls.Add(Me.Label3)
        Me.grpdivisao.Controls.Add(Me.btnIgualDivisao)
        Me.grpdivisao.Location = New System.Drawing.Point(18, 373)
        Me.grpdivisao.Name = "grpdivisao"
        Me.grpdivisao.Size = New System.Drawing.Size(513, 97)
        Me.grpdivisao.TabIndex = 8
        Me.grpdivisao.TabStop = False
        Me.grpdivisao.Text = "DIVISÃO"
        '
        'txtDiv1
        '
        Me.txtDiv1.Location = New System.Drawing.Point(19, 42)
        Me.txtDiv1.Name = "txtDiv1"
        Me.txtDiv1.Size = New System.Drawing.Size(96, 22)
        Me.txtDiv1.TabIndex = 0
        '
        'txtDiv2
        '
        Me.txtDiv2.Location = New System.Drawing.Point(167, 42)
        Me.txtDiv2.Name = "txtDiv2"
        Me.txtDiv2.Size = New System.Drawing.Size(100, 22)
        Me.txtDiv2.TabIndex = 3
        '
        'txtResultadoDivisao
        '
        Me.txtResultadoDivisao.Enabled = False
        Me.txtResultadoDivisao.Location = New System.Drawing.Point(394, 41)
        Me.txtResultadoDivisao.Name = "txtResultadoDivisao"
        Me.txtResultadoDivisao.Size = New System.Drawing.Size(100, 22)
        Me.txtResultadoDivisao.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(131, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "/"
        '
        'btnIgualDivisao
        '
        Me.btnIgualDivisao.Location = New System.Drawing.Point(295, 41)
        Me.btnIgualDivisao.Name = "btnIgualDivisao"
        Me.btnIgualDivisao.Size = New System.Drawing.Size(75, 23)
        Me.btnIgualDivisao.TabIndex = 4
        Me.btnIgualDivisao.Text = "="
        Me.btnIgualDivisao.UseVisualStyleBackColor = True
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 504)
        Me.Controls.Add(Me.grpsubtracao)
        Me.Controls.Add(Me.grpmultiplicacao)
        Me.Controls.Add(Me.grpdivisao)
        Me.Controls.Add(Me.grpsoma)
        Me.Controls.Add(Me.lblaviso)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora"
        Me.grpsoma.ResumeLayout(False)
        Me.grpsoma.PerformLayout()
        Me.grpsubtracao.ResumeLayout(False)
        Me.grpsubtracao.PerformLayout()
        Me.grpmultiplicacao.ResumeLayout(False)
        Me.grpmultiplicacao.PerformLayout()
        Me.grpdivisao.ResumeLayout(False)
        Me.grpdivisao.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSoma1 As TextBox
    Friend WithEvents lblSoma As Label
    Friend WithEvents txtSoma2 As TextBox
    Friend WithEvents btnIgualSoma As Button
    Friend WithEvents txtResultadoSoma As TextBox
    Friend WithEvents lblaviso As Label
    Friend WithEvents grpsoma As GroupBox
    Friend WithEvents grpsubtracao As GroupBox
    Friend WithEvents txtSub1 As TextBox
    Friend WithEvents txtSub2 As TextBox
    Friend WithEvents txtResultadoSubtracao As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnIgualSubtracao As Button
    Friend WithEvents grpmultiplicacao As GroupBox
    Friend WithEvents txtMult1 As TextBox
    Friend WithEvents txtMult2 As TextBox
    Friend WithEvents txtResultadoMultiplicacao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnIgualMultiplicacao As Button
    Friend WithEvents grpdivisao As GroupBox
    Friend WithEvents txtDiv1 As TextBox
    Friend WithEvents txtDiv2 As TextBox
    Friend WithEvents txtResultadoDivisao As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnIgualDivisao As Button
End Class
