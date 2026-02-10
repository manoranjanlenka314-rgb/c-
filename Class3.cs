using System.ComponentModel;

namespace Interface
{
    public class Calculato

    {
        public int AddingNewEventArgs(int a, int b)
        {
          return a + b;
        }
        public int AddingNewEventArgs(int a, int b,int c)
        {
            return a + b + c;
        }

        static void Main()
        {
            Calculato m1=new Calculato();
            Console.WriteLine("add " +  m1.AddingNewEventArgs(1,2));
            Console.WriteLine("add " +  m1.AddingNewEventArgs(1, 2,3));
        }

    }
}
