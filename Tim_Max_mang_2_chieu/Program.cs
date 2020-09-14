using System;

namespace Tim_Max_mang_2_chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[100, 100];
            int d, c;
            do
            {
                Console.WriteLine("Nhap so dong: ");
                d = int.Parse(Console.ReadLine());
                if (d <= 0)
                {
                    Console.WriteLine("So dong khong hop le, hay nhap lai.");
                }
            } while (d <= 0);
            do
            {
                Console.WriteLine("Nhap so cot: ");
                c = int.Parse(Console.ReadLine());
                if (c <= 0)
                {
                    Console.WriteLine("So cot khong hop le, hay nhap lai.");
                }
            } while (c <= 0);
            Nhapmang(ref A, ref d, ref c);
            Xuatmang(A, d, c);
            int Max = max(A, d, c);
            Console.WriteLine("Phan tu lon nhat la {0} ", Max);
            Console.ReadLine();
        }
        static void Nhapmang(ref int[,] A, ref int d, ref int c)
        {
            for (int i = 0; i < d * c; i++)
            {
                Console.Write("Nhap theo thu tu tu dong toi cot [{0}][{1}] :", i / c, i % c);
                A[i / c, i % c] = int.Parse(Console.ReadLine());
            }
        }
        static void Xuatmang(int[,] A, int d, int c)
        {
            for (int i = 0; i < d * c; i++)
            {
                Console.Write("{0}    ", A[i / c, i % c]);
                if ((i + 1) % c == 0)
                {
                    Console.Write("\n");
                }
            }
        }

        static int max(int[,] A, int d, int c)
        {
            int max = A[0, 0];
            for (int i = 0; i < d * c; i++)
            {
                if (max < A[i / c, i % c])
                {
                    max = A[i / c, i % c];
                }
            }
            return max;
        }
    }
}
