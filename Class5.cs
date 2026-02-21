namespace Properties
{
    internal class Class5
    {
        private int ID;
        private string? Name;
        private double Salary;
        public int id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string? name
        {
            get { return Name; }
            set { Name = value; }
        }
        public double salary
        {
            get { return Salary; }
            set { Salary = value; }
        }
        public void Display()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Salary: " + Salary);
        }
    }
    public class Mainclass
    {
        static void Main()
        {
            Class5 emp = new Class5();
            emp.id = 1;
            emp.name = "John Doe";
            emp.salary = 75000.50;
            emp.Display();
        }
    }
}
