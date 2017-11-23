using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public interface IChainHandler
    {
        void SetNextChain(IChainHandler nextChainHandler);
        Message Register(string nick, string email, string phoneNum);

    }
}
