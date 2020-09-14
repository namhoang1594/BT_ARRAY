using System;

namespace Tong_duong_cheo_ma_tran_vuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n, s=0;
            int[,] mang1 = new int[50, 50];
            Console.Write("Nhap kich thuoc ma tran vuong: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap cac phan tu cua ma tran:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Phan tu - [{0}],[{1}]: ", i, j);
                    mang1[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (i == j) s = s + mang1[i, j];
                }
            }

            Console.Write("In ma tran:\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0} ", mang1[i, j]);
                Console.Write("\n");
            }

            Console.Write("Tong cac phan tu tren duong cheo chinh cua ma tran la: {0}\n", s);
            Console.ReadKey();
        }
    }
}
