using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RetrieveDataFromFile
{
    class FileProg
    {
        public static void Do()
        { 
            WriteLine();
            ReadLine();
        }

        private static void WriteLine()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\dataLine.txt";

            StreamWriter wrt = File.CreateText(filename);
            wrt.WriteLine("Ruchika,ETC");
            wrt.WriteLine("Prateek,CS");
            wrt.WriteLine("Pragya,IT");
            wrt.WriteLine("Nidhi,ETC");
            wrt.WriteLine("Mayank,ETC");
            wrt.WriteLine("Pritika,CS");
            wrt.WriteLine("Kishwar,IT");

            wrt.Close();
            Console.WriteLine("*****Content lines have been added into file*****");

        }

        private static void ReadLine()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\dataLine.txt";
            if (File.Exists(filename))
            {
                string[] contents = File.ReadAllLines(filename);
                Console.WriteLine("*****Displaying contents in the file*****");
                Print(contents);
            }

            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }
        public static void SortByName()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\dataLine.txt";
            if (File.Exists(filename))
            {
               
                string[] contents = File.ReadAllLines(filename);
                Console.WriteLine("*****Sorting contents in the file by name*****");
                string temp;
                foreach (var content in contents)
                {

                    for (int j = 0; j < contents.Length - 1; j++)
                    {
                        if (contents[j + 1].CompareTo(contents[j]) < 0)
                        {

                            temp = contents[j];
                            contents[j] = contents[j + 1];
                            contents[j + 1] = temp;


                        }
                    }

                }
                Print(contents);
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }
        public static void SearchByName(string name)
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\dataLine.txt";
            if (File.Exists(filename))
            {
               
                string[] contents = File.ReadAllLines(filename);
 
                int flag = 0;
                foreach (var content in contents)
                {

                    if (content.Contains(name))
                    {
                        Console.WriteLine("*****data exists*****");
                        Console.Write("Name:");
                        int i;
                        for (i = 0; content[i] != ','; i++)
                            Console.Write(content[i]);
                        Console.Write(" Class:");
                        for (i++; i < content.Length; i++)
                            Console.Write(content[i]);


                        Console.Write("\n");
                        flag = 1;
                        break;
                    }
                   


                }
                if(flag==0)
                {
                    
                        Console.WriteLine("no data found corresponding to the Name!");
                    
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }

        }
        private static void Print(string[] contents)
        {
            foreach (var content in contents)
            {
                Console.Write("Name:");
                int i;
                for (i = 0; content[i] != ','; i++)
                    Console.Write(content[i]);
                Console.Write(" Class:");
                for (i++; i < content.Length; i++)
                    Console.Write(content[i]);


                Console.Write("\n");
            }

        }
    }
}
