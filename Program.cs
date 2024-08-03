namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
            int[] arrSort = new int[arr.GetLength(0) * arr.GetLength(1)];
            var k = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arrSort[k++] = arr[i, j];
                }
            }
            Array.Sort(arrSort);
            k = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = arrSort[k++];
                    Console.Write(arr[i, j]);
                }
                Console.WriteLine();
            }  
        }
    }
}