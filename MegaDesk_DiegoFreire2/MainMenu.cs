using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_DiegoFreire2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAddNew_Click(object sender, EventArgs e)
        {
            AddMyQuotes AddQuotes = new AddMyQuotes();
            AddQuotes.Tag = this;
            AddQuotes.Show(this);
            Hide();
        }

        private void ButtonViewQuotes_Click(object sender, EventArgs e)
        {

            ViewAllQuotes viewDisplayQuotes = new ViewAllQuotes();
            viewDisplayQuotes.Tag = this;
            viewDisplayQuotes.Show(this);
            Hide();
            //DisplayQuote viewDisplayQuote = (DisplayQuote)Tag;
            //viewDisplayQuote.Show();
            //Close();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearchQuotes = new SearchQuotes();
            viewSearchQuotes.Tag = this;
            viewSearchQuotes.Show(this);
            Hide();
        }
    }
}
