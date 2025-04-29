using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
    internal class Program
    {
        static void Main(string[] args)
        {
        Employee employee1 = new Employee();
        employee1.Details("Mostaf Ahmed",1234,34000);
        employee1.ShowDetail();

        
        Employee employee2 = new Employee();
        employee2.ShowDetail();  // here constrction is used

        Employee employee3 = new Employee("Ali",10,7000);
        employee3.ShowDetail();  // here constrction is used


        Console.ReadLine();
        }
    }

class Employee
{
    //Field
    string Name;
    int ID;
    float Salary;


    // Method

    public void Details(string _name, int _id, float _salary)
    {
         Name=_name;
         ID= _id;
         Salary= _salary;

    }

    public void ShowDetail()
    {
        Console.WriteLine($"The Emoplyee name is: {Name} \n The Emoplyee ID is : {ID} \n The Emoplyee Salary is : {Salary}  \n ");
    }

    // Constructor
    public Employee()
    {
        Name = "Ahmed ";
        ID = 9876; 
        Salary = 50000;

    }

    // Constructor
    public Employee(string name, int id,float salary)
    {
        Name = name;
        ID = id;
        Salary = salary;
        
    }

}



