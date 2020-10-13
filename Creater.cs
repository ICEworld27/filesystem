using System;
using System.Collections.Generic;
using System.Text;

namespace failsysyt
{
    class Creater
    {
        private List<MemoTo> states = new List<MemoTo>();
        public void AddMemoTo(MemoTo m)
        {
            states.Add(m);
        }
        public MemoTo getMemoTo(int index)
        {
            return states[index];
        }
    }
}
