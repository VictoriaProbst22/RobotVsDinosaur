//Has Name, Attack Power and Health

class Dinosaur
{

    //Feilds

    public string name;
    public int attackPower;
    public int health;

    //Constructors
    public Dinosaur(string name, int attackPower, int health)
    {
        this.Name = name;
        this.AttackPower = attackPower;
        this.Health = 100;

    }

    //Properties

    public string Name
    { get; set; }

    public int AttackPower
    { get; set;}

    public int Health
    { get; private set; }


    //Methods - Has attack method

    public int Attack()
    {
        Health -= 10;
        return Health;
    }

}

