using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5a
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print_a_2_z_v1();
            //Print2();
            //Print_a_2_z_v2();
            //Print_a_2_z_v3();
            //Print_a_2_z_v4();

            //while (true)
            {

                char c = Console.ReadKey().KeyChar;
                Console.WriteLine(" " + Char2Code(c));

            }

            Console.WriteLine(" " + IsUpper('A'));
            //Console.WriteLine(ToUpper('a'));
           // Console.WriteLine(" " + IsLower('A'));
            //Console.WriteLine(ToLower('A'));


        }
        public static void Print_a_2_z_v1()
        {
            for (int i = 97; i < 123; i++)
            {
                Console.Write((char)i);
            }
        }
        public static void Print_a_2_z_v2()
        {
            char c = ' ';
            for (int i = 97; i <= 122; i++)
            {
                c = (char)i;
                Console.Write(c);
            }
        }
        public static void Print_a_2_z_v3()
        {
            char c = 'a';
            for (int i = 0; i < 26; i++)
            {
                Console.WriteLine(c);
                c++;
            }
        }
        public static void Print_a_2_z_v4()
        {
            for (char c = 'a'; c <= 'z'; c++)
            {
                Console.WriteLine(c);
            }
        }
        public static void Print2()
        {
            for (int i = 122; i > 96; i--)
            {
                Console.Write((char)i);
            }
            //3//
            for (int i = 65; i < 91; i++)
            {
                Console.Write((char)i);
            }
            //4//
            for (int i = 0; i < 256; i++)
            {
                Console.WriteLine((char)i);
                Console.WriteLine(i);
            }
        }
        public static int Char2Code(char c)
        {
            return (int)c;
        }
        public static bool IsUpper(char d)
        {
            for (int i = 65; i < 91; i++)
            {
                Console.Write((char)i);
                if(d.Equals((char)i))
                    return true;
            }
           
            return false;
        }
        public static bool IsLower(char c)
        {
            return false;
        }
        public static char ToUpper(char a)
        {
            int c=Char2Code(a);
            c=c-32;
            a=(char)c;
            return a;
        }
        public static char ToLower(char a)
        {
             int c=Char2Code(a);
            c=c+32;
            a=(char)c;
            return a;
        }
    }
}