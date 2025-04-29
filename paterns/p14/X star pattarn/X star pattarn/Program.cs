// X star pattarn
Console.Write("Enter number of rows:  ");
int Row= int.Parse(Console.ReadLine());


int count = 2 * Row - 1;
for (int i = 1; i <= count; i++)
{

    for (int k = 1; k <= count; k++)
    {
        if (k == i || k == count - i + 1)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}

//another solution using 2 for loop
for (int i = Row; i > 1; i--)
{
    for (int j = Row; j >= i; j--)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= 2 * i - 1; k++)
    {
        if (k == 1 || k == 2 * i - 1)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}


for (int i = 1;i<= Row; i++)
{
    for(int j = i;j<= Row; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k <= 2 * i - 1; k++)
    {
        if ( k == 1 || k == 2 * i - 1)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}
