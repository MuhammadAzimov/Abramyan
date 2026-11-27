using System.Security.Cryptography.X509Certificates;

namespace Zadacha.Abramyan;

public class For
{
   /*
       //for1
       
       int a=int.Parse(Console.ReadLine()); 
       int b = int.Parse(Console.ReadLine());
       for (int i = 0; i < b; i++)
       {
           Console.WriteLine(a);
       }
       
        
       //for2
       
       int s=int.Parse(Console.ReadLine());
       int d=int.Parse(Console.ReadLine());
       int n = 0;
       for (int i = s; i <= d; i++ )
       {
           Console.WriteLine(i);
           n++;
       }
       Console.WriteLine(n);
       
       
       //for 3
       
       int a=int.Parse(Console.ReadLine());
       int b=int.Parse(Console.ReadLine());
       int w = 0;
       for (int i = b-1; i >a; i-- )
       {
           Console.WriteLine(i);
           w++;
       }
       Console.WriteLine(w);

       
        //for 4
        
        
        double price=double.Parse(Console.ReadLine());
        for (double kg = 1; kg <= 10; kg++)
        {
            double c= kg* price;
           Console.WriteLine(c);
        }
        
        //for5
        
        double kg=double.Parse(Console.ReadLine());
        for (double i = 1; i <= 10; i++)
        {
            double c= i/10.0;
            Console.WriteLine(c);
        }

            //for6
            
            double kg=double.Parse(Console.ReadLine());
            for (double i = 1.2; i <= 2.0001; i+=0.2)
            {
                double c= i*kg;
                Console.WriteLine(c);
            }  
         
             
             //for 7
             
             int a=int.Parse(Console.ReadLine());
             int b=int.Parse(Console.ReadLine());
             int sum = 0;
             for (int i = a; i <= b; i++)
             {
                 sum = sum + i;
                 Console.WriteLine(sum);
             }
             
                 
                 //for 8
                 
                 int a=int.Parse(Console.ReadLine());
                 int b=int.Parse(Console.ReadLine());
                 int sum = 0;
                 for (int i = a; i <= b; i++)
                 {
                     sum = sum * i;
                     Console.WriteLine(sum);
                 } 
                 
                 
                 //for 9
                 
                 
                 int a=int.Parse(Console.ReadLine());
                 int b=int.Parse(Console.ReadLine());
                 int summ = 0;
                 for (int i = a; i <= b; i++)
                 {
                      summ += i*i;
                 }
                 Console.WriteLine(summ);

                 //for 10
                 
                 int n=int.Parse(Console.ReadLine());
                 double sum = 0;
                 for (int i = 1; i <= n; i++)
                 {
                      sum+= 1.0/i;
                     
                 }

                 Console.WriteLine(sum);
                 
        
        
          //for 11

          int n = int.Parse(Console.ReadLine());
          int sum = 0;
          for (int i = n; i <= 2 * n; i++)
          {
              sum += i * i;
        
          }
          Console.WriteLine(sum);
          
          //for12
          
          int N = int.Parse(Console.ReadLine());
          double p= 1;
          for (int i = 1; i <= N; i++)
          {
              p += 1+i*0.1;
        
          }
          Console.WriteLine(p);
          
          //for 13
          
          
          int a=int.Parse(Console.ReadLine());
          double sum = 0;
          int sign = 1;
          for (int i = 1; i <= a; i++)
          {
              sum += sign * (1 + i * 0.1);
              sign = -sign;
          }

          Console.WriteLine(sum);
          
          
          //for 14
          
          int b=int.Parse(Console.ReadLine());
          int summ = 0;
          for (int i = 1; i <= b; i++)
          {
              summ += 2 * i - 1;
              
          }

          Console.WriteLine(summ);
          
          //for 15

          int k = int.Parse(Console.ReadLine());
          int t=int.Parse(Console.ReadLine());
          double sumn = 1;
          for (int i = 1; i <=t;i++)
          {
              sumn = sumn * k;

          }

          Console.WriteLine(k);
          
          //for 16

          int[][] a = new int [3][];
          a[0] = new int [] { 1, 2, 3 };
          a[1] = new int [] { 1, 2, 3 ,4};
          a[2] = new int [] { 1, 2, 3 };
          for (int i = 0; i< a.Length; i++)
          {
              for (int j = 0; j < a[i].Length; j++)
              {
               Console.Write(a[i][j]);
              }
          }
          
          


        string[] name = { "Ali", "Vali", "Sali" };

        int[][] students = new int [3][];
        
            students[0] = new int  []{1,2,3,4};
            students[1] = new int  []{1,2,3,4,5,6};
            students[2] = new int  []{1,2,3,4,5};
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 0; j < students[i].Length; j++)
                {
                    Console.WriteLine(name[i]);
                    Console.Write(students[i][j]);
                }
            }
           

          //for 17
          
        double a=double.Parse(Console.ReadLine());
        int b=int.Parse(Console.ReadLine());
        double p = 1;
        double  s = 1;
        for (int i = 1; i <= b; i++)
        {
            p*=a;
            s+=p;
            Console.WriteLine($"{p},{s}");
        }
       
        
        
        //for 18
        
        
        double a=double.Parse(Console.ReadLine());
        int b=int.Parse(Console.ReadLine());
        double p = 1;
        double  s = 1;
        double sum = 1;
        for (int i = 1; i <= b; i++)
        {
            p*=a;
            s+=p;
            sum += s * p;
            Console.WriteLine($"{p},{s},{sum}");
        }

      
          
          
          //for 19

          
          
          int a=int.Parse(Console.ReadLine());
          double sum = 1;
          double prod = 1;
          for (int i = 1; i <= a; i++)
          {
              sum=prod*i;
          }

          Console.WriteLine(sum);


         //for 20
         
         int a=int.Parse(Console.ReadLine());
         double sum = 1;
         double prod = 1;
         for (int i = 1; i <= a; i++)
         {
             prod*=i;
             sum = +prod;
         }

         Console.WriteLine(sum);
         
         
         //for 21
         
         
         int a=int.Parse(Console.ReadLine());
         double sum = 1;
         double prod = 1;
         for (int i = 1; i <= a; i++)
         {
             prod*=i;
             sum +=1.0/prod;
         }
 
         //for 22.
         double a=double.Parse(Console.ReadLine());
         int b=int.Parse(Console.ReadLine());
         double sum = 1;
         double prod = 1;
         Double fact = 1;
         for (int i = 1; i <= b; i++)
         {
             prod*=a;
             fact *= i;
             sum +=fact/prod;
         }

         Console.WriteLine(sum);
         
         //for23
         
        double x=double.Parse(Console.ReadLine());
        int n=int.Parse(Console.ReadLine());
        double term = x;
        double sum = x;
        int sign = 1;
        for (int i = 1; i <= n; i++)
        {
            term = term * x * x / ((2 * i) * (2 * i + 1));
            sign = -sign;
            sum += term * sign;
        }

        Console.WriteLine(sum);
        
        //for 24
        
        double x=double.Parse(Console.ReadLine());
        int n=int.Parse(Console.ReadLine());
        double term = x;
        double sum = x;
        int sign = 1;
        for (int i = 1; i <= n; i++)
        {
            term = term * x * x /(2 * i + 1)* ((2 * i) );
            sign = -sign;
            sum += term * sign;
        }

        Console.WriteLine(sum);


        
        
        //for 25
        
        
        double x=double.Parse(Console.ReadLine());
        int n=int.Parse(Console.ReadLine());
        double term = x;
        double sum = x;
        int sign = 1;
        for (int i = 1; i <= n; i++)
        {
            term = term * x * x /(2 * i + 1)* ((2 * i) );
            sign = -sign;
            sum += term * sign;
        }

        Console.WriteLine(sum);

        double x=double.Parse(Console.ReadLine());
        int n=int.Parse(Console.ReadLine());
        double term = 1;
        double sum = 0;
        int sign = 1;
        for (int i = 1; i <= n; i++)
        {
            term *= x;
            sign = -sign;
            sum += sign * (term / i);
        }

        Console.WriteLine(sum);
        
        
        
        
        //for 26
        
        
        double x=double.Parse(Console.ReadLine());
        int n=int.Parse(Console.ReadLine());
        double term = x;
        double sum = x;
        int sign = 1;
        for (int i = 1; i <= n; i++)
        {
            term *= x * x;
            sign = -sign;
            sum += sign * (term / (2 * i + 1));
        }

        Console.WriteLine(sum);
 
        
        
        
        
        //for 27
        
        double x=double.Parse(Console.ReadLine());
        int n=int.Parse(Console.ReadLine());
        double term = x;
        double sum = x;
        
        for (int i = 1; i <= n; i++)
        {
            
            term = term * x * x * (2 * i - 1) / ((2 * i) * (2 * i + 1));
            sum += term;
        }

        Console.WriteLine(sum);
        
        
        
        //for 28
        
        double x=double.Parse(Console.ReadLine());
        int n=int.Parse(Console.ReadLine());
        double term = x;
        double sum = x;
        int sign = 1;
        for (int i = 1; i <= n; i++)
        {
            term = term * x * (2 * i - 3) / (2 * i);
            sign = -sign;
            sum += sign * (term / (2 * i + 1));
        }

        Console.WriteLine(sum);
        
        
        //for 29
        
        int n = int.Parse(Console.ReadLine());
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = (b - a) / n;Console.WriteLine(h);
        for (int i = 0; i <= n; i++)
        {
            double x = a + i * h;

            double f = 1 - Math.Sin(x);
            Math.Sin(x);
            Console.WriteLine($"x = {x}, f = {f}");
            Console.WriteLine(f);
        }
        
        
        //for 30
        
        int n = int.Parse(Console.ReadLine());
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = (b - a) / n;Console.WriteLine(h);
        for (int i = 0; i <= n; i++)
        {
            double x = a + i * h;

            double f = 1 - Math.Sin(x);

            Console.WriteLine(f);
        }
        
        
        //for 31

        int n = int.Parse(Console.ReadLine());
        double a = 2;
        Console.WriteLine(a);
        for (int k = 1; k <= n; k++)
        {
            a = 2 + 1.0 / a;
            Console.WriteLine(a);
        }

        
        
        //for 32
        
     
        int n = int.Parse(Console.ReadLine());
        double a = 1;
        Console.WriteLine(a);
        for (int k = 1; k <= n; k++)
        {
            a = (a + 1.0) / k;
            Console.WriteLine(a);
        }
        
        
        //for 33
        
        
        int a=int.Parse(Console.ReadLine());
        int p1 = 1;
        int p2 = 1;
        Console.WriteLine($"{p1} + {p2} ");
        for (int k = 3; k <= a; k++)
        {
            int c = p1 + p2;
            Console.WriteLine(c);
        }
        //for 34
        
        int a=int.Parse(Console.ReadLine());
        double p1 = 2;
        double p2 = 1;
        Console.WriteLine($"{p1} + {p2} ");
        for (int k = 3; k <= a; k++)
        {
            double c = (p1 +2* p2)/3.0;
            Console.WriteLine(c);
        }
        
        //for 35
        
        
        int a=int.Parse(Console.ReadLine());
        int  p1 = 1;
        int  p2 = 2;
        int p3 = 3;
        Console.WriteLine($"{p1} + {p2}+{p3} ");
        for (int k = 4; k <= a; k++)
        {
            double c =( p3 + p2 * 2 / p1);
            Console.WriteLine(c);
        }
        
        
        //for 36



        int n = int.Parse(Console.ReadLine());
        int k=int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)

        {
            sum += Math.Pow(i, k);
            Console.WriteLine(sum);
        }
        
        
        
        //for 37
        
        
        
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)

        {
            sum += Math.Pow(i, i);
            Console.WriteLine(sum);
        }
        
        //for 38
        
        
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)

        {
            sum += Math.Pow(i,n-i+ 1);
            Console.WriteLine(sum);
        }
        
        
        //for 39
        
        int a=int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            for (int j = 1; i <= i; i++)
            {
                Console.WriteLine(i);
            }
        }
        
        
        //for 40
        
        
        int a=int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        for (int i = a; i <= b; i++)
        {
            int count = i - a + 1;
            for (int j = 1; i <= count; i++)
            {
                Console.WriteLine(i);
            }
        }
        */
    }
    
