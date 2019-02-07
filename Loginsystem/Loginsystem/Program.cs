using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loginsystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            int blockedCount = 0;
            bool flag = false;
            Person enteredPerson = new Person();
            while (true)
            {
                Console.WriteLine("1.Qeydiyyatdan kecin:");
                Console.WriteLine("2.Daxil olun:");
                Console.WriteLine("3.Sifreni Yenileyin:");
                Console.WriteLine("0.Sistemden cixis:");
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Emeliyyat secin");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Person prs = new Person();
                        Console.WriteLine("Istifadeci adini daxil edin:");
                        prs.Username = Console.ReadLine();
                        Console.WriteLine("Sifreni daxil edin:");
                        prs.Password = Console.ReadLine();
                        persons.Add(prs);
                        break;
                    case 2:
                        Console.WriteLine("Istifadeci adini daxil edin:");
                        var username = Console.ReadLine();
                        Console.WriteLine("Sifreni daxil edin:");
                        var password = Console.ReadLine();
                        
                        foreach (var person in persons)
                        {

                            if (person.Username == username && person.Password == password)
                            {
                                Console.WriteLine("Sisteme daxil oldunuz:");
                                Console.WriteLine("-----------------------------------");
                                enteredPerson = person;
                                flag = true;
                                break;
                            }
                           


                        }
                        if (flag==false)
                        {
                            Console.WriteLine("istifadeci adi ve ya sifre yanlisdir:");
                            blockedCount++;
                        }
                        break;
                    case 3:
                        if (flag==true)
                        {
                            Console.WriteLine("Yeni sifreni daxil et");
                            var newPassword = Console.ReadLine();
                            enteredPerson.Password = newPassword;
                        }
                        break;
                }


            }
        }
    }
}
