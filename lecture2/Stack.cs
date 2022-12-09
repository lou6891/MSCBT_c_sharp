
public class Stack {

    private const int MaxElements = 10;
    private int[] intArr = new int [MaxElements];
    private int top = -1;

    public void Push(int number){
        if(top == MaxElements - 1){
            Console.WriteLine("Could not push, stack overflow");
            return;
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
    
    
}
