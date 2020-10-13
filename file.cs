
using System;
using System.Collections.Generic;
using System.Text;

namespace failsysyt
{
    class file
    {
        string name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Введите название:");
                    name = Console.ReadLine();
                }
                name = value;

            }
        }
        public file(string vname = null)
        {
            if (vname == null)
            {
                name = "";
            }
            else
            {
                name = vname;
            }
        }
    }
}
