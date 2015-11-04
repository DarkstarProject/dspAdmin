using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using IniParser;
using System.IO;

namespace dspAdmin
{
    public partial class frmCharImport : Form
    {
        private MySqlConnection connection;
        private string charFile = "";
        IniParser.Model.IniData data = new IniParser.Model.IniData();

        public frmCharImport(string fileToOpen, MySqlConnection conn)
        {
            InitializeComponent();
            connection = conn;
            charFile = fileToOpen;
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            string query = "";
            query = "select max(charid) from chars";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            int result = (int)cmd.ExecuteScalar();
            foreach (Control c in groupBox1.Controls)
            {
                CheckBox current = c as CheckBox;
                if (current.Checked)
                {
                    string tName = current.Name.Remove(0, 3);
                    string columns = "";
                 //   foreach (IniParser.Model.KeyData keys in (IniParser.Model.SectionData)tName)
                  //  query = "insert into "+tName+" (charid,"+data[tName][]
                }

              //  query = "Select * from " + current.Name.Remove(0, 3) + " where charid =" + charid;
             //   MySqlCommand command = new MySqlCommand(query, connection);
            }
        }

        private void frmCharImport_Load(object sender, EventArgs e)
        {
            List<string> controls = new List<string>();
            foreach (Control c in groupBox1.Controls)
            {
                CheckBox current = c as CheckBox;
                controls.Add(c.Name.Remove(0, 3));
            }
            FileIniDataParser readFile = new FileIniDataParser();
            data = readFile.ReadFile(charFile);
            foreach (IniParser.Model.SectionData s in data.Sections)
            {
                if (controls.Contains(s.SectionName))
                {
                    CheckBox cb = (CheckBox)this.Controls.Find("chk" + s.SectionName, true)[0];
                    cb.Checked = true;
                }
            }
            lblCharName.Text = "Importing data for: " + System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(Path.GetFileName(charFile.Split('.')[0]));
            foreach (Control c in groupBox1.Controls)
            {
                CheckBox current = c as CheckBox;
                if (current.Checked != true)
                    current.Enabled = false;
            }
        }

        private void chkEverything_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEverything.Checked)
            {
                foreach (Control c in groupBox1.Controls)
                {
                    CheckBox current = c as CheckBox;
                    if (current.Enabled)
                        current.Checked = true;
                }

                }
            else
            {
                foreach (Control c in groupBox1.Controls)
                {
                    CheckBox current = c as CheckBox;
                    if (current.Enabled)
                        current.Checked = false;
                }
            }
        }
    }
}
