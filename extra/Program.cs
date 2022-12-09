namespace extra;
class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Exercises");
        
        Console.WriteLine("");
        Console.WriteLine("Q1");
        q1();

        Console.WriteLine("");
        Console.WriteLine("Q2");
        q2();
        
        
        Console.WriteLine("");
        Console.WriteLine("Q5");
        q3();
        
        Console.WriteLine("");
        Console.WriteLine("Q4 : " + q4());
        
        Console.WriteLine("");
        Console.WriteLine("Q5");
        q5();

        Console.WriteLine("");
        Console.WriteLine("Q6");
        q6();

        Console.WriteLine("");
        Console.WriteLine("Q7");
        q7();
    }
    public static string WriteArray(int[] input){
        return string.Format("[{0}]", string.Join(',', input));
    }

    private static void q1 ()
    {
        // given an array of integers, output the difference between the largest and smallest value, without thinking of edge cases

        int[] input = new int[]{5, 7, 12, 3, 2, 4, 9, 2,1};
        int smallest = input[0];
        int largest = input[0];

        for (int i = 0; i < input.Length;i ++){
            if (smallest > input[i]){
                smallest = input[i];
            }
            if(largest < input[i]){
                largest = input[i];
            }
        }
        int result = largest - smallest;

        Console.WriteLine("Result: " +result );
    }
    private static void q2 ()
    {
        // given an array of sorted integers (increasing), you should remove the duplicate values 
        //(each value can be multiple times in the input, butshould be removed to be only one time in the output). 
        //The result of your method should be an array with distinct numbers in sorted order(increasing)
        // input: [0,0,0,1,1,2,3,5,7,7,7,9] output: [0,1,2,3,5,7,9]

        int[] input = new int[]{0,0,0,1,1,2,3,5,7,7,7,9};
        
        int[] tester = new int[input.Length];
        Array.Fill(tester, -999999);
        Console.WriteLine(String.Join(",", tester));

        int counter = 0;
        bool test = false;

        for (int i= 0; i< input.Length; i++){
            test = false;

            for (int j= 0; j < tester.Length; j++){
                if (input[i] == tester[j]){
                    test = true;
                }
            }

            if (test == false){
                tester[counter] = input[i];
                counter ++;
            }
        }

        for (int i = 0; i < counter; i++){
            Console.Write(" "+ tester[i]);
        }
    }
    private static void q3 ()
    {
        // Given an array of positive integers, e.g. [1, 7, 5] and a given target, e.g. 12, 
        // you should output an array with the indices of the elements in the array which forms as a sum the given target, e.g. [1,2]. 
        // Do not look for edge cases like empty arrays. you will always have at least 3elements. You provide only one pair of indices, 
        // even if there are more possible combinations, and there is no direction 
        // (does not matter ifthey are at the beginning, middle or end). 
        // if you cannot find two pairs, return an empty array of the same output size.
        // input: [5, 7, 12, 3, 2, 4, 9, 4,1] and target 8

        int[] input = new int[]{5, 7, 12, 3, 2, 4, 9, 4,1};
        int target = 8;
        int[] result = new int[2];

        for (int i = 0; i < input.Length; i++){
            
            for (int j = 0; j < input.Length; j++){
                if (input[i] + input[j] == target){
                    result[0] = i;
                    result[1] = j;
                    goto LoopEnd;
                }
            }
        }
        
        LoopEnd:
            for (int i = 0; i < result.Length; i++){
            Console.Write(" "+ result[i]);
            }
    }
    private static int q4 ()
    {
        // given a sorted array of distinct integer numbers and an integer Y you should provide a method, 
        // which returns the index of the value of Y (if it is in the array), or the index where Y has to be inserted to have a sorted array again
        // input: [1, 2, 4, 7, 9, 10] and Y = 4 output: 2
        
        int[] input = new int[]{1, 2, 4, 7, 9, 10};
        int target = 4;

        for (int i = 0; i < input.Length; i++){
            if(input[i] == target){
                return i;
            }
            else if (i != 0 && input[i- 1] < target  && input[i] > target){
                return i;
            }
        }

        return 0;

    }
    private static void q5 ()
    {
        // given an array of integer numbers, a value and an insert index (0-based) insert the value into the array.
        // input: [1, 2, 5, 7, 9, 12] value = 8, index = 4 output: [1, 2, 5, 7, 8, 9, 12]

        int[] input = new int[]{1, 2, 5, 7, 9, 12};
        int[] result = new int[input.Length + 1];
        int value = 8;
        int index = 4;

        for (int i = 0; i < result.Length; i++){
            if(i < index ){
                result[i] = input[i];
            }
            else if(i == index){
                result[i] = value;
            }
            else if(i > index){
                result[i] = input[i-1];
            }
        }

        for (int i = 0; i < result.Length; i++){
            Console.Write(" "+ result[i]);
        }
    }
    private static void q6 ()
    {
        // given an array of positive integer numbers, all values are twice in the array except one. find the one and return it. 
        // If you cannot find it,return -1. Don't overcomplicate, it is just working with an array

        // input: [1, 2, 5, 8, 5, 1, 2] output: 8

        int[] input = new int[]{1, 2, 5, 8, 5, 1, 2};
        int result = -1;

        for (int i = 0; i < input.Length; i++){
            bool tester = false;

            for (int j = 0; j < input.Length; j++){
                if(i != j){
                    if(input[i] == input[j]){
                        tester = true;
                    }
                }
            }

            if(tester == false){
               result = input[i];
            }
        }
        
        Console.Write("Result: "+ result);

    }
    private static void q7 ()
    {
        //given an array of integers provide a method which creates a slice of the array; a slice is a part of an array. 
        // You will always return an array, the slice will always have at least the size of 1, 
        // and the input index X and Y will always be in the index range of the given array, 
        // and X will always be equal or smaller than Y.

        // input: [1, 5, 2, 6, 7, 8, 11], X = 2, Y = 4
        // output: [2, 6, 7]

        int[] input = new int[]{1, 5, 2, 6, 7, 8, 11};
        int x = 2;
        int y = 4;
        int[] result = new int[ y - x + 1];

        int counter = 0;
        for (int i = 0; i < input.Length; i++){
           if(i >= x && i <= y){
                result[counter] = input[i];
                counter = counter +1;
           }
        }
        
        for (int i = 0; i < result.Length; i++){
            Console.Write(" "+ result[i]);
        }
    }
    

    // Exercises not to be done
    private static void q8 ()
    {
        // implement the queue adt with a linked list.

    }

    private static void q9 ()
    {
        // implement the stack adt with the linked list.

    }

    private static void q10 ()
    {
        // given a linked integer list implementation, add a method ToArray which gives as output an array of the 
        // values of the linked list in the order they were added to the linked list. 
        // Now, look at the implementation, where you added the new elements (begin/end). 

    }

    private static void q11 ()
    {
        // given the queue implementation we did in class, add the following feature: 
        // the queue implementation should be used for the queue in front of a hospital. 
        // people arrive and use the queue to enter; however, there are also emergencies which should pass the queue 
        // and should get in front, but if there are already emergencies which wait they also have to queue behind the emergencies. 
        // if there are no emergencies than the other patients will get inside.

    }

    private static void q12 ()
    {
        // given an array of chars provide a method, which should count the number of occurences of each char.
        // you are only allowed to use arrays/loops for solving this exercise.
        
        // input: [a, b, c, a, f, f, f, b, d, d, e, a]
        // output: [[a, 3],[b, 2], [c, 1], [f, 3], [d, 2], [2,1]]

        // hint: the output is an array of arrays, meaning in index 0 there is another array with two positions a, 3
        // hint: you cannot know the size of the output array at the beginning

    }

    private static void q13 ()
    {
        // in your linked list implementation (for integers), provide a method which returns a boolean value: 
        // true if the numbers in the list are sorted in increasing order, false if they are not.

    }
}


