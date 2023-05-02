using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystem_Requirment1
{
   public class Member
    {
        long _id;
        public long Id 
        {   get { return _id;}
            set { _id = value; }
        }

        string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

         string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }

        string _contactNumber;
        public string ContactNumber
        {
            get { return _contactNumber; }
            set
            {
                _contactNumber = value;
            }
        }

        string _licenseNumber;
        public string LicenseNumber
        {
            get { return _licenseNumber; }
            set
            {
                _licenseNumber = value;
            }
        }

        DateTime _licenseStartDate;
        public DateTime LicenseStartDate
        {
            get { return _licenseStartDate; }
            set
            {
                _licenseStartDate = value;
            }
        }
        DateTime _licenseExpiryDate;
        public DateTime LicenseExpiryDate
        {
            get { return _licenseExpiryDate; }
            set
            {
                _licenseExpiryDate = value;
            }
        }



        

        public Member() { }
        public Member(long _id, string _firstName, string _lastName, string _email, string _contactNumber, string _licenseNumber, DateTime _licenseStartDate,DateTime _licenseExpiryDate)
        {
            Id = _id;
            FirstName = _firstName;
            LastName = _lastName;
            Email = _email;
            ContactNumber = _contactNumber;
            LicenseNumber = _licenseNumber;
            LicenseStartDate = _licenseStartDate;
            LicenseExpiryDate = _licenseExpiryDate;
          
        }

        public  override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Member other=(Member)obj;
            return Email.ToLower()== other.Email.ToLower() && ContactNumber.ToLower() == other.ContactNumber.ToLower();
        }

        public override string ToString()
        {
            return string.Format("Member:{0},{1}\n Member contact details: {2},{3}",_firstName,_lastName,_contactNumber,_email);
        }
       public override int GetHashCode()
        {
            return Id.GetHashCode();
        }


        public static  Member FindMember(Member Id)
        {

            return null;
        }

    }
}
