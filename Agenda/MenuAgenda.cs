using System;
namespace Agenda
{
    public class MenuAgenda
    {
        private Agenda myAgenda = new Agenda();

        public MenuAgenda()
        {
        }
        public void MenuInicio()
        {
            int opcionSelected;
            Console.Clear();
            Console.WriteLine("\n1. Add new contact");
            Console.WriteLine("2. Remove contact");
            Console.WriteLine("3. Edit contact");
            Console.WriteLine("4. Show contacts");
            string inputOption = Console.ReadLine();
            opcionSelected = Convert.ToInt32(inputOption);
            MenuSelection(opcionSelected);

        }
        public void MenuSelection (int optionSelected)
        {
            switch (optionSelected)
            {
                case 1:
                    AddNewContactMenu();
                    break;
                case 2:
                    DeteleContactMenu();
                    break;
                case 3:
                    SelectAndEditContactMenu();
                    break;
                case 4:
                    myAgenda.ShowContacts();
                    Console.WriteLine("\nPress a key to return to the main menu ..");
                    Console.ReadKey();
                    MenuInicio();
                    break;
                default:
                    MenuInicio();
                    break;
            }
        }
        public void AddNewContactMenu()
        {
            Console.Clear();
            Console.WriteLine("Name: ");
            string nameIn = Console.ReadLine();
            Console.WriteLine("Number: ");
            string numberIn = Console.ReadLine();
            myAgenda.AddNewContact(nameIn,Convert.ToInt32(numberIn));
            Console.WriteLine("\nPress a key to return to the main menu ..");
            Console.ReadKey();
            MenuInicio();
        }

        public void SelectAndEditContactMenu()
        {
            Console.Clear();
            myAgenda.ShowContacts();
            Console.WriteLine("\nIntro contact's index number to edit: ");
            string posContactSelectedString = Console.ReadLine();
            int posContactSelected = Convert.ToInt32(posContactSelectedString);
            if (EditContactMenu(posContactSelected))
            {
                Console.Clear();
                Console.WriteLine("Operation successful");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Error");
            }
            Console.WriteLine("\nPress a key to return to the main menu ..");
            Console.ReadKey();
            MenuInicio();
        }

        public bool EditContactMenu(int pos)
        {
            Console.Clear();
            Console.WriteLine("New Name: ");
            string nameIn = Console.ReadLine();
            Console.WriteLine("New Number: ");
            string numberIn = Console.ReadLine();

            if((nameIn != null) && (numberIn != null))
            {
                myAgenda.EditContact(pos, "number", numberIn);
                myAgenda.EditContact(pos, "name", nameIn);
                return true;
            }
            if (nameIn == null)
            {
                myAgenda.EditContact(pos, "number", numberIn);
                return true;
            }
            if (numberIn == null)
            {
                myAgenda.EditContact(pos, "name", nameIn);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DeteleContactMenu()
        {
            Console.Clear();
            myAgenda.ShowContacts();
            Console.WriteLine("\nIntro contact's index number to delete: ");
            string posContactSelectedString = Console.ReadLine();
            int posContactSelected = Convert.ToInt32(posContactSelectedString);
            myAgenda.DeleteContact(posContactSelected);
            Console.WriteLine("\nPress a key to return to the main menu ..");
            Console.ReadKey();
            MenuInicio();
        }
    }
}
