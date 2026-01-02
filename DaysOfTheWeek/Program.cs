//Project: Days of the week for homework from Nikita

Console.Write("Hello please enter a number from 1 to 7 to check what day of the week is behind it: ");
int userInput = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (userInput == 1)
{
    Console.WriteLine("Number one is Monday!");
    Console.WriteLine();
    Console.WriteLine("Press any key to close the program.");
    Console.ReadKey();
}
else if (userInput == 2)
{
    Console.WriteLine("Number two is Tuesday!");
    Console.WriteLine();
    Console.WriteLine("Press any key to close the program.");
    Console.ReadKey();
}
else if (userInput == 3)
{
    Console.WriteLine("Number three is Wednesday!");
    Console.WriteLine();
    Console.WriteLine("Press any key to close the program.");
    Console.ReadKey();
}
else if (userInput == 4)
{
    Console.WriteLine("Number four is Thursday!");
    Console.WriteLine();
    Console.WriteLine("Press any key to close the program.");
    Console.ReadKey();
}
else if (userInput == 5)
{
    Console.WriteLine("Number five is Friday!");
    Console.WriteLine();
    Console.WriteLine("Press any key to close the program.");
    Console.ReadKey();
}
else if (userInput == 6)
{
    Console.WriteLine("Number six is Saturday!");
    Console.WriteLine();
    Console.WriteLine("Press any key to close the program.");
    Console.ReadKey();
}
else if (userInput == 7)
{
    Console.WriteLine("Number seven is Sunday!");
    Console.WriteLine();
    Console.WriteLine("Press any key to close the program.");
    Console.ReadKey();
}
else
{
    Console.WriteLine("Number is out of range 1..7 or the value you entered is invalid.");
    Console.WriteLine();
    Console.WriteLine("Press any key to close the program.");
    Console.ReadKey();
}