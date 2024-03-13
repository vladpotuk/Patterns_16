using System.Xml.Linq;

public class ConcreteColleague : Colleague
{
    public ConcreteColleague(IMediator mediator, string name) : base(mediator, name)
    {
    }

    public override void ReceiveMessage(string message)
    {
        Console.WriteLine($"{name} отримав(ла) повідомлення: {message}");
    }

    public void SendMessage(string message)
    {
        Console.WriteLine($"{name} відправив(ла) повідомлення: {message}");
        mediator.SendMessage(message, this);
    }
}
