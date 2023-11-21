using System;

namespace Application
{
    class InternalClass
    {
        public string name;
        public int age;

        public void ShowData()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }

        public bool IsLegalAge()
        {
            return age >= 18;
        }
        
        public bool IsOlderThan(InternalClass objectItem)
        {
            return age > objectItem.age;
        }

        public int GetDifference(InternalClass objectItem)
        {
            return objectItem.age - age;
        }
    } 
    
    public class PublicClass {}

    public static class StaticClass {}
}
