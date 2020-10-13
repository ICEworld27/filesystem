using System;
using System.Collections.Generic;
using System.Text;

namespace failsysyt
{
    class floder : file
    {
        List<file> files;
        string name
        {
            get
            {
                return name;
            }
            set
            {
                Console.WriteLine("Введите название:");
                name = Console.ReadLine();

            }
        }
       public void add(file file)
        {
            files.Add(file);
            Console.WriteLine("Добавлено успешно!");
        }
        public floder(string name) : base(name)
        {
            files = new List<file>();
        }
    }
}
