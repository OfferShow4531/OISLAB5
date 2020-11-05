Public Class Доставка
    Private Sub Доставка_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PharmasyDataSet.Доставка". При необходимости она может быть перемещена или удалена.
        Me.ДоставкаTableAdapter.Fill(Me.PharmasyDataSet.Доставка)

    End Sub
End Class