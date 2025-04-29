/*Hallow Mirrored Parallelogram star pattarn
 A parallelogram pattern is a geometrical arrangement of stars in a parallelogram shape. 
The stars are printed in such a manner that if we draw a closed figure on the boundary of the printed pattern, 
it will resemble a parallelogram. 
Each row is shifted with space, which creates a diagonal slant.
 */

Console.Write("Enter number of Rows :  ");   // output massage ask the user to write number of rows

int Row = int.Parse(Console.ReadLine());  // get the number of rows from the user

Console.Write("Enter number of column :  ");   // output massage ask the user to write number of columns

int Col = int.Parse(Console.ReadLine());  // get the number of columns from the user

for (int i = 1; i <= Row; i++)
{

    /* Print trailing spaces */

    for (int k = 0; k < i-1; k++)
    {
        Console.Write(" ");
    }

    /* Print stars and center spaces */
    for (int j = 1; j <= Col; j++)
    {
        if (i == 1 || i == Row || j == 1 || j == Col)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }


    }

    Console.WriteLine();       /* Move to the next line */
}