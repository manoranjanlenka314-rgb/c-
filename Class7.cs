using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSproject
{
    public  class Leela
    {
        public virtual void display()
        {
            Console.WriteLine("I am Leela from leela class.");
        }
    }
    public class Hemon : Leela
    {
        public void show()
        {
            Console.WriteLine("I am Hemon from Hemon class.");

        }
        public override void display()
        {
            Console.WriteLine("I am overridden display method from Hemon class.");
        }
        public static void Main(string[] args)
        {
            Hemon h = new Hemon();
            h.show();
            h.display();
            Leela l = new Leela();
            l.display();
            Leela le = new Hemon();
            le.display();
        }

    }
}
