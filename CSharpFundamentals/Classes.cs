using System;

namespace Application
{
    class InternalClass
    {
        string name;
        private int age;

        public void ShowData()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
    } 
    
    public class PublicClass {}

    public static class StaticClass {}
}
