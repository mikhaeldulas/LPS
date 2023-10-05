using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOALE
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
            string result = "";

            string FormatBiasa = "Format Biasa :";
            string FormatJudul = "Format Judul :";

            List<string> listWord = new List<string>();
            List<string> listWordeveryword = new List<string>();
            List<string> listWordfirstword = new List<string>();
            listWord.AddRange(_val.Split(' '));
            foreach (var item in listWord)
            {
                var kata = item.ToLower();
                var kata_true = string.Format("{0}{1}", char.ToUpper(kata[0]), kata.Remove(0, 1));
                listWordeveryword.Add(kata_true);
                int cnt = listWordfirstword.Count();
                if(cnt < 1)
                {
                    listWordfirstword.Add(kata_true);
                }
                else
                {
                    listWordfirstword.Add(kata);
                }
            }
            //list.AddRange(myStringTwo.Split(' '));
            result =FormatJudul +  string.Join(" ", listWordeveryword);
            sb1.AppendLine($" {result}");
            result = FormatBiasa + string.Join(" ", listWordfirstword);
            sb1.AppendLine($" {result}");
            Console.WriteLine(sb1.ToString());

            Console.ReadLine();
        }
    }
}
