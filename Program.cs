namespace Hw1_C_
{
    class Program
    {
        static void Main()
        {
            string[,] array = {
            {"#", "@", "$"  },
            {"#", "@", "$" },
            {"#", "@", "$"}
        };
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            Console.WriteLine("Исходный массив:");
            Print(array);
            int col1 = 0, col2 = 2;
            Swap(array, col1, col2);
            Console.WriteLine("\nМассив после замены столбцов:");
            Print(array);
        }
        static void Swap(string[,] array, int col1, int col2)
        {
            int rows = array.GetLength(0);
            for (int i = 0; i < rows; i++)
            {
                string trash = array[i, col1];
                array[i, col1] = array[i, col2];
                array[i, col2] = trash;
            }
        }
        static void Print(string[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
