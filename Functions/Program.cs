using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Operations
{
    class Functions
    {
        static void TinhGiaiThua()
        {
            int n, gt=1; 
            Console.Write("Nhập n: ");
            n=int.Parse(Console.ReadLine());
            Console.Write("{0}! = ",n);
            for (int i=1; i<=n;i++)
            {
                gt=gt*i;
            }
            Console.Write(gt);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TinhGiaiThua();
            Console.ReadLine();
        }
    }
}