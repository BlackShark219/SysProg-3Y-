using System;
using Library_1;
using Library_2;

namespace Library_3
{
    public class KI3_Class_3:KI3_Class_1
    {
        public double F3(double x, double y)
        {
            return 6 * this.F1(x, y) - 3 * KI3_Class_2.F2(x, y);
        }
    }
}
