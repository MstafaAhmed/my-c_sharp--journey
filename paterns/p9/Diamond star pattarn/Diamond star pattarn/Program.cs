// diamond star pattarn
// created by Mostafa Ahmed

Console.Write("Enter number of rows :  ");

int Row = int.Parse(Console.ReadLine());

for (int i = 1; i <= Row; i++)

{
    for(int k=i;k<Row;k++)
    {
        Console.Write(" ");

    }
    for (int j = 1; j <= (2 * i - 1); j++)
    {

        Console.Write("*");
    }
    /* Move to next line */
    Console.WriteLine();
}

for (int i = Row - 1; i >= 1; i--)
{

    for (int k = Row; k > i; k--)
    {
        Console.Write(" ");

    }

    for (int j = 2 * i - 1; j >= 1; j--)
    {

        Console.Write("*");
    }
    /* Move to next line */
    Console.WriteLine();
}


