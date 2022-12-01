using System.Collections;

namespace Memento;

#nullable disable

public class Memento
{
    private string state;

    public Memento(string state)
    {
        this.state = state;
    }

    public string getState()
    {
        return state;
    }
}

public class Originator
{
    private string state;

    public void setState(string state)
    {
        this.state = state;
    }

    public string getState()
    {
        return state;
    }

    public Memento saveStateToMemento()
    {
        return new Memento(state);
    }

    public void getStateFromMemento(Memento memento)
    {
        state = memento.getState();
    }
}



public class CareTaker
{
    private List<Memento> mementoList = new();

    public void Add(Memento state)
    {
        mementoList.Add(state);
    }

//    public Memento Get(Memento index)
//    {
//        return mementoList.IndexOf(index);
//    }
}

public class MementoPatternDemo
{
    public static void Main()
    {

        Originator originator = new Originator();
        CareTaker careTaker = new CareTaker();

        originator.setState("State #1");
        originator.setState("State #2");
        careTaker.Add(originator.saveStateToMemento());

        originator.setState("State #3");
        careTaker.Add(originator.saveStateToMemento());

        originator.setState("State #4");
        Console.WriteLine("Current State: " + originator.getState());

        // originator.getStateFromMemento(careTaker.Get(0));
        Console.WriteLine("First saved State: " + originator.getState());
        // originator.getStateFromMemento(careTaker.Get(1));
        Console.WriteLine("Second saved State: " + originator.getState());
    }
}