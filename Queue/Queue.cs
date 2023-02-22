using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Queue
{
    class NumberQueue
    {
        private int _queueNumber;
        private int _startNumber;
        private string[] _strFormatSplitted;
        private static Queue<string> _numberQueue;
        public static string newNumberInQueue = "";

        public NumberQueue(int startNumber = 0, string strFormat = "QUEUE #[]")
        {
            _strFormatSplitted = strFormat.Split(new string[] {"[]"}, StringSplitOptions.None);
            _startNumber = startNumber;
            _queueNumber = _startNumber;
            _numberQueue = new Queue<string>();
        }

        public string EnqueueNumber()
        {
            _queueNumber++;
            string strNum = string.Format("{0}{1}{2}", _strFormatSplitted[0], _queueNumber, _strFormatSplitted[1]);
            _numberQueue.Enqueue(strNum);

            return strNum;
        }

        public int CurrentNumber()
        {
            return _queueNumber;
        }

        public string DequeNumber()
        {
            return _numberQueue.Dequeue();
        }

        public Queue<string> GetQueue()
        {
            return _numberQueue;
        }

        public void Reset()
        {
            _queueNumber = _startNumber;
            _numberQueue.Clear();
        }


    }
}
