namespace State;

public class ComputerOffState : IComputerState
{
    public void TurnOff()
    {
        Console.WriteLine("Cannot turn off computer as it is already off");
    }

    public void TurnOn()
    {
        Console.WriteLine("Computer turned on");
    }

    public void IncreaseSound()
    {
        Console.WriteLine("Cannot increase sound on computer as it is already off");

    }

    public void DecreseSound()
    {
        Console.WriteLine("Cannot decrease sound on computer as it is already off");
    }
}