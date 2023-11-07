using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ElizarovKI.Sprint4.Task4.V12.Lib
{
    public class DataService : ISprint4Task4V12
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(1);
            int columns = matrix.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[j, i] % 2 == 0)
                    {
                        matrix[j, i] = 1;
                    }
                }
            }
            return matrix;
        }
    }
}
