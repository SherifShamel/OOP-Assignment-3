using OOP___Assignment03.Classes;

namespace OOP___Assignment03
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //a) Composition Relationship
            //b) Association Relationship
            //c) Inheritance Relationship
            //d) Aggregation Relationship
            //e) Dependency Relationship
            #endregion

            #region Q2
            //a) a parent class with a protected field: can be accessed by derived classes inside and outside the assembly.
            //b) Protected Internal: Accessible within the same assembly or project and by derived classes, even if they are in different assemblies.
            //Private Protected: Accessible only within the containing class and derived classes.
            //c) sealed keyword means that the class cannot be inherited. It is used to prevent other classes from deriving from it.
            //When a method is sealed , it cannot be overridden by any derived class. This is useful when you want to prevent further modification of a method's behavior in subclasses.
            //d) Yes, can create an instance of a sealed class using new() keyword.
            //Because sealing a class only prevents it from being inherited, but it can still be instantiated like any other class. 
            #endregion

            #region Part 2
            Ticket t = new Ticket("Inception", 10);
            //Console.WriteLine(t);
            //Console.WriteLine("-----------------------");

            StandardTicket st = new StandardTicket("1B", "The Matrix", 130);
            //Console.WriteLine(st);
            //Console.WriteLine("--------------------------");

            VIPTicket vt = new VIPTicket(true, "Dumb And Dumber 2", 200);
            //Console.WriteLine(vt);
            //Console.WriteLine("--------------------------");

            IMAXTicket it = new IMAXTicket(true, "Avatar 3", 300);
            //Console.WriteLine(it);
            //Console.WriteLine("--------------------------");


            Console.WriteLine("=====================");

            Cinema c = new Cinema(t, "City Stars");

            c.OpenCinema();
            
            c.AddTicket(t);
            c.PrintAllTickets(); // I have no idea how to print all tickets.. I thought I can make an array in the ctor of Ticket class and add it every call but I couldn't..
            c.CloseCinema();

            #endregion

        }
    }
}
