namespace BehavioralDesignPatterns.Mediator
{
    public class Client
    {
        public static void Execute()
        {
            var chat = new Chat();

            var user = new User("User");
            var bot1 = new Bot("Bot1");
            var bot2 = new Bot("Bot2");

            user.Chat = chat;
            bot1.Chat = chat;
            bot2.Chat = chat;

            user.Send("test Bot1");
            user.Send("test Bot2");
            user.Send("Bot1", "private test 1");
            user.Send("Bot1Nick", "private test 2");
            user.Send("Bot2", "private test 3");
        }
    }
}
