using Excerciseqstn;
using System;

//Arrange following lines in proper order to make program run:

public class Program
{
    public static void Main(string[] args)
    {
        Product p = new Product();
        Console.WriteLine("Enter the product id");
        p._id = Convert.ToInt64(Console.ReadLine());

        Console.WriteLine("Enter the supplier name");
        p._supplierName = Console.ReadLine();

        Console.WriteLine("Enter the product name");
        p._productName = Console.ReadLine();


        Console.WriteLine("Product Id is " + p._id);
        Console.WriteLine("Supplier Name is " + p._supplierName);
        Console.WriteLine("Product Name is " + p._productName);


    }

    

}















