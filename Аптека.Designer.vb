<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class АптекаBindingSource
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

    Friend Shared Sub MoveFirst()
        Throw New NotImplementedException()
    End Sub

    Friend Shared Sub MovePrevious()
        Throw New NotImplementedException()
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    Friend Shared Sub AddNew()
        Throw New NotImplementedException()
    End Sub

    Friend Shared Sub MoveLast()
        Throw New NotImplementedException()
    End Sub

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PharmasyDataSet = New OISLaboratory.PharmasyDataSet()
        Me.АптекаBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.АптекаTableAdapter = New OISLaboratory.PharmasyDataSetTableAdapters.АптекаTableAdapter()
        Me.TableAdapterManager1 = New OISLaboratory.PharmasyDataSetTableAdapters.TableAdapterManager()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PharmasyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.АптекаBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Label1.Location = New System.Drawing.Point(373, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ТАБЛИЦА АПТЕКА"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Номер препарата"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Имя препарата"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(152, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Тип лекарства"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 319)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Стоимость"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(152, 382)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Дата изготовления"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(152, 448)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Компания"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.АптекаBindingSource1, "Дата изготовления", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(348, 377)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 7
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.АптекаBindingSource1, "Номер препарата", True))
        Me.NumericUpDown1.Location = New System.Drawing.Point(348, 86)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 22)
        Me.NumericUpDown1.TabIndex = 8
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АптекаBindingSource1, "Название препарата", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(348, 168)
        Me.MaskedTextBox1.Mask = "Text"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(120, 22)
        Me.MaskedTextBox1.TabIndex = 9
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АптекаBindingSource1, "Тип лекарства", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(348, 241)
        Me.MaskedTextBox2.Mask = "Text"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox2.TabIndex = 10
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АптекаBindingSource1, "Компания", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(348, 448)
        Me.MaskedTextBox3.Mask = "Text"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox3.TabIndex = 11
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.АптекаBindingSource1, "Стоимость лекарства", True))
        Me.MaskedTextBox4.Location = New System.Drawing.Point(348, 314)
        Me.MaskedTextBox4.Mask = "00000"
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox4.TabIndex = 12
        Me.MaskedTextBox4.ValidatingType = GetType(Integer)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(701, 85)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 33)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Первая"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(701, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 31)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Предыдущая"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(701, 204)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 29)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(701, 265)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 31)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Последняя"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(701, 331)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 30)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "Следующая"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(701, 392)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(120, 30)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(701, 448)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(120, 33)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'PharmasyDataSet
        '
        Me.PharmasyDataSet.DataSetName = "PharmasyDataSet"
        Me.PharmasyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'АптекаBindingSource1
        '
        Me.АптекаBindingSource1.DataMember = "Аптека"
        Me.АптекаBindingSource1.DataSource = Me.PharmasyDataSet
        '
        'АптекаTableAdapter
        '
        Me.АптекаTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.UpdateOrder = OISLaboratory.PharmasyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.АптекаTableAdapter = Me.АптекаTableAdapter
        Me.TableAdapterManager1.ДоставкаTableAdapter = Nothing
        Me.TableAdapterManager1.СкладTableAdapter = Nothing
        '
        'АптекаBindingSource
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 540)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MaskedTextBox4)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "АптекаBindingSource"
        Me.Text = "Аптека"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PharmasyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.АптекаBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents PharmasyDataSet As PharmasyDataSet
    Friend WithEvents АптекаBindingSource1 As BindingSource
    Friend WithEvents АптекаTableAdapter As PharmasyDataSetTableAdapters.АптекаTableAdapter
    Friend WithEvents TableAdapterManager1 As PharmasyDataSetTableAdapters.TableAdapterManager
End Class
