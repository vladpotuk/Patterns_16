public class ConcreteMediator : IMediator
{
    private ConcreteColleague colleague1;
    private ConcreteColleague colleague2;

    public ConcreteMediator(ConcreteColleague colleague1, ConcreteColleague colleague2)
    {
        this.colleague1 = colleague1;
        this.colleague2 = colleague2;
    }

    public void SendMessage(string message, Colleague sender)
    {
        if (sender == colleague1)
        {
            colleague2.ReceiveMessage(message);
        }
        else if (sender == colleague2)
        {
            colleague1.ReceiveMessage(message);
        }
    }
}
