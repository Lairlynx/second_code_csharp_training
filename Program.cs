/*
Clase (obiecte)
-mutabile -modifica starea in timpul vietii
-imutabile -nu isi modifica starea in timpul vietii
*/
using System.Drawing;

namespace MyProgram2
{
    internal class MyProgram2
    {
        static void f(int x)
        {
            x++;
            Console.WriteLine(x);
        }

        static void ff(string s)
        {
            s = "casa";
            Console.WriteLine(s);
        }

        static void fff(Point p)
        {
            p.X = 99;
            p.Y = 13;
            Console.WriteLine(p);
        }

        static void swap(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }

        static void set (out int val)
        {
            val = 100;
        }

        struct Info
        {
            public int x;
            public int y;
        }

        static void Process(in Info info)
        {

        }

        static void Main(string[] args)
        {
            // 6. parametru in - pt tipuri valoare mari
            Info info = new Info();
            Process(in info);

            //5. parametrii out
            int qqq = 3;
            set(out qqq);
            Console.WriteLine(qqq); //? 3 sau 100

            //4. parametrii ref
            int xx = 1; int yy = 2;
            swap(ref xx, ref yy);
            Console.WriteLine(xx); //? 1 sau 2

            //3. pasare tip referinta -mutabil
            Point pp = new Point();
            pp.X = pp.Y = 5;
            fff(pp);
            Console.WriteLine(pp.X); //? 5 sau 99

            //2. pasare tip referinta
            string ss = "bec";
            ff(ss);

            //1. pasare tip valoare
            int q = 3;
            f(q);
            Console.WriteLine(q);
            //q =? 3, 4
        }
    }
}