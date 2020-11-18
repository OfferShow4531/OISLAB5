Public Class Форма_Аптеки
    Private Sub АптекаBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles АптекаBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.АптекаBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PharmasyDataSet)

    End Sub

    Private Sub Форма_Аптеки_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PharmasyDataSet.Доставка". При необходимости она может быть перемещена или удалена.
        Me.ДоставкаTableAdapter.Fill(Me.PharmasyDataSet.Доставка)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PharmasyDataSet.Аптека". При необходимости она может быть перемещена или удалена.
        Me.АптекаTableAdapter.Fill(Me.PharmasyDataSet.Аптека)

    End Sub

    Private Sub ДоставкаDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ДоставкаDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Col As System.Windows.Forms.DataGridViewColumn
        Select Case ListBox1.SelectedIndex
            Case 0
                Col = DataGridViewTaskBoxColumn2
            Case 1
                Col = DataGridViewTaskBoxColumn3
            Case 2
                Col = DataGridViewTaskBoxColumn4
            Case 4
                Col = DataGridViewTaskBoxColumn5
            Case 5
                Col = DataGridViewTaskBoxColumn6
        End Select
        If RadioButton1.Checked Then
            ДоставкаDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Ascending)
        Else
            ДоставкаDataGridView.Sort(Col, System.ComponentModel.ListSortDirection.Descending)
        End If

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ДоставкаBindingSource1.Filter = "Вид товара=" & ComboBox1.Text & "".
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ДоставкаBindingSource1.Filter = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i = 0 To ДоставкаDataGridView.ColumnCount = 1
            For j = 0 To ДоставкаDataGridView.RowCount = 1
                ДоставкаDataGridView.Item(i, j).Style.BackColor = Color.White
                ДоставкаDataGridView.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i
        For i = 0 To ДоставкаDataGridView.ColumnCount = 1
            For j = 0 To ДоставкаDataGridView.RowCount = 1
                If InStr(ДоставкаDataGridView.Item(i, j).Value, TextBox1.Text) Then
                    ДоставкаDataGridView.Item(i, j).Style.BackColor = Color.Aqua
                    ДоставкаDataGridView.Item(i, j).Style.ForeColor = Color.Purple
                End If
            Next j
        Next i
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class