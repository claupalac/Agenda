using System;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuAgenda myAgenda = new MenuAgenda();
            while(true)
            {
                myAgenda.MainMenu();
                myAgenda.ReturnToMainMenu();
            }
            
           
        }
    }
}
