using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Task2.Font_Adjustment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Font fnt = Font.None;
            Console.WriteLine("Вводите соответствующее число для установки и удаления параметра");
            while (true)
            {
                Console.WriteLine($"Параметры надписи: {fnt}");
                Console.WriteLine("Введите:");
                Console.WriteLine($"1: {Font.Bold}\n2: {Font.Italic}\n3: {Font.Underline}");


                if (int.TryParse(Console.ReadLine(), out num))
                {
                    switch (num)
                    {
                        case 1:
                            fnt ^= Font.Bold;
                            break;
                        case 2:
                            fnt ^= Font.Italic;
                            break;
                        case 3:
                            fnt ^= Font.Underline;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Число введено некорректно");
                }
            }



        }

        [Flags]
        enum Font
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 4,
        }
    }
}
