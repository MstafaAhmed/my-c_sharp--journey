/*Parallelogram star pattarn
 A parallelogram pattern is a geometrical arrangement of stars in a parallelogram shape. 
The stars are printed in such a manner that if we draw a closed figure on the boundary of the printed pattern, 
it will resemble a parallelogram. 
Each row is shifted with space, which creates a diagonal slant.
 */

Console.Write("Enter number of Rows :  ");   // output massage ask the user to write number of rows

int Row = int.Parse(Console.ReadLine());  // get the number of rows from the user

Console.Write("Enter number of column :  ");   // output massage ask the user to write number of columns

int Col = int.Parse(Console.ReadLine());  // get the number of columns from the user

for(int i=0;i<Row;i++)
{
    for (int k = Row-1; k > i; k--)
    {
        Console.Write(" ");
    }
    /* Print stars after spaces */
    for (int j=0;j<Col;j++)
    {
        Console.Write("*");

    }
    Console.WriteLine(  );       /* Move to the next line */
}