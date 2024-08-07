using System;
using System.Security.Cryptography.X509Certificates;
namespace PhuongTrinhBacNhat{
    class Program{
        static void Main(string[] args)
        {
            Console.WriteLine("Phuong Trinh Bac Nhat");
            Console.WriteLine("Cho phương trình là 'a * x + b = 0', vui lòng nhập hằng số:");

            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a != 0){
            double solution = -b / a;
            Console.Write("The solution is: {0}!", solution);
            }else{
            if (b == 0)
            {
            Console.Write("The solution is all x!");
            }
            else
            {
            Console.Write("Nod solution!");
            }
}

        }
        }
    }

