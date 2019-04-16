using System.Collections.Generic;

namespace Zoological

{
public class Zoological {

  public List<PaintedDog> PaintedDogs { get; set; } = new List<PaintedDog>();

   public List<Human> Humans { get; set; } = new List<Human>();


public List<Fish> Fishes { get; set; } = new List<Fish>();


    public List<IWalking> WalkingAnimals()
    {
      List<IWalking> WalkingAnimals = new List<IWalking>() {
          new PaintedDog(),
          new PaintedDog(),
          new PaintedDog(),
          new Human(),
      };
      return WalkingAnimals ;
    }


  public List<ISwimming> SwimmingAnimals()
    {
      List<ISwimming> SwimmingAnimals = new List<ISwimming>() {
          new Fish(),
          new Fish(),
          new Dolphin(),
          new Dolphin(),
      };
      return SwimmingAnimals ;
    }

}

}