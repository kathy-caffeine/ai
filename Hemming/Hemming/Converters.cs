using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemming
{
    static internal class Converters
    {
        public static double[] DoubleArray(int[,] input)
        {
            int rowsAmount = input.GetLength(0);
            int columnsAmount = input.GetLength(1);
            double[]letter = new double[rowsAmount * columnsAmount];

            for (int i = 0; i < rowsAmount; i++)
                for (int j = 0; j < columnsAmount; j++)
                    letter[i * columnsAmount + j] = input[i, j];

            return letter;
        }

        public static int[,] IntMatrix(double[] letterColumn, 
            int rowsAmount, int columnsAmount)
        {
            int[,] let = new int[rowsAmount, columnsAmount];
            for (int i = 0; i < rowsAmount; i++)
            {
                for (int j = 0; j < columnsAmount; j++)
                    let[i, j] = (int)letterColumn[i * columnsAmount + j];
            }
            return let;
        }
    }
}
