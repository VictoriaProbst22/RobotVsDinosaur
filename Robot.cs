//Has a name, Health, Active Weapon


//properties
class Robot
{

    //Feilds
    public string name;
    public string weaponName;
    public int health;
    public int weapon;

    


    //Constructors
    public Robot(string name, int weapon, string weaponName) 
    {
        this.Name = name;
        this.Health = 100;
        this.Weapon = 25;
        this.WeaponName = "Chainsaw";

    }

    //Properties

    public string WeaponName
    { get; set; }
    public string Name
    { get; set; }

    public int Health
    { get; set; }

    public int Weapon
    { get; private set; }

    //Method - Has attack Method

    public virtual int Attack(Dinosaur d)
    {
        Health -= 10;
        Weapon -= 5;

        Console.WriteLine($"Hit!! {Name} has {Health} !");

        return Health;
        
        

    }

    

}

