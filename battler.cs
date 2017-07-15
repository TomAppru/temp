using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace battleTest
{
    public partial class battleWindow : Form
    {
        private Player player;
        private Panel[] actionPoints = new Panel[10];

        public battleWindow()
        {
            InitializeComponent();

            actionPoints[0] = ap1;
            actionPoints[1] = ap2;
            actionPoints[2] = ap3;
            actionPoints[3] = ap4;
            actionPoints[4] = ap5;
            actionPoints[5] = ap6;
            actionPoints[6] = ap7;
            actionPoints[7] = ap8;
            actionPoints[8] = ap9;
            actionPoints[9] = ap10;
        }

        private void populateComboBox()
        {
            //proc to move inventory items into combobox
            for (int i = 0; i < dgvInventory.RowCount; i++)
            {
                cmbItemToUse.Items.Add(dgvInventory.Rows[i].Cells[0].Value);
            }
            try
            {
                cmbItemToUse.SelectedIndex = 0;
            }
            catch (Exception)
            {
                //
            }
        }

        private void fillInventoryDataGrid(List<Inventory_Item> items)
        {
            List<object> rowToAdd = new List<object>();
            rowToAdd.Add("");
            rowToAdd.Add("");
            rowToAdd.Add("");

            foreach (Inventory_Item i in items)
            {
                rowToAdd[0] = i.item.itemName;
                rowToAdd[1] = i.itemAmount;
                rowToAdd[2] = i.item.ID;

                dgvInventory.Rows.Add(rowToAdd.ToArray());
            }

            populateComboBox();
        }

        private void setHealth(int HP)
        {
            player.currentHP = HP;
            lblHealth.Text = player.currentHP + " / " + player.maxHP;
            pbHealth.Maximum = player.maxHP;
            pbHealth.Value = HP;
        }

        private void btnUseItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            player = new Player();

            setHealth(player.maxHP);
            fillInventoryDataGrid(player.inventory);

            btnSave.Visible = true;
        }
    }
}
