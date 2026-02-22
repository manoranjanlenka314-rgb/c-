namespace Properties
{
    internal class Car
    {
        private string? Make;
        private string? Model;
        private int Year;
        public string Make1
        {
            get { return Make!; }
            set { Make = value; }
        }
        public string Model1
        {
            get { return Model!; }
            set { Model = value; }
        }
        public int Year1
        {
            get { return Year; }
            set { Year = value; }
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Car Make: {Make}, \nModel: {Model}, \nYear: {Year}");
        }


    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Make1 = "Toyota";
            car.Model1 = "Camry";
            car.Year1 = 2020;
            car.DisplayInfo();
            Console.ReadLine();
        }
    }
}
