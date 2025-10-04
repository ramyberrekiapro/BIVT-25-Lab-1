namespace Lab1
{
    public class Purple
    {
        public bool Task1(int a, int b, int c)
        {
            bool answer = false;

            if (a > 0 && b > 0 && c > 0)
                answer = true;
            else if (a < 0 && b < 0 && c < 0)
                answer = true;
            else if (a == 0 && b == 0 && c == 0)
                answer = true;
            else
                answer = false;

            return answer;
        }

        public bool Task2(int a, int b)
        {
            bool answer = false;

            // fixed: divide zero checks per variable
            if ((b != 0 && a % b == 0) || (a != 0 && b % a == 0))
                answer = true;
            else
                answer = false;

            return answer;
        }

        public bool Task3(int a, int b)
        {
            bool answer = false;

            if (a * a * a == b || a * a == b || b * b == a || b * b * b == a)
                answer = true;
            else
                answer = false;

            return answer;
        }

        public double Task4(double d, double f, double g)
        {
            double answer = 0;

            // discriminant
            answer = (f * f) - (4 * d * g);

            return answer;
        }

        public double Task5(double x)
        {
            double answer = 0;

            if (x <= -1)
                answer = 1;
            else if (x > 1)
                answer = -1;
            else
                answer = x * (-1);

            return answer;
        }

        public bool Task6(double squareS, double circleS)
        {
            bool answer = false;

            // fixed variable order
            if (Math.Sqrt(2 * squareS) <= 2 * Math.Sqrt(circleS / Math.PI))
                answer = true;

            // note: 10e-4 tolerance if needed
            return answer;
        }

        public int Task7(bool s, bool t, bool f)
        {
            int answer = 0;

            if (s)
            {
                if (t)
                    answer = 6;
                else
                    answer = f ? 10 : 2;
            }
            else
            {
                if (t)
                    answer = 3;
                else
                    answer = f ? 5 : 1;
            }

            return answer;
        }

        // optional numeric Task7 variant
        public int Task7_alt(int n)
        {
            int answer = 0;

            if (n > 3 && n % 2 == 0)
                answer = n * 2;
            else
                answer = n + 1;

            return answer;
        }

        public bool Task8(int year, int pupils, int salary)
        {
            bool answer = false;
            const int bank = 10000;

            if (year % 400 == 0 || (year % 100 != 0 && year % 4 == 0))
            {
                answer = false;
            }
            else
            {
                if (((int)Math.Ceiling(pupils / 7.0)) * salary + (pupils * 5) <= bank)
                    answer = true;
                else
                    answer = false;
            }

            return answer;
        }
    }
}