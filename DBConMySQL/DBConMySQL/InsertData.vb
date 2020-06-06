Imports MySql.Data.MySqlClient

Public Class MySQLCRUD
    Dim MySQLConn As New MySqlConnection("datasource=localhost;username=root;password=")
    Dim SDA As New MySqlDataAdapter
    Dim DBDataSet As New DataTable
    Dim BSource As New BindingSource
    Dim Query As String
    Dim Commandz As MySqlCommand
    Dim Reader As MySqlDataReader
    Dim DV As New DataView(DBDataSet)

    Dim Dialog As DialogResult

    Private Sub LoadTable()
        Try
            MySQLConn.Open()
            Query = "select * from vbconn.users"
            Commandz = New MySqlCommand(Query, MySQLConn)
            SDA.SelectCommand = Commandz
            SDA.Fill(DBDataSet)
            BSource.DataSource = DBDataSet
            DGrid1.DataSource = BSource
            SDA.Update(DBDataSet)
            MySQLConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()

        End Try
    End Sub

    Public Sub ClearTable()
        Try
            BSource.DataSource = Nothing
            DBDataSet.Clear()

            DGrid1.Rows.Clear()
            DGrid1.Columns.Clear()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub ClearTXT1s()
        LBLID1.Visible = False
        LBLID2.Visible = False
        LBLID2.Text = ""
        TXTFName1.Clear()
        TXTLName1.Clear()
        DateBday1.Value = "1 - Jan - 90"
    End Sub

    Private Sub ClearTXT2s()
        TXTUserID.Clear()
        TXTFName2.Clear()
        TXTLName2.Clear()
        DateBDay2.Value = "1 - Jan - 90"
        CBXSearch.SelectedIndex = -1

        If LBLID2.Visible = False Then
            LBLID1.Visible = False
        End If
    End Sub

    Private Sub DGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGrid1.CellContentClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.DGrid1.Rows(e.RowIndex)

                LBLID1.Visible = True
                LBLID2.Visible = True

                LBLID2.Text = row.Cells("UserID").Value.ToString
                TXTFName1.Text = row.Cells("FirstName").Value.ToString
                TXTLName1.Text = row.Cells("LastName").Value.ToString
                DateBday1.Value = row.Cells("Birthday").Value.ToString
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub LLBLRefresh_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLBLRefresh.LinkClicked
        LLBLRefresh.Text = "Refresh Table"
        ClearTable()
        LoadTable()
    End Sub

    Private Sub BTNInsert_Click(sender As Object, e As EventArgs) Handles BTNInsert.Click
        Try
            MySQLConn.Open()
            Query = "insert into vbconn.users values ('', '" & TXTFName1.Text & "', '" & TXTLName1.Text & " ', '" & DateBday1.Value & "');"
            Commandz = New MySqlCommand(Query, MySQLConn)
            Reader = Commandz.ExecuteReader
            MessageBox.Show("Data Inserted Successfully")

            MySQLConn.Close()
            ClearTable()
            LoadTable()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()

        End Try
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click
        If MessageBox.Show("Do you want to clear the table as well?", "CLEAR TABLE?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) = DialogResult.Yes Then
            ClearTable()
            LLBLRefresh.Text = "Load Table"
            ClearTXT1s()

        ElseIf DialogResult.No Then
            ClearTXT1s()
        End If

    End Sub

    Private Sub BTNUpdate_Click(sender As Object, e As EventArgs) Handles BTNUpdate.Click
        Try
            MySQLConn.Open()
            Query = "update vbconn.users set FirstName = '" & TXTFName1.Text & "', LastName = '" & TXTLName1.Text & "', Birthday = '" & DateBday1.Value & "' where UserID = " & LBLID2.Text & ";"
            Commandz = New MySqlCommand(Query, MySQLConn)
            Reader = Commandz.ExecuteReader
            MessageBox.Show("Data Updated Successfully")

            MySQLConn.Close()
            ClearTable()
            LoadTable()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()

        End Try
    End Sub

    Private Sub BTNDelete_Click(sender As Object, e As EventArgs) Handles BTNDelete.Click
        Try
            MySQLConn.Open()
            Query = "delete from vbconn.users where UserID = " & LBLID2.Text & ";"
            Commandz = New MySqlCommand(Query, MySQLConn)
            Reader = Commandz.ExecuteReader
            MessageBox.Show("Data Deleted Successfully")

            MySQLConn.Close()
            ClearTable()
            LoadTable()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()

        End Try
    End Sub

    Private Sub DisableBTNs()
        DateBday1.Enabled = False
        BTNDelete.Enabled = False
        BTNInsert.Enabled = False
        BTNUpdate.Enabled = False
        BTNClear.Enabled = False

        Me.BackColor = Color.FromArgb(192, 255, 192)
    End Sub

    Private Sub EnableBTNs()
        DateBday1.Enabled = True
        BTNDelete.Enabled = True
        BTNInsert.Enabled = True
        BTNUpdate.Enabled = True
        BTNClear.Enabled = True

        Me.BackColor = SystemColors.Control
    End Sub

    Private Sub InvisibleTXT1s()
        TXTFName1.Visible = False
        TXTLName1.Visible = False
        DateBday1.Visible = False
    End Sub

    Private Sub VisibleTXT1s()
        TXTFName1.Visible = True
        TXTLName1.Visible = True
        DateBday1.Visible = True

    End Sub

    Private Sub DisableTXT2s()
        TXTFName2.Enabled = False
        TXTLName2.Enabled = False
        DateBDay2.Enabled = False

    End Sub

    Private Sub EnableTXT2s()
        TXTFName2.Enabled = True
        TXTLName2.Enabled = True
        DateBDay2.Enabled = True

    End Sub

    Private Sub VisibleTXT2s()
        TXTUserID.Visible = True
        TXTFName2.Visible = True
        TXTLName2.Visible = True
        DateBDay2.Visible = True
        LLBLExitSearch.Visible = True

        LBLSearchBy.Text = "Searching By:"
        LLBLExitSearch.Visible = True
        LBLID1.Visible = True
    End Sub

    Private Sub InvisibleTXT2s()
        TXTUserID.Visible = False
        TXTFName2.Visible = False
        TXTLName2.Visible = False
        DateBDay2.Visible = False
        LLBLExitSearch.Visible = False

        LBLSearchBy.Text = "Search By:"
        LLBLExitSearch.Visible = False
        LBLID1.Visible = False
    End Sub

    Private Sub CBXSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBXSearch.SelectedIndexChanged
        If CBXSearch.SelectedItem = "UserID" Then
            TXTUserID.Enabled = True
            TXTFName2.Enabled = False
            TXTLName2.Enabled = False
            DateBDay2.Enabled = False

            VisibleTXT2s()
            InvisibleTXT1s()
            DisableBTNs()

        ElseIf CBXSearch.SelectedItem = "First Name" Then
            TXTUserID.Enabled = False
            TXTFName2.Enabled = True
            TXTLName2.Enabled = False
            DateBDay2.Enabled = False

            VisibleTXT2s()
            InvisibleTXT1s()
            DisableBTNs()

        ElseIf CBXSearch.SelectedItem = "Last Name" Then
            TXTUserID.Enabled = False
            TXTFName2.Enabled = False
            TXTLName2.Enabled = True
            DateBDay2.Enabled = False

            VisibleTXT2s()
            InvisibleTXT1s()
            DisableBTNs()

        ElseIf CBXSearch.SelectedItem = "Birthday" Then
            TXTUserID.Enabled = False
            TXTFName2.Enabled = False
            TXTLName2.Enabled = False
            DateBDay2.Enabled = True

            VisibleTXT2s()
            InvisibleTXT1s()
            DisableBTNs()

        End If
    End Sub

    Private Sub TXTUserID_TextChanged(sender As Object, e As EventArgs) Handles TXTUserID.TextChanged
        Try
            MySQLConn.Open()
            ClearTable()
            Query = "select * from vbconn.users where UserID like '%" & TXTUserID.Text & "%';"
            Commandz = New MySqlCommand(Query, MySQLConn)
            SDA.SelectCommand = Commandz
            SDA.Fill(DBDataSet)
            BSource.DataSource = DBDataSet
            DGrid1.DataSource = BSource
            SDA.Update(DBDataSet)
            MySQLConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()

        End Try

    End Sub

    Private Sub TXTFName2_TextChanged(sender As Object, e As EventArgs) Handles TXTFName2.TextChanged
        DV.RowFilter = String.Format("FirstName Like '%{0}%'", TXTFName2.Text)
        DGrid1.DataSource = DV

    End Sub

    Private Sub TXTLName2_TextChanged(sender As Object, e As EventArgs) Handles TXTLName2.TextChanged
        DV.RowFilter = String.Format("LastName Like '%{0}%'", TXTLName2.Text)
        DGrid1.DataSource = DV

    End Sub

    Private Sub DateBday2_ValueChanged(sender As Object, e As EventArgs) Handles DateBDay2.ValueChanged
        Try
            If DateBDay2.Value = "01-Jan-90" Then

            Else
                MySQLConn.Open()
                ClearTable()
                Query = "select * from vbconn.users where Birthday = '" & DateBDay2.Value & "';"
                Commandz = New MySqlCommand(Query, MySQLConn)
                SDA.SelectCommand = Commandz
                SDA.Fill(DBDataSet)
                BSource.DataSource = DBDataSet
                DGrid1.DataSource = BSource
                SDA.Update(DBDataSet)
                MySQLConn.Close()


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySQLConn.Dispose()

        End Try

    End Sub

    Private Sub LLBLExitSearch_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLBLExitSearch.LinkClicked
        DisableTXT2s()
        InvisibleTXT2s()
        VisibleTXT1s()
        EnableBTNs()
        ClearTXT2s()

    End Sub

    Private Sub MySQLCRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadTable()

        Catch ex As Exception
            MessageBox.Show("The Database is Offline.", "MYSQL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally
            MySQLConn.Dispose()

        End Try

    End Sub

    Private Sub LLBLLogout_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLBLLogout.LinkClicked
        If MessageBox.Show("All your changes have been saved.", "GO BACK", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
            CheckConn.Show()
            Me.Hide()

        End If
    End Sub
End Class