using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Native.Csharp.App.Model;
using BackRunner.QQBot;
using BackRunner.QQBot.Utils;
using BackRunner.QQBot.Processors;
using System.Windows;
using System.Text.RegularExpressions;
using BackRunner.QQBot.Controller;
using Native.Csharp.Sdk.Cqp.Model;

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
		public static Event_GroupMessage Instance { get { return _instance.Value; } }
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
            if (e.Msg.IndexOf("[CQ:at,qq=" + SettingsController.settings.BotQQ.ToString() + "]") == 0)
            {
                #region == 包含@机器人的消息 ==
                //将@qqbot的部分过滤掉
                Regex atBotPattern = new Regex(@"\[CQ:at,qq=" + SettingsController.settings.BotQQ.ToString() + "]");
                e.Msg = atBotPattern.Replace(e.Msg, "", 1);
                e.Msg = e.Msg.Trim();

                if (e.FromAnonymous != null)    //如果此属性不为null, 则消息来自于匿名成员
                {
                    //匿名消息处理示例
                    //Common.CqApi.SendGroupMessage(e.FromGroup, e.FromAnonymous.CodeName + " 你发送了这样的消息: " + e.Msg);

                    //匿名消息处理
                    ProcessGroupMessage(e, true);

                    e.Handled = true;
                    return;
                }
                else
                {
                    //非匿名消息处理示例
                    //Common.CqApi.SendGroupMessage(e.FromGroup, Common.CqApi.CqCode_At(e.FromQQ) + "你发送了这样的消息: " + e.Msg);

                    //非匿名消息处理
                    ProcessGroupMessage(e, false);
                    e.Handled = true;
                    return;
                }
                #endregion
            }
            else
            {
                #region == 普通消息 ==
                //普通消息
                //将多余的空格过滤掉
                e.Msg = e.Msg.Trim();

                //交由复读处理器处理消息
                if (SettingsController.settings.AutoRepeat)
                {
                    RepeatProcessor.Process(e);
                }
                e.Handled = true;
                #endregion
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
                Common.CqApi.GetMemberInfo(e.FromGroup, e.FromQQ, out fromMember);
                //验证是否有管理权限
                if (fromMember.PermitType == Sdk.Cqp.Enum.PermitType.Manage || fromMember.PermitType == Sdk.Cqp.Enum.PermitType.Holder)
                {
                    //管理权限
                    #region == 禁言 ==
                    //全体禁言
                    if (e.Msg.Contains("开启全体禁言"))
                    {
                        Common.CqApi.SetGroupWholeBanSpeak(e.FromGroup, true);
                        Common.CqApi.SendGroupMessage(e.FromGroup, "全体禁言已开启。");

                    }
                    //解除全体禁言
                    else if (e.Msg.Contains("解除全体禁言"))
                    {
                        Common.CqApi.SetGroupWholeBanSpeak(e.FromGroup, false);
                        Common.CqApi.SendGroupMessage(e.FromGroup, "全体禁言已解除。");
                    }
                    //禁言
                    else if (e.Msg.Contains("禁言") || e.Msg.Contains("封禁"))
                    {
                        GroupManageProcessor.BanGroupSpeak(e);
                    }
                    //解除禁言
                    else if (e.Msg.Contains("解禁") || e.Msg.Contains("解封"))
                    {
                        GroupManageProcessor.UnBanGroupSpeak(e);
                    }
                    #endregion

                    #region == 头衔 ==
                    else if (e.Msg.Contains("设置专属头衔"))
                    {
                        GroupManageProcessor.SetSpecialTitle(e);
                    }
                    else if ((e.Msg.Contains("移除") && e.Msg.Contains("的专属头衔")) || e.Msg.Contains("移除专属头衔"))
                    {
                        GroupManageProcessor.RemoveSpecialTitle(e);
                    }
                    #endregion
                }
                else
                {
                    //普通成员权限
                    
                }
                #endregion

                //不分权限均予以执行
                if (e.Msg.Contains("复读") && e.Msg.IndexOf("复读") == 0 && !e.Msg.Contains("复读机"))
                {
                    if (e.Msg.IndexOf("复读一下") == 0)
                    {
                        e.Msg = e.Msg.Substring(4);
                    } else if (e.Msg.IndexOf("复读：") == 0 || e.Msg.IndexOf("复读:") == 0)
                    {
                        e.Msg = e.Msg.Substring(3);
                    } else
                    {
                        e.Msg = e.Msg.Substring(2);
                    }
                    RepeatProcessor.ManualRepeat(e);
                }
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
            if (e.BeingOperateQQ != SettingsController.settings.BotQQ && (DateTime.Now - e.SendTime).TotalSeconds <= 30)
            {
                Common.CqApi.SendGroupMessage(e.FromGroup, Common.CqApi.CqCode_At(e.BeingOperateQQ) + SettingsController.settings.GroupWelcomeMessage);
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
            if (e.BeingOperateQQ != SettingsController.settings.BotQQ && (DateTime.Now - e.SendTime).TotalSeconds <= 30)
            {
                Common.CqApi.SendGroupMessage(e.FromGroup, Common.CqApi.CqCode_At(e.BeingOperateQQ) + SettingsController.settings.GroupWelcomeMessage);
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
