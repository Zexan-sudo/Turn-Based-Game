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
    public partial class frmBattleForm : Form
    {
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public frmBattleForm()
        {
            InitializeComponent();
            player.SoundLocation = "chikasong.wav";
        }
        string[] strMovesList = { "Wombo Combo", "Round House Kick", "Trebuchet Toss", "Rubber Chicken" };
        int[] intMovePowers = { 15, 25, 30, 10 };
        int[] intManaCost = { 3, 5, 7, 2 };
        int intHealth = 100;
        int intEnemyHealth = 100;
        int intMana = 20;
        int intEnemyMana = 20;
        Image enemyImage = Properties.Resources.EnemyImage;
        Random random = new Random();
        Form frmInventoryForm = new frmInventory();
        EnemyInventory enemyInventory = new EnemyInventory();

        /// <summary>
        /// loads the form frmBattleForm and initiates the game with default health, mana, and inventory values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmBattleForm_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "You've run into a CHIKA! \nPick a move and click SELECT before she destroys Za Worldo";

            player.Play();

            txtHealth.Text = intHealth.ToString();
            txtHealth.BackColor = Color.White;
            txtHealth.ForeColor = Color.Green;
            txtHealth.ReadOnly = true;

            txtMana.Text = intMana.ToString();
            txtMana.BackColor = Color.White;
            txtMana.ForeColor = Color.Blue;
            txtMana.ReadOnly = true;

            txtEnemyHealth.Text = intEnemyHealth.ToString();
            txtEnemyHealth.BackColor = Color.White;
            txtEnemyHealth.ForeColor = Color.Green;
            txtEnemyHealth.ReadOnly = true;

            txtEnemyMana.Text = intEnemyMana.ToString();
            txtEnemyMana.BackColor = Color.White;
            txtEnemyMana.ForeColor = Color.Blue;
            txtEnemyMana.ReadOnly = true;

            pcbEnemyPicture.Image = enemyImage;

            lstMoves.Items.Clear();
            for (int i = 0; i < strMovesList.Length; i++)
            {
                lstMoves.Items.Add(strMovesList[i] + "\t Power: " + intMovePowers[i] + "       Mana: " + intManaCost[i]);
            }
        }

        /// <summary>
        /// event handler for the select button. Executes the move selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelect_Click(object sender, EventArgs e)
        {

            int intSelectedMove = lstMoves.SelectedIndex;
            if (intSelectedMove == -1)
            {
                MessageBox.Show("Select a move before CHIKA yeets you to the Shadow Dimension.", "Select A Move.");
            }
            else if (intSelectedMove != -1)
            {
                if (intMana <= 1)
                {
                    EndGame("enemy");
                }
                else if (ManaCheck(intManaCost[intSelectedMove], intMana) == false)
                {
                    MessageBox.Show("Not enough mana!", "Not Enough Mana");
                }

                else if (ManaCheck(intManaCost[intSelectedMove], intMana) == true)
                {

                    if (HealthCheck(intMovePowers[intSelectedMove], intEnemyHealth) == false)
                    {
                        intEnemyHealth = 0;
                        txtEnemyHealth.Text = intEnemyHealth.ToString();
                        EndGame("player");
                    }
                    if (HealthCheck(intMovePowers[intSelectedMove], intEnemyHealth))
                    {
                        intEnemyHealth -= intMovePowers[intSelectedMove];
                        intMana -= intManaCost[intSelectedMove];
                        txtEnemyHealth.Text = intEnemyHealth.ToString();
                        txtMana.Text = intMana.ToString();
                        EnemyTurn();
                    }

                }

            }


        }

        /// <summary>
        /// executes the enemies move.
        /// TODO: 
        /// Very certain this can be reworked to be cleaner
        /// </summary>
        private void EnemyTurn()
        {
            bool counter = true;
            bool moveAttempt0 = false;
            bool moveAttempt1 = false;
            bool moveAttempt2 = false;
            bool moveAttempt3 = false;
            bool moveAttempt4 = false;
            string strEnemyItem = enemyInventory.RandomItem();
            while (counter == true)
            {
                int intEnemyMove = random.Next(5);
                if (intEnemyMana <= 1)
                {
                    EndGame("player");
                }

                if(intEnemyHealth <= 10)
                {
                    intEnemyMove = 4;
                    strEnemyItem = "potion";
                }

                if(intEnemyMana <= 5)
                {
                    intEnemyMove = 4;
                    strEnemyItem = "elixir";
                }

                if (intEnemyMove == 0)
                {

                    if (ManaCheck(intManaCost[intEnemyMove], intEnemyMana) == false)
                    {
                        moveAttempt0 = true;
                        continue;
                    }
                    if (ManaCheck(intManaCost[intEnemyMove], intEnemyMana) == true)
                    {
                        if (HealthCheck(intMovePowers[intEnemyMove], intHealth) == false)
                        {
                            EnemyWins();
                        }
                        if (HealthCheck(intMovePowers[intEnemyMove], intHealth) == true)
                        {
                            EnemyMove(intEnemyMove);
                            counter = false;
                            break;
                        }
                    }
                }

                if (intEnemyMove == 1)
                {

                    if (ManaCheck(intManaCost[intEnemyMove], intEnemyMana) == false)
                    {
                        moveAttempt1 = true;
                        continue;
                    }
                    if (ManaCheck(intManaCost[intEnemyMove], intEnemyMana) == true)
                    {
                        if (HealthCheck(intMovePowers[intEnemyMove], intHealth) == false)
                        {
                            EnemyWins();
                        }
                        if (HealthCheck(intMovePowers[intEnemyMove], intHealth) == true)
                        {
                            EnemyMove(intEnemyMove);
                            counter = false;
                            break;
                        }
                    }
                }

                if (intEnemyMove == 2)
                {

                    if (ManaCheck(intManaCost[intEnemyMove], intEnemyMana) == false)
                    {
                        moveAttempt2 = true;
                        continue;
                    }
                    if (ManaCheck(intManaCost[intEnemyMove], intEnemyMana) == true)
                    {
                        if (HealthCheck(intMovePowers[intEnemyMove], intHealth) == false)
                        {
                            EnemyWins();
                        }
                        if (HealthCheck(intMovePowers[intEnemyMove], intHealth) == true)
                        {
                            EnemyMove(intEnemyMove);
                            counter = false;
                            break;
                        }
                    }
                }

                if (intEnemyMove == 3)
                {

                    if (ManaCheck(intManaCost[intEnemyMove], intEnemyMana) == false)
                    {
                        moveAttempt3 = true;
                        continue;
                    }
                    if (ManaCheck(intManaCost[intEnemyMove], intEnemyMana) == true)
                    {
                        if (HealthCheck(intMovePowers[intEnemyMove], intHealth) == false)
                        {
                            EnemyWins();
                        }
                        if (HealthCheck(intMovePowers[intEnemyMove], intHealth) == true)
                        {
                            EnemyMove(intEnemyMove);
                            counter = false;
                            break;
                        }
                    }
                }

                if(intEnemyMove == 4)
                {
                    
                    if(strEnemyItem == "nomoreitems")
                    {
                        moveAttempt4 = true;
                    }
                    if(strEnemyItem == "")
                    {
                        continue;
                    }
                    if(strEnemyItem.ToLower() == "potion")
                    {
                        intEnemyHealth += 20;
                        txtEnemyHealth.Text = intEnemyHealth.ToString();
                        lblEnemyMoveMessage.Text = "CHIKA used " + strEnemyItem;
                        break;
                    }
                    if(strEnemyItem.ToLower() == "bomb")
                    {
                        intHealth -= 10;
                        txtHealth.Text = intHealth.ToString();
                        lblEnemyMoveMessage.Text = "CHIKA used " + strEnemyItem;
                        break;
                    }
                    if(strEnemyItem.ToLower() == "elixir")
                    {
                        intEnemyMana += 10;
                        txtEnemyMana.Text = intEnemyMana.ToString();
                        lblEnemyMoveMessage.Text = "CHIKA used " + strEnemyItem;
                        break;
                    }
                }

                if (moveAttempt0 == true && moveAttempt1 == true && moveAttempt2 == true && moveAttempt3 == true && moveAttempt4 == true)
                {
                    EndGame("player");
                    break;
                }

            }

        }

        /// <summary>
        /// Closes the game
        /// </summary>
        /// <param name="name">The name of the player that won</param>
        private void EndGame(string name)
        {
            if (name.ToLower() == "player")
            {
                MessageBox.Show("Congratulations! You beat CHIKA before she destroyed the world!", "You Win!");
                this.Close();
            }
            if (name.ToLower() == "enemy")
            {
                MessageBox.Show("OH NO CHIKA beat you, now she is going to destroy the world!", "You lost,");
                this.Close();
            }
        }

        /// <summary>
        /// Checks if the player or CPUs mana is sufficient for the move selected
        /// </summary>
        /// <param name="intManaCost">The amount of mana to execute the move selected</param>
        /// <param name="intMana">The amount of mana avaliable</param>
        /// <returns></returns>
        private bool ManaCheck(int intManaCost, int intMana)
        {
            bool manaCheck;
            int intManaLeft = intMana - intManaCost;
            if (intManaLeft < 0)
            {
                manaCheck = false;
            }
            else
            {
                manaCheck = true;
            }
            return manaCheck;
        }

        /// <summary>
        /// checks if the player or CPUs health is above 0 and deducts the health infliced by the move attacked with
        /// </summary>
        /// <param name="intHealthCost">The amount of heath inflicted</param>
        /// <param name="intHealth">The amount of health avaliable</param>
        /// <returns></returns>
        private bool HealthCheck(int intHealthCost, int intHealth)
        {
            bool healthCheck;
            int intHealthLeft = intHealth - intHealthCost;
            if (intHealthLeft <= 0)
            {
                healthCheck = false;
            }
            else
            {
                healthCheck = true;
            }
            return healthCheck;
        }

        /// <summary>
        /// Recalculates enemies values based on enemies move
        /// </summary>
        /// <param name="intEnemyMove">The move the enemy selected</param>        
        private void EnemyMove(int intEnemyMove)
        {
            lblEnemyMoveMessage.Text = "CHIKA used " + strMovesList[intEnemyMove];
            intHealth -= intMovePowers[intEnemyMove];
            intEnemyMana -= intManaCost[intEnemyMove];
            txtHealth.Text = intHealth.ToString("");
            txtEnemyMana.Text = intEnemyMana.ToString();
        }

        /// <summary>
        /// Sets health to zero and executes EndGame with enemy as the winner
        /// </summary>
        private void EnemyWins()
        {
            intHealth = 0;
            txtHealth.Text = intHealth.ToString("");
            EndGame("enemy");
        }

        /// <summary>
        /// Event handler for the inventory button. Will pull up the frmInventory menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnInventory_Click(object sender, EventArgs e)
        {
            frmInventoryForm.ShowDialog();

            string strItem = frmInventoryForm.Tag.ToString();

            if (strItem.ToLower() == "potion")
            {
                intHealth += 20;
                txtHealth.Text = intHealth.ToString();
                EnemyTurn();
            }
            else if (strItem.ToLower() == "bomb")
            {
                intEnemyHealth -= 10;
                txtEnemyHealth.Text = intEnemyHealth.ToString();
                EnemyTurn();
            }
            else if (strItem.ToLower() == "elixir")
            {
                intMana += 10;
                txtMana.Text = intMana.ToString();
                EnemyTurn();
            }
        }

    }
}
