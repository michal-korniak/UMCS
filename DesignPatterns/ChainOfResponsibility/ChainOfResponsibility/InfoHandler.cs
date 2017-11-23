namespace ChainOfResponsibility
{
    public class InfoHandler: IChainHandler
    {
        private IChainHandler _nextChain;
        public void SetNextChain(IChainHandler nextChainHandler)
        {
            _nextChain = nextChainHandler;
        }

        public Message Register(string nick, string email, string phoneNum)
        {
                return new Message(3,"INFO - Pola uzupelnione poprawnie");
        }
    }
}