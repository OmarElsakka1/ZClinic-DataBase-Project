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
    public partial class MedicalExcuseAcceptingTemp : UserControl
    {
        public Image ExcuseImage { get; set; }

        public string ExcuseName { get; set; }
        
        public string ExcuseID { get; set; }


        public string ExcuseAge { get; set; }

        public string ExcuseMajor { get; set; }

        public string ExcuseStartDate { get; set; }

        public string ExcuseEndDate { get; set; }

        public string ExcuseSymptom1 { get; set; }

        public string ExcuseSymptom2 { get; set; }

        public string ExcuseSymptom3 { get; set; }

        public string ExcuseSymptom4 { get; set; }

        public MedicalExcuseAcceptingTemp()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MedicalExcuses.Instance.IfAccept(this);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MedicalExcuses.Instance.IfDeny(this);
        }
        private void MedicalExcuseAcceptingTemp_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = ExcuseImage;
            bunifuCustomLabel1.Text = ExcuseName;
            bunifuCustomLabel2.Text = ExcuseAge;
            bunifuCustomLabel9.Text = ExcuseMajor;
            bunifuCustomLabel11.Text = ExcuseSymptom1;
            bunifuCustomLabel12.Text = ExcuseSymptom2;
            bunifuCustomLabel13.Text = ExcuseSymptom3;
            bunifuCustomLabel14.Text = ExcuseSymptom4;
            bunifuCustomLabel6.Text = ExcuseStartDate;
            bunifuCustomLabel7.Text = ExcuseEndDate;
            bunifuCustomLabel16.Text = ExcuseID;
        }
       
    }


}

