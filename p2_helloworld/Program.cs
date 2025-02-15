// See https://aka.ms/new-console-template for more information

// Part 1
Console.WriteLine("Hello, World!");

// Part 2
string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");

// Part 3
string firstFriend3 = "  Maria  ";
firstFriend = firstFriend3.TrimStart();

string secondFriend3 = "   Sage ";
secondFriend = secondFriend3.TrimEnd();

string thirdFriend3 = "  Johnson  ";
thirdFriend3 = thirdFriend3.Trim();

Console.WriteLine($"My friends are {firstFriend3} and {secondFriend3} and {thirdFriend3}");
