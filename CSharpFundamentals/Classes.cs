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
        public string Name { get; set; }
        
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

    sealed class Descendant : Ancestral
    {
        private readonly string _name;

        public Descendant(int age, int favoriteNumber, string name) : base(age, favoriteNumber)
        {
            _name = name;
        }

        public void ShowDescendantData()
        {
            ShowAncestralData();
            Console.WriteLine($"Favorite number: {FavoriteNumber}");
            Console.WriteLine($"Name: {_name}");
        }
    }
    
    internal class Ancestral
    {
        private readonly int _age;
        protected readonly int FavoriteNumber;

        protected Ancestral(int age, int favoriteNumber)
        {
            _age = age;
            FavoriteNumber = favoriteNumber;
        }

        protected void ShowAncestralData()
        {
            Console.WriteLine($"Age: {_age}");
        }
    }

    internal class BadRequestError : Error
    {
        public override string? Name { get; set; }

        public override void ShowMessage()
        {
            Console.WriteLine($"Bad request: {Name}");
        }
    }

    internal abstract class Error
    {
        public abstract string? Name { get; set; }
        public abstract void ShowMessage();
        
        public bool HasName()
        {
            return !String.IsNullOrEmpty(Name);
        }
    }

    internal class ListDetails : IList, IDetails
    {
        public void Get()
        {
            Console.WriteLine("Get items!");
        }

        public void CreatePagination()
        {
            Console.WriteLine("Pagination was created!");
        }
        
        public void GetOne()
        {
            Console.WriteLine("Get one item!");
        }
    }

    internal class Details : IDetails
    {
        public void GetOne()
        {
            Console.WriteLine("Get one item!");
        }

        public void GetByToken()
        {
            Console.WriteLine("Get by token!");
        }
    }

    internal class Product
    {
        public delegate void OnChangePrice(double newPrice, double oldPrice);
        public event OnChangePrice? OnChangePriceEvent;
        private double _price;

        public double Price
        {
            get { return _price; }
            set
            {
                if(value <= 0) return;
                
                var oldPrice = _price;
                _price = value;
                
                if(OnChangePriceEvent != null)
                    OnChangePriceEvent.Invoke(_price, oldPrice);
            }
        }
    }
}
