<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim Txt_nomeLabel As System.Windows.Forms.Label
        Dim Txt_enderecoLabel As System.Windows.Forms.Label
        Dim Txt_cidadeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CadastroDataSet = New Cadastro.CadastroDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New Cadastro.CadastroDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New Cadastro.CadastroDataSetTableAdapters.TableAdapterManager()
        Me.ClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdLabel1 = New System.Windows.Forms.Label()
        Me.Txt_nomeTextBox = New System.Windows.Forms.TextBox()
        Me.Txt_enderecoTextBox = New System.Windows.Forms.TextBox()
        Me.Txt_cidadeTextBox = New System.Windows.Forms.TextBox()
        Me.btnAbrir = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        Txt_nomeLabel = New System.Windows.Forms.Label()
        Txt_enderecoLabel = New System.Windows.Forms.Label()
        Txt_cidadeLabel = New System.Windows.Forms.Label()
        CType(Me.CadastroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(15, 30)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'Txt_nomeLabel
        '
        Txt_nomeLabel.AutoSize = True
        Txt_nomeLabel.Location = New System.Drawing.Point(15, 59)
        Txt_nomeLabel.Name = "Txt_nomeLabel"
        Txt_nomeLabel.Size = New System.Drawing.Size(50, 13)
        Txt_nomeLabel.TabIndex = 3
        Txt_nomeLabel.Text = "txt nome:"
        '
        'Txt_enderecoLabel
        '
        Txt_enderecoLabel.AutoSize = True
        Txt_enderecoLabel.Location = New System.Drawing.Point(15, 85)
        Txt_enderecoLabel.Name = "Txt_enderecoLabel"
        Txt_enderecoLabel.Size = New System.Drawing.Size(69, 13)
        Txt_enderecoLabel.TabIndex = 5
        Txt_enderecoLabel.Text = "txt endereco:"
        '
        'Txt_cidadeLabel
        '
        Txt_cidadeLabel.AutoSize = True
        Txt_cidadeLabel.Location = New System.Drawing.Point(15, 111)
        Txt_cidadeLabel.Name = "Txt_cidadeLabel"
        Txt_cidadeLabel.Size = New System.Drawing.Size(56, 13)
        Txt_cidadeLabel.TabIndex = 7
        Txt_cidadeLabel.Text = "txt cidade:"
        '
        'CadastroDataSet
        '
        Me.CadastroDataSet.DataSetName = "CadastroDataSet"
        Me.CadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.CadastroDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cadastro.CadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientesBindingNavigator
        '
        Me.ClientesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientesBindingNavigator.BindingSource = Me.ClientesBindingSource
        Me.ClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientesBindingNavigatorSaveItem})
        Me.ClientesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ClientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientesBindingNavigator.Name = "ClientesBindingNavigator"
        Me.ClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientesBindingNavigator.Size = New System.Drawing.Size(362, 25)
        Me.ClientesBindingNavigator.TabIndex = 0
        Me.ClientesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ClientesBindingNavigatorSaveItem
        '
        Me.ClientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientesBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientesBindingNavigatorSaveItem.Name = "ClientesBindingNavigatorSaveItem"
        Me.ClientesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClientesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdLabel1
        '
        Me.IdLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Id", True))
        Me.IdLabel1.Location = New System.Drawing.Point(90, 30)
        Me.IdLabel1.Name = "IdLabel1"
        Me.IdLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IdLabel1.TabIndex = 2
        Me.IdLabel1.Text = "Label1"
        '
        'Txt_nomeTextBox
        '
        Me.Txt_nomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "txt_nome", True))
        Me.Txt_nomeTextBox.Location = New System.Drawing.Point(90, 56)
        Me.Txt_nomeTextBox.Name = "Txt_nomeTextBox"
        Me.Txt_nomeTextBox.Size = New System.Drawing.Size(245, 20)
        Me.Txt_nomeTextBox.TabIndex = 4
        '
        'Txt_enderecoTextBox
        '
        Me.Txt_enderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "txt_endereco", True))
        Me.Txt_enderecoTextBox.Location = New System.Drawing.Point(90, 82)
        Me.Txt_enderecoTextBox.Name = "Txt_enderecoTextBox"
        Me.Txt_enderecoTextBox.Size = New System.Drawing.Size(245, 20)
        Me.Txt_enderecoTextBox.TabIndex = 6
        '
        'Txt_cidadeTextBox
        '
        Me.Txt_cidadeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "txt_cidade", True))
        Me.Txt_cidadeTextBox.Location = New System.Drawing.Point(90, 108)
        Me.Txt_cidadeTextBox.Name = "Txt_cidadeTextBox"
        Me.Txt_cidadeTextBox.Size = New System.Drawing.Size(245, 20)
        Me.Txt_cidadeTextBox.TabIndex = 8
        '
        'btnAbrir
        '
        Me.btnAbrir.Location = New System.Drawing.Point(221, 151)
        Me.btnAbrir.Name = "btnAbrir"
        Me.btnAbrir.Size = New System.Drawing.Size(123, 23)
        Me.btnAbrir.TabIndex = 9
        Me.btnAbrir.Text = "ABRIR"
        Me.btnAbrir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 341)
        Me.Controls.Add(Me.btnAbrir)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdLabel1)
        Me.Controls.Add(Txt_nomeLabel)
        Me.Controls.Add(Me.Txt_nomeTextBox)
        Me.Controls.Add(Txt_enderecoLabel)
        Me.Controls.Add(Me.Txt_enderecoTextBox)
        Me.Controls.Add(Txt_cidadeLabel)
        Me.Controls.Add(Me.Txt_cidadeTextBox)
        Me.Controls.Add(Me.ClientesBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Cadastro"
        CType(Me.CadastroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingNavigator.ResumeLayout(False)
        Me.ClientesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CadastroDataSet As CadastroDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As CadastroDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As CadastroDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ClientesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdLabel1 As Label
    Friend WithEvents Txt_nomeTextBox As TextBox
    Friend WithEvents Txt_enderecoTextBox As TextBox
    Friend WithEvents Txt_cidadeTextBox As TextBox
    Friend WithEvents btnAbrir As Button
End Class
