using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p511_oop

{
    public class Matrix
    {
        private readonly int[,] _data;
        public int Rows { get; }
        public int Cols { get; }

        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            _data = new int[rows, cols];
        }

        public int this[int i, int j]
        {
            get => _data[i, j];
            set => _data[i, j] = value;
        }

        public void ReadFromConsole()
        {
            Console.WriteLine($"Введите элементы матрицы {Rows}x{Cols}:");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write($"[{i},{j}]: ");
                    _data[i, j] = int.Parse(Console.ReadLine() ?? "0");
                }
            }
        }

        public void PrintToConsole()
        {
            Console.WriteLine("Матрица:");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write(_data[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public int Max()
        {
            int max = _data[0, 0];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (_data[i, j] > max)
                        max = _data[i, j];
                }
            }
            return max;
        }

        public int Min()
        {
            int min = _data[0, 0];
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (_data[i, j] < min)
                        min = _data[i, j];
                }
            }
            return min;
        }
    }
}
