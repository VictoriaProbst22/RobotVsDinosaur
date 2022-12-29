// See https://aka.ms/new-console-template for more information

//runs game

class Program
{

        static void Main(string[] args)
        {
            //Display Welcome Message 
            string welcomeMessage = "Welcome to Robot V Dinosaur! An Epic Battle to See Who's the Best! Whats Your Guess on Who Will WIN?!";
            Console.WriteLine(welcomeMessage);

            //Enter Players
            Robot r = new Robot("Harold", 5, "Chainsaw");

             Dinosaur d = new Dinosaur("Kumar", 35);

             while(d.Health > 0 || r.Health > 0)
             {
                r.Attack(d);
                d.Attack(r);
             }

            //Display Winner
            if(r.health <= 0)
            {
                Console.WriteLine("Robot Won!");
            } else
            {
                Console.WriteLine("Dinosaur Won!");
            }

        }
         


}
    
   