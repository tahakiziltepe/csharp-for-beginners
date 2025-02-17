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