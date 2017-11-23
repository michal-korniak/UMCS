namespace ChainOfResponsibility
{
    public class ErrorHandler: IChainHandler
    {
        private IChainHandler _nextChain;
        public void SetNextChain(IChainHandler nextChainHandler)
        {
            _nextChain = nextChainHandler;
        }

        public Message Register(string nick, string email, string phoneNum)
        {
            if(string.IsNullOrWhiteSpace(nick) || string.IsNullOrWhiteSpace(email))
                return new Message(1,"ERROR - Puste pole (nick lub email)");
            return _nextChain.Register(nick, email, phoneNum);
        }
    }
}