using System;
using System.Collections.Generic;

namespace Q54_Spiral_Matrix_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public void Debug(IList<int> spiralOrder)
        {
            foreach(var n in spiralOrder)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine("--------------------------------------------------------------------------");
        }

        public class Point
        {
            public int Row { get; set; }
            public int Col { get; set; }
        }

        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> spiralOrder = new List<int>();
            Point top_left = new Point();
            Point top_right = new Point();
            Point bottom_right = new Point();
            Point bottom_left = new Point();
            int regtangle_width = matrix[0].Length;
            int regtangle_height = matrix.Length;
            int top_left_index = 0;

            while (regtangle_width > 0 && regtangle_height > 0)
            {
                // 計算當前矩形的四個頂點
                top_left.Row = top_left_index;
                top_left.Col = top_left_index;

                top_right.Row = top_left.Row;
                top_right.Col = top_left.Col + regtangle_width - 1;

                bottom_right.Row = top_right.Row + regtangle_height - 1;
                bottom_right.Col = top_right.Col;

                bottom_left.Row = bottom_right.Row;
                bottom_left.Col = top_left.Col;

                // 沿著矩形的最上方往右走
                for (int i = top_left.Col; i <= top_right.Col; i++)
                {
                    spiralOrder.Add(matrix[top_left.Row][i]);
                }

                // 沿著矩形的最右方往下走
                for (int i = top_right.Row+1; i <= bottom_right.Row; i++)
                {
                    spiralOrder.Add(matrix[i][top_right.Col]);
                }

                // 沿著矩形的最下方往左走(注意，若高度只有1，則往左走會重複經過已拜訪的元素)
                if(regtangle_height > 1)
                {
                    for (int i = bottom_right.Col - 1; i >= bottom_left.Col; i--)
                    {
                        spiralOrder.Add(matrix[bottom_right.Row][i]);
                    }
                }

                // 沿著矩形的最左方往上走(注意，若寬度只有1，則往上走會重複經過已拜訪的元素)
                if (regtangle_width > 1)
                {
                    for (int i = bottom_left.Row - 1; i > top_left.Row; i--)
                    {
                        spiralOrder.Add(matrix[i][bottom_left.Col]);
                    }
                }

                // 將左上的頂點往內層移動 & 取得往內一層矩形的寬與高
                top_left_index++;
                regtangle_width -= 2;
                regtangle_height -= 2;
            }
            return spiralOrder;
        }
    }
}
