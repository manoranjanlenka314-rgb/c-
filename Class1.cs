// Crate a Class Name "Iphone" should have the following Members:-
// Create an abstract Method:- Return Type : Void Name : DisplayFeatures()
// Accessmodifier : public Create a Child Class Name "Iphone15" That Inherits "Iphone" class, should have the following
// Members:- Instance Variables:- string Model,OS,Camera Generate a Default Constructor and Pass this default Values:-
// Model = "iPhone 15"; OS = "iOS 17"; Camera = "48 MP Main Camera"; Override the DisplayFeatures() Method and Print the values.
// Create a Main Class with name "Task":- create object for the Iphone15 class and call the DisplayFeatures() Method.

namespace ConsoleApp10
{
    internal abstract class Iphone
    {
        public abstract void DisplayFeatures();

        

    }
    internal class Iphone15 : Iphone
    {
        string Model;
        string OS;
        string Camera;
        public Iphone15()
        {
            Model = "iPhone 15";
            OS = "iOS 17";
            Camera = "48 MP Main Camera";
        }
        public override void DisplayFeatures()
        {
            Console.WriteLine($"Model: {Model}, OS: {OS}, Camera: {Camera}");
        }
    }
    internal class Task
    {
        static void Main(string[] args)
        {
            Iphone15 iphone15 = new Iphone15();
            iphone15.DisplayFeatures();
            Console.ReadLine();
        }
    }



}
