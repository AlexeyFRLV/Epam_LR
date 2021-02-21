using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace listingSCharp
{
    class Program
    {
        static void FileRead(string path, List<string[]> coordinates)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                {
                    int count = 0;
                    while (true)
                    {
                        if (!sr.EndOfStream)
                        {
                            coordinates.Add(new string[2]);
                            coordinates[count] = sr.ReadLine().Split(',');
                        }
                        else
                        {
                            break;
                        }

                        count++;
                    }
                    Console.WriteLine("The data obtained!");
                }
                fs.Close();
            }
        }

        static void FileWrite(string path, List<string[]> coordinates)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    foreach (string[] s in coordinates)
                    {
                        for (int i = 0; i < s.Length; i++)
                        {
                            char ch = i == 0 ? 'X' : 'Y';
                            sw.Write($"{ch}: {s[i].Replace('.', ',')} ");
                        }
                        sw.WriteLine();
                    }
                    Console.WriteLine("Information recorded!");
                }
                fs.Close();
            }
        }

        static void Main(string[] args)
        {
            string filePathBefore = "testBeforeCorrect.txt";
            string filePathAfter = "testAfterCorrect.txt";
            List<string[]> coordinates = new List<string[]>();
            try
            {
                FileRead(filePathBefore, coordinates);
                Console.WriteLine("To record information, press any key!");
                Console.ReadKey();

                FileWrite(filePathAfter, coordinates);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

