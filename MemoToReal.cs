using System;
using System.Collections.Generic;
using System.Text;

namespace failsysyt
{
    class MemoToReal : MemoTo
    {
      
        public floder root;
        public MemoTo createMemento()
        {
            return new MemoToReal();
        }

    }
}
