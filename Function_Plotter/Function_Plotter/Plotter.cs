using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Function_Plotter 
{
    class Plotter : Form1
    { 
        private string y;

        Bitmap finalBmp;

        Form1 mainForm;
        Grid grid;

        public Plotter()
        { 
            mainForm = new Form1();

            grid = new Grid(Convert.ToUInt32(mainForm.gridWidthTextBox.Text), Convert.ToUInt32(mainForm.gridHeightTextBox.Text), mainForm.scaleSlider.Value); // Ensure text can be converted to UInt later.
            finalBmp = grid.GridBmp;

            y = mainForm.functionTextBox.Text;
        }

        private void plotFunction(double y, int scale)
        {

        }
    }
}
