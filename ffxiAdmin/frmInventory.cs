using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Collections;
using System.Globalization;

namespace dspAdmin
{
    public partial class frmInventory : Form
    {
        public string chId = "";
        bool inStartup = true;
        MySqlConnection connection;
        MySqlConnection connection2, connection3, connection4;
        public frmInventory(string charID, string charName, MySqlConnection conn)
        {
            InitializeComponent();
            this.Text = "Inventory of: " + charName;
            connection = conn;
            connection2 = conn.Clone();
            connection3 = conn.Clone();
            connection2.Open();
            connection3.Open();
            chId=charID;
            // connection.Close();
            //  connection.Open();
            ArrayList tables = new ArrayList();
            tables.AddRange(new object[] {
                    "item_armor",
                    "item_basic",
                    "item_furnishing",
                    "item_usable",
                    "item_weapon"});
            int iTables = tables.Count;
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            inventoryItems colItems = new inventoryItems();
            string sqlCharItems = "select itemid, location, quantity, bazaar from char_inventory where charid=" + charID + ";";
            MySqlCommand myCmd = new MySqlCommand(sqlCharItems, connection);
            MySqlDataReader myReader = myCmd.ExecuteReader();

            while (myReader.Read())
            {
                inventoryItem iItem = new inventoryItem();
                iItem.id = Int32.Parse((myReader[0].ToString()), System.Globalization.NumberStyles.Integer);
                iItem.location = Int32.Parse((myReader[1].ToString()), System.Globalization.NumberStyles.Integer);
                //  iItem.item = (int)myReader[2];
                iItem.quantity = Int32.Parse((myReader[2].ToString()), System.Globalization.NumberStyles.Integer);
                if (myReader[3].ToString() == "1")
                    iItem.bazaar = true;
                else
                    iItem.bazaar = false;
                // myReader.Close();
                // myReader.Dispose();
                // Determine what the item is and get it's info.
                // There are 5 tables that hold item information
                // and we have to find the table and then get the info
                // item_armor, item_basic, item_furnishing, item_usable, item_weapon
                // We want itemID, name
                // I don't care about any other stats, characters can have stuff they can't equip or use, etc
                // 12/18/11 -- I'm feeling lazy and going to do this the hard way (try each table)
                string inventoryTable = "";
                int curtable = 0;
                if (iItem.id == 65535) // Gil is 65535
                {
                    iItem.description = "Gil";
                }
                else
                {

                    foreach (string iTable in tables)
                    {
                        string sqlInventoryItem = "select itemid from " + iTable + " where itemid=" + iItem.id + ";";
                        MySqlCommand myInventoryCmd = new MySqlCommand(sqlInventoryItem, connection2);

                        MySqlDataReader myInventoryReader = myInventoryCmd.ExecuteReader();
                        if (myInventoryReader.HasRows)
                        {
                            inventoryTable = iTable;
                            myInventoryReader.Close();
                            myInventoryReader.Dispose();
                            myInventoryCmd.Dispose();
                            break;
                        }
                        curtable++;
                        myInventoryReader.Close();
                        myInventoryReader.Dispose();
                        myInventoryCmd.Dispose();
                    }

                    // We found the table, now get the information
                    string sqlItemLookup = "";
                    switch (inventoryTable)
                    {
                        case "item_armor":
                            sqlItemLookup = "select name, level from item_armor where itemID=" + iItem.id + ";";
                            break;
                        case "item_basic":
                            sqlItemLookup = "select name from item_basic where itemID=" + iItem.id + ";";
                            break;
                        case "item_furnishing":
                            sqlItemLookup = "select name from item_furnishing where itemID=" + iItem.id + ";";
                            break;
                        case "item_usable":
                            sqlItemLookup = "select name from item_usable where itemID=" + iItem.id + ";";
                            break;
                        case "item_weapon":
                            sqlItemLookup = "select name from item_weapon where itemID=" + iItem.id + ";";
                            break;
                    }
                    MySqlCommand myItemCmd = new MySqlCommand(sqlItemLookup, connection3);
                    MySqlDataReader myItemReader = myItemCmd.ExecuteReader();
                    while (myItemReader.Read())
                    {
                        iItem.description = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myItemReader[0].ToString().Replace('_', ' '));
                    }
                    myItemReader.Close();
                    myItemReader.Dispose();
                    myItemCmd.Dispose();

                }
                colItems.add(iItem);
            }
            myReader.Close();
            myReader.Dispose();
            connection2.Close();
            connection3.Close();
            connection2.Dispose();
            connection3.Dispose();
            foreach (inventoryItem item in colItems)
            {
                dgvCharInventory.Rows.Add(false, item.id, item.description, item.location, item.quantity);
            }
            //connection2.Open();
            //MySqlCommand allItemsCmd = new MySqlCommand("Select name from item_armor, item_basic, item_furnishing, item_usable, item_weapon;", connection2);
            //MySqlDataReader myAllItemsReader = allItemsCmd.ExecuteReader();
            //ArrayList allItems = new ArrayList();
            //while (myAllItemsReader.Read())
            //{
            //    allItems.Add(myAllItemsReader["name"].ToString());
            //}
            //myAllItemsReader.Close();
            //myAllItemsReader.Dispose();
            //allItems.Sort();
            //foreach (string allitem in allItems)
            //{
            //    lbAllItems.Items.Add(allitem);
            //}
        }
        public class inventoryItem
        {
            public int id;
            public int location;
            public int item;
            public int quantity;
            public string description;
            // True=In Bazaar
            public bool bazaar;
            public string table;
        }
        public class inventoryItems : CollectionBase
        {
            public virtual void add(inventoryItem NewGameZone)
            {
                this.List.Add(NewGameZone);
            }
            public virtual inventoryItem this[int index]
            {
                get
                {
                    return (inventoryItem)this.List[index];
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAllItems.Items.Clear();
            possibleItems colPossibleItems = new possibleItems();
            string sqlItems = "";
            switch (cmbItemType.Text)
            {
                case "Armor":
                    sqlItems = "select itemid,name from item_armor order by name;";

                    break;
                case "Basic":
                    sqlItems = "select itemid,name from item_basic order by name;";

                    break;
                case "Furnishings":
                    sqlItems = "select itemid,name from item_furnishing order by name;";

                    break;
                case "Usable":
                    sqlItems = "select itemid,name from item_usable order by name;";

                    break;
                case "Weapons":
                    sqlItems = "select itemid,name from item_weapon order by name;";
                    break;
            }
            if (connection3.State == ConnectionState.Closed)
                connection3.Open();
            MySqlCommand myItemsCmd = new MySqlCommand(sqlItems, connection3);
            MySqlDataReader myItemReader = myItemsCmd.ExecuteReader();
            while (myItemReader.Read())
            {
                possibleItem pItem = new possibleItem();
                pItem.id = Int32.Parse((myItemReader[0].ToString()), System.Globalization.NumberStyles.Integer);
                pItem.description = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(myItemReader[1].ToString().Replace('_', ' '));
                colPossibleItems.add(pItem);

            }
            connection3.Close();
            foreach (possibleItem item in colPossibleItems)
            {
                lbAllItems.Items.Add(item.description);
            }




        }

        public class possibleItem
        {
            public int id;
            public string description;
        }
        public class possibleItems : CollectionBase
        {
            public virtual void add(possibleItem item)
            {
                this.List.Add(item);
            }
            public virtual possibleItem this[int index]
            {
                get
                {
                    return (possibleItem)this.List[index];
                }
            }
        }

        private void btnAddtoChar_Click(object sender, EventArgs e)
        {
            // Get list of what's selected
            // for each item
            // get the max slot number for that location
            // add it to the location and in quantity desired
            if (connection3.State == ConnectionState.Closed)
                connection3.Open();
            string sqlAddItem="";
            int itemLoc=0;
            if (radInventory.Checked)
            itemLoc=0;
            else if (radHouse.Checked)
                itemLoc=1;
            else if (radSafe.Checked)
                itemLoc=2;
            else if (radSatchel.Checked)
                itemLoc=3;
            //foreach (string selectedItem in lbAllItems.SelectedItems)
            //{

            //    sqlAddItem="insert into char_inventory values("+chId+","+itemLoc
        }

        private void dgvCharInventory_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
          //  MessageBox.Show(e.Exception.InnerException.ToString());
        }

        private void btnDeletefromChar_Click(object sender, EventArgs e)
        {

        }

        private void dgvCharInventory_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex==3)
            MessageBox.Show("Edit done");
        }
    }
}
