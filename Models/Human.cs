namespace Zoological {
public class Human : IWalking
{
  public string Species {get; set;}

  public string Size {get; set;}

public void run()
    {

    }

    public void walk()
    {

    }

     public override string ToString() {
       return "human";
    }

}
}