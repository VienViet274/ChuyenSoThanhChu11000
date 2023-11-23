using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapMangArrays
{
    
    internal class Program
    {
        //Main Program
       
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            BaiKiemTra c = new BaiKiemTra();
            string s = c.ChuyenSoThanhChu(101);
            Console.WriteLine(s);
            s = c.ChuyenSoThanhChu(231);
            Console.WriteLine(s);
            s = c.ChuyenSoThanhChu(19);
            Console.WriteLine(s);
            s = c.ChuyenSoThanhChu(10);
            Console.WriteLine(s);
            s = c.ChuyenSoThanhChu(0);
            Console.WriteLine(s);
            for (int i = 0; i <=1000; i++)
            {
                Console.WriteLine($"{c.ChuyenSoThanhChu(i)} ------- {i}");
            }

            Console.ReadKey();
        }
    }
}

