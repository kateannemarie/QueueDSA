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
            this.SuspendLayout();
            // 
            // EnqueueBtn
            // 
            this.EnqueueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EnqueueBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EnqueueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnqueueBtn.Location = new System.Drawing.Point(420, 382);
            this.EnqueueBtn.Name = "EnqueueBtn";
            this.EnqueueBtn.Size = new System.Drawing.Size(120, 50);
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
            this.ShowNextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowNextBtn.Location = new System.Drawing.Point(546, 382);
            this.ShowNextBtn.Name = "ShowNextBtn";
            this.ShowNextBtn.Size = new System.Drawing.Size(120, 50);
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
            this.QueueListBox.ItemHeight = 20;
            this.QueueListBox.Location = new System.Drawing.Point(12, 12);
            this.QueueListBox.Margin = new System.Windows.Forms.Padding(5);
            this.QueueListBox.Name = "QueueListBox";
            this.QueueListBox.Size = new System.Drawing.Size(654, 359);
            this.QueueListBox.TabIndex = 1;
            // 
            // AutoQueueBtn
            // 
            this.AutoQueueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoQueueBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AutoQueueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AutoQueueBtn.Location = new System.Drawing.Point(294, 382);
            this.AutoQueueBtn.Name = "AutoQueueBtn";
            this.AutoQueueBtn.Size = new System.Drawing.Size(120, 50);
            this.AutoQueueBtn.TabIndex = 0;
            this.AutoQueueBtn.Text = "Auto Queue";
            this.AutoQueueBtn.UseVisualStyleBackColor = false;
            this.AutoQueueBtn.Click += new System.EventHandler(this.AutoQueueBtn_Click);
            // 
            // QueueCountTxt
            // 
            this.QueueCountTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QueueCountTxt.AutoSize = true;
            this.QueueCountTxt.Location = new System.Drawing.Point(8, 384);
            this.QueueCountTxt.Name = "QueueCountTxt";
            this.QueueCountTxt.Size = new System.Drawing.Size(121, 20);
            this.QueueCountTxt.TabIndex = 2;
            this.QueueCountTxt.Text = "Queue Count: 0";
            // 
            // QueueLastTxt
            // 
            this.QueueLastTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QueueLastTxt.AutoSize = true;
            this.QueueLastTxt.Location = new System.Drawing.Point(8, 408);
            this.QueueLastTxt.Name = "QueueLastTxt";
            this.QueueLastTxt.Size = new System.Drawing.Size(122, 20);
            this.QueueLastTxt.TabIndex = 2;
            this.QueueLastTxt.Text = "Queue Last #: 0";
            // 
            // ResetQueueBtn
            // 
            this.ResetQueueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetQueueBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetQueueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetQueueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetQueueBtn.Location = new System.Drawing.Point(168, 382);
            this.ResetQueueBtn.Name = "ResetQueueBtn";
            this.ResetQueueBtn.Size = new System.Drawing.Size(120, 50);
            this.ResetQueueBtn.TabIndex = 0;
            this.ResetQueueBtn.Text = "Reset Queue";
            this.ResetQueueBtn.UseVisualStyleBackColor = false;
            this.ResetQueueBtn.Click += new System.EventHandler(this.ResetQueueBtn_Click);
            // 
            // QueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 444);
            this.Controls.Add(this.QueueLastTxt);
            this.Controls.Add(this.QueueCountTxt);
            this.Controls.Add(this.QueueListBox);
            this.Controls.Add(this.ShowNextBtn);
            this.Controls.Add(this.ResetQueueBtn);
            this.Controls.Add(this.AutoQueueBtn);
            this.Controls.Add(this.EnqueueBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 800);
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "QueueForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Queue";
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
    }
}

