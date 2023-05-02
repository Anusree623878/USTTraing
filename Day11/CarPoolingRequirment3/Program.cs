using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingRequirment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Valid Car registration number:");
            Console.WriteLine("2. Convert car registration number:");
            Console.WriteLine("3. Valid driving license:");
            Console.WriteLine("Enter your choice:");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the car registration number :");
                    string carregno = Console.ReadLine();
                    if (IsValidCarRegistrationNumber(carregno))
                    {
                        Console.WriteLine(carregno + "is valid");
                    }
                    else
                    {
                        Console.WriteLine(carregno + "is  Invalid");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter car registration number:");
                    string carregnotoconvert = Console.ReadLine();
                    string convertedcarregno = ConvertCarRegistrationNumber(carregnotoconvert);
                    Console.WriteLine("Converted number:" + convertedcarregno);
                    break;
                case 3:
                    Console.WriteLine("Enter driving license issue date (dd-mm-yyyy):");
                    DateTime issuedate = DateTime.ParseExact(Console.ReadLine(), "dd-mm-yyyy", null);
                    if (IsValidDrivingLicense(issuedate))
                    {
                        Console.WriteLine((DateTime.Now.Year - issuedate.Year) + "years old license - expired");

                    }
                    else
                    {
                        Console.WriteLine((DateTime.Now.Year - issuedate.Year) + "years old license - valid");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;


            }
        }
        static bool IsValidCarRegistrationNumber(string carregno)
        {
            string pattern = @"^[A-Z]{2}-\d{2}=[A-Z]{2}-\d{4}$";
            return System.Text.RegularExpressions.Regex.IsMatch(pattern, carregno);
        }

        static string ConvertCarRegistrationNumber(string carregno)
        {
            return carregno.Replace('@','-').Replace('*','-').ToUpper();
        }

        static bool IsValidDrivingLicense(DateTime issuedate)
        {
            DateTime currentDate= DateTime.Now;
            DateTime expiryDate=issuedate.AddYears(10);
            return currentDate > expiryDate;
        }
           






    }
}
    