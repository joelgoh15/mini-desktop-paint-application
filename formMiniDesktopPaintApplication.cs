using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace project8_3
{
    public partial class formMiniDesktopPaintApplication : Form
    {
        bool shouldPaint = false;
        public static Color selectedColor;
        int selectedBrushSize;

        public formMiniDesktopPaintApplication()
        {
            InitializeComponent();
        }


        private void formMiniDesktopPaintApplication_Load(object sender, EventArgs e)
        {
            selectedColor = Color.Red;
            selectedBrushSize = 4;
        }

        private void radioButtonRedColor2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRedColor2.Checked)
            {
                selectedColor = Color.Red;
            }
        }

        private void radioButtonorangeColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonorangeColor.Checked)
            {
                selectedColor = Color.Orange;
            }
        }

        private void radioButtonYellowColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonYellowColor.Checked)
            {
                selectedColor = Color.Yellow;
            }
        }

        private void radioButtonGreenButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGreenButton.Checked)
            {
                selectedColor = Color.Green;
            }
        }

        private void radioButtonBlueColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBlueColor.Checked)
            {
                selectedColor = Color.Blue;
            }
        }

        private void radioButtonIndigoColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIndigoColor.Checked)
            {
                selectedColor = Color.Indigo;
            }
        }

        private void radioButtonVioletColor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonVioletColor.Checked)
            {
                selectedColor = Color.Violet;
            }
        }

        private void radioButtonThinBrushSize_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonThinBrushSize.Checked)
            {
                selectedBrushSize = 4;
            }
        }

        private void radioButtonMediumBrushSize_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMediumBrushSize.Checked)
            {
                selectedBrushSize = 8;
            }
        }

        private void radioButtonThickBrushSize_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonThickBrushSize.Checked)
            {
                selectedBrushSize = 12;
            }
        }


        private void formMiniDesktopPaintApplication_MouseDown(object sender, MouseEventArgs e)
        {
            shouldPaint = true;
        }

        private void formMiniDesktopPaintApplication_MouseUp(object sender, MouseEventArgs e)
        {
            shouldPaint = false;
        }

        private void formMiniDesktopPaintApplication_MouseMove(object sender, MouseEventArgs e)
        {
            if (shouldPaint)
            {
                using (Graphics graphics = CreateGraphics())
                {
                    graphics.FillEllipse(new SolidBrush(selectedColor), e.X, e.Y, selectedBrushSize, selectedBrushSize);
                }
            }
        }

        private void buttonClearDrawingBoard_Click(object sender, EventArgs e)
        {
            using (Graphics graphics = CreateGraphics())
            {
                graphics.Clear(Color.White);
                radioButtonRedColor2.Checked = true;
                radioButtonThinBrushSize.Checked = true;
                selectedBrushSize = 4;

            }

        }
    }//end-class
}//end-namespace
