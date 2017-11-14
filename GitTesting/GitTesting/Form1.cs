using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitTesting
{
    public partial class Test_from : Form
    {
        public Test_from()
        {
            InitializeComponent();
        }

        private void Test_button_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Byte[] b = new Byte[3];
            rnd.NextBytes(b);
            Color color = Color.FromArgb(b[0], b[1], b[2]);
            Test_button.BackColor = color;
        }
    }
}
