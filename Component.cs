using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ritprogram1
{
    public class Penna
    {
        private Color färg;
        private float tjocklek;


        public Penna(Color färg, float tjocklek)
        {
            this.färg = färg;
            this.tjocklek = tjocklek;
        }

        // Metod som ändrar pennans färg genom colorDialog 
        public void ÄndraFärg()
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                färg = colorDialog.Color;
            }
        }

        // Metod som ändrar tjocklek
        public void ÄndraTjocklek(float nyTjocklek)
        {
            tjocklek = nyTjocklek;
        }

        public void Rita(Point startPoint, Point endPoint, Graphics g)
        {
            // Penna skapas med aktuell färg och tjocklek
            using (Pen pen = new Pen(färg, tjocklek))
            {
                g.DrawLine(pen, startPoint, endPoint);
            }
        }

       
    }
}
