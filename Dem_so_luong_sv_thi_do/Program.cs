﻿using System;

namespace Dem_so_luong_sv_thi_do
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] array;
            do
            {
                Console.WriteLine("Enter a size:");
                size = Int32.Parse(Console.ReadLine());
                if (size > 30)
                    Console.WriteLine("Size should not exceed 30");

            } while (size > 30);
            //}
            //static void Nhap(int []array)
            //{
            array = new int[size];
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine("Enter a mark for student " + (i + 1) + ": ");
                array[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            //}
            //static int Hien(int []array)
            //{
            int count = 0;
            Console.WriteLine("List of mark: ");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j] + "\t");
                if (array[j] >= 5 && array[j] <= 10)
                    count++;
                //}
                //return count;
                Console.WriteLine("\n The number of students passing the exam is " + count);
            }
        }
    }
}
