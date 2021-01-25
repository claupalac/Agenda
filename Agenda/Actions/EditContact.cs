using System;
namespace Agenda
{
    public class EditContact : IAction
    {
        public EditContact()
        {
        }

        public void Run(Agenda agenda)
        {
            Console.WriteLine("-----EDIT CONTACT-----");
            agenda.ShowContacts();
            Console.WriteLine("Enter number of contact to EDIT");
            int posIndexOne = Convert.ToInt16(Console.ReadLine());
            int posIndexCero = posIndexOne - 1;
            Console.WriteLine("New Name: ");
            string nameIn = Console.ReadLine();
            Console.WriteLine("New Number: ");
            string numberIn = Console.ReadLine();

            if ((nameIn != null) && (numberIn != null))
            {
                agenda.EditContact(posIndexCero, "number", numberIn);
                agenda.EditContact(posIndexCero, "name", nameIn);   
            }
            if (nameIn == null)
            {
                agenda.EditContact(posIndexCero, "number", numberIn);
            }
            if (numberIn == null)
            {
                agenda.EditContact(posIndexCero, "name", nameIn);  
            }
        }
    }
}
