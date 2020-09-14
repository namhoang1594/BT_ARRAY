using System;

namespace Dem_so_lan_xuat_hien_ki_tu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "a", "b", "c", "c", "c", "d", "d", "e" };
            Mang(s);
            Console.WriteLine("Nhap ki tu bat ky co trong mang: ");
            string x = Console.ReadLine();
            Console.WriteLine("So lan xuat hien cua ki tu {0} la :",x);
            dem(s, x);

        }
        static void Mang(string[] str)
        {
            for (int i=0; i<str.Length;i++)
            {
                Console.Write(str[i] + " ");
            }
            Console.WriteLine();
        }
        static void dem(string[] str, string n)
        {
            int d = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == n)
                    d++;

            }
            Console.WriteLine(d);
        }
    }
}
