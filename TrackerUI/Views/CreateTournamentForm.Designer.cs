namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.tournamentNameValue = new System.Windows.Forms.TextBox();
            this.tournamentNameLabel = new System.Windows.Forms.Label();
            this.entryFeeLabel = new System.Windows.Forms.Label();
            this.entryFeeValue = new System.Windows.Forms.TextBox();
            this.selectTeamLabel = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.prizesListBox = new System.Windows.Forms.ListBox();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.deleteSelectedTournamentButton = new System.Windows.Forms.Button();
            this.addTeamButton = new System.Windows.Forms.Button();
            this.createPrizeButton = new System.Windows.Forms.Button();
            this.tournamentPlayersLable = new System.Windows.Forms.Label();
            this.prizesLabel = new System.Windows.Forms.Label();
            this.deleteSelectedPrizeButton = new System.Windows.Forms.Button();
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(317, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Create Tournament";
            // 
            // tournamentNameValue
            // 
            this.tournamentNameValue.Location = new System.Drawing.Point(48, 143);
            this.tournamentNameValue.Name = "tournamentNameValue";
            this.tournamentNameValue.Size = new System.Drawing.Size(270, 35);
            this.tournamentNameValue.TabIndex = 4;
            // 
            // tournamentNameLabel
            // 
            this.tournamentNameLabel.AutoSize = true;
            this.tournamentNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentNameLabel.Location = new System.Drawing.Point(48, 103);
            this.tournamentNameLabel.Name = "tournamentNameLabel";
            this.tournamentNameLabel.Size = new System.Drawing.Size(225, 37);
            this.tournamentNameLabel.TabIndex = 0;
            this.tournamentNameLabel.Text = "Tournament Name";
            // 
            // entryFeeLabel
            // 
            this.entryFeeLabel.AutoSize = true;
            this.entryFeeLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryFeeLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.entryFeeLabel.Location = new System.Drawing.Point(48, 227);
            this.entryFeeLabel.Name = "entryFeeLabel";
            this.entryFeeLabel.Size = new System.Drawing.Size(124, 37);
            this.entryFeeLabel.TabIndex = 0;
            this.entryFeeLabel.Text = "Entry Fee";
            // 
            // entryFeeValue
            // 
            this.entryFeeValue.Location = new System.Drawing.Point(178, 229);
            this.entryFeeValue.Name = "entryFeeValue";
            this.entryFeeValue.Size = new System.Drawing.Size(140, 35);
            this.entryFeeValue.TabIndex = 4;
            this.entryFeeValue.Text = "0";
            // 
            // selectTeamLabel
            // 
            this.selectTeamLabel.AutoSize = true;
            this.selectTeamLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.selectTeamLabel.Location = new System.Drawing.Point(48, 328);
            this.selectTeamLabel.Name = "selectTeamLabel";
            this.selectTeamLabel.Size = new System.Drawing.Size(150, 37);
            this.selectTeamLabel.TabIndex = 0;
            this.selectTeamLabel.Text = "Select Team";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(48, 368);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(270, 38);
            this.selectTeamDropDown.TabIndex = 1;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 30;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(355, 143);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(305, 152);
            this.tournamentPlayersListBox.TabIndex = 3;
            // 
            // prizesListBox
            // 
            this.prizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizesListBox.FormattingEnabled = true;
            this.prizesListBox.ItemHeight = 30;
            this.prizesListBox.Location = new System.Drawing.Point(355, 368);
            this.prizesListBox.Name = "prizesListBox";
            this.prizesListBox.Size = new System.Drawing.Size(305, 152);
            this.prizesListBox.TabIndex = 3;
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Location = new System.Drawing.Point(204, 335);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(114, 30);
            this.createNewTeamLink.TabIndex = 5;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new";
            // 
            // deleteSelectedTournamentButton
            // 
            this.deleteSelectedTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedTournamentButton.Location = new System.Drawing.Point(666, 143);
            this.deleteSelectedTournamentButton.Name = "deleteSelectedTournamentButton";
            this.deleteSelectedTournamentButton.Size = new System.Drawing.Size(108, 74);
            this.deleteSelectedTournamentButton.TabIndex = 5;
            this.deleteSelectedTournamentButton.Text = "Delete Selected";
            this.deleteSelectedTournamentButton.UseVisualStyleBackColor = true;
            // 
            // addTeamButton
            // 
            this.addTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.addTeamButton.Location = new System.Drawing.Point(118, 424);
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.Size = new System.Drawing.Size(131, 39);
            this.addTeamButton.TabIndex = 5;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.UseVisualStyleBackColor = true;
            // 
            // createPrizeButton
            // 
            this.createPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createPrizeButton.Location = new System.Drawing.Point(104, 481);
            this.createPrizeButton.Name = "createPrizeButton";
            this.createPrizeButton.Size = new System.Drawing.Size(160, 39);
            this.createPrizeButton.TabIndex = 5;
            this.createPrizeButton.Text = "Create Prize";
            this.createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersLable
            // 
            this.tournamentPlayersLable.AutoSize = true;
            this.tournamentPlayersLable.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentPlayersLable.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentPlayersLable.Location = new System.Drawing.Point(355, 103);
            this.tournamentPlayersLable.Name = "tournamentPlayersLable";
            this.tournamentPlayersLable.Size = new System.Drawing.Size(189, 37);
            this.tournamentPlayersLable.TabIndex = 0;
            this.tournamentPlayersLable.Text = "Teams / Players";
            // 
            // prizesLabel
            // 
            this.prizesLabel.AutoSize = true;
            this.prizesLabel.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prizesLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prizesLabel.Location = new System.Drawing.Point(355, 328);
            this.prizesLabel.Name = "prizesLabel";
            this.prizesLabel.Size = new System.Drawing.Size(84, 37);
            this.prizesLabel.TabIndex = 0;
            this.prizesLabel.Text = "Prizes";
            // 
            // deleteSelectedPrizeButton
            // 
            this.deleteSelectedPrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedPrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedPrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedPrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedPrizeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedPrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.deleteSelectedPrizeButton.Location = new System.Drawing.Point(666, 368);
            this.deleteSelectedPrizeButton.Name = "deleteSelectedPrizeButton";
            this.deleteSelectedPrizeButton.Size = new System.Drawing.Size(108, 74);
            this.deleteSelectedPrizeButton.TabIndex = 5;
            this.deleteSelectedPrizeButton.Text = "Delete Selected";
            this.deleteSelectedPrizeButton.UseVisualStyleBackColor = true;
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.createTournamentButton.Location = new System.Drawing.Point(301, 534);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(233, 45);
            this.createTournamentButton.TabIndex = 5;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(817, 600);
            this.Controls.Add(this.createTournamentButton);
            this.Controls.Add(this.deleteSelectedPrizeButton);
            this.Controls.Add(this.prizesLabel);
            this.Controls.Add(this.tournamentPlayersLable);
            this.Controls.Add(this.createPrizeButton);
            this.Controls.Add(this.addTeamButton);
            this.Controls.Add(this.deleteSelectedTournamentButton);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.prizesListBox);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.selectTeamLabel);
            this.Controls.Add(this.entryFeeValue);
            this.Controls.Add(this.entryFeeLabel);
            this.Controls.Add(this.tournamentNameLabel);
            this.Controls.Add(this.tournamentNameValue);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.TextBox tournamentNameValue;
        private System.Windows.Forms.Label tournamentNameLabel;
        private System.Windows.Forms.Label entryFeeLabel;
        private System.Windows.Forms.TextBox entryFeeValue;
        private System.Windows.Forms.Label selectTeamLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.ListBox prizesListBox;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button deleteSelectedTournamentButton;
        private System.Windows.Forms.Button addTeamButton;
        private System.Windows.Forms.Button createPrizeButton;
        private System.Windows.Forms.Label tournamentPlayersLable;
        private System.Windows.Forms.Label prizesLabel;
        private System.Windows.Forms.Button deleteSelectedPrizeButton;
        private System.Windows.Forms.Button createTournamentButton;
    }
}