// Hollow right triangle

Console.Write("Enter number of rows:  ");

int Row=int.Parse(Console.ReadLine());

for(int i=1;i<=Row;i++)
{
    for(int j=1;j<=i;j++)

    {/*
               Print star for first column(j==1), 
               last column(j==i) or last row(i==rows).
      */
        if ( i == Row || j == 1 || j == i)
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
