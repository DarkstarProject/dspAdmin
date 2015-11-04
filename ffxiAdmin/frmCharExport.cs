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

        private void chkEverything_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEverything.Checked)
            {
                foreach (Control c in groupBox1.Controls)
                {
                    CheckBox current = c as CheckBox;
                    current.Checked = true;
                }
            }
            else
            {
                foreach (Control c in groupBox1.Controls)
                {
                    CheckBox current = c as CheckBox;
                    current.Checked = false;
                }
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
                DataTable dtreader = reader.GetSchemaTable();
                while (reader.Read())
                {
                    data.Sections.AddSection(current.Name.Remove(0, 3));
                    int i = 0;
                    foreach (DataRow field in dtreader.Rows)
                    {
                        if ((string)field["ColumnName"] != "charid")
                        {
                            if (reader[i].GetType().Name == "Byte[]")
                                data[current.Name.Remove(0, 3)].AddKey((string)field["ColumnName"], Convert.ToBase64String((byte[])reader[i]));
                            else
                                data[current.Name.Remove(0, 3)].AddKey((string)field["ColumnName"], reader[i].ToString());
                        }
                        i++;
                    }
                }
                reader.Close();
            }
            saveFileDialog1.FileName = charName;
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                saveData.WriteFile(saveFileDialog1.FileName, data);
                MessageBox.Show("Data saved for " + charName);
            }
        }
    }
}
