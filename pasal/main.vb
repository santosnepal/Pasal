Imports System.Data.OleDb
Public Class main
    Dim myconnstring As String = "provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Environment.CurrentDirectory & "\digitalpasal.accdb"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim my As New OleDbConnection(myconnstring)
        my.Open()
        TextBox7.Clear()
        TextBox10.Clear()
        ListView4.Items.Clear()
        Dim mydelete As New OleDbCommand("DELETE * FROM TEMP", my)
        mydelete.ExecuteNonQuery()
        my.Close()


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub Sales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myconnection As New OleDbConnection(myconnstring)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("INSERT INTO stock(Product,expiry,price,Brand,quantity,type) values(?,?,?,?,?,?) ", myconnection)
        mycommand.Parameters.AddWithValue("@Product", TextBox1.Text)
        mycommand.Parameters.AddWithValue("@expiry", DateTimePicker1.Text)
        mycommand.Parameters.AddWithValue("@Price", TextBox3.Text)
        mycommand.Parameters.AddWithValue("@brand", TextBox2.Text)
        mycommand.Parameters.AddWithValue("@quantity", TextBox5.Text)
        mycommand.Parameters.AddWithValue("@Type", TextBox4.Text)
        'Dim delete As New OleDbCommand("DELETE FROM stock WHERE ID=1", myconnection)
        Try
            mycommand.ExecuteNonQuery()
            mycommand.Dispose()
            'delete.ExecuteNonQuery()
            myconnection.Close()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            MessageBox.Show("sucess")

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        upd.Show()

    End Sub

    

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox9.Clear()
        ListView4.Items.Clear()
        Dim myconnection As New OleDbConnection(myconnstring)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM stock Where id LIKE @busno", myconnection)
        mycommand.Parameters.AddWithValue("@busno", TextBox8.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()



        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetInt32(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetString(3))
            newlistviewitem.SubItems.Add(myreader.GetString(4))
            newlistviewitem.SubItems.Add(myreader.GetString(5))
            newlistviewitem.SubItems.Add(myreader.GetString(6))
            ListView1.Items.Add(newlistviewitem)
        End While
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox8.Clear()
        ListView1.Items.Clear()
        Dim myconnection As New OleDbConnection(myconnstring)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM stock Where product LIKE @busno", myconnection)
        mycommand.Parameters.AddWithValue("@busno", TextBox9.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()



        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetInt32(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetString(3))
            newlistviewitem.SubItems.Add(myreader.GetString(4))
            newlistviewitem.SubItems.Add(myreader.GetString(5))
            newlistviewitem.SubItems.Add(myreader.GetString(6))
            ListView1.Items.Add(newlistviewitem)


        End While

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'ListView3.Items.Clear()
        ListView2.Hide()
        'ListView3.Show()

        'ListView2.columheader10.Text = "Sales Date"
        Dim myconnection As New OleDbConnection(myconnstring)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM sold ", myconnection)
        mycommand.Parameters.AddWithValue("@busno", TextBox8.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()



        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetInt32(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetString(3))
            newlistviewitem.SubItems.Add(myreader.GetString(4))
            newlistviewitem.SubItems.Add(myreader.GetString(5))
            newlistviewitem.SubItems.Add(myreader.GetString(6))
            'ListView3.Items.Add(newlistviewitem)
        End While

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        ListView2.Items.Clear()
        'ListView3.Hide()
        ListView2.Show()
        Dim myconnection As New OleDbConnection(myconnstring)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM stock ", myconnection)
        mycommand.Parameters.AddWithValue("@busno", TextBox8.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()



        While myreader.Read
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetInt32(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetString(3))
            newlistviewitem.SubItems.Add(myreader.GetString(4))
            newlistviewitem.SubItems.Add(myreader.GetString(5))
            newlistviewitem.SubItems.Add(myreader.GetString(6))
            ListView2.Items.Add(newlistviewitem)
        End While

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim my As New OleDbConnection(myconnstring)
        my.Open()
        TextBox7.Clear()
        TextBox10.Clear()
        ListView4.Items.Clear()
        Dim mydelete As New OleDbCommand("DELETE * FROM TEMP", my)
        mydelete.ExecuteNonQuery()
        my.Close()
    End Sub

    Private Sub ListView3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        'TextBox7.Clear()
       Dim myconnection As New OleDbConnection(myconnstring)
        myconnection.Open()
        Dim mycommand As New OleDbCommand("Select * FROM stock WHERE ID= @bus  ", myconnection)
        'Dim mycopy As New OleDbCommand(" INSERT INTO sold(id,product,brand,price,quantity,expiry,type) values(?,?,?,?,?,?,?)", myconnection)
        'Dim pk As Integer = TextBox7.Text
        Dim mycopy As New OleDbCommand("INSERT INTO temp (id,product,brand,price,quantity,expiry,type) SELECT * FROM Stock WHERE ID = @pk", myconnection)
        mycopy.Parameters.AddWithValue("@pk", TextBox7.Text)
        mycopy.ExecuteNonQuery()

        mycommand.Parameters.AddWithValue("@bus", TextBox7.Text)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()
        While myreader.Read
            'mycopy.Parameters.AddWithValue("@ID", myreader.GetInt32(0))
            Dim newlistviewitem As New ListViewItem
            newlistviewitem.Text = myreader.GetInt32(0)
            newlistviewitem.SubItems.Add(myreader.GetString(1))
            newlistviewitem.SubItems.Add(myreader.GetString(2))
            newlistviewitem.SubItems.Add(myreader.GetString(3))
            newlistviewitem.SubItems.Add(myreader.GetString(4))
            newlistviewitem.SubItems.Add(myreader.GetString(5))
            newlistviewitem.SubItems.Add(myreader.GetString(6))
            ListView4.Items.Add(newlistviewitem)
        End While
    End Sub

    Private Sub ListView4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView4.SelectedIndexChanged

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim myconnection As New OleDbConnection(myconnstring)
        myconnection.Open()
        Dim str As String
        Dim top As Integer
        Dim pop As Integer
        Dim tip As Integer
        'str = "update [STOCK] set [quantity]='" & tip & "' WHERE [ID]=" & TextBox7.Text & " "
        'Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        Dim mycommand As New OleDbCommand("Select * FROM stock WHERE [ID] =" & TextBox7.Text & "", myconnection)
        Dim myreader As OleDbDataReader = mycommand.ExecuteReader()
        While myreader.Read
            Top = myreader.GetString(5)
            Integer.Parse(Top)
        End While

        pop = CInt(TextBox10.Text)
        tip = top - pop
        TextBox11.Text = tip
        str = "update [STOCK] set [quantity]='" & tip & "' WHERE [ID]=" & TextBox7.Text & " "
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        Try
            MsgBox(tip)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            'mycommand.ExecuteNonQuery()
            'mycommand.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim myconnection As New OleDbConnection(myconnstring)
        myconnection.Open()
        Dim sdet As New OleDbCommand("DELETE * FROM STOCK WHERE id=@al", myconnection)
        sdet.Parameters.AddWithValue("&al", TextBox6.Text)
        sdet.ExecuteNonQuery()
    End Sub
End Class