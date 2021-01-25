using System;
namespace Agenda
{
    public class Contact
    {
        private string contactName;
        private int telfNumber;
        private string dateModif;

        public Contact(string newContactName, int newTelfNumber)
        {
            contactName = newContactName;
            telfNumber = newTelfNumber;
            RefreshDate();
        }

        public void RefreshDate()
        {
            DateTime dt = DateTime.Now;
            dateModif = String.Format("{0: MM/dd/yyyy HH:mm:ss}", dt);
        }

        public void UpdateContactName(string newContactName)
        {
            contactName = newContactName;
        }

        public void UpdateNumerContact(int newTelfNumber)
        {
            telfNumber = newTelfNumber;
        }

        public bool ModifyContact (string opcion, string newValue)
        {
            try
            {
                switch (opcion)
                {
                    case "name":
                        UpdateContactName(newValue);
                        break;
                    case "number":
                        UpdateNumerContact(Convert.ToInt32(newValue));
                        break;
                    default:
                        return false;
                }
                RefreshDate();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR");
                return false;            
            }
        }
        public override string ToString()
        {
            return "Name: " + contactName + "................" + "Telf. Number: " + telfNumber;
        }

        public void PrintContact()
        {
            Console.WriteLine("Name: " + contactName + "................" + "Telf. Number: " + telfNumber);        
        }

        
    }
}
