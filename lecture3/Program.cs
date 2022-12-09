internal class Program
{ 
    private static void Main(string[] args)
    { 

        Queue queue = new Queue();

        CharStack charStack = new CharStack();

        string input = "hello";
        char[] inputChars = input.ToCharArray();

        //Console.WriteLine(inputChars);

        charStack.Push(inputChars[0]);
        charStack.Push(inputChars[1]);
        charStack.Push(inputChars[2]);
        charStack.Push(inputChars[3]);
        charStack.Push(inputChars[4]);

        //Console.WriteLine(charStack.Peek());

        Console.WriteLine(charStack.GetString());

        


        // for (int i = 0; i<100; i++){
        //     queue.Enqueue(new Random().Next(100));
        //     if(i % 3 == 0){
        //         Console.WriteLine("deque: " + queue.Dequeue());
        //     }
        // }



        //string input = "{ c [ s { i ( m ) } } ( ) { }";
        //if(IsStringValid(input)){
        //    Console.WriteLine("the string is valid");
        //} else {
        //    Console.WriteLine("the string is not valid");
        //}

    }

    private static bool IsStringValid(string input){

        char[] inputAsChars = input.ToCharArray();
        
        CharStack stack = new CharStack();
        for(int i=0;i<inputAsChars.Length;i++){
            char charToHandle = inputAsChars[i];
            //Console.WriteLine("i: " + i + " => " + charToHandle);
            if(IsOpeningBracket(charToHandle)){
                stack.Push(charToHandle);
            }
            if(IsClosingBracket(charToHandle)) {
                char topElement = stack.Pop();
                if(MatchesOpeningBracket(topElement,charToHandle)) {
                    Console.WriteLine("found closing " + charToHandle + " and it matches the last opening");
                }
                else {
                    Console.WriteLine("found closing " + charToHandle + " but the opening " + topElement +" does not match");
                    return false;
                }
            }
        }
        return true;
    }

    private static bool IsOpeningBracket(Char input){
        char[] brackets = new char[] {'[','{','('};

        for(int i=0;i<brackets.Length;i++) {
            if(brackets[i] == input) {
                return true;
            }
        }

        return false;
    }
    private static bool IsClosingBracket(Char input){
        char[] brackets = new char[] {']','}',')'};

        for(int i=0;i<brackets.Length;i++) {
            if(brackets[i] == input) {
                return true;
            }
        }

        return false;
    }
  
    private static bool MatchesOpeningBracket(Char opening, Char closing){
        if(opening == '[' && closing == ']') {
            return true;
        }
        if(opening == '{' && closing == '}') {
            return true;
        }
        if(opening == '(' && closing == ')') {
            return true;
        }
        return false;
    }

}


