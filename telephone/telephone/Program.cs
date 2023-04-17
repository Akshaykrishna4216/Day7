using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telephone
{
    class Telephone
    {
        
        protected string _phonetype;
        public string Phonetype
        {
            get { return _phonetype; }
            set { _phonetype = value; }
        }
        public Telephone()
        {

        }
        public Telephone(string phonetype)
        {
            _phonetype = phonetype;
        }
        public void Ring()
        {
            Console.WriteLine("Ringing the " + _phonetype);
        }
        class Electronicphone : Telephone
        {
            public Electronicphone()
            {
                 _phonetype = "Digital";
            }
            
            public void Run()
            {
                Ring();
            }

        }

        public class Program
        {
            static void Main(string[] args)
            {
                Electronicphone phn = new Electronicphone();
                phn.Run();
            }
        }
    }
}

