using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOALD
{
    class Program
    {
        static void Main(string[] args)
        {
            string _val = "";
            Console.Write("input N Number: ");
            ConsoleKeyInfo key;
            StringBuilder sb1 = new StringBuilder();
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    //double val = 0;
                    //bool _x = double.TryParse(key.KeyChar.ToString(), out val);
                    if (char.IsNumber(key.KeyChar))
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
            int Lenth = Convert.ToInt32(_val);
            int a = 5;
            int b = 6;
            string result = "";
            int calculate = 0;
            for (int i = 0; i < Lenth; i++)
            {
                if (i < 7)
                {
                    result = i.ToString();
                }
                else
                {
                    calculate = i % a;
                    if (calculate == 0)
                    {
                        result = "IDIC";
                    }
                    else
                    {
                        calculate = i % b;
                        if (calculate == 0)
                        {
                            result = "LPS";
                        }
                        else
                        {
                            result = i.ToString();
                        }
                    }
                }

                sb1.Append($" {result},");

            }

            Console.WriteLine(sb1.ToString());

            Console.ReadLine();
        }
    }
}
