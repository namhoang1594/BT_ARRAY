using System;

namespace Tong_cac_so_o_mot_cot
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
            Tong(A, d, c);
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
                Console.Write("{0}    ", A[i % c, i / c]);
                if ((i + 1) % c == 0)
                {
                    Console.Write("\n");
                }
            }
        }

        static void Tong(int[,] A, int d, int c)
        {
            int s = 0;
            for (int i = 0; i < c * c; i++)
            {
                s += A[i / c, i % c];
                if ((i + 1) % c == 0)
                {
                    Console.WriteLine("Nhap cot can tinh tong: ");
                    c = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Tong cot {0} la: {1}", i / c, s);
                    s = 0;
                    break;
                }
            }
        }
    }
}
