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
            //Ticket t = new Ticket("Inception", 10);
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

            Cinema c = new Cinema(st, "City Stars");

            c.OpenCinema();

            c.AddTicket(st);

            st.SetPrice(150m);
            st.SetPrice(100m, 1.5m);
            Console.WriteLine("==== Tickets ====");
            c.PrintAllTickets(); // I have no idea how to print all tickets.. I thought I can make an array in the ctor of Ticket class and add it every call but I couldn't..
            Console.WriteLine("===processing ticket===");
            Cinema.ProcessTicket(st);

            c.CloseCinema();

            #endregion

            #region Questions of Assignment 4
            #region Part01 
            #region Q1
            //static binding happens when I make overloading, and happens at compile time,
            //dynamic binding happens when I make overriding, and happens at runtime.
            #endregion

            #region Q2
            //Overriding means that I can change the implementation of a method in a derived class
            //that is already defined in the base class.

            //overloading means that I can have multiple methods with the same name

            #endregion//but different parameters in the same class.

            #region Q3
            //keywords used for Method Overriding: override, virtual
            //we use virtual keyword in the base class to tell that this method can be overridden in the derived class,
            //and we use override keyword to edit the implementation of the method in the derived class.
            #endregion
            #endregion
            #endregion

        }
    }
}
