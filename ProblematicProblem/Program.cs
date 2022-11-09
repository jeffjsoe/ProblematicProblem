//JESUS
using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem {

    public class ProblematicProblem
    {



        //A list should be inside of the main method or else it cant read the list
        static void Main(string[] args)
        {
            List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };
            bool cont = true;
            //Here we had to fix this error with activties by puting it inside the main method not outside of it
            //Here what we did was that we initilized a new object called random
            Random rng1 = new Random();

            while (cont)
            {
                Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
                //cont = bool.Parse(Console.ReadLine());
                var userinput = Console.ReadLine().ToLower();
                if (userinput == "yes")
                {
                    cont = true;

                }
                else
                {
                    cont = false;
                    Environment.Exit(0);    
                    //If this is false then it exits
                }




                Console.WriteLine();
                Console.Write("We are going to need your information first! What is your name? ");
                string userName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("What is your age? ");
                int userAge = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
                // bool seeList = bool.Parse(Console.ReadLine());
                bool seeList;
                var contResponce2 = Console.ReadLine().ToLower();
                seeList=(contResponce2=="Sure")? true:false;

                if (seeList)
                {
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }
                    Console.WriteLine();
                    Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                    //bool addToList = bool.Parse(Console.ReadLine());
                    bool addToList;

                    var contResponce3 = Console.ReadLine().ToLower();

                    addToList = (contResponce3 == "yes");



                    Console.WriteLine();
                    while (addToList)
                    {
                        Console.Write("What would you like to add? ");
                        string userAddition = Console.ReadLine();
                        activities.Add(userAddition);
                        foreach (string activity in activities)
                        {
                            Console.Write($"{activity} ");
                            Thread.Sleep(250);
                        }
                        Console.WriteLine();
                        Console.WriteLine("Would you like to add more? yes/no: ");
                        // addToList = bool.Parse(Console.ReadLine());

                        var contResponce4 = Console.ReadLine().ToLower();

                        addToList= (contResponce4 == "yes");

                    }
                }

                while (cont)
                {
                    Console.Write("Connecting to the database");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine();
                    Console.Write("Choosing your random activity");
                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }
                    Console.WriteLine();
                    //Here they store activities as a index in randomnumber. Then we just print out randomActivity1.
                    int randomNumber = rng1.Next(activities.Count);
                    //  string randomActivity1 = activities[randomNumber];
                    string randomActivity1 = "Wine Tasting";
                    if (userAge < 21 && randomActivity1 == "Wine Tasting")
                    {
                        Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity1}");
                        Console.WriteLine("Pick something else!");
                        activities.Remove(randomActivity1);
                        randomNumber = rng1.Next(activities.Count);
                        string randomActivity = activities[randomNumber];
                    }
                    Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity1}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                    Console.WriteLine();
                    //Whenever we update variable we dont put the variable type if it already has been initilzied
                    //cont = bool.Parse(Console.ReadLine());


                    


                    cont=(Console.ReadLine().ToLower()=="redo")? true: false;




                }
            }
        }
    }

}