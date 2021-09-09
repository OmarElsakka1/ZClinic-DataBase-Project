using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZClinic
{
    public partial class Hospitals : UserControl
    {
        public string hospitalName { get; set; }
        public string hospitalAddress { get; set; }
        public string hospitalLinkMap { get; set; }
        public string hospitalPhoneNumber { get; set; }

        public Hospitals()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Hospitals_Load(object sender, EventArgs e)
        {

            bunifuCustomLabel1.Text = hospitalName;
            bunifuCustomLabel3.Text = hospitalAddress;
            bunifuCustomLabel2.Text = hospitalLinkMap;
            bunifuCustomLabel8.Text = hospitalPhoneNumber;
        }
    }
}