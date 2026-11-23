using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Zadacha.Abramyan;

class Begin
{ 
  
    
          /* // begin 1

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

         // begin 30

         double a = double.Parse(Console.ReadLine());
         double c = a * (180 / 3.14);
         Console.WriteLine(c);

        //begin 31

        double Tf= double.Parse(Console.ReadLine());
        double Tc = (Tf - 32) * 5.0 / 9.0;
        Console.WriteLine(Tc);

        //begin 32

        double Tc= double.Parse(Console.ReadLine());
        double Tf = (Tc * 9.0 / 5.0) + 32;
        Console.WriteLine(Tf);

        //begin 33


        double x=double.Parse(Console.ReadLine());
        double y=double.Parse(Console.ReadLine());
        int a = 10;
        double c =( a / x)*y;
        Console.WriteLine(c);

        //begin 34

        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double b = 20;
        int a = 10;
        double c = (a / x);
        double d = (b / y);
        double e = Math.Max(c, d);
        Console.WriteLine(e);

        //begin 35

        double u = double.Parse(Console.ReadLine());
        double v = double.Parse(Console.ReadLine());
        double t1= double.Parse(Console.ReadLine());
        double t2 = double.Parse(Console.ReadLine());
        double s1 = (v * t1);
        double s2 = (v * u)*t2;
        double s = s1 + s2;
        Console.WriteLine(s);

        //begin 36


        double v1 = double.Parse(Console.ReadLine());
        double v2 = double.Parse(Console.ReadLine());
        double t= double.Parse(Console.ReadLine());
        double s1 = double.Parse(Console.ReadLine());
        double e = v1 + v2;
        double e1 = (v1 + v2)*t;
        double s = s1 + (v1 + v2) * t;
        Console.WriteLine(s);

        //begin 37

        double v1 = double.Parse(Console.ReadLine()!);
        double v2= double.Parse(Console.ReadLine()!);
        double s = double.Parse(Console.ReadLine()!);
        double t= double.Parse(Console.ReadLine()!);
        double d = Math.Abs(s - (v1+ v2) * t);
        Console.WriteLine(d);
        
        //begin 38
        
        double a = double.Parse(Console.ReadLine()!);
        double b = double.Parse(Console.ReadLine()!);
        double x = -b / a;
        Console.WriteLine( x);
        
        //begin 39
        
        double a = double.Parse(Console.ReadLine()!);
        double b = double.Parse(Console.ReadLine()!);
        double c = double.Parse(Console.ReadLine()!);
        double d = b * b - 4 * a * c;
        double r1 = (-b- Math.Sqrt(d)) / (2 * a);
        double r2 = (-b + Math.Sqrt(d)) / (2 * a);
        Console.WriteLine( Math.Min(r1, r2));
        Console.WriteLine( Math.Max(r1, r2));

        
        //begin 40
        
        
        double a1 = double.Parse(Console.ReadLine()!);
        double b1 = double.Parse(Console.ReadLine()!);
        double c1 = double.Parse(Console.ReadLine()!);
        double a2 = double.Parse(Console.ReadLine()!);
        double b2 = double.Parse(Console.ReadLine()!);
        double c2 = double.Parse(Console.ReadLine()!);
        double d = a1 * b2 - a2 * b1;
        double x = (c1 * b2 - c2 * b1) / d;
        double y = (a1 * c2 - a2 * c1) / d;
        Console.WriteLine(x);
        Console.WriteLine(y);*/




}







    