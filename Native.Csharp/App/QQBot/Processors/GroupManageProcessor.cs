﻿using BackRunner.QQBot.Utils;
using Native.Csharp.App.Model;
using Native.Csharp.Sdk.Cqp.Api;
using Native.Csharp.Sdk.Cqp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace BackRunner.QQBot.Processors
{
    public static class GroupManageProcessor
    {
        #region == 禁言 ==
        //禁言
        public static void BanGroupSpeak(GroupMessageEventArgs e)
        {
            //判断是否有禁言目标
            if (e.Msg.Contains("CQ:at"))
            {
                MatchCollection beingOperatedQQ = Regex.Matches(e.Msg, @"(?<=\[CQ:at,qq=)([0-9]*)(?=])");

                //提取禁言时长
                int day = 0;
                int hour = 0;
                int minute = 0;

                if (e.Msg.Contains("天"))
                {
                    //判断是中文数字还是阿拉伯数字
                    Match _day = Regex.Match(e.Msg, @"([\u4e00-\u9fa5]+)(?=天)");
                    if (_day.Length > 0)
                    {
                        day = ChineseNumberConverter.Convert2Number(_day.ToString());
                    }
                    else
                    {
                        _day = Regex.Match(e.Msg, @"([0-9]+)(?=天)");
                        day = Convert.ToInt32(_day.ToString());
                    }
                }
                if (e.Msg.Contains("小时"))
                {
                    Match _hour = Regex.Match(e.Msg, @"([\u4e00-\u9fa5]+)(?=小时)");
                    if (_hour.Length > 0)
                    {
                        hour = ChineseNumberConverter.Convert2Number(_hour.ToString());
                    }
                    else
                    {
                        _hour = Regex.Match(e.Msg, @"([0-9]+)(?=小时)");
                        hour = Convert.ToInt32(_hour.ToString());
                    }
                }
                if (e.Msg.Contains("分钟"))
                {
                    Match _minute = Regex.Match(e.Msg, @"([\u4e00-\u9fa5]+)(?=分钟)");
                    if (_minute.Length > 0)
                    {
                        minute = ChineseNumberConverter.Convert2Number(_minute.ToString());
                    }
                    else
                    {
                        _minute = Regex.Match(e.Msg, @"([0-9]+)(?=分钟)");
                        minute = Convert.ToInt32(_minute.ToString());
                    }
                }

                if (day > 0 || hour > 0 || minute > 0)
                {
                    TimeSpan banTime = new TimeSpan(0, 0, minute * 60 + hour * 3600 + day * 86400);

                    //封禁
                    string operatedMessage = "";
                    foreach (Match qq in beingOperatedQQ)
                    {
                        long operatedQQ = Convert.ToInt64(qq.ToString());
                        operatedMessage += EnApi.Instance.CqCode_At(operatedQQ);
                        EnApi.Instance.SetGroupBanSpeak(e.FromGroup, operatedQQ, banTime);
                    }

                    EnApi.Instance.SendGroupMessage(e.FromGroup, operatedMessage + "已被禁言");
                }
                else
                {
                    EnApi.Instance.SendGroupMessage(e.FromGroup, EnApi.Instance.CqCode_At(e.FromQQ) + "你需要先告诉我禁言多长时间");
                }
            }
            else
            {
                EnApi.Instance.SendGroupMessage(e.FromGroup, EnApi.Instance.CqCode_At(e.FromQQ) + "你需要先告诉我禁言谁");
            }
        }

        //解禁
        public static void UnBanGroupSpeak(GroupMessageEventArgs e)
        {
            //判断是否有禁言目标
            if (e.Msg.Contains("CQ:at"))
            {
                MatchCollection beingOperatedQQ = Regex.Matches(e.Msg, @"(?<=\[CQ:at,qq=)([0-9]*)(?=])");

                //解禁
                string operatedMessage = "";
                foreach (Match qq in beingOperatedQQ)
                {
                    long operatedQQ = Convert.ToInt64(qq.ToString());
                    operatedMessage += EnApi.Instance.CqCode_At(operatedQQ);
                    EnApi.Instance.SetGroupBanSpeak(e.FromGroup, operatedQQ, TimeSpan.Zero);
                }

                EnApi.Instance.SendGroupMessage(e.FromGroup, "已解除" + operatedMessage + "的禁言");
            }
            else
            {
                EnApi.Instance.SendGroupMessage(e.FromGroup, EnApi.Instance.CqCode_At(e.FromQQ) + "你需要先告诉我要解禁谁");
            }
        }
        #endregion

        #region == 头衔 ==
        //设置专属头衔
        public static void SetSpecialTitle(GroupMessageEventArgs e)
        {
            GroupMember BotMemberInfo;
            EnApi.Instance.GetMemberInfo(e.FromGroup, BotConfig.BotQQ, out BotMemberInfo);
            if (BotMemberInfo.PermitType == Native.Csharp.Sdk.Cqp.Enum.PermitType.Holder)
            {
                if (e.Msg.Contains("CQ:at"))
                {
                    MatchCollection beingOperatedQQ = Regex.Matches(e.Msg, @"(?<=\[CQ:at,qq=)([0-9]*)(?=])");

                    string title = e.Msg.Substring(e.Msg.IndexOf("设置专属头衔") + 6);
                    //替换掉冒号
                    title = title.Replace("：", "").Replace(":", "");

                    //去除首尾空格
                    title = title.Trim();
                    if (title.Length > 6)
                    {
                        title = title.Substring(0, 6);
                    }

                    //设置头衔
                    string operatedMessage = "";

                    TimeSpan forever = new TimeSpan(0, 0, -1);
                    foreach (Match qq in beingOperatedQQ)
                    {
                        long operatedQQ = Convert.ToInt64(qq.ToString());
                        operatedMessage += EnApi.Instance.CqCode_At(operatedQQ);
                        EnApi.Instance.SetGroupSpecialTitle(e.FromGroup, operatedQQ, title, forever);
                    }

                    EnApi.Instance.SendGroupMessage(e.FromGroup, "已经给成员" + operatedMessage + "设置了专属头衔：" + title);
                }
                else
                {
                    EnApi.Instance.SendGroupMessage(e.FromGroup, EnApi.Instance.CqCode_At(e.FromQQ) + "你需要先告诉我要给谁设置专属头衔");
                }
            } else
            {
                EnApi.Instance.SendGroupMessage(e.FromGroup, "本机不是群主，不能给成员设置专属头衔");
            }
        }

        //移除专属头衔
        public static void RemoveSpecialTitle(GroupMessageEventArgs e)
        {
            GroupMember BotMemberInfo;
            EnApi.Instance.GetMemberInfo(e.FromGroup, BotConfig.BotQQ, out BotMemberInfo);
            if (BotMemberInfo.PermitType == Native.Csharp.Sdk.Cqp.Enum.PermitType.Holder)
            {
                if (e.Msg.Contains("CQ:at"))
                {
                    MatchCollection beingOperatedQQ = Regex.Matches(e.Msg, @"(?<=\[CQ:at,qq=)([0-9]*)(?=])");

                    //移除头衔
                    string operatedMessage = "";

                    foreach (Match qq in beingOperatedQQ)
                    {
                        long operatedQQ = Convert.ToInt64(qq.ToString());
                        operatedMessage += EnApi.Instance.CqCode_At(operatedQQ);
                        EnApi.Instance.SetGroupSpecialTitle(e.FromGroup, operatedQQ, "", TimeSpan.Zero);
                    }

                    EnApi.Instance.SendGroupMessage(e.FromGroup, "已经移除了成员" + operatedMessage + "的专属头衔");
                }
                else
                {
                    EnApi.Instance.SendGroupMessage(e.FromGroup, EnApi.Instance.CqCode_At(e.FromQQ) + "你需要先告诉我要移除谁的头衔");
                }
            }
            else
            {
                EnApi.Instance.SendGroupMessage(e.FromGroup, "本机不是群主，不能移除成员的专属头衔");
            }
        }
        #endregion
    }
}
