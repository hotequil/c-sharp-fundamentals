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
