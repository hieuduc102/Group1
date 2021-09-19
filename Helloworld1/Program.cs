using System;
using MyLib;

namespace Helloworld1
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 0;
            var rs = MyMath.PTBacNhat(20, 10, out x);
            if (rs==MyMath.KetQua.VoSoNghiem)
                Console.WriteLine("Pt vo so nghiem");
            else if (rs==MyMath.KetQua.VoNghiem)
                Console.WriteLine("Pt vo nghiem");
            else 
                Console.WriteLine($"Pt co nghiem la: {x}");
            Console.ReadKey();
        }
    }
}
