using System;

namespace ExtensionMethodHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { Name = "John" };
            person.SetDefaultAge().PrintInfo();
        }
    }
}