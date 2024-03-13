using System;

public abstract class Colleague<T>
{
    protected IMediator<T> mediator;
    protected string name;

    public Colleague(IMediator<T> mediator, string name)
    {
        this.mediator = mediator;
        this.name = name;
    }

    public abstract void ReceiveMessage<TMessage>(TMessage message);
}
