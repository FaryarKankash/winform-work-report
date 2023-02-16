using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using System.Data.SQLite;
using System.Windows.Controls;

namespace VpnWinform
{
    public partial class Form1 : MaterialForm
    {

        readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public Form1()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            //config light and dark theme
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //config colors
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(
                MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700,
                MaterialSkin.Primary.Indigo100,
                MaterialSkin.Accent.Blue400, MaterialSkin.TextShade.WHITE);
        }

        //set privates
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private SQLiteDataAdapter DBR;
        private SQLiteDataAdapter DBPN;
        private DataSet DS = new DataSet();
        private DataSet DSR = new DataSet();
        private DataSet DSPN = new DataSet();
        private DataTable DTR = new DataTable();
        private DataTable DT = new DataTable();

        //make connection
        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=db.db;Version=3;New=False;Compress=True;");
        }

        //set ExecuteQuery
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        //set load DB
        //todo For each table i use seprate DS, DB and DT it's not a good thing!
        private void LoadDataProject()
        {
            DS.Reset();
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string commandText = "select * from Project";
            DB = new SQLiteDataAdapter(commandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            Project_List.DataSource = DT;
            sql_con.Close();
        }

        private void LoadDataReport()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string commandText = "select * from Report";
            DBR = new SQLiteDataAdapter(commandText, sql_con);
            DSR.Reset();
            DBR.Fill(DSR);
            DTR = DSR.Tables[0];
            Report_List.DataSource = DTR;
            sql_con.Close();
        }

        private void GetProjectNames()
        {
            string data = "Ok";
            int indexOfYourColumn = 1;
            Work_Project_Name_TextBox.Items.Clear();
            foreach (DataGridViewRow row in Project_List.Rows)
            {
                data = (string)row.Cells[indexOfYourColumn].Value;
                if (data != null)
                {
                    Work_Project_Name_TextBox.Items.Add(data);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load data
            LoadDataProject();
            LoadDataReport();
            //load drop box value
            GetProjectNames();
        }

        private void Project_Submit_Btn_Click(object sender, EventArgs e)
        {
            if(Project_Name_TextBox.Text.Length >0 && Project_Deadline_TextBox.Text.Length > 0) {
                string txtQuery = "insert into Project (Name, Deadline, Description)values('" + Project_Name_TextBox.Text + "','" + Project_Deadline_TextBox.Text + "','" + Project_Description_TextBox.Text + "')";
                ExecuteQuery(txtQuery);
                LoadDataProject();
                GetProjectNames();
            } else
            {
                MessageBox.Show("Name or Deadline is empty");
            }

        }

        private void Report_Submit_Btn_Click(object sender, EventArgs e)
        {
            if (Report_Date_Textbox.Text.Length > 0 && Report_Time_Textbox.Text.Length > 0 && Work_Project_Name_TextBox.Text.Length > 0)
            {
                string txtQuery = "insert into Report (Work_Time, Report_Date, Project_name, Description)values('" + Int32.Parse(Report_Time_Textbox.Text) + "','" + Report_Date_Textbox.Text + "','" + Work_Project_Name_TextBox.Text + "','" + Report_Description_Textbox.Text + "')";
                ExecuteQuery(txtQuery);
                LoadDataReport();
            }
            else
            {
                MessageBox.Show("Time, Date or Deadline is empty!");
            }
        }

        private void Delete_Report_Btn_Click(object sender, EventArgs e)
        {
            if(Report_List.SelectedRows.Count > 0)
            {
                string txtQuery = "delete from Report where Id='" + Report_List.SelectedRows[0].Cells[0].Value + "'";
                ExecuteQuery(txtQuery);
                LoadDataReport();
            } else
            {
                MessageBox.Show("Row is not selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if(Project_List.SelectedRows.Count > 0)
            {
                string txtQuery = "delete from Project where Id='" + Project_List.SelectedRows[0].Cells[0].Value + "'";
                ExecuteQuery(txtQuery);
                LoadDataProject();
                GetProjectNames();
            } else
            {
                MessageBox.Show("Row is not selected!","Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
