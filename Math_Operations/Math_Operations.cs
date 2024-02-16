using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operations
{
    class Math_Operations
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            int a = 5;
            a += 2;
            Console.WriteLine("a={0}",a);
            //Nhập 1 số, kiểm tra chẵn lẻ
            int b;
            Console.Write("Nhập b: ");
            b=int.Parse(Console.ReadLine()); // Console.ReadLine() => Chờ người dùng nhập rồi nhấn Enter
            // Nếu nhập 5 => hiểu 5 là "5" nên ta cần ép kiểu
            //int.Prase("5");
            if (b%2==0)
            {
                Console.WriteLine("{0} là số chẵn",b);
            }
            else
            {
                Console.WriteLine("{0} là số lẻ", b);
            }

            Console.ReadLine();
        }
    }
}