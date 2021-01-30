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
    public partial class AddMyQuotes : Form
    {
        public static string custName;
        public static string deskWidth;
        public static string deskDepth;
        public static string deskDrawer;
        public static string deskRushOrder;
        public static string deskMaterial;

        
        // THIS IS THE TIMER CONFIGURATION
        private Timer x = new Timer();
        public AddMyQuotes()
        {
            InitializeComponent();
            x.Interval = (4000);  //1 second = 1000
            x.Tick += new EventHandler(timer1_Tick); //evoke your custom event
            x.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // DESK WIDTH VALIDATION

        private void Width_Validating(object sender, CancelEventArgs e)
        {
            Desk obj = new Desk();
            try
            {
                int temp = Convert.ToInt32(Width.Text);
                if (temp < Desk.MinWidth)
                {
                    MessageBox.Show("Desk Width Cannot be less than 24 inches");
                    Width.Clear();

                }
                else if (temp > Desk.MaxWidth)
                {
                    MessageBox.Show("Desk Width Cannot be less than 96 inches");
                    Width.Clear();

                }



            }
            catch (Exception h)
            {
                //MessageBox.Show("Please provide number only");

                this.Width.Text = "Type a number";
                Width.Clear();

            }
        }


        private void Depth_KeyPress(object sender, KeyPressEventArgs e)
        {

            //ALERTS THE USER IF HE PRESSES A NON DIGIT KEY IN DEPTH TEXTBOX

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                this.Depth.Text = "Type a number";
                e.Handled = true;

            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        // Timer event to clear textbox message after pressing a non digit key
        // It was deleting any type of input despite being valid input
        // It is not active at the moment

        private void timer1_Tick(object sender, EventArgs e)
        {

            //Width.Clear();
            //Depth.Clear();

        }

        // This verifies if the key pressed in width is a digit or control.

        private void Width_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {

                //Text is placed in textbox, please delete it manually.
                this.Width.Text = "Please type a number...";
                e.Handled = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            custName = Customer.Text;
            deskWidth = Width.Text;
            deskDepth = Depth.Text;
            deskDrawer = Drawer.Text;
            deskRushOrder = RushOrder.Text;
            deskMaterial = ListMaterial.Text;

            /*DisplayQuote disQuote = new DisplayQuote();
            disQuote.Show();
            this.Close();*/

            // This should get the user out of the display quote window
            //

            DisplayQuote disQuote = new DisplayQuote();
            disQuote.Tag = this;
            disQuote.Show(this);
            Hide();


        }

        //DESK DEPTH VALIDATION

        private void Depth_Validating(object sender, CancelEventArgs e)
        {
            Desk obj = new Desk();
            int temp = Convert.ToInt32(Depth.Text);
            try
            {
                if (temp < Desk.MinDepth)
                {
                    MessageBox.Show("Desk Depth Cannot be less than 12 inches");
                    Depth.Clear();

                }
                else if (temp > Desk.MaxDepth)
                {
                    MessageBox.Show("Desk Width Cannot be less than 48 inches");
                    Depth.Clear();

                }
            }

            catch (Exception h)
            {
                //MessageBox.Show("Please provide number only");

                this.Depth.Text = "Type a number";
                Depth.Clear();

            }
        }

        private void ListMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

            Desk o = new Desk();

            ListMaterial.DataSource = o.materialsDesk;
        }
    }
}
