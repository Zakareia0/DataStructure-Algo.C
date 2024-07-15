/* using Algorithms_Data_Structures_Course_2024.ADT;
using System.Collections;

Stack ts = new Stack();

Class1_pokemon squirtle = new Pokemon(); */
//using System.Threading.Tasks.Dataflow;

//int[] intArray = new int[10];

//int length = 0;

//for (int i = 0; i < 8; i++)
//{
//    intArray[length] = i;
//    length++;

//}

////intArray[length] = 0;
////length++;


//// inserting at the start of an array
///*for (int i = 3; i >= 0; i--)
//{
//    intArray[i + 1] = intArray[i];
//}

//intArray[0] = 20;*/



//for (int i = 4; i>= 2; i--)
//{
//    // Shifting position to the right
//    intArray[i+1] = intArray[i];

//}

//intArray[2] = 8;

// deleting from the beginning
//int[] intArray = new int[9];

//int length = 0;
//for (int i = 0; i < 6; i++)
//    {
//    intArray[length] = i;
//    length++;
//}

//for (int i = 4; i < length; i++)
//{
//    intArray[i - 1] = intArray[i];
//}

//length--;

////for(int i =1; i<length; i++)
////{
////    intArray[i-1] = intArray[i];
////}
////length--;

//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine(intArray[i]);
//}


//int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//bool LinearSearch(int[] array, int key)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] == key)
//        {
//            return true;
//        }
//    }
//    return false;
//}

//Console.WriteLine(LinearSearch(array, 10));


/////////////   Linked list
///

using Algorithms_Data_Structures_Course_2024.LinkedList;


//LinkedList LinkedList = new LinkedList();
//LinkedList.InsertFirst(1);
//LinkedList.InsertFirst(2);
//LinkedList.InsertFirst(3);
//LinkedList.InsertFirst(4);

//LinkedList.DeleteFirst();
//LinkedList.DeleteFirst();

//LinkedList.InsertLast(546);
//LinkedList.InsertLast(3434);

//LinkedList.DisplayList();

//using Algorithms_Data_Structures_Course_2024.Stack;
//using System.Collections;
//Stack stack = new Stack(10);
//for(int i = 0 ; i < 10; i++)
//{
//    stack.Push("===");
//    stack.Push("---");
//    stack.Push("****");

//}

//stack.Pop();
//stack.Peek();

//while (!stack.isEmpty())
//{
//    var var = stack.Pop();
//    Console.WriteLine(var);

//}


// C# code to create a LinkedList 

class GFG
{


    public static void Main()
    {


        LinkedList<String> myList = new LinkedList<String>();


        myList.AddLast("Geeks");
        myList.AddLast("for");
        myList.AddLast("Data Structures");
        myList.AddLast("Noida");

 
        if (myList.Count > 0)
            Console.WriteLine("LinkedList is not empty");
        else
            Console.WriteLine("LinkedList is empty");
    }
}



// C# code to create a Dictionary
//using System;
//using System.Collections.Generic;

//class GFG
//{


//    public static void Main()
//    {


//        Dictionary<string, string> myDict =
//        new Dictionary<string, string>();

        
//        myDict.Add("1", "C");
//        myDict.Add("2", "C++");
//        myDict.Add("3", "Java");
//        myDict.Add("4", "Python");
//        myDict.Add("5", "C#");
//        myDict.Add("6", "HTML");

        
//        Console.WriteLine("Total key/value pairs" +
//            " in myDict are : " + myDict.Count);

        
//        Console.WriteLine("\nThe key/value pairs" +
//                        " in myDict are : ");

//        foreach (KeyValuePair<string, string> kvp in myDict)
//        {
//            Console.WriteLine("Key = {0}, Value = {1}",
//                            kvp.Key, kvp.Value);
//        }
//    }
//}


//// program for createing9 Hashtable
//using System;
//using System.Collections;

//class GFG
//{


//    static void Main(string[] args)
//    {

//        Hashtable g = new Hashtable();
//        g.Add(1, "welcome");
//        g.Add(2, "to");
//        g.Add(3, "tutorials");
//        g.Add(4, "of");
//        g.Add(5, "C#");

//        ICollection key = g.Keys;


//        Console.WriteLine("Hashtable:");
//        Console.WriteLine();
//        foreach (var val in key)
//        {
//            Console.WriteLine(val + "-" + g[val]);
//        }
//    }
//}


//// C# code to create a Queue 
//using System; 
//using System.Collections; 

//class GFG
//{


//    public static void Main()
//    {

    
//        Queue myQueue = new Queue();


//        myQueue.Enqueue("one");

     
//        Console.Write("Total number of elements in the Queue are : ");

//        Console.WriteLine(myQueue.Count);

//        myQueue.Enqueue("two");

//        // Displaying the count of elements 
//        // contained in the Queue 
//        Console.Write("Total number of elements in the Queue are : ");

//        Console.WriteLine(myQueue.Count);

//        myQueue.Enqueue("three");

    
//        Console.Write("Total number of elements in the Queue are : ");

//        Console.WriteLine(myQueue.Count);

//        myQueue.Enqueue("four");

 
//        Console.Write("Total number of elements in the Queue are : ");

//        Console.WriteLine(myQueue.Count);

//        myQueue.Enqueue("five");

    
//        Console.Write("Total number of elements in the Queue are : ");

//        Console.WriteLine(myQueue.Count);

//        myQueue.Enqueue("six");

   
//        Console.Write("Total number of elements in the Queue are : ");

//        Console.WriteLine(myQueue.Count);
//    }
//}
