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
    public partial class Form1 : Form
    {
        private bool Drawing = false;
        private Point previousPoint;
        public Penna Penna; // Skapa en instans av Penna
        private Point startPoint; // För att hålla koll på linjens startpunkt
        private Point endPoint; // För att hålla koll på linjens slutpunkt
        private bool DrawingLine = false; // Kollar vilken av ritfunktionerna som ska användas
        private readonly Bitmap bm = new Bitmap(800, 600);
        private bool DrawingRectangel = false;
        private bool DrawingEllipse = false;

        public Form1()
        {
            InitializeComponent();
            Penna = new Penna(Color.Black, 4.0f); // Skapa en Penna-instans med standardfärg och tjocklek  
        }
        
       
        private void btn_Rensa_Click(object sender, EventArgs e)
        {
            // Rensa PictureBox genom att rita en tom bild
            using (Graphics g = Graphics.FromImage(bm))
            {
                g.Clear(Color.White);
            }

            // Uppdatera PictureBox för att visa den tomma bilden
            pic.Invalidate();
            DrawingLine = false;
            DrawingEllipse = false;
            DrawingRectangel = false;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Drawing = true;
            previousPoint = e.Location;

            if (e.Button == MouseButtons.Left)
            {
                if (DrawingRectangel == true)
                {
                    startPoint = e.Location;
                    endPoint = e.Location;
                }
                else
                {
                    Drawing = true;
                }
            }
           
            if (e.Button == MouseButtons.Left)
            {
                if (DrawingLine == true)
                {

                    startPoint = e.Location; // Spara startpunkten för linjen
                    endPoint = e.Location;   // Sätt slutpunkten till samma som startpunkten
                }
                else
                {
                    // Användaren ritar en frihandlinje
                    Drawing = false;             // Flagga för att indikera att vi ritar
                    previousPoint = e.Location;   // Spara musens position som den tidigare punkten
                }
            }

            if(e.Button == MouseButtons.Left)
            {
                if(DrawingEllipse == true)
                {
                    startPoint = e.Location;
                    endPoint = e.Location;
                }
                else
                {
                Drawing = false;
                    previousPoint = e.Location;
                }
                
            }
        }

        public void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            if (Drawing)
            {
                using (Graphics g = Graphics.FromImage(bm))
                {
                    // Använd minPenna för att rita
                    Penna.Rita(previousPoint, e.Location, g);
                }
                previousPoint = e.Location;
                pic.Invalidate();
            }
            
                        
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Drawing = false;

            if (e.Button == MouseButtons.Left)
            {
                if (DrawingRectangel== true)
                {
                    endPoint = e.Location;
                    using (Graphics g = Graphics.FromImage(bm))
                    {
                        //Tar alla koordinater och gör om de till variabler.
                        Pen pen = new Pen(Color.Black, 9);
                        int x = Math.Min(startPoint.X, endPoint.X);
                        int y = Math.Min(startPoint.Y, endPoint.Y);
                        int w = Math.Abs(endPoint.X - startPoint.X);
                        int h = Math.Abs(endPoint.Y - startPoint.Y);
                        g.DrawRectangle(pen, new Rectangle(x, y, w, h));
                    }
                    pic.Invalidate();
                }
                else
                {
                    Drawing = false;
                }
            }
         
            if (e.Button == MouseButtons.Left)
            {
                if (DrawingLine == true )
                {
                    // Användaren ritar en rak linje
                    endPoint = e.Location; // Spara slutpunkten för linjen
                    using (Graphics g = Graphics.FromImage(bm))
                    {
                        g.DrawLine(Pens.Black, startPoint, endPoint); // Rita linjen från startpunkt till slutpunkt
                    }
                    pic.Invalidate(); // Uppdatera PictureBox för att visa ritningen
                }
                else
                {
                    // Användaren ritar en frihandlinje
                    Drawing = false; // Sluta rita
                }
            } 
            
            if (DrawingEllipse == true)
            {
                using (Graphics g = Graphics.FromImage(bm))
                {
                    Pen pen = new Pen(Color.Black, 5);
                    g.DrawEllipse(pen, new Rectangle(endPoint.X, endPoint.Y, (e.Location.X - endPoint.X), (e.Location.Y - endPoint.Y)));
                }
                pic.Invalidate();
            }
            else
            {
                Drawing = false;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bm, Point.Empty);
        } 
        private void Färg_Click(object sender, EventArgs e)
        {
            Penna.ÄndraFärg();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Penna.ÄndraTjocklek(trackBar1.Value);
        }

        public void Save()
        {
            //Metod som sparar användarens målning 
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PNG files (*.png)|*.png";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Spara bilden på den valda sökvägen som PNG
                bm.Save(saveFileDialog.FileName, ImageFormat.Png);
            }
        }

        private void btn_Spara_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btn_Linje_Click(object sender, EventArgs e)
        {
            DrawingLine = true;
            DrawingRectangel = false;
            DrawingEllipse = false;
            Drawing = false;
            
        }

        private void btn_Cirkel_Click(object sender, EventArgs e)
        {
            DrawingEllipse = true;
            DrawingRectangel = false;
            DrawingLine = false;
            Drawing = false;
           
        }

        private void btn_Rektangel_Click(object sender, EventArgs e)
        {
            DrawingRectangel = true;
            DrawingEllipse = false;
            DrawingLine = false;
            Drawing = false;
            
        }

        private void btn_Penna_Click(object sender, EventArgs e)
        {
            Drawing = true;
            DrawingRectangel = false;
            DrawingLine = false;
            DrawingEllipse = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
