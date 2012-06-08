<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BatchRename
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
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOldName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewName = New System.Windows.Forms.TextBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(13, 13)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(281, 20)
        Me.txtPath.TabIndex = 0
        '
        'btnPath
        '
        Me.btnPath.Location = New System.Drawing.Point(300, 13)
        Me.btnPath.Name = "btnPath"
        Me.btnPath.Size = New System.Drawing.Size(75, 21)
        Me.btnPath.TabIndex = 1
        Me.btnPath.Text = "Folder"
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Old Name:"
        '
        'txtOldName
        '
        Me.txtOldName.Location = New System.Drawing.Point(82, 52)
        Me.txtOldName.Name = "txtOldName"
        Me.txtOldName.Size = New System.Drawing.Size(133, 20)
        Me.txtOldName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "New Name:"
        '
        'txtNewName
        '
        Me.txtNewName.Location = New System.Drawing.Point(82, 78)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.Size = New System.Drawing.Size(133, 20)
        Me.txtNewName.TabIndex = 5
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(236, 52)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(139, 46)
        Me.btnRun.TabIndex = 6
        Me.btnRun.Text = "Rename!"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'BatchRename
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 111)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.txtNewName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtOldName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPath)
        Me.Controls.Add(Me.txtPath)
        Me.MaximizeBox = False
        Me.Name = "BatchRename"
        Me.Text = "Batch Rename"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPath As System.Windows.Forms.TextBox
    Friend WithEvents btnPath As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOldName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNewName As System.Windows.Forms.TextBox
    Friend WithEvents btnRun As System.Windows.Forms.Button

End Class
