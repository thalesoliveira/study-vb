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
        Me.grpSoma = New System.Windows.Forms.GroupBox()
        Me.lblSoma = New System.Windows.Forms.Label()
        Me.btnResultSoma = New System.Windows.Forms.Button()
        Me.resultSoma = New System.Windows.Forms.TextBox()
        Me.valSoma2 = New System.Windows.Forms.TextBox()
        Me.valSoma1 = New System.Windows.Forms.TextBox()
        Me.grpSub = New System.Windows.Forms.GroupBox()
        Me.lblSub = New System.Windows.Forms.Label()
        Me.btnResultSub = New System.Windows.Forms.Button()
        Me.resultSub = New System.Windows.Forms.TextBox()
        Me.valSub2 = New System.Windows.Forms.TextBox()
        Me.valSub1 = New System.Windows.Forms.TextBox()
        Me.grpMulti = New System.Windows.Forms.GroupBox()
        Me.lblMulti = New System.Windows.Forms.Label()
        Me.btnResultMulti = New System.Windows.Forms.Button()
        Me.valMult2 = New System.Windows.Forms.TextBox()
        Me.resultMulti = New System.Windows.Forms.TextBox()
        Me.valMult1 = New System.Windows.Forms.TextBox()
        Me.grpDiv = New System.Windows.Forms.GroupBox()
        Me.lblDiv = New System.Windows.Forms.Label()
        Me.btnResultDiv = New System.Windows.Forms.Button()
        Me.resultDiv = New System.Windows.Forms.TextBox()
        Me.valDiv2 = New System.Windows.Forms.TextBox()
        Me.valDiv1 = New System.Windows.Forms.TextBox()
        Me.lblAviso = New System.Windows.Forms.Label()
        Me.grpSoma.SuspendLayout()
        Me.grpSub.SuspendLayout()
        Me.grpMulti.SuspendLayout()
        Me.grpDiv.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpSoma
        '
        Me.grpSoma.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpSoma.Controls.Add(Me.lblSoma)
        Me.grpSoma.Controls.Add(Me.btnResultSoma)
        Me.grpSoma.Controls.Add(Me.resultSoma)
        Me.grpSoma.Controls.Add(Me.valSoma2)
        Me.grpSoma.Controls.Add(Me.valSoma1)
        Me.grpSoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSoma.Location = New System.Drawing.Point(15, 44)
        Me.grpSoma.Name = "grpSoma"
        Me.grpSoma.Size = New System.Drawing.Size(440, 100)
        Me.grpSoma.TabIndex = 0
        Me.grpSoma.TabStop = False
        Me.grpSoma.Text = "SOMA"
        '
        'lblSoma
        '
        Me.lblSoma.AutoSize = True
        Me.lblSoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoma.Location = New System.Drawing.Point(113, 34)
        Me.lblSoma.Name = "lblSoma"
        Me.lblSoma.Size = New System.Drawing.Size(24, 25)
        Me.lblSoma.TabIndex = 4
        Me.lblSoma.Text = "+"
        '
        'btnResultSoma
        '
        Me.btnResultSoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultSoma.Location = New System.Drawing.Point(243, 33)
        Me.btnResultSoma.Name = "btnResultSoma"
        Me.btnResultSoma.Size = New System.Drawing.Size(75, 23)
        Me.btnResultSoma.TabIndex = 3
        Me.btnResultSoma.Text = "="
        Me.btnResultSoma.UseVisualStyleBackColor = True
        '
        'resultSoma
        '
        Me.resultSoma.Enabled = False
        Me.resultSoma.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultSoma.Location = New System.Drawing.Point(326, 34)
        Me.resultSoma.Name = "resultSoma"
        Me.resultSoma.Size = New System.Drawing.Size(100, 22)
        Me.resultSoma.TabIndex = 2
        '
        'valSoma2
        '
        Me.valSoma2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valSoma2.Location = New System.Drawing.Point(137, 34)
        Me.valSoma2.Name = "valSoma2"
        Me.valSoma2.Size = New System.Drawing.Size(100, 22)
        Me.valSoma2.TabIndex = 1
        '
        'valSoma1
        '
        Me.valSoma1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valSoma1.Location = New System.Drawing.Point(7, 34)
        Me.valSoma1.Name = "valSoma1"
        Me.valSoma1.Size = New System.Drawing.Size(100, 22)
        Me.valSoma1.TabIndex = 0
        '
        'grpSub
        '
        Me.grpSub.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpSub.Controls.Add(Me.lblSub)
        Me.grpSub.Controls.Add(Me.btnResultSub)
        Me.grpSub.Controls.Add(Me.resultSub)
        Me.grpSub.Controls.Add(Me.valSub2)
        Me.grpSub.Controls.Add(Me.valSub1)
        Me.grpSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSub.Location = New System.Drawing.Point(15, 162)
        Me.grpSub.Name = "grpSub"
        Me.grpSub.Size = New System.Drawing.Size(440, 100)
        Me.grpSub.TabIndex = 1
        Me.grpSub.TabStop = False
        Me.grpSub.Text = "SUBTRAÇÃO"
        '
        'lblSub
        '
        Me.lblSub.AutoSize = True
        Me.lblSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSub.Location = New System.Drawing.Point(113, 41)
        Me.lblSub.Name = "lblSub"
        Me.lblSub.Size = New System.Drawing.Size(19, 25)
        Me.lblSub.TabIndex = 4
        Me.lblSub.Text = "-"
        '
        'btnResultSub
        '
        Me.btnResultSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultSub.Location = New System.Drawing.Point(243, 40)
        Me.btnResultSub.Name = "btnResultSub"
        Me.btnResultSub.Size = New System.Drawing.Size(75, 23)
        Me.btnResultSub.TabIndex = 3
        Me.btnResultSub.Text = "="
        Me.btnResultSub.UseVisualStyleBackColor = True
        '
        'resultSub
        '
        Me.resultSub.Enabled = False
        Me.resultSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultSub.Location = New System.Drawing.Point(326, 41)
        Me.resultSub.Name = "resultSub"
        Me.resultSub.Size = New System.Drawing.Size(100, 22)
        Me.resultSub.TabIndex = 2
        '
        'valSub2
        '
        Me.valSub2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valSub2.Location = New System.Drawing.Point(137, 41)
        Me.valSub2.Name = "valSub2"
        Me.valSub2.Size = New System.Drawing.Size(100, 22)
        Me.valSub2.TabIndex = 1
        '
        'valSub1
        '
        Me.valSub1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valSub1.Location = New System.Drawing.Point(7, 41)
        Me.valSub1.Name = "valSub1"
        Me.valSub1.Size = New System.Drawing.Size(100, 22)
        Me.valSub1.TabIndex = 0
        '
        'grpMulti
        '
        Me.grpMulti.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpMulti.Controls.Add(Me.lblMulti)
        Me.grpMulti.Controls.Add(Me.btnResultMulti)
        Me.grpMulti.Controls.Add(Me.valMult2)
        Me.grpMulti.Controls.Add(Me.resultMulti)
        Me.grpMulti.Controls.Add(Me.valMult1)
        Me.grpMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMulti.Location = New System.Drawing.Point(15, 283)
        Me.grpMulti.Name = "grpMulti"
        Me.grpMulti.Size = New System.Drawing.Size(440, 100)
        Me.grpMulti.TabIndex = 2
        Me.grpMulti.TabStop = False
        Me.grpMulti.Text = "MULTIPLICAÇÃO"
        '
        'lblMulti
        '
        Me.lblMulti.AutoSize = True
        Me.lblMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMulti.Location = New System.Drawing.Point(113, 35)
        Me.lblMulti.Name = "lblMulti"
        Me.lblMulti.Size = New System.Drawing.Size(20, 25)
        Me.lblMulti.TabIndex = 4
        Me.lblMulti.Text = "*"
        '
        'btnResultMulti
        '
        Me.btnResultMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultMulti.Location = New System.Drawing.Point(245, 35)
        Me.btnResultMulti.Name = "btnResultMulti"
        Me.btnResultMulti.Size = New System.Drawing.Size(75, 23)
        Me.btnResultMulti.TabIndex = 3
        Me.btnResultMulti.Text = "="
        Me.btnResultMulti.UseVisualStyleBackColor = True
        '
        'valMult2
        '
        Me.valMult2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valMult2.Location = New System.Drawing.Point(139, 35)
        Me.valMult2.Name = "valMult2"
        Me.valMult2.Size = New System.Drawing.Size(100, 22)
        Me.valMult2.TabIndex = 2
        '
        'resultMulti
        '
        Me.resultMulti.Enabled = False
        Me.resultMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultMulti.Location = New System.Drawing.Point(326, 35)
        Me.resultMulti.Name = "resultMulti"
        Me.resultMulti.Size = New System.Drawing.Size(100, 22)
        Me.resultMulti.TabIndex = 1
        '
        'valMult1
        '
        Me.valMult1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valMult1.Location = New System.Drawing.Point(7, 35)
        Me.valMult1.Name = "valMult1"
        Me.valMult1.Size = New System.Drawing.Size(100, 22)
        Me.valMult1.TabIndex = 0
        '
        'grpDiv
        '
        Me.grpDiv.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grpDiv.Controls.Add(Me.lblDiv)
        Me.grpDiv.Controls.Add(Me.btnResultDiv)
        Me.grpDiv.Controls.Add(Me.resultDiv)
        Me.grpDiv.Controls.Add(Me.valDiv2)
        Me.grpDiv.Controls.Add(Me.valDiv1)
        Me.grpDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpDiv.Location = New System.Drawing.Point(15, 407)
        Me.grpDiv.Name = "grpDiv"
        Me.grpDiv.Size = New System.Drawing.Size(440, 100)
        Me.grpDiv.TabIndex = 3
        Me.grpDiv.TabStop = False
        Me.grpDiv.Text = "DIVISÃO"
        '
        'lblDiv
        '
        Me.lblDiv.AutoSize = True
        Me.lblDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiv.Location = New System.Drawing.Point(113, 34)
        Me.lblDiv.Name = "lblDiv"
        Me.lblDiv.Size = New System.Drawing.Size(18, 25)
        Me.lblDiv.TabIndex = 4
        Me.lblDiv.Text = "/"
        '
        'btnResultDiv
        '
        Me.btnResultDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResultDiv.Location = New System.Drawing.Point(245, 35)
        Me.btnResultDiv.Name = "btnResultDiv"
        Me.btnResultDiv.Size = New System.Drawing.Size(75, 23)
        Me.btnResultDiv.TabIndex = 3
        Me.btnResultDiv.Text = "="
        Me.btnResultDiv.UseVisualStyleBackColor = True
        '
        'resultDiv
        '
        Me.resultDiv.Enabled = False
        Me.resultDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultDiv.Location = New System.Drawing.Point(326, 35)
        Me.resultDiv.Name = "resultDiv"
        Me.resultDiv.Size = New System.Drawing.Size(100, 22)
        Me.resultDiv.TabIndex = 2
        '
        'valDiv2
        '
        Me.valDiv2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valDiv2.Location = New System.Drawing.Point(137, 35)
        Me.valDiv2.Name = "valDiv2"
        Me.valDiv2.Size = New System.Drawing.Size(100, 22)
        Me.valDiv2.TabIndex = 1
        '
        'valDiv1
        '
        Me.valDiv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valDiv1.Location = New System.Drawing.Point(7, 34)
        Me.valDiv1.Name = "valDiv1"
        Me.valDiv1.Size = New System.Drawing.Size(100, 22)
        Me.valDiv1.TabIndex = 0
        '
        'lblAviso
        '
        Me.lblAviso.AutoSize = True
        Me.lblAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAviso.Location = New System.Drawing.Point(12, 541)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(57, 17)
        Me.lblAviso.TabIndex = 4
        Me.lblAviso.Text = "Label1"
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 567)
        Me.Controls.Add(Me.lblAviso)
        Me.Controls.Add(Me.grpDiv)
        Me.Controls.Add(Me.grpMulti)
        Me.Controls.Add(Me.grpSub)
        Me.Controls.Add(Me.grpSoma)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Calculadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.grpSoma.ResumeLayout(False)
        Me.grpSoma.PerformLayout()
        Me.grpSub.ResumeLayout(False)
        Me.grpSub.PerformLayout()
        Me.grpMulti.ResumeLayout(False)
        Me.grpMulti.PerformLayout()
        Me.grpDiv.ResumeLayout(False)
        Me.grpDiv.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpSoma As GroupBox
    Friend WithEvents grpSub As GroupBox
    Friend WithEvents grpMulti As GroupBox
    Friend WithEvents grpDiv As GroupBox
    Friend WithEvents lblAviso As Label
    Friend WithEvents lblSoma As Label
    Friend WithEvents btnResultSoma As Button
    Friend WithEvents resultSoma As TextBox
    Friend WithEvents valSoma2 As TextBox
    Friend WithEvents valSoma1 As TextBox
    Friend WithEvents lblSub As Label
    Friend WithEvents btnResultSub As Button
    Friend WithEvents resultSub As TextBox
    Friend WithEvents valSub2 As TextBox
    Friend WithEvents valSub1 As TextBox
    Friend WithEvents lblMulti As Label
    Friend WithEvents btnResultMulti As Button
    Friend WithEvents valMult2 As TextBox
    Friend WithEvents resultMulti As TextBox
    Friend WithEvents valMult1 As TextBox
    Friend WithEvents lblDiv As Label
    Friend WithEvents btnResultDiv As Button
    Friend WithEvents resultDiv As TextBox
    Friend WithEvents valDiv2 As TextBox
    Friend WithEvents valDiv1 As TextBox
End Class
