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
        MemoTo a;
        MemoToReal b;
        public MemoTo CreatMemoTo()
        {
            MemoToReal m = new MemoToReal();

            m.root = State.copy();
            a = m;
            return a;
        }
        public void RestoreMemoTo(MemoTo n)
        {
            if (n != null)
            {
                a = n;
            }
            else
            {
                 a = new MemoTo();
                 a = n;
            }
            
        }
        public void ResetByMemoTo(MemoTo n)
        {
            State = b.root;

        }
    }
}
