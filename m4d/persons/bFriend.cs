namespace persons;
public class BFriend
{
    public int age;
    public bool younger;
    public string name;

    public void Tell(){
        Console.WriteLine("My friends name is " + name + ". They are " + age + ".");
    }
}