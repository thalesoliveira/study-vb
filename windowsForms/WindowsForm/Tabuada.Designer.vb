﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tabuada
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTabuada = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtCidades = New System.Windows.Forms.TextBox()
        Me.btnArray = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INFORME UM NÚMERO"
        '
        'btnTabuada
        '
        Me.btnTabuada.Location = New System.Drawing.Point(25, 92)
        Me.btnTabuada.Name = "btnTabuada"
        Me.btnTabuada.Size = New System.Drawing.Size(124, 34)
        Me.btnTabuada.TabIndex = 1
        Me.btnTabuada.Text = "Gerar Tabuada"
        Me.btnTabuada.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(25, 55)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(124, 20)
        Me.txtNumero.TabIndex = 2
        '
        'txtCidades
        '
        Me.txtCidades.Location = New System.Drawing.Point(211, 72)
        Me.txtCidades.Multiline = True
        Me.txtCidades.Name = "txtCidades"
        Me.txtCidades.Size = New System.Drawing.Size(188, 257)
        Me.txtCidades.TabIndex = 3
        '
        'btnArray
        '
        Me.btnArray.Location = New System.Drawing.Point(211, 29)
        Me.btnArray.Name = "btnArray"
        Me.btnArray.Size = New System.Drawing.Size(188, 37)
        Me.btnArray.TabIndex = 4
        Me.btnArray.Text = "Gerando Array"
        Me.btnArray.UseVisualStyleBackColor = True
        '
        'Tabuada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(426, 341)
        Me.Controls.Add(Me.btnArray)
        Me.Controls.Add(Me.txtCidades)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.btnTabuada)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Tabuada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabuada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnTabuada As Button
    Friend WithEvents txtNumero As TextBox
    Friend WithEvents txtCidades As TextBox
    Friend WithEvents btnArray As Button
End Class
