<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MySQLCRUD
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MySQLCRUD))
        Me.LBLID1 = New System.Windows.Forms.Label()
        Me.LBLLName = New System.Windows.Forms.Label()
        Me.LBLFName = New System.Windows.Forms.Label()
        Me.LBLBday = New System.Windows.Forms.Label()
        Me.LBLID2 = New System.Windows.Forms.Label()
        Me.TXTFName1 = New System.Windows.Forms.TextBox()
        Me.TXTLName1 = New System.Windows.Forms.TextBox()
        Me.DGrid1 = New System.Windows.Forms.DataGridView()
        Me.BTNDelete = New System.Windows.Forms.Button()
        Me.BTNInsert = New System.Windows.Forms.Button()
        Me.BTNUpdate = New System.Windows.Forms.Button()
        Me.BTNClear = New System.Windows.Forms.Button()
        Me.LLBLRefresh = New System.Windows.Forms.LinkLabel()
        Me.DateBday1 = New System.Windows.Forms.DateTimePicker()
        Me.CBXSearch = New System.Windows.Forms.ComboBox()
        Me.LBLSearchBy = New System.Windows.Forms.Label()
        Me.TXTUserID = New System.Windows.Forms.TextBox()
        Me.LLBLExitSearch = New System.Windows.Forms.LinkLabel()
        Me.TXTFName2 = New System.Windows.Forms.TextBox()
        Me.TXTLName2 = New System.Windows.Forms.TextBox()
        Me.DateBDay2 = New System.Windows.Forms.DateTimePicker()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.LLBLLogout = New System.Windows.Forms.LinkLabel()
        CType(Me.DGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBLID1
        '
        Me.LBLID1.AutoSize = True
        Me.LBLID1.Location = New System.Drawing.Point(12, 9)
        Me.LBLID1.Name = "LBLID1"
        Me.LBLID1.Size = New System.Drawing.Size(57, 19)
        Me.LBLID1.TabIndex = 0
        Me.LBLID1.Text = "UserID:"
        Me.LBLID1.Visible = False
        '
        'LBLLName
        '
        Me.LBLLName.AutoSize = True
        Me.LBLLName.Location = New System.Drawing.Point(12, 92)
        Me.LBLLName.Name = "LBLLName"
        Me.LBLLName.Size = New System.Drawing.Size(75, 19)
        Me.LBLLName.TabIndex = 1
        Me.LBLLName.Text = "LastName:"
        '
        'LBLFName
        '
        Me.LBLFName.AutoSize = True
        Me.LBLFName.Location = New System.Drawing.Point(12, 50)
        Me.LBLFName.Name = "LBLFName"
        Me.LBLFName.Size = New System.Drawing.Size(76, 19)
        Me.LBLFName.TabIndex = 2
        Me.LBLFName.Text = "FirstName:"
        '
        'LBLBday
        '
        Me.LBLBday.AutoSize = True
        Me.LBLBday.Location = New System.Drawing.Point(12, 138)
        Me.LBLBday.Name = "LBLBday"
        Me.LBLBday.Size = New System.Drawing.Size(63, 19)
        Me.LBLBday.TabIndex = 3
        Me.LBLBday.Text = "Birthday:"
        '
        'LBLID2
        '
        Me.LBLID2.AutoSize = True
        Me.LBLID2.Location = New System.Drawing.Point(111, 9)
        Me.LBLID2.Name = "LBLID2"
        Me.LBLID2.Size = New System.Drawing.Size(25, 19)
        Me.LBLID2.TabIndex = 4
        Me.LBLID2.Text = "ID"
        Me.LBLID2.Visible = False
        '
        'TXTFName1
        '
        Me.TXTFName1.Location = New System.Drawing.Point(94, 43)
        Me.TXTFName1.Name = "TXTFName1"
        Me.TXTFName1.Size = New System.Drawing.Size(152, 26)
        Me.TXTFName1.TabIndex = 1
        '
        'TXTLName1
        '
        Me.TXTLName1.Location = New System.Drawing.Point(94, 85)
        Me.TXTLName1.Name = "TXTLName1"
        Me.TXTLName1.Size = New System.Drawing.Size(152, 26)
        Me.TXTLName1.TabIndex = 2
        '
        'DGrid1
        '
        Me.DGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGrid1.Location = New System.Drawing.Point(252, 85)
        Me.DGrid1.Name = "DGrid1"
        Me.DGrid1.Size = New System.Drawing.Size(465, 211)
        Me.DGrid1.TabIndex = 8
        '
        'BTNDelete
        '
        Me.BTNDelete.Location = New System.Drawing.Point(16, 250)
        Me.BTNDelete.Name = "BTNDelete"
        Me.BTNDelete.Size = New System.Drawing.Size(75, 41)
        Me.BTNDelete.TabIndex = 6
        Me.BTNDelete.Text = "Delete"
        Me.BTNDelete.UseVisualStyleBackColor = True
        '
        'BTNInsert
        '
        Me.BTNInsert.Location = New System.Drawing.Point(16, 187)
        Me.BTNInsert.Name = "BTNInsert"
        Me.BTNInsert.Size = New System.Drawing.Size(75, 40)
        Me.BTNInsert.TabIndex = 4
        Me.BTNInsert.Text = "Insert"
        Me.BTNInsert.UseVisualStyleBackColor = True
        '
        'BTNUpdate
        '
        Me.BTNUpdate.Location = New System.Drawing.Point(171, 187)
        Me.BTNUpdate.Name = "BTNUpdate"
        Me.BTNUpdate.Size = New System.Drawing.Size(75, 40)
        Me.BTNUpdate.TabIndex = 5
        Me.BTNUpdate.Text = "Update"
        Me.BTNUpdate.UseVisualStyleBackColor = True
        '
        'BTNClear
        '
        Me.BTNClear.Location = New System.Drawing.Point(171, 250)
        Me.BTNClear.Name = "BTNClear"
        Me.BTNClear.Size = New System.Drawing.Size(75, 41)
        Me.BTNClear.TabIndex = 7
        Me.BTNClear.Text = "Clear All"
        Me.BTNClear.UseVisualStyleBackColor = True
        '
        'LLBLRefresh
        '
        Me.LLBLRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LLBLRefresh.AutoSize = True
        Me.LLBLRefresh.Location = New System.Drawing.Point(625, 63)
        Me.LLBLRefresh.Name = "LLBLRefresh"
        Me.LLBLRefresh.Size = New System.Drawing.Size(92, 19)
        Me.LLBLRefresh.TabIndex = 13
        Me.LLBLRefresh.TabStop = True
        Me.LLBLRefresh.Text = "Refresh Table"
        '
        'DateBday1
        '
        Me.DateBday1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateBday1.Location = New System.Drawing.Point(94, 138)
        Me.DateBday1.Name = "DateBday1"
        Me.DateBday1.Size = New System.Drawing.Size(152, 26)
        Me.DateBday1.TabIndex = 3
        Me.DateBday1.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
        '
        'CBXSearch
        '
        Me.CBXSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBXSearch.FormattingEnabled = True
        Me.CBXSearch.Items.AddRange(New Object() {"UserID", "First Name", "Last Name", "Birthday"})
        Me.CBXSearch.Location = New System.Drawing.Point(378, 5)
        Me.CBXSearch.Name = "CBXSearch"
        Me.CBXSearch.Size = New System.Drawing.Size(112, 27)
        Me.CBXSearch.TabIndex = 14
        '
        'LBLSearchBy
        '
        Me.LBLSearchBy.AutoSize = True
        Me.LBLSearchBy.Location = New System.Drawing.Point(287, 9)
        Me.LBLSearchBy.Name = "LBLSearchBy"
        Me.LBLSearchBy.Size = New System.Drawing.Size(75, 19)
        Me.LBLSearchBy.TabIndex = 15
        Me.LBLSearchBy.Text = "Search By:"
        '
        'TXTUserID
        '
        Me.TXTUserID.Enabled = False
        Me.TXTUserID.Location = New System.Drawing.Point(94, 6)
        Me.TXTUserID.Name = "TXTUserID"
        Me.TXTUserID.Size = New System.Drawing.Size(152, 26)
        Me.TXTUserID.TabIndex = 19
        Me.TXTUserID.Visible = False
        '
        'LLBLExitSearch
        '
        Me.LLBLExitSearch.AutoSize = True
        Me.LLBLExitSearch.LinkColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LLBLExitSearch.Location = New System.Drawing.Point(254, 63)
        Me.LLBLExitSearch.Name = "LLBLExitSearch"
        Me.LLBLExitSearch.Size = New System.Drawing.Size(108, 19)
        Me.LLBLExitSearch.TabIndex = 20
        Me.LLBLExitSearch.TabStop = True
        Me.LLBLExitSearch.Text = "EXIT SEARCH"
        Me.LLBLExitSearch.Visible = False
        '
        'TXTFName2
        '
        Me.TXTFName2.Enabled = False
        Me.TXTFName2.Location = New System.Drawing.Point(94, 43)
        Me.TXTFName2.Name = "TXTFName2"
        Me.TXTFName2.Size = New System.Drawing.Size(152, 26)
        Me.TXTFName2.TabIndex = 21
        Me.TXTFName2.Visible = False
        '
        'TXTLName2
        '
        Me.TXTLName2.Enabled = False
        Me.TXTLName2.Location = New System.Drawing.Point(94, 85)
        Me.TXTLName2.Name = "TXTLName2"
        Me.TXTLName2.Size = New System.Drawing.Size(152, 26)
        Me.TXTLName2.TabIndex = 22
        Me.TXTLName2.Visible = False
        '
        'DateBDay2
        '
        Me.DateBDay2.Enabled = False
        Me.DateBDay2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateBDay2.Location = New System.Drawing.Point(94, 138)
        Me.DateBDay2.Name = "DateBDay2"
        Me.DateBDay2.Size = New System.Drawing.Size(152, 26)
        Me.DateBDay2.TabIndex = 23
        Me.DateBDay2.Value = New Date(1990, 1, 1, 0, 0, 0, 0)
        Me.DateBDay2.Visible = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'LLBLLogout
        '
        Me.LLBLLogout.AutoSize = True
        Me.LLBLLogout.Location = New System.Drawing.Point(625, 6)
        Me.LLBLLogout.Name = "LLBLLogout"
        Me.LLBLLogout.Size = New System.Drawing.Size(52, 19)
        Me.LLBLLogout.TabIndex = 24
        Me.LLBLLogout.TabStop = True
        Me.LLBLLogout.Text = "Logout"
        '
        'MySQLCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(729, 334)
        Me.Controls.Add(Me.LLBLLogout)
        Me.Controls.Add(Me.DateBDay2)
        Me.Controls.Add(Me.TXTLName2)
        Me.Controls.Add(Me.TXTFName2)
        Me.Controls.Add(Me.LLBLExitSearch)
        Me.Controls.Add(Me.TXTUserID)
        Me.Controls.Add(Me.LBLSearchBy)
        Me.Controls.Add(Me.CBXSearch)
        Me.Controls.Add(Me.DateBday1)
        Me.Controls.Add(Me.LLBLRefresh)
        Me.Controls.Add(Me.BTNClear)
        Me.Controls.Add(Me.BTNUpdate)
        Me.Controls.Add(Me.BTNInsert)
        Me.Controls.Add(Me.BTNDelete)
        Me.Controls.Add(Me.DGrid1)
        Me.Controls.Add(Me.TXTLName1)
        Me.Controls.Add(Me.TXTFName1)
        Me.Controls.Add(Me.LBLID2)
        Me.Controls.Add(Me.LBLBday)
        Me.Controls.Add(Me.LBLFName)
        Me.Controls.Add(Me.LBLLName)
        Me.Controls.Add(Me.LBLID1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MySQLCRUD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MySQLCRUD"
        CType(Me.DGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLID1 As Label
    Friend WithEvents LBLLName As Label
    Friend WithEvents LBLFName As Label
    Friend WithEvents LBLBday As Label
    Friend WithEvents LBLID2 As Label
    Friend WithEvents TXTFName1 As TextBox
    Friend WithEvents TXTLName1 As TextBox
    Friend WithEvents DGrid1 As DataGridView
    Friend WithEvents BTNDelete As Button
    Friend WithEvents BTNInsert As Button
    Friend WithEvents BTNUpdate As Button
    Friend WithEvents BTNClear As Button
    Friend WithEvents LLBLRefresh As LinkLabel
    Friend WithEvents DateBday1 As DateTimePicker
    Friend WithEvents CBXSearch As ComboBox
    Friend WithEvents LBLSearchBy As Label
    Friend WithEvents TXTUserID As TextBox
    Friend WithEvents LLBLExitSearch As LinkLabel
    Friend WithEvents TXTFName2 As TextBox
    Friend WithEvents TXTLName2 As TextBox
    Friend WithEvents DateBDay2 As DateTimePicker
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents LLBLLogout As LinkLabel
End Class
