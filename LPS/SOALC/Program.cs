using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOALC
{
    class Program
    {
        static void Main(string[] args)
        {
            string _val = "";
            StringBuilder sb1 = new StringBuilder();
            Console.Write("input kata: ");
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    _val += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
            }
            while (key.Key != ConsoleKey.Enter);


            Console.WriteLine();
            _val = _val.Replace(" ", "");
            int Lenth = _val.Length;
            List<string> alphabet = new List<string>();
            List<string> alphabet2 = new List<string>();
            for (int i = 0; i < Lenth; i++)
            {
                var data = _val[i].ToString().ToLower();
                alphabet2.Add(data);
                alphabet2.Remove("\r");
            }
            for (int i = 0; i < Lenth; i++)
            {
                var data = _val[i].ToString().ToLower();
                int cek = alphabet.Where(x => x == data).Count();
                if(cek < 1)
                {
                    int cnt = alphabet2.Where(x => x == data).Count();
                    if (cnt > 0)
                    {
                        alphabet.Add(data);
                        var ConcateData = data + "-" + alphabet2.Where(x => x == data).Count().ToString();
                        sb1.AppendLine($" {ConcateData}");
                    }
                 
                }
            }
            Console.WriteLine(sb1.ToString());

            Console.ReadLine();

        }
    }
}
