using System;
using System.Collections;
using System.Collections.Generic;

namespace devoircsharp
{
    class Program
    {
        static void Main(string[] args)
        {
         //Hashtable stores key-value pairs 
        // Create a hashtable
        // Using Hashtable class
        Hashtable my_hashtable1 = new Hashtable();
 
        // Adding key/value pair
        // in the hashtable
        // Using Add() method
        my_hashtable1.Add("A1", "Kalibu");
        my_hashtable1.Add("A2", "hapa");
        my_hashtable1.Add("A3", "Soft");
 
        Console.WriteLine("Key and Value pairs from my_hashtable1:");
 
        foreach(DictionaryEntry ele1 in my_hashtable1)
        {
            Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
        }
 
        // Create another hashtable
        // Using Hashtable class
        // and adding key/value pairs
        // without using Add method
        Hashtable my_hashtable2 = new Hashtable() {
                                      {1, "hello"},
                                          {2, 234},
                                        {3, 230.45},
                                         {4, null}};
 
        Console.WriteLine("Key and Value pairs from my_hashtable2:");
 
        foreach(var ele2 in my_hashtable2.Keys)
        {
            Console.WriteLine("{0}and {1}", ele2,
                            my_hashtable2[ele2]);
        }

        // Stack code Last In First Out (LIFO) !

                  Stack countries = new Stack();  
        countries.Push("Burundi");  
        countries.Push("Rwanda");  
        countries.Push("Ouganda");  
        countries.Push("RDC");  
        countries.Push("Kenya"); 

        // list'Countries before Pop Method !
         Console.WriteLine("List of push Countries:"); 
        foreach (string country in countries)  
        {  
            Console.WriteLine(country);  
        }  

        // Peek and Pop properties here !
        Console.WriteLine("Peek element: "+ countries.Peek());  
        Console.WriteLine("Pop element: "+ countries.Pop());  
        Console.WriteLine("Pop element: " + countries.Pop());
         Console.WriteLine("New Peek element after Pop: "+ countries.Peek()); 

        // New list after Pop Method !
         Console.WriteLine("New List'Countries after Pop Method():"); 
        foreach (string country in countries)  
             {  
            Console.WriteLine(country);  
            }  

        //QUEUE CODE HERE  Fist In First Out (FIFO) !

        Queue pays = new Queue();  
        pays.Enqueue("Burundi");  
        pays.Enqueue("Rwanda");  
        pays.Enqueue("Ouganda");  
        pays.Enqueue("RDC");  
        pays.Enqueue("Kenya");

         // list'Countries after Enqueue Method !
         Console.WriteLine("List of Enqueue's Countries:");   
 
        foreach (string pay in pays)  
        {  
            Console.WriteLine(pay);  
        }  
 
        Console.WriteLine("Peek element: "+ pays.Peek());  
        Console.WriteLine("Dequeue: "+ pays.Dequeue());  
        Console.WriteLine("Peek element After Dequeue: " + pays.Peek());

         // list'Countries after Dequeue Method !
         Console.WriteLine("New List of Countries after Dequeue Method():");  
        foreach (string pay in pays)  
        {  
            Console.WriteLine(pay);  
        } 

        }
    }
}
