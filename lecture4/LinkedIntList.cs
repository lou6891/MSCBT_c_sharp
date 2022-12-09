
public class LinkedIntList{
    private IntNode Head;

    public void WriteInformation(){
        //Console.WriteLine("Printing all values: ");
        IntNode current = Head;
        Console.Write("Printing all values: [ ");
        // loop though the linked list and write the value, other Console.Write are just cosmetics
        while (current != null)
        {
            Console.Write("Value : " + current.Value);
            Console.Write(" , ");
            current = current.Next;
        }
        Console.Write(" ]");
        Console.WriteLine("");
    }

    public void AddFirst(int value){
        // This code adds a node to the beginning of the chain
        
        IntNode toAdd = new IntNode();

        toAdd.Value = value;
        toAdd.Next = Head;

        Head = toAdd;
    }

    
    public void Add(int value){
        // Add at the last position

        IntNode current = Head;
        IntNode toAdd = new IntNode();
        toAdd.Value = value;
        toAdd.Next = null;

        // if head is null the new elements will be the head
        if(current == null){
            Head = toAdd;
        }

        // Else we loop though the chain until we find the last node 
        // and then add the new node to the end of the linked list
        else{
            while (current != null)
            {
                if(current.Next == null){
                    current.Next = toAdd;
                    break;
                }
                current = current.Next;  
            }
        }        
    }

    public void AddAtPosition(int value, int position){
        // Add to speciifc position IMPORTANT index starting at 0

        IntNode toAddPosition = new IntNode();
        IntNode current = Head;
        toAddPosition.Value = value;

        int positionCounter = 0;
        // loop though the linked list keeping track of where we are int positionCounter
        while (current != null)
        {
            // since we need to add to a certain position I am adding the node at position - 1
            // so that when i'll add the node it will be in the postion the user intended
            // to add the node I set the new node's next to the ending chain and then switch around
            if (positionCounter == position -1 ){
                toAddPosition.Value = value;
                toAddPosition.Next = current.Next;
                current.Next = toAddPosition;
                break;
            }
            positionCounter ++;
            current = current.Next;
        }

        if(current == null){
            Console.WriteLine("Position not valid");
        }
    }

    public void RemoveEnd(){
        // remove the ending node
        if (Head != null)
        {
            IntNode current = Head;
            
            while (current.Next !=null){
                current = current.Next;
                // when it finds the last node it removes it by setting current.Next = null;
                if(current.Next.Next == null){
                current.Next = null;
                }    
            } 
        }
        
    }

    public void RemoveBeginning(){
        // eliminate the beginning node
        if (Head != null)
        {
            Head = Head.Next;
        }
        
    }

    public void RemoveValue(int value){
        IntNode current = Head;

        if(current != null){
            
            // IF the value is in the first position, remove the first node
            if(current.Value == value){
                Head = Head.Next;
            }
            else{

                // IF the value is present the loop will return, else the program will console log and then return
                // loop though the list
                while (current.Next != null){ 
                    //If the the value is in the next node and that node has a next, eliminate the node in the middle
                    if(current.Next.Value == value && current.Next.Next != null){
                        //Console.WriteLine("found " + current.Next.Value );
                        //Console.WriteLine("current " + current.Value );
                        current.Next = current.Next.Next;
                        return;
                    }
                    // if the the value is in the node at the end of the list eliminate the last node
                    else if(current.Next.Value == value && current.Next.Next == null){
                        current.Next = null;
                        return;
                    }
                    current = current.Next;
                }
                Console.WriteLine("Impossible to remove the value, it's not present in the LinkedList");
            }
            return;
           
        }
        Console.WriteLine("Impossible to find the value, the LinkedList is empty");
    }

    public void Clear(){
        // Removes everything by setting the linkedchain to null
        Head = null;
        Console.WriteLine("The LinkedList is now empty");
    }

    public bool Contains(int value){
        // prints the values contained in each node

        IntNode current = Head;

        // Loop though the linked list to find the value
        // when it finds the value stop and print
        // if the value is not found it will just return false

        while (current != null){ 
            
            if(current.Value == value){
                Console.WriteLine("The value: " + value + " is in the NodeList ");
                return true;
            }

            current = current.Next;
        }

        Console.WriteLine("The value: " + value + " is NOT in the NodeList ");
        return false;
    }

    public void GetSize(){
        // prints the number of nodes in the linked list

        IntNode current = Head;
        int counter = 0;

        // loop though the linked list and add 1 to the counter until the linked list is finished
        while (current != null){ 
            counter ++;
            current = current.Next;
        }

        Console.WriteLine("The size of the NodeList is: " + counter);

    }

}