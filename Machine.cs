public class Machine{
    
    private static Machine? instance = null;
    
    public static Machine Current{
        get{
            instance ??= new Machine();
            return instance;
        }
    }
    private Machine(){}

    public int level {get; set;}
    public int experience {get; set;}
    public int tier {get; set;}
    public int attack {get; set;}
    public int life {get; set;}
}