<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckConn
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
        Me.BTNConnect = New System.Windows.Forms.Button()
        Me.BTNDisconnect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BTNConnect
        '
        Me.BTNConnect.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNConnect.Location = New System.Drawing.Point(43, 36)
        Me.BTNConnect.Name = "BTNConnect"
        Me.BTNConnect.Size = New System.Drawing.Size(178, 44)
        Me.BTNConnect.TabIndex = 0
        Me.BTNConnect.Text = "Connect to MySQL"
        Me.BTNConnect.UseVisualStyleBackColor = True
        '
        'BTNDisconnect
        '
        Me.BTNDisconnect.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNDisconnect.Location = New System.Drawing.Point(43, 139)
        Me.BTNDisconnect.Name = "BTNDisconnect"
        Me.BTNDisconnect.Size = New System.Drawing.Size(178, 44)
        Me.BTNDisconnect.TabIndex = 1
        Me.BTNDisconnect.Text = "Disconnect from MySQL"
        Me.BTNDisconnect.UseVisualStyleBackColor = True
        '
        'CheckConn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 215)
        Me.Controls.Add(Me.BTNDisconnect)
        Me.Controls.Add(Me.BTNConnect)
        Me.Name = "CheckConn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MySQL Connection"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BTNConnect As Button
    Friend WithEvents BTNDisconnect As Button
End Class
