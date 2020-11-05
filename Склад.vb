Public Class Склад
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Склад_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PharmasyDataSet.Склад". При необходимости она может быть перемещена или удалена.
        Me.СкладTableAdapter.Fill(Me.PharmasyDataSet.Склад)

    End Sub
End Class