using System;

namespace RetrieveDataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Retrieve Student Data from a Text File*****");
            FileProg.Do();
            string input;
            do
            {
                Console.WriteLine("*****Available Options*****");
                Console.WriteLine("1.Show Sorted Data\n2.Search By Name");
                int option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    FileProg.SortByName();
                    
                }
                else
                {
                    Console.WriteLine("Input name ");
                    FileProg.SearchByName(Console.ReadLine());
                }
                Console.WriteLine("Want to continue?(Type yes/no)");
                input = Console.ReadLine();

            } while (input.Equals("yes"));

        }
    }
}
