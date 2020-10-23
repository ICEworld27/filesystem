
using System;
using System.Collections.Generic;
using System.Text;

namespace failsysyt
{
    class file
    {
        private string _name;
        string name
        {
            get
            {
                return name;
            }
            set
            {
                /*if (value == "")
                {
                    Console.WriteLine("Введите название:");
                    value = Console.ReadLine();
                }
                */
                name = value;

            }
        }
        public file copy()
        {
            file r = new file(_name);
            return r;
        }
        public file(string vname = null)
        {
            if (vname == null)
            {
                name = "New floder";
            }
            else
            {
                name = vname;
            }
        }
    }
}
