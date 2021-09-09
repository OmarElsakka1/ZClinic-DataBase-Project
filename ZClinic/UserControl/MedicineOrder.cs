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
    public partial class MedicineOrder : UserControl
    {
        public Image drugImage { get; set; }

        public string drugName { get; set; }

        public string drugPrice { get; set; }

        public string drugDescription { get; set; }
       
        public int drugQuantity { get; set; }


        public MedicineOrder()
        {
            InitializeComponent();
            bunifuMaterialTextbox1.Text = drugQuantity.ToString();
            //drugQuantity =1;
        }

        private void MedicineOrder_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = drugImage;
            bunifuCustomLabel1.Text = drugName;
            bunifuCustomLabel2.Text = drugPrice;
            bunifuCustomLabel3.Text = drugDescription;
            bunifuMaterialTextbox1.Text = drugQuantity.ToString();

        }

        internal void LoadQ()
        {
          /*  pictureBox1.Image = drugImage;
            bunifuCustomLabel1.Text = drugName;
            bunifuCustomLabel2.Text = drugPrice;
            bunifuCustomLabel3.Text = drugDescription;*/
            bunifuMaterialTextbox1.Text = drugQuantity.ToString();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Drugs.Instance.RemoveMed(this);
        }
    }
}
