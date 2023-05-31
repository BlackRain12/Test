Imports System.Data.SqlClient

Public Class VicePresident

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        con.ConnectionString = "Server=DESKTOP-2LBUH21\SERVER; Database=election;Trusted_Connection=True;"
        Dim cmd As New SqlCommand("select * from VicePresident", con)

        Dim da As New SqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox1.DataSource = dt
        ComboBox1.DisplayMember = "Name"
        'ComboBox2.Items.Add("President")
        ComboBox2.Items.Add("Vice President")
        'ComboBox2.Items.Add("Organizing Secretary")
        'ComboBox2.Items.Add("Finance Secretary")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("Please select Yes or No")
        End If
        Dim con As New SqlConnection
        con.ConnectionString = "Server=DESKTOP-2LBUH21\SERVER; Database=election;Trusted_Connection=True;"
        Dim cmd As New SqlCommand("insert into result(name,number,position)values(@name,@number,@position)", con)
        Dim agree_v As Boolean
        If RadioButton1.Checked = True Then
            agree_v = 1

        End If
        If RadioButton2.Checked = True Then
            agree_v = 0

        End If
        cmd.Parameters.AddWithValue("name", ComboBox1.Text)
        cmd.Parameters.AddWithValue("position", ComboBox2.Text)
        cmd.Parameters.AddWithValue("number", agree_v)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Vote Recorded")
        Me.Hide()

        OrgSec.Show()



    End Sub
End Class