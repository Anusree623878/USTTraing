

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPoolingSystem_Requirment2
{
    public class MemberCar
    {

        private long _id;
        public long Id {
            get { return _id; } 
            set { _id = value; } 
        }

        private Member _member;
        public Member Member { 
            get { return _member; }
            set { _member = value; }

        }

        private Car _car;
        public Car Car { 
            get { return _car; } 
            set {  _car = value; }
        }

        private string _carRegistrationNumber;
        public string CarRegistrationNumber
        {
            get { return _carRegistrationNumber; }
            set
            {
                _carRegistrationNumber = value;
            }
        }

        private string _carColor;
        public string CarColor
        {
            get { return _carColor; }
            set
            {
                _carColor = value;
            }
        }
        private List<MemberCar> _membercarlist;
        public List<MemberCar> Membercarlist
        {
            get { return _membercarlist; }
            set { _membercarlist = value; }
        }
        public MemberCar()
        {
            _membercarlist = new List<MemberCar>();
        }

       

        public MemberCar(long _id,Member member,Car _car,string _carRegistrationNumber,string _carColor) 
        {
            Id = _id;
            Member = member;
            Car = _car;
            CarRegistrationNumber= _carRegistrationNumber;
            CarColor= _carColor;
        }


    }
}
