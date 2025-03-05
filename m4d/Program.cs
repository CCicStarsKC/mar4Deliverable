using occupation;
using car;
using persons;
namespace m4d
{
 public class Program
{
    static void Main(string[] args)
    {
        
         BFriend people = new BFriend();
    
        people.name="Keegan";
        people.age = 39;
        people.younger= true;   
    
     people.Tell();

        Wifey lady = new Wifey();

        lady.birds = 1;
        lady.midName = "Lee Anne";
        lady.married = true;

     lady.share();

        Aviarist pilot = new Aviarist();

        pilot.name = "Pilot";
        pilot.alone =true;
        pilot.birds = 1;

     pilot.BHobby();

        Beekeeper apis = new Beekeeper();
        apis.owner= "Caleb";
        apis.hives= 1;
        apis.alive=true;
    
     apis.EHobby();

        Ford dying = new Ford();
        dying.Model = "Focus";
        dying.rearDrive= false;
        dying.year= 2013;

     dying.MyCar();

        GMC dead= new GMC();
        dead.Type="Truck";
        dead.flats= 4;
        dead.runable=false;

     dead.GrampsTruck();
    }
 
}
}