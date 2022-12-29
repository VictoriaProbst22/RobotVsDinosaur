//Has a name, Health, Active Weapon

class Robot
{

    //Feilds and Properties
     public string WeaponName
    { get; set; }
    public string Name
    { get; set; }

    public int Health
    { get; set; } 
    public int Weapon
    { get; private set; }


    //Constructors
    public Robot(string name, int health, string weapon)
    {
        this.Name = name;
        this.Health = health;
        this.Weapon = 25;
        this.WeaponName = "Chainsaw";

    }

    

   

   

    //Method - Has attack Method

    public virtual void Attack()
    {
        Health -= 10;
        Weapon =+ 5;
        
        if(Health > 0)
        {
            Console.WriteLine("Dinosaur Won!");
        } else
        {
            Console.WriteLine("Robot Won!");
        }
        

    }

    

}

