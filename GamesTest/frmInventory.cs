using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesTest
{
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        string[] strItemsList = { "Potion", "Bomb", "Elixir"};
        int[] intItemsQuantity = { 1, 2 , 1};

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            FillListBox();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            int intSelectedItem = lstItemsList.SelectedIndex;
            if (intItemsQuantity[intSelectedItem] != 0)
            {
                intItemsQuantity[intSelectedItem] -= 1;
                this.Tag = strItemsList[intSelectedItem];
                this.Close();
            }
            else
            {
                MessageBox.Show("You dont have any of " + strItemsList[intSelectedItem] + " left!", "Dont have that item.");
            }
        }

        private void FillListBox()
        {
            lstItemsList.Items.Clear();

            for (int i = 0; i < strItemsList.Length; i++)
            {
                lstItemsList.Items.Add(strItemsList[i] + "\t" + intItemsQuantity[i]);
            }
        }

        private void BtnInfo_Click(object sender, EventArgs e)
        {
            int intSelectedItem = lstItemsList.SelectedIndex;

            if(intSelectedItem == 0)
            {
                MessageBox.Show("Potion: \nAdds 20 health to the user.", "Potion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(intSelectedItem == 1)
            {
                MessageBox.Show("Bomb: \nDeals 10 damage to the enemy.", "Potion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(intSelectedItem == 2)
            {
                MessageBox.Show("Elixir: \nAdds 10 Mana to the user.", "Potion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
