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
    public partial class OrderDrugs : Form
    {
        int counter = 0;
        string NationalId;
        string Type;
        static OrderDrugs _obj;
        public static OrderDrugs Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new OrderDrugs();
                }
                return _obj;
            }
        }

        Controller ControllerObj;
        public OrderDrugs()
        {
            InitializeComponent();
            ControllerObj = new Controller() ;
            NationalId = login.ID;
            Type = login.TYPE;
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactDevelopers.Instance.Show();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard.Instance.Show();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            ////////////////////// /////////////////////////////////////
            /////////////////////////////////////////////////////////
            ///////////// I am working here ///////////////////////
            //////////////// I am working here ///////////////////////
            //////////////// I am working here ///////////////////////
            ////////////////////////////////////////////////////////
            ///////////////////////////////////////////////////
            ///

            // IF you wanna fill the list automaticall form the database use the following
            //GetAllDrugs query


            string NationalID =NationalId;      //// Delete it 
            string DrugName = bunifuMaterialTextbox1.Text;         //// Delete it
            Int32 Number = counter;                    //// Delete it
            //Don't forget to delete the barcode.
            int result = ControllerObj.Request_Drugs(NationalID, DrugName, Number);
            if (result == 0)
            {
                MessageBox.Show("The request fails!");
            }

            ////////////////////////////////////////////////////
            //////////////////////////////////////////////////////
            /////////// Till here //////////////////////////////
            ////////// Till here //////////////////////////////
            ////////// Till here //////////////////////////////
            ///////////////////////////////////////////////



            Int32 value;
            if ( bunifuMaterialTextbox1.Text != "")
            {
                if (counter != 0)
                {
                    //if (int.TryParse(bunifuMaterialTextbox2.Text, out value))
                    //{
                      //  MessageBox.Show("Request Successful!");

                    //}
                    //else
                    //{
                      //  MessageBox.Show("Barcode Incorrect, only numbers allowed");
                    //}
                }
                else
                {
                    MessageBox.Show("Input Quantity first");
                }
            }
            else
            {
                MessageBox.Show("Input name");
            }
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            
            counter++;
            bunifuMaterialTextbox3.Text = counter.ToString();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                bunifuMaterialTextbox3.Text = counter.ToString();
            }
            else
            {
                counter=0;
                bunifuMaterialTextbox3.Text = counter.ToString();

            }

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Type == "Admin")
            {
                //Support Admin
            }
            else if (Type == "Student" || Type == "Teaching Stuff" || Type == "Nurse" || Type == "Doctor")
            {
                SupportUser.Instance.Show();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (Type == "Student" || Type == "Teaching Stuff")
            {
                this.Hide();
                RequestMedicalExcuse.Instance.Show();

            }
            else if (Type == "Doctor")
            {
                this.Hide();
                MedicalExcuses.Instance.Show();
            }
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (Type == "Nurse" || Type == "Doctor")
            {
                ViewAppointments.Instance.Show();
            }
            else if (Type == "Student" || Type == "Teaching Stuff" || Type == "Admin")
            {
                this.Hide();
                BookAppointment.Instance.Show();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Dashboard.Instance.Close();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new EditProfile().Show(); 
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drugs.Instance.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (Type == "Nurse" || Type == "Doctor")
            {
                new DrugsEntry().Show();
            }
            else if (Type == "Student" || Type == "Teaching Stuff" || Type == "Admin")
            {
                this.Hide();
                Drugs.Instance.Show();
            }
        }

        //  private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        // DataTable dt = ControllerObj.GetAllDrugs();
        //comboBox1.DataSource = dt;
        //comboBox1.DisplayMember = "Names";

        //dt.
        //}
    }
}
