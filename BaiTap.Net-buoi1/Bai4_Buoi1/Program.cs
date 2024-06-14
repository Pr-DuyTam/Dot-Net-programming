using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Buoi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MangSoNguyen msn = new MangSoNguyen();
            int n;
            Console.Write("Nhập vào số phần tử mảng = "); n =
            msn.NhaSoDuong();
            int[] a = new int[n];
            msn.NhapMang(a);
            Console.WriteLine("Mảng vừa nhập ");
            msn.InMang(a);
            Console.WriteLine("\nSố lớn nhất trong mảng {0}");
            msn.TimSoLonNhat(a);
            Console.WriteLine("\nSố nhỏ nhất trong mảng {0}");
            msn.TimSoNhoNhat(a);
            Console.WriteLine("\nTổng các phần tử trong mảng {0}");
            msn.TinhTong(a);
            Console.WriteLine("\nMang sau khi sắp tă ần ");
            msn.SapXep(a);
            msn.InMang(a);
            Console.ReadLine();
        }
    }
}
