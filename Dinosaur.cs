//Has Name, Attack Power and Health

class Dinosaur
{

    //Feilds and Properties

    public string Name
    { get; set; }

    public int AttackPower
    { get; set;}

    public int Health
    { get; private set; }

    //Constructors
    public Dinosaur(string name, int attackPower)
    {
        this.Name = name;
        this.AttackPower = attackPower;
        this.Health = 100;

    }

   


    //Methods - Has attack method

    public virtual int Attack(Robot r)
    {
        Health -= 10;
        Console.WriteLine($"Hit!! {Name} has {Health} !");

        return Health;
    }

}

