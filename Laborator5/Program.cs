using System;

namespace Lab5POO
{
    class Program
    {
        public class A
        {
            protected string a;
            protected X x = new X("value");

            public A (string a, X x)
            {
                this.a = a;
                this.x = x;
    
            }
            public void print()
            {
                Console.WriteLine("Class A: ");
                Console.WriteLine(a);
                Console.WriteLine(x.getX());

            }

        }

        public class B : A
        {
            protected string b;
            public B(string a, string b, X x):base(a, x)
            {
                this.b = b;
            }
            public void print()
            {
                Console.WriteLine("Class B: ");
                Console.WriteLine(b);
                Console.WriteLine(x.getX());
                base.print();

            }


        }

        public class C : B
        {
            protected string c;

            public C(string a, string b, string c, X x):base(a, b, x)
            {
                this.c = c;
            }
            public void print()
            {
                Console.WriteLine("Class C: ");
                Console.WriteLine(c);
                Console.WriteLine(x.getX());
                base.print();

            }

        }

        public class D : C
        {
            protected string d;
            protected X x = new X("value1");


            public D(string a, string b, string c, string d , X x):base(a, b, c, x)
            {
                this.d = d;
            }
            public void print()
            {
                Console.WriteLine("Class D: ");
                Console.WriteLine(d);
                Console.WriteLine(x.getX());
                base.print();

            }

        }

        public class E : D
        {
            protected string e;
            public E(string a, string b, string c, string d, string e, X x) : base(a, b, c, d, x)
            {
                this.e = e;
            }
            public void print()
            {
                Console.WriteLine("Class E: ");
                Console.WriteLine(e);
                Console.WriteLine(x.getX());
                base.print();
            }
        }

        public class F : E
        {
            protected string f;
            public F(string a, string b, string c, string d, string e, string f, X x):base(a, b, c, d, e, x)
            {
                this.f = f;
            }
            public void print()
            {
                Console.WriteLine("Class F: ");
                Console.WriteLine(f);
                Console.WriteLine(x.getX());
                base.print();

            }


        }

        public class G : F
        {
            protected string g;
            public G(string a, string b, string c, string d, string e, string f, string g, X x) : base(a, b, c, d, e, f, x)
            {
                this.g = g;
            }
            public void print()
            {
                Console.WriteLine("Class G: ");
                Console.WriteLine(g);
                Console.WriteLine(x.getX());
                base.print();

            }
        }

        public class H : G
        {
            protected string h;
            protected X x = new X("value2");

            public H(string a, string b, string c, string d, string e, string f, string g, string h, X x) : base(a, b, c, d, e, f, g, x)
            {
                this.h = h;
            }
            public void print()
            {
                Console.WriteLine("Class H: ");
                Console.WriteLine(h);
                Console.WriteLine(x.getX());
                base.print();

            }

        }

        public class I : H
        {
            protected string i;
            public I(string a, string b, string c, string d, string e, string f, string g, string h,string i, X x) : base(a, b, c, d, e, f, g, h, x)
            {
                this.i = i;
            }
            public void print()
            {
                Console.WriteLine("Class I: ");
                Console.WriteLine(i);
                Console.WriteLine(x.getX());
                base.print();

            }

        }

        public class J : I
        {
            protected string j;
            public J(string a, string b, string c, string d, string e, string f, string g, string h, string i,string j, X x) : base(a, b, c, d, e, f, g, h, i, x)
            {
                this.j = j;
            }
            public void print()
            {
                Console.WriteLine("Class J: ");
                Console.WriteLine(j);
                Console.WriteLine(x.getX());
                base.print();
            }
        }

        public class X
        {
            private string name;
            public X(string x)
            {
                name = x;
            }
            public string getX()
            {
                return name;
            }
        }
        static void Main(string[] args)
        {
            J tenth_letter = new J("A", "B", "C", "D", "E", "F", "G", "H", "I", "J", new X("X"));

            tenth_letter.print();
            

        }
    }
}
