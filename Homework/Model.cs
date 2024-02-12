using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Homework
{
    internal class Model : IModel
    {
        public string filePath = "Humans.txt";
        public string Name { get; set; }
        public string Age { get; set; }
        public Model() { }
        public void AddHuman()
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"Ім'я: {Name}\tВік: {Age}");
                writer.Close();
                MessageBox.Show("Користувача додано успішно!");
            }
        }
        public List<string> GetAllHumans()
        {
            List<string> humans = new List<string>();
            using (StreamReader reader = new StreamReader(filePath, true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    humans.Add(line);
                }
            }
            return humans;
        }
        public List<string> SearchHumans(string nameForSearch)
        {
            List<string> humansByName = new List<string>();
            using (StreamReader reader = new StreamReader(filePath, true))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Case-insensitive search
                    if (line.IndexOf(nameForSearch, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        // Add the line (name) to the ListBox
                        humansByName.Add(line);
                    }
                    /*if (line.Contains($"Ім'я: {nameForSearch}"))
                    {
                        humansByName.Add(line);
                    }*/
                    else
                    {
                        MessageBox.Show("Користувачів за цим ім'ям не знайдено!");
                    }
                }
            }
            return humansByName;
        }
    }
}