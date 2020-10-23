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
        private floder State = new floder("C:/");
        
        MemoToReal b;
        public MemoTo CreatMemoTo()
        {
            MemoTo a;
            MemoToReal m = new MemoToReal();

            m.root = State.copy();
            a = m;
            return a;


        }
        public void RestoreMemoTo(MemoTo n)
        {
            MemoToReal r = (MemoToReal)n;
            State = r.root.copy();

        }
    }
}
