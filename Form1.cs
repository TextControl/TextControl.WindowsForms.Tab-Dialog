using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txTabPositions
{
    public partial class Form1 : Form
    {
        private int iDpiX = 15;
        public Form1()
        {
            InitializeComponent();
            
            // get resolution conversion value
            Graphics g = textControl1.CreateGraphics();
            iDpiX = (int)(1440 / g.DpiX);

            // set page units to twips
            textControl1.PageUnit = TXTextControl.MeasuringUnit.Twips;
        }

        private void rulerBar1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // calculate zoom factor
            float fZoomFactor = (float)textControl1.ZoomFactor / 100;

            // get the click location in the ruler bar
            int iClickLocation = (int)((e.X * iDpiX) + (textControl1.ScrollLocation.X * fZoomFactor));

            // loop through all tab positions
            foreach (int tabPosition in textControl1.Paragraphs.GetItem(
                textControl1.Selection.Start).Format.TabPositions)
            {
                // retrieve the exact location including zoom factor
                int iTabLocation = (int)((tabPosition + 
                    textControl1.Sections.GetItem().Format.PageMargins.Left) * fZoomFactor);

                // if click location matches tab position
                // open the tab dialog
                if (iClickLocation >= iTabLocation - 50 && iClickLocation <= iTabLocation + 50)
                {
                    textControl1.TabDialog(); // open dialog
                    break;
                }
            }
        }
    }
}
