using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_HarryVashisht
{
    class DeskQuote
    {

        private Desk desk { get; set; }
        private int rushDays { get; set; }
        private string customerName { get; set; }        
        DateTime quoteDate { get; set; }
        float totalCost { get; set; }

        public DeskQuote(Desk desk, string customerName)
        {
            this.desk = desk;
            this.customerName = customerName;
        }

        public DeskQuote(Desk desk, int rushDays, string customerName, DateTime quoteDate, float totalCost)
        {
            this.desk = desk ?? throw new ArgumentNullException(nameof(desk));
            this.rushDays = rushDays;
            this.customerName = customerName ?? throw new ArgumentNullException(nameof(customerName));
            this.quoteDate = quoteDate;
            this.totalCost = totalCost;
        }
    }
}
