string[] userNames = { "mingyu", "seokmin", "minghao" };
string[] password = { "runningman7012", "yeheyyehey", "dontcare" };

Console.Write("userName:");
var currentUser = Console.ReadLine();
Console.Write("password:");
var currentPassword = Console.ReadLine();

bool isUserFound = userNames.Contains(currentUser);

for (int i = 0; i <= userNames.Length; i++)
{
    if (userNames[i] == currentUser && password[i] == currentPassword)
    {
        isUserFound = true;
        Console.Write($"Login is successful. Welcome {currentUser}");
        break;
    }
}

if (!isUserFound)
{
    Console.Write($"User \"{currentUser}\" not found");
}