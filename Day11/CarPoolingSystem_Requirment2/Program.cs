using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystem_Requirment2
{
    internal class Program
    {
        

       static  List<Member> memberList = new List<Member>();
        static List<Car> carList = new List<Car>();
        static List<MemberCar> membercarList = new List<MemberCar>();
        static void Main(string[] args)

        {
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add a Member:");
                Console.WriteLine("2. Add a Car");
                Console.WriteLine("3. Assign car to Member");
                Console.WriteLine("4.Cars Owned");
                Console.WriteLine("5.Exit");


                Console.WriteLine("Enter your choice:");
                choice=int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        AddMember();
                        break;
                    case 2:
                        AddCar();
                        break;
                    case 3:
                        AssignCar();
                        break;
                    case 4:
                        DisplayCarOwned();
                        break;
                    case 5:
                        Console.WriteLine("Exiting !!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
                Console.WriteLine();

            }while (choice!=0);

           
        }
        static void AddMember()
        {

            Console.WriteLine("Enter member Id:");
            int id=int.Parse(Console.ReadLine());


            Console.WriteLine("Enter Member First Name:");
            string fname = Console.ReadLine();


            Console.WriteLine("Enter Member Last Name:");
            string lname = Console.ReadLine();


            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();


            Console.WriteLine("Enter Contact Number:");
            string contactNo= Console.ReadLine();


            Console.WriteLine("Enter License number:");
            string licenseno = Console.ReadLine();


            Console.WriteLine("Enter License start date:");
            DateTime lsdt = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter License expiry date:");
            DateTime ledt = Convert.ToDateTime(Console.ReadLine());

            Member member = new Member(id,fname,lname,email,contactNo,licenseno,lsdt,ledt);
            
           memberList.Add(member);
            Console.WriteLine("member added successfullly");
        }
        static void AddCar()
        {
            Console.WriteLine("Id:");
            long id=int.Parse(Console.ReadLine());

            Console.WriteLine("name:");
            string cname = Console.ReadLine();

            Console.WriteLine("Model:");
            string model = Console.ReadLine();

            Console.WriteLine("Make year:");
            int makeyear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Company:");
            string company=Console.ReadLine();

            Console.WriteLine("Comfort level:");
            int comfortlevel=Convert.ToInt32(Console.ReadLine());

            Car car=new Car(id,cname,model,makeyear,company,comfortlevel);
            carList.Add(car); 
        }

        static void AssignCar()
        {
            Console.WriteLine("Member id:");
            long memberassignid= Convert.ToInt32(Console.ReadLine());
            Member membertoassign = Member.FindMember(memberassignid,memberList);
            if(membertoassign == null)
            {
                Console.WriteLine("Member not found");
            }

            Console.WriteLine("car Id:");
            long carassignno=Convert.ToInt32(Console.ReadLine());
            Car cartoassign = Car.FindCar(carassignno, carList);
            if(cartoassign == null)
            {
                Console.WriteLine("car not found");
            }

            Console.WriteLine("car registration number:");
            string carregno=Console.ReadLine();
            Console.WriteLine("car color:");
            string carcolor=Console.ReadLine();

            MemberCar membercar=new MemberCar(carassignno,membertoassign,cartoassign,carregno,carcolor);
            membercarList.Add(membercar);

            Console.WriteLine("car assigned successfully");
        }
        static void DisplayCarOwned()
        {
            Console.WriteLine("Enter the member id:");
            long memberid= Convert.ToInt32(Console.ReadLine());
            Member membertocheck = Member.FindMember(memberid, memberList);

            if(membertocheck == null)
            {
                Console.WriteLine("member not found");
            }

            foreach(Member m in memberList)
            {
                Console.WriteLine(m.ToString());
            }
        }







    }
}
