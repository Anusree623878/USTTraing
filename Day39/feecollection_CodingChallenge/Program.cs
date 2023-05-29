using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feecollection_CodingChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Student Types:");
            Console.WriteLine("Enter the  Student type:");
            string sttype=Console.ReadLine();

            Console.WriteLine("Enter tuition fee:");
            float tufee=float.Parse(Console.ReadLine());

            Console.WriteLine("Enter bus fee:");
            float busfee=float.Parse(Console.ReadLine());

            Console.WriteLine("Enter hostel fee");
            float hsfee=float.Parse(Console.ReadLine());


            if(sttype== "MSDS")
            {
                msds( tufee, busfee);
            }
            else if(sttype== "MSH")
            {
                msh(tufee, hsfee);
            }
            else if (sttype== "MGSDS")
            {
                mgsds(tufee, busfee);
            }
            else if (sttype== "MGSH")
            {
                mgsh(tufee, hsfee);
            }
        }

        private static void mgsh(float tufee, float hsfee)
        {
            //150% of Tuition fee + Hostel fee
            float total = 0;

            total =(150 * tufee / 100) + hsfee;
            Console.WriteLine("The fees to be paid by the student is Rs."+total.ToString("0.00"));
        }

        private static void mgsds(float tufee, float busfee)
        {
            //150% of Tuition fee + Bus fee
            float total = 0;
            total= (150 * tufee / 100) + busfee;
            Console.WriteLine("The fees to be paid by the student is Rs."+total.ToString("0.00"));

        }

        private static void msh(float tufee, float hsfee)
        {
            //Tuition fee + Hostel fee
            float total = 0;
            total=tufee+hsfee;
            Console.WriteLine("The fees to be paid by the student is Rs." + total.ToString("0.00"));

        }

        public static void msds(float tufee, float busfee)
        {
            //Tuition fee + Bus fee
            float total = 0;
            total = tufee + busfee;
            Console.WriteLine("The fees to be paid by the student is Rs." +total.ToString("0.00"));

        }
    }
}
