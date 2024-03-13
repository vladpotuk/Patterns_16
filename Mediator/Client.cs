public class Client
{
    public void Run()
    {
        ConcreteColleague colleague1 = new ConcreteColleague(new ConcreteMediator(null, null), "Колега 1");
        ConcreteColleague colleague2 = new ConcreteColleague(new ConcreteMediator(null, null), "Колега 2");

        ConcreteMediator mediator = new ConcreteMediator(colleague1, colleague2);

        colleague1.SendMessage("Привіт, колего!");
        colleague2.SendMessage("Привіт! Як справи?");
    }
}
