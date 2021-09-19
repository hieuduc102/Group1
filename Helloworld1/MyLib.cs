
using System;

namespace MyLib
{
    public class MyMath
    {
        /// <summary>
        /// Giai phuong trinh bac nhat
        /// </summary>
        /// <param name="a">Tham so a</param>
        /// <param name="b">tham so b</param>
        /// <param name="x">Nghien cua pt</param>
        /// <returns>
        /// -1:pt vo nghiem
        /// 0:pt vo so nghiem
        /// 1:pt co 1 nghiem
        /// </returns>
        public static KetQua PTBacNhat(int a,int b, out float x)
        {
            /**
             * Mo ta thuat toan
             */
            x = 0;
            if (a == 0)
                if (b == 0)
                    return KetQua.VoSoNghiem;
                else return KetQua.VoNghiem;
            else
            {
                x = (float)-b / a;
                return KetQua.MotNghiem;
            }
        }
        public enum KetQua
        {
            VoNghiem,
            VoSoNghiem,
            MotNghiem,
            HaiNghiem
        }
        public static long TongSo(int n)
        {
            long rs = 0;
            for(int i = 0; i < n; i++)
            {
                rs += (long)i;
            }
            return rs;
        }
        public static long TongSo2(int n)
        {
            long rs = 0;
            int i = 0;
            while (i <= n)
            {
                rs += (long)i;
            }
            return rs;
        }
        public static long TongDeQuy(int n)
        {
            if (n == 0)
                return 0;
            else
                return n + TongDeQuy(n - 1);
        }
    }
    public class Point :Object
    { 
        public int x { 
            get;//lay du lieu
            set;//thiet lap du lieu
        }
        public int y { 
            get; 
            set; 
        }
        public Point()
        {
            x = 0;
            y = 0;
        }
        public Point(int x, int y)
        {
            this.x = x;//x nay cua ham nay
            this.y = y;
        }
        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
        }
        /// <summary>
        /// Tinh khoang cach tu diem hien tai den goc toa do
        /// </summary>
        /// <returns>Khoang cach den 0</returns>
        public double Distance()
        {
            double d = Math.Sqrt(x * x + y * y);
            return d;
        }
        /// <summary>
        /// Tinh khoang cach den p
        /// Ham Overloading cua ham Distance(cung ten khac tham so)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public double Distance(Point p)
        {
            double d = Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
            return d;
        }
        /// <summary>
        /// Tinh khoang cach tu a den b
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Distance(Point a, Point b)
        {
            double d = Math.Sqrt(Math.Pow(a.x - b.x, 2) + Math.Pow(a.y - b.y, 2));
            return d;
        }
    }
    /*
    public override string ToString()
    {
        return $"Toa do cua diem la ({x},{y})";
    }*/
}
