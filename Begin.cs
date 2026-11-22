namespace Zadacha.Abramyan;

class Begin
{
      static void Main()
    {
        // begin 1

        double a = double.Parse(Console.ReadLine());
        Console.WriteLine(4 * a);

        //begin 2

        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(b * b);
        //begin 3  
        
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        Console.WriteLine("s=" + (c * d));
        Console.WriteLine("p = " + (2 * (a + b)));
        //begin 4

        double m = double.Parse(Console.ReadLine());
        Console.WriteLine(3.14 * m);
        //begin 5

        double i = double.Parse(Console.ReadLine());
        Console.WriteLine("v = " + (i * i * i));
        Console.WriteLine("s = " + (6 * i * i));
        //begin 6
        double s = double.Parse(Console.ReadLine()!);
        double t = double.Parse(Console.ReadLine()!);
        double y = double.Parse(Console.ReadLine()!);
        Console.WriteLine("v = " + (s * t * y));
        Console.WriteLine("s = " + (2 * (s * t + y * y + s * y)));
        //begin 7

        double r = double.Parse(Console.ReadLine()!);
        double p = 3.14;
        Console.WriteLine("L = " + (2 * p * r));
        Console.WriteLine("S = " + (p * r * r));
        // begin 8 
        double ab = double.Parse(Console.ReadLine()!);
        double bb = double.Parse(Console.ReadLine()!);
        Console.WriteLine("mean = " + ((ab + bb) / 2));

        // begin 9 
        double ar = double.Parse(Console.ReadLine()!);
        double br = double.Parse(Console.ReadLine()!);
        Console.WriteLine("geom = " + Math.Sqrt(ar * br));

        // begin 10 
        double ae = double.Parse(Console.ReadLine()!);
        double be = double.Parse(Console.ReadLine()!);
        double se = ae * ae;
        double sr = be * be;
        Console.WriteLine("sum = " + (se + sr));
        Console.WriteLine("diff = " + (se - sr));
        Console.WriteLine("prod = " + (se * sr));
        Console.WriteLine("quot = " + (se / sr));

        // begin 11 
        double a1 = double.Parse(Console.ReadLine()!);
        double b1 = double.Parse(Console.ReadLine()!);
        double ma1 = Math.Abs(a1);
        double mb1 = Math.Abs(b1);
        Console.WriteLine("sum = " + (ma1 + mb1));
        Console.WriteLine("diff = " + (ma1 - mb1));
        Console.WriteLine("prod = " + (ma1 * mb1));
        Console.WriteLine("quot = " + (ma1 / mb1));

        // begin 12 
        double a2 = double.Parse(Console.ReadLine()!);
        double b2 = double.Parse(Console.ReadLine()!);
        double c2 = Math.Sqrt(a2 * a2 + b2 * b2);
        Console.WriteLine("c = " + c2);
        Console.WriteLine("P = " + (a2 + b2 + c2));

        // begin 13 
        double rr1 = double.Parse(Console.ReadLine()!);
        double r2 = double.Parse(Console.ReadLine()!);
        double s1 = r * rr1 * rr1;
        double s2 = s * r2 * r2;
        Console.WriteLine("S1 = " + s1);
        Console.WriteLine("S2 = " + s2);
        Console.WriteLine("S3 = " + (s1 - s2));

        // begin 14 
        double l1 = double.Parse(Console.ReadLine()!);
        double r1 = l1 / (2 * r);
        Console.WriteLine("R = " + r1);
        Console.WriteLine("S = " + (r * r1 * r1));

        // begin 15 
        double s5 = double.Parse(Console.ReadLine()!);
        double r5 = Math.Sqrt(s5 / y);
        double d5 = 2 * r5;
        Console.WriteLine("d = " + d5);
        Console.WriteLine("L = " + (p * d5));

        // begin 16
        double x1_9 = double.Parse(Console.ReadLine()!);
        double x2_9 = double.Parse(Console.ReadLine()!);
        Console.WriteLine("d = " + Math.Abs(x1_9 - x2_9));

        // begin 17 
        double a7 = double.Parse(Console.ReadLine()!);
        double b7 = double.Parse(Console.ReadLine()!);
        double c7 = double.Parse(Console.ReadLine()!);
        double ac7 = Math.Abs(c7 - a7);
        double bc7 = Math.Abs(c7 - b7);
        Console.WriteLine("AC = " + ac7);
        Console.WriteLine("BC = " + bc7);
        Console.WriteLine("sum = " + (ac7 + bc7));

        // begin 18 
        double a18 = double.Parse(Console.ReadLine()!);
        double b18 = double.Parse(Console.ReadLine()!);
        double c18 = double.Parse(Console.ReadLine()!);
        double ac18 = Math.Abs(c18 - a18);
        double bc18 = Math.Abs(b18 - c18);
        Console.WriteLine("p= " + (ac18 * bc18));

        // begin 19 
        double x1_19 = double.Parse(Console.ReadLine()!);
        double y1_19 = double.Parse(Console.ReadLine()!);
        double x2_19 = double.Parse(Console.ReadLine()!);
        double y2_19 = double.Parse(Console.ReadLine()!);
        double sA = Math.Abs(x2_19 - x1_19);
        double sB = Math.Abs(y2_19 - y1_19);
        Console.WriteLine("P = " + (2 * (sA + sB)));
        Console.WriteLine("S = " + (sA * sB));

        // begin 20 
        double x1_20 = double.Parse(Console.ReadLine()!);
        double y1_20 = double.Parse(Console.ReadLine()!);
        double x2_20 = double.Parse(Console.ReadLine()!);
        double y2_20 = double.Parse(Console.ReadLine()!);
        double dx20 = x2_20 - x1_20;
        double dy20 = y2_20 - y1_20;
        Console.WriteLine("d = " + Math.Sqrt(dx20 * dx20 + dy20 * dy20));
    }
}