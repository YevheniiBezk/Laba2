using Laba2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Введіть кількість комп'ютерів: ");
            int cntComputer = int.Parse(Console.ReadLine());
            Computer[] arrComputer = new Computer[cntComputer];

            for (int i = 0; i < cntComputer; i++)
            {
                Console.WriteLine($"\nВведення даних для комп'ютера #{i + 1}");

                Console.Write("Введіть бренд комп'ютера: ");
                string brand = Console.ReadLine();

                Console.Write("Введіть модель комп'ютера: ");
                string model = Console.ReadLine();

                Console.Write("Введіть процесор: ");
                string processor = Console.ReadLine();

                Console.Write("Введіть об'єм оперативної пам'яті (ГБ): ");
                string sRAM = Console.ReadLine();

                Console.Write("Введіть об'єм накопичувача (ГБ): ");
                string sStorage = Console.ReadLine();

                Console.Write("Введіть ціну (у доларах): ");
                string sPrice = Console.ReadLine();

                Console.Write("Чи має комп'ютер дискретну відеокарту? (у-так, н-ні): ");
                ConsoleKeyInfo keyHasDedicatedGPU = Console.ReadKey();
                Console.WriteLine();

                Console.Write("Чи має комп'ютер сенсорний екран? (у-так, н-ні): ");
                ConsoleKeyInfo keyHasTouchscreen = Console.ReadKey();
                Console.WriteLine();

                arrComputer[i] = new Computer();
                arrComputer[i].Brand = brand;
                arrComputer[i].Model = model;
                arrComputer[i].Processor = processor;
                arrComputer[i].RAM = int.Parse(sRAM);
                arrComputer[i].Storage = int.Parse(sStorage);
                arrComputer[i].Price = double.Parse(sPrice);
                arrComputer[i].HasDedicatedGPU = keyHasDedicatedGPU.Key == ConsoleKey.Y ? true : false;
                arrComputer[i].HasTouchscreen = keyHasTouchscreen.Key == ConsoleKey.Y ? true : false;
            }
            Console.WriteLine("\nДані про всі комп'ютери:");
            Console.WriteLine("-------------------------");
            for (int i = 0; i < cntComputer; i++)
            {
                double pricePerGB = arrComputer[i].GetPricePerGB();
                Console.WriteLine($"\nКомп'ютер #{i + 1}");
                Console.WriteLine("Бренд: " + arrComputer[i].Brand);
                Console.WriteLine("Модель: " + arrComputer[i].Model);
                Console.WriteLine("Процесор: " + arrComputer[i].Processor);
                Console.WriteLine("Оперативна пам'ять: " + arrComputer[i].RAM + " ГБ");
                Console.WriteLine("Накопичувач: " + arrComputer[i].Storage + " ГБ");
                Console.WriteLine("Ціна: $" + arrComputer[i].Price.ToString("0.00"));
                Console.WriteLine(arrComputer[i].HasDedicatedGPU ? "Має дискретну відеокарту" : "Не має дискретної відеокарти");
                Console.WriteLine(arrComputer[i].HasTouchscreen ? "Має сенсорний екран" : "Не має сенсорного екрану");
                Console.WriteLine("Ціна за ГБ: $" + pricePerGB.ToString("0.00"));
            }

            Console.ReadKey();
        }
    }
}

