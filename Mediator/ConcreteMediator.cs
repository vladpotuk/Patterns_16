using System;

public class ConcreteMediator : IMediator<ConcreteColleague>
{
    private ConcreteColleague colleague1;
    private ConcreteColleague colleague2;

    public ConcreteMediator(ConcreteColleague colleague1, ConcreteColleague colleague2)
    {
        this.colleague1 = colleague1;
        this.colleague2 = colleague2;
    }

    public void SendMessage(string message, ConcreteColleague colleague)
    {
        switch (colleague)
        {
            case ConcreteColleague c1 when c1 == colleague1:
                colleague2.ReceiveMessage(message);
                break;
            case ConcreteColleague c2 when c2 == colleague2:
                colleague1.ReceiveMessage(message);
                break;
            default:
                throw new ArgumentException("Невідомий колега");
        }
    }
}
