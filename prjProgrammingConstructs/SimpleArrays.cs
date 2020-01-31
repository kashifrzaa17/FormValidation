using System;
using System.Collections;
class SimpleArray
{
    /*static void Main()
    {
        int[] ar = new int[10];
        Array.Resize(ref ar, 16);
        Console.WriteLine(ar.Length);
        Console.ReadLine();

    }*/
    static void Main()
    {
        ArrayList al = new ArrayList();
        Console.WriteLine(al.Capacity);
        al.Add(100);
        al.Add("Stirg");
        al.Insert(2, 6);
        al.AddRange(al);
// Console.WriteLine(al.BinarySearch("stirg"));
        Console.WriteLine(al.Count);
        Console.WriteLine(al.GetRange(1, 3));
        Console.Read();

    }
}
