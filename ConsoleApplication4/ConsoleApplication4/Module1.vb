Module Module1

    Sub Main()
        Dim NodeTree As New Tree(Console.ReadLine)
        NodeTree.AddtoTree(Console.ReadLine)
        NodeTree.AddtoTree(Console.ReadLine)
        NodeTree.AddtoTree(Console.ReadLine)
        NodeTree.AddtoTree(Console.ReadLine)
        NodeTree.AddtoTree(Console.ReadLine)
        NodeTree.AddtoTree(Console.ReadLine)
        NodeTree.AddtoTree(Console.ReadLine)
        NodeTree.AddtoTree(Console.ReadLine)
        NodeTree.AddtoTree(Console.ReadLine)
        NodeTree.inOrderTraverse(NodeTree._root)
        NodeTree.postOrderTraverse(NodeTree._root)
        NodeTree.preOrderTraverse(NodeTree._root)
        Console.ReadLine()
    End Sub

End Module
