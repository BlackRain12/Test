Imports System.Data.SqlClient

Public Class login

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnvote_Click(sender As Object, e As EventArgs) Handles btnvote.Click
        Dim con As New SqlConnection
        con.ConnectionString = "Server=DESKTOP-2LBUH21\SERVER; Database=election;Trusted_Connection=True;"
        Dim cmd As New SqlCommand("select * from login where student_id=@student_id", con)
        cmd.Parameters.Add("@student_id", SqlDbType.VarChar).Value = txtid.Text
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then

            MessageBox.Show("Invalid ID")
        ElseIf txtid.Text = "" Then
            MessageBox.Show("Enter your id please:")

        Else

            MessageBox.Show("Logged In")
            Me.Hide()

            Welcome.Show()

        End If






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()


    End Sub
End Class