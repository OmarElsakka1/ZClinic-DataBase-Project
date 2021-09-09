using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZClinic.Model;

namespace ZClinic
{
    public partial class Drugs : Form
    {
        public bool aactivator = false;
        static Drugs _obj;
        string NationalId;
        string Type;
        public static Drugs Instance
        {
            get
            {
                if (_obj == null || _obj.IsDisposed)
                {
                    _obj = new Drugs();
                }
                return _obj;
            }
        }
        public FlowLayoutPanel FLayout
        {
            get { return flowLayoutPanel2; }

        }


        double Sum = 0;
        int CartCounter = 0;
        string imagePath = Application.StartupPath + @"\Images";
        Medicens mControl;
        //Medicens hControl;
        List<MedicineOrder> cartlist = new List<MedicineOrder>();
        Controller ControllerObj;
        public Drugs()
        {
            InitializeComponent();
            NationalId = login.ID;
            Type = login.TYPE;
            //////////////////////// I am working here     ////////////////////////////////////////////////////
            //////////////////////// I am working here     ////////////////////////////////////////////////////
            //////////////////////// I am working here     ////////////////////////////////////////////////////
            //////////////////////// I am working here     ////////////////////////////////////////////////////

            ControllerObj = new Controller();
           // object Name;
            //object priceS;
            //object ImageLocation;
           // object Description;
           // Double pricee;
            DataTable dt = ControllerObj.SelectDrugsData();
            /*
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Name = dt.Rows[i].ItemArray[0].ToString();
                            priceS = dt.Rows[i].ItemArray[1].ToString();
                            ImageLocation = dt.Rows[i].ItemArray[2].ToString();
                            Description = dt.Rows[i].ItemArray[3].ToString();
                            pricee = Double.Parse(dt.Rows[i].ItemArray[1].ToString());
                            drugsList.Add(A);
                        }*/

           // double price = 11.67;       // Delete it 
            //double price2 = 10.89;      // Delete it 
            //double price3 = 56.98;      // Delete it 
            //double price4 = 10.50;      // Delete it 
            //double price5 = 10.87;      // Delete it 
            //string omar = "Betaidne.jpg";   // Delete it 


            ////////////////////////     Till here     ////////////////////////////////////////////////////
            ////////////////////////    Till here     ////////////////////////////////////////////////////
            ////////////////////////    Till here     ////////////////////////////////////////////////////
            ////////////////////////     Till here     ////////////////////////////////////////////////////


            //Sum = price + price2 + price3 + price4 + price5;
            List<DrugsClass> drugsList = new List<DrugsClass>();
            //drugsList.AddRange(new List<DrugsClass>()
            //{
            //    new DrugsClass
            //    {
            //      Name = "Panadol",
            //      Price = "EGY " + price.ToString(),
            //      Description = "Paracetamol",
            //      ImagePath = imagePath + @"\Panadol.png"

            //    },
            //    new DrugsClass
            //    {
            //      Name = "Asprin",
            //       Price = "EGY " + price2.ToString(),
            //      Description = "Asprinazolzin",
            //      ImagePath = imagePath + @"\Asprin.jpg"
            //    },
            //    new DrugsClass
            //    {
            //      Name = "Symbicort",
            //      Price = "EGY " + price3.ToString(),
            //      Description = "Cortizon",
            //      ImagePath = imagePath + @"\Symbicort.jpg"
            //    },
            //      new DrugsClass
            //    {
            //      Name = "Nasonex",
            //      Price = "EGY " + price4.ToString(),
            //      Description = "Cortizon",
            //      ImagePath = imagePath + @"\Nasonex.jpg"
            //    },
            //      new DrugsClass
            //    {
            //      Name = "Betaidne",
            //      Price = "EGY " + price5.ToString(),
            //      Description = "Purpline",
            //      ImagePath = imagePath + @"\"+omar
            //    }
            //}) ;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DrugsClass A = new DrugsClass
                {
                    Name = dt.Rows[i].ItemArray[0].ToString(),//to get name by query from database
                    Price = dt.Rows[i].ItemArray[1].ToString(), //to get price by query from database
                    Description = dt.Rows[i].ItemArray[3].ToString(),//to get description from database
                    ImagePath = imagePath + @"\" + dt.Rows[i].ItemArray[2].ToString()//to get image name from the database e.g Panadol.png
                };
                drugsList.Add(A);
            }
            /*
            for (int i = 0; i < Count; i++)//Count from database
            {
                DrugsClass A = new DrugsClass
                {
                    Name = "",//to get name by query from database
                    Price = "", //to get price by query from database
                    Description = "",//to get description from database
                    ImagePath = imagePath + @"\"+//to get image name from the database e.g Panadol.png
                };
                drugsList.Add(A);
            }*/
            foreach (var drug in drugsList)
            {
                Medicens medicine = new Medicens();
                medicine.drugImage = Image.FromFile(drug.ImagePath);
                medicine.drugName = drug.Name;
                medicine.drugPrice = drug.Price;
                medicine.drugDescription = drug.Description;
                flowLayoutPanel1.Controls.Add(medicine);
                medicine.MouseDown += Medicens_MouseDown;
                //medicine.MouseClick += Medicens_MouseHover;
            }
            // Medicens M1 = new Medicens();
            // M1.pictureBox1.Image = global::ZClinic.Properties.Resources.squared_menu_24px;
        }

        /* private void Medicens_MouseHover(object sender, EventArgs e)
         { 
            hControl = (Medicens)sender;
            Bitmap bitmap = new Bitmap(mControl.Width, mControl.Height);
             this.DoDragDrop(mControl, DragDropEffects.All);
         }*/

        private void Drugs_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            e.UseDefaultCursors = false;
        }


        private void Medicens_MouseDown(object sender, MouseEventArgs e)
        {
            mControl = (Medicens)sender;
            Bitmap bitmap = new Bitmap(mControl.Width, mControl.Height);
            mControl.DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
            Cursor cursor = new Cursor(bitmap.GetHicon());
            Cursor.Current = cursor;
            this.DoDragDrop(mControl, DragDropEffects.All);
        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Close();
        }
        public void IfActivatorTrue(bool activator, Medicens Resp)
        {
            if (activator == true)
            {
                bool found = false;
                MedicineOrder drugOrder = new MedicineOrder();
                if (cartlist.Count != 0)
                {
                    for (int i = 0; i < cartlist.Count; i++)
                    {
                        if (cartlist[i].drugName == Resp.drugName)
                        {
                            cartlist[i].drugQuantity = cartlist[i].drugQuantity + 1;
                            //MedicineOrder temp=cartlist[i];
                            //flowLayoutPanel2.Refresh();
                            cartlist[i].LoadQ();
                            //flowLayoutPanel2.Invalidate();
                            //flowLayoutPanel2.Update();
                            // flowLayoutPanel2.Update();
                            //flowLayoutPanel2.Controls.Remove(cartlist[i]);
                            //flowLayoutPanel2.Controls.Add(temp);
                            //cartlist.Add(temp);
                            found = true;
                        }
                    }
                }
                drugOrder.drugName = Resp.drugName;
                drugOrder.drugPrice = Resp.drugPrice;

                char[] removing = { 'E', 'G', 'Y', ' ' };
                string final = drugOrder.drugPrice.Trim(removing);
                double P = Double.Parse(final);
                CartCounter++;
                Sum += P;
                drugOrder.drugImage = Resp.drugImage;
                drugOrder.drugDescription = Resp.drugDescription;
                //flowLayoutPanel2.Controls.Add(drugOrder);
                flowLayoutPanel2.AutoScrollPosition = new Point(drugOrder.Left, drugOrder.Right);
                bunifuMaterialTextbox3.Text = Sum.ToString();

                if (found == false)
                {
                    drugOrder.drugQuantity++;
                    cartlist.Add(drugOrder);
                    flowLayoutPanel2.Controls.Add(drugOrder);
                }
                found = false;
                flowLayoutPanel2.Refresh();
            }

        }
        public void RemoveMed(MedicineOrder med)
        {
            for (int i = 0; i < cartlist.Count; i++)
            {
                if (cartlist[i].drugName == med.drugName)
                {
                    char[] removing = { 'E', 'G', 'Y', ' ' };
                    string final = med.drugPrice.Trim(removing);
                    double P = Double.Parse(final);
                    CartCounter--;

                    Sum = Math.Round(Sum - ((cartlist[i].drugQuantity) * P), 2);
                    if (CartCounter == 0)
                    {
                        Sum = 0;
                        bunifuMaterialTextbox3.Text = "";
                    }
                    else
                    {
                        bunifuMaterialTextbox3.Text = Sum.ToString();
                    }
                    flowLayoutPanel2.Controls.Remove(cartlist[i]);
                    cartlist.RemoveAt(i);

                }
            }
        }
        private void flowLayoutPanel2_DragDrop(object sender, DragEventArgs e)
        {
            bool found = false;
            MedicineOrder drugOrder = new MedicineOrder();
            if (cartlist.Count != 0)
            {
                for (int i = 0; i < cartlist.Count; i++)
                {
                    if (cartlist[i].drugName == mControl.drugName)
                    {
                        cartlist[i].drugQuantity = cartlist[i].drugQuantity + 1;
                        //MedicineOrder temp=cartlist[i];
                        //flowLayoutPanel2.Refresh();
                        cartlist[i].LoadQ();
                        //flowLayoutPanel2.Invalidate();
                        //flowLayoutPanel2.Update();
                        // flowLayoutPanel2.Update();
                        //flowLayoutPanel2.Controls.Remove(cartlist[i]);
                        //flowLayoutPanel2.Controls.Add(temp);
                        //cartlist.Add(temp);
                        found = true;
                    }
                }
            }
            drugOrder.drugName = mControl.drugName;
            drugOrder.drugPrice = mControl.drugPrice;

            char[] removing = { 'E', 'G', 'Y', ' ' };
            string final = drugOrder.drugPrice.Trim(removing);
            double P = Double.Parse(final);
            CartCounter++;
            Sum = Sum + P;
            drugOrder.drugImage = mControl.drugImage;
            drugOrder.drugDescription = mControl.drugDescription;
            //flowLayoutPanel2.Controls.Add(drugOrder);
            flowLayoutPanel2.AutoScrollPosition = new Point(drugOrder.Left, drugOrder.Right);
            bunifuMaterialTextbox3.Text = Sum.ToString();

            if (found == false)
            {
                drugOrder.drugQuantity++;
                cartlist.Add(drugOrder);
                flowLayoutPanel2.Controls.Add(drugOrder);
            }
            found = false;

            //mControl.Parent.Controls.Remove(mControl); //to prevent removing from flowLayout

        }

        private void flowLayoutPanel2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void flowLayoutPanel2_DragOver(object sender, DragEventArgs e)
        {

            Bitmap bitmap = new Bitmap(Properties.Resources.breakable_50px, new Size(30, 30));
            Cursor cur = new Cursor(bitmap.GetHicon());
            Cursor.Current = cur;

        }

        private void flowLayoutPanel2_DragLeave(object sender, EventArgs e)
        {
            //Cursor.Current = Cursor;
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {

            if (CartCounter == 0)
            {
                MessageBox.Show("Fill Your Cart First, It Is Empty!");
            }
            else
            {

                ///////////////////////////////////////////////////////////
                /////////////////////////////////////////////////////////
                ///////////// I am working here////////////////////////
                //////////////// I am working here////////////////////////
                //////////////// I am working here////////////////////////
                /////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////
                ///

               


                //////////////////////////////////////////////////////
                //////////////////////////////////////////////////////
                ////////// Till Here////////////////////////////
                ////////////////Till here//////////////////////
                /////////////////////////////////////////
                //------------------------------------------To Do-------------------------------------//
                //query to update user balance 
                //query to send those medicines to be recorded that they are ordered with the patient 
                //------------------------------------------------------------------------------------//
                for (int i = 0; i < cartlist.Count(); i++)
                {
                    ////////////////////////////////////Sakka////////////////////////////////////////////////////////////////////////////////
                    string NationalID =NationalId;    ///// delete it /////
                    string Drugname =cartlist[i].drugName;        //fixed
                    Int32 number = cartlist[i].drugQuantity;                ///// delete it /////
                    // the next query will be done for each drugname
                    // number here is the number that the user requested from that drug.
                    int result = ControllerObj.Request_Drugs(NationalID, Drugname, number);
                    if (result == 0)
                    {
                        MessageBox.Show("the request of drug " + Drugname + " failed!");
                    }
                    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    flowLayoutPanel2.Controls.Remove(cartlist[i]);
                    //flowLayoutPanel2.Controls.Add(cartlist[i]);
                }
                Sum = 0;
                cartlist.Clear();
                bunifuMaterialTextbox3.Text = "";
                MessageBox.Show("Medicines Requested!");
            }
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new OrderDrugs().Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard.Instance.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (Type == "Student")
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

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hospital.Instance.Show();
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

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactDevelopers.Instance.Show();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
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

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new EditProfile().Show();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Dashboard.Instance.Close();
            
        }

        private void Drugs_FormClosed(object sender, FormClosedEventArgs e)
        {
            _obj = null;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}