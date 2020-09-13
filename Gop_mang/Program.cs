using System;

namespace Gop_mang
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mang1 = new int[100];
            int[] mang2 = new int[200];
            int[] mang3 = new int[300];
            int a1, a2, a3;
            int i, j, k;
            //Console.Write("Nhap so luong phan tu mang 1: ");
            //a1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap {0} phan tu vao trong mang 1: \n", a1);
            //Nhapmang1(mang1, a1);
            //Console.Write("Nhap so luong phan tu mang 2: ");
            //a2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Nhap {0} phan tu vao trong mang 1: \n", a2);
            //Nhapmang2(mang2, a2);
            //Ghepmang(mang3,mang2,mang1,i,a1,a2,a3,j,k);
            //Mang3(mang3,a3);
            Console.Write("Nhap so luong phan tu mang 1: ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap {0} phan tu vao trong mang 1: \n", a1);
            for (i = 0; i < a1; i++)
            {
                Console.Write("Phan tu {0}: ", i);
                mang1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Nhap so luong phan tu mang 2: ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap {0} phan tu vao trong mang 1: \n", a2);
            for (i = 0; i < a2; i++)
            {
                Console.Write("Phan tu {0}: ", i);
                mang2[i] = Convert.ToInt32(Console.ReadLine());
            }

            a3 = a1 + a2;
            for (i = 0; i < a1; i++)
            {
                mang3[i] = mang1[i];
            }
            for (j = 0; j < a2; j++)
            {
                mang3[i] = mang2[j];
                i++;
            }
            for (i = 0; i < a3; i++)
            {
                for (k = 0; k < a3 - 1; k++)
                {

                    if (mang3[k] >= mang3[k + 1])
                    {
                        j = mang3[k + 1];
                        mang3[k + 1] = mang3[k];
                        mang3[k] = j;
                    }
                }
            }
            Console.WriteLine("Mang thu 3: ");
            for (i = 0; i < a3; i++)
            {
                Console.Write("Cac phan tu la {0} ", mang3[i]);
            }
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
//        static void Nhapmang1(int []mang1, int a1)
//        {
//            for (int i = 0; i < a1; i++)
//            {
//                Console.Write("Phan tu {0}: ", i);
//                mang1[i] = Convert.ToInt32(Console.ReadLine());
//            }
//        }
//        static void Nhapmang2(int[] mang2, int a2)
//        {
//            for (int i = 0; i < a2; i++)
//            {
//                Console.Write("Phan tu {0}: ", i);
//                mang2[i] = Convert.ToInt32(Console.ReadLine());
//            }
//        }
//        static void Ghepmang(int []mang1, int[] mang2, int []mang3, int i, int a1, int a2, int a3, int k, int j)
//        {
//            a3 = a1 + a2;
//            for (i = 0; i < a1; i++)
//            {
//                mang3[i] = mang1[i];
//            }
//            for (j = 0; j < a2; j++)
//            {
//                mang3[i] = mang2[j];
//                i++;
//            }
//            for (i = 0; i < a3; i++)
//            {
//                for (k = 0; k < a3 - 1; k++)
//                {

//                    if (mang3[k] >= mang3[k + 1])
//                    {
//                        j = mang3[k + 1];
//                        mang3[k + 1] = mang3[k];
//                        mang3[k] = j;
//                    }
//                }
//            }
//        }
//        static void Mang3(int []mang3, int a3)
//        {
//            Console.WriteLine("Mang thu 3: ");
//            for (int i = 0; i < a3; i++)
//            {
//                Console.Write("Cac phan tu la {0} ", mang3[i]);
//            }
//            Console.WriteLine("");
//        }
//    }
//}
