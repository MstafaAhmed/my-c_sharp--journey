/*
 Floyd's triangle is a triangular array of natural numbers used in computer science education.
 It is named after Robert Floyd. 
 It is defined by filling the rows of the triangle with consecutive numbers, starting with a 1 in the top left corner:

1
2	3
4	5	6
7	8	9	10
11	12	13	14	15
 */

Console.Write("Enter number of floyd's triangle to print :  ");   // output massage ask the user to write number of rows

int Row= int.Parse(Console.ReadLine());  // get the number of rows from the user

int counter = 1;   // intialiaze the counter 

// use nasted loop to print numbers 

for(int i=0;i<Row;i++)     
{
    for (int j=0;j<=i;j++)
    {
        Console.Write(counter + " ");
        counter++;
    }
    Console.WriteLine(  );  // to go to next line
}

