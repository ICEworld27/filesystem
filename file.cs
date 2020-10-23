
using System;
using System.Collections.Generic;
using System.Text;

namespace failsysyt
{
    class file
    { 

        public string name { get; set; }
        /*
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
                
                name = value;

            }
        }
    */
        public  virtual file copy()
        {
            file r = new file(name);
            return r;
        }
        public file(string vname = null)
        {
            if (vname == null)
            {
                name = "New";
            }
            else
            {
                name = vname;
            }
        }
        public override string ToString()
        {
            return name;
        }
    }
}
