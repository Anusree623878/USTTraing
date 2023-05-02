using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailFolferRequirment2
{
    public class Mail
    {

        long _id;
        string _to;
        string _from;
        string _subject;
        string _content;
        DateTime _receivedDate;
        double _size;
        private long v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;
        private string v6;

        // properties
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string To
        {
            get { return _to; }
            set { _to = value; }
        }
        public string From
        {
            get { return _from; }
            set { _from = value; }
        }
        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
        public DateTime ReceivedDate
        {
            get { return _receivedDate; }
            set { _receivedDate = value; }
        }
        public double Size
        {
            get { return _size; }
            set { _size = value; }
        }

        // zero argument  Constructor
        public Mail() { }

        // parameterized constructor
        public Mail(long _id, string _from, string _to, string _subject, string _content, DateTime _receivedDate, double _size)
        {
            this._id = _id;
            this._from = _from;
            this._to = _to;
            this._subject = _subject;
           this._content = _content;
           this._receivedDate = _receivedDate;
            this._size = _size;
        }

        

        // Overriding toString Method
        public override string ToString()
        {

            //Console.WriteLine("{0} {1,15} {2,15} {3,15}{4,15}{5,15}{6,15}",Id,To,From,Subject,Content,ReceivedDate,Size);
            return string.Format("Id:{0} \n To:{1}\n From: {2}\n Subject:{3} \n Content:{4} \nReceivedDate:{5}" +
                "\n Size:{6}\n", _id, _to, _from, _subject, _content, _receivedDate.ToString("dd-mm-yyyy", null), _size.ToString("0.0"));
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Mail otherMail = obj as Mail;


            return _to.Equals(otherMail._to) &&
                _from.Equals(otherMail._from) &&
                _subject.Equals(otherMail._subject);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static Mail CreateMail(String detail)
        {
            string[] maildetail=detail.Split(',');
            DateTime dt = DateTime.ParseExact(maildetail[5],"dd-mm-yyyy", null);
            Mail mail = new Mail(long.Parse(maildetail[0]), maildetail[1], maildetail[2], maildetail[3], maildetail[4], dt,double.Parse(maildetail[6]));
           
            return mail;
        }
    }
}
