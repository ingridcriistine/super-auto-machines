public class Player 
{
    private static Player? instance = null;
    public static Player Current
    {
        get
        {
            instance ??= new Player();
            return instance;
        }
    }
    private Player() {}
    public int Coins { get; set; } = 10;
    public int Hearts { get; set; } = 5;
    public string Nickname { get; set; }
    public int Trophies { get; set; } = 0;
}