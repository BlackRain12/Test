Imports System.Data.SqlClient
Public Class PresidentResults

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        con.ConnectionString = "Server=DESKTOP-2LBUH21\SERVER; Database=election;Trusted_Connection=True;"
        Dim cmd As New SqlCommand("select COUNT(number) As 'John Doe Votes' from result  where number=1 and name='John Doe' and position='President'", con)
        Dim cmd2 As New SqlCommand("select COUNT(number)as 'Ama Doe Votes' from result where number=1 and name='Ama Doe' and position='President'", con)
        Dim cmd3 As New SqlCommand("select COUNT(number)as 'Kwasi Osei Votes' from result where number=1 and name='Kwasi Osei' and position='President'", con)
        Dim da1 As New SqlDataAdapter
        Dim da2 As New SqlDataAdapter
        Dim da3 As New SqlDataAdapter
        da1.SelectCommand = cmd
        da2.SelectCommand = cmd2
        da3.SelectCommand = cmd3


        Dim dt1 As New DataTable
        Dim dt2 As New DataTable
        Dim dt3 As New DataTable
        da1.Fill(dt1)
        da2.Fill(dt2)
        da3.Fill(dt3)
        DataGridView1.DataSource = dt1
        DataGridView2.DataSource = dt2
        DataGridView3.DataSource = dt3
    End Sub
End Class