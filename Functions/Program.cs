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
        static void TangGiaTri(ref int n)
        {
            n = n + 1;
        }
        static void GiamGiaTri(out int b)
        {
            b=0;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //TinhGiaiThua();

            // Tham chiều: khiến giá trị đi vào hàm sẽ thay đổi giá trị bên ngoài hàm
            // Tham chiếu dùng từ khóa out hoặc ref
            // out bắt buộc người dùng phải gán giá trị cho biến trước khi thoát khỏi hàm
            // ref bắt buộc người dùng phải khởi tạo giá trị cho biến trước khi vào hàm
            int a = 10,b=10;
            TangGiaTri(ref a); // Lúc này giá trị của a=b=11
            Console.WriteLine("a= {0}, b= {1}", a,b);
            GiamGiaTri(out b);
            Console.WriteLine("a= {0}, b= {1}", a, b);
            Console.ReadLine();
        }
    }
}