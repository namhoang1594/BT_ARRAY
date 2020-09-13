using System;

namespace Xoa_phan_tu_khoi_mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 4, 6, 7, 8, 0, 0, 0, 0, 0 };
            int x;
            Console.WriteLine("Mang truoc khi xoa la: ");
            HienMang(arr, arr.Length);
            Nhapx(out x, arr.Length);
            Xoa(arr, x);
            Console.WriteLine("Mang sau khi xoa la: ");
            HienMang(arr, arr.Length - 1);
        }
        static void Nhapx(out int x, int n)
        {
            x = -1;
            while (x < 0 || x >= n)
            {
                Console.WriteLine("Nhap tu x co trong mang: ");
                x = Convert.ToInt32(Console.ReadLine());
            }
        }
        static bool Xoa(int[] arr, int k)
        {
            bool vt = false;
            for (int i = 0; i < arr.Length; ++i)
            {
                if (vt)
                {
                    arr[i - 1] = arr[i];
                }
                else if (arr[i] == k)
                {
                    int index = i;
                    Console.WriteLine("Vi tri cua phan tu x la: {0}", index);
                    vt = true;
                }
            }
            return vt;
        }
        static void HienMang(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
