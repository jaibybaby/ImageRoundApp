using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageRoundApp
{
    public partial class Form1 : Form
    {
        int buttonClickCount = 0;
        int buttonClickCountLeft = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
           
            buttonClickCount = buttonClickCount + 1;
            if (buttonClickCount == 1)
            {
               picOrangeFish.Image =  ImageRoundApp.Properties.Resources.purplefish; //purpl
                picBlueFish.Image =  ImageRoundApp.Properties.Resources.orangefish;//orang
               picWhiteFish.Image =  ImageRoundApp.Properties.Resources.bluefish;//blu
                picPurpleFish.Image =  ImageRoundApp.Properties.Resources.whitefish;//white

            }
            if (buttonClickCount == 2)
            {
                 picOrangeFish.Image = ImageRoundApp.Properties.Resources.whitefish;
                picBlueFish.Image =  ImageRoundApp.Properties.Resources.purplefish;
               picWhiteFish.Image =  ImageRoundApp.Properties.Resources.orangefish;
                picPurpleFish.Image =  ImageRoundApp.Properties.Resources.bluefish;

            }
            if (buttonClickCount == 3)
            {
                picBlueFish.Image =  ImageRoundApp.Properties.Resources.whitefish;
               picWhiteFish.Image =  ImageRoundApp.Properties.Resources.purplefish;
                picPurpleFish.Image =  ImageRoundApp.Properties.Resources.orangefish;
                 picOrangeFish.Image =  ImageRoundApp.Properties.Resources.bluefish;
            }
            if (buttonClickCount ==4 )
            {
                picBlueFish.Image =  ImageRoundApp.Properties.Resources.bluefish;
               picWhiteFish.Image =  ImageRoundApp.Properties.Resources.whitefish;
                picPurpleFish.Image =  ImageRoundApp.Properties.Resources.purplefish;
                 picOrangeFish.Image =  ImageRoundApp.Properties.Resources.orangefish;
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            buttonClickCountLeft = buttonClickCountLeft + 1;
            if (buttonClickCountLeft == 1)
            {
                picOrangeFish.Image = ImageRoundApp.Properties.Resources.bluefish;
                picBlueFish.Image = ImageRoundApp.Properties.Resources.whitefish;
                picWhiteFish.Image = ImageRoundApp.Properties.Resources.purplefish;
                picPurpleFish.Image = ImageRoundApp.Properties.Resources.orangefish;

            }
            if (buttonClickCountLeft == 2)
            {
                picOrangeFish.Image = ImageRoundApp.Properties.Resources.whitefish;
                picBlueFish.Image = ImageRoundApp.Properties.Resources.purplefish;
                picWhiteFish.Image = ImageRoundApp.Properties.Resources.orangefish;
                picPurpleFish.Image = ImageRoundApp.Properties.Resources.bluefish;

            }
            if (buttonClickCountLeft == 3)
            {
                picBlueFish.Image = ImageRoundApp.Properties.Resources.orangefish;
                picWhiteFish.Image = ImageRoundApp.Properties.Resources.bluefish;
                picPurpleFish.Image = ImageRoundApp.Properties.Resources.whitefish;
                picOrangeFish.Image = ImageRoundApp.Properties.Resources.purplefish;
            }
            if (buttonClickCountLeft == 4)
            {
                picBlueFish.Image = ImageRoundApp.Properties.Resources.bluefish;
                picWhiteFish.Image = ImageRoundApp.Properties.Resources.whitefish;
                picPurpleFish.Image = ImageRoundApp.Properties.Resources.purplefish;
                picOrangeFish.Image = ImageRoundApp.Properties.Resources.orangefish;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {

        }
    }
}
