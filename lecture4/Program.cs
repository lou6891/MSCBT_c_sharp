internal class Program
{
    private static void Main(string[] args)
    {      
        // These are thwo lists with different scenarios
        Console.WriteLine("List 1 example usecases -----------------");
        LinkedIntList myList1 = new LinkedIntList();

        myList1.AddFirst(5);
        myList1.AddFirst(6);
        myList1.AddFirst(7);
        myList1.AddFirst(8);
        myList1.AddFirst(9);
        myList1.AddAtPosition(0, 3);

        myList1.WriteInformation();

        Console.WriteLine("Finshed adding values");

        myList1.RemoveEnd();
        myList1.RemoveBeginning();
        myList1.RemoveValue(0);

        myList1.WriteInformation();
        
        myList1.Contains(6);
        myList1.Contains(9);

        myList1.GetSize();

        myList1.Clear();

        myList1.Add(999);
        myList1.Add(666);
        myList1.AddFirst(0);

        myList1.WriteInformation();

        Console.WriteLine("List 2 example usecases ------------------");
        
        LinkedIntList list2 = new LinkedIntList();
        list2.WriteInformation();

        list2.RemoveBeginning();
        list2.RemoveEnd();
        
        list2.Contains(1);
        list2.RemoveValue(5);

        list2.GetSize();

        list2.Add(1);
        list2.Add(2);
        list2.Add(7);

        list2.WriteInformation();

        Console.WriteLine("now insert at a position");

        list2.AddAtPosition(12, 1);

        list2.WriteInformation();

        Console.WriteLine("now remove");

        list2.RemoveValue(2);

        list2.WriteInformation();

        Console.WriteLine("now clear");
        list2.Clear();
        list2.WriteInformation();

        Console.WriteLine("program finished");

    }
}
