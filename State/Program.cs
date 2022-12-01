using System;
namespace State.Structural;

#nullable disable

/// State Design Pattern

public class Program
{
    public static void Main()
    {
        // Setup context in a state
        var context = new Context(new ConcreteStateA());
        // Issue requests, which toggles state
        context.Request();
        context.Request();
        context.Request();
        context.Request();
        // Wait for user
        Console.ReadKey();
    }
}

/// The 'State' abstract class

public abstract class State
{
    public abstract void Handle(Context context);
}

/// A 'ConcreteState' class

public class ConcreteStateA : State
{
    public override void Handle(Context context)
    {
        context.State = new ConcreteStateB();
    }
}


/// A 'ConcreteState' class

public class ConcreteStateB : State
{
    public override void Handle(Context context)
    {
        context.State = new ConcreteStateA();
    }
}

/// The 'Context' class

public class Context
{
    State state;
    // Constructor
    public Context(State state)
    {
        this.State = state;
    }
    // Gets or sets the state
    public State State
    {
        get { return state; }
        set
        {
            state = value;
            Console.WriteLine("State: " + state.GetType().Name);
        }
    }
    public void Request()
    {
        state.Handle(this);
    }
}
