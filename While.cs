namespace Zadacha.Abramyan;

public class While
{
    static void Main()
    {
        //while 1
        
        
        double a=double.Parse(Console.ReadLine());
        double b=double.Parse(Console.ReadLine());
        while (a >= b)
        {
            a =a- b;
        }
        Console.WriteLine(a);
        
        
        //while 2
        
        double c =double.Parse(Console.ReadLine());
        double d=double.Parse(Console.ReadLine());
        int count = 0;
        while (c >= d)
        {
            c = c - b;
            count++;
            Console.WriteLine(count);
        }
        
        //while 3
        
        
        






    }
}