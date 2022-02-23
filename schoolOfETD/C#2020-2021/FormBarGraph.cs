using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // ---------------------------------------------------------------------

        private void log(string str) { System.Diagnostics.Debug.WriteLine(str); }

        readonly Random random = new Random();
        readonly int max_value = 20;
        
        List<int> data = new List<int>(new int[] { 5, 2, 7, 12, 3 });


        private void button1_Click(object sender, EventArgs e) {
            // Manipulate data
            data.RemoveAt(0);  // Remove the first element
            data.Add(random.Next(0, max_value));  /// Add new random element to the end
            renderData(data, pictureBox1.CreateGraphics());  // Draw the bar graph
        }

        void renderData(IList<int> data, Graphics g) {
            SolidBrush brush = new SolidBrush(Color.Red);
            int width = (int)g.VisibleClipBounds.Size.Width;
            int height = (int)g.VisibleClipBounds.Size.Height;
            //int max_value = data.Max();  // for responsive height
            int width_per_item = width / data.Count;
            int height_ratio = height / max_value;

            g.FillRectangle(new SolidBrush(Color.Black), 0, 0, width, height);  // Clear the whole drawing area with a color
            for (int i=0; i<data.Count; i++) {
                var value = data[i];
                int bar_height = height_ratio * value;
                g.FillRectangle(brush, new Rectangle(
                    new Point(i * width_per_item, height - bar_height),
                    new Size(width_per_item, bar_height)
                ));
            }
        }

        // ---------------------------------------------------------------------
    }
}
