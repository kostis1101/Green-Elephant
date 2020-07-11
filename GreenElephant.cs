using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace GreenElephant
{
    class GreenMath
    {
        /// <summary>
        /// returns nth Fibonacci number
        /// </summary>
        /// <param name="n"></param>
        /// <returns>unsigned 64bit long / ulong</returns>
        public static ulong getFibonacci(int n)
        {
            ulong result = 0;

            ulong lastNum = 1;
            ulong lastTwoNum = 0;

            for (int i = 0; i < n; i++)
            {
                result = lastNum + lastTwoNum;

                lastTwoNum = lastNum;
                lastNum = result;
            }

            if (n == 0)
            {
                result = 1;
            }

            return result;
        }

        /// <summary>
        /// converts string to float
        /// </summary>
        /// <param name="n"></param>
        /// <returns>unsigned 64bit long / ulong</returns>
        public static float ParseFloat(string stringToParse)
        {
            float result = 0;

            if (!stringToParse.Contains("."))
            {
                return Int32.Parse(stringToParse);
            }

            try
            {
                string[] nums = stringToParse.Split('.');
                int intPart = Int32.Parse(nums[0]);
                float decimalPart = (float)Int32.Parse(nums[1]) / (float)Math.Pow(10, nums[1].Length);

                result = intPart + decimalPart;
            }
            catch
            {
                if (!stringToParse.Contains('.'))
                {
                    try
                    {
                        return Int32.Parse(stringToParse);
                    }
                    catch
                    {
                        Console.WriteLine("Error: couldn't covert to float, undefined character.");
                    }
                }
            }

            return result;
        }
        /// <summary>
        /// converts string to float
        /// </summary>
        /// <param name="n"></param>
        /// <returns>unsigned 64bit long / ulong</returns>
        public static float ParseFloat(string stringToParse, char splitChar)
        {
            float result = 0;



            try
            {
                string[] nums = stringToParse.Split(splitChar);
                int intPart = Int32.Parse(nums[0]);
                float decimalPart = (float)Int32.Parse(nums[1]) / (float)Math.Pow(10, nums[1].Length);

                result = intPart + decimalPart;
            }
            catch
            {
                if (!stringToParse.Contains('.'))
                {
                    try
                    {
                        return Int32.Parse(stringToParse);
                    }
                    catch
                    {
                        Console.WriteLine("Error: couldn't covert to float, undefined character.");
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// converts string to double
        /// </summary>
        /// <param name="n"></param>
        /// <returns>unsigned 64bit long / ulong</returns>
        public static double ParseDouble(string stringToParse)
        {
            double result = 0;

            if (!stringToParse.Contains("."))
            {
                return Int32.Parse(stringToParse);
            }

            try
            {
                string[] nums = stringToParse.Split('.');
                int intPart = Int32.Parse(nums[0]);
                double decimalPart = (double)Int32.Parse(nums[1]) / (double)Math.Pow(10, nums[1].Length);

                result = intPart + decimalPart;
            }
            catch
            {
                if (!stringToParse.Contains('.'))
                {
                    try
                    {
                        return Int32.Parse(stringToParse);
                    }
                    catch
                    {
                        Console.WriteLine("Error: couldn't covert to float, undefined character.");
                    }
                }
            }

            return result;
        }
        /// <summary>
        /// converts string to double
        /// </summary>
        /// <param name="n"></param>
        /// <returns>unsigned 64bit long / ulong</returns>
        public static double ParseDouble(string stringToParse, char splitChar)
        {
            double result = 0;

            try
            {
                string[] nums = stringToParse.Split(splitChar);
                int intPart = Int32.Parse(nums[0]);
                double decimalPart = (double)Int32.Parse(nums[1]) / (double)Math.Pow(10, nums[1].Length);

                result = intPart + decimalPart;
            }
            catch
            {
                if (!stringToParse.Contains('.'))
                {
                    try
                    {
                        return Int32.Parse(stringToParse);
                    }
                    catch
                    {
                        Console.WriteLine("Error: couldn't covert to float, undefined character.");
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// converts string to decimal
        /// </summary>
        /// <param name="n"></param>
        /// <returns>unsigned 64bit long / ulong</returns>
        public static decimal ParseDecimal(string stringToParse)
        {
            decimal result = 0;

            if (!stringToParse.Contains("."))
            {
                return Int32.Parse(stringToParse);
            }

            try
            {
                string[] nums = stringToParse.Split('.');
                int intPart = Int32.Parse(nums[0]);
                decimal decimalPart = (decimal)Int32.Parse(nums[1]) / (decimal)Math.Pow(10, nums[1].Length);

                result = intPart + decimalPart;
            }
            catch
            {
                if (!stringToParse.Contains('.'))
                {
                    try
                    {
                        return Int32.Parse(stringToParse);
                    }
                    catch
                    {
                        Console.WriteLine("Error: couldn't covert to float, undefined character.");
                    }
                }
            }

            return result;
        }
        /// <summary>
        /// converts string to decimal
        /// </summary>
        /// <param name="n"></param>
        /// <returns>unsigned 64bit long / ulong</returns>
        public static decimal ParseDecimal(string stringToParse, char splitChar)
        {
            decimal result = 0;

            try
            {
                string[] nums = stringToParse.Split(splitChar);
                int intPart = Int32.Parse(nums[0]);
                decimal decimalPart = (decimal)Int32.Parse(nums[1]) / (decimal)Math.Pow(10, nums[1].Length);

                result = intPart + decimalPart;
            }
            catch
            {
                if (!stringToParse.Contains('.'))
                {
                    try
                    {
                        return Int32.Parse(stringToParse);
                    }
                    catch
                    {
                        Console.WriteLine("Error: couldn't covert to float, undefined character.");
                    }
                }
            }

            return result;
        }

        public static void CartesianToPolar(float x, float y, out float a, out float d)
        {
            a = (float)Math.Atan((y / x));
            d = (float)Math.Sqrt((x * x + y * y));
        }

        public static void PolarToCartesian(float a, float d, out float x, out float y)
        {
            x = (float)Math.Cos(a) * d;
            y = (float)Math.Sin(a) * d;
        }

        public static float RadiansToDegrees(float radians)
        {
            return (float)(radians / (Math.PI / 180));
        }

        public static float DegreesToRadians(float degrees)
        {
            return (float)(degrees * (Math.PI / 180));
        }

        public static double ToBaseTen(double numToSwicht, int correntBase = 2)
        {
            double result = 0;

            double _numToSwicht = numToSwicht;

            if (numToSwicht < 0)
                numToSwicht = -numToSwicht;

            if(numToSwicht % 1 == 0)
            {
                string numText = numToSwicht.ToString();

                for(int dig = numText.Length - 1; dig >= 0; dig--)
                {
                    int _dig = Int32.Parse(numText[dig].ToString());
                    result += _dig * Math.Pow(correntBase, numText.Length - dig - 1);
                }
            }
            else
            {
                string numText = numToSwicht.ToString();
                string[] parts = numText.Split(',');

                //integer part
                for (int dig = parts[0].Length - 1; dig >= 0; dig--)
                {
                    int _dig = Int32.Parse(parts[0][dig].ToString());
                    result += _dig * Math.Pow(correntBase, parts[0].Length - dig - 1);
                }

                //decimal part
                for (int dig = parts[1].Length - 1; dig >= 0; dig--)
                {
                    int _dig = Int32.Parse(parts[1][dig].ToString());
                    result += _dig * Math.Pow(correntBase, -dig - 1);
                }
            }

            if (_numToSwicht < 0)
                return -result;

            return result;
        }

        public static double sigmoid(double x)
        {
            return (1 / (1 + Math.Pow(Math.E, -x)));
        }
    }

    class GreenString
    {
        /// <summary>
        /// returns the reverce of a string
        /// </summary>
        /// <param name="stringToRevese"></param>
        /// <returns></returns>
        public static string ReverceString(string stringToRevese)
        {
            string result;
            char[] charsInString = stringToRevese.ToCharArray();
            charsInString = charsInString.Reverse().ToArray();
            result = new string(charsInString);
            return result;
        }
    }

    class Complex
    {
        public float r = 0;
        public float i = 0;
        public Complex normalized;

        public Complex(float real, float imaginary)
        {
            r = real;
            i = imaginary;

            float na;
            float nd;
            float nx;
            float ny;
            GreenMath.CartesianToPolar(r, i, out na, out nd);
            GreenMath.PolarToCartesian(na, 1, out nx, out ny);
            normalized = new Complex();
            normalized.r = (float)nx;
            normalized.i = (float)ny;
        }

        public Complex()
        {
            r = 0;
            i = 0;
        }

        public static Complex Add(Complex a, Complex b)
        {
            Complex result = new Complex(0, 0);

            result.r = a.r + b.r;
            result.i = a.i + b.i;

            return result;
        }

        public static Complex Add(float a, Complex b)
        {
            Complex result = new Complex(0, 0);

            result.r = a + b.r;
            result.i = b.i;

            return result;
        }

        public static Complex Add(Complex a, float b)
        {
            Complex result = new Complex(0, 0);

            result.r = b + a.r;
            result.i = a.i;

            return result;
        }

        public static Complex Subtract(Complex a, Complex b)
        {
            Complex result = new Complex(0, 0);

            result.r = a.r - b.r;
            result.i = a.i - b.i;

            return result;
        }

        public static Complex Subtract(Complex a, float b)
        {
            Complex result = new Complex(0, 0);

            result.r = a.r - b;
            result.i = a.i;

            return result;
        }

        public static Complex Subtract(float a, Complex b)
        {
            Complex result = new Complex(0, 0);

            result.r = a - b.r;
            result.i = -b.i;

            return result;
        }

        public static Complex Multiply(Complex a, Complex b)
        {
            return new Complex((a.r * b.r - a.i * b.i), (a.r * b.i + a.i * b.r));
        }

        public static Complex Multiply(Complex a, float b)
        {
            return new Complex(a.r * b, a.i * b);
        }

        public static Complex Multiply(float a, Complex b)
        {
            return new Complex(b.r * a, b.i * a);
        }

        public static Complex Divide(Complex a, Complex b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            Complex result = new Complex();

            float aa;
            float ad;

            float ba;
            float bd;

            float ra;
            float rd;

            float x;
            float y;

            GreenMath.CartesianToPolar(a.r, a.i, out aa, out ad);
            GreenMath.CartesianToPolar(b.r, b.i, out ba, out bd);

            ra = aa - ba;
            rd = ad / bd;

            GreenMath.PolarToCartesian(ra, rd, out x, out y);

            result.r = (float)x;
            result.i = (float)y;

            return result;
        }

        public static Complex Divide(float a, Complex b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            Complex result = new Complex();

            float aa;
            float ad;

            float ba;
            float bd;

            float ra;
            float rd;

            float x;
            float y;

            GreenMath.CartesianToPolar(a, 0, out aa, out ad);
            GreenMath.CartesianToPolar(b.r, b.i, out ba, out bd);

            ra = aa - ba;
            rd = ad / bd;

            GreenMath.PolarToCartesian(ra, rd, out x, out y);

            result.r = (float)x;
            result.i = (float)y;

            return result;
        }

        public static Complex Divide(Complex a, float b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            Complex result = new Complex();

            result.r = a.r / b;
            result.i = a.i / b;

            return result;
        }

        public static Complex Parse(string stringToParse)
        {
            Complex result = new Complex(0, 0);

            stringToParse = stringToParse.Replace(" ", string.Empty);
            string[] parts = stringToParse.Split(',');
            float realPart = GreenMath.ParseFloat(parts[0]);
            float imaginaryPart = GreenMath.ParseFloat(parts[1]);

            result.r = realPart;
            result.i = imaginaryPart;

            return result;
        }

        public static void print(Complex complex)
        {
            string sign;
            float imaginaryPart = complex.i;

            if (complex.i >= 0)
            {
                sign = " + ";
            }
            else
            {
                sign = " - ";
                imaginaryPart *= -1;
            }

            Console.Write(complex.r + sign + imaginaryPart + "i");
        }

        public static void print(Complex complex, CultureInfo cultureInfo)
        {
            string sign;
            float imaginaryPart = complex.i;

            if (imaginaryPart >= 0)
            {
                sign = " + ";
            }
            else
            {
                sign = " - ";
                imaginaryPart *= -1;
            }

            Console.Write(complex.r + sign + imaginaryPart + "i", cultureInfo);
        }

        public static void println(Complex complex)
        {
            string sign;
            float imaginaryPart = complex.i;

            if (imaginaryPart >= 0)
            {
                sign = " + ";
            }
            else
            {
                sign = " - ";
                imaginaryPart *= -1;
            }

            Console.WriteLine(complex.r + sign + imaginaryPart + "i");
        }

        public static void println(Complex complex, CultureInfo cultureInfo)
        {
            string sign;
            float imaginaryPart = complex.i;

            if (imaginaryPart >= 0)
            {
                sign = " + ";
            }
            else
            {
                sign = " - ";
                imaginaryPart *= -1;
            }

            Console.WriteLine(complex.r + sign + imaginaryPart + "i", cultureInfo);
        }

        public static bool constainsMandelbrodSet(Complex complex, int iterations)
        {
            Complex z = new Complex(0, 0);

            for (int i = 0; i < iterations; i++)
            {
                z = Add(Pow(z, 2), complex);

                if (Abs(z) > 2)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool constainsMandelbrodSet(Complex complex, int idurations, out int exitValue)
        {
            Complex z = new Complex(0, 0);

            for (int i = 0; i < idurations; i++)
            {
                z = Add(Pow(z, 2), complex);

                if (Abs(z) > 2)
                {
                    exitValue = i;
                    return false;
                }
            }

            exitValue = idurations;
            return true;
        }

        public static List<Complex> MandelbrodSetEscapingPoints(Complex complex, int iterations)
        {
            Complex z = new Complex(0, 0);

            List<Complex> result = new List<Complex>();

            for (int i = 0; i < iterations; i++)
            {
                z = Add(Pow(z, 2), complex);

                result.Add(new Complex((float)Math.Floor((Multiply(z, new Complex(300, 0))).r), (float)Math.Round(Multiply(z, new Complex(300, 0)).i)));
                if (Abs(z) >= 2)
                {
                    return result;
                }
            }

            return new List<Complex>();
        }

        public static bool containsJuliaSet(Complex z, Complex c, int iterations)
        {
            for (int i = 0; i < iterations; i++)
            {
                z = Add(Pow(z, 2), c);

                if (Abs(z) > 2)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool containsJuliaSet(Complex z, Complex c, int iterations, out int exitValue)
        {
            for (int i = 0; i < iterations; i++)
            {
                z = Add(Pow(z, 2), c);

                if (Abs(z) > 2)
                {
                    exitValue = i;
                    return false;
                }
            }

            exitValue = iterations;
            return true;
        }

        public static double Abs(Complex complex)
        {
            return Math.Sqrt(complex.r * complex.r + complex.i * complex.i);
        }

        public static Complex Normalize(Complex complex)
        {
            Complex result = new Complex();

            float ra;
            float rd;
            GreenMath.CartesianToPolar(complex.r, complex.i, out ra, out rd);
            GreenMath.PolarToCartesian(ra, 1, out result.r, out result.i);

            return complex;
        }

        public static Complex Pow(Complex Base, float Exponent)
        {
            Complex result = new Complex();
            float ra;
            float rd;

            float rr;
            float ri;
            GreenMath.CartesianToPolar(Base.r, Base.i, out ra, out rd);
            GreenMath.PolarToCartesian((ra * Exponent), ((float)Math.Pow(rd, Exponent)), out rr, out ri);
            result.r = rr;
            result.i = ri;

            return result;
        }

        public static Complex Pow(float Base, Complex Exponent)
        {
            Complex result;
            Complex realPart = new Complex();
            Complex imaginaryPart = new Complex();
            realPart.r = (float)Math.Pow(Base, Exponent.r);
            GreenMath.PolarToCartesian((float)(Exponent.i * Math.Log(Base)), 1, out imaginaryPart.r, out imaginaryPart.i);

            result = Multiply(realPart, imaginaryPart);

            return result;
        }

        public static Complex Pow(Complex Base, Complex Exponent)
        {
            Complex result = new Complex();
            Complex realPart = new Complex();
            realPart = Pow(Base, Exponent.r);

            Complex imaginaryPart = new Complex();
            imaginaryPart = Pow((float)Math.E, Multiply(ln(Base), new Complex(0, Exponent.i)));

            result = Multiply(imaginaryPart, realPart);
            return result;
        }

        public static Complex ln(Complex complex)
        {
            Complex result = new Complex();
            float a;
            float d;

            GreenMath.CartesianToPolar(complex.r, complex.i, out a, out d);
            result.i = a;
            result.r = (float)Math.Log(d);

            return result;
        }

        public static string ToString(Complex complex)
        {
            string result = "";
            string sign;

            float imaginaryPart = complex.i;

            if (imaginaryPart >= 0)
            {
                sign = " + ";
            }
            else
            {
                sign = " - ";
                imaginaryPart *= -1;
            }

            result += complex.r.ToString();
            result += sign;
            result += imaginaryPart.ToString();
            result += "i";

            return result;
        }

        public static Complex cos(Complex complex)
        {
            Complex result;

            result = Divide(Add(Pow((float)Math.E, Multiply(complex, new Complex(0, 1))), Pow((float)Math.E, Multiply(Multiply(complex, new Complex(0, 1)), new Complex(-1, 0)))), new Complex(2, 0));

            return result;
        }

        public static Complex sin(Complex complex)
        {
            Complex result;

            result = Divide(Subtract(Pow((float)Math.E, Multiply(complex, new Complex(0, 1))), Pow((float)Math.E, Multiply(Multiply(complex, new Complex(0, 1)), new Complex(-1, 0)))), Multiply(new Complex(2, 0), new Complex(0, 1)));

            result = Multiply(result, new Complex(-1, 0));

            return result;
        }

        public static Complex tan(Complex complex)
        {
            return Divide(sin(complex), cos(complex));
        }

        public static Complex operator +(Complex c) => c;
        public static Complex operator -(Complex c) => Multiply(c, -1);

        public static Complex operator +(Complex a, Complex b) => Add(a, b);
        public static Complex operator +(float a, Complex b) => Add(a, b);
        public static Complex operator +(Complex a, float b) => Add(a, b);

        public static Complex operator -(Complex a, Complex b) => Subtract(a, b);
        public static Complex operator -(float a, Complex b) => Subtract(a, b);
        public static Complex operator -(Complex a, float b) => Subtract(a, b);

        public static Complex operator *(Complex a, Complex b) => Multiply(a, b);
        public static Complex operator *(Complex a, float b) => Multiply(a, b);
        public static Complex operator *(float a, Complex b) => Multiply(a, b);

        public static Complex operator /(Complex a, Complex b) => Divide(a, b);
        public static Complex operator /(float a, Complex b) => Divide(a, b);
        public static Complex operator /(Complex a, float b) => Divide(a, b);

        public static Complex operator ^(Complex a, Complex b) => Pow(a, b);
        public static Complex operator ^(Complex a, float b) => Pow(a, b);
        public static Complex operator ^(float a, Complex b) => Pow(a, b);

        public static bool operator ==(Complex a, Complex b)
        {
            if (a.r == b.r && a.i == b.i)
            {
                return true;
            }

            return false;
        }
        public static bool operator !=(Complex a, Complex b)
        {
            if (a.r == b.r && a.i == b.i)
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(float a, Complex b)
        {
            if (a == b.r && 0 == b.i)
            {
                return true;
            }

            return false;
        }
        public static bool operator !=(float a, Complex b)
        {
            if (a == b.r && 0 == b.i)
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Complex a, float b)
        {
            if (a.r == b && a.i == 0)
            {
                return true;
            }

            return false;
        }
        public static bool operator !=(Complex a, float b)
        {
            if (a.r == b && a.i == 0)
            {
                return false;
            }

            return true;
        }


        public override string ToString()
        {
            return ToString(new Complex(r, i));
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}

