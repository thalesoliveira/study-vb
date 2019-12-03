<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioTreeView
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node3")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node ", New System.Windows.Forms.TreeNode() {TreeNode1})
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node4")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2", New System.Windows.Forms.TreeNode() {TreeNode4})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioTreeView))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.btnAddNo = New System.Windows.Forms.Button()
        Me.txtNoRaiz = New System.Windows.Forms.TextBox()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExpandir = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.txtNoFilho = New System.Windows.Forms.TextBox()
        Me.btnNoFilho = New System.Windows.Forms.Button()
        Me.TreeView3 = New System.Windows.Forms.TreeView()
        Me.btnExibirCategoriasProdutos = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(432, 12)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node3"
        TreeNode1.Text = "Node3"
        TreeNode2.Name = "Node0"
        TreeNode2.Text = "Node "
        TreeNode3.Name = "Node1"
        TreeNode3.Text = "Node1"
        TreeNode4.Name = "Node4"
        TreeNode4.Text = "Node4"
        TreeNode5.Name = "Node2"
        TreeNode5.Text = "Node2"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode5})
        Me.TreeView1.Size = New System.Drawing.Size(258, 70)
        Me.TreeView1.TabIndex = 0
        '
        'TreeView2
        '
        Me.TreeView2.Location = New System.Drawing.Point(11, 214)
        Me.TreeView2.Name = "TreeView2"
        Me.TreeView2.Size = New System.Drawing.Size(385, 133)
        Me.TreeView2.TabIndex = 1
        '
        'btnAddNo
        '
        Me.btnAddNo.Location = New System.Drawing.Point(185, 12)
        Me.btnAddNo.Name = "btnAddNo"
        Me.btnAddNo.Size = New System.Drawing.Size(153, 36)
        Me.btnAddNo.TabIndex = 2
        Me.btnAddNo.Text = "Adicionar No Raiz"
        Me.btnAddNo.UseVisualStyleBackColor = True
        '
        'txtNoRaiz
        '
        Me.txtNoRaiz.Location = New System.Drawing.Point(13, 18)
        Me.txtNoRaiz.Name = "txtNoRaiz"
        Me.txtNoRaiz.Size = New System.Drawing.Size(166, 22)
        Me.txtNoRaiz.TabIndex = 3
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(296, 162)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(109, 30)
        Me.btnLimpar.TabIndex = 4
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(11, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(136, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Adicionar Regiões"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExpandir
        '
        Me.btnExpandir.Location = New System.Drawing.Point(11, 164)
        Me.btnExpandir.Name = "btnExpandir"
        Me.btnExpandir.Size = New System.Drawing.Size(136, 26)
        Me.btnExpandir.TabIndex = 6
        Me.btnExpandir.Text = "Expandir"
        Me.btnExpandir.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(153, 164)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(137, 28)
        Me.btnFechar.TabIndex = 7
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'txtNoFilho
        '
        Me.txtNoFilho.Location = New System.Drawing.Point(13, 60)
        Me.txtNoFilho.Name = "txtNoFilho"
        Me.txtNoFilho.Size = New System.Drawing.Size(166, 22)
        Me.txtNoFilho.TabIndex = 8
        '
        'btnNoFilho
        '
        Me.btnNoFilho.Location = New System.Drawing.Point(186, 58)
        Me.btnNoFilho.Name = "btnNoFilho"
        Me.btnNoFilho.Size = New System.Drawing.Size(152, 33)
        Me.btnNoFilho.TabIndex = 9
        Me.btnNoFilho.Text = "Adicionar No Filho"
        Me.btnNoFilho.UseVisualStyleBackColor = True
        '
        'TreeView3
        '
        Me.TreeView3.ImageIndex = 0
        Me.TreeView3.ImageList = Me.ImageList1
        Me.TreeView3.Location = New System.Drawing.Point(11, 376)
        Me.TreeView3.Name = "TreeView3"
        Me.TreeView3.SelectedImageIndex = 0
        Me.TreeView3.Size = New System.Drawing.Size(385, 291)
        Me.TreeView3.TabIndex = 10
        '
        'btnExibirCategoriasProdutos
        '
        Me.btnExibirCategoriasProdutos.Location = New System.Drawing.Point(416, 376)
        Me.btnExibirCategoriasProdutos.Name = "btnExibirCategoriasProdutos"
        Me.btnExibirCategoriasProdutos.Size = New System.Drawing.Size(194, 32)
        Me.btnExibirCategoriasProdutos.TabIndex = 11
        Me.btnExibirCategoriasProdutos.Text = "Exibir Categorias/Produtos"
        Me.btnExibirCategoriasProdutos.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "close.png")
        Me.ImageList1.Images.SetKeyName(1, "open.png")
        '
        'FormularioTreeView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 696)
        Me.Controls.Add(Me.btnExibirCategoriasProdutos)
        Me.Controls.Add(Me.TreeView3)
        Me.Controls.Add(Me.btnNoFilho)
        Me.Controls.Add(Me.txtNoFilho)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnExpandir)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.txtNoRaiz)
        Me.Controls.Add(Me.btnAddNo)
        Me.Controls.Add(Me.TreeView2)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "FormularioTreeView"
        Me.Text = "Formulario Tree View"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents TreeView2 As TreeView
    Friend WithEvents btnAddNo As Button
    Friend WithEvents txtNoRaiz As TextBox
    Friend WithEvents btnLimpar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnExpandir As Button
    Friend WithEvents btnFechar As Button
    Friend WithEvents txtNoFilho As TextBox
    Friend WithEvents btnNoFilho As Button
    Friend WithEvents TreeView3 As TreeView
    Friend WithEvents btnExibirCategoriasProdutos As Button
    Friend WithEvents ImageList1 As ImageList
End Class
