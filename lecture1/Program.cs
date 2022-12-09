// https://learn.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code?pivots=dotnet-6-0

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! From lecture 1");

        //test comment
        int x = 5;
        int z = x +1;
        string s = "test string";
        string A = "test autosave";

        Console.WriteLine("int X = " + x + " int Z = "+  z+ " string S = " + s);
        Console.WriteLine(A);

        // Call method
        Console.WriteLine(MultiplyWithTwo(4));

        // Calling the different methods
        Arrays();
        LoopsAndArrays();     
        MultipleArray(); 
        declareInitializeArrays();
        copyArraysCorrectWay();
    }

    // A method 
    // public defines accessability, int is the type of data returned
    public static int MultiplyWithTwo(int number){
       return number * 2;
    }

    //Array 
    // Arrays conists of componets which are all SAME TYPE
    // When declaring an array we SELECT THE SIZE, THET CANNOT BE CHANGED
    public static void Arrays (){
        Console.WriteLine("Array program");
        // int[] -> specifies the array type
        // new int[] inside the brachets you specify the lenght of the array
        int[] first_array = new int [10];

        first_array[5] = 666;

        Console.WriteLine(first_array[5]);
    }

    //Loops and arrays
    public static void LoopsAndArrays(){
        
        int[] loop_array = new int[10];

        for (int i=0; i<10; i++){
            Console.WriteLine("pos " + i + " : " + loop_array[i]);
        }

        

    }

    public static void MultipleArray(){
    
       // Array containing other arrays
        int[][] multiple_array = new int[5][];
        for (int i=0; i<multiple_array.Length; i++){
            multiple_array[i] = new int[3];
        }

        Console.WriteLine(multiple_array);
    }



    // COPYING ARRAYS
    // In C# when coptying an array we also inherit the properties so if you change one you also change the other
    public static void declareInitializeArrays(){
    
       //create empty array 
       int[] parent = new int[]{0,1,2,3,4};
       int [] children = parent;
       
       parent[2] = 666;

       for (int i=0; i<parent.Length; i++){
           Console.WriteLine("parent " + parent[i]);
        }
       
       for (int i=0; i<parent.Length; i++){
            Console.WriteLine("children with modified parent " + children[i]);
        }
      

    }  

    public static void copyArraysCorrectWay(){
    
       //create empty array 
       int[] parent = new int[]{0,1,2,3,4};
       
       int [] copy = new int[parent.Length];
       for(int i=0; i<parent.Length; i++){
        copy[i] = parent[i];
       }
       
       parent[2] = 666;
       for (int i=0; i<copy.Length; i++){
            Console.WriteLine("copy" + copy[i]);
        }
        for (int i=0; i<parent.Length; i++){
           Console.WriteLine("parent " + parent[i]);
        }
      

    }   
}