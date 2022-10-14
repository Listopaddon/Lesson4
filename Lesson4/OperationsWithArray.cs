using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class OperationsWithArray
    {
        int rows = 2;
        int columns = 2;
        int[,] matrix;


        //int[,] matrix = new int[rows,columns] почему при инициализации строк и столбцов
        // требует что бы они были статическими
        // (на одинаковое имя не обращайте внимания)


        public OperationsWithArray()
        {
            matrix = new int[rows, columns];
        }
        public OperationsWithArray(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new int[rows, columns];
        }

        public int SearchPositiveNumbers()
        {
            int result = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        public int SearchNegativeNumbers()
        {
            int result = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        result++;
                    }
                }
            }

            return result;
        }

        public void SortArrayAscending()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = j + 1; k < columns; k++)
                    {
                        if (matrix[i, j] > matrix[i, k])
                        {
                            int temporary = matrix[i, j];
                            matrix[i, j] = matrix[i, k];
                            matrix[i, k] = temporary;
                        }
                    }
                }
            }
        }

        public void SortArrayDescending()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = j + 1; k < columns; k++)
                    {
                        if (matrix[i, j] < matrix[i, k])
                        {
                            int temporary = matrix[i, j];
                            matrix[i, j] = matrix[i, k];
                            matrix[i, k] = temporary;
                        }
                    }
                }
            }
        }

        public void FillingArrayRandom()
        {
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(-10, 30);
                }
            }
        }

        public void FillingArrayManually()
        {

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Enter your number - ");
                    string enterNumber = Console.ReadLine();
                    if (int.TryParse(enterNumber, out int numberCheck))
                    {
                        int number = int.Parse(enterNumber);
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine("!!!!Wrong Number!!!!");
                    }
                }
            }
        }

        public void InversionArray()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns / 2; j++)
                {
                    int temporary = matrix[i, j];
                    matrix[i, j] = matrix[i, columns - (1 + j)];
                    matrix[i, columns - (1 + j)] = temporary;
                }
            }

        }

        public void OutputMatrix()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(" " + matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
