Public Class АптекаBindingSource

    Public Property АптекаBindingSource As Object

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "PharmasyDataSet.Аптека". При необходимости она может быть перемещена или удалена.
        Me.АптекаTableAdapter.Fill(Me.PharmasyDataSet.Аптека)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        АптекаBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        АптекаBindingSource.MovePrevious()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        АптекаBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        АптекаBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        АптекаBindingSource.MoveNext()
    End Sub

    Private Shared Sub MoveNext()
        Throw New NotImplementedException()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        АптекаBindingSource.RemoveCurrent()
    End Sub

    Private Shared Sub RemoveCurrent()
        Throw New NotImplementedException()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Validate()
        Me.АптекаBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PharmasyDataSet)
    End Sub

    Private Function TableAdapterManager() As Object
        Throw New NotImplementedException()
    End Function

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged

    End Sub
End Class
