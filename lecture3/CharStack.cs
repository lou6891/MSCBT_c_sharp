
public class CharStack {

    private int size = 10;
    private char[] charArr;
    private int top = -1;

    
    public CharStack()
    {
        charArr = new char[size];
    }

    public CharStack(int newSize) 
    {
        size = newSize;
        charArr = new char[size];
    }

    private void DoubleTheInternalArray(){
        int newSize = size * 2;
        char[] newArray = new char[newSize];
        
        for(int i=0;i<size;i++) {
            newArray[i] = charArr[i];
        }
        charArr = newArray;
        size = newSize;
        Console.WriteLine("resized the array");
        Console.WriteLine("new size: " + newSize);
    }

    public void Push(char singleChar) {
        if(top == size - 1) {
            // Console.WriteLine("could not push, stack overflow");
            // return;
            DoubleTheInternalArray();
        }
        top++;
        charArr[top] = singleChar;
    }

    public char Pop() {
        if(top == -1) {
            Console.WriteLine("could not pop, stack underflow");
            return ' ';
        }
        char result = charArr[top];
        top--;
        return result;
    }

    public char Peek() {
        if(top < 0) {
            Console.WriteLine("could not peek, stack underflow");
            return ' ';
        }
        char result = charArr[top];
        return result;
    }

    public void WriteInformation(){
        
        for(int i=0;i<charArr.Length;i++) {
            string infoIsTop = "";
            if(i == top) {
                infoIsTop = " top";
            }
            Console.WriteLine("internal array at pos " + i + ": " + charArr[i] + infoIsTop);
        }
    }

    public string GetString()
   {

       char[] result = new char[top+1];
    
       for(int i=0;i<=top;i++) {
           result[i] = charArr[i];

       }

       return new string(result);

   }
}
