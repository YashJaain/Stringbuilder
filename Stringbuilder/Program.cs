using System;
using System.Text;

namespace String_builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your String here:- ");
            String str = Console.ReadLine();
            StringBuilder sb = new StringBuilder(str);
            int p = 0;
            while (p == 0) {
                Console.WriteLine("Type 1 for Append in the String:- ");
                Console.WriteLine("Type 2 for Remove in the String:- ");
                Console.WriteLine("Type 3 for Length in the String:- ");
                Console.WriteLine("Type 4 for Replace in the String:- ");
                Console.WriteLine("Type 5 for Insert in the String:- ");
                Console.WriteLine("Type 6 to show the String:- ");
                Console.WriteLine("Type 7 for Exit in the String:- ");
                int i = Convert.ToInt16(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Console.Write("Enter text that you want to append:- ");
                        String a = Console.ReadLine();
                        sb.Append(a);
                        break;
                    case 2:
                        Console.Write("Enter the place from where you want to remove:- ");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the place from where you want to end remove:- ");
                        int j = Convert.ToInt32(Console.ReadLine());
                        sb.Remove(f, j);
                        break;
                    case 3:
                        Console.Write($"Length of your String is:- {sb.Length}");
                        break;
                    case 4:
                        Console.Write("Enter text that you want to replace:- ");
                        String z = Console.ReadLine();
                        Console.Write("To which value you want to replace:- ");
                        String w = Console.ReadLine();
                        sb.Replace(z , w);
                        break;
                    case 5:
                        Console.Write("Enter text that you want to insert:- ");
                        String insert = Console.ReadLine();
                        Console.Write("At which place you want to insert:- ");
                        int place = Convert.ToInt32(Console.ReadLine());
                        sb.Insert(place, insert);
                        break;
                    
                    case 6:
                        Console.WriteLine("Current String:- "+sb);
                        break;
                    case 7:
                        p++;
                        break;
                    default:
                        Console.WriteLine("You have been entered Invalid input");
                        break;

                }
                
                
                
        }       }
    }
}
