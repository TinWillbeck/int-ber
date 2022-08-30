string input;
input = ("");

while  (input != "äpple" && input != "päron")
{
    Console.WriteLine("äpple eller päron?");
    input = Console.ReadLine();
}
    if (input == "äpple")
    {
        Console.WriteLine("bra!");
    }
    else if (input == "päron")
    {
        Console.WriteLine("dåligt!");
    }
    else if (input != "äpple" && input != "päron")
    {
        Console.WriteLine("dåligt svar");
    }

Console.ReadLine();
