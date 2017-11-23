namespace ChainOfResponsibility
{
    public class WarringHandler: IChainHandler
    {
        private IChainHandler _nextChain;
        public void SetNextChain(IChainHandler nextChainHandler)
        {
            _nextChain = nextChainHandler;
        }

        public Message Register(string nick, string email, string phoneNum)
        {
            if(string.IsNullOrWhiteSpace(phoneNum))
                return new Message(2,"WARRING - Puste pole opcjonalne");
            return _nextChain.Register(nick, email, phoneNum);
        }
    }
}