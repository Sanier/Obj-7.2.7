using System;

namespace Obj_7._2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        class A
        {
            public virtual void Display()
            {
                Console.WriteLine("A");
            }
        }

        class B : A
        {
            public new void Display()
            {
                //base.Display();
                Console.WriteLine("B");
            }
        }

        class C : A
        {
            public override void Display()
            {
                //base.Display();
                Console.WriteLine("C");

            }
        }

        class D : B
        {
            public new void Display()
            {
                Console.WriteLine("D");
            }
        }

        class E : C
        {
            public new void Display()
            {
                Console.WriteLine("E");
            }
        }
    }
}
