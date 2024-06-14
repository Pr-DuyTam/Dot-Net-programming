using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_Bai7
{
    class Employee
    {
        private int _id;
        private String _name;
        private int _yearOfBirth;
        private double _salaryLevel;
        private static double _basicSalary;

        public Employee()
        {
            Id = 0;
            Name = "";
            YearOfBirth = 0;
            SalaryLevel = 0;
            BasicSalary = 0;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int YearOfBirth
        {
            get { return _yearOfBirth; }
            set { _yearOfBirth = value; }
        }
        public double SalaryLevel
        {
            get { return _salaryLevel; }
            set { _salaryLevel = value; }
        }
        public double BasicSalary
        {
            get { return _basicSalary; }
            set { _basicSalary = value; }
        }
        public double Income
        {
            get { return Math.Round(BasicSalary * SalaryLevel); }
        }
        public void nhap()
        {
            Console.Write(" \t -Nhap id:");
            Id = Int32.Parse(Console.ReadLine());
            Console.Write(" \t -Nhap ho ten:");
            Name = Console.ReadLine();
            Console.Write(" \t -Nhap nam sinh:");
            YearOfBirth = Int32.Parse(Console.ReadLine());
            Console.Write(" \t -Nhap luong co ban:");
            BasicSalary = Double.Parse(Console.ReadLine());
            Console.Write(" \t -Nhap bac luong:");
            SalaryLevel = Double.Parse(Console.ReadLine());
        }
        public void xuat()
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}{3,-15}{4,-15}{5,-15}", Id, Name, YearOfBirth, BasicSalary, SalaryLevel, Income);
        }
    }
}
