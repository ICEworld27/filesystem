using System;
using System.Collections.Generic;
using System.Text;

namespace failsysyt
{
    class System
    {
        private static System instance;
        public static System getInstance()
        {
            if (instance == null)
                instance = new System();
            return instance;
        }
        public floder State = new floder("C:/");
        
        public MemoTo CreatMemoTo()
        {
            MemoToReal m = new MemoToReal();

            m.root = State.copy();
            return m;


        }
        public void RestoreMemoTo(MemoTo n)
        {
            MemoToReal r = (MemoToReal)n;
            State = (floder)r.root.copy();

        }

    }
}
