using System;
using System.Collections.Generic;
namespace EventsInCSharp
{
    public class MyClass
    {
        public delegate void MyDelegate(string message);
        public event MyDelegate MyEvent;
        public void RaiseEvent(string message)
        {
            if (MyEvent != null) MyEvent(message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Neww Repository");
        }
       
    }
}



