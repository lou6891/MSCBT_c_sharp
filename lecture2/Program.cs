internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lecture 2");

        //int[] inputArray = new int[] {9,54,76,4577,578,4,325,7,-9999999,426,57,235,57,-100,1,2,3,4,5,6,7,8,9};
        //Console.WriteLine("The minumum value is: " + MinValue(inputArray));
        //Console.WriteLine("The position of the min value is: " + PosOfMinValue(inputArray));

        Cars CarsData = new Cars();
        //CarsData.Location = "Varese";
        //CarsData.SetLocation("Madrid");
        //CarsData.WriteConsole();

        StackV1 stack =  new StackV1();

    
        //ReverseTheOrder();

       /*  int[] myArray = new int[]{27, 21, 29, 22, 23,1};

       int[] anArray = myArray;

       myArray[2] = 33;

       anArray[1] = 37;
        
        Console.WriteLine("My array");
       for (int i = 0; i < myArray.Length ; i++){
            Console.WriteLine(myArray[i]);
        }
        Console.WriteLine("an array");
        for (int i = 0; i < anArray.Length ; i++){
            Console.WriteLine(anArray[i]);
        }
        
        Console.WriteLine("SumOfParts");
        //{3,4,6,9,12,5,3} startPos 5, endPos 5
        int[] test = new int[]{3,4,6,9,12,5,3};
        Console.WriteLine(SumOfPart( test, 5, 5));
 */
        string input = "some textt# where sommd##eone made typo#oerrors";
        
        
        Console.WriteLine(clearString(input));

    }

    public static int[] clearString(string input){
        char[] inputchr = input.ToCharArray();

        int[] result = new int[inputchr.Length];

        StackV1 stack = new StackV1();

        for (int i = 0; i < inputchr.Length; i++){
           
        }

        return result;
    }

    public static int NumberOfOccurences(char[] array, char letter){
        int result = 0;

        for (int i = 0; i < array.Length; i++){
            if(array[i] == letter){
                result ++;
            }
        }

        return result ;
    }

    public static void ReturnOddIndex (int[] inputArr){
        int size = (inputArr.Length / 2);
        int[] outputArr = new int[size];
        // Output =  [21, 41, 39, 3]
        int counter = 0;
        for (int i = 1; i < inputArr.Length; i = i + 2){
            outputArr[counter] = inputArr[i];
            counter ++;
        }

       for (int i = 0; i < outputArr.Length ; i++){
            Console.WriteLine(outputArr[i]);
        }
    }
    public static int SumOfPart(int[] array, int startPos, int endPos){
        int result = 0;

        for (int i = startPos; i <= endPos; i++){
            result = result + array[i];
        }

        return result;
    }

    public static int MinValue(int[] input){
        
        int dummy = input[0];
        for (int i = 0; i < input.Length ; i++){
            if (dummy > input[i]){
                dummy = input[i];
            }
        }

        return dummy;

    }

    public static int PosOfMinValue(int[] input){
        
        // [ value, position of the value]
        int[] dummy = new int[2] {input[0], 0};
        for (int i = 0; i < input.Length ; i++){
            if (dummy[0] > input[i]){
                dummy[0] = input[i];
                dummy[1] = i;
            }
        }
        return dummy[1];
    }

    public static void ReverseTheOrder(){
        int[] NumberArr = new int[]{1,3,6,8,12,19,2};

        StackV1 stackv1 = new StackV1(NumberArr.Length);

        DisplayArray("Original Array",NumberArr);

        for (int i = 0; i < NumberArr.Length; i++){
            stackv1.Push(NumberArr[i]);
        }
         for (int i = 0; i < NumberArr.Length; i++){
            NumberArr[i] = stackv1.Pop();
        }

        DisplayArray("Reversed Array" , NumberArr);
    }


    public static void DisplayArray(string text , int[] Arr){
        Console.Write(text + ": [");
        for(int i = 0; i < Arr.Length; i++){
            Console.Write(Arr[i] + ",");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


