<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TXTFName = New System.Windows.Forms.TextBox()
        Me.TXTSName = New System.Windows.Forms.TextBox()
        Me.LBLFName = New System.Windows.Forms.Label()
        Me.LBLSName = New System.Windows.Forms.Label()
        Me.BTNPrev = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LBLID2 = New System.Windows.Forms.Label()
        Me.BTNNext = New System.Windows.Forms.Button()
        Me.BTNClear = New System.Windows.Forms.Button()
        Me.BTNFirst = New System.Windows.Forms.Button()
        Me.BTNLast = New System.Windows.Forms.Button()
        Me.BTNUpdate = New System.Windows.Forms.Button()
        Me.BTNDelete = New System.Windows.Forms.Button()
        Me.BTNAdd = New System.Windows.Forms.Button()
        Me.LBLEmail = New System.Windows.Forms.Label()
        Me.TXTEmail = New System.Windows.Forms.TextBox()
        Me.LBLPhone = New System.Windows.Forms.Label()
        Me.TXTPhone = New System.Windows.Forms.TextBox()
        Me.RTXTNotes = New System.Windows.Forms.RichTextBox()
        Me.LBLNotes = New System.Windows.Forms.Label()
        Me.LBLID = New System.Windows.Forms.Label()
        Me.LBLAddress3 = New System.Windows.Forms.Label()
        Me.TXTAddress3 = New System.Windows.Forms.TextBox()
        Me.LBLPost = New System.Windows.Forms.Label()
        Me.TXTPost = New System.Windows.Forms.TextBox()
        Me.LBLAddress1 = New System.Windows.Forms.Label()
        Me.TXTAddress1 = New System.Windows.Forms.TextBox()
        Me.LBLAddress2 = New System.Windows.Forms.Label()
        Me.TXTAddress2 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTFName
        '
        Me.TXTFName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFName.Location = New System.Drawing.Point(118, 48)
        Me.TXTFName.Name = "TXTFName"
        Me.TXTFName.Size = New System.Drawing.Size(134, 26)
        Me.TXTFName.TabIndex = 1
        '
        'TXTSName
        '
        Me.TXTSName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSName.Location = New System.Drawing.Point(118, 80)
        Me.TXTSName.Name = "TXTSName"
        Me.TXTSName.Size = New System.Drawing.Size(134, 26)
        Me.TXTSName.TabIndex = 2
        '
        'LBLFName
        '
        Me.LBLFName.AutoSize = True
        Me.LBLFName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFName.Location = New System.Drawing.Point(20, 51)
        Me.LBLFName.Name = "LBLFName"
        Me.LBLFName.Size = New System.Drawing.Size(80, 19)
        Me.LBLFName.TabIndex = 3
        Me.LBLFName.Text = "First Name:"
        '
        'LBLSName
        '
        Me.LBLSName.AutoSize = True
        Me.LBLSName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSName.Location = New System.Drawing.Point(20, 83)
        Me.LBLSName.Name = "LBLSName"
        Me.LBLSName.Size = New System.Drawing.Size(65, 19)
        Me.LBLSName.TabIndex = 4
        Me.LBLSName.Text = "Surname:"
        '
        'BTNPrev
        '
        Me.BTNPrev.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.BTNPrev.Location = New System.Drawing.Point(104, 331)
        Me.BTNPrev.Name = "BTNPrev"
        Me.BTNPrev.Size = New System.Drawing.Size(75, 32)
        Me.BTNPrev.TabIndex = 14
        Me.BTNPrev.Text = "<"
        Me.BTNPrev.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LBLID2)
        Me.Panel1.Controls.Add(Me.BTNPrev)
        Me.Panel1.Controls.Add(Me.BTNNext)
        Me.Panel1.Controls.Add(Me.BTNClear)
        Me.Panel1.Controls.Add(Me.BTNFirst)
        Me.Panel1.Controls.Add(Me.BTNLast)
        Me.Panel1.Controls.Add(Me.BTNUpdate)
        Me.Panel1.Controls.Add(Me.BTNDelete)
        Me.Panel1.Controls.Add(Me.BTNAdd)
        Me.Panel1.Controls.Add(Me.LBLEmail)
        Me.Panel1.Controls.Add(Me.TXTEmail)
        Me.Panel1.Controls.Add(Me.LBLPhone)
        Me.Panel1.Controls.Add(Me.TXTPhone)
        Me.Panel1.Controls.Add(Me.RTXTNotes)
        Me.Panel1.Controls.Add(Me.LBLNotes)
        Me.Panel1.Controls.Add(Me.LBLID)
        Me.Panel1.Controls.Add(Me.LBLAddress3)
        Me.Panel1.Controls.Add(Me.TXTAddress3)
        Me.Panel1.Controls.Add(Me.LBLPost)
        Me.Panel1.Controls.Add(Me.TXTPost)
        Me.Panel1.Controls.Add(Me.LBLAddress1)
        Me.Panel1.Controls.Add(Me.TXTAddress1)
        Me.Panel1.Controls.Add(Me.LBLAddress2)
        Me.Panel1.Controls.Add(Me.TXTAddress2)
        Me.Panel1.Controls.Add(Me.LBLFName)
        Me.Panel1.Controls.Add(Me.TXTFName)
        Me.Panel1.Controls.Add(Me.LBLSName)
        Me.Panel1.Controls.Add(Me.TXTSName)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(611, 382)
        Me.Panel1.TabIndex = 22
        '
        'LBLID2
        '
        Me.LBLID2.AutoSize = True
        Me.LBLID2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLID2.Location = New System.Drawing.Point(114, 16)
        Me.LBLID2.Name = "LBLID2"
        Me.LBLID2.Size = New System.Drawing.Size(57, 19)
        Me.LBLID2.TabIndex = 26
        Me.LBLID2.Text = "ID NO."
        Me.LBLID2.Visible = False
        '
        'BTNNext
        '
        Me.BTNNext.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.BTNNext.Location = New System.Drawing.Point(193, 331)
        Me.BTNNext.Name = "BTNNext"
        Me.BTNNext.Size = New System.Drawing.Size(75, 32)
        Me.BTNNext.TabIndex = 15
        Me.BTNNext.Text = ">"
        Me.BTNNext.UseVisualStyleBackColor = True
        '
        'BTNClear
        '
        Me.BTNClear.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.BTNClear.Location = New System.Drawing.Point(488, 331)
        Me.BTNClear.Name = "BTNClear"
        Me.BTNClear.Size = New System.Drawing.Size(107, 32)
        Me.BTNClear.TabIndex = 25
        Me.BTNClear.Text = "Clear"
        Me.BTNClear.UseVisualStyleBackColor = True
        '
        'BTNFirst
        '
        Me.BTNFirst.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.BTNFirst.Location = New System.Drawing.Point(23, 331)
        Me.BTNFirst.Name = "BTNFirst"
        Me.BTNFirst.Size = New System.Drawing.Size(75, 32)
        Me.BTNFirst.TabIndex = 13
        Me.BTNFirst.Text = "<<"
        Me.BTNFirst.UseVisualStyleBackColor = True
        '
        'BTNLast
        '
        Me.BTNLast.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.BTNLast.Location = New System.Drawing.Point(274, 331)
        Me.BTNLast.Name = "BTNLast"
        Me.BTNLast.Size = New System.Drawing.Size(75, 32)
        Me.BTNLast.TabIndex = 16
        Me.BTNLast.Text = ">>"
        Me.BTNLast.UseVisualStyleBackColor = True
        '
        'BTNUpdate
        '
        Me.BTNUpdate.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.BTNUpdate.Location = New System.Drawing.Point(488, 183)
        Me.BTNUpdate.Name = "BTNUpdate"
        Me.BTNUpdate.Size = New System.Drawing.Size(107, 32)
        Me.BTNUpdate.TabIndex = 11
        Me.BTNUpdate.Text = "Update"
        Me.BTNUpdate.UseVisualStyleBackColor = True
        '
        'BTNDelete
        '
        Me.BTNDelete.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.BTNDelete.Location = New System.Drawing.Point(408, 221)
        Me.BTNDelete.Name = "BTNDelete"
        Me.BTNDelete.Size = New System.Drawing.Size(107, 32)
        Me.BTNDelete.TabIndex = 12
        Me.BTNDelete.Text = "Delete"
        Me.BTNDelete.UseVisualStyleBackColor = True
        '
        'BTNAdd
        '
        Me.BTNAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.BTNAdd.Location = New System.Drawing.Point(328, 183)
        Me.BTNAdd.Name = "BTNAdd"
        Me.BTNAdd.Size = New System.Drawing.Size(107, 32)
        Me.BTNAdd.TabIndex = 10
        Me.BTNAdd.Text = "Add New"
        Me.BTNAdd.UseVisualStyleBackColor = True
        '
        'LBLEmail
        '
        Me.LBLEmail.AutoSize = True
        Me.LBLEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEmail.Location = New System.Drawing.Point(20, 279)
        Me.LBLEmail.Name = "LBLEmail"
        Me.LBLEmail.Size = New System.Drawing.Size(45, 19)
        Me.LBLEmail.TabIndex = 21
        Me.LBLEmail.Text = "Email:"
        '
        'TXTEmail
        '
        Me.TXTEmail.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTEmail.Location = New System.Drawing.Point(118, 272)
        Me.TXTEmail.Name = "TXTEmail"
        Me.TXTEmail.Size = New System.Drawing.Size(134, 26)
        Me.TXTEmail.TabIndex = 8
        '
        'LBLPhone
        '
        Me.LBLPhone.AutoSize = True
        Me.LBLPhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPhone.Location = New System.Drawing.Point(20, 247)
        Me.LBLPhone.Name = "LBLPhone"
        Me.LBLPhone.Size = New System.Drawing.Size(78, 19)
        Me.LBLPhone.TabIndex = 19
        Me.LBLPhone.Text = "Phone No.:"
        '
        'TXTPhone
        '
        Me.TXTPhone.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPhone.Location = New System.Drawing.Point(118, 240)
        Me.TXTPhone.Name = "TXTPhone"
        Me.TXTPhone.Size = New System.Drawing.Size(134, 26)
        Me.TXTPhone.TabIndex = 7
        '
        'RTXTNotes
        '
        Me.RTXTNotes.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTXTNotes.Location = New System.Drawing.Point(339, 48)
        Me.RTXTNotes.Name = "RTXTNotes"
        Me.RTXTNotes.Size = New System.Drawing.Size(256, 122)
        Me.RTXTNotes.TabIndex = 9
        Me.RTXTNotes.Text = ""
        '
        'LBLNotes
        '
        Me.LBLNotes.AutoSize = True
        Me.LBLNotes.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNotes.Location = New System.Drawing.Point(445, 16)
        Me.LBLNotes.Name = "LBLNotes"
        Me.LBLNotes.Size = New System.Drawing.Size(49, 19)
        Me.LBLNotes.TabIndex = 15
        Me.LBLNotes.Text = "Notes"
        '
        'LBLID
        '
        Me.LBLID.AutoSize = True
        Me.LBLID.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLID.Location = New System.Drawing.Point(20, 23)
        Me.LBLID.Name = "LBLID"
        Me.LBLID.Size = New System.Drawing.Size(28, 19)
        Me.LBLID.TabIndex = 16
        Me.LBLID.Text = "ID:"
        Me.LBLID.Visible = False
        '
        'LBLAddress3
        '
        Me.LBLAddress3.AutoSize = True
        Me.LBLAddress3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAddress3.Location = New System.Drawing.Point(20, 183)
        Me.LBLAddress3.Name = "LBLAddress3"
        Me.LBLAddress3.Size = New System.Drawing.Size(75, 19)
        Me.LBLAddress3.TabIndex = 11
        Me.LBLAddress3.Text = "Address 3:"
        '
        'TXTAddress3
        '
        Me.TXTAddress3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTAddress3.Location = New System.Drawing.Point(118, 176)
        Me.TXTAddress3.Name = "TXTAddress3"
        Me.TXTAddress3.Size = New System.Drawing.Size(134, 26)
        Me.TXTAddress3.TabIndex = 5
        '
        'LBLPost
        '
        Me.LBLPost.AutoSize = True
        Me.LBLPost.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPost.Location = New System.Drawing.Point(20, 215)
        Me.LBLPost.Name = "LBLPost"
        Me.LBLPost.Size = New System.Drawing.Size(87, 19)
        Me.LBLPost.TabIndex = 12
        Me.LBLPost.Text = "Postal Code:"
        '
        'TXTPost
        '
        Me.TXTPost.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPost.Location = New System.Drawing.Point(118, 208)
        Me.TXTPost.Name = "TXTPost"
        Me.TXTPost.Size = New System.Drawing.Size(134, 26)
        Me.TXTPost.TabIndex = 6
        '
        'LBLAddress1
        '
        Me.LBLAddress1.AutoSize = True
        Me.LBLAddress1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAddress1.Location = New System.Drawing.Point(20, 119)
        Me.LBLAddress1.Name = "LBLAddress1"
        Me.LBLAddress1.Size = New System.Drawing.Size(75, 19)
        Me.LBLAddress1.TabIndex = 7
        Me.LBLAddress1.Text = "Address 1:"
        '
        'TXTAddress1
        '
        Me.TXTAddress1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTAddress1.Location = New System.Drawing.Point(118, 112)
        Me.TXTAddress1.Name = "TXTAddress1"
        Me.TXTAddress1.Size = New System.Drawing.Size(134, 26)
        Me.TXTAddress1.TabIndex = 3
        '
        'LBLAddress2
        '
        Me.LBLAddress2.AutoSize = True
        Me.LBLAddress2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAddress2.Location = New System.Drawing.Point(20, 151)
        Me.LBLAddress2.Name = "LBLAddress2"
        Me.LBLAddress2.Size = New System.Drawing.Size(75, 19)
        Me.LBLAddress2.TabIndex = 8
        Me.LBLAddress2.Text = "Address 2:"
        '
        'TXTAddress2
        '
        Me.TXTAddress2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTAddress2.Location = New System.Drawing.Point(118, 144)
        Me.TXTAddress2.Name = "TXTAddress2"
        Me.TXTAddress2.Size = New System.Drawing.Size(134, 26)
        Me.TXTAddress2.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 407)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "MS ACCESS CONNECT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TXTFName As TextBox
    Friend WithEvents TXTSName As TextBox
    Friend WithEvents LBLFName As Label
    Friend WithEvents LBLSName As Label
    Friend WithEvents BTNPrev As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTNFirst As Button
    Friend WithEvents BTNLast As Button
    Friend WithEvents BTNNext As Button
    Friend WithEvents RTXTNotes As RichTextBox
    Friend WithEvents LBLNotes As Label
    Friend WithEvents LBLID As Label
    Friend WithEvents LBLAddress3 As Label
    Friend WithEvents TXTAddress3 As TextBox
    Friend WithEvents LBLPost As Label
    Friend WithEvents TXTPost As TextBox
    Friend WithEvents LBLAddress1 As Label
    Friend WithEvents TXTAddress1 As TextBox
    Friend WithEvents LBLAddress2 As Label
    Friend WithEvents TXTAddress2 As TextBox
    Friend WithEvents LBLEmail As Label
    Friend WithEvents TXTEmail As TextBox
    Friend WithEvents LBLPhone As Label
    Friend WithEvents TXTPhone As TextBox
    Friend WithEvents BTNClear As Button
    Friend WithEvents BTNUpdate As Button
    Friend WithEvents BTNDelete As Button
    Friend WithEvents BTNAdd As Button
    Friend WithEvents LBLID2 As Label
End Class
