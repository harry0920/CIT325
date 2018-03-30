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
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();

           
                DataTable table = new DataTable();
                table.Columns.Add("Row No.");
                table.Columns.Add("Col No.");
                table.Columns.Add("Width");
                table.Columns.Add("Height");
                table.Columns.Add("Image URL");
                table.Columns.Add("Description");

                using (System.IO.StreamReader sr = new System.IO.StreamReader(@"C:\Users\Harry Vashisht\source\repos\CIT365\MegaDesk-3-HarryVashisht\MegaDesk-3-HarryVashisht\data.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] parts = sr.ReadLine().Split(',');
                        table.Rows.Add(parts[0], parts[1], parts[2], parts[3], parts[4], parts[5]);
                    }
                }
                dataGrid.DataSource = table;
              //  dataGrid.DataBind();
            }
        

        private void closeButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }
    }
}
