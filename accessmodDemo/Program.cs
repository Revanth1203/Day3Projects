using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using accessmodDemo;


namespace accessmodDemo
{
    class abcd
    {
        private int a = 1;
        public int b = 2;
        protected int c = 3;
    
    public void seta(int k)
    {
        this.a = k;
    }

    public int geta()
    {
        return this.a;
    }
    
    class Program:abcd
    {
            static void Main(string[] args)
            {
                abcd abcdobj = new abcd();
                Program pp = new Program();
                //and see which can be accessed which cannot 
                // i can touch and display b using both class objects as it is public 
                Console.WriteLine($"b i can touch using base class obj and display {abcdobj.b}");
                Console.WriteLine($"b i can touch using sub class obj and display {pp.b}");
                // i cannot do this 
                //abcdobj.a  // error private...
                //pp.a // error private
                // abcdobj.c // error only sub class can use even it is there in main class 
                Console.WriteLine($"c i can touch using sub class obj and display {pp.c}");
                // Console.WriteLine($"{abcd.c}"); //error

                pp.seta(1);
                Console.WriteLine($"{pp.geta()}");

            }

        }
    }
}
/*Access Modifiers or specifiers :
---------------------------------
private ,public ,protected ,internal and protected internal

so this comes under encapsulation data hiding which part of the program i want to show
and which i want to hide is decided by these access specifiers in the program .


private : directly cannot access this u need set and get methods (Be defualt it is private if u dont give any access specifier )

public : can be accessible outside the class

protected : only sub class can access the variable defined as protected in base class

internal : you can access within the assembly or within the namespace only.

protected internal : you can access across assembly but it should be inherited.

when u have an entry point function like main .exe file will be created and when
you have normal class a dll file will be created.so you cannot execute dll file it can be used as an component in some other program or in an exe.

so in this what u do 	create an or add a project of new as clas library and
inside that class create a varibale as internal and try to access it using adding refernce and
including namespace also then also it will not highlight and same thing making it protected internal and
inheriting in main progam the class then    it will highlight eventhough u are from seperate assembly.*/