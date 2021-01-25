using System;
using System.Collections.Generic;
using Agenda.Actions;

namespace Agenda
{
    public class ActionRunner
    {
        private Dictionary<string, IAction> agendaActions;
        private IAction doNothing;
        public ActionRunner()
        {
            agendaActions = new Dictionary<string, IAction>
            {
               { "1", new AddContact() },
               { "2", new DeleteContact() },
               { "3", new EditContact() },
               { "4", new ShowContacts() },
            };
            doNothing = new DoNothing();
        }

        public void Start(string key, Agenda agenda)
        {
            agendaActions.GetValueOrDefault(key,doNothing).Run(agenda);
        }
    }
}
