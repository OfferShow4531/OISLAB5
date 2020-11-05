<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Доставка
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
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MaskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PharmasyDataSet = New OISLaboratory.PharmasyDataSet()
        Me.ДоставкаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ДоставкаTableAdapter = New OISLaboratory.PharmasyDataSetTableAdapters.ДоставкаTableAdapter()
        Me.TableAdapterManager = New OISLaboratory.PharmasyDataSetTableAdapters.TableAdapterManager()
        Me.MaskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PharmasyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ДоставкаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(691, 465)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(120, 33)
        Me.Button7.TabIndex = 59
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(691, 409)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(120, 30)
        Me.Button6.TabIndex = 58
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(691, 348)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(120, 30)
        Me.Button5.TabIndex = 57
        Me.Button5.Text = "Следующая"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(691, 282)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(120, 31)
        Me.Button4.TabIndex = 56
        Me.Button4.Text = "Последняя"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(691, 221)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(120, 29)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(691, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 31)
        Me.Button2.TabIndex = 54
        Me.Button2.Text = "Предыдущая"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(691, 102)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 33)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Первая"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MaskedTextBox3
        '
        Me.MaskedTextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ДоставкаBindingSource, "Тип валюты", True))
        Me.MaskedTextBox3.Location = New System.Drawing.Point(338, 465)
        Me.MaskedTextBox3.Mask = "Text"
        Me.MaskedTextBox3.Name = "MaskedTextBox3"
        Me.MaskedTextBox3.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox3.TabIndex = 52
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ДоставкаBindingSource, "Имя курьера", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(338, 258)
        Me.MaskedTextBox2.Mask = "Text"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox2.TabIndex = 51
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ДоставкаBindingSource, "Штрих-код препарата", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(338, 105)
        Me.MaskedTextBox1.Mask = "00000-9999"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(120, 22)
        Me.MaskedTextBox1.TabIndex = 50
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ДоставкаBindingSource, "Время доставки", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(338, 343)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(143, 470)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Тип валюты"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(141, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 17)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Дата доставки"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(142, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "Имя курьера"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(143, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Штрих код"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Вид товара"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Label1.Location = New System.Drawing.Point(363, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 17)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "ТАБЛИЦА СКЛАД"
        '
        'PharmasyDataSet
        '
        Me.PharmasyDataSet.DataSetName = "PharmasyDataSet"
        Me.PharmasyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = OISLaboratory.PharmasyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.АптекаTableAdapter = Nothing
        Me.TableAdapterManager.ДоставкаTableAdapter = Me.ДоставкаTableAdapter
        Me.TableAdapterManager.СкладTableAdapter = Nothing
        '
        'MaskedTextBox4
        '
        Me.MaskedTextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ДоставкаBindingSource, "Вид товара", True))
        Me.MaskedTextBox4.Location = New System.Drawing.Point(338, 177)
        Me.MaskedTextBox4.Mask = "Text"
        Me.MaskedTextBox4.Name = "MaskedTextBox4"
        Me.MaskedTextBox4.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox4.TabIndex = 62
        '
        'MaskedTextBox5
        '
        Me.MaskedTextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ДоставкаBindingSource, "Цена", True))
        Me.MaskedTextBox5.Location = New System.Drawing.Point(338, 410)
        Me.MaskedTextBox5.Mask = "00000"
        Me.MaskedTextBox5.Name = "MaskedTextBox5"
        Me.MaskedTextBox5.Size = New System.Drawing.Size(100, 22)
        Me.MaskedTextBox5.TabIndex = 64
        Me.MaskedTextBox5.ValidatingType = GetType(Integer)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 413)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 17)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Цена"
        '
        'Доставка
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 536)
        Me.Controls.Add(Me.MaskedTextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MaskedTextBox4)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MaskedTextBox3)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Доставка"
        Me.Text = "Доставка"
        CType(Me.PharmasyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ДоставкаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents MaskedTextBox3 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PharmasyDataSet As PharmasyDataSet
    Friend WithEvents ДоставкаBindingSource As BindingSource
    Friend WithEvents ДоставкаTableAdapter As PharmasyDataSetTableAdapters.ДоставкаTableAdapter
    Friend WithEvents TableAdapterManager As PharmasyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MaskedTextBox4 As MaskedTextBox
    Friend WithEvents MaskedTextBox5 As MaskedTextBox
    Friend WithEvents Label5 As Label
End Class
