using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal interface IModel
    {
        string Name { get; set; }
        string Age { get; set; }
        void AddHuman();
        List<string> GetAllHumans();
        List<string> SearchHumans(string nameForSearch);
    }
}