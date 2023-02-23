namespace Queue
{
    partial class QueueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueueForm));
            this.EnqueueBtn = new System.Windows.Forms.Button();
            this.ShowNextBtn = new System.Windows.Forms.Button();
            this.QueueListBox = new System.Windows.Forms.ListBox();
            this.AutoQueueBtn = new System.Windows.Forms.Button();
            this.QueueCountTxt = new System.Windows.Forms.Label();
            this.QueueLastTxt = new System.Windows.Forms.Label();
            this.ResetQueueBtn = new System.Windows.Forms.Button();
            this.CurrentQueueLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnqueueBtn
            // 
            this.EnqueueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EnqueueBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnqueueBtn.Font = new System.Drawing.Font("Mont Blanc", 9F, System.Drawing.FontStyle.Bold);
            this.EnqueueBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.EnqueueBtn.Location = new System.Drawing.Point(421, 412);
            this.EnqueueBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnqueueBtn.Name = "EnqueueBtn";
            this.EnqueueBtn.Size = new System.Drawing.Size(103, 25);
            this.EnqueueBtn.TabIndex = 0;
            this.EnqueueBtn.Text = "Get Queue";
            this.EnqueueBtn.UseVisualStyleBackColor = false;
            this.EnqueueBtn.Click += new System.EventHandler(this.EnqueueBtn_Click);
            // 
            // ShowNextBtn
            // 
            this.ShowNextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowNextBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ShowNextBtn.Enabled = false;
            this.ShowNextBtn.Font = new System.Drawing.Font("Mont Blanc", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowNextBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.ShowNextBtn.Location = new System.Drawing.Point(529, 412);
            this.ShowNextBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowNextBtn.Name = "ShowNextBtn";
            this.ShowNextBtn.Size = new System.Drawing.Size(103, 25);
            this.ShowNextBtn.TabIndex = 0;
            this.ShowNextBtn.Text = "Show Next";
            this.ShowNextBtn.UseVisualStyleBackColor = false;
            this.ShowNextBtn.Click += new System.EventHandler(this.ShowNextBtn_Click);
            // 
            // QueueListBox
            // 
            this.QueueListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueueListBox.FormattingEnabled = true;
            this.QueueListBox.IntegralHeight = false;
            this.QueueListBox.Location = new System.Drawing.Point(26, 128);
            this.QueueListBox.Name = "QueueListBox";
            this.QueueListBox.Size = new System.Drawing.Size(606, 276);
            this.QueueListBox.TabIndex = 1;
            // 
            // AutoQueueBtn
            // 
            this.AutoQueueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoQueueBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AutoQueueBtn.Font = new System.Drawing.Font("Mont Blanc", 9F, System.Drawing.FontStyle.Bold);
            this.AutoQueueBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.AutoQueueBtn.Location = new System.Drawing.Point(313, 412);
            this.AutoQueueBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AutoQueueBtn.Name = "AutoQueueBtn";
            this.AutoQueueBtn.Size = new System.Drawing.Size(103, 25);
            this.AutoQueueBtn.TabIndex = 0;
            this.AutoQueueBtn.Text = "Auto Queue";
            this.AutoQueueBtn.UseVisualStyleBackColor = false;
            this.AutoQueueBtn.Click += new System.EventHandler(this.AutoQueueBtn_Click);
            // 
            // QueueCountTxt
            // 
            this.QueueCountTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QueueCountTxt.AutoSize = true;
            this.QueueCountTxt.BackColor = System.Drawing.Color.Transparent;
            this.QueueCountTxt.Font = new System.Drawing.Font("Tw Cen MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueueCountTxt.ForeColor = System.Drawing.Color.White;
            this.QueueCountTxt.Location = new System.Drawing.Point(508, 102);
            this.QueueCountTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QueueCountTxt.Name = "QueueCountTxt";
            this.QueueCountTxt.Size = new System.Drawing.Size(121, 20);
            this.QueueCountTxt.TabIndex = 2;
            this.QueueCountTxt.Text = "Queue Length: 0";
            // 
            // QueueLastTxt
            // 
            this.QueueLastTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QueueLastTxt.AutoSize = true;
            this.QueueLastTxt.BackColor = System.Drawing.Color.Transparent;
            this.QueueLastTxt.Font = new System.Drawing.Font("Tw Cen MT", 12.75F);
            this.QueueLastTxt.ForeColor = System.Drawing.Color.White;
            this.QueueLastTxt.Location = new System.Drawing.Point(22, 412);
            this.QueueLastTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.QueueLastTxt.Name = "QueueLastTxt";
            this.QueueLastTxt.Size = new System.Drawing.Size(129, 20);
            this.QueueLastTxt.TabIndex = 2;
            this.QueueLastTxt.Text = "Queue Last No. 0";
            // 
            // ResetQueueBtn
            // 
            this.ResetQueueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetQueueBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetQueueBtn.Font = new System.Drawing.Font("Mont Blanc", 9F, System.Drawing.FontStyle.Bold);
            this.ResetQueueBtn.ForeColor = System.Drawing.Color.Firebrick;
            this.ResetQueueBtn.Location = new System.Drawing.Point(205, 412);
            this.ResetQueueBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResetQueueBtn.Name = "ResetQueueBtn";
            this.ResetQueueBtn.Size = new System.Drawing.Size(103, 25);
            this.ResetQueueBtn.TabIndex = 0;
            this.ResetQueueBtn.Text = "Reset Queue";
            this.ResetQueueBtn.UseVisualStyleBackColor = false;
            this.ResetQueueBtn.Click += new System.EventHandler(this.ResetQueueBtn_Click);
            // 
            // CurrentQueueLbl
            // 
            this.CurrentQueueLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CurrentQueueLbl.AutoSize = true;
            this.CurrentQueueLbl.BackColor = System.Drawing.Color.Transparent;
            this.CurrentQueueLbl.Font = new System.Drawing.Font("Tw Cen MT", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentQueueLbl.ForeColor = System.Drawing.Color.White;
            this.CurrentQueueLbl.Location = new System.Drawing.Point(22, 102);
            this.CurrentQueueLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentQueueLbl.Name = "CurrentQueueLbl";
            this.CurrentQueueLbl.Size = new System.Drawing.Size(385, 20);
            this.CurrentQueueLbl.TabIndex = 3;
            this.CurrentQueueLbl.Text = "Welcome! kindly wait for your turn to order as follows:";
            // 
            // QueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(657, 451);
            this.Controls.Add(this.CurrentQueueLbl);
            this.Controls.Add(this.QueueLastTxt);
            this.Controls.Add(this.QueueCountTxt);
            this.Controls.Add(this.QueueListBox);
            this.Controls.Add(this.ShowNextBtn);
            this.Controls.Add(this.ResetQueueBtn);
            this.Controls.Add(this.AutoQueueBtn);
            this.Controls.Add(this.EnqueueBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "QueueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "McDonald\'s Queue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnqueueBtn;
        private System.Windows.Forms.Button ShowNextBtn;
        private System.Windows.Forms.ListBox QueueListBox;
        private System.Windows.Forms.Button AutoQueueBtn;
        private System.Windows.Forms.Label QueueCountTxt;
        private System.Windows.Forms.Label QueueLastTxt;
        private System.Windows.Forms.Button ResetQueueBtn;
        private System.Windows.Forms.Label CurrentQueueLbl;
    }
}

