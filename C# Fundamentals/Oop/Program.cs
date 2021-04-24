using System;

namespace Oop
{
     class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes sound");
        }
    }
    
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says:wee wee");
        }
    }
    abstract class Eating
    {
        public abstract void sleep();
        public void eating()
        {
            Console.WriteLine("Eating....");
        }

    }
    class Dog:Eating
    {
        public override void sleep()
        {
            Console.WriteLine("Zzz..");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal obj =new Animal();
            Animal obj1 = new Pig();
            Dog obj2 = new Dog();
            obj.animalSound();
            obj1.animalSound();
            obj2.sleep();
            obj2.eating();
        }
    }
}
