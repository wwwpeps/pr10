using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcc
{
    public class math
    {
        public static double Sum(double a, double b) 
        {
            double sum = a + b;
            return sum;
        }

        public static double Vich(double a, double b)
        {
            double vich = 0;
            vich = a - b;
            return vich;
        }

        public static double Mult(double a, double b)
        {
            double mult = a * b;
            return mult;
        }

        public static double Del(double a, double b)
        {
            double del = a/b;
            return del;
        }
    }
}
