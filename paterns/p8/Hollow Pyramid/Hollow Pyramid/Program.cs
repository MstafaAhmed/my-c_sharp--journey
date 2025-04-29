
Console.Write("Enter number of rows :  ");

int Row=int.Parse(Console.ReadLine());

for(int i = 1; i <= Row;i++)
{
    /* Print trailing spaces */
    for (int k=i;k<Row;k++)
    {
        Console.Write(" ");
    }

    /* Print hollow pyramid */
    
    for (int j=1;j<= (2 * i - 1); j++)
    {
        /*
             * Print star for last row (i==row),
             * first column(j==1) and for
             * last column (j==(2*i-1)).
             */
        if (j == 1 || i == Row || j == (2 * i - 1))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }

    }
    /* Move to next line */
    Console.WriteLine();


}

