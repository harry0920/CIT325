using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_HarryVashisht
{
    class Desk
    {

        private int width { get; set; }

        private int depth { get; set; }

        private int numDrawers { get; set; }

        private string surfaceMaterial { get; set; }

        public Desk(int width, int depth, int numDrawers, string surfaceMaterial)
        {
            this.width = width;
            this.depth = depth;
            this.numDrawers = numDrawers;
            this.surfaceMaterial = surfaceMaterial;
        }
    }
}
 