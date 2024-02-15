using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_Expr_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int soluong=0; 
            int khoiluong=0;
            double diemtoan = 10;
            string name = "Nguyễn Đăng Huy";

            Console.OutputEncoding = Encoding.UTF8; // Viết tiếng Việt

            Console.WriteLine("Điểm toán: {0}", diemtoan);
            Console.WriteLine("Tên: {0}",name);
            double d = 1 / 2;
            Console.WriteLine("d={0}/{1}={2}", 1, 2, d);
            double d2 =(double) 1 / 2;
            Console.WriteLine("d={0}/{1}={2}", 1, 2, d2);
            double d3 = 1.0 / 2;
            Console.WriteLine("d={0}/{1}={2}", 1, 2, d3);
            var t = 5;
            Console.WriteLine(t.GetType());
            Console.ReadLine();
        }
    }
}