using System;

namespace failsysyt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System a = new System();
            
            file f = new file();
            floder s = new floder("Documents");
            floder t = new floder("Desktop");
            floder user = new floder("User");
            

            user.add(t);
            user.add(s);
            s.add(f);
            a.State.add(user);
            Console.WriteLine(a.State);
            Creater ca = new Creater();
            ca.AddMemoTo(a.CreatMemoTo());
            user.add(new floder("Virus"));
            ca.AddMemoTo(a.CreatMemoTo());
            user.add(new floder("Virus"));
            for (int i = 0; i <= 100000; i++) //грузится за минуту 
            {
                user.add(new file("Virus"));
                s.add(new file("Virus"));
                t.add(new file("Virus"));
            }
            ca.AddMemoTo(a.CreatMemoTo());
            a.RestoreMemoTo(ca.getMemoTo(0));
            Console.WriteLine(a.State);
            

        }
    }
}
