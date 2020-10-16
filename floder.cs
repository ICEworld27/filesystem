using System;
using System.Collections.Generic;
using System.Text;

namespace failsysyt
{
    class floder : file
    {
        List<file> files;
        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                Console.WriteLine("Введите название:");
                _name = Console.ReadLine();

            }
        }
        public floder copy()
        {
            floder reserv = new floder(this.name);
            for (int i = 0; i < files.Count; i++)
            {
                reserv.add(files[i].copy());
            }
            return reserv;
        }
       public void add(file file)
        {
            files.Add(file);
            Console.WriteLine("Добавлено успешно!");
        }
        public void Remove(file file)
        {
            files.Remove(file);
            Console.WriteLine("Добавлено успешно!");
        }
        public floder(string name) : base(name)
        {
            files = new List<file>();
        }
    }
}
