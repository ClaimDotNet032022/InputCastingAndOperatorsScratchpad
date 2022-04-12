// See https://aka.ms/new-console-template for more information

//Console.Write("Say something: ");
//string input = Console.ReadLine();

//string sibilant = input.Replace("s", "sssss");
//Console.WriteLine("You said:");
//Console.WriteLine(sibilant);


Console.WriteLine(3 + 5);

int n1 = 9;
int n2 = 10;
int n3 = n1 + n2;
Console.WriteLine(n3);

double d = 3.4;
double d2 = 1.6;
Console.WriteLine(d + d2);

string s1 = "12";
string s2 = "34";
Console.WriteLine(s1 + s2);

string s3 = "Hello ";
string s4 = "World!";
Console.WriteLine(s3 + s4);

Console.WriteLine(n1 - n2);

double d3 = 5.0;
double d4 = 2.0;
Console.WriteLine(d3 / d4);

int n4 = 5;
int n5 = 2;
Console.WriteLine(n4 / n5);

Console.WriteLine(n4 * n5);

Console.WriteLine(n4 % n5);

int evenOrOdd = 7;
Console.WriteLine(evenOrOdd % 2);

bool b = (12 == 15);
Console.WriteLine(b);

Console.WriteLine("Is evenOrOdd even?");
Console.WriteLine(evenOrOdd % 2 == 0);

Console.WriteLine(12 != 15);
Console.WriteLine(12 > 15);
Console.WriteLine(12 >= 15);
Console.WriteLine(12 < 15);
Console.WriteLine(12 <= 15);
Console.WriteLine(12 > 12);//false
Console.WriteLine(12 >= 12);//false


int i = 3;
i += 5;
i += 1;
i += 1;
Console.WriteLine(i);

i -= 1;
i *= 3;
i /= 2;
i %= 2;

int j = 42;
int k = -j;

j++;
j--;
++j;
--j;


//////////////////////

// Narrowing conversion (could lose
// information) requires cast.
int myInt = 3;
short myShort = (short)myInt;

double myDouble = 4.5;
int doubleAsInt = (int)myDouble;
Console.WriteLine(doubleAsInt);

// Widening conversion works without
// cast. No possibility of losing data.
int myOtherInt = myShort;

myDouble = myInt;
long myLong = myInt;

string doubleAsString = myDouble.ToString();
Console.WriteLine(doubleAsString);

string sss = "123HELLO45";
int parsedInt = int.Parse(sss);
double.Parse(sss); 
float floatAsString = float.Parse(sss);
long longAsString = long.Parse(sss);