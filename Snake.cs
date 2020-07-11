using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Snakeame
{
    class Snake
    {
        public List<PictureBox> snakePixels = new List<PictureBox>();
        public Snake()
        {
            InitializeSnake();
        }
        
        private void InitializeSnake()
        {
            PictureBox pixel = new PictureBox();
            pixel.Height = 20;
            pixel.Width = 20;
            pixel.BackColor = Color.SlateGray;
            snakePixels.Add(pixel);           
        }

        public void Render(Form form)
        {
            foreach (var sp in snakePixels)
            {
                form.Controls.Add(sp);
            }           
        }

    }
}
