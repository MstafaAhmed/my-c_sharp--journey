//numbers pattarn with 1,0

Console.Write("Enter number of rows :  ");
int Row=int.Parse(Console.ReadLine());

Console.Write("Enter number of columns :  ");
int Col = int.Parse(Console.ReadLine());


for (int i=1;i<=Row;i++)
{
    if(i%2==1)
    {
        for(int j=1;j<=Col;j++)
        { Console.Write("1"); }
    }
    else
    {
        for (int j = 1; j <= Col; j++)
        { Console.Write("0"); }
    }
    Console.WriteLine();
}
