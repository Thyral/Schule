using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        public virtual string Name { get { return "animal"; } }
        public virtual void WhoAreYou() { Console.WriteLine("I am an animal"); }
        public virtual bool Likes(string food)
        {
            return false;
        }
        public virtual void Speak() { }
    }

 class Dog : Animal
 {
     public override string Name { get { return "dog"; } }
     public override void WhoAreYou()
     {
         Console.WriteLine("I am a dog");
     }
     public override bool Likes(string food)
     {
         return food == "bones" || food == "meat";
     }
     public override void Speak() { Console.WriteLine("Wooff"); }
 }

    class Cat : Animal
    {
        public override string Name { get { return "cat"; } }
        public override void WhoAreYou()
        {
            Console.WriteLine("I am a cat");
        }

        public override bool Likes(string food)
        {
            return food == "fishy" || food == "flesh"; 
        }

        public override void Speak() { Console.WriteLine("Meow"); }
    }

   
    
    class Cow : Animal
    {
        public override string Name { get { return "cow"; } }
        public override void WhoAreYou()
        {
            Console.WriteLine("I am a cow");
        }

        public override bool Likes(string food)
        {
            return food == "gras" || food == "flowers";
        }

        public override void Speak() { Console.WriteLine("Muh"); }
       

 static void Main(string[] args)
        {
            Animal[] farm = { new Cow(), new Dog(), new Cow(), new Cat(), new Cat()};
            foreach (Animal a in farm)
                if (a.Likes("fish")) a.Speak();
                else Console.WriteLine("A " + a.Name + " does not like fish");
            


        }
    }
}
