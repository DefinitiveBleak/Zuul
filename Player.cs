class Player
{
    //fields
    private static int health;
    public static int Health
    {
        get{return health;}
        private set{ health = Math.Max(0,value); }
    }
    //auto property
    public Room CurrentRoom {get; set;}

    //constructor
    public Player()
    {
        CurrentRoom = null;
        health = 100;
    }

//methods
void IsAlive(){
    if(health <= 0){
        Console.Clear();
        Console.WriteLine("Game over");
    }
    

}
void Heal(int amount){
    health += amount;
}

void Damage(int amount){
    health -= amount;
}
   
    
    
}