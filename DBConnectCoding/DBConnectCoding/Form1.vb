Public Class Form1
    Dim dbProvider As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
    Dim MyDocumentsFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
    Dim TheDatabase As String = "C:\Users\ray njire\Downloads\AddressBook\AddressBook.mdb"
    Dim FullDatabasePath As String = MyDocumentsFolder & TheDatabase
    Dim dbSource As String = "Data Source = " & FullDatabasePath

    Dim con As New OleDb.OleDbConnection
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim inc As Integer
    Dim MaxRows As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbProvider & dbSource

        con.Open()

        sql = "Select * from tblContacts"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "AddressBook")
        da.Fill(ds, "AddressBook")
        da.Fill(ds, "Bacon Sandwich")
        MessageBox.Show("Database is now open")

        MaxRows = ds.Tables("AddressBook").Rows.Count
        inc = -1

    End Sub

    Private Sub NavigateRecords()
        LBLID.Visible = True
        LBLID2.Visible = True
        LBLID2.Text = ds.Tables("AddressBook").Rows(inc).Item(0)
        TXTFName.Text = ds.Tables("AddressBook").Rows(inc).Item(1)
        TXTSName.Text = ds.Tables("AddressBook").Rows(inc).Item(2)
        TXTAddress1.Text = ds.Tables("AddressBook").Rows(inc).Item(3)
        TXTAddress2.Text = ds.Tables("AddressBook").Rows(inc).Item(4)
        TXTAddress3.Text = ds.Tables("AddressBook").Rows(inc).Item(5)
        TXTPost.Text = ds.Tables("AddressBook").Rows(inc).Item(6)
        TXTPhone.Text = ds.Tables("AddressBook").Rows(inc).Item(7)
        TXTEmail.Text = ds.Tables("AddressBook").Rows(inc).Item(8)
        RTXTNotes.Text = ds.Tables("AddressBook").Rows(inc).Item(9)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BTNNext.Click
        If inc <> MaxRows - 1 Then

            inc = inc + 1

            NavigateRecords()

        Else

            MessageBox.Show("No More Rows")

        End If

        BTNAdd.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTNPrev.Click
        If inc > 0 Then

            inc = inc - 1

            NavigateRecords()

        Else

            MessageBox.Show("First Record")

        End If

        BTNAdd.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTNLast.Click
        If inc <> MaxRows - 1 Then

            inc = MaxRows - 1

            NavigateRecords()

        End If

        BTNAdd.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BTNFirst.Click
        If inc <> 0 Then

            inc = 0

            NavigateRecords()
        End If

        BTNAdd.Enabled = False
    End Sub

    Private Sub BTNUpdate_Click(sender As Object, e As EventArgs) Handles BTNUpdate.Click
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        ds.Tables("AddressBook").Rows(inc).Item(1) = TXTFName.Text
        ds.Tables("AddressBook").Rows(inc).Item(2) = TXTSName.Text
        ds.Tables("AddressBook").Rows(inc).Item(3) = TXTAddress1.Text
        ds.Tables("AddressBook").Rows(inc).Item(4) = TXTAddress2.Text
        ds.Tables("AddressBook").Rows(inc).Item(5) = TXTAddress3.Text
        ds.Tables("AddressBook").Rows(inc).Item(6) = TXTPost.Text
        ds.Tables("AddressBook").Rows(inc).Item(7) = TXTPhone.Text
        ds.Tables("AddressBook").Rows(inc).Item(8) = TXTEmail.Text
        ds.Tables("AddressBook").Rows(inc).Item(9) = RTXTNotes.Text
        da.Update(ds, "AddressBook")

        MessageBox.Show("Data updated")
    End Sub

    Private Sub BTNAdd_Click(sender As Object, e As EventArgs) Handles BTNAdd.Click
        If MessageBox.Show("Do you really want to Add this Record?", "ADD NEW RECORD", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MessageBox.Show("Operation Cancelled")
            Exit Sub

        End If

        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRow As DataRow

        dsNewRow = ds.Tables("AddressBook").NewRow()

        dsNewRow.Item("FirstName") = TXTFName.Text
        dsNewRow.Item("Surname") = TXTSName.Text
        dsNewRow.Item("Address1") = TXTAddress1.Text
        dsNewRow.Item("Address2") = TXTAddress2.Text
        dsNewRow.Item("Address3") = TXTAddress3.Text
        dsNewRow.Item("PostCode") = TXTPost.Text
        dsNewRow.Item("Phone") = TXTPhone.Text
        dsNewRow.Item("Email") = TXTEmail.Text
        dsNewRow.Item("Notes") = RTXTNotes.Text

        ds.Tables("AddressBook").Rows.Add(dsNewRow)

        da.Update(ds, "AddressBook")

        MessageBox.Show("New Record added to the Database")

        BTNAdd.Enabled = True
        BTNUpdate.Enabled = True
        BTNDelete.Enabled = True

        LBLID.Visible = False
        LBLID2.Visible = False
        TXTFName.Clear()
        TXTSName.Clear()
        TXTAddress1.Clear()
        TXTAddress2.Clear()
        TXTAddress3.Clear()
        TXTEmail.Clear()
        TXTPhone.Clear()
        TXTPost.Clear()
        RTXTNotes.Clear()

        BTNAdd.Enabled = True
        BTNUpdate.Enabled = True
        BTNDelete.Enabled = True
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        LBLID.Visible = False
        LBLID2.Visible = False
        TXTFName.Clear()
        TXTSName.Clear()
        TXTAddress1.Clear()
        TXTAddress2.Clear()
        TXTAddress3.Clear()
        TXTEmail.Clear()
        TXTPhone.Clear()
        TXTPost.Clear()
        RTXTNotes.Clear()

        BTNAdd.Enabled = True
        BTNUpdate.Enabled = True
        BTNDelete.Enabled = True
    End Sub

    Private Sub BTNCommit_Click(sender As Object, e As EventArgs)
        If inc <> -1 Then

            Dim cb As New OleDb.OleDbCommandBuilder(da)
            Dim dsNewRow As DataRow

            dsNewRow = ds.Tables("AddressBook").NewRow()

            dsNewRow.Item("FirstName") = TXTFName.Text
            dsNewRow.Item("Surname") = TXTSName.Text
            dsNewRow.Item("Address1") = TXTAddress1.Text
            dsNewRow.Item("Address2") = TXTAddress2.Text
            dsNewRow.Item("Address3") = TXTAddress3.Text
            dsNewRow.Item("PostCode") = TXTPost.Text
            dsNewRow.Item("Phone") = TXTPhone.Text
            dsNewRow.Item("Email") = TXTEmail.Text
            dsNewRow.Item("Notes") = RTXTNotes.Text

            ds.Tables("AddressBook").Rows.Add(dsNewRow)

            da.Update(ds, "AddressBook")

            MessageBox.Show("New Record added to the Database")

            BTNAdd.Enabled = True
            BTNUpdate.Enabled = True
            BTNDelete.Enabled = True
        End If
    End Sub

    Private Sub BTNDelete_Click(sender As Object, e As EventArgs) Handles BTNDelete.Click
        If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

            MessageBox.Show("Operation Cancelled")
            Exit Sub

        End If
        Dim cb As New OleDb.OleDbCommandBuilder(da)

        ds.Tables("AddressBook").Rows(inc).Delete()
        MaxRows = MaxRows - 1

        inc = 0
        da.Update(ds, "AddressBook")
        NavigateRecords()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        con.Close()

        MessageBox.Show("Database is now Closed")

    End Sub
End Class

