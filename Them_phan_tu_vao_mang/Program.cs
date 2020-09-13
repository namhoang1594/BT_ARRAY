using System;

namespace Them_phan_tu_vao_mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 4, 6, 7, 8, 0, 0, 0, 0, 0 };
            int x, k;
            Nhapvt(array, out x, out k);
            Console.WriteLine("Mang truoc khi chen la: ");
            HienMang(array);
            Chen(array, x, k);
            Console.WriteLine("Mang sau khi chen la: ");
            HienMang(array);
        }

        private static void Chen(int[] array, int x, int k)
        {
            for (int i = array.Length - 1; i > k; i--)
            {
                array[i] = array[i - 1];
            }
            array[k] = x;
        }

        static void HienMang(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        static void Nhapvt(int []array, out int x, out int k)
        {
            Console.WriteLine("Nhap x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap vi tri index k can chen: ");
            k = Convert.ToInt32(Console.ReadLine());
            if ((k <= 1) && (k >= array.Length -1))
            {
                Console.WriteLine("Khong chen duoc phan tu");
            }

        }
    }
}
