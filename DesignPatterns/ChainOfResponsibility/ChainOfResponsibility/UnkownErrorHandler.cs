namespace ChainOfResponsibility
{
    public class UnknownErrorHandler : IChainHandler
    {
        private IChainHandler _nextChain;

        public void SetNextChain(IChainHandler nextChainHandler)
        {
            _nextChain = nextChainHandler;
        }

        public Message Register(string nick, string email, string phoneNum)
        {
            var isNumOk = true;
            if (phoneNum.Length < 11)
                isNumOk = false;
            else
                foreach (var x in phoneNum)
                    if (!char.IsDigit(x))
                        isNumOk = false;
            if (!isNumOk)
                return new Message(5, "UNKNOWN ERROR - Nieznany blad");
            return _nextChain.Register(nick, email, phoneNum);
        }
    }
}