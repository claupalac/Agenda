using System;
namespace Agenda
{
    public class DeleteContact : IAction
    {
        public DeleteContact()
        {
        }
        public void Run(Agenda agenda)
        {
            Console.WriteLine("-----DELETE CONTACT-----");
            agenda.ShowContacts();
            Console.WriteLine("Enter number of contact to DELETE");
            int numberOfContact = Convert.ToInt16(Console.ReadLine());
            agenda.DeleteContactByIndexOne(numberOfContact);
        }
    }
}
