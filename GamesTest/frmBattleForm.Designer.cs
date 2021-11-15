namespace GamesTest
{
    partial class frmBattleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMoves = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtHealth = new System.Windows.Forms.TextBox();
            this.txtMana = new System.Windows.Forms.TextBox();
            this.pcbEnemyPicture = new System.Windows.Forms.PictureBox();
            this.txtEnemyHealth = new System.Windows.Forms.TextBox();
            this.txtEnemyMana = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblEnemyMoveMessage = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEnemyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lstMoves
            // 
            this.lstMoves.FormattingEnabled = true;
            this.lstMoves.Location = new System.Drawing.Point(12, 289);
            this.lstMoves.Name = "lstMoves";
            this.lstMoves.Size = new System.Drawing.Size(227, 108);
            this.lstMoves.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(12, 24);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(333, 29);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "message";
            // 
            // txtHealth
            // 
            this.txtHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHealth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHealth.Location = new System.Drawing.Point(288, 288);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(30, 20);
            this.txtHealth.TabIndex = 2;
            // 
            // txtMana
            // 
            this.txtMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMana.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMana.Location = new System.Drawing.Point(288, 314);
            this.txtMana.Name = "txtMana";
            this.txtMana.Size = new System.Drawing.Size(30, 20);
            this.txtMana.TabIndex = 3;
            // 
            // pcbEnemyPicture
            // 
            this.pcbEnemyPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbEnemyPicture.Location = new System.Drawing.Point(225, 76);
            this.pcbEnemyPicture.Name = "pcbEnemyPicture";
            this.pcbEnemyPicture.Size = new System.Drawing.Size(120, 120);
            this.pcbEnemyPicture.TabIndex = 4;
            this.pcbEnemyPicture.TabStop = false;
            // 
            // txtEnemyHealth
            // 
            this.txtEnemyHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnemyHealth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEnemyHealth.Location = new System.Drawing.Point(189, 150);
            this.txtEnemyHealth.Name = "txtEnemyHealth";
            this.txtEnemyHealth.Size = new System.Drawing.Size(30, 20);
            this.txtEnemyHealth.TabIndex = 5;
            // 
            // txtEnemyMana
            // 
            this.txtEnemyMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnemyMana.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEnemyMana.Location = new System.Drawing.Point(189, 176);
            this.txtEnemyMana.Name = "txtEnemyMana";
            this.txtEnemyMana.Size = new System.Drawing.Size(30, 20);
            this.txtEnemyMana.TabIndex = 6;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(245, 345);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 23);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "SELECT";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enemy Health:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enemy Mana:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Health:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mana:";
            // 
            // lblEnemyMoveMessage
            // 
            this.lblEnemyMoveMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEnemyMoveMessage.Location = new System.Drawing.Point(12, 76);
            this.lblEnemyMoveMessage.Name = "lblEnemyMoveMessage";
            this.lblEnemyMoveMessage.Size = new System.Drawing.Size(207, 39);
            this.lblEnemyMoveMessage.TabIndex = 12;
            // 
            // btnInventory
            // 
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.Location = new System.Drawing.Point(245, 374);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(100, 23);
            this.btnInventory.TabIndex = 13;
            this.btnInventory.Text = "INVENTORY";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.BtnInventory_Click);
            // 
            // frmBattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 404);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.lblEnemyMoveMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtEnemyMana);
            this.Controls.Add(this.txtEnemyHealth);
            this.Controls.Add(this.pcbEnemyPicture);
            this.Controls.Add(this.txtMana);
            this.Controls.Add(this.txtHealth);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lstMoves);
            this.Name = "frmBattleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Battle Form";
            this.Load += new System.EventHandler(this.FrmBattleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbEnemyPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMoves;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtHealth;
        private System.Windows.Forms.TextBox txtMana;
        private System.Windows.Forms.PictureBox pcbEnemyPicture;
        private System.Windows.Forms.TextBox txtEnemyHealth;
        private System.Windows.Forms.TextBox txtEnemyMana;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblEnemyMoveMessage;
        private System.Windows.Forms.Button btnInventory;
    }
}

