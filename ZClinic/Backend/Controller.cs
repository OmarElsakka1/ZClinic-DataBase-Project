using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace ZClinic
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();

        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        public object Get_Password(string Email)
        {

            string StoredProcedureName = StoredProcedures.Get_Password;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Email", Email);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int IsUserExist(string Email)   /// 1 is true , 0 is false
        {
            string StoredProcedureName = StoredProcedures.IsUserExist;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Email", Email);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertUser(string NationalID, string pnumber, string Type, string Password, string Email, string Name, Char Sex, string A1, string A2,string Image)
        {
            //ControllerObj.signupdata(NationalIDtextBox.Text, PhonenumbertextBox.Text, TypecomboBox.Text, PassowrdtextBox.Text, E_mailtextBox.Text, NametextBox.Text, A1_textBox, A2_textBox);
            string StoredProcedureName = StoredProcedures.InsertUser;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NationalID);
            Parameters.Add("@Pnumber", pnumber);
            Parameters.Add("@Type", Type);
            Parameters.Add("@Password", Password);
            Parameters.Add("@Email", Email);
            Parameters.Add("@Name", Name);
            Parameters.Add("@A1", A1);
            Parameters.Add("@A2", A2);
            Parameters.Add("@Sex", Sex);
            Parameters.Add("@Image", Image);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Insert_Medical_info(string BloodType, string Bdate, string Height, string Weights, string NationalID, string Notes)
        {
            string StoredProcedureName = StoredProcedures.Insert_Medical_info;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BloodType", BloodType);
            Parameters.Add("@Bdate", Bdate);
            Parameters.Add("@Height", Height);
            Parameters.Add("@Weights", Weights);
            Parameters.Add("@NID", NationalID);
            Parameters.Add("@Notes", Notes);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int Insert_Medical_infoNULL(string BloodType, string Bdate, string Height, string Weights, string NationalID)
        {
            string StoredProcedureName = StoredProcedures.Insert_Medical_infoNULL;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BloodType", BloodType);
            Parameters.Add("@Bdate", Bdate);
            Parameters.Add("@Height", Height);
            Parameters.Add("@Weights", Weights);
            Parameters.Add("@NID", NationalID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int Insert_Drug_Data(string DrugName, double Price, int Available, int Needed, string ImageLocation, string Description)
        {
            string StoredProcedureName = StoredProcedures.Insert_Drug_Data;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DrugName", DrugName);
            Parameters.Add("@Price", Price);
            Parameters.Add("@Available", Available);
            Parameters.Add("@Needed", Needed);
            Parameters.Add("@ImageLocation", ImageLocation);
            Parameters.Add("@Descriptions", Description);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Insert_Chronic_Disease(string Disease, string NationalID)
        {
            string StoredProcedureName = StoredProcedures.Insert_Chronic_Disease;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Disease", Disease);
            Parameters.Add("@NID", NationalID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Request_Drugs(string NationalID, string DrugName, Int32 Number)  // for requesting database
        {
            string StoredProcedureName = StoredProcedures.Request_Drugs;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NationalID);
            Parameters.Add("@Names", DrugName);
            Parameters.Add("@NUMBER", Number);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable SelectDrugsData()//for filling the scroll page
        {
            string StoredProcedureName = StoredProcedures.SelectDrugsData;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetAllDrugs() // for getting all names from database
        {
            string StoredProcedureName = StoredProcedures.GetAllDrugs;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetAllMedicalExcuses()//for filling the scroll page
        {
            string StoredProcedureName = StoredProcedures.GetAllMedicalExcuses;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetAllAcceptedMedicalExcusesPerUSer()
        {
            string StoredProcedureName = StoredProcedures.GetAllAcceptedMedicalExcusesPerUSer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetAllPendingMedicalExcusesPerUSer()
        {

            string StoredProcedureName = StoredProcedures.GetAllPendingMedicalExcusesPerUSer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetAllDeclinedMedicalExcusesPerUSer()
        {
            string StoredProcedureName = StoredProcedures.GetAllDeclinedMedicalExcusesPerUSer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetAllNullMedicalExcuses()//for filling the scroll page
        {
            string StoredProcedureName = StoredProcedures.GetAllNullMedicalExcuses;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable FillSupportIT()
        {
            string StoredProcedureName = StoredProcedures.FillSupportIT;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable FillRevisedSupportIT()
        {
            string StoredProcedureName = StoredProcedures.FillRevisedSupportIT;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int Edit_Profile(string NationalID, string Name, string Email, string Pnumber)  // for requesting database
        {
            string StoredProcedureName = StoredProcedures.Edit_Profile;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NationalID);
            Parameters.Add("@Names", Name);
            Parameters.Add("@Email", Email);
            Parameters.Add("@Pnumber", Pnumber);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public object Get_NationalID(string Email) // would be used form the login form till the log out
        {

            string StoredProcedureName = StoredProcedures.Get_NationalID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Email", Email);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object Get_Email_From_NationalID(string National_ID) // would be used form the login form till the log out
        {

            string StoredProcedureName = StoredProcedures.Get_Email_From_NationalID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", National_ID);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object GetIDUsingPhotoName(string imageloc)
        {
            string StoredProcedureName = StoredProcedures.GetIDUsingPhotoName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ImageName", imageloc);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int UpdatePassword(string NationalID, string NewPass)  // for requesting database
        {
            
            string StoredProcedureName = StoredProcedures.UpdatePassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NationalID);
            Parameters.Add("@password", NewPass);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int Set_Rating(string NationalID, int rating)  // for requesting database
        {
            string StoredProcedureName = StoredProcedures.Set_Rating;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NationalID);
            Parameters.Add("@rating", rating);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int SetRevisedSupportIT(string NationalID, string comment)
        {
            string StoredProcedureName = StoredProcedures.SetRevisedSupportIT;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NationalID);
            Parameters.Add("@Comment", comment);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int SetUNRevisedSupportIT(string NationalID, string comment)
        {
            string StoredProcedureName = StoredProcedures.SetUNRevisedSupportIT;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NationalID);
            Parameters.Add("@Comment", comment);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int DeleteSupportIT(string NationalID, string comment)
        {
            string StoredProcedureName = StoredProcedures.DeleteSupportIT;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NationalID);
            Parameters.Add("@Comment", comment);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public object Get_Type(string Email)
        {
            string StoredProcedureName = StoredProcedures.Get_Type;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Email", Email);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        public int ExcuseUpdate(string NationalID, bool state, string Date)
        {
            string StoredProcedureName = StoredProcedures.ExcuseUpdate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NationalID);
            Parameters.Add("@state", state);
            Parameters.Add("@Date", Date);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateUserState(string email)
        {
            string StoredProcedureName = StoredProcedures.UpdateUserState;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Email", email);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int  UpdateUserStateDec(string email)
        {
            string StoredProcedureName = StoredProcedures.UpdateUserStateDec;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Email", email);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int SET_STUDENT(string ID, string DepartmentName, string NationalID)  // for requesting database
        {
            string StoredProcedureName = StoredProcedures.SET_STUDENT;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", ID);
            Parameters.Add("@DName", DepartmentName);
            Parameters.Add("@National_ID", NationalID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetAnswers(string Email)//for filling the scroll page
        {
            string StoredProcedureName = StoredProcedures.GetAnswers;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Email", Email);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int Insert_Doctor(string NationalID, string Specialization)  // for requesting database
        {
            string StoredProcedureName = StoredProcedures.Insert_Doctor;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NationalID);
            Parameters.Add("@Specialization", Specialization);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertExcuse(string SD, string ED, string S1, string S2, string S3, string S4, string DL, string Com, string NID)
        {
            string StoredProcedureName = StoredProcedures.InsertExcuse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SD", SD);
            Parameters.Add("@ED", ED);
            Parameters.Add("@S1", S1);
            Parameters.Add("@S2", S2);
            Parameters.Add("@S3", S3);
            Parameters.Add("@S4", S4);
            Parameters.Add("@DL", DL);
            Parameters.Add("@Com", Com);
            Parameters.Add("@NID", NID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertStudentExcuse(string SD, string ED, string S1, string S2, string S3, string S4, string DL, string Com, string NID,string TNID)
        {
            string StoredProcedureName = StoredProcedures.InsertStudentExcuse;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@SD", SD);
            Parameters.Add("@ED", ED);
            Parameters.Add("@S1", S1);
            Parameters.Add("@S2", S2);
            Parameters.Add("@S3", S3);
            Parameters.Add("@S4", S4);
            Parameters.Add("@DL", DL);
            Parameters.Add("@Com", Com);
            Parameters.Add("@NID", NID);
            Parameters.Add("@TANID", TNID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertSupport(string NID, string SD, string Comment)
        {
            string StoredProcedureName = StoredProcedures.InsertSupport;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NID);
            Parameters.Add("@SD", SD);
            Parameters.Add("@Comment", Comment);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable Hosptials_Data() // for getting all names from database
        {
            string StoredProcedureName = StoredProcedures.Hosptials_Data;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable Get_Issues()//for filling the scroll page
        {
            string StoredProcedureName = StoredProcedures.Get_Issues;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable Get_All_MyIssues(string NationalID)//for filling the scroll page
        {
            string StoredProcedureName = StoredProcedures.Get_All_MyIssues;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NationalID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable TeachingMedicalEcxcuses(string NationalID)
        {
            string StoredProcedureName = StoredProcedures.TeachingMedicalEcxcuses;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NID", NationalID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable FillAdmin()
        {
            string StoredProcedureName = StoredProcedures.FillAdmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public object GetNumPerSex_Branch(int year, char Sex) // would be used form the login form till the log out
        {
            
            string StoredProcedureName = StoredProcedures.GetNumPerSex_Branch;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@num", year);
            Parameters.Add("@Sex", Sex);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }
        //
        public object Get_Month() // would be used form the login form till the log out
        {

            string StoredProcedureName = StoredProcedures.Get_Month;
            return dbMan.ExecuteScalar(StoredProcedureName, null);
        }
        public int CheckUsersImage(string Image)
        {
            string StoredProcedureName = StoredProcedures.CheckUsersImage;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Image", Image);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int CheckMSuppliesImage(string Image)
        {
            string StoredProcedureName = StoredProcedures.CheckMSuppliesImage;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Image", Image);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

    }

}

