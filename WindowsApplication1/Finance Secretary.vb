Imports System.Data.SqlClient
Public Class Finance_Secretary

    Private Sub Finance_Secretary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        con.ConnectionString = "Server=DESKTOP-2LBUH21\SERVER; Database=election;Trusted_Connection=True;"
        Dim cmd As New SqlCommand("insert into result(name,number,position,studentid)values(@name,@number,@position,@studentid)", con)
        Dim cmd2 As New SqlCommand("insert into result(name,number,position,studentid)values(@name,@number,@position,@studentid)", con)
        Dim cmd3 As New SqlCommand("insert into result(name,number,position,studentid)values(@name,@number,@position,@studentid)", con)
        If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False Then
            MsgBox("Please tick")
        End If
        Dim agree_v1, agree_v2, agree_v3 As Boolean
        If RadioButton1.Checked = True Then
            agree_v1 = 1

        End If
        If RadioButton2.Checked = True Then
            agree_v2 = 1
        End If
        If RadioButton3.Checked = True Then
            agree_v3 = 1
        End If
        cmd.Parameters.AddWithValue("name", Label5.Text)
        cmd.Parameters.AddWithValue("position", "Finance Secretary")
        cmd.Parameters.AddWithValue("number", agree_v1)
        cmd.Parameters.AddWithValue("studentid", login.txtid.Text)
        cmd2.Parameters.AddWithValue("name", Label6.Text)
        cmd2.Parameters.AddWithValue("position", "Finance Secretary")
        cmd2.Parameters.AddWithValue("number", agree_v2)
        cmd2.Parameters.AddWithValue("studentid", login.txtid.Text)
        cmd3.Parameters.AddWithValue("name", Label7.Text)
        cmd3.Parameters.AddWithValue("position", "Finance Secretary")
        cmd3.Parameters.AddWithValue("number", agree_v3)
        cmd3.Parameters.AddWithValue("studentid", login.txtid.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd2.ExecuteNonQuery()
        cmd3.ExecuteNonQuery()

        Me.Hide()

        MessageBox.Show("Thanks for voting, Results would be uploaded soon ")
        Application.Exit()





    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class