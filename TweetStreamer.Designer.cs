namespace RxWinForms
{
    partial class TweetStreamer
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
            this.components = new System.ComponentModel.Container();
            this.tweetStreamGrid = new System.Windows.Forms.DataGridView();
            this.tweetSource = new System.Windows.Forms.BindingSource(this.components);
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.keyword = new System.Windows.Forms.TextBox();
            this.keywordLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tweetStreamGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tweetSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tweetStreamGrid
            // 
            this.tweetStreamGrid.AllowUserToAddRows = false;
            this.tweetStreamGrid.AllowUserToDeleteRows = false;
            this.tweetStreamGrid.AutoGenerateColumns = false;
            this.tweetStreamGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tweetStreamGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tweetStreamGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Username,
            this.Content});
            this.tweetStreamGrid.DataSource = this.tweetSource;
            this.tweetStreamGrid.Location = new System.Drawing.Point(23, 53);
            this.tweetStreamGrid.Name = "tweetStreamGrid";
            this.tweetStreamGrid.ReadOnly = true;
            this.tweetStreamGrid.Size = new System.Drawing.Size(783, 307);
            this.tweetStreamGrid.TabIndex = 0;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(316, 11);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(229, 11);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(23, 363);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(0, 13);
            this.progressLabel.TabIndex = 3;
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(81, 12);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(118, 20);
            this.keyword.TabIndex = 4;
            this.keyword.Text = "euro";
            // 
            // keywordLabel
            // 
            this.keywordLabel.AutoSize = true;
            this.keywordLabel.Location = new System.Drawing.Point(23, 15);
            this.keywordLabel.Name = "keywordLabel";
            this.keywordLabel.Size = new System.Drawing.Size(51, 13);
            this.keywordLabel.TabIndex = 5;
            this.keywordLabel.Text = "Keyword:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(500, 363);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 13);
            this.statusLabel.TabIndex = 6;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.DataPropertyName = "Id";
            this.Id.FillWeight = 30.45685F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // Username
            // 
            this.Username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Username.DataPropertyName = "Username";
            this.Username.FillWeight = 68.41196F;
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 80;
            // 
            // Content
            // 
            this.Content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Content.DataPropertyName = "Content";
            this.Content.FillWeight = 201.1312F;
            this.Content.HeaderText = "Content";
            this.Content.Name = "Content";
            this.Content.ReadOnly = true;
            this.Content.Width = 69;
            // 
            // TweetStreamer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(842, 412);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.keywordLabel);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.tweetStreamGrid);
            this.Name = "TweetStreamer";
            this.Text = "Tweet Streamer";
            ((System.ComponentModel.ISupportInitialize)(this.tweetStreamGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tweetSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tweetStreamGrid;
        private System.Windows.Forms.BindingSource tweetSource;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label keywordLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Content;
    }
}

