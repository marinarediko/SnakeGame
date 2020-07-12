using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;

namespace SnakeGame 
{
    class Area : PictureBox
    {
        Snake snake = new Snake();
        
        public Area()
        {
            InitializeArea();
        }

        private void InitializeArea()
        {
            this.BackColor = Color.RosyBrown;
            this.Height = 400 ;
            this.Width = 400;
        }      
    }
}
