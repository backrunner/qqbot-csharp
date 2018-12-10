using Native.Csharp.Sdk.Cqp.Api;
using Native.Csharp.Sdk.Cqp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Native.Csharp.App.Model;
using BackRunner.QQBot;
using BackRunner.QQBot.Utils;
using System.Windows;
using System.Text.RegularExpressions;

namespace Native.Csharp.App.Event
{
    public class Event_GroupMessage
    {
        #region --字段--
        private static Lazy<Event_GroupMessage> _instance = new Lazy<Event_GroupMessage>(() => new Event_GroupMessage());
        #endregion

        #region --属性--
        /// <summary>
        /// 获取 Event_GroupMessage 实例对象
        /// </summary>
        public static Event_GroupMessage Instance { get => _instance.Value; }
        #endregion

        #region --构造函数--
        /// <summary>
        /// 隐藏构造函数
        /// </summary>
        private Event_GroupMessage()
        {

        }
        #endregion

        #region --公开方法--
        /// <summary>
        /// Type=2 群消息
        /// </summary>
        /// <param name="sender">触发此事件的对象</param>
        /// <param name="e">附加的参数</param>
        public void ReceiveGroupMessage(object sender, GroupMessageEventArgs e)
        {
            //本子程序会在酷Q【线程】中被调用，请注意使用对象等需要初始化(CoInitialize,CoUninitialize)。
            //这里处理消息

            //判断是否是@qqbot的消息
            if (e.Msg.IndexOf("[CQ:at,qq=" + BotConfig.BotQQ.ToString() + "]") == 0)
            {
                //将@qqbot的部分过滤掉
                Regex atBotPattern = new Regex(@"\[CQ:at,qq=" + BotConfig.BotQQ.ToString() + "]");
                e.Msg = atBotPattern.Replace(e.Msg, "", 1);
                e.Msg = e.Msg.Trim();

                if (e.FromAnonymous != null)    //如果此属性不为null, 则消息来自于匿名成员
                {
                    //匿名消息处理示例
                    //EnApi.Instance.SendGroupMessage(e.FromGroup, e.FromAnonymous.CodeName + " 你发送了这样的消息: " + e.Msg);

                    //匿名消息处理
                    ProcessGroupMessage(e, true);

                    e.Handled = true;
                    return;
                }
                else
                {
                    //非匿名消息处理示例
                    //EnApi.Instance.SendGroupMessage(e.FromGroup, EnApi.Instance.CqCode_At(e.FromQQ) + "你发送了这样的消息: " + e.Msg);

                    //非匿名消息处理
                    ProcessGroupMessage(e, false);
                    e.Handled = true;
                    return;
                }
            }
        }

        /// <summary>
		/// 处理群消息
		/// </summary>
        private void ProcessGroupMessage(GroupMessageEventArgs e, bool isAnnoymous)
        {
            if (!isAnnoymous)
            {
                //普通消息
                #region === 管理功能 ===
                GroupMember fromMember;
                EnApi.Instance.GetMemberInfo(e.FromGroup, e.FromQQ, out fromMember);
                //验证是否有管理权限
                if (fromMember.PermitType == Sdk.Cqp.Enum.PermitType.Manage || fromMember.PermitType == Sdk.Cqp.Enum.PermitType.Holder)
                {
                    //管理权限

                    //禁言
                    #region == 禁言 ==
                    if (e.Msg.Contains("禁言")||e.Msg.Contains("封禁"))
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
                                    day = ChineseNumberConverter.Convert2Number(day.ToString());
                                } else
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

                            TimeSpan banTime = new TimeSpan(0, 0, minute*60+hour*3600+day*86400);

                            //封禁
                            string operatedMessage = "";
                            foreach (Match qq in beingOperatedQQ) {
                                long operatedQQ = Convert.ToInt64(qq.ToString());
                                operatedMessage += EnApi.Instance.CqCode_At(operatedQQ);
                                EnApi.Instance.SetGroupBanSpeak(e.FromGroup, operatedQQ, banTime);
                            }

                            EnApi.Instance.SendGroupMessage(e.FromGroup, operatedMessage+"已被禁言");
                        } else
                        {
                            EnApi.Instance.SendGroupMessage(e.FromGroup, EnApi.Instance.CqCode_At(e.FromQQ) + "你需要先告诉我禁言谁");
                        }
                    }
                    else if (e.Msg.Contains("解禁") || e.Msg.Contains("解封") || e.Msg.Contains("解除封禁") || e.Msg.Contains("解除禁言"))
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

                            EnApi.Instance.SendGroupMessage(e.FromGroup, "已解除"+operatedMessage + "的禁言");
                        }
                        else
                        {
                            EnApi.Instance.SendGroupMessage(e.FromGroup, EnApi.Instance.CqCode_At(e.FromQQ) + "你需要先告诉我要解禁谁");
                        }
                    }
                    #endregion
                }
                else
                {
                    //普通成员权限
                    
                }
                #endregion
            }
            else
            {
                //匿名消息
            }
            
        }

        /// <summary>
        /// Type=11 群文件上传事件
        /// </summary>
        /// <param name="sender">触发此事件的对象</param>
        /// <param name="e">附加的参数</param>
        public void ReceiveGroupFileUpload(object sender, FileUploadMessageEventArgs e)
        {
            //本子程序会在酷Q【线程】中被调用，请注意使用对象等需要初始化(CoInitialize,CoUninitialize)。
            //这里处理消息
            //关于文件信息, 触发事件时已经转换完毕, 请直接使用



            e.Handled = false;   //关于返回说明, 请参见 "Event_ReceiveMessage.ReceiveFriendMessage" 方法
        }

        /// <summary>
        /// Type=101 群事件-管理员增加
        /// </summary>
        /// <param name="sender">触发此事件的对象</param>
        /// <param name="e">附加的参数</param>
        public void ReceiveGroupManageIncrease(object sender, GroupManageAlterEventArgs e)
        {
            //本子程序会在酷Q【线程】中被调用，请注意使用对象等需要初始化(CoInitialize,CoUninitialize)。
            //这里处理消息            

            e.Handled = false;  //关于返回说明, 请参见 "Event_ReceiveMessage.ReceiveFriendMessage" 方法
        }

        /// <summary>
        /// Type=101 群事件-管理员减少
        /// </summary>
        /// <param name="sender">触发此事件的对象</param>
        /// <param name="e">附加的参数</param>
        public void ReceiveGroupManageDecrease(object sender, GroupManageAlterEventArgs e)
        {
            //本子程序会在酷Q【线程】中被调用，请注意使用对象等需要初始化(CoInitialize,CoUninitialize)。
            //这里处理消息


            e.Handled = false;  //关于返回说明, 请参见 "Event_ReceiveMessage.ReceiveFriendMessage" 方法
        }

        /// <summary>
        /// Type=103 群事件-群成员增加 - 主动入群
        /// </summary>
        /// <param name="sender">触发此事件的对象</param>
        /// <param name="e">附加的参数</param>
        public void ReceiveGroupMemberJoin(object sender, GroupMemberAlterEventArgs e)
        {
            //本子程序会在酷Q【线程】中被调用，请注意使用对象等需要初始化(CoInitialize,CoUninitialize)。
            //这里处理消息

            //发送入群欢迎消息（仅对30秒内的消息有效）
            if (e.BeingOperateQQ != BotConfig.BotQQ && (DateTime.Now - e.SendTime).TotalSeconds <= 30)
            {
                EnApi.Instance.SendGroupMessage(e.FromGroup, EnApi.Instance.CqCode_At(e.BeingOperateQQ) + BotConfig.WelcomeMsg);
            }

            e.Handled = true;  //关于返回说明, 请参见 "Event_ReceiveMessage.ReceiveFriendMessage" 方法
        }

        /// <summary>
        /// Type=103 群事件-群成员增加 - 被邀请入群
        /// </summary>
        /// <param name="sender">触发此事件的对象</param>
        /// <param name="e">附加的参数</param>
        public void ReceiveGroupMemberInvitee(object sender, GroupMemberAlterEventArgs e)
        {
            //本子程序会在酷Q【线程】中被调用, 请注意使用对象等需要初始化(ConIntialize, CoUninitialize).
            //这里处理消息

            //发送入群欢迎消息（仅对30秒内的消息有效）
            if (e.BeingOperateQQ != BotConfig.BotQQ && (DateTime.Now - e.SendTime).TotalSeconds <= 30)
            {
                EnApi.Instance.SendGroupMessage(e.FromGroup, EnApi.Instance.CqCode_At(e.BeingOperateQQ) + BotConfig.WelcomeMsg);
            }

            e.Handled = true;  //关于返回说明, 请参见 "Event_ReceiveMessage.ReceiveFriendMessage" 方法
        }

        /// <summary>
        /// Type=102 群事件-群成员减少 - 成员离开
        /// </summary>
        /// <param name="sender">触发此事件的对象</param>
        /// <param name="e">附加的参数</param>
        public void ReceiveGroupMemberLeave(object sender, GroupMemberAlterEventArgs e)
        {
            //本子程序会在酷Q【线程】中被调用, 请注意使用对象等需要初始化(ConIntialize, CoUninitialize).
            //这里处理消息



            e.Handled = false;  //关于返回说明, 请参见 "Event_ReceiveMessage.ReceiveFriendMessage" 方法
        }

        /// <summary>
        /// Type=102 群事件-群成员减少 - 成员移除
        /// </summary>
        /// <param name="sender">触发此事件的对象</param>
        /// <param name="e">附加的参数</param>
        public void ReceiveGroupMemberRemove(object sender, GroupMemberAlterEventArgs e)
        {
            //本子程序会在酷Q【线程】中被调用, 请注意使用对象等需要初始化(ConIntialize, CoUninitialize).
            //这里处理消息



            e.Handled = false;  //关于返回说明, 请参见 "Event_ReceiveMessage.ReceiveFriendMessage" 方法
        }

        /// <summary>
        /// Type=302 请求-群添加 - 申请入群
        /// </summary>
        /// <param name="sender">触发此事件的对象</param>
        /// <param name="e">附加的参数</param>
        public void ReceiveGroupAddApply(object sender, GroupAddRequestEventArgs e)
        {
            //本子程序会在酷Q【线程】中被调用, 请注意使用对象等需要初始化(ConIntialize, CoUninitialize).
            //这里处理消息



            e.Handled = false;  //关于返回说明, 请参见 "Event_ReceiveMessage.ReceiveFriendMessage" 方法
        }

        /// <summary>
        /// Type=302 请求-群添加 - (酷Q登录号)被邀请入群
        /// </summary>
        /// <param name="sender">触发此事件的对象</param>
        /// <param name="e">附加的参数</param>
        public void ReceiveGroupAddInvitee(object sender, GroupAddRequestEventArgs e)
        {
            //本子程序会在酷Q【线程】中被调用, 请注意使用对象等需要初始化(ConIntialize, CoUninitialize).
            //这里处理消息



            e.Handled = false;  //关于返回说明, 请参见 "Event_ReceiveMessage.ReceiveFriendMessage" 方法
        }
        #endregion
    }
}
