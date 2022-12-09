public class linkedList{

    private IntNode Head;


    public int Queue(int value){
        // First in first out aproach
        // add to the beginning, remove from the end

        IntNode toAdd = new IntNode();
        toAdd.Value = value;
        toAdd.Next = Head;
        Head = toAdd;

        IntNode current = Head;

        int returnValue = null;

        while (current.Next != null){
            current = current.Next;
            if (current.Next.Next == null){
                returnValue = current.Next.Value;
                current.Next = null;
            }
        }

        return returnValue;
    }

}