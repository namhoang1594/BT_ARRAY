using System;

namespace Tim_gia_tri_Min_trong_mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            Console.WriteLine("Enter a size:");
            size = Int32.Parse(Console.ReadLine());
            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Enter element" + (i + 1) + " : ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("Property list: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
            }
            int min = MinValue(array);
            Console.WriteLine("Phan tu nho nhat trong mang la :{0}", min);
        }
        public static int MinValue(int[] array)
            {

            int min = array[0];

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }

                return min;
            }
    }
}
