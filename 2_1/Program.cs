using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = File.ReadAllLines("file.txt");
            string[] textOut = new string[text.Length];
            for (int i=0;i<text.Length;i++)
            {
                string[] textI = text[i].Split();
                textI[0] = textI[0]+"?";
                for (int j =0;j<textI.Length;j++)
                {
                    textOut[i] = textOut[i] + textI[j] + " ";
                }
                Console.WriteLine(textOut[i]);
            }
            Console.ReadLine();    
        }
    }
}
