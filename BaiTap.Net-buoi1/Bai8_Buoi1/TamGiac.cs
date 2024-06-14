using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai8
{
    class TamGiac
    {
        private int A;
        private int B;
        private int C;
        private float _chuVi;
        private String _loaiTamGiac;
        private float _dienTich;

        public TamGiac()
        {
            A = 2;
            B = 3;
            C = 5;
        }
        public TamGiac(int a, int b, int c)
        {
            a = A;
            b = B;
            c = C;
        }
        public float Chuvi(int a, int b, int c)
        {
            float chuvi;
            chuvi = a + b + c;
            return chuvi;
        }
        public float DienTich(int a, int b, int c)
        {
            Get{ return (float)Math.Sqrt(p * (p - a) * (p - b) * (p - c)); }
        }

    }
}
