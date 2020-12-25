Imports System.Data.OleDb
Public Class upd
    Dim myconnstring As String = "provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Environment.CurrentDirectory & "\digitalpasal.accdb"


    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myconnection As New OleDbConnection(myconnstring)
        myconnection.Open()
        'Dim mycommand As New OleDbCommand("UPDATE [stock] SET [product]='"textbox5.text&"',[Brand=@bustype],[Type=@comapanyname],[price=@totalseat],[quantity=@q],[expiry=@ex] WHERE [ID = @pk]", myconnection)
        'mycommand.Parameters.AddWithValue("@busno", 8)
        'Dim mycommand As New OleDbCommand("UPDATE stock SET (product,Brand,Type,price,quantity,expiry) WHERE ID=@pk", myconnection)
        'Dim mycommand As New OleDbCommand("INSERT INTO stock (product,Brand,Type,price,Quantity,Expiry) values (?,?,?,?,?,?) WHERE ID=@pk", myconnection)
        Dim STR As String
        STR = "update [STOCK] set [PRODUCT]='" & TextBox5.Text & "',[brand]='" & TextBox4.Text & "',[Type]='" & TextBox1.Text & "',[price]='" & TextBox2.Text & "',[expiry]='" & DateTimePicker1.Text & "',[quantity]='" & TextBox3.Text & "' WHERE [ID]=" & TextBox6.Text & " "
        Dim cmd As OleDbCommand = New OleDbCommand(STR, myconnection)
        'mycommand.Parameters.AddWithValue("@pk", TextBox6.Text)
        'mycommand.Parameters.AddWithValue("@pd", TextBox5.Text)
        'mycommand.Parameters.AddWithValue("@bustype", TextBox4.Text)
        'mycommand.Parameters.AddWithValue("@companyname", TextBox1.Text)
        'mycommand.Parameters.AddWithValue("@totalseat", TextBox2.Text)
        'mycommand.Parameters.AddWithValue("@q", TextBox3.Text)
        'mycommand.Parameters.AddWithValue("@ex", DateTimePicker1.Text)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'mycommand.ExecuteNonQuery()
            myconnection.Close()
            MessageBox.Show("Updated!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub upd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class