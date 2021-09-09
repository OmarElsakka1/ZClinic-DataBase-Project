using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZClinic
{
    public partial class TBM : UserControl
    {
        public string text { get; set; }
        public TBM()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox7_Load(object sender, EventArgs e)
        {
            text = bunifuMetroTextbox7.Text;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void bunifuMetroTextbox7_OnValueChanged(object sender, EventArgs e)
        {
            text = bunifuMetroTextbox7.Text;
        }
    }
}
