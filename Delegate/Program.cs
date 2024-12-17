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
            MyClass myClass1 = new MyClass();
            myClass1.MyEvent += new MyClass.MyDelegate(myClass1_MyEvent);
            Console.WriteLine("Please enter a message\n");
            string msg = Console.ReadLine();
            myClass1.RaiseEvent(msg);
            Console.Read();
        }
        static void myClass1_MyEvent(string message)
        {
            Console.WriteLine("Your Message is: {0}", message);
        }
    }
}



