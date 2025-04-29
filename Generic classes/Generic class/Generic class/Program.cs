using System;


#region generic_+class

public class Sample <T>
{
    T field= default;

    public T fieldInfo{
        get { return field; }
        set { field = value; }
    }

    public string showInfo()
    {
        return $"field value {field} and field date type {field.GetType()}";
    }

 }
#endregion

#region example

class Program
{
    #region Generic_method
    // Generic method to swap two values
    public static void Swap<T>(ref T a, ref T b)
    {

        T temp = a;
        a = b;
        b = temp;
    }
    #endregion
    static void Main(string[] args)
    {
        Console.WriteLine("------------ Hello,from Mostafa Ahmed ---------------!");
        Console.WriteLine("---------------- Generic classes ---------------!");

        #region
        // Example usage
        var sampleInt = new Sample<int>();
        sampleInt.fieldInfo = 100;
        Console.WriteLine(sampleInt.showInfo());

        var sampleString = new Sample<string>();
        sampleString.fieldInfo = "Mostafa";
        Console.WriteLine(sampleString.showInfo());

        Sample<char> sampleChar = new Sample<char>();
        sampleChar.fieldInfo = 'G';
        Console.WriteLine(sampleChar.showInfo());
        #endregion

        #region
        int x = 10, y = 20;
        Console.WriteLine($"Before Swap: x = {x}, y = {y}");
        Swap(ref x, ref y);
        Console.WriteLine($"After Swap: x = {x}, y = {y}");

        string str1 = "Mostafa", str2 = "Ahmed";
        Console.WriteLine($"Before Swap: str1 = {str1}, str2 = {str2}");
        Swap(ref str1, ref str2);
        Console.WriteLine($"After Swap: str1 = {str1}, str2 = {str2}");


        #endregion
    }
}

#endregion




    

    
    

