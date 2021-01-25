using System;
namespace Agenda
{
    public class AddContact : IAction
    {
        Agenda agenda;
        public AddContact()
        { 
        }

        public void Run(Agenda agenda)
        {
            Console.WriteLine("-----ADD CONTACT-----");
            Console.WriteLine("Name: ");
            string nameIn = Console.ReadLine();
            Console.WriteLine("Number: ");
            string numberIn = Console.ReadLine();
            agenda.AddNewContact(nameIn, Convert.ToInt32(numberIn));  
        }
    }
}
