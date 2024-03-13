using System;

public class ConcreteColleague : Colleague<ConcreteColleague>
{
    public ConcreteColleague(IMediator<ConcreteColleague> mediator, string name) : base(mediator, name)
    {
    }

    public override void ReceiveMessage<TMessage>(TMessage message)
    {
        Console.WriteLine("{0} отримав повідомлення: {1}", name, message);
    }

    public void SendMessage<TMessage>(TMessage message)
    {
        mediator.SendMessage(message, this);
    }
}
