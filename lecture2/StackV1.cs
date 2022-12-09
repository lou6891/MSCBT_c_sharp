
public class StackV1 {


    private int size = 10;
    private int[] intArr;
    private int top = -1;

    public StackV1(){
        intArr = new int [size];
    }

    public StackV1(int newSize){
        size = newSize;
        intArr = new int [size];
    }

    public void Push(int number){
        if(top == size - 1){
            DoubleTheInternalArray();
        }
        top++;
        intArr[top] = number;
        
    }

    public int Pop(){
        if(top == -1){
             Console.WriteLine("Could not push, stack undeflow");
            return 0;
        }
        
        int result = intArr[top];
        top --;
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
