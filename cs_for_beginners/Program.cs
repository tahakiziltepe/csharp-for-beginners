// See https://aka.ms/new-console-template for more information

// Part 1
Console.WriteLine("Hello, World!");

// Part 3
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

// Part 5
string firstFriend5 = "  Maria  ";
firstFriend5 = firstFriend5.TrimStart();

string secondFriend5 = "   Sage ";
secondFriend5 = secondFriend5.TrimEnd();

string thirdFriend5 = "  Johnson  ";
thirdFriend5 = thirdFriend5.Trim();

Console.WriteLine($"My friends are {firstFriend5} and {secondFriend5} and {thirdFriend5}");

// Part 6
string friends = $"My friends are {firstFriend5} and {secondFriend5} and {thirdFriend5}";
Console.WriteLine(friends.Replace("Sage", "Hank"));
string newFriends = friends.Replace("Maria", "John");
Console.WriteLine(newFriends);

Console.WriteLine(newFriends.Contains("Maria"));
Console.WriteLine(newFriends.ToUpper());
Console.WriteLine(newFriends.Length);
Console.WriteLine(newFriends.StartsWith("My"));
Console.WriteLine(newFriends.EndsWith("Maria"));


// Part 7
int a = 18;
int b = 6;
int c = a + b;
Console.WriteLine(c);

int a1 = 2100000000;
int b1 = 2100000000;
long c1 = (long)a1 + (long)b1;
Console.WriteLine(c1);

// returns error because the result is too large for an int
// int a2 = 2100000000;
// int b2 = 2100000000;
//long c2 = checked(a2+b2);
//Console.WriteLine(c2);

// Part 8
double a3 = 42.1;
float b3 = 38.2F;
double c3 = a3 + b3;
Console.WriteLine(c3); // 0,30000076293945

decimal a4 = 42.1M;
decimal b4 = 38.2M;
decimal c4 = a4 + b4;
Console.WriteLine($"The answer is {c4}"); // 80.3

// Part 9
int a5 = 7;
int b5 = 4;
if (a5 + b5 > 10) 
    Console.WriteLine("The answer is greater than 10.");
else 
    Console.WriteLine("The answer is not greater than 10.");

int a6 = 5;
int b6 = 3;
bool myTest = (a6 + b6 > 10);
if (myTest) {
    Console.WriteLine("The answer is greater than 10.");
} else if (a6 + b6 == 10) { 
    Console.WriteLine("The answer is 10.");
} else { 
    Console.WriteLine("The answer is not greater than 10.");
}

if ((a6 + b6 > 10) && (a6 == b6)) {
    Console.WriteLine("The answer is greater than 10.");
    Console.WriteLine("And the first number is equal to the second.");
} else {
    Console.WriteLine("The answer is not greater than 10.");
    Console.WriteLine("Or the first number is not equal to the second.");
}

if ((a6 + b6 > 10) || (a6 == b6)) {
    Console.WriteLine("The answer is greater than 10.");
    Console.WriteLine("Or the first number is equal to the second.");
} else {
    Console.WriteLine("The answer is not greater than 10.");
    Console.WriteLine("And the first number is not equal to the second.");
}