using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsercizioSpesa.Handlers
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;


        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }

        public virtual string Handle(double request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }else
            {
                return null;
            }

        }

        
    }
}
