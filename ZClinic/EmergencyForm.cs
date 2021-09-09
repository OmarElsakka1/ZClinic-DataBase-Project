using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace ZClinic
{
    public partial class EmergencyForm : Form
    {
        Controller ControllerObj;
        static EmergencyForm _obj;
        public static EmergencyForm Instance
        {
            get
            {
                if (_obj == null ||_obj.IsDisposed)
                {
                    _obj = new EmergencyForm();
                }
                return _obj;
            }

        }
        public EmergencyForm()
        {
            InitializeComponent();
            ControllerObj = new Controller();
        }

        private void Donebutton_Click(object sender, EventArgs e)
        {
            if(Email.Text =="" || Building.Text == "")
            {
                MessageBox.Show("You Must Fill All the Entries");
            }
            else
            {
                if(ControllerObj.Get_NationalID(Email.Text)!=null)
                {
                    string NID=ControllerObj.Get_NationalID(Email.Text).ToString();
                }
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.Amb;
                popup.TitleText = "Don't Worry!";
                popup.TitleColor = Color.Chocolate;
                popup.TitleFont = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                popup.ContentFont = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                popup.BodyColor = Color.DeepSkyBlue;
                popup.ContentText = "Emergency on the way";
                popup.Popup();
                Email.Text = "" ; Building.Text = ""; 
            }
        }

        private void EmergencyForm_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmergencyForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
