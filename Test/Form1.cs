using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ligy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Init
            ToolTipWithPictureOrGif pictureOrGif = new ToolTipWithPictureOrGif();

            //picture or gif
            pictureOrGif.Binding(label1,Image.FromFile(Path.Combine(Application.StartupPath,"TestPic.jpg")));
        }
    }
}
