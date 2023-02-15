using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HopfieldApp
{
    class Hopfield
    {
        // 1 - black; -1 - white
        static int amount = 4, power = 12;
        public int[] input = Enumerable.Repeat(1, power).ToArray();
        public int[,] known = {
            { -1,-1,-1,1,1,1,-1,1,-1,-1,1,-1}, // T
            { 1, 1, 1, 1, -1, -1, 1, -1, -1, 1, -1, -1},  // Г
            {1,1,-1,1,-1,1,1,1,-1,1,-1,-1 }, // Р
            {-1,1,-1,1,-1,1,1,1,1,1,-1,1 } // A
        };
        int[,] weight = new int[power, power];
        int[,] tm = new int[power, power];
        public Hopfield(){}

        public int getAmount() { return amount; }
        public int getPower() { return power; }

        public int recognition()
        {
            // Проверить, не равен ли инпут какому-нибудь эталону
            bool crunch = true;
            for(int i = 0; i<amount; i++)
            {
                for(int j = 0; j<power; j++)
                {
                    if (input[j] != known[i, j])
                    {
                        crunch = false;
                        break;
                    }
                }
                if (crunch) return i;
                else crunch = true;
            }
            // weights
            for (int k = 0; k < amount; k++)
            {
                for (int i = 0; i < power; i++)
                {
                    for (int j = 0; j < power; j++)
                    {
                        weight[i, j] += known[k, i] * known[k, j];
                    }
                }
            }
            
            for(int i = 0; i<power; i++)
            {
                weight[i, i] = 0;
            }

            int[] func = new int[power];
            crunch = false; 
            int counter = 0;
            int maxcount = 200;
            //int suitable = -1;//Индекс подходящей строки
            while (!crunch && counter < maxcount)
            {
                // вес умножаем на входной вектор
                for (int i = 0; i < power; i++)
                    for (int j = 0; j < power; j++)
                        func[i] += weight[i, j] * input[j];
                // обрабатываем полученный вектор 
                for (int i = 0; i < power; i++)
                    if (func[i] >= 0) func[i] = 1;
                    else func[i] = -1;
                // сравниваем
                bool st = false;
                for (int i = 0; i < amount; i++)
                {
                    st = true;
                    for (int j = 0; j < power; j++)
                        if (known[i, j] != func[j]) { st = false; break; }
                    if (st) { return i; }
                }
                counter++; // счетчик глубины поиска
                // меняем инпут на функцию
                for (int i = 0; i < power; i++)
                    input[i] = func[i];
                //Обнуляем результирующий вектор
                for (int i = 0; i < power; i++)
                    func[i] = 0;
            }
            return -1;
        }
    }
}
