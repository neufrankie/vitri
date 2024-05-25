﻿using System;

namespace dotnet_find_value_in_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Christian", "Michael", "Camila", "Sienna", "Tanya", "Connor", "Zachariah", "Mallory", "Zoe", "Emily" };
            Console.WriteLine("Nhap vao ten sinh vien ma ban muon tim kiem:");
            string input_name = Console.ReadLine();
            bool isExist = false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Equals(input_name))
                {
                    Console.WriteLine("Vi tri cua sinh vien " + input_name + " trong danh sach la: " + (i + 1));
                    isExist = true;
                    break;
                }
            }
            if (!isExist)
            {
                Console.WriteLine("Khong tim thay" + input_name + " trong danh sach.");
            }
        }
    }
}