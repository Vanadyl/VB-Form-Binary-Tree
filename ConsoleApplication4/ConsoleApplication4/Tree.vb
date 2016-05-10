Public Class Tree
    Public _root As TreeNode
    'Creating a new tree requires a root node, contained within this constructor
    Sub New(ByVal rootdata As Object)
        _root = GetNode(rootdata)
    End Sub
    Public Function GetNode(ByVal data As Object) As TreeNode
        Dim node As New TreeNode
        node.Data = data
        Return node
    End Function

    Public Sub AddtoTree(ByVal data As Object)
        Dim currentNode As TreeNode = _root
        Dim nextNode As TreeNode = _root

        While currentNode.Data <> data And Not nextNode Is Nothing
            currentNode = nextNode
            If nextNode.Data < data Then
                nextNode = nextNode.RightNode
            Else
                nextNode = nextNode.LeftNode
            End If
        End While
        'I was not sure where to put duplicate datas so I delete them as I am presuming this code would be used in a dictionary or similar.
        If currentNode.Data = data Then
            Console.WriteLine("Duplicate data (" &
                 data & "). Node was not inserted")
        ElseIf currentNode.Data < data Then
            currentNode.RightNode = GetNode(data)
        Else
            currentNode.LeftNode = GetNode(data)
        End If
    End Sub
    Public Sub inOrderTraverse(ByVal node As TreeNode)
        If Not node Is Nothing Then
            inOrderTraverse(node.LeftNode)
            Console.WriteLine(node.Data)
            inOrderTraverse(node.RightNode)
        End If
    End Sub
    Public Sub preOrderTraverse(ByVal node As TreeNode)
        If Not node Is Nothing Then
            Console.WriteLine(node.Data)
            preOrderTraverse(node.LeftNode)
            preOrderTraverse(node.RightNode)
        End If
    End Sub
    Public Sub postOrderTraverse(ByVal node As TreeNode)
        If node Is Nothing Then
            postOrderTraverse(node.LeftNode)
            Console.WriteLine(node.Data)
            postOrderTraverse(node.RightNode)
        End If
    End Sub
End Class
