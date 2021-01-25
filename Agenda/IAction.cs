using System;
namespace Agenda
{
    public interface IAction
    {
        void Run(Agenda agenda);
    }
}
