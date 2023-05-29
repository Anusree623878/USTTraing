using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingchng_qstn1Abstract
{
    public abstract class Book

    {

        protected string title;

        public string Title

        {

            get { return title; }

            set { title = value; }

        }

        public abstract void setTitle(string s);

        public string getTitle()

        {

            return title;

        }

    }
}
