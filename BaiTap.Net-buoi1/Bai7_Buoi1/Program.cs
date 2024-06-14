using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write(" Nhap so luong nhan vien: ");
            n = int.Parse(Console.ReadLine());
            Employee[] _arrEmployee = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(" Nhap thong tin nhan vien thu: " + (i + 1).ToString());
                _arrEmployee[i] = new Employee();
                _arrEmployee[i].nhap();
            }
            Console.WriteLine(" Danh sach nhan vien: ");
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", "Dinh Danh", "Ho Ten", "Nam Sinh", "Bac Luong", "Luong Co Ban", "Thu Nhap");
            for (int i = 0; i < n; i++)
            {
                _arrEmployee[i].xuat();
            }
            Console.ReadLine();
        }
    }
}
