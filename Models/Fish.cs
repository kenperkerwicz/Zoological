namespace Zoological {
public class Fish : ISwimming
{
  public string Species {get; set;}

  public string Size {get; set;}

 public int MaximumDepth {get; set;}
 public void swim() {

 }

 public override string ToString() {
      return "fish";
  }

}
}