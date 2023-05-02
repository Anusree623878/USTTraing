using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailFolderRequirment
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
        public Mail(long _id, string _to, string _from, string _subject, string _content, DateTime _receivedDate, double _size)
        {
            Id = _id;
           To = _to;
            From = _from;
            Subject = _subject;
            Content = _content;
            ReceivedDate = _receivedDate;
            Size = _size;
        }

        // Overriding toString Method
        public override string ToString()
        {
            return string.Format("Id:{0} \n To:{1}\n From: {2}\n Subject:{3} \n Content:{4} \nReceivedDate:{5}" +
                "\n Size:{6}\n",_id,_to, _from, _subject, _content, _receivedDate.ToString("dd-mm-yyyy",null), _size.ToString("0.0"));
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Mail otherMail = obj as Mail ;


            return _to.Equals(otherMail._to ) &&
                _from.Equals(otherMail._from) &&
                _subject.Equals(otherMail._subject);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }


    }
}
