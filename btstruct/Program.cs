using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btstruct
{
    class Program
    {
        public struct sinhvien
        {
            public string maso210;
            public string hoten210;
            public double diemtoan210;
            public double diemly210;
            public double diemhoa210;
        }
        
        public static void nhapDS(ref sinhvien[] sv, int n)
        {
            for (int i210 = 0; i210 < n; i210++)
            {
                Console.WriteLine("Nhap sinh vien thu " + (i210 + 1));
                Console.Write("Ho ten: ");
                string ht210 = Console.ReadLine();
                Console.Write("Ma sinh vien: ");
                string msv210 = Console.ReadLine();
                Console.Write("Diem toan: ");
                double dt210 = double.Parse(Console.ReadLine());
                Console.Write("Diem ly: ");
                double dl210 = double.Parse(Console.ReadLine());
                Console.Write("Diem hoa: ");
                double dh210 = double.Parse(Console.ReadLine());

                sv[i210].hoten210 = ht210;
                sv[i210].maso210 = msv210;
                sv[i210].diemtoan210 = dt210;
                sv[i210].diemly210 = dl210;
                sv[i210].diemhoa210 = dh210;
                sv[i210].diemhoa210 = dh210;

            }
        }
        public static void xuatDS(sinhvien[] sv, int n)
        {
            int i210 = 1;
            foreach (sinhvien item210 in sv)
            {
                Console.WriteLine("----- " + i210 + " -----");
                Console.WriteLine("Ho ten: " + item210.hoten210);
                Console.WriteLine("Ma sinh vien: " + item210.maso210);
                Console.WriteLine("Diem toan: " + item210.diemtoan210);
                Console.WriteLine("Diem ly: " + item210.diemly210);
                Console.WriteLine("Diem hoa: " + item210.diemhoa210);
                Console.Write("Diem TB: "+ diemTB(item210.diemhoa210, item210.diemly210, item210.diemtoan210));

                i210++;
            }
        }
        public static double diemTB(double toan, double ly, double hoa)
        {
            double dtb210 = (toan + ly + hoa) / 3;
            return dtb210;
        }
        public static void timKiem(sinhvien[] sv, int n, string ht)
        {
            foreach (sinhvien item210 in sv)
            {
                if (item210.hoten210 == ht)
                {
                    Console.WriteLine("Ho ten: " + item210.hoten210);
                    Console.WriteLine("Ma sinh vien: " + item210.maso210);
                    Console.WriteLine("Diem toan: " + item210.diemtoan210);
                    Console.WriteLine("Diem ly: " + item210.diemly210);
                    Console.WriteLine("Diem hoa: " + item210.diemhoa210);
                    Console.WriteLine("Diem TB: " + item210.diemhoa210);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so sinh vien: ");
            int n210 = int.Parse(Console.ReadLine());
            sinhvien[] sv210 = new sinhvien[n210];
            nhapDS(ref sv210, n210);
            Console.WriteLine("\n\n==========DANH SACH SINH VIEN==========");
            xuatDS(sv210, n210);

            Console.WriteLine("\n==========TIM KIEM SINH VIEN==========");
            Console.Write("Nhap ten sinh vien: ");
            string ht210 = Console.ReadLine();
            timKiem(sv210, n210, ht210);

            Console.ReadLine();
        }
    }
}
