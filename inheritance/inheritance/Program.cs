using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace inheritance
{
    class Fruit
    {
        


        private int _num;
        public int Num
        {
            get
            {
                return _num;
            }
            set
            {
                _num = value;
            }
        }
        
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
            
            public Fruit()
        {

        }
        public Fruit(int Num,string Name) 
        {
            _num = Num;
            _name = Name;
        }
        public void display()
        {
            Console.WriteLine("fruit no" + _num);
            Console.WriteLine("fruit name" + _name);
        }
    }
         class Orange:Fruit
        {
        string[] origin = { "maharashtra", "telangana", "himachal" };
        private string _origin;
        public string Origin
        {
            get { return _origin; }
        set {
                if (Array.BinarySearch(origin, value) >= 0)
                    _origin = value;
                else
                    Console.WriteLine("invalid");
            }
            

        }
       
        
    public Orange()
    {

    }
        public Orange(int  Num,string Name,string origin):base(Num,Name)
        {
            _origin = origin;
        }
        public new void display()
        {
            Console.WriteLine("fruit no" + Num);
            Console.WriteLine("fruit name" + Name);
            Console.WriteLine("fruit origin" + Origin);
           

        }

}
internal class program
        {

            static void Main(string[] args)
            {
            Orange O = new Orange(11, "apple", "kerala");
            O.display();
            }
        }
    }

