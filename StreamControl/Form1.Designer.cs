namespace StreamControl
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChallongeID = new System.Windows.Forms.TextBox();
            this.GetTournamentData = new System.Windows.Forms.Button();
            this.GroupsList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MatchesList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FillInButton = new System.Windows.Forms.Button();
            this.Player1Flag = new System.Windows.Forms.ComboBox();
            this.Player1Name = new System.Windows.Forms.TextBox();
            this.Player1Score = new System.Windows.Forms.TextBox();
            this.Player2Score = new System.Windows.Forms.TextBox();
            this.Player2Name = new System.Windows.Forms.TextBox();
            this.Player2Flag = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Player1ScoreUp = new System.Windows.Forms.Button();
            this.Player1ScoreDown = new System.Windows.Forms.Button();
            this.Player2ScoreDown = new System.Windows.Forms.Button();
            this.Player2ScoreUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GetNextBattleButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SetCommentatorsNames = new System.Windows.Forms.Button();
            this.NextPlayer1Name = new System.Windows.Forms.TextBox();
            this.NextPlayer2Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SetNextBattle = new System.Windows.Forms.Button();
            this.CommentatorsNames = new System.Windows.Forms.TextBox();
            this.ClearCommentatorsNames = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SaveTournamentInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GameTitle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TournamentStage = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TimerSaveButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TimerMinutes = new System.Windows.Forms.NumericUpDown();
            this.TimerSeconds = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.TimerTextInfo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CurrentTimerValue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerSeconds)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GetTournamentData);
            this.groupBox1.Controls.Add(this.ChallongeID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Challonge identifier";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Player2ScoreDown);
            this.groupBox2.Controls.Add(this.Player2ScoreUp);
            this.groupBox2.Controls.Add(this.Player1ScoreDown);
            this.groupBox2.Controls.Add(this.Player1ScoreUp);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Player2Flag);
            this.groupBox2.Controls.Add(this.Player2Name);
            this.groupBox2.Controls.Add(this.Player2Score);
            this.groupBox2.Controls.Add(this.Player1Score);
            this.groupBox2.Controls.Add(this.Player1Name);
            this.groupBox2.Controls.Add(this.Player1Flag);
            this.groupBox2.Controls.Add(this.FillInButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.MatchesList);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.GroupsList);
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 213);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Players information";
            // 
            // ChallongeID
            // 
            this.ChallongeID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChallongeID.Location = new System.Drawing.Point(7, 20);
            this.ChallongeID.Name = "ChallongeID";
            this.ChallongeID.Size = new System.Drawing.Size(556, 20);
            this.ChallongeID.TabIndex = 0;
            // 
            // GetTournamentData
            // 
            this.GetTournamentData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetTournamentData.Location = new System.Drawing.Point(569, 19);
            this.GetTournamentData.Name = "GetTournamentData";
            this.GetTournamentData.Size = new System.Drawing.Size(75, 23);
            this.GetTournamentData.TabIndex = 1;
            this.GetTournamentData.Text = "Connect";
            this.GetTournamentData.UseVisualStyleBackColor = true;
            // 
            // GroupsList
            // 
            this.GroupsList.FormattingEnabled = true;
            this.GroupsList.Location = new System.Drawing.Point(49, 19);
            this.GroupsList.Name = "GroupsList";
            this.GroupsList.Size = new System.Drawing.Size(595, 21);
            this.GroupsList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Group";
            // 
            // MatchesList
            // 
            this.MatchesList.FormattingEnabled = true;
            this.MatchesList.Location = new System.Drawing.Point(49, 47);
            this.MatchesList.Name = "MatchesList";
            this.MatchesList.Size = new System.Drawing.Size(595, 21);
            this.MatchesList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Match";
            // 
            // FillInButton
            // 
            this.FillInButton.Location = new System.Drawing.Point(10, 74);
            this.FillInButton.Name = "FillInButton";
            this.FillInButton.Size = new System.Drawing.Size(634, 23);
            this.FillInButton.TabIndex = 4;
            this.FillInButton.Text = "Fill in ->";
            this.FillInButton.UseVisualStyleBackColor = true;
            // 
            // Player1Flag
            // 
            this.Player1Flag.FormattingEnabled = true;
            this.Player1Flag.Location = new System.Drawing.Point(10, 104);
            this.Player1Flag.Name = "Player1Flag";
            this.Player1Flag.Size = new System.Drawing.Size(56, 21);
            this.Player1Flag.TabIndex = 5;
            // 
            // Player1Name
            // 
            this.Player1Name.Location = new System.Drawing.Point(72, 104);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(165, 20);
            this.Player1Name.TabIndex = 6;
            // 
            // Player1Score
            // 
            this.Player1Score.Location = new System.Drawing.Point(243, 104);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(72, 20);
            this.Player1Score.TabIndex = 7;
            // 
            // Player2Score
            // 
            this.Player2Score.Location = new System.Drawing.Point(339, 104);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(72, 20);
            this.Player2Score.TabIndex = 8;
            // 
            // Player2Name
            // 
            this.Player2Name.Location = new System.Drawing.Point(417, 104);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(165, 20);
            this.Player2Name.TabIndex = 9;
            // 
            // Player2Flag
            // 
            this.Player2Flag.FormattingEnabled = true;
            this.Player2Flag.Location = new System.Drawing.Point(588, 104);
            this.Player2Flag.Name = "Player2Flag";
            this.Player2Flag.Size = new System.Drawing.Size(56, 21);
            this.Player2Flag.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = ":";
            // 
            // Player1ScoreUp
            // 
            this.Player1ScoreUp.Location = new System.Drawing.Point(243, 131);
            this.Player1ScoreUp.Name = "Player1ScoreUp";
            this.Player1ScoreUp.Size = new System.Drawing.Size(33, 30);
            this.Player1ScoreUp.TabIndex = 12;
            this.Player1ScoreUp.Text = "+";
            this.Player1ScoreUp.UseVisualStyleBackColor = true;
            // 
            // Player1ScoreDown
            // 
            this.Player1ScoreDown.Location = new System.Drawing.Point(282, 131);
            this.Player1ScoreDown.Name = "Player1ScoreDown";
            this.Player1ScoreDown.Size = new System.Drawing.Size(33, 30);
            this.Player1ScoreDown.TabIndex = 13;
            this.Player1ScoreDown.Text = "-";
            this.Player1ScoreDown.UseVisualStyleBackColor = true;
            // 
            // Player2ScoreDown
            // 
            this.Player2ScoreDown.Location = new System.Drawing.Point(378, 131);
            this.Player2ScoreDown.Name = "Player2ScoreDown";
            this.Player2ScoreDown.Size = new System.Drawing.Size(33, 30);
            this.Player2ScoreDown.TabIndex = 15;
            this.Player2ScoreDown.Text = "-";
            this.Player2ScoreDown.UseVisualStyleBackColor = true;
            // 
            // Player2ScoreUp
            // 
            this.Player2ScoreUp.Location = new System.Drawing.Point(339, 131);
            this.Player2ScoreUp.Name = "Player2ScoreUp";
            this.Player2ScoreUp.Size = new System.Drawing.Size(33, 30);
            this.Player2ScoreUp.TabIndex = 14;
            this.Player2ScoreUp.Text = "+";
            this.Player2ScoreUp.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Refresh nicknames";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 37);
            this.button2.TabIndex = 17;
            this.button2.Text = "Set zero scores";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(454, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 37);
            this.button3.TabIndex = 18;
            this.button3.Text = "Swap players";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SetNextBattle);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.NextPlayer2Name);
            this.groupBox3.Controls.Add(this.NextPlayer1Name);
            this.groupBox3.Controls.Add(this.GetNextBattleButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(315, 117);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Next battle";
            // 
            // GetNextBattleButton
            // 
            this.GetNextBattleButton.Location = new System.Drawing.Point(10, 20);
            this.GetNextBattleButton.Name = "GetNextBattleButton";
            this.GetNextBattleButton.Size = new System.Drawing.Size(299, 23);
            this.GetNextBattleButton.TabIndex = 0;
            this.GetNextBattleButton.Text = "Get next battle";
            this.GetNextBattleButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ClearCommentatorsNames);
            this.groupBox4.Controls.Add(this.CommentatorsNames);
            this.groupBox4.Controls.Add(this.SetCommentatorsNames);
            this.groupBox4.Location = new System.Drawing.Point(333, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(329, 117);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Commentators";
            // 
            // SetCommentatorsNames
            // 
            this.SetCommentatorsNames.Location = new System.Drawing.Point(6, 47);
            this.SetCommentatorsNames.Name = "SetCommentatorsNames";
            this.SetCommentatorsNames.Size = new System.Drawing.Size(317, 23);
            this.SetCommentatorsNames.TabIndex = 0;
            this.SetCommentatorsNames.Text = "Save";
            this.SetCommentatorsNames.UseVisualStyleBackColor = true;
            // 
            // NextPlayer1Name
            // 
            this.NextPlayer1Name.Location = new System.Drawing.Point(10, 49);
            this.NextPlayer1Name.Name = "NextPlayer1Name";
            this.NextPlayer1Name.Size = new System.Drawing.Size(202, 20);
            this.NextPlayer1Name.TabIndex = 7;
            // 
            // NextPlayer2Name
            // 
            this.NextPlayer2Name.Location = new System.Drawing.Point(10, 91);
            this.NextPlayer2Name.Name = "NextPlayer2Name";
            this.NextPlayer2Name.Size = new System.Drawing.Size(202, 20);
            this.NextPlayer2Name.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "VS";
            // 
            // SetNextBattle
            // 
            this.SetNextBattle.Location = new System.Drawing.Point(218, 49);
            this.SetNextBattle.Name = "SetNextBattle";
            this.SetNextBattle.Size = new System.Drawing.Size(91, 62);
            this.SetNextBattle.TabIndex = 10;
            this.SetNextBattle.Text = "Save next battle";
            this.SetNextBattle.UseVisualStyleBackColor = true;
            // 
            // CommentatorsNames
            // 
            this.CommentatorsNames.Location = new System.Drawing.Point(7, 21);
            this.CommentatorsNames.Name = "CommentatorsNames";
            this.CommentatorsNames.Size = new System.Drawing.Size(316, 20);
            this.CommentatorsNames.TabIndex = 1;
            // 
            // ClearCommentatorsNames
            // 
            this.ClearCommentatorsNames.Location = new System.Drawing.Point(6, 88);
            this.ClearCommentatorsNames.Name = "ClearCommentatorsNames";
            this.ClearCommentatorsNames.Size = new System.Drawing.Size(317, 23);
            this.ClearCommentatorsNames.TabIndex = 4;
            this.ClearCommentatorsNames.Text = "Clear";
            this.ClearCommentatorsNames.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TournamentStage);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.SaveTournamentInfo);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.GameTitle);
            this.groupBox5.Location = new System.Drawing.Point(12, 418);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(315, 101);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tournament info";
            // 
            // SaveTournamentInfo
            // 
            this.SaveTournamentInfo.Location = new System.Drawing.Point(194, 70);
            this.SaveTournamentInfo.Name = "SaveTournamentInfo";
            this.SaveTournamentInfo.Size = new System.Drawing.Size(115, 26);
            this.SaveTournamentInfo.TabIndex = 10;
            this.SaveTournamentInfo.Text = "Save";
            this.SaveTournamentInfo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stage";
            // 
            // GameTitle
            // 
            this.GameTitle.Location = new System.Drawing.Point(48, 16);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(261, 20);
            this.GameTitle.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Game";
            // 
            // TournamentStage
            // 
            this.TournamentStage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TournamentStage.Items.AddRange(new object[] {
            "Pools",
            "Playoff",
            "Top-8",
            "Winners Final",
            "Losers Final",
            "Grand Finals"});
            this.TournamentStage.Location = new System.Drawing.Point(48, 43);
            this.TournamentStage.Name = "TournamentStage";
            this.TournamentStage.Size = new System.Drawing.Size(261, 21);
            this.TournamentStage.TabIndex = 12;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CurrentTimerValue);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.TimerTextInfo);
            this.groupBox6.Controls.Add(this.TimerSeconds);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.TimerMinutes);
            this.groupBox6.Controls.Add(this.TimerSaveButton);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(333, 418);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(329, 101);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Starting screen";
            // 
            // TimerSaveButton
            // 
            this.TimerSaveButton.Location = new System.Drawing.Point(202, 69);
            this.TimerSaveButton.Name = "TimerSaveButton";
            this.TimerSaveButton.Size = new System.Drawing.Size(121, 26);
            this.TimerSaveButton.TabIndex = 10;
            this.TimerSaveButton.Text = "Save";
            this.TimerSaveButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(111, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Min";
            // 
            // TimerMinutes
            // 
            this.TimerMinutes.Location = new System.Drawing.Point(7, 16);
            this.TimerMinutes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TimerMinutes.Name = "TimerMinutes";
            this.TimerMinutes.Size = new System.Drawing.Size(98, 20);
            this.TimerMinutes.TabIndex = 11;
            // 
            // TimerSeconds
            // 
            this.TimerSeconds.Location = new System.Drawing.Point(163, 16);
            this.TimerSeconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TimerSeconds.Name = "TimerSeconds";
            this.TimerSeconds.Size = new System.Drawing.Size(98, 20);
            this.TimerSeconds.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sec";
            // 
            // TimerTextInfo
            // 
            this.TimerTextInfo.Location = new System.Drawing.Point(85, 43);
            this.TimerTextInfo.Name = "TimerTextInfo";
            this.TimerTextInfo.Size = new System.Drawing.Size(238, 20);
            this.TimerTextInfo.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Additional info";
            // 
            // CurrentTimerValue
            // 
            this.CurrentTimerValue.AutoSize = true;
            this.CurrentTimerValue.Location = new System.Drawing.Point(54, 76);
            this.CurrentTimerValue.Name = "CurrentTimerValue";
            this.CurrentTimerValue.Size = new System.Drawing.Size(42, 13);
            this.CurrentTimerValue.TabIndex = 16;
            this.CurrentTimerValue.Text = "MM:SS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 528);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimerMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimerSeconds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button GetTournamentData;
        private System.Windows.Forms.TextBox ChallongeID;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Player2ScoreDown;
        private System.Windows.Forms.Button Player2ScoreUp;
        private System.Windows.Forms.Button Player1ScoreDown;
        private System.Windows.Forms.Button Player1ScoreUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Player2Flag;
        private System.Windows.Forms.TextBox Player2Name;
        private System.Windows.Forms.TextBox Player2Score;
        private System.Windows.Forms.TextBox Player1Score;
        private System.Windows.Forms.TextBox Player1Name;
        private System.Windows.Forms.ComboBox Player1Flag;
        private System.Windows.Forms.Button FillInButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox MatchesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GroupsList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button SetNextBattle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NextPlayer2Name;
        private System.Windows.Forms.TextBox NextPlayer1Name;
        private System.Windows.Forms.Button GetNextBattleButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button ClearCommentatorsNames;
        private System.Windows.Forms.TextBox CommentatorsNames;
        private System.Windows.Forms.Button SetCommentatorsNames;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox TournamentStage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SaveTournamentInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox GameTitle;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button TimerSaveButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TimerTextInfo;
        private System.Windows.Forms.NumericUpDown TimerSeconds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown TimerMinutes;
        private System.Windows.Forms.Label CurrentTimerValue;
    }
}

