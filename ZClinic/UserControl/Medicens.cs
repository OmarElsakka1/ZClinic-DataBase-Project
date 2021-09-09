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
    
    public partial class Medicens : UserControl
    {
        
        int counter = 0;
        public Image drugImage { get; set; }

        public string drugName { get; set; }

        public string drugPrice { get; set; }

        public string drugDescription { get; set; }

        public Medicens()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            counter++;
            bunifuMaterialTextbox1.Text = counter.ToString();

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            if (counter > 0)
            {
                counter--;
                bunifuMaterialTextbox1.Text = counter.ToString();

            }
            else
            {
                counter = 0;
                bunifuMaterialTextbox1.Text = counter.ToString();
            }
        }

        private void Medicens_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = drugImage;
            bunifuCustomLabel1.Text = drugName;
            bunifuCustomLabel3.Text = drugDescription;
            bunifuCustomLabel2.Text = drugPrice;
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            int Count = Int32.Parse(bunifuMaterialTextbox1.Text);
            if(Count!=0)
            {
                for(int i=0;i<Count;i++)
                {
                    bool acctivator = true;
                    Drugs.Instance.IfActivatorTrue(acctivator,this);
                }
            }
            else
            {
                MessageBox.Show("Select Quantity First");
            }
        }
    }
}
