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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void BackButton2_Click(object sender, EventArgs e)
        {
            /*MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();*/

            MainMenu dispMenu = new MainMenu();
            dispMenu.Tag = this;
            dispMenu.Show(this);
            Hide();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            dispLabel1.Text = AddMyQuotes.custName;
            dispLabel2.Text = AddMyQuotes.deskWidth;
            dispLabel3.Text = AddMyQuotes.deskDepth;
            dispLabel4.Text = AddMyQuotes.deskDrawer;
            dispLabel5.Text = AddMyQuotes.deskRushOrder;
            dispLabel6.Text = AddMyQuotes.deskMaterial;


        }

    }
}
