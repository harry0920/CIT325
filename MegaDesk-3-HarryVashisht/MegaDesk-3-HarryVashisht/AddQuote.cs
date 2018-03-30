using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_HarryVashisht
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

     
        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void validInput(object sender, CancelEventArgs e)
        {
            if(validateInt(inputwidth.Text))
            {
                // SHOW message
            }
        }

        private bool validateInt(string value)
        {
            //value = Int32.Parse(value);

            //if (value < 0 || value > 2000)
            //    return false;
            return true;
        }

        private void inputwidth_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
