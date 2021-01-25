using System;
namespace Agenda.Actions
{
    public class ShowContacts : IAction
    {
        public ShowContacts()
        {
        }

        public void Run(Agenda agenda)
        {
            Console.WriteLine("----CONTACTS----");
            agenda.ShowContacts();
        }
    }
}
