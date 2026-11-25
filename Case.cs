namespace Zadacha.Abramyan;

public class Case
{
     /*
        // Case1
        Console.WriteLine("week");
        int k = int.Parse(Console.ReadLine());
        switch (k)
        {
            case 1:
                Console.WriteLine("Mondey");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Mondey");
                break;
        }
        // case 2


        Console.WriteLine("rate it");
        int Rate = int.Parse(Console.ReadLine());
        switch (Rate)
        {
            case 1:
                Console.WriteLine("khub");
                break;
            case 2:
                Console.WriteLine("qanoatmand");
                break;
            case 3:
                Console.WriteLine("miyona");
                break;
            case 4:
                Console.WriteLine("bad");
                break;
            case 5:
                Console.WriteLine("xele bad");
                break;
            default:
                Console.WriteLine("x");
                break;
        }

        // Case 3

        Console.WriteLine("Month");
        int Season = int.Parse(Console.ReadLine());
        Console.WriteLine("Month");
        int Month = int.Parse(Console.ReadLine());
        switch (Season)
        {
            case 1:
                switch (Month)
                {
                    case 1: Console.WriteLine("Winter - January "); break;
                    case 2: Console.WriteLine("Winter - February "); break;
                    case 3: Console.WriteLine("Winter - December "); break;
                    default: Console.WriteLine("xato (1-3)"); break;
                }

                break;
            case 2:
                switch (Month)
                {
                    case 1: Console.WriteLine("Spring - March "); break;
                    case 2: Console.WriteLine("Spring - April"); break;
                    case 3: Console.WriteLine("Spring - May"); break;
                    default: Console.WriteLine("xato (1-3)"); break;
                }

                break;
            case 3:
                switch (Month)
                {
                    case 1: Console.WriteLine("Summer - June"); break;
                    case 2: Console.WriteLine("Summer - Jule"); break;
                    case 3: Console.WriteLine("Summer - August"); break;
                    default: Console.WriteLine("xato (1-3)"); break;
                }

                break;
            case 4:
                switch (Month)
                {
                    case 1: Console.WriteLine("Autumn - September"); break;
                    case 2: Console.WriteLine("Autumn - Oktober"); break;
                    case 3: Console.WriteLine("Autumn - November"); break;
                    default: Console.WriteLine("xato (1-3)"); break;
                }

                break;
            default:
                Console.WriteLine("x");
                break;

                //Case 4

                Console.WriteLine("month 31.30.28");
                int month = int.Parse(Console.ReadLine());
                switch (month)
                {
                    case 31 :
                        Console.WriteLine("1, 3, 5, 7, 8, 10, 12"); break;
                    case 30:
                        Console.WriteLine("4,6,9,11"); break;
                    case 29:
                        Console.WriteLine("2"); break;
                }
                
                //Case 5

            
                double a=double.Parse(Console.ReadLine());
                double b=double.Parse(Console.ReadLine());
                Console.WriteLine("1+.2-.3/.4*");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        double v = a + b;
                        Console.WriteLine(v); break;
                    case 2:
                          double r= a - b;
                        Console.WriteLine(r); break;
                    case 3:
                        double t = a / b;
                        Console.WriteLine(t); break;
                    case 4:
                        double h = a * b;
                        Console.WriteLine(h); break;
                    default: Console.WriteLine("x"); break;
                }
                
        //case 6
        
        
        double a=double.Parse(Console.ReadLine());

        string  n =string Console.ReadLine();
        switch (n)
        {
            case "DM":
                double v = a /  n;
                Console.WriteLine(v); break;
            case "KM":
                double r= a *1000;
                Console.WriteLine(r); break;
            case "M":
                Console.WriteLine(a); break;
            case "MM":
                double h = a * 100;
                Console.WriteLine(h); break;
            case "SM":
                double l = a  /1000;
                Console.WriteLine(l); break;
            default: Console.WriteLine("x"); break;
        }
        
        //Case 7
        
        double a=double.Parse(Console.ReadLine());
        string  n =string Console.ReadLine();
        switch (n)
        {
            case "DM":
                double v = a / a;
                Console.WriteLine(v); break;
            case "KM":
                double r= a *1000;
                Console.WriteLine(r); break;
            case "M":
                Console.WriteLine(a); break;
            case "MM":
                double h = a * 100;
                Console.WriteLine(h); break;
            case "SM":
                double l = a  /1000;
                Console.WriteLine(l); break;
            default: Console.WriteLine("x"); break;
        }
        
        //Case 8
        
        int d = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        d--;

        if (d == 0)
        {
            m--;
            if (m == 0)
            {
                m = 12;
            }

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    d = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    d = 30;
                    break;
                case 2:
                    d = 28;
                    break;
            }
        }

        Console.WriteLine($"{d} {m}");
        
        // Case 9
        
          int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            d++;

            int maxDays = 31;
            switch (m)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    maxDays = 30;
                    break;
                case 2:
                    maxDays = 28;
                    break;
            }

            if (d > maxDays)
            {
                d = 1;
                m++;
                if (m > 12)
                {
                    m = 1;
                }
            }

            Console.WriteLine($"{d} {m}");
            
        
            
            //Case 10
            
            char c = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 0:
                    break;
                case 1: 
                    c = c switch
                    {
                        'N' => 'W',
                        'W' => 'S',
                        'S' => 'E',
                        'E' => 'N',
                        _ => c
                    };
                    break;
                case -1:
                    c = c switch
                    {
                        'N' => 'E',
                        'E' => 'S',
                        'S' => 'W',
                        'W' => 'N',
                        _ => c
                    };
                    break;
            }

            Console.WriteLine(c);
*/
    }
    


