using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOALB
{
    class Program
    {

       
        static void Main(string[] args)
        {


            string _val = "";
            Console.Write("Enter your value: ");
            ConsoleKeyInfo key;
            StringBuilder sb1 = new StringBuilder();
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    //double val = 0;
                    //bool _x = double.TryParse(key.KeyChar.ToString(), out val);
                    if (char.IsNumber(key.KeyChar) || key.KeyChar == '.')
                    {
                        _val += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Backspace && _val.Length > 0)
                    {
                        _val = _val.Substring(0, (_val.Length - 1));
                        Console.Write("\b \b");
                    }
                }
            }
            while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();
            _val = _val.Replace(".", "");
            int Lenth = _val.Length;
            for (int i = 0; i < Lenth; i++)
            {
     
                var data = _val[i].ToString();
                var ConcateData = data +  String.Concat(Enumerable.Repeat("0", Lenth - (i+1)));
                sb1.AppendLine($" {ConcateData}");

            }

            Console.WriteLine(sb1.ToString());

            Console.ReadLine();
        }
    }
}
