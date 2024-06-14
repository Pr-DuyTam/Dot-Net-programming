using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4_Buoi1
{
    internal class MangSoNguyen
    {
        public int NhaSoDuong()
        {
            int so;
            do
            {
                so = Convert.ToInt32(Console.ReadLine());
            } while (so < 0);
            return so;
        }
        //phuong thuc nhap mot so
        public int NhapMotSo()
        {
            int so;
            so = Convert.ToInt32(Console.ReadLine());
            return so;
        }
        //phuong thuc nhap mang
        public void NhapMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        //phuong thuc in mang
        public void InMang(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
                Console.Write(" {0}", a[i]);
        }
        public void TimSoLonNhat(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.Write(max);

        }
        public void TimSoNhoNhat(int[] a)
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.Write(min);

        }
        public void TinhTong(int[] a)
        {
            int Tong = 0;
            for (int i = 0; i < a.Length; i++)
            {
                Tong = Tong + a[i];
            }
            Console.Write(Tong);
        }
        public void SapXep(int[] a)
        {
            int t = 0;
            for (int i = 0; i < a.Length - 1; i++)
            {
                for(int j = 0; j<a.Length -1; j++)
                {
                    if (a[i] > a[j])
                    {
                        t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
        }

    }
}
