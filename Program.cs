﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arts__HomeWork2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures = 52;
            int picturesInRow = 3;

            int rowCount = 52 / 3;
            int picturesOverRow = 52 % 3;

            Console.WriteLine("Количество рядов: " + rowCount);
            Console.WriteLine("Картинок сверх меры: " + picturesOverRow);
            Console.ReadKey();
        }
    }
}
