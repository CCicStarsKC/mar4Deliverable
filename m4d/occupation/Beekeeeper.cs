namespace occupation;
public class Beekeeper
{
    public int hives;
    public bool alive;
    public string owner;

    public void EHobby(){
        Console.WriteLine("Our apiary has "+hives+" hives. "+owner+" is the beekeeper." );
    }

}
