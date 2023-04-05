Console.WriteLine("Enter a number");
string strnum = Console.ReadLine();
mirror(strnum);

void mirror(string num)
{
    try
    {
        int number = int.Parse(num);
        int nummir = 0;
        while (number / 1 >= 1)
        {
        nummir = nummir * 10 + number % 10;
        number /= 10;
        }
        Console.WriteLine(nummir);
        
    }
    catch (Exception)
    { Console.WriteLine("I said NUMBER! Use your brain >:("); }
}