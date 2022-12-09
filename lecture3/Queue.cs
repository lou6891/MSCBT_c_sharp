
public class Queue {

    private int size = 10;
    private int[] intArr ;
    private int top = -1;

    public Queue()
    {
        intArr = new int[size];
    }

    public Queue(int newSize) 
    {
        size = newSize;
        intArr = new int[size];
    }

    public void Enqueue(int number){
        if(top == size - 1){
            DoubleTheInternalArray();
            return;
        }
        if(top < -1){
            top = -1;
        }
        top++;
        intArr[top] = number;
    }

    public int Dequeue(){
        int result = intArr[0];
        top--;
        
        int[] tempArr = new int[size];

        for (int i = 1; i < intArr.Length; i ++){
            tempArr[i -1] = intArr[i];
        }

        for (int i = 0; i < intArr.Length; i ++){
            intArr[i] = tempArr[i];
        }

        return result;
    }

     public int Peek(){
        if(top < 0){
             Console.WriteLine("Could not peek, stack undeflow");
            return 0;
        }
        int result = intArr[top];
        return result;
    }

    public void WriteInformation(){
        Console.Write("intAr: [");
        for(int i = 0; i < intArr.Length; i++){
            Console.Write(intArr[i] + ",");
        }
        Console.Write("]");

        Console.WriteLine(" Top: "+ top);
    }

    private void DoubleTheInternalArray() {
        int newSize = size * 2;
        int [] newArray = new int[newSize];

        for (int i = 0; i < size; i++){
            newArray[i] = intArr[i];
        }

        intArr = newArray;
        size = newSize;
        Console.WriteLine("Resized the array");
        Console.WriteLine("New Size: " + newSize);

    }

}
