﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;

using System.Collections;
using Microsoft.Win32;
using System.Net;
using System.Text.RegularExpressions;

namespace dspAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ArrayList jobs = new ArrayList();
            jobs.AddRange(new object[] {
                    "war",
                    "mnk",
                    "whm",
                    "blm",
                    "rdm",
                    "thf",
                    "pld",
                    "drk",
                    "bst",
                    "brd",
                    "rng",
                    "sam",
                    "nin",
                    "drg",
                    "smn",
                    "blu",
                    "cor",
                    "pup",
                    "dnc",
                    "sch",
                    "geo",
                    "run"});
        }
        public MySqlConnection conn, conn2, conn3, conn4;
        int mouseX = 0;
        int mouseY = 0;
        string selectedCharID = "";
        string selectedCharName = "";
        bool freezeSelection = false;
        bool connected = false;
        bool inStartup = true;
        private Image imgOffline = dspAdmin.Properties.Resources.imgOffline;
        private Image imgOnline = dspAdmin.Properties.Resources.imgOnline;
        IPHostEntry remoteIP;
        ListSortDirection lsDirection;

        public void getCharacterList()
        {
            DataGridViewColumn sortColumn = dgvCharacters.SortedColumn;
            if (sortColumn != null)
            if (sortColumn.Index >= 0)
            {
                switch (dgvCharacters.SortOrder)
                {
                    case SortOrder.Ascending:
                        lsDirection = ListSortDirection.Ascending;
                        break;

                    case SortOrder.Descending:
                        lsDirection = ListSortDirection.Descending;
                        break;

                    default:
                        lsDirection = ListSortDirection.Descending;
                        break;
                }
            }
            dgvCharacters.Rows.Clear();
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            conn2 = (MySqlConnection)conn.Clone();
            conn3 = (MySqlConnection)conn.Clone();
            conn4 = (MySqlConnection)conn.Clone();
            string myZoneQuery="";
                myZoneQuery = "Select zoneid,name from zone_settings;";
            
            MySqlCommand myZoneCmd = new MySqlCommand(myZoneQuery,conn);
            MySqlDataReader zoneReader = myZoneCmd.ExecuteReader();
            gameZones colGameZones=new gameZones();
            gameZone gZone;
            conn2.Open();
            conn3.Open();
            conn4.Open();
            while (zoneReader.Read())
            {
                gZone=new gameZone();
                int value;
                // If we're running DLX we have to convert it to an integer, they're stored as hex values, otherwise just suck it in
                    value = Int32.Parse((zoneReader["zoneid"].ToString()), System.Globalization.NumberStyles.Integer);
                
                gZone.id=value;
                gZone.zone = zoneReader["name"].ToString().Replace('_', ' ');
                colGameZones.add(gZone);
                
            }
            zoneReader.Close();
            zoneReader.Dispose();
            string myQuery = "";
            if (chkShowOnlineOnly.Checked)
                myQuery = "Select chars.charid,chars.accid,charname,pos_zone from chars inner join accounts_sessions on chars.charid=accounts_sessions.charid order by charid;";
            else
                myQuery = "Select charid,accid,charname,pos_zone from chars order by charid";
            MySqlCommand myCmd = new MySqlCommand(myQuery, conn);
            MySqlDataReader reader = myCmd.ExecuteReader();
            string foundZone="";
            Image listImg=null;
            int charcount=0;
            int charOnline=0;
            while (reader.Read())
            {
                foreach (gameZone gameZone in colGameZones)
                {
                    if (gameZone.id == (Convert.ToInt32(reader["pos_zone"].ToString())))
                    {
                        foundZone = gameZone.zone.Replace('_',' ');
                        break;
                    }
                }
                string myQuery2 = "select INET_NTOA(client_addr) from accounts_sessions where charid=" + reader["charid"] + ";";

                MySqlCommand myCmd2 = new MySqlCommand(myQuery2, conn2);
                string charIP = (string)myCmd2.ExecuteScalar();
                if (charIP != null)
                {
                    listImg = imgOnline;
                    charOnline++;
                }
                else
                    listImg = imgOffline;
                string myQuery3 = "select login from accounts where id=" + reader["accid"].ToString() + ";";
                MySqlCommand myCmd3 = new MySqlCommand(myQuery3, conn3);
                string result2 = (string)myCmd3.ExecuteScalar();
                string myQuery4 = "select timelastmodify from accounts where id=" + reader["accid"].ToString() + ";";
                MySqlCommand myCmd4 = new MySqlCommand(myQuery4, conn4);
                string result3 = Convert.ToString(myCmd4.ExecuteScalar());
                dgvCharacters.Rows.Add(listImg, reader["charid"].ToString(), result2, reader["charname"].ToString(), foundZone, charIP, result3);
                charcount++;
            }
            string query = "select count(distinct client_addr) from accounts_sessions;";
            MySqlCommand myCmd0 = new MySqlCommand(query, conn3);
            string distinctUsers = Convert.ToString(myCmd0.ExecuteScalar());
            reader.Close();
            conn2.Close();
            conn3.Close();
            conn4.Close();
            
            if (sortColumn != null)
                dgvCharacters.Sort(dgvCharacters.Columns[sortColumn.Index], lsDirection);
            tlstrNumbers.Text = "Total: " + charcount.ToString() + "   Characters Online: " + charOnline.ToString() + " Distinct: " + distinctUsers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "DSP Administrator v"+ System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString().Remove(5,2);
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software\\DSAdmin\\");
            if (regKey.GetValue("ServerName") != null)
                txtServerName.Text = regKey.GetValue("ServerName").ToString();
            if (regKey.GetValue("ServerUsername") != null)
                txtDBUname.Text = regKey.GetValue("ServerUsername").ToString();
            if (regKey.GetValue("ServerPassword") != null)
                txtDBPassword.Text = regKey.GetValue("ServerPassword").ToString();
            if (regKey.GetValue("ServerDatabase") != null)
                txtDB.Text = regKey.GetValue("ServerDatabase").ToString();
            if (regKey.GetValue("AutoConnect") != null)
            {
                string chkAuto = regKey.GetValue("AutoConnect").ToString();
                if (chkAuto == "1")
                    chkAutoConnect.Checked = true;
                else
                    chkAutoConnect.Checked = false;
            }
            if (regKey.GetValue("CharListRefresh")!=null)
                txtCharListRefreshValue.Text=regKey.GetValue("CharListRefresh").ToString();
            if (regKey.GetValue("CharListRefreshEnable") != null)
            {
                string chkRefreshvalue = regKey.GetValue("CharListRefreshEnable").ToString();
                if (chkRefreshvalue == "1")
                {
                    tmrRefreshCharList.Interval = Convert.ToInt32(txtCharListRefreshValue.Text.Trim()) * 1000;
                    tmrRefreshCharList.Enabled = true;
                    chkRefresh.Checked = true;
                }
            }
            if (regKey.GetValue("ShowOnlineOnly")!=null)
            {
                string chkOnlineONly = regKey.GetValue("ShowOnlineOnly").ToString();
                if (chkOnlineONly == "1")
                {
                    chkShowOnlineOnly.Checked = true;
                }
                else
                    chkShowOnlineOnly.Checked = false;
            }
            regKey.Close();
            if (chkAutoConnect.Checked)
                btnConnect_Click(null, null);
            inStartup = false;
        }

        public class gameZone
        {
            public int id;
            public string zone;
        }
        public class gameZones : CollectionBase
        {
            public virtual void add(gameZone NewGameZone)
            {
                this.List.Add(NewGameZone);
            }
            public virtual gameZone this[int index]
            {
                get
                {
                    return (gameZone)this.List[index];
                }
            }
        }

        private void dgvCharacters_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
            Point pt = new Point(mouseX, mouseY);
            DataGridView.HitTestInfo hitInfo = dgvCharacters.HitTest(mouseX, mouseY);
            if (hitInfo.Type == DataGridViewHitTestType.Cell)
            {
                freezeSelection = true;
                dgvCharacters.CurrentCell = dgvCharacters.Rows[hitInfo.RowIndex].Cells[0];
                contextMenuStrip1.Show(dgvCharacters, e.Location);
            }
            }
        }

        private void dgvCharacters_MouseHover(object sender, EventArgs e)
        {
            if (!freezeSelection)
            {
                Point pt = new Point(mouseX, mouseY);
                DataGridView.HitTestInfo hitInfo = dgvCharacters.HitTest(mouseX, mouseY);
                if (hitInfo.Type == DataGridViewHitTestType.Cell)
                {
                    string charIP = "";
                    if (dgvCharacters.Rows[hitInfo.RowIndex].Cells[5].Value != null)
                        charIP = dgvCharacters.Rows[hitInfo.RowIndex].Cells[5].Value.ToString();
                    if (charIP != null)
                    {
                        try
                        {
                            remoteIP = Dns.GetHostEntry(charIP);
                        }
                        catch { }
                        if (remoteIP.AddressList.Count() > 0)
                            toolTip1.SetToolTip(dgvCharacters, remoteIP.AddressList[0].ToString());
                    }
                }
            }
        }

        private void dgvCharacters_MouseMove(object sender, MouseEventArgs e)
        {
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void toolJobsExp_Click(object sender, EventArgs e)
        {
            selectedCharID = dgvCharacters.CurrentRow.Cells[1].Value.ToString();
            selectedCharName = dgvCharacters.CurrentRow.Cells[3].Value.ToString();
           // MessageBox.Show("Character ID is: " + selectedCharID+ "Name is: "+selectedCharName);
            freezeSelection = false;
            frmJobsExp form2 = new frmJobsExp(selectedCharID, selectedCharName, conn);
            form2.Show();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                if (testServerConnection())
                {
                    RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software\\DSAdmin\\");
                    regKey.SetValue("ServerName", txtServerName.Text);
                    regKey.SetValue("ServerUsername", txtDBUname.Text);
                    regKey.SetValue("ServerPassword", txtDBPassword.Text);
                    regKey.SetValue("ServerDatabase", txtDB.Text);
                    regKey.Close();
                    tlstrConnected.ForeColor = Color.Green;
                    tlstrConnected.Visible = true;
                    tlstrConnected.Text = "Connected to: " + txtServerName.Text + "  ";
                    chkAutoConnect.Enabled = true;
                    createMySQLConnection();
                    getCharacterList();
                    connected = true;
                    btnConnect.Text = "Disconnect";
                }
                else
                {
                    txtServerName.Focus();
                }
            }
            else
            {
                conn.Close();
                tlstrConnected.ForeColor = Color.Red;
                tlstrConnected.Visible = true;
                tlstrConnected.Text = "Disconnected";
                connected = false;
                dgvCharacters.Rows.Clear();
                btnConnect.Text = "Connect";
            }
        }
        private bool testServerConnection()
        {
            bool iFailed = false;
            if (txtServerName.Text == "" | txtDB.Text == "" | txtDBUname.Text == "" | txtDBPassword.Text == "")
                return false;
            MySqlConnection connectionTest = new MySqlConnection("server = " + txtServerName.Text + ";Database=" + txtDB.Text + ";Persist Security Info=true;User id='" + txtDBUname.Text + "';Password='" + txtDBPassword.Text + "';Convert Zero Datetime=True;pooling=false");
            try
            {
                connectionTest.Open();
            }
            catch (Exception mysqlexception)
            {
                MessageBox.Show("Connection to the server failed, check your inputs\n" + mysqlexception, "Connection test error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                iFailed = true;
            }
            if (iFailed)
            {
                connectionTest.Close();
                return false;
            }
            connectionTest.Close();
            return true;
        }
        private void createMySQLConnection()
        {
            string connection = "server = " + txtServerName.Text + ";Database=" + txtDB.Text + ";Persist Security Info=true;User id='" + txtDBUname.Text + "';Password='" + txtDBPassword.Text + "';Convert Zero Datetime=True;pooling=false";
            conn = new MySqlConnection(connection);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (connected)
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 1:
                        lstMonsters.Items.Clear();
                        ArrayList monsters = new ArrayList();
                        //conn.Open();
                        if (conn.State == ConnectionState.Closed)
                            conn.Open();
                        string myMonsterQuery = "Select name from mob_pools;";
                        MySqlCommand myMonsterCmd = new MySqlCommand(myMonsterQuery, conn);
                        MySqlDataReader monsterReader = myMonsterCmd.ExecuteReader();
                        while (monsterReader.Read())
                        {
                            monsters.Add(monsterReader["name"].ToString());
                        }
                        conn.Close();
                        monsterReader.Close();
                        monsterReader.Dispose();
                        monsters.Sort();
                        foreach (string monster in monsters)
                            lstMonsters.Items.Add(monster);
                        break;
                    case 2:
                        refreshChat();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                if (tabControl1.SelectedIndex != 3)
                {
                    MessageBox.Show("Connect to a database first!", "Not Connected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabControl1.SelectedIndex = 3;
                }
            }
        }

        private void refreshChat()
        {
            string chatQuery = "";
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            if (txtCharListRefreshValue.Text != null)
                chatQuery = "select type, lsname, speaker, recipient, CONVERT(message using utf8), datetime from audit_chat order by datetime desc limit " + txtShowMessages.Text + ";";
            else
            {
                MessageBox.Show("Please enter a valid value for the number of messages displayed");
                tmrRefreshChat.Stop();
                chkRefresh.CheckState = CheckState.Unchecked;
                return;
            }
            MySqlCommand myChatCmd = new MySqlCommand(chatQuery, conn);
            MySqlDataReader chatReader = myChatCmd.ExecuteReader();
            dgChat.Rows.Clear();
            while (chatReader.Read())
            {
                dgChat.Rows.Add(chatReader[0], chatReader[1], chatReader[2], chatReader[3], chatReader[4], chatReader[5]);
            }
            chatReader.Close();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            lstMonsters.SelectedIndex = lstMonsters.FindString(txtFilter.Text);
        }

        private void lstMonsters_DoubleClick(object sender, EventArgs e)
        {
            grpMonsterDrop.Text = lstMonsters.SelectedItem.ToString();
           // string monsterDrops= "Select poolid.pool_mobs2,poolid.spawn_grouptopool,spawn_grouptopool.dropid
        }



        private void toolInventory_Click(object sender, EventArgs e)
        {
            selectedCharID = dgvCharacters.CurrentRow.Cells[1].Value.ToString();
            selectedCharName = dgvCharacters.CurrentRow.Cells[3].Value.ToString();
            frmInventory formInventory = new frmInventory(selectedCharID, selectedCharName, conn);
            formInventory.Show();
        }

        private void chkAutoConnect_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software\\DSAdmin\\");
            if (chkAutoConnect.Checked == true)
                regKey.SetValue("AutoConnect", "1");
            else
                regKey.SetValue("AutoConnect", "0");
            regKey.Close();
        }

        private void tmrRefreshCharList_Tick(object sender, EventArgs e)
        {
            getCharacterList();
        }

        private void chkRefresh_CheckedChanged(object sender, EventArgs e)
        {
            RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software\\DSAdmin\\");
            regKey.SetValue("CharListRefresh",txtCharListRefreshValue.Text.Trim());
            
            
            if (chkRefresh.Checked == true)
            {
                tmrRefreshCharList.Interval = Convert.ToInt32(txtCharListRefreshValue.Text.Trim()) * 1000;
                tmrRefreshCharList.Enabled = true;
                tlstrTimer.Text = "Refresh timer on";
                tlstrTimer.ForeColor = Color.Green;
                tlstrTimer.Visible = true;
                regKey.SetValue("CharListRefreshEnable", "1");
            }
            else
            {
                tmrRefreshCharList.Enabled = false;
                tlstrTimer.Text = "Refresh timer off";
                tlstrTimer.ForeColor = Color.Red;
                tlstrTimer.Visible = true;
                regKey.SetValue("CharListRefreshEnable", "0");
            }
            regKey.Close();
        }

        private void txtCharListRefreshValue_TextChanged(object sender, EventArgs e)
        {
            chkRefresh_CheckedChanged(null, null);
        }

        private void dgvCharacters_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (!freezeSelection)
            {
            
                if (e.ColumnIndex == 5 & e.RowIndex > 1)
                {
                    if (dgvCharacters.Rows[e.RowIndex].Cells[5].Value != null)
                    {
                        string charIP = dgvCharacters.Rows[e.RowIndex].Cells[5].Value.ToString();
                        if (charIP != null)
                        {
                            IPHostEntry remoteIP = Dns.GetHostEntry(charIP);
                            if (remoteIP != null)
                                toolTip1.Show(remoteIP.HostName, this, mouseX, mouseY, 5000);
                       //     toolTip1.SetToolTip(dgvCharacters, remoteIP.AddressList[0].ToString());
                        }
                    }
                }
            }
        }

        private void tmrRefreshChat_Tick(object sender, EventArgs e)
        {
            refreshChat();
        }

        private void toolExportChar_Click(object sender, EventArgs e)
        {
            selectedCharID = dgvCharacters.CurrentRow.Cells[1].Value.ToString();
            selectedCharName = dgvCharacters.CurrentRow.Cells[3].Value.ToString();
            frmCharExport frmCharExport = new frmCharExport(selectedCharID, selectedCharName, conn);
            frmCharExport.Show();
        }

        private void charImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                frmCharImport frmChrImport = new frmCharImport(openFileDialog1.FileName, conn);
                frmChrImport.Show();
            }
        }

        private void chkShowOnlineOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (!inStartup)
            {
                RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software\\DSAdmin\\");
                if (chkShowOnlineOnly.Checked)
                {
                    regKey.SetValue("ShowOnlineOnly", "1");
                    getCharacterList();
                }
                else
                {
                    regKey.SetValue("ShowOnlineOnly", "0");
                    getCharacterList();
                }
                regKey.Close();
            }
        }

        private void cbChatRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (cbChatRefresh.Checked)
                tmrRefreshChat.Start();
            else
                tmrRefreshChat.Stop();
        }

        private void btnChatRefresh_Click(object sender, EventArgs e)
        {
            refreshChat();
        }

        private void txtShowMessages_TextChanged(object sender, EventArgs e)
        {
           // refreshChat();
        }



    }
}
