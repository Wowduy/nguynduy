using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();


        program.TinhTongMang();


        program.TimMaxTrongMang();


        program.DaoNguocChuoi();


        program.DemKyTuTrongChuoi();


        program.KiemTraMangDoiXung();
    }


    void TinhTongMang()
    {
        Console.WriteLine("nhap so phan tu:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("nhap cac phan tu:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += arr[i];
        }
        Console.WriteLine($"tong cac phan tu: {sum}");
    }


    void TimMaxTrongMang()
    {
        int[] a = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
        int max = a[0];
        for (int i = 0; i < a.Length; i++)
        {
            if (max < a[i])
            {
                max = a[i];
            }
        }
        Console.WriteLine($"phan tu lon nhat la: {max}");
    }


    void DaoNguocChuoi()
    {
        Console.WriteLine("nhap chuoi ki tu:");
        string input = Console.ReadLine();
        string reversedString = new string(input.Reverse().ToArray());
        Console.WriteLine($"chuoi dao : {reversedString}");
    }
    void DemKyTuTrongChuoi()
    {
        string names = Convert.ToString(Console.ReadLine());
        names.ToArray();
        Console.WriteLine(" ki tu can tim so lan :");
        char kitu = Convert.ToChar(Console.ReadLine());
        int dem = 0;
        for (int i = 0; i < names.Length - 1; i++)
        {
            if (names[i] == kitu)
            {
                dem++;
            }
        }
        Console.WriteLine($" ki tu {kitu} xuat hien {dem} lan");
    }
    void KiemTraMangDoiXung()
    {

        Console.WriteLine("nhap so luong phan tu:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[n];
        Console.WriteLine(" nhap mang :");
        for (int i = 0; i < n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }

        int size = a.Length - 1;
        int dem = 0;
        int dk = a.Length / 2;
        Console.WriteLine("kiem tra xem mang co doi xung khong:");
        for (int i = 0; i < dk; i++)
        {
            if (a[i] == a[size])
            {
                dem++;
            }
            size--;
        }

        if (dem == dk)
        {
            Console.WriteLine("mang nay doi xung");
        }
        else
        {
            Console.WriteLine("mang nay khong doi xung");
        }
    }
}
