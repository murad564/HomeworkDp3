//using System.Collections.Generic;
//public abstract class Observer
//{
//    protected Subject? subject;
//    public abstract void update();
//}
//public class Subject
//{

//    private List<Observer> observers = new();
//    private int state;

//    public int getState()
//    {
//        return state;
//    }

//    public void setState(int state)
//    {
//        this.state = state;
//        notifyAllObservers();
//    }

//    public void attach(Observer observer)
//    {
//        observers.Add(observer);
//    }

//    public void notifyAllObservers()
//    {
//        foreach (Observer observer in observers)
//        {
//            observer.Update();
//        }
//    }
//}

//public class BinaryObserver : Observer
//{

//   public BinaryObserver(Subject subject)
//{
//    this.subject = subject;
//    this.subject.attach(this);
//}

//// Override
//   public void update()
//{
//        Console.WriteLine("Binary String: " + ToString(subject.getState()));
//}
//}

//public class OctalObserver : Observer
//{

//   public OctalObserver(Subject subject)
//{
//    this.subject = subject;
//    this.subject.attach(this);
//}

//// Override
//   public void update()
//{
//    Console.WriteLine("Octal String: " + ToString(subject.getState()));
//}
//}

//public class HexaObserver: Observer
//{

//   public HexaObserver(Subject subject)
//{
//    this.subject = subject;
//    this.subject.attach(this);
//}

////Override
//   public void update()
//{
//        Console.WriteLine("Hex String: " + ToString(subject.getState()).toUpperCase());
//}
//}


//public class Program
//{
//    public static void main(String[] args)
//    {
//        Subject subject = new Subject();

//        new HexaObserver(subject);
//        new OctalObserver(subject);
//        new BinaryObserver(subject);

//        Console.WriteLine("First state change: 15");
//        subject.setState(15);
//        Console.WriteLine("Second state change: 10");
//        subject.setState(10);
//    }
//}