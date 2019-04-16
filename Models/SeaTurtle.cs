using System;

namespace Zoological {




class SeaTurtle : IWalking, ISwimming
{
    public int MaximumDepth {get; set;} = 100;

    public void run()
    {
  Console.WriteLine("Animal is now running");
    }

    public void walk()
    {

    }

    public void swim()
    {

    }
}

}