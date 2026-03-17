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
            ////Ticket t = new Ticket("Inception", 10);
            ////Console.WriteLine(t);
            ////Console.WriteLine("-----------------------");

            //StandardTicket st = new StandardTicket("1B", "The Matrix", 130);
            ////Console.WriteLine(st);
            ////Console.WriteLine("--------------------------");

            //VIPTicket vt = new VIPTicket(true, "Dumb And Dumber 2", 200);
            ////Console.WriteLine(vt);
            ////Console.WriteLine("--------------------------");

            //IMAXTicket it = new IMAXTicket(true, "Avatar 3", 300);
            ////Console.WriteLine(it);
            ////Console.WriteLine("--------------------------");


            //Console.WriteLine("=====================");

            //Cinema c = new Cinema(st, "City Stars");

            //c.OpenCinema();

            //c.AddTicket(st);

            //st.SetPrice(150m);
            //st.SetPrice(100m, 1.5m);
            //Console.WriteLine("==== Tickets ====");
            //c.PrintAllTickets(); // I have no idea how to print all tickets.. I thought I can make an array in the ctor of Ticket class and add it every call but I couldn't..
            //Console.WriteLine("===processing ticket===");
            //Cinema.ProcessTicket(st);

            //c.CloseCinema();

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

            #region Assignment 5
            #region Part01
            #region Q01
            //Interface is a contract that defines a set of methods and properties that a class must implement.
            //It specifies what a class can do.

            //We use interfaces to achieve abstraction and loose coupling in our code.
            //Avoid tight coupling between classes and promote code reusability.
            //Also Interfaces allow us to use multiple inheritance in C#.
            //Enable polymorphism without inheritance.
            #endregion

            #region Q02
            //a) the problem with this design is the function has the same name, while we inherit from multiple interfaces,
            // there will be conflict, will not result an error but it will be ambiguous which method to call.
            //also both methods in the interfaces will have the same implementation.

            //b) we can resolve it by using explicit interface implementation, which allows us to implement the methods of the interfaces separately.
            // like void IEnglishSpeaker.greet() and IArabicSpeaker.greet() and then we can call the methods by casting the object to the respective interface.
            //this technique is called explicit interface implementation.

            //c) can't call it directly from Translator class because it is implemented explicitly,
            // we need to cast the object to the respective interface to call the method, like ((IEnglishSpeaker)translator).greet();
            // or assign the object to a variable of the interface type and then call the method,
            // like :
            // Translator translator = new Translator();
            // IEnglishSpeaker englishSpeaker = translator;
            // englishSpeaker.greet().
            #endregion

            #region Q03
            //difference between a shallow copy and a deep copy
            //Shallow Copy creates a new object but copies the first level of the object,
            //while Deep Copy creates a new object and copies all the levels of the object.
            //-We use deep copy when we need to copy the object and make modification (Isolate),
            //without affecting the first object.
            //-We use shallow copy when we want to create a new object that shares the same data as the original object,
            //and we don't need to modify the data.
            //-it is risky when we make a shallow copy and modify the data, it will affect the original object as well,
            //because they share the same data.
            #endregion

            #region Q04
            //Console.WriteLine($"{e1.Title} - {e1.Dept.Name}");
            //Console.WriteLine($"{e2.Title} - {e2.Dept.Name}");
            //the change in the title here will only affect the e1 object because we made a shallow copy, and the e1.title will remain the same.
            //but the change in the department name will affect both e1 and e2
            //because they share the same department object, and we made a shallow copy.
            #endregion
            #endregion

            #region Movie Tickets System
            Projector p = new Projector();
            p.OpenCinema();
            Ticket t = new Ticket("Inception", 10);

            StandardTicket standard = new StandardTicket("1B", "The Matrix", 130);
            VIPTicket vip = new VIPTicket(true, "Dumb And Dumber 2", 200);
            IMAXTicket imax = new IMAXTicket(true, "Avatar 3", 300);

            Cinema cinema = new Cinema(standard, "City Stars");
            cinema.AddTicket(cinema.Ticket);
            cinema.PrintTicket();
            Console.WriteLine("==========================");
            //Clone a VIP ticket, change the clone's movie name, and print both to prove independence
            VIPTicket clonedVipTicket = (VIPTicket)vip.Clone();
            Console.WriteLine(vip);
            Console.WriteLine("====");
            Console.WriteLine(clonedVipTicket);
            Console.WriteLine(ReferenceEquals(vip,clonedVipTicket));

            Console.WriteLine("======================");
            clonedVipTicket.MovieName = "Dumb And Dumber 3";
            Console.WriteLine(vip);
            Console.WriteLine(clonedVipTicket);
            cinema.CloseCinema();
            #endregion
            #endregion
        }
    }
}
