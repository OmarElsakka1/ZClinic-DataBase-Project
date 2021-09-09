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
    public partial class Statistics : Form
    {
        Controller Controllerobj;
        public Statistics()
        {
            InitializeComponent();
            Controllerobj = new Controller();

            if (Int32.Parse(Controllerobj.Get_Month().ToString()) == 9 || Int32.Parse(Controllerobj.Get_Month().ToString()) == 10 || Int32.Parse(Controllerobj.Get_Month().ToString()) == 11 || Int32.Parse(Controllerobj.Get_Month().ToString()) == 12)
            {
                Int32 year1m = Int32.Parse(Controllerobj.GetNumPerSex_Branch(0, 'M').ToString());
                Int32 year1f = Int32.Parse(Controllerobj.GetNumPerSex_Branch(0, 'F').ToString());
                Int32 year1 = year1m + year1f;

                Int32 year2m = Int32.Parse(Controllerobj.GetNumPerSex_Branch(1, 'M').ToString());
                Int32 year2f = Int32.Parse(Controllerobj.GetNumPerSex_Branch(1, 'F').ToString());
                Int32 year2 = year2m + year2f;

                Int32 year3m = Int32.Parse(Controllerobj.GetNumPerSex_Branch(2, 'M').ToString());
                Int32 year3f = Int32.Parse(Controllerobj.GetNumPerSex_Branch(2, 'F').ToString());
                Int32 year3 = year3m + year3f;

                Int32 year4m = Int32.Parse(Controllerobj.GetNumPerSex_Branch(3, 'M').ToString());
                Int32 year4f = Int32.Parse(Controllerobj.GetNumPerSex_Branch(3, 'F').ToString());
                Int32 year4 = year4m + year4f;

                Int32 year5m = Int32.Parse(Controllerobj.GetNumPerSex_Branch(4, 'M').ToString());
                Int32 year5f = Int32.Parse(Controllerobj.GetNumPerSex_Branch(4, 'F').ToString());
                Int32 year5 = year5m + year5f;

                Year1M.Text = year1m.ToString();
                Year1F.Text = year1f.ToString();
                Year1.Text = year1.ToString();

                Year2M.Text = year2m.ToString();
                Year2F.Text = year2f.ToString();
                Year2.Text = year2.ToString();

                Year3M.Text = year3m.ToString();
                Year3F.Text = year3f.ToString();
                Year3.Text = year3.ToString();

                Year4M.Text = year4m.ToString();
                Year4F.Text = year4f.ToString();
                Year4.Text = year4.ToString();

                Year5M.Text = year5m.ToString();
                Year5F.Text = year5f.ToString();
                Year5.Text = year5.ToString();

                TotalMale.Text = (year1m + year2m + year3m + year4m + year5m).ToString();
                TotalFemale.Text = (year1f + year2f + year3f + year4f + year5f).ToString();
            }
            else
            {
                Int32 year1m = Int32.Parse(Controllerobj.GetNumPerSex_Branch(1, 'M').ToString());
                Int32 year1f = Int32.Parse(Controllerobj.GetNumPerSex_Branch(1, 'F').ToString());
                Int32 year1 = year1m + year1f;

                Int32 year2m = Int32.Parse(Controllerobj.GetNumPerSex_Branch(2, 'M').ToString());
                Int32 year2f = Int32.Parse(Controllerobj.GetNumPerSex_Branch(2, 'F').ToString());
                Int32 year2 = year2m + year2f;

                Int32 year3m = Int32.Parse(Controllerobj.GetNumPerSex_Branch(3, 'M').ToString());
                Int32 year3f = Int32.Parse(Controllerobj.GetNumPerSex_Branch(3, 'F').ToString());
                Int32 year3 = year3m + year3f;

                Int32 year4m = Int32.Parse(Controllerobj.GetNumPerSex_Branch(4, 'M').ToString());
                Int32 year4f = Int32.Parse(Controllerobj.GetNumPerSex_Branch(4, 'F').ToString());
                Int32 year4 = year4m + year4f;

                Int32 year5m = Int32.Parse(Controllerobj.GetNumPerSex_Branch(5, 'M').ToString());
                Int32 year5f = Int32.Parse(Controllerobj.GetNumPerSex_Branch(5, 'F').ToString());
                Int32 year5 = year5m + year5f;

                Year1M.Text = year1m.ToString();
                Year1F.Text = year1f.ToString();
                Year1.Text = year1.ToString();

                Year2M.Text = year2m.ToString();
                Year2F.Text = year2f.ToString();
                Year2.Text = year2.ToString();

                Year3M.Text = year3m.ToString();
                Year3F.Text = year3f.ToString();
                Year3.Text = year3.ToString();

                Year4M.Text = year4m.ToString();
                Year4F.Text = year4f.ToString();
                Year4.Text = year4.ToString();

                Year5M.Text = year5m.ToString();
                Year5F.Text = year5f.ToString();
                Year5.Text = year5.ToString();
                TotalMale.Text = (year1m + year2m + year3m + year4m + year5m).ToString();
                TotalFemale.Text = (year1f + year2f + year3f + year4f + year5f).ToString();
            }
        }

        private void Year1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Statistics_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}