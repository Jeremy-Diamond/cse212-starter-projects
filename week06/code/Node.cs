public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) { // if value is less than Data
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data) { // if value is greater than Data
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        // if the value is equal to the current node's data
        if (value == Data)
            return true;
        // if the value is less than the current node's data
        if (value < Data)
            // if the left node is not null
            if (Left != null)
                // recursively call Contains on the left node
                return Left.Contains(value);
        // if the value is greater than the current node's data
        if (value > Data)
            // if the right node is not null
            if (Right != null)
                // recursively call Contains on the right node
                return Right.Contains(value);
        // if the value is not found
        return false;
    }

    public int GetHeight() {
        // TODO Start Problem 4
        //find the height of the left subtree
        int leftHeight = Left?.GetHeight() ?? 0;
        //find the height of the right subtree
        int rightHeight = Right?.GetHeight() ?? 0;
        //return the maximum height of the left and right subtrees
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}