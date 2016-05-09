Public Class VisualComponent
    Public NodeTree As New Tree(Nothing)
    Private Sub BtnUpdateTable_Click(sender As Object, e As EventArgs) Handles BtnUpdateTable.Click
        NodeTree.inOrderTraverse(NodeTree.GetNode(1))

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub BtnAddData_Click(sender As Object, e As EventArgs) Handles BtnAddData.Click
        NodeTree.AddtoTree(DataInputBox.Text)





    End Sub

End Class