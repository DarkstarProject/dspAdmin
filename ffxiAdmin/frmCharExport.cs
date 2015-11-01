using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Collections;
using IniParser;


namespace dspAdmin
{
    public partial class frmCharExport : Form
    {
        private MySqlConnection connection;
        private string charName = "";
        private int charid = 0;

        public frmCharExport(string charID, string cName, MySqlConnection conn)
        {
            InitializeComponent();
            lblExportCharacter.Text = "Exporting Character: " + cName;
            connection = conn;
            charName = cName;
            charid = Convert.ToInt16(charID);
        }

         private void frmCharExport_Load(object sender, EventArgs e)
        {
            
        }

        private void chkEverything_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEverything.Checked)
            {
                chkChars.Checked = true;
                chkChar_merits.Checked = true;
                chkChar_equip.Checked = true;
                chkChar_exp.Checked = true;
                chkChar_inventory.Checked = true;
                chkChar_jobs.Checked = true;
                chkChar_look.Checked = true;
                chkChar_pet.Checked = true;
                chkChar_Pet_Name.Checked = true;
                chkChar_Points.Checked = true;
                chkChar_Profile.Checked = true;
                chkChar_Skills.Checked = true;
                chkChar_Spells.Checked = true;
                chkChar_Stats.Checked = true;
                chkChar_Storage.Checked = true;
                chkChar_Style.Checked = true;
                chkChar_Titles.Checked = true;
                chkChar_Vars.Checked = true;
                chkChar_weapon_skill_points.Checked = true;

            }
            else
            {
                chkChars.Checked = false;
                chkChar_merits.Checked = false;
                chkChar_equip.Checked = false;
                chkChar_exp.Checked = false;
                chkChar_inventory.Checked = false;
                chkChar_jobs.Checked = false;
                chkChar_look.Checked = false;
                chkChar_pet.Checked = false;
                chkChar_Pet_Name.Checked = false;
                chkChar_Points.Checked = false;
                chkChar_Profile.Checked = false;
                chkChar_Skills.Checked = false;
                chkChar_Spells.Checked = false;
                chkChar_Stats.Checked = false;
                chkChar_Storage.Checked = false;
                chkChar_Style.Checked = false;
                chkChar_Titles.Checked = false;
                chkChar_Vars.Checked = false;
                chkChar_weapon_skill_points.Checked = false;
            }


        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string query = "";
            FileIniDataParser saveData = new FileIniDataParser();
            IniParser.Model.IniData data = new IniParser.Model.IniData();
            foreach (Control c in groupBox1.Controls)
            {
                CheckBox current = c as CheckBox;
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                query = "Select * from " + current.Name.Remove(0, 3) + " where charid =" + charid;
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    data.Sections.AddSection(current.Name.Remove(0, 3));

                }
            }


        }


    }
}
