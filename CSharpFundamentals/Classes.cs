using System;

namespace Application
{
    class InternalClass
    {
        public string name;
        public int age;

        public void ShowData(bool isUpperCase = false)
        {
            Console.WriteLine($"Name: {(isUpperCase ? name.ToUpper() : name)}");
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

        public int Sum(int firstNumber, int secondNumber = 10)
        {
            return firstNumber + secondNumber;
        }

        public int Subtracion(ref int firstNumber, int secondNumber)
        {
            return firstNumber -= secondNumber;
        }
    }

    public class PublicPerson
    {
        private int age;

        public PublicPerson()
        {
            Console.WriteLine("Person without age");
        }

        public PublicPerson(int age) : this()
        {
            this.age = age;
        }

        public void ShowAge()
        {
            Console.WriteLine(age);
        }

        ~PublicPerson()
        {
            Console.WriteLine("PublicPerson was destructed!");
        }
    }

    public static class StaticClass
    {
        public static int GetFavoriteNumber()
        {
            return 7;
        }
    }
}
