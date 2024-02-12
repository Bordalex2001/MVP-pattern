using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Presenter
    {
        public readonly IModel model;
        public readonly IView view;
        public Presenter() { }
        public Presenter(IModel model, IView view)
        {
            this.model = model;
            this.view = view;
            view.add += View_add;
            view.showAll += View_showAll;
            view.search += View_search;
        }

        private void View_search(object sender, EventArgs e)
        {
            model.Name = view.Name;
            model.Age = view.Age;
            List<string> searchResults = model.SearchHumans(view.Name);
            view.ShowHumansList(searchResults);
        }

        private void View_showAll(object sender, EventArgs e)
        {
            model.Name = view.Name;
            model.Age = view.Age;
            List<string> humans = model.GetAllHumans();
            view.ShowHumansList(humans);
        }

        private void View_add(object sender, EventArgs e)
        {
            model.Name = view.Name;
            model.Age = view.Age;
            model.AddHuman();
        }
    }
}