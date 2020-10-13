using System;
using System.Collections.Generic;
using System.Text;

namespace failsysyt
{
    class System
    {
        private floder State = new floder("C:/");
        MemoTo a;
        public MemoTo  CreatMemoTo()
        {
            return a =  new MemoTo();
        }
        public void CreatMemoTo(MemoTo n)
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
    }
}
