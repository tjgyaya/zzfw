using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zzfw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool starBool = false;
        private void btn_star_Click(object sender, EventArgs e)
        {
            if (starBool)
            {
                stop();
                btn_star.Text = "开始运行";
            }
            else
            {
                star();
                btn_star.Text = "正在运行";
            }
        }
        public void star()
        {



        }

        public void stop()
        {



        }

    }
}
