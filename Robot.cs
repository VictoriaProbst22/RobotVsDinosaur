//Has a name, Health, Active Weapon


//properties
class Robot
{

    //Feilds
    public string name;
    public int health;
    public int weapon;


    //Constructors
    public Robot(string name, int health, int weapon)
    {
        this.Name = name;
        this.Health = health;
        this.Weapon = 25;

    }

    //Properties

    public string Name
    { get; set; }

    public int Health
    { get; set; }

    public int Weapon
    { get; private set; }

    //Method - Has attack Method

    public int Attack()
    {
        Health -= 10;
        Weapon =+ 5;
        return Health;

    }
}
