


//######## Abstraction ########//

/*
using System;
abstract class Math
{
    public void add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public void sub(int a, int b)
    {
        Console.WriteLine(a - b);
    }
    public abstract void mul(int a, int b);
    public abstract void div(int a, int b);     
}
    class Cal : Math
{
    public override void mul(int a, int b)
    {
        Console.WriteLine(a * b);
    }
    public override void div (int a, int b)
    {
        Console.WriteLine(a / b);
    }
    static void Main(string[] args)
    {
        Cal C =new Cal();
        C.add(25, 25);
        C.sub(100, 25);
        C.mul(25, 25);
        C.div(100, 25);
    }
}
    
*/



//########## Interface ##########// 


/*
* using System;


   interface IFirstName
   {
       void FirstName();
   }
   interface ILastName
   {
       void LastName();
   }

class FullName : IFirstName, ILastName
{
   public void FirstName()
   {
   Console.Write("Abhijeet ");
       }
   public void LastName()
   {
       Console.WriteLine("Chanale");
   }
}
class Program
{
   static void Main(string[] args)
   {
       FullName name= new FullName();
       name.FirstName();
       name.LastName();
   }

}
*/


//######### Multiple Inheritance ########//



/*
using System;  
   public class Animal
{
    public void eat()
    {
        Console.WriteLine("Eating...");
    }
}
public class Dog : Animal
{
    public void run()
    {
        Console.WriteLine("Running...");
    }
}
public class Cat : Animal, Dog
{
    public void sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}
class TestInheritance
{
    public static void Main(string[] args)
    {
        Dog d1 = new Dog();
        d1.eat();
        d1.run();

        Cat c1 = new Cat();
        c1.eat();
        c1.sleep();
        Console.ReadLine();
    }
}

*/

  //######### hierarchical Inheritance ########//}
/*

using System;
class Teacher
{
    public void program()
    {
        Console.WriteLine("C# Programming...");
    }
    public void physics()
    {
        Console.WriteLine("Physics Lecture");
    }
    public void chemistry()
    {
        Console.WriteLine("Chemistry Lecture");
    }
}
class ComputerDepartment:Teacher
{
    public void learn()
    {
        Console.WriteLine("Programming...");
    }
        
}

class ScienceDeparment:Teacher
{
    public void learn()
    {
        Console.WriteLine("Science...");
    }

}
class HierarchicalTest
{
    public static void Main(string[] args)
    {
        ComputerDepartment cd= new ComputerDepartment();
        cd.learn();
        cd.program();

        ScienceDeparment sc= new ScienceDeparment();
        sc.learn();
        sc.physics();
        sc.chemistry();
    }
}
*/





//######### Runtime Polymorphism #########//



/*
using System;
namespace Application
{
    class Gadget
    {
        public virtual void MoFeature()
        {
            Console.WriteLine("Every Mobile have different feature");      
        }
    }

    class SamsungA1: Gadget
    {
        public override void MoFeature()
        {
            Console.WriteLine("SamsungA1 4gb ram 64gb rom");
        }
    }
    class SamsungA2 : Gadget
    {
        public override void MoFeature()
        {
            Console.WriteLine("SamsungA2 6gb ram 120gb rom ");
        }
    }
    class SamsungA3 : Gadget
    {
        public override void MoFeature()
        {
            Console.WriteLine("SamsungA3 8gb ram 512gb rom");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Gadget g = new Gadget();
            SamsungA1 A1 = new SamsungA1();
            SamsungA2 A2 = new SamsungA2();
            SamsungA3 A3 = new SamsungA3();

            g.MoFeature();
            A1.MoFeature();
            A2.MoFeature();
            A3.MoFeature();
        }
    }
}
*/



//######## Compile Time Polymorphism ########//



using System;
class Staff
{
    public void Salary(int a)
    {
        Console.WriteLine("1st emp salary is 1,50,000");
    }
    public void Salary(String b)
    {
        Console.WriteLine("2nd emp salary is 2,50,000");
    }
    public void Salary(int a, string b)
    {
        Console.WriteLine("3rd emp salary is 3,50,000");
    }

}
class AllEmp
{
    public static void Main(string[] args)
    {
        Staff s = new Staff();
        s.Salary(1);
        s.Salary("a");
        s.Salary(1, "A");
    }
}



     
