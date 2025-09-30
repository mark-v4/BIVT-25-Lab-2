using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Lab2
{
    public class Purple
    {
        const double E = 0.0001;
        public int Task1(int n, int p, int h)
        {
            int answer = 0;

            // code here

            for (int i = 0; i < n; i++)
            {
                answer += (p + h * i) * (p + h * i);
            }

            // end

            return answer;
        }
        public (int quotient, int remainder)  Task2(int a, int b)
        {
            int quotient = 0;
            int remainder = 0;

            // code here

            while (a >= b)
            {
                a -= b;
                quotient++;
            }
            remainder = a;

            // end

            return (quotient, remainder);
        }
        public double Task3()
        {
            double answer = 0;

            // code here

            const double e = 1e-4;
            double a1 = 1, a2 = 2, b1 = 1, b2 = 1;
            while (Math.Abs(a2 / b2 - a1 / b1) >= e)
            {
                (a1, a2) = (a2, a1 + a2);
                (b1, b2) = (b2, b1 + b2);
            }
            answer = a2 / b2;

            // end

            return answer;
        }
        public int Task4(double b, double q)
        {
            int answer = 1;

            // code here

            const double e = 1e-4;
            while (Math.Abs(b) >= e)
            {
                b *= q;
                answer++;
            }

            // end

            return answer;
        }
        public int Task5(int a, int b)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public long Task6()
        {
            long answer = 0;

            // code here

            // end

            return answer;
        }

        public int Task7(double S, double d)
        {
            int answer = 0;

            // code here

            // end

            return answer;
        }
        public (double SS, double SY) Task8(double a, double b, double h)
        {
            double SS = 0;
            double SY = 0;

            // code here

            // end

            return (SS, SY);
        }
    }
}