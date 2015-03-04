using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace dspAdmin
{
    public partial class frmJobsExp : Form
    {
        public string chId="";
        bool inStartup = true;
        MySqlConnection connection;
        public frmJobsExp(string charID, string charName, MySqlConnection conn)
        {
            InitializeComponent();
            inStartup = true;
            this.Text = "Editing: "+charName;
            chId=charID;
            connection = conn;
           
            ArrayList jobs = new ArrayList();
            connection.Close();
            connection.Open();
            string myQuery = "show columns from char_exp;";
            MySqlCommand myCmd = new MySqlCommand(myQuery, connection);
            MySqlDataReader myReader = myCmd.ExecuteReader();
            while (myReader.Read())
            {
                jobs.Add((myReader[0].ToString()).Replace("exp_","").ToUpper());
            }
            myReader.Close();
            jobs.RemoveAt(0);
            foreach (string job in jobs)
            {
                cmbJobs.Items.Add(job);
            }
            cmbJobs.Sorted = true;
            cmbJobs.Items.Insert(0, "_Select");
            cmbJobs.SelectedIndex = 0;
            myQuery = "select sjob from char_stats where charid=" + charID + ";";
            myCmd = new MySqlCommand(myQuery, connection);
            myReader = myCmd.ExecuteReader();
            while (myReader.Read())
            {
                if (myReader[0].ToString() == "1")
                    chkSJ.Checked = true;
                else
                    chkSJ.Checked = false;
            }
            myReader.Close();
            myQuery = "select nameflags from char_stats where charid=" + charID + ";";
            myCmd = new MySqlCommand(myQuery, connection);
            myReader = myCmd.ExecuteReader();
            while (myReader.Read())
            {
                switch (myReader[0].ToString())
                {
                    case "67108864":
                        radGM.Checked = true;
                        break;
                    case "83886080":
                        radGMSenior.Checked = true;
                        break;
                    case "100663296":
                        radGMLeader.Checked = true;
                        break;
                    case "117440512":
                        radSEProducer.Checked = true;
                        break;
                    default:
                        radGMnone.Checked = true;
                        break;
                }
            }
            connection.Close();
            inStartup = false;
        }

        private void cmbJobs_SelectedValueChanged(object sender, EventArgs e)
        {
            lblSaved.Visible = false;
            if (cmbJobs.Text == "_Select")
            {
                txtCharExp.Text = "";
                txtCharLevel.Text = "";
            }
            if (!inStartup & cmbJobs.Text!="_Select")
            {
                
                ArrayList jobs = new ArrayList();
                if (connection.State==ConnectionState.Closed)
                    connection.Open();
                string myQuery = "select char_jobs." + cmbJobs.Text.ToLower() + ",char_exp." + cmbJobs.Text.ToLower() + " from char_jobs inner join char_exp on char_jobs.charid=char_exp.charid where char_jobs.charid=" + chId + ";";
                //MessageBox.Show(myQuery);
                MySqlCommand myCmd = new MySqlCommand(myQuery, connection);
                MySqlDataReader myReader = myCmd.ExecuteReader();
                while (myReader.Read())
                {
                    txtCharLevel.Text = myReader[0].ToString();
                    txtCharExp.Text = myReader[1].ToString();
                }
                myReader.Close();
                connection.Close();
            }
        }

        private void chkSJ_CheckedChanged(object sender, EventArgs e)
        {
            //if (!inStartup)
            //{
            //    string setSJ = "0";
            //    if (chkSJ.Checked)
            //        setSJ = "1";
            //    if (connection.State == ConnectionState.Closed)
            //        connection.Open();
                    
            //    string myQuery = "update char_stats set sjob=" + setSJ + " where charid=" + chId + ";";
            //    MySqlCommand myCmd = new MySqlCommand(myQuery, connection);
            //    myCmd.ExecuteNonQuery();
            // //   connection.Close();
            //}
            lblSaved.Visible = false;
        }

        private void btnCharSubmit_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            bool updatedSomething = false;
            string setSJ = "0";
            string gmMode = "";
            if (chkSJ.Checked)
                setSJ = "1";
            else
                setSJ = "0";

            if (radGMnone.Checked)
                gmMode = "0";
            else if (radGM.Checked)
                gmMode = "67108864";
            else if (radGMLeader.Checked)
                gmMode = "100663296";
            else if (radGMSenior.Checked)
                gmMode = "83886080";
            else if (radSEProducer.Checked)
                gmMode = "117440512";
            if (gmMode != "")
            {
               string myQuery = "update char_stats set nameflags=" + gmMode + " where charid=" + chId + ";";
                MySqlCommand myCmd3 = new MySqlCommand(myQuery, connection);
                myCmd3.ExecuteNonQuery();
                updatedSomething = true;
            }
            if (cmbJobs.Text != "_Select")
            {
                string myQuery = "update char_jobs set " + cmbJobs.Text.ToLower() + "=" + txtCharLevel.Text + " where charid=" + chId + ";";
                MySqlCommand myCmd = new MySqlCommand(myQuery, connection);
                myCmd.ExecuteNonQuery();
                myQuery = "update char_exp set " + cmbJobs.Text.ToLower() + "=" + txtCharExp.Text + " where charid=" + chId + ";";
                myCmd = new MySqlCommand(myQuery, connection);
                myCmd.ExecuteNonQuery();
                myQuery = "update char_stats set sjob=" + setSJ + " where charid=" + chId + ";";
                MySqlCommand myCmd2 = new MySqlCommand(myQuery, connection);
                myCmd2.ExecuteNonQuery();
                updatedSomething = true;
                connection.Close();
                
            }
            if (updatedSomething)
            {
                lblSaved.ForeColor = Color.Green;
                lblSaved.Visible = true;
            }
        }

        private void radGMnone_CheckedChanged(object sender, EventArgs e)
        {
            lblSaved.Visible = false;
        }

        private void radGM_CheckedChanged(object sender, EventArgs e)
        {
            lblSaved.Visible = false;
        }

        private void radGMLeader_CheckedChanged(object sender, EventArgs e)
        {
            lblSaved.Visible = false;
        }

        private void radGMSenior_CheckedChanged(object sender, EventArgs e)
        {
            lblSaved.Visible = false;
        }

        private void radSEProducer_CheckedChanged(object sender, EventArgs e)
        {
            lblSaved.Visible = false;
        }

       

    }
}
