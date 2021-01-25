using System;
namespace Agenda
{
    public class MenuAgenda
    {
        private Agenda myAgenda;
        private ActionRunner runner;

        public MenuAgenda()
        {
            myAgenda = new Agenda();
            runner = new ActionRunner();
        }
        public void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("\n1. Add new contact");
            Console.WriteLine("2. Delete contact");
            Console.WriteLine("3. Edit contact");
            Console.WriteLine("4. Show contacts");
            Console.WriteLine("\n enter a number (1-4)");
            string select = Console.ReadLine();
            runner.Start(select, myAgenda);    
        }
      
        public void ReturnToMainMenu()
        {
            Console.WriteLine("\nPress Any key to return to main menu..");
            Console.ReadKey();
            MainMenu();
        }
    }
}
