using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Queue
{
    public partial class QueueForm : Form
    {
        private Timer _queueTimer;
        private NumberQueue _numberQueue;

        public QueueForm()
        {
            InitializeComponent();
            _queueTimer = new Timer();
            _queueTimer.Interval = 1000;
            _queueTimer.Tick += _queueTimer_Tick;
            _numberQueue = new NumberQueue();
            ResetQueueBtn.Enabled = false;
        }

        private void _queueTimer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            _queueTimer.Interval = rnd.Next(750,3000);
            _numberQueue.EnqueueNumber();
            RefreshQueueList();
        }

        private void RefreshQueueList()
        {
            QueueListBox.Items.Clear();
            QueueListBox.Items.AddRange(_numberQueue.GetQueue().ToArray());

            ShowNextBtn.Enabled = _numberQueue.GetQueue().Count != 0;
            ResetQueueBtn.Enabled = _numberQueue.GetQueue().Count != 0;

            QueueCountTxt.Text = String.Format("Queue Length: {0}", _numberQueue.GetQueue().Count);
            QueueLastTxt.Text = String.Format("Queue Last No. {0}", _numberQueue.CurrentNumber());
        }

        private void AutoQueueBtn_Click(object sender, EventArgs e)
        {
            Button senderBtn = ((Button)sender);
            if (senderBtn.BackColor == Color.WhiteSmoke)
            {
                senderBtn.BackColor = Color.Moccasin;
                EnqueueBtn.Enabled = false;
                _queueTimer.Start();
            } else if (senderBtn.BackColor == Color.Moccasin)
            {
                senderBtn.BackColor = Color.WhiteSmoke;
                EnqueueBtn.Enabled = true;
                _queueTimer.Stop();
            }
        }

        private void EnqueueBtn_Click(object sender, EventArgs e)
        {
            _numberQueue.EnqueueNumber();
            RefreshQueueList();
        }

        private void ShowNextBtn_Click(object sender, EventArgs e)
        {
            if (_numberQueue.GetQueue().Count != 0)
            {
                string messageQueue = _numberQueue.DequeNumber();
                RefreshQueueList();
                MessageBox.Show(this, String.Format("The {0}'s order has been completed. Thank you!", messageQueue), "McDonald's Queue - Dequeued");
            }
        }

        private void ResetQueueBtn_Click(object sender, EventArgs e)
        {
            _numberQueue.Reset();
            RefreshQueueList();
        }
    }
}
