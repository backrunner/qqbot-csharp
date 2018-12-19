using Native.Csharp.App.Model;
using BackRunner.QQBot.Models;
using Native.Csharp.Sdk.Cqp.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Native.Csharp.App;

namespace BackRunner.QQBot.Processors
{
    public static class RepeatProcessor
    {
        private static List<GroupMessage> lastGroupMessage = new List<GroupMessage>();

        #region == 自动复读 ==
        public static void Process(GroupMessageEventArgs e)
        {
            //查询之前的各群最后一次发言
            GroupMessage gm = lastGroupMessage.Find(t => t.FromGroup.Equals(e.FromGroup));
            
            if (gm == null)
            {
                //无该群的最后一次发言记录，则新建记录并添加
                gm = new GroupMessage(e.FromGroup, e.FromQQ, e.Msg);
                lastGroupMessage.Add(gm);
            } else
            {
                //存在该群的最后一次发言记录
                //判断消息是否为复读
                if (gm.Msg == e.Msg)
                {
                    //判断是否为同一个人发送的
                    if (gm.FromQQ != e.FromQQ)
                    {
                        gm.RepeatCount++;   //复读计数器递增
                        gm.FromQQ = e.FromQQ;   //更新QQ
                        if (gm.RepeatCount >= Common.Random.Next(2,5))
                        {
                            //当复读次数达到三次的时候进行复读
                            EnApi.Instance.SendGroupMessage(e.FromGroup, e.Msg);
                            gm.isRepeated = true;
                        }
                    } else
                    {
                        //为同一个人发送，更新fromQQ，不更新其他值
                        gm.FromQQ = e.FromQQ;
                    }
                } else
                {
                    //消息不是复读，更新相应的内容
                    gm.Msg = e.Msg;
                    gm.FromQQ = e.FromQQ;
                    //重置
                    gm.RepeatCount = 0;
                    gm.isRepeated = false;                    
                }
            }
        }
        #endregion


    }
}
