namespace RazorDemoExample.Models
{
    public class People
    {
        List<People> peoples = new List<People>();
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        } 

        public People() { } 
        public People(string name)
        {
            this.name = name;
        }
    }
}
