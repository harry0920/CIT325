﻿using System;
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

        private void inputwidth_Validating(object sender, CancelEventArgs e)
        {
            string ErrorMessage = "Invalid Width";

         //   if(inputwidth < 0 || inputwidth > 100)
            {

            }
        }

        private void inputwidth_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
