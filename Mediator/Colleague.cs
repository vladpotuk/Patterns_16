using System;


public abstract class Colleague
{
    protected IMediator mediator;
    protected string name;

    public Colleague(IMediator mediator, string name)
    {
        this.mediator = mediator;
        this.name = name;
    }

    public abstract void ReceiveMessage(string message);
}
