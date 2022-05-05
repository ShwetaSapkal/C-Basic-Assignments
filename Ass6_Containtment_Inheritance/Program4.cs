using System;
using System.Collections.Generic;
using System.Text;

namespace CSPrograms.Ass6_Containtment_Inheritance
{
    class FindVolume
    {
        internal double Volume(double r)
        {
            double v = ((4 / 3) * (22 / 7) * (r * r * r));
            return v;
        }

        internal double Volume(double h, double r)
        {
            double v = ((22 / 7) * (r * r * r) * h);
                return v;
        }

        internal double Volume(double l, double b, double h)
        {
            double v = l * b * h;
            return v;
        }
    }

    class VolumeTest
    {
        static void Main(string[] args)
        {
            FindVolume v = new FindVolume();
            double ans = v.Volume(10,23,7);
            Console.WriteLine(ans);
                
        }
    }
}
