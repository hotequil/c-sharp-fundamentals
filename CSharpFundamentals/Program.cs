using System;

namespace Application
{
    enum Status
    {
        Waiting,
        Success,
        Error
    }

    enum Weekday
    {
        Monday = 0b_0000_0001,
        Tuesday = 0b_0000_0010,
        Wednesday = 0b_0000_0100,
        Thursday = 0b_0000_1000,
        Friday = 0b_0001_0000,
        Saturday = 0b_0010_0000,
        Sunday = 0b_0100_0000,
        Weekend = Saturday | Sunday
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args);
            
            int age = 21;
            int year;

            year = 2023;

            string name = "João Paulo", surname = "Hotequil";
            const int birthYear = 2002;
            bool isLegalAge = true;
            char firstLetter = 'J';
            var firstName = "João";

            Console.WriteLine("Hello, World!");
            Console.WriteLine(age);
            Console.WriteLine(year);
            Console.WriteLine($"{name} {surname}");
            Console.WriteLine(birthYear);
            Console.WriteLine(isLegalAge);
            Console.WriteLine(firstLetter);
            Console.WriteLine(firstName);

            sbyte firstNumber = 127;
            short secondNumber = 32767;
            int thirdNumber = 2147483647;
            long fourthNumber = 9223372036854775807;
            byte fifthNumber = 255;
            ushort sixthNumber = 65535;
            uint seventhNumber = 4294967295;
            ulong eighthNumber = 18_446_744_073_709_551_615;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
            Console.WriteLine(thirdNumber);
            Console.WriteLine(fourthNumber);
            Console.WriteLine(fifthNumber);
            Console.WriteLine(sixthNumber);
            Console.WriteLine(seventhNumber);
            Console.WriteLine(eighthNumber);

            int binary = 0b00100001;
            int hexadecimal = 0x2A;

            Console.WriteLine(binary);
            Console.WriteLine(hexadecimal);

            float firstDotNumber = 0.1234567890F;
            double secondDotNumber = 0.12345678012345678;
            decimal thirdDotNumber = 0.123456789012345678901234567890M;
            double fourthDotNumber = 1.55e2;

            Console.WriteLine(firstDotNumber);
            Console.WriteLine(secondDotNumber);
            Console.WriteLine(thirdDotNumber);
            Console.WriteLine(fourthDotNumber);

            short favoriteNumber = 7;
            int favoriteNumberAsInt = favoriteNumber;
            double favoriteNumberAsDouble = favoriteNumberAsInt;

            Console.WriteLine(favoriteNumber);
            Console.WriteLine(favoriteNumberAsInt);
            Console.WriteLine(favoriteNumberAsDouble);

            double gradeNumber = 2.75;
            int gradeNumberAsInt = (int)gradeNumber;
            short gradeNumberAsShort = (short)gradeNumberAsInt;

            Console.WriteLine(gradeNumber);
            Console.WriteLine(gradeNumberAsInt);
            Console.WriteLine(gradeNumberAsShort);

            double weight = 76.8;
            int weightAsInt = (int)weight;
            int weightAsIntConverted = Convert.ToInt32(weight);
            string weightAsString = "76.8";
            double weightAsDoubleConverted = Convert.ToDouble(weightAsString);

            Console.WriteLine(weight);
            Console.WriteLine(weightAsInt);
            Console.WriteLine(weightAsIntConverted);
            Console.WriteLine(weightAsString);
            Console.WriteLine(weightAsDoubleConverted);

            string firstConsoleValue = Console.ReadLine();
            double firstConsoleValueConverted = Convert.ToDouble(firstConsoleValue);
            string secondConsoleValue = Console.ReadLine();
            int secondConsoleValueConverted = Convert.ToInt32(secondConsoleValue);

            Console.WriteLine(firstConsoleValueConverted);
            Console.WriteLine(secondConsoleValueConverted);

            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine(key.KeyChar);

            int day = 28;
            int month = 6;
            int sum = day + month;
            int subtraction = day - month;
            int multiplication = day * month;
            int integerDivision = day / month;
            float division = (float)day / month;
            int mod = day % month;

            Console.WriteLine(sum);
            Console.WriteLine(subtraction);
            Console.WriteLine(multiplication);
            Console.WriteLine(integerDivision);
            Console.WriteLine(division);
            Console.WriteLine(mod);

            Console.WriteLine(day);
            Console.WriteLine(month);

            day++;
            month--;

            Console.WriteLine(day);
            Console.WriteLine(month);

            day--;
            month++;

            string phrase = "I Like " + "C#";
            phrase += " so much";

            Console.WriteLine(phrase);

            int andBitOperator = day & month;
            int orBitOperator = day | month;
            int xorBitOperator = day ^ month;
            int rightBitOperator = day >> month;
            int leftBitOperator = day << month;
            uint five = 0b_0101;
            uint notFive = ~five;

            Console.WriteLine(andBitOperator);
            Console.WriteLine(orBitOperator);
            Console.WriteLine(xorBitOperator);
            Console.WriteLine(rightBitOperator);
            Console.WriteLine(leftBitOperator);
            Console.WriteLine(five);
            Console.WriteLine(notFive);

            bool isDayBiggerThanMonth = day > month;

            Console.WriteLine(isDayBiggerThanMonth);

            bool hasLicenseDriver  = true;
            bool hasCar = false;

            Console.WriteLine(hasLicenseDriver && hasCar);
            Console.WriteLine(hasLicenseDriver & hasCar); // optimized
            Console.WriteLine(hasLicenseDriver || hasCar);
            Console.WriteLine(hasLicenseDriver | hasCar); // optimized
            Console.WriteLine(hasLicenseDriver ^ hasCar);
            Console.WriteLine(!hasLicenseDriver);
            Console.WriteLine(!hasCar);

            string text = "This is cool";

            Console.WriteLine(text.Length);
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.IndexOf("is"));
            Console.WriteLine(text.Substring(0, 4));
            Console.WriteLine("\"" + text + "\"");
            Console.WriteLine($"\"{text}\"");
            Console.WriteLine("C:\\Temp\\File.txt");
            Console.WriteLine("Break line!\n\n\n");
            Console.WriteLine("Tab 1\tTab 2\tTab 3");

            if (age == 18) Console.WriteLine("Almost...");
            else if (age > 18) Console.WriteLine("Is over 18 years!");
            else Console.WriteLine("Isn't in legal age!");

            Random random = new Random();

            int weekday = random.Next(1, 8);

            switch (weekday)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid weekday");
                    break;
            }

            var counter = 0;

            while (counter < 10)
            {
                Console.WriteLine($"First counter: {counter}");
                counter++;
            }

            counter = 0;

            do
            {
                Console.WriteLine($"Second counter: {counter}");
                counter++;
            } while (counter < 10);

            for (int index = 0; index < 10; index++)
            {
                if(index == 4) continue;
                if(index == 8) break;
                
                Console.WriteLine($"First index: {index}");
            }

            string[] techs = { "C#", "JavaScript", "HTML", "React" };

            techs[3] = "CSS";

            Console.WriteLine(techs[2]);

            foreach(string tech in techs) Console.WriteLine(tech);

            string[] letters = { "a", "b", "c" };
            letters = new string[6];
            letters = new string[4]{ "a", "b", "c", "d" };

            for (int index = 0; index < letters.Length; index++) Console.WriteLine(letters[index]);
            foreach(string letter in letters) Console.WriteLine(letter);

            int[] numbers = { 10, 32, 12, 65, 78, 34, 56 };

            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Count());

            Array.Sort(numbers);

            foreach (int number in numbers) Console.WriteLine(number);

            Console.WriteLine($"{Status.Success}: {(int)Status.Success}");

            foreach (Weekday weekdayItem in Enum.GetValues(typeof(Weekday))) Console.WriteLine($"{weekdayItem}: {(int)weekdayItem}");
            
            var firstObject = new InternalClass();
            var secondObject = new InternalClass();

            firstObject.name = "João Paulo Hotequil";
            firstObject.age = 21;

            secondObject.name = "Test";
            secondObject.age = 50;
            
            firstObject.ShowData();
            firstObject.ShowData(true);
            secondObject.ShowData();

            Console.WriteLine(firstObject.IsLegalAge());
            Console.WriteLine(secondObject.IsLegalAge());
            Console.WriteLine(firstObject.IsOlderThan(secondObject));
            Console.WriteLine(firstObject.GetDifference(secondObject));
            Console.WriteLine(firstObject.Sum(12, 8));
            Console.WriteLine(firstObject.Sum(12));
            Console.WriteLine(firstObject.Sum(secondNumber: 20, firstNumber: 30));

            int refNumber = 10;
            
            Console.WriteLine(firstObject.Subtracion(ref refNumber, 2));
            Console.WriteLine(refNumber);

            var firstPublicPerson = new PublicPerson();
            var secondPublicPerson = new PublicPerson(30);
            
            firstPublicPerson.ShowAge();
            secondPublicPerson.ShowAge();

            firstPublicPerson.Name = "João Paulo Hotequil";
            
            Console.WriteLine(firstPublicPerson.Name);
            Console.WriteLine(StaticClass.GetFavoriteNumber());

            var descendant = new Descendant(21, 7, "João Paulo Hotequil");
            
            descendant.ShowDescendantData();

            var badRequestError = new BadRequestError();

            Console.WriteLine(badRequestError.HasName());
            Console.WriteLine(badRequestError.Name);
            
            badRequestError.Name = "A simple error in a request. HTTP code is 400";
            
            Console.WriteLine(badRequestError.HasName());
            Console.WriteLine(badRequestError.Name);
            
            badRequestError.ShowMessage();

            var listDetails = new ListDetails();
            IDetails details = new Details();
            
            listDetails.Get();
            listDetails.CreatePagination();
            listDetails.GetOne();
            details.GetOne();

            if (details is Details) (details as Details).GetByToken();

            List<string> names = new List<string>{ "Hotequil" };
            
            names.Add("João");
            names.Add("Paulo");

            foreach (var nameItem in names) Console.WriteLine(nameItem);

            int divider = random.Next(0, 2);

            try
            {
                double result = 2 / divider;
                
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("DivideByZeroException");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                Console.WriteLine("Exception");
            }
        }
    }
}
