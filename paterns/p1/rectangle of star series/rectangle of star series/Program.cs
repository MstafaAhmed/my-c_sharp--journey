
Console.Write("Enter number of Rows :  ");   // output massage ask the user to write number of rows

int Row = int.Parse(Console.ReadLine());  // get the number of rows from the user

Console.Write("Enter number of column :  ");   // output massage ask the user to write number of columns

int Col = int.Parse(Console.ReadLine());  // get the number of columns from the user

/* Iterate over each row */
for (int i=1;i<=Row; i++)
{
    /* Print star for 1st and last row, column */
    for (int j = 1; j <= Col; j++)
    {
        if (i == 1 || i==Row || j ==1 || j== Col)
        {
            Console.Write("*");

        }
        else
        {
            Console.Write( " " );
        }

    }
    /* Move to the next line */
    Console.WriteLine();
}

