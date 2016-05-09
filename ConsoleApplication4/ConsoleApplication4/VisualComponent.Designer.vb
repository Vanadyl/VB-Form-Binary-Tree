<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualComponent
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
        Me.BtnAddData = New System.Windows.Forms.Button()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnUpdateTable = New System.Windows.Forms.Button()
        Me.DataInputBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnAddData
        '
        Me.BtnAddData.Location = New System.Drawing.Point(13, 13)
        Me.BtnAddData.Name = "BtnAddData"
        Me.BtnAddData.Size = New System.Drawing.Size(75, 23)
        Me.BtnAddData.TabIndex = 0
        Me.BtnAddData.Text = "Add data"
        Me.BtnAddData.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(13, 212)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(347, 228)
        Me.TreeView1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnUpdateTable
        '
        Me.BtnUpdateTable.Location = New System.Drawing.Point(13, 71)
        Me.BtnUpdateTable.Name = "BtnUpdateTable"
        Me.BtnUpdateTable.Size = New System.Drawing.Size(99, 23)
        Me.BtnUpdateTable.TabIndex = 3
        Me.BtnUpdateTable.Text = "Update Table"
        Me.BtnUpdateTable.UseVisualStyleBackColor = True
        '
        'DataInputBox
        '
        Me.DataInputBox.Location = New System.Drawing.Point(94, 13)
        Me.DataInputBox.Name = "DataInputBox"
        Me.DataInputBox.Size = New System.Drawing.Size(100, 20)
        Me.DataInputBox.TabIndex = 4
        '
        'VisualComponent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(975, 463)
        Me.Controls.Add(Me.DataInputBox)
        Me.Controls.Add(Me.BtnUpdateTable)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TreeView1)
        Me.Controls.Add(Me.BtnAddData)
        Me.Name = "VisualComponent"
        Me.Text = "VisualComponent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAddData As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BtnUpdateTable As System.Windows.Forms.Button
    Friend WithEvents DataInputBox As System.Windows.Forms.TextBox
End Class
