using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           int num1 = 1;

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
            Console.WriteLine("10");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("11");
            Console.WriteLine("12");
            Console.WriteLine("13");
            Console.WriteLine("14");
            Console.WriteLine("15");
            Console.WriteLine("16");
            Console.WriteLine("17");
            Console.WriteLine("18");
            Console.WriteLine("19");
            Console.WriteLine("20");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("21");
            Console.WriteLine("22");
            Console.WriteLine("23");
            Console.WriteLine("24");
            Console.WriteLine("25");
            Console.WriteLine("26");
            Console.WriteLine("27");
            Console.WriteLine("28");
            Console.WriteLine("29");
            Console.WriteLine("30");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("31");
            Console.WriteLine("32");
            Console.WriteLine("33");
            Console.WriteLine("34");
            Console.WriteLine("35");
            Console.WriteLine("36");
            Console.WriteLine("37");
            Console.WriteLine("38");
            Console.WriteLine("39");
            Console.WriteLine("40");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("41");
            Console.WriteLine("42");
            Console.WriteLine("43");
            Console.WriteLine("44");
            Console.WriteLine("45");
            Console.WriteLine("46");
            Console.WriteLine("47");
            Console.WriteLine("48");
            Console.WriteLine("49");
            Console.WriteLine("50");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("51");
            Console.WriteLine("52");
            Console.WriteLine("53");
            Console.WriteLine("54");
            Console.WriteLine("55");
            Console.WriteLine("56");
            Console.WriteLine("57");
            Console.WriteLine("58");
            Console.WriteLine("59");
            Console.WriteLine("60");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("61");
            Console.WriteLine("62");
            Console.WriteLine("63");
            Console.WriteLine("64");
            Console.WriteLine("65");
            Console.WriteLine("66");
            Console.WriteLine("67");
            Console.WriteLine("68");
            Console.WriteLine("69");
            Console.WriteLine("70");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("71");
            Console.WriteLine("72");
            Console.WriteLine("73");
            Console.WriteLine("74");
            Console.WriteLine("75");
            Console.WriteLine("76");
            Console.WriteLine("77");
            Console.WriteLine("78");
            Console.WriteLine("79");
            Console.WriteLine("80");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("81");
            Console.WriteLine("82");
            Console.WriteLine("83");
            Console.WriteLine("84");
            Console.WriteLine("85");
            Console.WriteLine("86");
            Console.WriteLine("87");
            Console.WriteLine("88");
            Console.WriteLine("89");
            Console.WriteLine("90");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("91");
            Console.WriteLine("92");
            Console.WriteLine("93");
            Console.WriteLine("94");
            Console.WriteLine("95");
            Console.WriteLine("96");
            Console.WriteLine("97");
            Console.WriteLine("98");
            Console.WriteLine("99");
            Console.WriteLine("100");
            Console.ResetColor();


            while(num1 <= 100)

                if (num1 % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(num1);
                    Console.ResetColor();
                    num1++;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(num1);
                    Console.ResetColor();
                    num1++;
                }
                
            
        }

    }
}