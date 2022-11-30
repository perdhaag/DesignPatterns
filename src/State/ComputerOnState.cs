namespace State;

public class ComputerOnState : IComputerState
{
    public void TurnOff()
    {
        Console.WriteLine("Computer turned off");
    }

    public void TurnOn()
    {
        Console.WriteLine("You cannot turn on computer as it is already on");
    }

    public void IncreaseSound()
    {
        Console.WriteLine("Sound increased");
    }

    public void DecreseSound()
    {
        Console.WriteLine("Sound decreased");
    }
}