Imports System.Data.SqlClient
Public Class Welcome

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Welcome," & login.txtid.Text


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Application.Exit()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
       
        Dim con As New SqlConnection
        con.ConnectionString = "Server=DESKTOP-2LBUH21\SERVER; Database=election;Trusted_Connection=True;"
        Dim cmd As New SqlCommand("select * from result where studentid=@studentid", con)
        cmd.Parameters.Add("@studentid", SqlDbType.VarChar).Value = login.txtid.Text

        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count = 0 Then
            Me.Hide()
            pres.Show()

        Else

            MessageBox.Show("You have Already voted!")
         
        End If

    End Sub
End Class