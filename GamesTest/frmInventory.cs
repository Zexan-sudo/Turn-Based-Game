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

        /// <summary>
        /// loads the frmInventory menu so the player can select an item to use
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmInventory_Load(object sender, EventArgs e)
        {
            FillListBox();
        }

        /// <summary>
        /// Event handler for the cancel button. Will close the frmInventory menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Tag = "";
            this.Close();
        }

        /// <summary>
        /// Event handler for when an item is selected. Will use that item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Loads the items avaliable into the frmInventory listbox
        /// </summary>
        private void FillListBox()
        {
            lstItemsList.Items.Clear();

            for (int i = 0; i < strItemsList.Length; i++)
            {
                lstItemsList.Items.Add(strItemsList[i] + "\t" + intItemsQuantity[i]);
            }
        }

        /// <summary>
        /// Shows item descriptions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
