using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form1 : Form, IView
    {
        public Form1()
        {
            InitializeComponent();
            //IModel model = new Model();
            //Presenter presenter = new Presenter(model, this);
        }
        public string Name
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Age
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public string HumanSearch
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public void ShowHumansList(List<string> humans)
        {
            listBox1.Items.Clear();
            foreach (string item in humans)
            {
                listBox1.Items.Add(item);
            }
        }
        public void ShowHumansByName(List<string> HumanSearch)
        {
            listBox1.Items.Clear(); 
            foreach (string item in HumanSearch)
            {
                if (item.StartsWith(textBox3.Text))
                {
                    listBox1.Items.Add(item);
                }
            }
        }
        public event EventHandler<EventArgs> add;
        public event EventHandler<EventArgs> showAll;
        public event EventHandler<EventArgs> search;
        private void button1_Click(object sender, EventArgs e)
        {
            add?.Invoke(this, EventArgs.Empty);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            showAll?.Invoke(this, EventArgs.Empty);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            search?.Invoke(this, EventArgs.Empty);
        }
    }
}