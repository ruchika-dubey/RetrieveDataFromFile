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
            if (File.Exists(filename))
            {
                Console.WriteLine("File exists");
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }

            StreamWriter wrt = File.CreateText(filename);
            wrt.WriteLine("Ruchika,21,ETC.");
            wrt.WriteLine("Prateek,23,CS.");
            wrt.WriteLine("Pragya,21,IT.");
            wrt.WriteLine("Nidhi,23,ETC.");
            wrt.WriteLine("Mayank,21,ETC.");
            wrt.WriteLine("Pritika,20,CS.");
            wrt.WriteLine("Kishwar,21,IT.");

            wrt.Close();
            Console.WriteLine("Content lines have been added into file");
            
        }

        private static void ReadLine()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\dataLine.txt";
            if (File.Exists(filename))
            {
                Console.WriteLine("File exists");
                string[] contents = File.ReadAllLines(filename);
                


                    foreach (var content in contents)
                {
                    Console.Write("Name:");
                    int i;
                    for (i = 0; content[i] != ','; i++)
                    {
                        if (content[i] != ',')
                        {
                            Console.Write(content[i]);

                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.Write(" Age:");
                    for (i++; content[i] != ','; i++)
                    {
                        if (content[i] != ',')
                        {
                            Console.Write(content[i]);

                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.Write(" Dept:");
                    for (i++; content[i] != '.'; i++)
                    {
                        if (content[i] != '.')
                        {
                            Console.Write(content[i]);

                        }
                        else
                        {
                            break;
                        }

                    }
                    Console.Write("\n");
                }
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
        }


       

    }
}
