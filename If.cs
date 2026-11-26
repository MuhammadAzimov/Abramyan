using System.Data;

namespace Zadacha.Abramyan;

public class If
{
    
        //if 1
        /*
          int a = int.Parse(Console.ReadLine());
          if (a > 0)
          {
              a = a + 1;
          }
          Console.WriteLine();

          //if 2

          int a = int.Parse(Console.ReadLine());
          if (a > 0)
          {
              a = a - 2;
          }
          Console.WriteLine();

          //if 3

          int a = int.Parse(Console.ReadLine());
          if (a > 0)
          {
              a = a + 1;
          }
          else if (a < 0)
          {
              a = a - 2;
          }
          else
          {
              a = 10;
          }
          Console.WriteLine(a);

          // if 4

          int a=int.Parse(Console.ReadLine());
          int b=int.Parse(Console.ReadLine());
          int c=int.Parse(Console.ReadLine());

          int c = 0;
          if (a > 0)
          {
              c++;
          }

          if (b > 0)
          {
              c++;
          }

          if (c > 0)
          {
              c++;
          }

          Console.WriteLine(c);

          //if5

          int a=int.Parse(Console.ReadLine());
          int b=int.Parse(Console.ReadLine());
          int s=int.Parse(Console.ReadLine());
          int c = 0;
          if (a > 0 || a < 0) ;
          {
              c++;
          }
          if (b > 0 || b < 0) ;
          {
              c++;
          }
          if (s > 0 || s< 0) ;
          {
              c++;
          }
          Console.WriteLine(c);

          //if 6

          int t=  int.Parse(Console.ReadLine());
          int y = int.Parse(Console.ReadLine());
          if (t > y)
          {
              Console.WriteLine(t);
          }

          if (t < y)
          {
              Console.WriteLine(y);
          }

          //if 7

          int t=  int.Parse(Console.ReadLine());
          int y = int.Parse(Console.ReadLine());
          if (t > y)
          {
              Console.WriteLine(1);
          }

          if (t < y)
          {
              Console.WriteLine(2);
          }

          //if 8

          int t=  int.Parse(Console.ReadLine());
          int y = int.Parse(Console.ReadLine());
          if (t > y)
          {
              Console.WriteLine(t);
              Console.WriteLine(y);
          }

          if (t < y)
          {
              Console.WriteLine(y);
              Console.WriteLine(t);
          }

          //if9

          int a = int.Parse(Console.ReadLine());
          int b = int.Parse(Console.ReadLine());
          if (a > b)
          {
              int p = a;
              a=b;
              b = p;
          }

          Console.WriteLine($"{a} {b}");

          //if 10

          int a = int.Parse(Console.ReadLine());
          int b = int.Parse(Console.ReadLine());

          if (a != b)
          {
              int s = a + b;
              a = s;
              b = s;
          }
          else
          {
              a = 0;
              b = 0;
          }

          Console.WriteLine($"{a} {b}");

        //if 20

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int B1 = Math.Abs(a - b);
        int C1 = Math.Abs(a - c);

        if (B1 < C1)
        {
            Console.WriteLine(B1);
        }
        else if (C1 < B1)
        {
            Console.WriteLine(C1);
        }
        else
        {
            Console.WriteLine("barobar");
        }

        //if 21

        int x=int.Parse(Console.ReadLine());
        int y=int.Parse(Console.ReadLine());

        if (x == 0 && y == 0)
        {
            Console.WriteLine("0 markaz");
        }
        if (y == 0 && x > 0)
        {
            Console.WriteLine("1 markaz");
        }
        if (x == 0 && y > 0)
        {
            Console.WriteLine("2 markaz");
        }

        if (x > 0 && y > 0)
        {
            Console.WriteLine("3 markaz");
        }


        // if 22

        int x=int.Parse(Console.ReadLine());
        int y=int.Parse(Console.ReadLine());

        if (x > 0 && y > 0)
        {
            Console.WriteLine("1 ");
        }
        if (y < 0 && x > 0)
        {
            Console.WriteLine("2");
        }
        if (x < 0 && y < 0)
        {
            Console.WriteLine("3");
        }

        if (x > 0 && y < 0)
        {
            Console.WriteLine("4");
        }

        //if 23

        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());

        int x4, y4;

        if (x1 == x2)
        {
            x4 = x3;
        }
        else if (x1 == x3)
        {
            x4 = x2;
        }
        else
        {
            x4 = x1;
        }

        if (y1 == y2)
        {
            y4 = y3;
        }
        else if (y1 == y3)
        {
            y4 = y2;
        }
        else
        {
            y4 = y1;
        }

        Console.WriteLine($"{x4} {y4}");



        //if 24

        int x=int .Parse(Console.ReadLine());
        if(x>0)
        {
           int x1= x * 2;
           Console.WriteLine(x1);
        }
        if(x<=0)
        {
            int x2= 6-x;
            Console.WriteLine(x2);
        }

        //if 25

        int x = int.Parse(Console.ReadLine());
        int f;

        if (x < -2 || x > 2)
        {
            f = 2 * x;
        }
        else
        {
            f = -3 * x;
        }

        Console.WriteLine(f);


        //if 26

        int x=int.Parse(Console.ReadLine());
        if (x < 0)
        {
           int c= x = -x;
            Console.WriteLine(c);
        }

        if (x < 2)
        {
           int c1= x* x;
           Console.WriteLine(c1);
        }

        if (x > 2)
        {
            int c2= x*4;
            Console.WriteLine(c2);
        }
        

        //if 27

        double x = double.Parse(Console.ReadLine());
        int f;

        if (x < 0)
        {
            f = 0;
        }
        else
        {
            int d = (int)Math.Floor(x);
            if (d % 2 == 0)
            {
                f = 1;
            }
            else
            {
                f = -1;
            }
        }

        Console.WriteLine(f);


        //if 28

        int year = int.Parse(Console.ReadLine());
        int days;

        if (year % 400 == 0)
        {
            days = 366;
        }
        else if (year % 100 == 0)
        {
            days = 365;
        }
        else if (year % 4 == 0)
        {
            days = 366;
        }
        else
        {
            days = 365;
        }

        Console.WriteLine(days);

        //if 29

        int n = int.Parse(Console.ReadLine());

        if (n == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            string s = (n > 0) ? "+" : "-";
            string p = (n % 2 == 0) ? "juft" : "toq";
            Console.WriteLine($"{s} {p} ");
        }
        
        //if 30
        
        
        int n = int.Parse(Console.ReadLine());

        string d;
        if (n < 10)
        {
            d = "1 raqama";
        }
        else if (n < 100)
        {
            d = "2 raqama";
        }
        else
        {
            d = "3 raqama";
        }

        string p= (n % 2 == 0) ? "juft" : "toq";

        Console.WriteLine($"{d} {p} ");
        */
}
