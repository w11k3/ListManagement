using System.Runtime.ExceptionServices;

public class ListCollection
{
    public static void Main(string[] args)
    {
        // create a new List of string
        List<string> items = new List<string>();

        items.Add("red"); // append an item to the List
        items.Insert(0, "yellow"); // insert the value at index 0

        // display the colors in the list
        Console.Write("Display list contents with counter-controlled loop:");
        for (int i = 0; i < items.Count; i++)
            Console.Write(" {0}", items[i]);

        // display colors using foreach
        Console.Write("\nDisplay list contents with foreach statement:");

        foreach (var item in items)
            Console.Write(" {0}", item);

        items.Add("green"); // add "green" to the end of the List
        items.Add("yellow"); // add "yellow" to the end of the List
        Console.WriteLine();

        // display the List
        Console.Write("List with two new elements:");
        foreach (var item in items)
            Console.Write(" {0}", item);

        items.Remove("yellow"); // remove the first "yellow"
        Console.WriteLine();

        //display the List
        Console.Write("Remove first instance of yellow:");
        foreach (var item in items)
            Console.Write(" {0}", item);

        items.RemoveAt(1); // remove item at index 1
        Console.WriteLine();

        // display the List
        Console.Write("Remove second list element (green):");
        foreach (var item in items)
            Console.Write(" {0}", item);

        // check if a value is in the List
        Console.WriteLine("\n\"red\" is {0}in the list", items.Contains("red") ? string.Empty : "not ");

        //display number of elements in the List
        Console.WriteLine($"Count: {items.Count}");

        //display the capacity of the List
        Console.WriteLine($"Capacity: {items.Capacity}");
    } // end Main
} // end class
