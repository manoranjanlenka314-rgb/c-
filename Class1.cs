using System.Collections;   // Needed for ArrayList
namespace Collection
{
    class StudentListProgram
    {
        static void Main()
        {
            // Create an ArrayList to store student names
            ArrayList students = new ArrayList();

            // Accept 5 student names from the user
            Console.WriteLine("Enter 5 student names:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter name " + (i + 1) + ": ");
                string name = Console.ReadLine();
                students.Add(name);
            }

            // Display all student names entered
            Console.WriteLine("\nList of Students:");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            // Ask the user to enter a name to search
            Console.Write("\nEnter a name to search: ");
            string searchName = Console.ReadLine();

            int index = students.IndexOf(searchName);
            if (index != -1)
            {
                Console.WriteLine($"Student {searchName} found at index {index}");
            }
            else
            {
                Console.WriteLine($"Student {searchName} not found");
            }

            // Ask the user to enter a name to remove
            Console.Write("\nEnter a name to remove: ");
            string removeName = Console.ReadLine();

            if (students.Contains(removeName))
            {
                students.Remove(removeName);
                Console.WriteLine($"{removeName} removed successfully!");
            }
            else
            {
                Console.WriteLine($"{removeName} not found in the list!");
            }

            // Display the updated list
            Console.WriteLine("\nUpdated Student List:");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
