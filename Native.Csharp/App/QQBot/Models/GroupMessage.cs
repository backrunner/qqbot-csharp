using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackRunner.QQBot.Models
{
    public class GroupMessage
    {
        public long FromGroup;
        public long FromQQ;
        public string Msg;
        public int RepeatCount;
        
        //flags
        public bool isRepeated = false;

        public GroupMessage(long fromGroup, long fromQQ, string msg)
        {
            FromGroup = fromGroup;
            FromQQ = fromQQ;
            Msg = msg;
            RepeatCount = 0;
        }

        public GroupMessage(long fromGroup, long fromQQ, string msg, int repeatCount)
        {
            FromGroup = fromGroup;
            FromQQ = fromQQ;
            Msg = msg;
            RepeatCount = repeatCount;
        }
    }
}
