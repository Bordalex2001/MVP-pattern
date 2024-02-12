using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal interface IView
    {
        string Name { get; set; }
        string Age { get; set; }
        string HumanSearch { get; set; }
        void ShowHumansList(List<string> humans);
        void ShowHumansByName(List<string> HumanSearch);
        event EventHandler<EventArgs> add;
        event EventHandler<EventArgs> showAll;
        event EventHandler<EventArgs> search;
    }
}