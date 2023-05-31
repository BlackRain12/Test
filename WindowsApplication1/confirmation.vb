Imports System.Data.SqlClient
Public Class confirmation
    Dim agree_v1, agree_v2, agree_v3, agree_v4, agree_v5, agree_v6, agree_v7, agree_v8, agree_v9 As Boolean
    Private Sub confirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Hello," & login.txtid.Text
        If pres.RadioButton1.Checked = True Then
            RadioButton1.Checked = True
            agree_v1 = 1

        ElseIf pres.RadioButton2.Checked = True Then
            RadioButton2.Checked = True
            agree_v2 = 1
        ElseIf pres.RadioButton3.Checked = True Then
            RadioButton3.Checked = True
            agree_v3 = 1

        End If
        If OrgSec.RadioButton1.Checked = True Then
            RadioButton6.Checked = True
            agree_v4 = 1
        ElseIf OrgSec.RadioButton2.Checked = True Then
            RadioButton5.Checked = True
            agree_v5 = 1
        ElseIf OrgSec.RadioButton3.Checked = True Then
            RadioButton4.Checked = True
            agree_v6 = 1


        End If
        If Finance_Secretary.RadioButton1.Checked = True Then
            RadioButton9.Checked = True
            agree_v7 = 1
        ElseIf Finance_Secretary.RadioButton2.Checked = True Then
            RadioButton8.Checked = True
            agree_v8 = 1
        ElseIf Finance_Secretary.RadioButton3.Checked = True Then
            RadioButton7.Checked = True
            agree_v9 = 1



        End If


    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As New SqlConnection
        con.ConnectionString = "Server=DESKTOP-2LBUH21\SERVER; Database=election;Trusted_Connection=True;"
        Dim cmd As New SqlCommand("insert into result(name,number,position,studentid)values(@name,@number,@position,@studentid)", con)
        Dim cmd2 As New SqlCommand("insert into result(name,number,position,studentid)values(@name,@number,@position,@studentid)", con)
        Dim cmd3 As New SqlCommand("insert into result(name,number,position,studentid)values(@name,@number,@position,@studentid)", con)
        cmd.Parameters.AddWithValue("name", Label5.Text)
        cmd.Parameters.AddWithValue("position", "President")
        cmd.Parameters.AddWithValue("number", agree_v1)
        cmd.Parameters.AddWithValue("studentid", login.txtid.Text)
        cmd2.Parameters.AddWithValue("name", Label7.Text)
        cmd2.Parameters.AddWithValue("position", "President")
        cmd2.Parameters.AddWithValue("number", agree_v2)
        cmd2.Parameters.AddWithValue("studentid", login.txtid.Text)
        cmd3.Parameters.AddWithValue("name", Label6.Text)
        cmd3.Parameters.AddWithValue("position", "President")
        cmd3.Parameters.AddWithValue("number", agree_v3)
        cmd3.Parameters.AddWithValue("studentid", login.txtid.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        cmd2.ExecuteNonQuery()
        cmd3.ExecuteNonQuery()
        'Organizing Secretary Session:
        Dim cmd4 As New SqlCommand("insert into result(name,number,position,studentid)values(@name,@number,@position,@studentid)", con)
        Dim cmd5 As New SqlCommand("insert into result(name,number,position,studentid)values(@name,@number,@position,@studentid)", con)
        Dim cmd6 As New SqlCommand("insert into result(name,number,position,studentid)values(@name,@number,@position,@studentid)", con)
        
        cmd4.Parameters.AddWithValue("name", Label8.Text)
        cmd4.Parameters.AddWithValue("position", "Organizing Secretary")
        cmd4.Parameters.AddWithValue("number", agree_v4)
        cmd4.Parameters.AddWithValue("studentid", login.txtid.Text)
        cmd5.Parameters.AddWithValue("name", Label4.Text)
        cmd5.Parameters.AddWithValue("position", "Organizing Secretary")
        cmd5.Parameters.AddWithValue("number", agree_v5)
        cmd5.Parameters.AddWithValue("studentid", login.txtid.Text)
        cmd6.Parameters.AddWithValue("name", Label3.Text)
        cmd6.Parameters.AddWithValue("position", "Organizing Secretary")
        cmd6.Parameters.AddWithValue("number", agree_v6)
        cmd6.Parameters.AddWithValue("studentid", login.txtid.Text)

        'con.Open()
        cmd4.ExecuteNonQuery()
        cmd5.ExecuteNonQuery()
        cmd6.ExecuteNonQuery()
        'Finance Secretary Session:
        Dim cmd7 As New SqlCommand("insert into result(name,number,position,studentid)values(@name,@number,@position,@studentid)", con)
        Dim cmd8 As New SqlCommand("insert into result(name,number,position,studentid)values(@name,@number,@position,@studentid)", con)
        Dim cmd9 As New SqlCommand("insert into result(name,number,position,studentid)values(@name,@number,@position,@studentid)", con)
       
        cmd7.Parameters.AddWithValue("name", Label12.Text)
        cmd7.Parameters.AddWithValue("position", "Finance Secretary")
        cmd7.Parameters.AddWithValue("number", agree_v7)
        cmd7.Parameters.AddWithValue("studentid", login.txtid.Text)
        cmd8.Parameters.AddWithValue("name", Label11.Text)
        cmd8.Parameters.AddWithValue("position", "Finance Secretary")
        cmd8.Parameters.AddWithValue("number", agree_v2)
        cmd8.Parameters.AddWithValue("studentid", login.txtid.Text)
        cmd9.Parameters.AddWithValue("name", Label10.Text)
        cmd9.Parameters.AddWithValue("position", "Finance Secretary")
        cmd9.Parameters.AddWithValue("number", agree_v3)
        cmd9.Parameters.AddWithValue("studentid", login.txtid.Text)
        cmd7.ExecuteNonQuery()
        cmd8.ExecuteNonQuery()
        cmd9.ExecuteNonQuery()

        MessageBox.Show("Votes Have been Recorded")
        Me.Close()
        Application.Exit()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
        Application.Exit() '

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        login.txtid.Clear()

        Me.Hide()
        login.Show()

    End Sub
End Class