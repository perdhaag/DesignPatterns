namespace State;

public class Computer : IComputerState
{
    public IComputerState ComputerState { get; set; }

    public Computer()
    {
        ComputerState = new ComputerOffState();
    }
    public void TurnOff()
    {
        ComputerState.TurnOff();

        if (ComputerState is ComputerOnState)
        {
            ComputerState = new ComputerOffState();
        }
    }

    public void TurnOn()
    {
        ComputerState.TurnOn();

        if (ComputerState is ComputerOffState)
        {
            ComputerState = new ComputerOnState();
        }
    }

    public void IncreaseSound()
    {
        ComputerState.IncreaseSound();
    }

    public void DecreseSound()
    {
        ComputerState.DecreseSound();
    }
}