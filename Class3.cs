namespace Properties
{
    internal class Class3
    {
        private int ID;
        private string? Name;
        private int Price;
      

        public int id
        {
            get  {return ID; }
            set { ID = value; }
        }
        public string? name
        {
            get { return Name; }
            set { Name = value; }

        }
        public int price
        {
            get { return Price; }
            set { Price = value; }
        }
        public void Display()
        {
            Console.WriteLine($"ID:{ID}");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);
        }

    }
    public class MAin
    {
          static void Main()
        {
            Class3 obj = new Class3();
            obj.id = 101;
            obj.name = "Laptop";
            obj.price = 50000;
            obj.Display();
        }
    }
}
