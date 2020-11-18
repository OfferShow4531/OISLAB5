<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Форма_Аптеки
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Форма_Аптеки))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PharmasyDataSet = New OISLaboratory.PharmasyDataSet()
        Me.АптекаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.АптекаTableAdapter = New OISLaboratory.PharmasyDataSetTableAdapters.АптекаTableAdapter()
        Me.TableAdapterManager = New OISLaboratory.PharmasyDataSetTableAdapters.TableAdapterManager()
        Me.АптекаBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.АптекаBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ДоставкаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ДоставкаTableAdapter = New OISLaboratory.PharmasyDataSetTableAdapters.ДоставкаTableAdapter()
        Me.ДоставкаDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ДоставкаBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PharmasyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.АптекаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.АптекаBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.АптекаBindingNavigator.SuspendLayout()
        CType(Me.ДоставкаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ДоставкаDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ДоставкаBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(581, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 374)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Сортировать"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(293, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Таблица Доставки"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Поле для сортировки"
        '
        'ListBox1
        '
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ДоставкаBindingSource, "Вид товара", True))
        Me.ListBox1.DataSource = Me.ДоставкаBindingSource1
        Me.ListBox1.DisplayMember = "Вид товара"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(22, 77)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(359, 164)
        Me.ListBox1.TabIndex = 1
        Me.ListBox1.ValueMember = "Время доставки"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(22, 259)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(137, 21)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "По возрастанию"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(266, 259)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(97, 21)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.Text = "Убыванию"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(121, 304)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(186, 50)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Сортировать"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(581, 419)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(181, 31)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Фильтровать"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(795, 419)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(167, 31)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Показать"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(581, 463)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(181, 31)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Найти"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(795, 463)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(167, 31)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Закрыть"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 433)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(121, 341)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(304, 24)
        Me.ComboBox1.TabIndex = 8
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(121, 433)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(304, 22)
        Me.TextBox1.TabIndex = 9
        '
        'PharmasyDataSet
        '
        Me.PharmasyDataSet.DataSetName = "PharmasyDataSet"
        Me.PharmasyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'АптекаBindingSource
        '
        Me.АптекаBindingSource.DataMember = "Аптека"
        Me.АптекаBindingSource.DataSource = Me.PharmasyDataSet
        '
        'АптекаTableAdapter
        '
        Me.АптекаTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = OISLaboratory.PharmasyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.АптекаTableAdapter = Me.АптекаTableAdapter
        Me.TableAdapterManager.ДоставкаTableAdapter = Me.ДоставкаTableAdapter
        Me.TableAdapterManager.СкладTableAdapter = Nothing
        '
        'АптекаBindingNavigator
        '
        Me.АптекаBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.АптекаBindingNavigator.BindingSource = Me.АптекаBindingSource
        Me.АптекаBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.АптекаBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.АптекаBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.АптекаBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.АптекаBindingNavigatorSaveItem})
        Me.АптекаBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.АптекаBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.АптекаBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.АптекаBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.АптекаBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.АптекаBindingNavigator.Name = "АптекаBindingNavigator"
        Me.АптекаBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.АптекаBindingNavigator.Size = New System.Drawing.Size(988, 31)
        Me.АптекаBindingNavigator.TabIndex = 10
        Me.АптекаBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 20)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'АптекаBindingNavigatorSaveItem
        '
        Me.АптекаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.АптекаBindingNavigatorSaveItem.Image = CType(resources.GetObject("АптекаBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.АптекаBindingNavigatorSaveItem.Name = "АптекаBindingNavigatorSaveItem"
        Me.АптекаBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.АптекаBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ДоставкаBindingSource
        '
        Me.ДоставкаBindingSource.DataMember = "Доставка"
        Me.ДоставкаBindingSource.DataSource = Me.PharmasyDataSet
        '
        'ДоставкаTableAdapter
        '
        Me.ДоставкаTableAdapter.ClearBeforeFill = True
        '
        'ДоставкаDataGridView
        '
        Me.ДоставкаDataGridView.AutoGenerateColumns = False
        Me.ДоставкаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ДоставкаDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.ДоставкаDataGridView.DataSource = Me.ДоставкаBindingSource
        Me.ДоставкаDataGridView.Location = New System.Drawing.Point(143, 73)
        Me.ДоставкаDataGridView.Name = "ДоставкаDataGridView"
        Me.ДоставкаDataGridView.RowHeadersWidth = 51
        Me.ДоставкаDataGridView.RowTemplate.Height = 24
        Me.ДоставкаDataGridView.Size = New System.Drawing.Size(371, 250)
        Me.ДоставкаDataGridView.TabIndex = 11
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Штрих-код препарата"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Штрих-код препарата"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Время доставки"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Время доставки"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Вид товара"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Вид товара"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Цена"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Цена"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'ДоставкаBindingSource1
        '
        Me.ДоставкаBindingSource1.DataMember = "Доставка"
        Me.ДоставкаBindingSource1.DataSource = Me.PharmasyDataSet
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(208, 484)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(168, 37)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "Таблица"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Форма_Аптеки
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(988, 533)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ДоставкаDataGridView)
        Me.Controls.Add(Me.АптекаBindingNavigator)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Форма_Аптеки"
        Me.Text = "Форма_Аптеки"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PharmasyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.АптекаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.АптекаBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.АптекаBindingNavigator.ResumeLayout(False)
        Me.АптекаBindingNavigator.PerformLayout()
        CType(Me.ДоставкаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ДоставкаDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ДоставкаBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PharmasyDataSet As PharmasyDataSet
    Friend WithEvents АптекаBindingSource As BindingSource
    Friend WithEvents АптекаTableAdapter As PharmasyDataSetTableAdapters.АптекаTableAdapter
    Friend WithEvents TableAdapterManager As PharmasyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents АптекаBindingNavigator As BindingNavigator
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
    Friend WithEvents АптекаBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ДоставкаTableAdapter As PharmasyDataSetTableAdapters.ДоставкаTableAdapter
    Friend WithEvents ДоставкаBindingSource As BindingSource
    Friend WithEvents ДоставкаDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ДоставкаBindingSource1 As BindingSource
    Friend WithEvents Button6 As Button
End Class
