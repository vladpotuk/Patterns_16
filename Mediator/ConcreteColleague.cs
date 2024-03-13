using System;

public class ConcreteColleague : Colleague<ConcreteColleague>
{
    public ConcreteColleague(IMediator<ConcreteColleague> mediator, string name) : base(mediator, name)
    {
    }

    public override void ReceiveMessage(string message)
    {
        Console.WriteLine("{0} отримав повідомлення: {1}", name, message);
    }

    public void SendMessage(string message)
    {
        mediator.SendMessage(message, this);
    }
}
