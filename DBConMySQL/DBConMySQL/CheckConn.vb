Imports MySql.Data.MySqlClient

Public Class CheckConn
    Dim MySQLConn As New MySqlConnection("datasource=localhost;username=root;password=")



    Private Sub BTNConnect_Click(sender As Object, e As EventArgs) Handles BTNConnect.Click
        Try
            MySQLConn.Open()
            If MessageBox.Show("MySQL Connected!", "CONNECTED", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) = DialogResult.OK Then
                Dim NextPage As New MySQLCRUD
                NextPage.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BTNDisconnect_Click(sender As Object, e As EventArgs) Handles BTNDisconnect.Click
        Try
            MySQLConn.Close()
            MessageBox.Show("MySQL Disconnected!", "DISCONNECTED", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub CheckConn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
