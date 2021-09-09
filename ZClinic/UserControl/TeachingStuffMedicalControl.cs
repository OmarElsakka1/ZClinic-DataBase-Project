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
    public partial class TeachingStuffMedicalControl : UserControl
    {
        public Image ExcuseImage { get; set; }

        public string ExcuseName { get; set; }

        public string ExcuseID { get; set; }

        public string ExcuseMajor { get; set; }

        public string ExcuseStartDate { get; set; }

        public string ExcuseEndDate { get; set; }

        public string ExcuseSymptom1 { get; set; }

        public string ExcuseSymptom2 { get; set; }

        public string ExcuseSymptom3 { get; set; }

        public string ExcuseSymptom4 { get; set; }
        public TeachingStuffMedicalControl()
        {
            InitializeComponent();
        }

        private void TeachingStuffMedicalControl_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = ExcuseImage;
            bunifuCustomLabel1.Text = ExcuseName;
            bunifuCustomLabel10.Text = ExcuseMajor;
            bunifuCustomLabel12.Text = ExcuseSymptom1;
            bunifuCustomLabel13.Text = ExcuseSymptom2;
            bunifuCustomLabel14.Text= ExcuseSymptom3;
            bunifuCustomLabel15.Text = ExcuseSymptom4;
            bunifuCustomLabel5.Text = ExcuseStartDate;
            bunifuCustomLabel2.Text = ExcuseEndDate;
            bunifuCustomLabel11.Text = ExcuseID;
        }
    }
}
